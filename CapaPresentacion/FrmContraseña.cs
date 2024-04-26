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
            controlEtiquetaMap.Add(txtUsername, "Usuario");
            controlEtiquetaMap.Add(txtContraseñaActual, "Contraseña Actual");
            controlEtiquetaMap.Add(txtContraseñaNueva, "Nueva Contraseña");
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
                lblContraseñaError.Text = "La nueva contraseña y la confirmación no coinciden";
                lblContraseñaError.Visible = true;
                txtUsername.Text = "";
                txtContraseñaActual.Text = "";
                txtContraseñaNueva.Text = "";
                txtConfirmacionContraseña.Text = "";
                //MessageBox.Show("La nueva contraseña y la confirmación no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                usuarioNegocio.CambiarContraseña(usuario, contraseñaActual, nuevaContraseña);
                lblContraseñaError.Text = "";
                lblContraseñaCambiada.Text = "Contraseña cambiada exitosamente";
                lblContraseñaCambiada.Visible = true;
                //MessageBox.Show("Contraseña cambiada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar contraseña: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
