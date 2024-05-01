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
    public partial class FrmVenta : Form
    {
        private int perfilUsuario;
        
        public FrmVenta(int perfilUsuario)
        {
            InitializeComponent();
            this.FormClosing += FrmVenta_FormClosing;
            this.perfilUsuario = perfilUsuario;
        }

        private void FrmVenta_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FrmVenta_Load(object sender, EventArgs e)
        {

        }
    }
}
