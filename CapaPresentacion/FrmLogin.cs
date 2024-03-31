using CapaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionLayer
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Usuario1 = "admin";
            string Clave1 = "1234";
            string Usuario2 = "supervisor";
            string Clave2 = "1234";
            string Usuario3 = "Vendedor";
            string Clave3 = "1234";


            if (txtUsuario.Text == Usuario1 && txtClave.Text == Clave1)
            {
                string UsuarioLogueado = txtUsuario.Text;
                //FrmMain frmMain = new FrmMain(this);
                FrmMain frmMain = new FrmMain();
                frmMain.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }

        }

    }

}
