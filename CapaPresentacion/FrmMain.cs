using Negocio;
using Datos;
using Presentacion;
using PresentacionLayer;


namespace Presentacion
{
    public partial class FrmMain : Form
    {
        private UsuarioNegocio usuarioNegocio;
        
        private int perfilUsuario;

        public FrmMain(int perfilUsuario)
        {
            InitializeComponent();
            usuarioNegocio = new UsuarioNegocio();
            this.FormClosing += FrmMain_FormClosing;
            this.perfilUsuario = perfilUsuario;
            ConfigurarMenu();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void ConfigurarMenu()
        {
            switch (perfilUsuario)
            {
                case 1: // Vendedor
                    strpProductosMenu.Enabled = false;
                    break;
                case 2: // Supervisor
                    strpUsuariosMenu.Enabled = false;
                    strpProveedoresMenu.Enabled = false;
                    strpVentasMenu.Enabled = false;
                    break;
                case 3: // Administrador
                    strpVentasMenu.Enabled = false;
                    break;
                default:
                    // Perfil no reconocido
                    MessageBox.Show("Perfil de usuario no reconocido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void strpAltaUsuariosMenu_Click(object sender, EventArgs e)
        {
            FrmAltaUsuario frmAlta = new FrmAltaUsuario(perfilUsuario);
            frmAlta.Show();
            this.Hide();
        }

        public void strpBajaUsuariosMenu_Click(object sender, EventArgs e)
        {
            FrmBajaModUsuario frmBaja = new FrmBajaModUsuario(perfilUsuario);
            frmBaja.Show();
            this.Hide();
        }

        private void strpClientesMenu_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente(perfilUsuario);
            frmCliente.Show();
            this.Hide();
        }

        private void strpProductosMenu_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto(perfilUsuario);
            frmProducto.Show();
            this.Hide();
        }

        private void strpVentasMenu_Click(object sender, EventArgs e)
        {
            FrmVenta frmVenta = new FrmVenta(perfilUsuario);
            frmVenta.Show();
            this.Hide();
        }

        private void strpProveedoresMenu_Click(object sender, EventArgs e)
        {
            FrmProveedores frmProveedores = new FrmProveedores(perfilUsuario);
            frmProveedores.Show();
            this.Hide();
        }

        private void strpReportesMenu_Click(object sender, EventArgs e)
        {
            FrmReportes frmReportes = new FrmReportes(perfilUsuario);
            frmReportes.Show();
            this.Hide();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
