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
    public partial class FrmProducto : Form
    {
        private int perfilUsuario;
        
        public FrmProducto(int perfilUsuario)
        {
            InitializeComponent();
            this.FormClosing += FrmProducto_FormClosing;
            this.perfilUsuario = perfilUsuario;
           
        }

        private void FrmProducto_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FrmProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
