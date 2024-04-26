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
        private int perfilUsuario;

        public FrmBajaModUsuario(int perfilUsuario)
        {
            InitializeComponent();
            this.perfilUsuario = perfilUsuario;
        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain(perfilUsuario);
            frmMain.Show();
            this.Hide();
        }

        private void strpAltaUsuariosMenu_Click(object sender, EventArgs e)
        {
            FrmAltaUsuario frmAlta = new FrmAltaUsuario(perfilUsuario);
            frmAlta.Show();
            this.Hide();
        }

        private void strpBajaUsuariosMenu_Click(object sender, EventArgs e)
        {
            FrmBajaModUsuario frmBaja = new FrmBajaModUsuario(perfilUsuario);
            frmBaja.Show();
            this.Hide();
        }

        private void cargarUsuarios()
        {
            List<UsuarioAlta> usuario = usuarioNegocio.listarUsuarios();

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

        private void dataGridViewUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UsuarioAlta usuarioSeleccionado = (UsuarioAlta)dataGridViewUsuario.Rows[dataGridViewUsuario.CurrentCell.RowIndex].DataBoundItem;
            txtNombre.Text = usuarioSeleccionado.Nombre;
            txtApellido.Text = usuarioSeleccionado.Apellido;
            txtDNI.Text = usuarioSeleccionado.Dni.ToString();
            txtUsername.Text = usuarioSeleccionado.NombreUsuario;
        }

        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            UsuarioAlta usuarioSeleccionado = (UsuarioAlta)dataGridViewUsuario.Rows[dataGridViewUsuario.CurrentCell.RowIndex].DataBoundItem;
            string idUsuario = usuarioSeleccionado.IdUsuario;

            //usuarioNegocio.borrarUsuario(idUsuario);

            cargarUsuarios();
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
            txtUsername.Text = "";
        }
    }
}
