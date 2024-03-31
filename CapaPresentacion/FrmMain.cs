using PresentacionLayer;

namespace CapaPresentacion
{
    public partial class FrmMain : Form
    {
        //public FrmMain(Form padre)
        //
        //    InitializeComponent();

        //    this.Owner = padre;
        //}

        public FrmMain() 
        {
            InitializeComponent();
        }

        
        private void FrmMain_Load(object sender, EventArgs e)
        {
            

        }

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
    }
}
