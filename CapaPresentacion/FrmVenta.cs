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
    public partial class FrmVenta : Form
    {
        private int perfilUsuario;
        private ProductoNegocio productoNegocio = new ProductoNegocio();
        private ClienteNegocio clienteNegocio = new ClienteNegocio();

        public FrmVenta(int perfilUsuario)
        {
            InitializeComponent();
            this.FormClosing += FrmVenta_FormClosing;
            this.perfilUsuario = perfilUsuario;
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
            dataGridViewProducto.Columns["FechaBaja"].Visible = false;
            dataGridViewProducto.Columns["IdUsuario"].Visible = false;
            //dataGridViewProducto.Columns["IdProveedor"].Visible = false;
            dataGridViewProducto.CellFormatting += dataGridViewProducto_CellFormatting;
        }

        private void dataGridViewProducto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        private void dataGridViewProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cargarClientes()
        {
            List<Cliente> clientes = clienteNegocio.listarClientes();

            clientes = clientes.OrderBy(c => c.Apellido).ToList();

            cbCliente.DataSource = clientes;

            cbCliente.DisplayMember = "NombreCompleto";

            cbCliente.SelectedIndex = -1;

            //var bindingList = new BindingList<Cliente>(clientes);
            //var source = new BindingSource(bindingList, null);
            //dataGridViewCliente.DataSource = source;
            //dataGridViewCliente.Columns["id"].Visible = false;
            //dataGridViewCliente.Columns["fechaBaja"].Visible = false;
        }

    }
}
