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
        private Guid guidUsuario;
        string userLogueado = UsuarioLogueado.NombreUsuario;

        public FrmBajaModUsuario(int perfilUsuario)
        {
            InitializeComponent();
            this.FormClosing += FrmBajaModUsuario_FormClosing;
            this.perfilUsuario = perfilUsuario;
        }

        private void FrmBajaModUsuario_FormClosing(object sender, FormClosingEventArgs e)
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
            List<Usuario> usuario = usuarioNegocio.listarUsuarios();

            usuario = usuario.OrderBy(u => u.Apellido).ToList();

            var bindingList = new BindingList<Usuario>(usuario);
            var source = new BindingSource(bindingList, null);
            dataGridViewUsuario.DataSource = source;
            dataGridViewUsuario.Columns["Id"].Visible = false;
            dataGridViewUsuario.Columns["Host"].Visible = false;
            dataGridViewUsuario.Columns["Direccion"].Visible = false;
            dataGridViewUsuario.Columns["Telefono"].Visible = false;
            dataGridViewUsuario.Columns["Email"].Visible = false;
            dataGridViewUsuario.Columns["FechaNacimiento"].Visible = false;
            dataGridViewUsuario.Columns["FechaBaja"].Visible = false;
        }

        private void FrmBajaModUsuario_Load_1(object sender, EventArgs e)
        {
            lblAlertaUsuarios.Visible = false;
            cargarUsuarios();
            cargarUsuariosDadosDeBaja();
        }

        private void dataGridViewUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Usuario usuarioSeleccionado = (Usuario)dataGridViewUsuario.Rows[dataGridViewUsuario.CurrentCell.RowIndex].DataBoundItem;
            txtNombre.Text = usuarioSeleccionado.Nombre;
            txtApellido.Text = usuarioSeleccionado.Apellido;
            txtDNI.Text = usuarioSeleccionado.Dni.ToString();
            txtUsername.Text = usuarioSeleccionado.NombreUsuario;
        }

        //private void btnBajaUsuario_Click(object sender, EventArgs e)
        //{
        //    List<Usuario> usuarios = usuarioNegocio.listarUsuarios();
        //    Usuario usuario = usuarios.FirstOrDefault(u => u.NombreUsuario == userLogueado);
        //    guidUsuario = usuario.id;
        //    string guidUsuarioString = guidUsuario.ToString();

        //    Usuario usuarioSeleccionado = (Usuario)dataGridViewUsuario.Rows[dataGridViewUsuario.CurrentCell.RowIndex].DataBoundItem;
        //    string idUsuario = usuarioSeleccionado.id.ToString();
        //    string nombreUsuario = usuarioSeleccionado.NombreUsuario;
        //    string nombre = usuarioSeleccionado.Nombre;
        //    string apellido = usuarioSeleccionado.Apellido;

        //    usuarioNegocio.borrarUsuario(idUsuario, guidUsuarioString, nombreUsuario, nombre, apellido);
        //    usuarioNegocio.borrarUsuarioDBLocal(nombreUsuario);

        //    cargarUsuarios();
        //    cargarUsuariosDadosDeBaja();
        //    txtNombre.Text = "";
        //    txtApellido.Text = "";
        //    txtDNI.Text = "";
        //    txtUsername.Text = "";
        //}

        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewUsuario.CurrentCell == null)
                {
                    lblAlertaUsuarios.Visible = true;
                    lblAlertaUsuarios.ForeColor = Color.Red;
                    lblAlertaUsuarios.Text = "Seleccione un usuario para eliminar.";
                    return;
                }

                List<Usuario> usuarios = usuarioNegocio.listarUsuarios();
                Usuario usuario = usuarios.FirstOrDefault(u => u.NombreUsuario == userLogueado);
                guidUsuario = usuario.id;
                string guidUsuarioString = guidUsuario.ToString();

                Usuario usuarioSeleccionado = (Usuario)dataGridViewUsuario.Rows[dataGridViewUsuario.CurrentCell.RowIndex].DataBoundItem;
                if (usuarioSeleccionado == null)
                {
                    lblAlertaUsuarios.Visible = true;
                    lblAlertaUsuarios.ForeColor = Color.Red;
                    lblAlertaUsuarios.Text = "Seleccione un usuario para eliminar.";
                    return;
                }

                string idUsuario = usuarioSeleccionado.id.ToString();
                string nombreUsuario = usuarioSeleccionado.NombreUsuario;
                string nombre = usuarioSeleccionado.Nombre;
                string apellido = usuarioSeleccionado.Apellido;

                usuarioNegocio.borrarUsuario(idUsuario, guidUsuarioString, nombreUsuario, nombre, apellido);
                usuarioNegocio.borrarUsuarioDBLocal(nombreUsuario);

                lblAlertaUsuarios.Visible = true;
                lblAlertaUsuarios.ForeColor = Color.Green;
                lblAlertaUsuarios.Text = $"{usuarioSeleccionado.NombreUsuario} dado de baja correctamente.";

                cargarUsuarios();
                cargarUsuariosDadosDeBaja();
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDNI.Text = "";
                txtUsername.Text = "";
            }
            catch (Exception ex)
            {
                lblAlertaUsuarios.Visible = true;
                lblAlertaUsuarios.ForeColor = Color.Red;
                lblAlertaUsuarios.Text = "Se ha producido un error. Vuelva a intentarlo, \nsi persiste contacte a su administrador del Sistema.";
            }
        }
        private void cargarUsuariosDadosDeBaja()
            {
                List<UsuarioBajaDBLocal> usuariosBaja = usuarioNegocio.ObtenerUsuariosDadosDeBaja();

                var bindingList = new BindingList<UsuarioBajaDBLocal>(usuariosBaja);
                var source = new BindingSource(bindingList, null);
                dataGridViewReactivar.DataSource = source;
                dataGridViewReactivar.Columns["IdUsuario"].Visible = false;
            }


        private void dataGridViewReactivar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReactivar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Usuario> usuarios = usuarioNegocio.listarUsuarios();
                Usuario usuario = usuarios.FirstOrDefault(u => u.NombreUsuario == userLogueado);
                guidUsuario = usuario.id;
                string guidUsuarioString = guidUsuario.ToString();

                if (dataGridViewReactivar.SelectedRows.Count > 0)
                {
                    UsuarioBajaDBLocal usuarioSeleccionado = (UsuarioBajaDBLocal)dataGridViewReactivar.SelectedRows[0].DataBoundItem;
                    string IdUsuario = usuarioSeleccionado.IdUsuario;

                    usuarioNegocio.EliminarUsuarioDeBajasJson(IdUsuario);
                    usuarioNegocio.ReactivarUsuario(IdUsuario, guidUsuarioString);

                    lblAlertaUsuarios.Visible = true;
                    lblAlertaUsuarios.ForeColor = Color.Green;
                    lblAlertaUsuarios.Text = "Usuario reactivado correctamente.";

                    cargarUsuariosDadosDeBaja();
                    cargarUsuarios();
                }
                else
                {
                    lblAlertaUsuarios.Visible = true;
                    lblAlertaUsuarios.ForeColor = Color.Red;
                    lblAlertaUsuarios.Text = "Seleccione un usuario para reactivar.";
                }
            }
           catch (Exception ex)
            {
                lblAlertaUsuarios.Visible = true;
                lblAlertaUsuarios.ForeColor = Color.Red;
                lblAlertaUsuarios.Text = "Se ha producido un error. Vuelva a intentarlo, \nsi persiste contacte a su administrador del Sistema.";
            }
        }
    }
}
