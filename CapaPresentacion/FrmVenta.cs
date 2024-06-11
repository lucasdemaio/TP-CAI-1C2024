using Datos;
using Negocio;
using Negocio.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmVenta : Form
    {
        private int perfilUsuario;
        private Guid guidUsuario;
        string userLogueado = UsuarioLogueado.NombreUsuario;
        private ProductoNegocio productoNegocio = new ProductoNegocio();
        private ClienteNegocio clienteNegocio = new ClienteNegocio();
        private VentaNegocio ventaNegocio = new VentaNegocio();
        private UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        private List<ProductoDatos> carrito = new List<ProductoDatos>();        
        private FrmComprobante frmComprobante;


        public FrmVenta(int perfilUsuario, FrmComprobante frmComprobante)
        {
            InitializeComponent();
            this.FormClosing += FrmVenta_FormClosing;
            this.perfilUsuario = perfilUsuario;
            this.frmComprobante = frmComprobante;

            listCarrito.View = View.Details;
            listCarrito.FullRowSelect = true;
            listCarrito.GridLines = true;
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
            listCarrito.Columns.Add("Producto", 400);
            listCarrito.Columns.Add("Precio", 100);
            listCarrito.Columns.Add("Cantidad", 100);
        }

        private void FrmVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain(perfilUsuario);
            frmMain.Show();
            this.Hide();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            lblAlertaCarrito.Visible = false;
            lblAlertaVenta.Visible = false;
            cargarProductos();
            cargarClientes();            
        }

        private void cargarProductos()
        {
            List<ProductoDatos> productos = productoNegocio.listarProductos();

            productos = productos.OrderBy(p => p.Nombre).ToList();

            var bindingList = new BindingList<ProductoDatos>(productos);
            var source = new BindingSource(bindingList, null);
            dataGridViewProducto.DataSource = source;
            dataGridViewProducto.Columns["Id"].Visible = false;
            dataGridViewProducto.Columns["FechaBaja"].Visible = false;
            dataGridViewProducto.Columns["IdUsuario"].Visible = false;
            dataGridViewProducto.Columns["IdProveedor"].Visible = false;
            dataGridViewProducto.Columns["Cantidad"].Visible = false;
            dataGridViewProducto.Columns["Cantidad"].Visible = false;
            dataGridViewProducto.Columns["NombreProveedor"].Visible = false;
            dataGridViewProducto.Columns["ApellidoProveedor"].Visible = false;
            dataGridViewProducto.CellFormatting += dataGridViewProducto_CellFormatting;

            dataGridViewProducto.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void dataGridViewProducto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewProducto.Columns[e.ColumnIndex].Name == "Precio")
            {
                if (e.Value != null && double.TryParse(e.Value.ToString(), out double precio))
                {
                    e.Value = precio.ToString("C");
                    e.FormattingApplied = true;
                }
            }
        }

        private void cargarClientes()
        {
            List<Cliente> clientes = clienteNegocio.listarClientes();

            clientes = clientes.OrderBy(c => c.Apellido).ToList();

            cbCliente.DataSource = clientes;
            cbCliente.DisplayMember = "NombreCompleto";
            cbCliente.ValueMember = "Id";
            cbCliente.SelectedIndex = -1;
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {      
            if (cbCliente.SelectedIndex != -1)
            {
                Cliente clienteSeleccionado = cbCliente.SelectedItem as Cliente;
                if (clienteSeleccionado != null)
                {
                    Guid idCliente = clienteSeleccionado.Id;
                    bool esPrimeraCompra = ventaNegocio.EsClienteNuevo(idCliente);
                    lblClienteNuevo.Visible = esPrimeraCompra;
                    if (esPrimeraCompra)
                    {
                        lblClienteNuevo.Text = "Descuento primera compra: 5%";
                    }
                }
            }
            else
            {
                lblClienteNuevo.Visible = false;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listCarrito.SelectedItems.Count == 0)
            {
                lblAlertaCarrito.Visible = true;
                lblAlertaCarrito.ForeColor = Color.Red;
                lblAlertaCarrito.Text = "Seleccione un producto para remover del carrito."; 
                return;
            }

            var itemSeleccionado = listCarrito.SelectedItems[0];
            ProductoDatos productoSeleccionado = itemSeleccionado.Tag as ProductoDatos;

            if (productoSeleccionado == null)
            {
                lblAlertaCarrito.Visible = true;
                lblAlertaCarrito.ForeColor = Color.Red;
                lblAlertaCarrito.Text = "Error: No se pudo obtener el producto seleccionado. Intente nuevamente.";
                return;
            }

            carrito.Remove(productoSeleccionado);

            var productoOriginal = productoNegocio.listarProductos().FirstOrDefault(p => p.Id == productoSeleccionado.Id);
            if (productoOriginal != null)
            {
                productoOriginal.Stock += 1;
            }
            actualizarCarrito();
            actualizarDataGridViewProductos();
            lblAlertaCarrito.Visible = true;
            lblAlertaCarrito.ForeColor = Color.Green;
            lblAlertaCarrito.Text = "Producto Removido del carrito";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lblalertaVentas.Visible = false;

            if (cbCliente.SelectedItem == null)
            {
                lblAlertaCarrito.Visible = true;
                lblAlertaCarrito.ForeColor = Color.Red;
                lblAlertaCarrito.Text = "Debe seleccionar el cliente antes de agregar productos.";
                return;
            }

            if (dataGridViewProducto.SelectedRows.Count == 0)
            {
                lblAlertaCarrito.Visible = true;
                lblAlertaCarrito.ForeColor = Color.Red;
                lblAlertaCarrito.Text = "Seleccione la fila del producto para agregar al carrito.";
                return;
            }

            var filaSeleccionada = dataGridViewProducto.SelectedRows[0];
            ProductoDatos productoSeleccionado = (ProductoDatos)filaSeleccionada.DataBoundItem;

            int cantidadSeleccionada = (int)numericUpDownCantidad.Value;

            if (cantidadSeleccionada > productoSeleccionado.Stock)
            {
                lblAlertaCarrito.Visible = true;
                lblAlertaCarrito.ForeColor = Color.Red;
                lblAlertaCarrito.Text = "No hay suficiente stock disponible para la cantidad seleccionada.";
                return;
            }

            productoSeleccionado.Stock -= cantidadSeleccionada;

            for (int i = 0; i < cantidadSeleccionada; i++)
            {
                carrito.Add(new ProductoDatos
                {
                    Id = productoSeleccionado.Id,
                    Nombre = productoSeleccionado.Nombre,
                    Precio = productoSeleccionado.Precio,
                    Stock = productoSeleccionado.Stock,
                    IdCategoria = productoSeleccionado.IdCategoria,
                    IdProveedor = productoSeleccionado.IdProveedor,
                    Cantidad = cantidadSeleccionada
                });
            }

            lblAlertaCarrito.Text = "";
            lblAlertaCarrito.Visible = false;

            actualizarCarrito();
            actualizarDataGridViewProductos();
        }

        private void actualizarCarrito()
        {
            listCarrito.Items.Clear();

            var productosAgrupados = carrito.GroupBy(p => p.Id)
                                            .Select(g => new
                                            {
                                                Producto = g.First(),
                                                Cantidad = g.Sum(p => p.Cantidad)
                                            }).ToList();

            double totalSinDescuentos = productosAgrupados.Sum(p => p.Producto.Precio * p.Cantidad);
            bool esPrimeraCompra = false;
            double descuentoPrimeraCompra = 0;

            if (cbCliente.SelectedItem != null)
            {
                Guid clienteId = ((Cliente)cbCliente.SelectedItem).Id;
                esPrimeraCompra = ventaNegocio.EsClienteNuevo(clienteId);
                if (esPrimeraCompra)
                {
                    descuentoPrimeraCompra = totalSinDescuentos * 0.05;
                }
            }

            var (totalConDescuento, descuentoElectroHogar) = ventaNegocio.CalcularTotalConDescuento(productosAgrupados.Select(p =>
            {
                var producto = p.Producto;
                producto.Cantidad = p.Cantidad;
                return producto;
            }).ToList(), esPrimeraCompra);

            totalConDescuento = totalSinDescuentos - descuentoElectroHogar - descuentoPrimeraCompra;

            foreach (var item in productosAgrupados)
            {
                var producto = item.Producto;
                var cantidad = item.Cantidad;

                var listViewItem = new ListViewItem(producto.Nombre);
                listViewItem.Tag = producto;
                listViewItem.SubItems.Add(producto.Precio.ToString("C"));
                listViewItem.SubItems.Add(cantidad.ToString());
                listCarrito.Items.Add(listViewItem);
            }

            lblTotal.Text = $"Total: {totalConDescuento:C}";

            if (esPrimeraCompra)
            {
                lblClienteNuevo.Visible = true;
                lblClienteNuevo.Text = $"Descuento primera compra: {descuentoPrimeraCompra:C}";
            }
            else
            {
                lblClienteNuevo.Visible = false;
            }

            if (descuentoElectroHogar > 0)
            {
                lblAlertadecuentoCatElectroHogar.Visible = true;
                lblAlertadecuentoCatElectroHogar.Text = $"Se aplicó un 5% de descuento sobre productos de Electro Hogar de {descuentoElectroHogar:C}";
            }
            else
            {
                lblAlertadecuentoCatElectroHogar.Visible = false;
            }
        }
        private void actualizarDataGridViewProductos()
        {
            dataGridViewProducto.Refresh();
        }

        private void btnCompletarVenta_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios = usuarioNegocio.listarUsuarios();
            Usuario usuario = usuarios.FirstOrDefault(u => u.NombreUsuario == userLogueado);

            guidUsuario = usuario.id;
            string guidUsuarioString = guidUsuario.ToString();

            if (carrito.Count == 0)
            {
                lblalertaVentas.Text = "El carrito está vacío.";
                return;
            }

            Cliente clienteSeleccionado = cbCliente.SelectedItem as Cliente;
            if (clienteSeleccionado == null)
            {
                lblalertaVentas.Text = "Seleccione un cliente.";
                return;
            }

            Guid idCliente = clienteSeleccionado.Id;

            var productosAgrupados = carrito.GroupBy(p => p.Id)
                                             .Select(g => new
                                             {
                                                 Producto = g.First(),
                                                 Cantidad = g.Sum(p => p.Cantidad)
                                             }).ToList();

            bool esPrimeraCompra = ventaNegocio.EsClienteNuevo(clienteSeleccionado.Id);

            DateTime fechaVenta = DateTime.Now;

            foreach (var item in productosAgrupados)
            {
                var producto = item.Producto;
                var cantidadVendida = item.Cantidad;
                double montoTotal = producto.Precio * cantidadVendida;

                VentaAlta venta = new VentaAlta(idCliente.ToString(), guidUsuarioString, producto.Id.ToString(), cantidadVendida, montoTotal, fechaVenta);
                ventaNegocio.AgregarVenta(venta);

                productoNegocio.ActualizarProductoEnJson(producto.Nombre, producto.Precio, -cantidadVendida);
            }

            var productosListos = productosAgrupados.Select(g => (g.Producto, g.Cantidad)).ToList();

            double totalSinDescuentos = productosListos.Sum(p => p.Producto.Precio * p.Cantidad);
            double descuentoPrimeraCompra = esPrimeraCompra ? totalSinDescuentos * 0.05 : 0;

            lblalertaVentas.Text = "Venta completada con éxito.";
            GenerarComprobante(clienteSeleccionado, productosListos, descuentoPrimeraCompra);

            carrito.Clear();
            actualizarCarrito();
            cargarProductos();
        }

        private void GenerarComprobante(Cliente cliente, List<(ProductoDatos Producto, int Cantidad)> productosAgrupados, double descuentoPrimeraCompra)
        {
            FrmComprobante frmComprobante = new FrmComprobante();

            frmComprobante.txtCliente.Text = cliente.NombreCompleto;
            frmComprobante.txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        
            frmComprobante.dataGridViewDetalles.DataSource = productosAgrupados.Select(p => new
            {
                Descripción = p.Producto.Nombre,
                Cantidad = p.Cantidad,
                MontoUnitario = p.Producto.Precio.ToString("C"),
                MontoTotal = (p.Producto.Precio * p.Cantidad).ToString("C")
            }).ToList();

            double totalSinDescuentos = productosAgrupados.Sum(p => p.Producto.Precio * p.Cantidad);
            double descuentoElectroHogar = ventaNegocio.CalcularDescuentoElectroHogar(productosAgrupados.Select(p =>
            {
                var producto = p.Producto;
                producto.Cantidad = p.Cantidad;
                return producto;
            }).ToList());
            
            double totalConDescuento = totalSinDescuentos - descuentoElectroHogar - descuentoPrimeraCompra;

            frmComprobante.txtTotalAPagar.Text = totalConDescuento.ToString("C");
            frmComprobante.txtDescuento.Text = (descuentoElectroHogar + descuentoPrimeraCompra).ToString("C");

            List<dynamic> promociones = new List<dynamic>();
            if (descuentoPrimeraCompra > 0)
            {
                promociones.Add(new { Promoción = "Descuento primera compra", Monto = descuentoPrimeraCompra.ToString("C") });
            }
            if (descuentoElectroHogar > 0)
            {
                promociones.Add(new { Promoción = "Descuento 5% productos de ElectroHogar", Monto = descuentoElectroHogar.ToString("C") });
            }

            frmComprobante.dataGridViewPromociones.DataSource = promociones;

            frmComprobante.ShowDialog();
        }
    }
}
