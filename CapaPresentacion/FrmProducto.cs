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
        private ProductoNegocio productoNegocio = new ProductoNegocio();
        private ProveedoresNegocio proveedorNegocio = new ProveedoresNegocio();
        

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
            cargarProductos();
            cargarProveedores();            
        }

        private void cargarProductos()
        {
            List<ProductoDatos> productos = productoNegocio.listarProductos();

            productos = productos.OrderBy(p => p.Nombre).ToList();

            var bindingList = new BindingList<ProductoDatos>(productos);
            var source = new BindingSource(bindingList, null);
            dataGridViewProducto.DataSource = source;
            dataGridViewProducto.Columns["FechaBaja"].Visible = false;
            dataGridViewProducto.Columns["IdUsuario"].Visible = false;
            //dataGridViewProducto.Columns["IdProveedor"].Visible = false;
            dataGridViewProducto.CellFormatting += DataGridViewProducto_CellFormatting;
        }

        private void DataGridViewProducto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Para que los Precios se visualicen con formato de moneda local
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
            ProductoDatos productoSeleccionado = (ProductoDatos)dataGridViewProducto.Rows[dataGridViewProducto.CurrentCell.RowIndex].DataBoundItem;

            string idProducto = productoSeleccionado.Id.ToString();

            productoNegocio.eliminarProducto(idProducto);

            cargarProductos();

            txtNombre.Text = "";
            txtPrecio.Text = "";
            numericUpDownStock.Value = numericUpDownStock.Minimum;
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            ProductoDatos productoSeleccionado = (ProductoDatos)dataGridViewProducto.Rows[dataGridViewProducto.CurrentCell.RowIndex].DataBoundItem;

            string idProducto = productoSeleccionado.Id.ToString();

            string precioTexto = txtPrecio.Text;
            double precio = double.TryParse(precioTexto, out double result) ? result : 0.0;

            int stock = (int)numericUpDownStock.Value;

            productoNegocio.modificarProducto(idProducto, precio, stock);

            cargarProductos();

            txtNombre.Text = "";
            txtPrecio.Text = "";
            numericUpDownStock.Value = numericUpDownStock.Minimum;
        }

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            string precioTexto = txtPrecio.Text;
            double precio = double.TryParse(precioTexto, out double result) ? result : 0.0;
            int stock = (int)numericUpDownStock.Value;
            

            if (checkBoxAudio.Checked == true)
            {
                idCategoria = 1;
                
            }
            else if (checkBoxCelulares.Checked == true)
            {
                idCategoria = 2;
                //productoNegocio.agregarProducto(idCategoria, idProveedor, nombre, precio, stock);
            }
            else if (checkBoxElectro.Checked == true)
            {
                idCategoria = 3;
                //productoNegocio.agregarProducto(idCategoria, idProveedor, nombre, precio, stock);
            }
            else if (checkBoxInformatica.Checked == true)
            {
                idCategoria = 4;
                //productoNegocio.agregarProducto(idCategoria, idProveedor, nombre, precio, stock);
            }
            else if (checkBoxSmartTv.Checked == true)
            {
                idCategoria = 5;
                //productoNegocio.agregarProducto(idCategoria, idProveedor, nombre, precio, stock);
            }

            productoNegocio.agregarProducto(idCategoria, idProveedor, nombre, precio, stock);


            cargarProductos();
        }


        private void cargarProveedores()
        {
            List<ProveedoresDatos> proveedores = proveedorNegocio.listarProveedores();

            proveedores = proveedores.OrderBy(c => c.Apellido).ToList();

            var bindingList = new BindingList<ProveedoresDatos>(proveedores);
            var source = new BindingSource(bindingList, null);
            dataGridViewProdProv.DataSource = source;
            dataGridViewProdProv.Columns["Id"].Visible = false;
            dataGridViewProdProv.Columns["IdCategoriaProducto"].Visible = false;
            dataGridViewProdProv.Columns["FechaAlta"].Visible = false;
            dataGridViewProdProv.Columns["FechaBaja"].Visible = false;
            dataGridViewProdProv.Columns["Email"].Visible = false;
            dataGridViewProdProv.Columns["IdUsuario"].Visible = false;
        }

        private void dataGridViewProdProv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProveedoresDatos proveedorSeleccionado = (ProveedoresDatos)dataGridViewProdProv.Rows[dataGridViewProdProv.CurrentCell.RowIndex].DataBoundItem;
            idProveedor = proveedorSeleccionado.Id.ToString();
        }
    }
}
