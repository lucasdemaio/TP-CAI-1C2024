using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmProveedores : Form
    {
        private ProveedoresNegocio proveedorNegocio = new ProveedoresNegocio();
        private UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        
        private int perfilUsuario;
        private Guid guidUsuario;

        string userLogueado = UsuarioLogueado.NombreUsuario;
        
        public FrmProveedores(int perfilUsuario)
        {
            InitializeComponent();
            this.FormClosing += FrmProveedores_FormClosing;
            this.perfilUsuario = perfilUsuario;            
        }

        private void FrmProveedores_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            cargarProveedores();

            //List<Usuario> usuarios = usuarioNegocio.listarUsuarios();

            //Usuario usuario = usuarios.FirstOrDefault(u => u.NombreUsuario == userLogueado);

            //if (userLogueado != null)
            //{
            //    Guid guidUsuario = usuario.id;
            //}
            //else
            //{
            //    Console.WriteLine("Usuario no encontrado");
            //}
        }

        private void cargarProveedores()
        {
            List<ProveedoresDatos> proveedores = proveedorNegocio.listarProveedores();

            proveedores = proveedores.OrderBy(c => c.Apellido).ToList();

            var bindingList = new BindingList<ProveedoresDatos>(proveedores);
            var source = new BindingSource(bindingList, null);
            dataGridViewProveedores.DataSource = source;
            //dataGridViewProveedores.Columns["Id"].Visible = false;
            //dataGridViewProveedores.Columns["FechaAlta"].Visible = false;
            //dataGridViewProveedores.Columns["FechaBaja"].Visible = false;
            //dataGridViewProveedores.Columns["IdUsuario"].Visible = false;
        }

        private void btnAltaProveedor_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios = usuarioNegocio.listarUsuarios();

            Usuario usuario = usuarios.FirstOrDefault(u => u.NombreUsuario == userLogueado);

            if (userLogueado != null)
            {
                Guid guidUsuario = usuario.id;
                string guidUsuarioString = guidUsuario.ToString();
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string email = txtEmail.Text;
                string cuit = txtCUIT.Text;
                proveedorNegocio.agregarProveedor(guidUsuarioString, nombre, apellido, email, cuit);
            }
            else
            {
                //agregar un label que muestre el error
            }            

            cargarProveedores();
            }

        private void groupBoxABMProveedor_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProveedoresDatos proveedorSeleccionado = (ProveedoresDatos)dataGridViewProveedores.Rows[dataGridViewProveedores.CurrentCell.RowIndex].DataBoundItem;
            txtNombre.Text = proveedorSeleccionado.Nombre;
            txtApellido.Text = proveedorSeleccionado.Apellido;
            txtEmail.Text = proveedorSeleccionado.Email;
            txtCUIT.Text = proveedorSeleccionado.CUIT.ToString();           
            
        }
    }
}
