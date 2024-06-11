using Negocio;
using Datos;
using Presentacion;
using PresentacionLayer;
using System.Windows.Forms;


namespace Presentacion
{
    public partial class FrmMain : Form
    {
        private UsuarioNegocio usuarioNegocio;
        private ProductoNegocio productoNegocio;

        private int perfilUsuario;


        public FrmMain(int perfilUsuario)
        {
            InitializeComponent();
            usuarioNegocio = new UsuarioNegocio();
            this.productoNegocio = new ProductoNegocio();
            this.FormClosing += FrmMain_FormClosing;
            this.perfilUsuario = perfilUsuario;
            ConfigurarMenu();
            VerificarStockCritico();
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
                    strpProveedoresMenu.Enabled = false;
                    strpUsuariosMenu.Enabled = false;
                    strpDevolucionVenta.Enabled = false;

                    break;
                case 2: // Supervisor
                    strpUsuariosMenu.Enabled = false;
                    strpProveedoresMenu.Enabled = false;
                    strpNuevaVenta.Enabled = false;
                    break;
                case 3: // Administrador
                    strpVentasMenu.Enabled = false;
                    break;
                default:
                    MessageBox.Show("Perfil de usuario no reconocido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void VerificarStockCritico()
        {
            if (perfilUsuario == 2 || perfilUsuario == 3)
            {
                int cantidadProductosCriticos = productoNegocio.ContarProductosConStockCritico();
                if (cantidadProductosCriticos > 0)
                {
                    lblStockCritico.Visible = true;
                    lblStockCritico.Text = $"Hay {cantidadProductosCriticos} productos con stock crítico!!!";
                }
                else
                {
                    lblStockCritico.Visible = false;
                }
            }
            else
            {
                lblStockCritico.Visible = false;
            }
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

        private void strpNuevaVenta_Click(object sender, EventArgs e)
        {
            FrmComprobante frmComprobante = new FrmComprobante();
            FrmVenta frmVenta = new FrmVenta(perfilUsuario, frmComprobante);
            frmVenta.Show();
            this.Hide();
        }

        private void strpDevolucionVenta_Click(object sender, EventArgs e)
        {
            FrmDevolverVenta frmDevolverVenta = new FrmDevolverVenta(perfilUsuario);
            frmDevolverVenta.Show();
            this.Hide();
        }
    }
}
