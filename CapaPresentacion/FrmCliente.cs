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
        private UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        private int perfilUsuario;
        private Guid guidUsuario;
        string userLogueado = UsuarioLogueado.NombreUsuario;

        public FrmCliente(int perfilUsuario)
        {
            InitializeComponent();
            this.perfilUsuario = perfilUsuario;
            this.FormClosing += FrmCliente_FormClosing;
            CargarClientesBajas();
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
            lblAlertaClientes.Visible = false;
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
            dataGridViewCliente.Columns["NombreCompleto"].Visible = false;

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
            lblAlertaClientes.Visible = false;
            dateTimeFechaNacimiento.Value = DateTime.Today;
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                var controlEtiquetaMap = new Dictionary<Control, string>
                {
                { txtNombre, "Nombre" },
                { txtApellido, "Apellido" },
                { txtDNI, "DNI" },
                { txtDireccion, "Dirección" },
                { txtTelefono, "Teléfono" },
                { txtEmail, "Email" }
                };

                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                int dni;
                if (!Int32.TryParse(txtDNI.Text, out dni))
                {
                    lblAlertaClientes.Visible = true;
                    lblAlertaClientes.ForeColor = Color.Red;
                    lblAlertaClientes.Text = "El campo 'DNI' debe ser un número válido.";
                    return;
                }

                string direccion = txtDireccion.Text;
                string telefono = txtTelefono.Text;
                string email = txtEmail.Text;
                if (!email.Contains("@"))
                {
                    lblAlertaClientes.Visible = true;
                    lblAlertaClientes.ForeColor = Color.Red;
                    lblAlertaClientes.Text = "El campo 'Email' debe contener un '@'.";
                    return;
                }

                DateTime fechaNacimiento = dateTimeFechaNacimiento.Value;

                int edad = DateTime.Now.Year - fechaNacimiento.Year;
                if (fechaNacimiento > DateTime.Now.AddYears(-edad)) edad--;
                if (edad < 18)
                {
                    lblAlertaClientes.Visible = true;
                    lblAlertaClientes.ForeColor = Color.Red;
                    lblAlertaClientes.Text = "El cliente debe tener al menos 18 años.";
                    return;
                }

                ValidadorUtilis validador = new ValidadorUtilis();
                string errorCamposIncompletos = validador.ValidarCamposCompletos(this, controlEtiquetaMap);

                if (!string.IsNullOrEmpty(errorCamposIncompletos))
                {
                    lblAlertaClientes.ForeColor = Color.Red;
                    lblAlertaClientes.Text = errorCamposIncompletos;
                    return;
                }

                List<Usuario> usuarios = usuarioNegocio.listarUsuarios();
                Usuario usuario = usuarios.FirstOrDefault(u => u.NombreUsuario == userLogueado);
                guidUsuario = usuario.id;
                string guidUsuarioString = guidUsuario.ToString();

                clienteNegocio.agregarCliente(guidUsuarioString, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento);

                lblAlertaClientes.Visible = true;
                lblAlertaClientes.ForeColor = Color.Green;
                lblAlertaClientes.Text = "Cliente agregado correctamente";

                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDNI.Text = "";
                txtDireccion.Text = "";
                txtTelefono.Text = "";
                txtEmail.Text = "";
                dateTimeFechaNacimiento.Value = dateTimeFechaNacimiento.MaxDate;

                cargarClientes();
            }
            catch (Exception ex)
            {
                lblAlertaClientes.Visible = true;
                lblAlertaClientes.ForeColor = Color.Red;
                lblAlertaClientes.Text = "Se ha producido un error. Vuelva a intentarlo, \nsi persiste contacte a su administrador.";
            }
        }


        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente clienteSeleccionado = (Cliente)dataGridViewCliente.Rows[dataGridViewCliente.CurrentCell.RowIndex].DataBoundItem;
                if (clienteSeleccionado == null)
                {
                    lblAlertaClientes.Visible = true;
                    lblAlertaClientes.ForeColor = Color.Red;
                    lblAlertaClientes.Text = "Seleccione un cliente para eliminar.";
                    return;
                }

                Guid idCliente = clienteSeleccionado.Id;

                clienteNegocio.GuardarClienteEliminado(clienteSeleccionado);
                clienteNegocio.borrarCliente(idCliente);
                lblAlertaClientes.Visible = true;
                lblAlertaClientes.ForeColor = Color.Green;
                lblAlertaClientes.Text = $"El cliente {clienteSeleccionado.NombreCompleto} \n ha sido dado de baja";
                cargarClientes();
                CargarClientesBajas();
            }
            catch (Exception ex) 
            {
                lblAlertaClientes.Visible = true;
                lblAlertaClientes.ForeColor = Color.Red;
                lblAlertaClientes.Text = "Se ha producido un error. Vuelva a intentarlo, \nsi persiste contacte a su administrador.";
            }            
        }

        private void CargarClientesBajas()
        {
            try
            {
                var clientesBajas = clienteNegocio.ObtenerClientesEliminados();
                cbReactivarCliente.DataSource = clientesBajas;
                cbReactivarCliente.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes dados de Baja: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente clienteSeleccionado = (Cliente)dataGridViewCliente.Rows[dataGridViewCliente.CurrentCell.RowIndex].DataBoundItem;

                if (clienteSeleccionado == null)
                {
                    lblAlertaClientes.Visible = true;
                    lblAlertaClientes.ForeColor = Color.Red;
                    lblAlertaClientes.Text = "Seleccione un cliente para modificar.";
                    return;
                }

                string nombreActual = clienteSeleccionado.Nombre;
                string apellidoActual = clienteSeleccionado.Apellido;
                string nombreNuevo = txtNombre.Text;
                string apellidoNuevo = txtApellido.Text;

                if (nombreActual != nombreNuevo || apellidoActual != apellidoNuevo)
                {
                    lblAlertaClientes.Visible = true;
                    lblAlertaClientes.ForeColor = Color.Red;
                    lblAlertaClientes.Text = "No se puede modificar Nombre o Apellido.";
                    return;
                }

                Guid idCliente = clienteSeleccionado.Id;
                String direccion = txtDireccion.Text;
                String telefono = txtTelefono.Text;
                String email = txtEmail.Text;

                clienteNegocio.modificarCliente(idCliente, direccion, telefono, email);

                lblAlertaClientes.Visible = true;
                lblAlertaClientes.ForeColor = Color.Green;
                lblAlertaClientes.Text = $"El cliente {clienteSeleccionado.NombreCompleto} \nha sido modificado correctamente";

                cargarClientes();
            }
            catch (Exception ex)
            {
                lblAlertaClientes.Visible = true;
                lblAlertaClientes.ForeColor = Color.Red;
                lblAlertaClientes.Text = "Se ha producido un error. Vuelva a intentarlo, \nsi persiste contacte a su administrador.";
            }           
        }

        private void btnReactivarCliente_Click(object sender, EventArgs e)
        {
            if (cbReactivarCliente.SelectedIndex == -1)
            {
                lblAlertaClientes.Visible = true;
                lblAlertaClientes.ForeColor = Color.Red;
                lblAlertaClientes.Text = "Por favor, seleccione un cliente para reactivar.";
                return;
            }

            string clienteInfo = cbReactivarCliente.SelectedItem.ToString();
            string idClienteString = clienteInfo.Substring(clienteInfo.LastIndexOf(',') + 1).Trim();

            if (Guid.TryParse(idClienteString, out Guid idCliente))
            {
                try
                {
                    clienteNegocio.reactivarCliente(idCliente);
                    clienteNegocio.EliminarClienteReactivadoDeTxt(idCliente);

                    lblAlertaClientes.Visible = true;
                    lblAlertaClientes.ForeColor = Color.Green;
                    lblAlertaClientes.Text = "Cliente reactivado con éxito.";

                    CargarClientesBajas();
                    cbReactivarCliente.Refresh();
                    cbReactivarCliente.SelectedIndex = -1;
                    cargarClientes();
                }
                catch (Exception ex)
                {
                    lblAlertaClientes.Visible = true;
                    lblAlertaClientes.ForeColor = Color.Red;
                    lblAlertaClientes.Text = "Error al reactivar cliente. Vuelva a intentarlo, \nsi persiste contacte a su administrador.";
                }
            }
            else
            {
                lblAlertaClientes.Visible = true;
                lblAlertaClientes.ForeColor = Color.Red;
                lblAlertaClientes.Text = "Error al procesar la identificación del cliente.";
            }
        }

    }
}
    