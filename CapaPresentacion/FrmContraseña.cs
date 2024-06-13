using Negocio;
using PresentacionLayer;
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
    public partial class FrmContraseña : Form
    {
        private Dictionary<Control, string> controlEtiquetaMap = new Dictionary<Control, string>();
        UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        public FrmContraseña()
        {
            InitializeComponent();
            this.FormClosing += FrmContraseña_FormClosing;
            controlEtiquetaMap.Add(txtUsername, "Usuario");
            controlEtiquetaMap.Add(txtContraseñaActual, "Contraseña Actual");
            controlEtiquetaMap.Add(txtContraseñaNueva, "Nueva Contraseña");
        }

        private void FrmContraseña_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void FrmContraseña_Load(object sender, EventArgs e)
        {

        }

        private void btnCambioContraseña_Click_1(object sender, EventArgs e)
        {
            string usuario = txtUsername.Text;
            string contraseñaActual = txtContraseñaActual.Text;
            string nuevaContraseña = txtContraseñaNueva.Text;
            string confirmacionContraseña = txtConfirmacionContraseña.Text;

            if (nuevaContraseña != confirmacionContraseña)
            {
                lblContraseñaError.ForeColor = Color.Red;
                lblContraseñaError.Text = "La nueva contraseña y la confirmación no coinciden";
                lblContraseñaError.Visible = true;
                txtContraseñaActual.Text = "";
                txtContraseñaNueva.Text = "";
                txtConfirmacionContraseña.Text = "";
                return;
            }

            try
            {
                usuarioNegocio.CambiarContraseña(usuario, contraseñaActual, nuevaContraseña);
                lblContraseñaError.Text = "";
                lblContraseñaError.ForeColor = Color.White;
                lblContraseñaCambiada.Text = "Contraseña modificada exitosamente";
                lblContraseñaCambiada.Visible = true;
                txtUsername.Text = "";
                txtContraseñaActual.Text = "";
                txtContraseñaNueva.Text = "";
                txtConfirmacionContraseña.Text = "";
            }
            catch (Exception ex)
            {
                lblContraseñaError.ForeColor = Color.OrangeRed;
                lblContraseñaError.Text = "La contraseña actual ingresada no es correcta. Vuelva a intentarlo.\nSi persiste, contacte a su administrador del sistema.";
                lblContraseñaError.Visible = true;
            }
        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void lblContraseñaCambiada_Click(object sender, EventArgs e)
        {

        }
    }
}
