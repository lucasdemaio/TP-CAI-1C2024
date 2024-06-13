using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmProducto : Form
    {
        private int perfilUsuario;
        int idCategoria;
        string idProveedor;
        string nombreProveedor;
        string apellidoProveedor;
        private ProductoNegocio productoNegocio = new ProductoNegocio();
        private ProveedoresNegocio proveedorNegocio = new ProveedoresNegocio();
        private UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        private Guid guidUsuario;
        string userLogueado = UsuarioLogueado.NombreUsuario;
        private bool stockModificado = false;
        Guid idProductoReactivar;


        public FrmProducto(int perfilUsuario)
        {
            InitializeComponent();
            this.FormClosing += FrmProducto_FormClosing;
            this.perfilUsuario = perfilUsuario;
        }

        private void FrmProducto_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            btnConfirmarModificacion.Visible = false;
            btnCancelarModificacion.Visible = false;
            productoNegocio.InicializarProductosDesdeAPI();
            cargarProductos();
            cargarProveedores();
            cargarCategorias();
            ConfigurarListViewProductosBaja();
            CargarProductosDadosDeBajaEnListView();
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
            dataGridViewProducto.Columns["NombreProveedor"].Visible = false;
            dataGridViewProducto.Columns["ApellidoProveedor"].Visible = false;
            dataGridViewProducto.CellFormatting += DataGridViewProducto_CellFormatting;
        }

        private void DataGridViewProducto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        private void dataGridViewProducto_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ProductoDatos productoSeleccionado = (ProductoDatos)dataGridViewProducto.Rows[dataGridViewProducto.CurrentCell.RowIndex].DataBoundItem;
            txtNombre.Text = productoSeleccionado.Nombre;
            txtPrecio.Text = productoSeleccionado.Precio.ToString();
            numericUpDownStock.Value = productoSeleccionado.Stock;

            checkBoxAudio.Checked = false;
            checkBoxCelulares.Checked = false;
            checkBoxElectro.Checked = false;
            checkBoxInformatica.Checked = false;
            checkBoxSmartTv.Checked = false;


            if (productoSeleccionado.IdCategoria == 1)
            {
                checkBoxAudio.Checked = true;
            }
            else if (productoSeleccionado.IdCategoria == 2)
            {
                checkBoxCelulares.Checked = true;
            }
            else if (productoSeleccionado.IdCategoria == 3)
            {
                checkBoxElectro.Checked = true;
            }
            else if (productoSeleccionado.IdCategoria == 4)
            {
                checkBoxInformatica.Checked = true;
            }
            else if (productoSeleccionado.IdCategoria == 5)
            {
                checkBoxSmartTv.Checked = true;
            }
        }

        private void btnEliminarProducto_Click_1(object sender, EventArgs e)
        {
            try
            {
                List<Usuario> usuarios = usuarioNegocio.listarUsuarios();
                Usuario usuario = usuarios.FirstOrDefault(u => u.NombreUsuario == userLogueado);

                guidUsuario = usuario.id;
                string guidUsuarioString = guidUsuario.ToString();

                if (dataGridViewProducto.CurrentRow == null)
                {
                    lblalertaProductos.ForeColor = Color.Red;
                    lblalertaProductos.Text = "Seleccione un producto para eliminar.";
                    return;
                }

                ProductoDatos productoSeleccionado = (ProductoDatos)dataGridViewProducto.Rows[dataGridViewProducto.CurrentRow.Index].DataBoundItem;

                string idProducto = productoSeleccionado.Id.ToString();
                string nombreProducto = productoSeleccionado.Nombre;

                productoNegocio.eliminarProducto(idProducto, guidUsuarioString, nombreProducto);

                cargarProductos();
                CargarProductosDadosDeBajaEnListView();

                lblalertaProductos.ForeColor = Color.Green;
                lblalertaProductos.Text = "Producto eliminado con éxito.";
                txtNombre.Text = "";
                txtPrecio.Text = "";
                numericUpDownStock.Value = numericUpDownStock.Minimum;
            }
            catch (Exception ex)
            {
                lblalertaProductos.ForeColor = Color.Red;
                lblalertaProductos.Text = "Se ha producido un error. Vuelva a intentarlo, \nsi persiste contacte a su administrador del Sistema.";

            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProducto.CurrentCell == null || dataGridViewProducto.CurrentRow == null)
                {
                    lblalertaProductos.ForeColor = Color.Red;
                    lblalertaProductos.Text = "Debe seleccionar un producto antes de modificar.";
                    return;
                }

                List<Usuario> usuarios = usuarioNegocio.listarUsuarios();
                Usuario usuario = usuarios.FirstOrDefault(u => u.NombreUsuario == userLogueado);

                guidUsuario = usuario.id;
                string guidUsuarioString = guidUsuario.ToString();

                ProductoDatos productoSeleccionado = (ProductoDatos)dataGridViewProducto.Rows[dataGridViewProducto.CurrentCell.RowIndex].DataBoundItem;

                string idProducto = productoSeleccionado.Id.ToString();
                string nombreProducto = productoSeleccionado.Nombre;

                if (!txtNombre.Text.Equals(nombreProducto, StringComparison.OrdinalIgnoreCase))
                {
                    lblalertaProductos.ForeColor = Color.Red;
                    lblalertaProductos.Text = "No se puede cambiar el Nombre del producto.";
                    return;
                }

                string precioTexto = txtPrecio.Text;
                if (!double.TryParse(precioTexto, out double precio))
                {
                    lblalertaProductos.ForeColor = Color.Red;
                    lblalertaProductos.Text = "Ingrese un precio válido.";
                    return;
                }

                int stock = (int)numericUpDownStock.Value;

                if (stock != productoSeleccionado.Stock || precio != productoSeleccionado.Precio)
                {
                    btnAltaProducto.Visible = false;
                    btnEliminarProducto.Visible = false;
                    btnModificarProducto.Visible = false;
                    btnConfirmarModificacion.Visible = true;
                    btnCancelarModificacion.Visible = true;
                    lblalertaProductos.ForeColor = Color.Blue;
                    lblalertaProductos.Text = "Confirme la modificación del producto. Tener en cuenta que el Stock ingresado \nse sumara al ya existente";
                }
                else
                {
                    lblalertaProductos.ForeColor = Color.Red;
                    lblalertaProductos.Text = "No se detectaron cambios en el producto.";
                }
            }
            catch (Exception ex)
            {
                lblalertaProductos.ForeColor = Color.Red;
                lblalertaProductos.Text = "Se ha producido un error. Vuelva a intentarlo, \nsi persiste contacte a su administrador del Sistema.";

            }
        }




        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            try
            {
                List<Usuario> usuarios = usuarioNegocio.listarUsuarios();
                Usuario usuario = usuarios.FirstOrDefault(u => u.NombreUsuario == userLogueado);

                string nombre = txtNombre.Text.Trim();
                string precioTexto = txtPrecio.Text.Trim();
                int stock = (int)numericUpDownStock.Value;
                guidUsuario = usuario.id;
                string guidUsuarioString = guidUsuario.ToString();

                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(precioTexto) || stock == 0)
                {
                    lblalertaProductos.Text = "Todos los campos son obligatorios.";
                    return;
                }

                if (!double.TryParse(precioTexto, out double precio))
                {
                    lblalertaProductos.Text = "Ingrese un precio válido.";
                    return;
                }

                if (dataGridViewProdProv.CurrentRow == null)
                {
                    lblalertaProductos.Text = "Debe seleccionar el Proveedor del Producto antes de dar de alta el mismo.";
                    return;
                }

                ProveedoresDatos proveedorSeleccionado = (ProveedoresDatos)dataGridViewProdProv.CurrentRow.DataBoundItem;
                string idProveedor = proveedorSeleccionado.Id.ToString();
                string nombreProveedor = proveedorSeleccionado.Nombre;
                string apellidoProveedor = proveedorSeleccionado.Apellido;

                bool existeProducto = false;
                foreach (DataGridViewRow row in dataGridViewProducto.Rows)
                {
                    if (row.Cells["Nombre"].Value?.ToString().Equals(nombre, StringComparison.OrdinalIgnoreCase) == true)
                    {
                        existeProducto = true;
                        break;
                    }
                }

                if (existeProducto)
                {
                    lblalertaProductos.ForeColor = Color.Red;
                    lblalertaProductos.Text = "El producto que quiere ingresar ya existe";
                    return;
                }

                int[] categoriasSeleccionadas = {
                checkBoxAudio.Checked ? 1 : 0,
                checkBoxCelulares.Checked ? 1 : 0,
                checkBoxElectro.Checked ? 1 : 0,
                checkBoxInformatica.Checked ? 1 : 0,
                checkBoxSmartTv.Checked ? 1 : 0
                };
                int cantidadCategorias = categoriasSeleccionadas.Count(c => c == 1);

                if (cantidadCategorias == 0)
                {
                    lblalertaProductos.ForeColor = Color.Red;
                    lblalertaProductos.Text = "Seleccione una categoría.";
                    return;
                }
                else if (cantidadCategorias > 1)
                {
                    lblalertaProductos.ForeColor = Color.Red;
                    lblalertaProductos.Text = "Solo puede elegir una categoría para el producto a dar de Alta.";
                    return;
                }

                int idCategoria = categoriasSeleccionadas.ToList().IndexOf(1) + 1;

                productoNegocio.agregarProducto(guidUsuarioString, idCategoria, idProveedor, nombreProveedor, apellidoProveedor, nombre, precio, stock);
                cargarProductos();

                lblalertaProductos.ForeColor = Color.Green;
                lblalertaProductos.Text = "Producto agregado con éxito.";
                txtNombre.Text = "";
                txtPrecio.Text = "";
                numericUpDownStock.Value = 0;
                checkBoxAudio.Checked = false;
                checkBoxCelulares.Checked = false;
                checkBoxElectro.Checked = false;
                checkBoxInformatica.Checked = false;
                checkBoxSmartTv.Checked = false;
            }
            catch (Exception ex)
            {
                lblalertaProductos.ForeColor = Color.Red;
                lblalertaProductos.Text = "Se ha producido un error. Vuelva a intentarlo, \nsi persiste contacte a su administrador del Sistema.";
            }
        }
        private void cargarProveedores()
        {
            List<ProveedoresDatos> proveedores = proveedorNegocio.listarProveedores();

            proveedores = proveedores.OrderBy(c => c.Apellido).ToList();

            var bindingList = new BindingList<ProveedoresDatos>(proveedores);
            var source = new BindingSource(bindingList, null);
            dataGridViewProdProv.DataSource = source;
            dataGridViewProdProv.Columns["Id"].Visible = false;
            dataGridViewProdProv.Columns["FechaAlta"].Visible = false;
            dataGridViewProdProv.Columns["FechaBaja"].Visible = false;
            dataGridViewProdProv.Columns["Email"].Visible = false;
            dataGridViewProdProv.Columns["IdUsuario"].Visible = false;
        }

        private void dataGridViewProdProv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProveedoresDatos proveedorSeleccionado = (ProveedoresDatos)dataGridViewProdProv.Rows[dataGridViewProdProv.CurrentCell.RowIndex].DataBoundItem;
            idProveedor = proveedorSeleccionado.Id.ToString();
            nombreProveedor = proveedorSeleccionado.Nombre;
            apellidoProveedor = proveedorSeleccionado.Apellido;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            numericUpDownStock.Value = 0;
            checkBoxAudio.Checked = false;
            checkBoxCelulares.Checked = false;
            checkBoxElectro.Checked = false;
            checkBoxInformatica.Checked = false;
            checkBoxSmartTv.Checked = false;
        }

        private void CargarProductosDadosDeBajaEnListView()
        {
            try
            {
                var productosDadosDeBaja = productoNegocio.LeerProductosDadosDeBaja();

                var productosOrdenados = productosDadosDeBaja.OrderBy(p => p.Nombre).ToList();

                listViewProductosBaja.Items.Clear();

                foreach (var producto in productosOrdenados)
                {
                    var row = new string[]
                    {
                producto.Nombre,
                producto.Stock.ToString(),
                producto.FechaBaja?.ToString("dd/MM/yyyy") ?? string.Empty
                    };
                    var listViewItem = new ListViewItem(row)
                    {
                        Tag = producto.Id
                    };
                    listViewProductosBaja.Items.Add(listViewItem);
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al leer los datos: " + ex.Message);
            }
        }

        private void cargarCategorias()
        {
            var categorias = Enum.GetValues(typeof(CategoriaProducto))
                                 .Cast<CategoriaProducto>()
                                 .Select(c => new
                                 {
                                     Name = c.ToString(),
                                     Value = (int)c
                                 })
                                 .ToList();
            cbProductosporCategoria.DataSource = categorias;
            cbProductosporCategoria.DisplayMember = "Name";
            cbProductosporCategoria.ValueMember = "Value";
            cbProductosporCategoria.SelectedIndex = -1;

            cbProductosporCategoria.SelectedIndexChanged += cbProductosporCategoria_SelectedIndexChanged;
        }


        private void cbProductosporCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProductosporCategoria.SelectedIndex != -1 && cbProductosporCategoria.SelectedValue != null)
            {
                if (cbProductosporCategoria.SelectedValue is int categoriaSeleccionada)
                {
                    var productos = productoNegocio.GetProductosPorCategoria(categoriaSeleccionada);
                    productos = productos.OrderBy(p => p.Nombre).ToList();
                    dataGridViewProductoporCategoria.DataSource = productos;

                    dataGridViewProductoporCategoria.Columns["Id"].Visible = false;
                    dataGridViewProductoporCategoria.Columns["IdCategoria"].Visible = false;
                    dataGridViewProductoporCategoria.Columns["IdUsuario"].Visible = false;
                    dataGridViewProductoporCategoria.Columns["IdProveedor"].Visible = false;
                    dataGridViewProductoporCategoria.Columns["Cantidad"].Visible = false;
                    dataGridViewProductoporCategoria.Columns["NombreProveedor"].Visible = false;
                    dataGridViewProductoporCategoria.Columns["ApellidoProveedor"].Visible = false;
                    dataGridViewProductoporCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        private void ConfigurarListViewProductosBaja()
        {
            listViewProductosBaja.Columns.Clear();
            listViewProductosBaja.View = View.Details;
            listViewProductosBaja.View = View.Details;
            listViewProductosBaja.Columns.Add("Nombre del Producto", 400);
            listViewProductosBaja.Columns.Add("Stock", 50);
            listViewProductosBaja.Columns.Add("Fecha de Baja", 200);
        }

        private void dataGridViewProductoporCategoria_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewProductoporCategoria.Columns[e.ColumnIndex].Name == "Precio")
            {
                if (e.Value != null && double.TryParse(e.Value.ToString(), out double precio))
                {
                    e.Value = precio.ToString("C");
                    e.FormattingApplied = true;
                }
            }
        }
        private void numericUpDownStock_ValueChanged(object sender, EventArgs e)
        {
            stockModificado = true;
        }

        private void listViewProductosBaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProductosBaja.SelectedItems.Count > 0)
            {
                var selectedItem = listViewProductosBaja.SelectedItems[0];
                idProductoReactivar = (Guid)selectedItem.Tag;
            }
        }

        private void linkLblReactivarProductos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MostrarGroupBox(groupBoxProductosBaja);
        }

        private void linkLabelProductosporCategoria_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MostrarGroupBox(groupBoxProdporCategoria);
        }

        private void linkLabelStock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MostrarGroupBox(groupBoxStock);
        }
        private void MostrarGroupBox(GroupBox groupBoxToShow)
        {
            groupBoxProductosBaja.Visible = false;
            groupBoxProdporCategoria.Visible = false;
            groupBoxStock.Visible = false;

            groupBoxToShow.Visible = true;
        }

        private void btnReactivarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewProductosBaja.SelectedItems.Count == 0)
                {
                    lblalertaProductos.ForeColor = Color.Red;
                    lblalertaProductos.Text = "Debe seleccionar un producto para reactivar.";
                    return;
                }

                List<Usuario> usuarios = usuarioNegocio.listarUsuarios();
                Usuario usuario = usuarios.FirstOrDefault(u => u.NombreUsuario == userLogueado);

                guidUsuario = usuario.id;
                string guidUsuarioString = guidUsuario.ToString();

                var selectedItem = listViewProductosBaja.SelectedItems[0];
                string idProducto = selectedItem.Tag.ToString();
                string nombreProducto = selectedItem.SubItems[0].Text;

                productoNegocio.reactivarProducto(idProducto, guidUsuarioString, nombreProducto);

                CargarProductosDadosDeBajaEnListView();
                cargarProductos();

                lblalertaProductos.ForeColor = Color.Green;
                lblalertaProductos.Text = "Producto reactivado con éxito.";
            }
            catch (Exception ex)
            {
                lblalertaProductos.ForeColor = Color.Red;
                lblalertaProductos.Text = "Se ha producido un error. Vuelva a intentarlo, \nsi persiste contacte a su administrador del Sistema.";

            }
        }

        private void btnConfirmarModificacion_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoDatos productoSeleccionado = (ProductoDatos)dataGridViewProducto.Rows[dataGridViewProducto.CurrentCell.RowIndex].DataBoundItem;
                string idProducto = productoSeleccionado.Id.ToString();
                string nombreProducto = productoSeleccionado.Nombre;

                string precioTexto = txtPrecio.Text;
                if (!double.TryParse(precioTexto, out double precio))
                {
                    lblalertaProductos.ForeColor = Color.Red;
                    lblalertaProductos.Text = "Ingrese un precio válido.";
                    return;
                }

                int stock = (int)numericUpDownStock.Value;

                productoNegocio.ActualizarProductoEnJson(nombreProducto, precio, stock);
                productoNegocio.modificarProducto(idProducto, guidUsuario.ToString(), precio, stock);

                cargarProductos();

                txtNombre.Text = "";
                txtPrecio.Text = "";
                numericUpDownStock.Value = numericUpDownStock.Minimum;
                lblalertaProductos.ForeColor = Color.Green;
                lblalertaProductos.Text = "Producto modificado con éxito.";

                btnConfirmarModificacion.Visible = false;
                btnCancelarModificacion.Visible = false;
                btnModificarProducto.Visible = true;
                btnAltaProducto.Visible = true;
                btnEliminarProducto.Visible = true;
            }
            catch (Exception ex)
            {
                lblalertaProductos.ForeColor = Color.Red;
                lblalertaProductos.Text = "Se ha producido un error. Vuelva a intentarlo, \nsi persiste contacte a su administrador del Sistema.";
            }
        }

        private void btnCancelarModificacion_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            numericUpDownStock.Value = numericUpDownStock.Minimum;
            lblalertaProductos.Text = "";

            btnConfirmarModificacion.Visible = false;
            btnCancelarModificacion.Visible = false;
            btnModificarProducto.Visible = true;
            btnAltaProducto.Visible = true;
            btnEliminarProducto.Visible = true;
        }
    }
}
