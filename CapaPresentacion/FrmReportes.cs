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
    public partial class FrmReportes : Form
    {
        private int perfilUsuario;
        
        public FrmReportes(int perfilUsuario)
        {
            InitializeComponent();
            this.FormClosing += FrmReportes_FormClosing;
            this.perfilUsuario = perfilUsuario;
        }

        private void FrmReportes_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FrmReportes_Load(object sender, EventArgs e)
        {

        }
    }
}
