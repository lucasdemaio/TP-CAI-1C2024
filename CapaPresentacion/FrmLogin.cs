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
using Negocio;
using Persistencia;
using Datos;



namespace PresentacionLayer
{
    public partial class FrmLogin : Form
    {
        private UsuarioNegocio usuarioNegocio;
        private int intentosFallidos = 0;
        private string ultimoUsuarioIntentado = string.Empty;


        public FrmLogin()
        {
            InitializeComponent();
            usuarioNegocio = new UsuarioNegocio();
            this.FormClosing += FrmLogin_FormClosing;
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text;
                string clave = txtClave.Text;

                if (usuario != ultimoUsuarioIntentado)
                {                    
                    intentosFallidos = 0;
                    ultimoUsuarioIntentado = usuario;
                }

                bool primerlogueo = usuarioNegocio.VerificarPrimerLogin(usuario);
                if (primerlogueo)
                {
                    lblLoginIncorrecto.Text = $"Es su primer Login, debe cambiar la clave para ingresar";
                    lblLoginIncorrecto.Visible = true;
                    return;
                }

                bool contraseñaExpirada = usuarioNegocio.VerificarExpiracionContraseña(usuario);
                if (contraseñaExpirada)
                {
                    lblLoginIncorrecto.Text = $"Su contraseña ha expirado. Debe cambiarla para ingresar.";
                    lblLoginIncorrecto.Visible = true;
                    return;
                }

                int perfilUsuario = usuarioNegocio.Login(usuario, clave);

                if (perfilUsuario != -1)
                {
                    UsuarioLogueado.SetNombreUsuario(usuario);
                    FrmMain frmMain = new FrmMain(perfilUsuario);
                    frmMain.Show();
                    this.Hide();
                }
                else
                {
                    intentosFallidos++;
                    lblLoginIncorrecto.Text = "Nombre de usuario o contraseña incorrectos";
                    lblLoginIncorrecto.Visible = true;
                    txtUsuario.Text = "";
                    txtClave.Text = "";
                }
                if (intentosFallidos >= 3)
                {
                    usuarioNegocio.borrarUsuarioPorLoginFallido(usuario);
                    lblLoginIncorrecto.Text = $"Ha superado el limite de intentos. \nContacte a un Administrador para Reactivar su usuario";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void linklblCambioClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmContraseña frmContraseña = new FrmContraseña();
            frmContraseña.Show();
            this.Hide();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {   

        }
    }
}
