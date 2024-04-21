using Datos;
using Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Datos.Usuario;
using static Datos.UsuarioDBLocal;
using static Datos.Json;
using Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

namespace Presentacion
{
    public partial class FrmAltaUsuario : Form
    {
        private UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

        public FrmAltaUsuario()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();
        }

        private void strpAltaUsuariosMenu_Click(object sender, EventArgs e)
        {
            FrmAltaUsuario frmAlta = new FrmAltaUsuario();
            frmAlta.Show();
            this.Hide();
        }

        private void strpBajaUsuariosMenu_Click(object sender, EventArgs e)
        {
            FrmBajaModUsuario frmBaja = new FrmBajaModUsuario();
            frmBaja.Show();
            this.Hide();
        }


        
        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            try
            {  
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                int dni = Int32.Parse(txtDNI.Text);
                string direccion = txtDireccion.Text;
                string telefono = txtTelefono.Text;
                string email = txtEmail.Text;
                DateTime fechaNacimiento = dateTimeFechaNacimiento.Value;
                string nombreUsuario = txtUsuario.Text;
                string contraseña = txtContraseña.Text;
                int valorPerfil = (int)Enum.Parse(typeof(Usuario.Host), cbPerfiles.Text);
                DateTime fechaAlta = DateTime.Now;

                ValidadorUtilis validador = new ValidadorUtilis();

                string errorMensaje = validador.ValidarDatosUsuario(nombreUsuario, contraseña, dni, nombre, apellido);
                
                if (string.IsNullOrEmpty(errorMensaje))
                {
                    // Si todas las validaciones son exitosas, agregar el usuario
                    usuarioNegocio.agregarUsuario(valorPerfil, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, nombreUsuario, contraseña);
                    usuarioNegocio.agregarUsuarioDBLocal(nombre, apellido, email, fechaAlta, fechaNacimiento, null, nombreUsuario, valorPerfil, dni, contraseña, "INACTIVO");
                    MessageBox.Show("Usuario agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(errorMensaje, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComboBox()
        {
            {
                cbPerfiles.DropDownStyle = ComboBoxStyle.DropDownList;
                Host[] perfiles = (Host[])Enum.GetValues(typeof(Host));
                cbPerfiles.Items.AddRange(perfiles.Select(x => (object)x).ToArray());
                if (cbPerfiles.Items.Count > 0)
                {
                    cbPerfiles.SelectedIndex = -1;
                }
            }
        }

        private void FrmAltaUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}   
