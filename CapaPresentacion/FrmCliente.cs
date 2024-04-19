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
    public partial class FrmCliente : Form
    {
        private ClienteNegocio clienteNegocio = new ClienteNegocio();

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            cargarClientes();
        }

        private void cargarClientes()
        {
            List<Cliente> clientes = clienteNegocio.listarClientes();

            clientes = clientes.OrderBy(c => c.Apellido).ToList();

            var bindingList = new BindingList<Cliente>(clientes);
            var source = new BindingSource(bindingList, null);
            dataGridViewCliente.DataSource = source;
            dataGridViewCliente.Columns["id"].Visible = false;
            dataGridViewCliente.Columns["fechaBaja"].Visible = false;
        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();
        }
    }
}
    