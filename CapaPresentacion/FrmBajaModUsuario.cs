using Datos;
using Negocio;
using Persistencia;
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

namespace Presentacion
{
    public partial class FrmBajaModUsuario : Form
    {
        private UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        public FrmBajaModUsuario()
        {
            InitializeComponent();
        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();
        }

        private void strpAltaUsuariosMenu_Click(object sender, EventArgs e)
        {
            FrmAltaUsuario frmAlta = new FrmAltaUsuario();
            frmAlta.Show();
            this.Hide();
        }

        private void strpBajaUsuariosMenu_Click(object sender, EventArgs e)
        {
            FrmBajaModUsuario frmBaja = new FrmBajaModUsuario();
            frmBaja.Show();
            this.Hide();
        }

        //private void FrmBajaModUsuario_Load(object sender, EventArgs e)
        //{
        //    cargarUsuarios();
        //}


        private void cargarUsuarios()
        {
            string idAdministrador = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

            List<UsuarioAlta> usuario = usuarioNegocio.listarUsuarios(idAdministrador);


            usuario = usuario.OrderBy(u => u.Apellido).ToList();

            var bindingList = new BindingList<UsuarioAlta>(usuario);
            var source = new BindingSource(bindingList, null);
            dataGridViewUsuario.DataSource = source;
            dataGridViewUsuario.Columns["Host"].Visible = false;
            dataGridViewUsuario.Columns["IdUsuario"].Visible = false;
            dataGridViewUsuario.Columns["Direccion"].Visible = false;
            dataGridViewUsuario.Columns["Telefono"].Visible = false;
            dataGridViewUsuario.Columns["Email"].Visible = false;
            dataGridViewUsuario.Columns["FechaNacimiento"].Visible = false;
            dataGridViewUsuario.Columns["Contraseña"].Visible = false;


        }

        private void FrmBajaModUsuario_Load_1(object sender, EventArgs e)
        {
            cargarUsuarios();
        }

 
    }
}
