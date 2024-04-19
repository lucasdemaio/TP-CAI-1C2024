using Negocio;
using Datos;
using Presentacion;


namespace Presentacion
{
    public partial class FrmMain : Form
    {
        private UsuarioNegocio usuarioNegocio;

        public FrmMain()
        {
            InitializeComponent();
            usuarioNegocio = new UsuarioNegocio();
        }


        //////private void FrmMain_Load(object sender, EventArgs e)
        //////{
        //////    //string username = "usuario";
        //////    //string password = "contraseña";

        //////    //Datos.UsuarioDatos.Perfil perfilUsuario = usuarioNegocio.VerificarCredenciales(username, password);

        //////    //switch (perfilUsuario)
        //////    //{
        //////    //    case Datos.UsuarioDatos.Perfil.Vendedor:
        //////    //        strpUsuariosMenu.Visible = false;
        //////    //        strpVentasMenu.Visible = false;
        //////    //        break;
        //////    //    case Datos.UsuarioDatos.Perfil.Supervisor:
        //////    //        strpVentasMenu.Visible = false;
        //////    //        break;
        //////    //    case Datos.UsuarioDatos.Perfil.Administrador:
        //////    //        strpVentasMenu.Visible = false;
        //////    //        strpUsuariosMenu.Visible = false;
        //////    //        break;
        //////    //}

        //////}

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void strpAltaUsuariosMenu_Click(object sender, EventArgs e)
        {
            FrmAltaUsuario frmAlta = new FrmAltaUsuario();
            frmAlta.Show();
            this.Hide();
        }

        private void strpBajaUsuariosMenu_Click(object sender, EventArgs e)
        {
            FrmBajaUsuario frmBaja = new FrmBajaUsuario();
            frmBaja.Show();
            this.Hide();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void strpClientesMenu_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.Show();
            this.Hide();
        }
    }
}
