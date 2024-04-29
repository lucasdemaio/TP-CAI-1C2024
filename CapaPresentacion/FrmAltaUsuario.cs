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
using Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

namespace Presentacion
{
    public partial class FrmAltaUsuario : Form
    {
        private UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        private int perfilUsuario;

        public FrmAltaUsuario(int perfilUsuario)
        {
            InitializeComponent();
            InitializeComboBox();
            this.FormClosing += FrmAltaUsuario_FormClosing;
            this.perfilUsuario = perfilUsuario;            
        }

        private void FrmAltaUsuario_FormClosing(object sender, FormClosingEventArgs e)
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

        private void strpAltaUsuariosMenu_Click(object sender, EventArgs e)
        {
            FrmAltaUsuario frmAlta = new FrmAltaUsuario(perfilUsuario);
            frmAlta.Show();
            this.Hide();
        }

        private void strpBajaUsuariosMenu_Click(object sender, EventArgs e)
        {
            FrmBajaModUsuario frmBaja = new FrmBajaModUsuario(perfilUsuario);
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
                string contraseña = "CAI20232";
                int valorPerfil = (int)Enum.Parse(typeof(Usuario.Host), cbPerfiles.Text);
                DateTime fechaAlta = DateTime.Now;

                ValidadorUtilis validador = new ValidadorUtilis();

                string errorMensaje = validador.ValidarDatosUsuario(nombreUsuario, contraseña, dni, nombre, apellido, fechaNacimiento, valorPerfil);

                if (string.IsNullOrEmpty(errorMensaje))
                {
                    // Si todas las validaciones son exitosas, agregar el usuario
                    usuarioNegocio.agregarUsuario(valorPerfil, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, nombreUsuario, contraseña);
                    usuarioNegocio.agregarUsuarioDBLocal(nombreUsuario, contraseña);
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
