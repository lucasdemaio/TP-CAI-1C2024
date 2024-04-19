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



namespace PresentacionLayer
{
    public partial class FrmLogin : Form
    {
        private UsuarioNegocio usuarioNegocio;

        public FrmLogin()
        {
            InitializeComponent();
            usuarioNegocio = new UsuarioNegocio(); // Inicialización de la variable usuarioNegocio
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {

        //    string usuario = txtUsuario.Text;
        //    string clave = txtClave.Text;


        //    bool loginExitoso = await usuarioNegocio.VerificarCredenciales(usuario, clave);


        //    //string Usuario1 = "admin";
        //    //string Clave1 = "1234";
        //    //string Usuario2 = "supervisor";
        //    //string Clave2 = "1234";
        //    //string Usuario3 = "Vendedor";
        //    //string Clave3 = "1234";

           
        //    if (loginExitoso)
        //    {
        //        // Si el inicio de sesión es exitoso, puedes abrir el formulario principal de tu aplicación, por ejemplo:
        //        FrmMain frmMain = new FrmMain();
        //        frmMain.Show();

        //        // También puedes cerrar el formulario de inicio de sesión si lo deseas
        //        this.Hide();
        //    }
        //    else
        //    {
        //        // Si las credenciales son incorrectas, puedes mostrar un mensaje de error al usuario
        //        MessageBox.Show("Credenciales incorrectas. Por favor, inténtelo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }



            //if (txtUsuario.Text == Usuario1 && txtClave.Text == Clave1)
            //{
            //    string UsuarioLogueado = txtUsuario.Text;
            //    //FrmMain frmMain = new FrmMain(this);
            //    FrmMain frmMain = new FrmMain();
            //    frmMain.Show();
            //    this.Hide();

            //}
            //else
            //{
            //    MessageBox.Show("Datos incorrectos");
            //}

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {


        }
    }

}
