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
        private int perfilUsuario;
        
        public FrmCliente(int perfilUsuario)
        {
            InitializeComponent();
            this.perfilUsuario = perfilUsuario;
            this.FormClosing += FrmCliente_FormClosing;
        }

        private void FrmCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
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
            FrmMain frmMain = new FrmMain(perfilUsuario);
            frmMain.Show();
            this.Hide();
        }

        private void dataGridViewCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente clienteSeleccionado = (Cliente)dataGridViewCliente.Rows[dataGridViewCliente.CurrentCell.RowIndex].DataBoundItem;
            txtNombre.Text = clienteSeleccionado.Nombre;
            txtApellido.Text = clienteSeleccionado.Apellido;
            txtDNI.Text = clienteSeleccionado.Dni.ToString();
            txtDireccion.Text = clienteSeleccionado.Direccion;
            txtTelefono.Text = clienteSeleccionado.Telefono;
            txtEmail.Text = clienteSeleccionado.Email;
            dateTimeFechaNacimiento.Value = clienteSeleccionado.FechaNacimiento;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            dateTimeFechaNacimiento.Value = dateTimeFechaNacimiento.MaxDate;
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            int dni = Int32.Parse(txtDNI.Text);
            String direccion = txtDireccion.Text;
            String telefono = txtTelefono.Text;
            String email = txtEmail.Text;
            DateTime fechaNacimiento = dateTimeFechaNacimiento.Value;

            clienteNegocio.agregarCliente(nombre, apellido, dni, direccion, telefono, email, fechaNacimiento);

            cargarClientes();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            Cliente clienteSeleccionado = (Cliente)dataGridViewCliente.Rows[dataGridViewCliente.CurrentCell.RowIndex].DataBoundItem;
            Guid idCliente = clienteSeleccionado.Id;

            clienteNegocio.borrarCliente(idCliente);

            cargarClientes();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            Cliente clienteSeleccionado = (Cliente)dataGridViewCliente.Rows[dataGridViewCliente.CurrentCell.RowIndex].DataBoundItem;

            Guid idCliente = clienteSeleccionado.Id;
            String direccion = txtDireccion.Text;
            String telefono = txtTelefono.Text;
            String email = txtEmail.Text;

            clienteNegocio.modificarCliente(idCliente, direccion, telefono, email);

            cargarClientes();
        }
    }
}
    