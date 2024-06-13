using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            CargarProveedoresDesdeJson();
            cargarProveedoresCategoria();
        }

        private void CargarProveedoresDesdeJson()
        {
            if (!proveedorNegocio.ExisteJsonProveedores())
            {
                proveedorNegocio.CrearJsonProveedoresDesdeApi();
            }
            cargarProveedores();
        }

        private void cargarProveedores()
        {
            List<ProveedoresDatos> proveedores = proveedorNegocio.listarProveedores();

            proveedores = proveedores.OrderBy(c => c.Apellido).ToList();

            var bindingList = new BindingList<ProveedoresDatos>(proveedores);
            var source = new BindingSource(bindingList, null);
            dataGridViewProveedores.DataSource = source;
            dataGridViewProveedores.CurrentCell = null;
            dataGridViewProveedores.Columns["Id"].Visible = false;
            dataGridViewProveedores.Columns["FechaAlta"].Visible = false;
            dataGridViewProveedores.Columns["FechaBaja"].Visible = false;
            dataGridViewProveedores.Columns["IdUsuario"].Visible = false;
        }

        private void cargarProveedoresCategoria()
        {
            cbCategorias.Items.Clear();
            foreach (var categoria in Enum.GetValues(typeof(CategoriaProducto)))
            {
                cbCategorias.Items.Add(categoria);
            }

            cbCategorias.SelectedIndex = 0;
        }

        private void CargarProveedoresPorCategoria(CategoriaProducto categoria)
        {
            var proveedoresPorCategoria = proveedorNegocio.LeerProveedoresPorCategoria();
            if (proveedoresPorCategoria.ContainsKey((int)categoria))
            {
                var proveedores = proveedoresPorCategoria[(int)categoria];
                proveedores = proveedores.OrderBy(p => p.Apellido).ToList();

                dataGridViewProveedoresCat.DataSource = proveedores;
                dataGridViewProveedoresCat.Columns["IdUsuario"].Visible = false;
                dataGridViewProveedoresCat.Columns["Id"].Visible = false;
                dataGridViewProveedoresCat.Columns["FechaAlta"].Visible = false;
            }
        }
        private void btnAltaProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                List<Usuario> usuarios = usuarioNegocio.listarUsuarios();
                Usuario usuario = usuarios.FirstOrDefault(u => u.NombreUsuario == userLogueado);

                if (usuario != null)
                {
                    guidUsuario = usuario.id;
                    string guidUsuarioString = guidUsuario.ToString();
                    string nombre = txtNombre.Text.Trim();
                    string apellido = txtApellido.Text.Trim();
                    string email = txtEmail.Text.Trim();
                    string cuit = txtCUIT.Text.Trim();

                    if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(cuit))
                    {
                        lblAlertaProveedores.Visible = true;
                        lblAlertaProveedores.ForeColor = Color.Red;
                        lblAlertaProveedores.Text = "Todos los campos son obligatorios.";
                        return;
                    }

                    if (!email.Contains("@"))
                    {
                        lblAlertaProveedores.Visible = true;
                        lblAlertaProveedores.ForeColor = Color.Red;
                        lblAlertaProveedores.Text = "El campo 'Email' debe contener un '@'.";
                        return;
                    }

                    List<int> categorias = new List<int>();
                    if (checkBoxAudio.Checked) categorias.Add(1);
                    if (checkBoxCelulares.Checked) categorias.Add(2);
                    if (checkBoxElectro.Checked) categorias.Add(3);
                    if (checkBoxInformatica.Checked) categorias.Add(4);
                    if (checkBoxSmartTv.Checked) categorias.Add(5);

                    if (categorias.Count == 0)
                    {
                        lblAlertaProveedores.Visible = true;
                        lblAlertaProveedores.ForeColor = Color.Red;
                        lblAlertaProveedores.Text = "Debe seleccionar al menos una categoría.";
                        return;
                    }

                    proveedorNegocio.agregarProveedor(guidUsuarioString, nombre, apellido, email, cuit, categorias);
                    lblAlertaProveedores.Visible = true;
                    lblAlertaProveedores.ForeColor = Color.Green;
                    lblAlertaProveedores.Text = "Proveedor agregado con éxito.";

                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtEmail.Text = "";
                    txtCUIT.Text = "";
                    checkBoxAudio.Checked = false;
                    checkBoxCelulares.Checked = false;
                    checkBoxElectro.Checked = false;
                    checkBoxInformatica.Checked = false;
                    checkBoxSmartTv.Checked = false;
                }
                else
                {
                    lblAlertaProveedores.Visible = true;
                    lblAlertaProveedores.ForeColor = Color.Red;
                    lblAlertaProveedores.Text = "No se pudo obtener el usuario logueado.";
                }

                cargarProveedores();
                cargarProveedoresCategoria();
            }
            catch (Exception ex)
            {
                lblAlertaProveedores.Visible = true;
                lblAlertaProveedores.ForeColor = Color.Red;
                lblAlertaProveedores.Text = "Se ha producido un error. Vuelva a intentarlo, si persiste contacte a su administrador.";
            }
        }
        private void dataGridViewProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProveedoresDatos proveedorSeleccionado = (ProveedoresDatos)dataGridViewProveedores.Rows[dataGridViewProveedores.CurrentCell.RowIndex].DataBoundItem;
            txtNombre.Text = proveedorSeleccionado.Nombre;
            txtApellido.Text = proveedorSeleccionado.Apellido;
            txtEmail.Text = proveedorSeleccionado.Email;
            txtCUIT.Text = proveedorSeleccionado.CUIT.ToString();
        }
        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProveedores.CurrentCell == null)
                {
                    lblAlertaProveedores.Visible = true;
                    lblAlertaProveedores.ForeColor = Color.Red;
                    lblAlertaProveedores.Text = "Seleccione un proveedor para eliminar.";
                    return;
                }

                ProveedoresDatos proveedorSeleccionado = (ProveedoresDatos)dataGridViewProveedores.Rows[dataGridViewProveedores.CurrentCell.RowIndex].DataBoundItem;

                if (proveedorSeleccionado == null)
                {
                    lblAlertaProveedores.Visible = true;
                    lblAlertaProveedores.ForeColor = Color.Red;
                    lblAlertaProveedores.Text = "Seleccione un proveedor válido.";
                    return;
                }

                List<Usuario> usuarios = usuarioNegocio.listarUsuarios();
                Usuario usuario = usuarios.FirstOrDefault(u => u.NombreUsuario == userLogueado);

                if (usuario == null)
                {
                    lblAlertaProveedores.Visible = true;
                    lblAlertaProveedores.ForeColor = Color.Red;
                    lblAlertaProveedores.Text = "No se pudo obtener el usuario logueado.";
                    return;
                }

                guidUsuario = usuario.id;

                Guid idProveedor = proveedorSeleccionado.Id;
                string CUIT = proveedorSeleccionado.CUIT;

                proveedorNegocio.borrarProveedor(idProveedor, guidUsuario, CUIT);

                cargarProveedores();
                cargarProveedoresCategoria();

                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEmail.Text = "";
                txtCUIT.Text = "";

                lblAlertaProveedores.Visible = true;
                lblAlertaProveedores.ForeColor = Color.Green;
                lblAlertaProveedores.Text = "Proveedor eliminado con éxito.";
            }
            catch (Exception ex)
            {
                lblAlertaProveedores.Visible = true;
                lblAlertaProveedores.ForeColor = Color.Red;
                lblAlertaProveedores.Text = "Se ha producido un error. Vuelva a intentarlo, si persiste contacte a su administrador.";
            }
        }


        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProveedores.CurrentCell == null)
                {
                    lblAlertaProveedores.Visible = true;
                    lblAlertaProveedores.Text = "Seleccione un proveedor para modificar.";
                    lblAlertaProveedores.ForeColor = Color.Red;
                    return;
                }

                ProveedoresDatos proveedorSeleccionado = (ProveedoresDatos)dataGridViewProveedores.Rows[dataGridViewProveedores.CurrentCell.RowIndex].DataBoundItem;

                if (proveedorSeleccionado == null)
                {
                    lblAlertaProveedores.Visible = true;
                    lblAlertaProveedores.Text = "Seleccione un proveedor válido.";
                    lblAlertaProveedores.ForeColor = Color.Red;
                    return;
                }

                List<Usuario> usuarios = usuarioNegocio.listarUsuarios();
                Usuario usuario = usuarios.FirstOrDefault(u => u.NombreUsuario == userLogueado);

                if (usuario == null)
                {
                    lblAlertaProveedores.Visible = true;
                    lblAlertaProveedores.Text = "No se pudo obtener el usuario logueado.";
                    lblAlertaProveedores.ForeColor = Color.Red;
                    return;
                }

                guidUsuario = usuario.id;
                Guid idProveedor = proveedorSeleccionado.Id;
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string email = txtEmail.Text;
                string cuit = proveedorSeleccionado.CUIT;

                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(cuit))
                {
                    lblAlertaProveedores.Visible = true;
                    lblAlertaProveedores.Text = "Debe seleccionar un Proveedor de la tabla para modificar";
                    lblAlertaProveedores.ForeColor = Color.Red;
                    return;
                }

                List<int> categorias = new List<int>();
                if (checkBoxAudio.Checked) categorias.Add(1);
                if (checkBoxCelulares.Checked) categorias.Add(2);
                if (checkBoxElectro.Checked) categorias.Add(3);
                if (checkBoxInformatica.Checked) categorias.Add(4);
                if (checkBoxSmartTv.Checked) categorias.Add(5);

                if (categorias.Count == 0)
                {
                    lblAlertaProveedores.Visible = true;
                    lblAlertaProveedores.Text = "Debe seleccionar al menos una categoría.";
                    lblAlertaProveedores.ForeColor = Color.Red;
                    return;
                }

                proveedorNegocio.modificarProveedor(idProveedor, guidUsuario, nombre, apellido, email, cuit);

                proveedorNegocio.ActualizarProveedorDbLocal(cuit, nombre, apellido, email, categorias);

                cargarProveedores();
                cargarProveedoresCategoria();

                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEmail.Text = "";
                lblAlertaProveedores.Text = "";
                if (txtCUIT.Text != proveedorSeleccionado.CUIT)
                {
                    txtCUIT.Text = "El CUIT no esta permitido modificarse";
                }
                else
                {
                    txtCUIT.Text = "";
                }
                checkBoxAudio.Checked = false;
                checkBoxCelulares.Checked = false;
                checkBoxElectro.Checked = false;
                checkBoxInformatica.Checked = false;
                checkBoxSmartTv.Checked = false;

                lblAlertaProveedores.Visible = true;
                lblAlertaProveedores.ForeColor = Color.Green;
                lblAlertaProveedores.Text = "Proveedor modificado con éxito.";
            }
            catch (Exception ex)
            {
                lblAlertaProveedores.Visible = true;
                lblAlertaProveedores.ForeColor = Color.Red;
                lblAlertaProveedores.Text = "Se ha producido un error. Vuelva a intentarlo, si persiste contacte a su administrador.";
            }
        }

        private void cbCategorias_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbCategorias.SelectedIndex != -1)
            {
                CategoriaProducto categoriaSeleccionada = (CategoriaProducto)cbCategorias.SelectedItem;
                CargarProveedoresPorCategoria(categoriaSeleccionada);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEmail.Text = "";
            txtCUIT.Text = "";
            checkBoxAudio.Checked = false;
            checkBoxCelulares.Checked = false;
            checkBoxElectro.Checked = false;
            checkBoxInformatica.Checked = false;
            checkBoxSmartTv.Checked = false;
            lblAlertaProveedores.Visible = false;
        }

        private void btnReactivarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProveedoresCat.CurrentCell == null)
                {
                    lblAlertaProveedores.Visible = true;
                    lblAlertaProveedores.Text = "Seleccione un proveedor para reactivar.";
                    lblAlertaProveedores.ForeColor = Color.Red;
                    return;
                }

                ProveedoresDatos proveedorSeleccionado = (ProveedoresDatos)dataGridViewProveedoresCat.Rows[dataGridViewProveedoresCat.CurrentCell.RowIndex].DataBoundItem;

                if (proveedorSeleccionado == null)
                {
                    lblAlertaProveedores.Visible = true;
                    lblAlertaProveedores.Text = "Seleccione un proveedor válido.";
                    lblAlertaProveedores.ForeColor = Color.Red;
                    return;
                }

                List<ProveedoresDatos> proveedores = proveedorNegocio.listarProveedores();
                ProveedoresDatos proveedor = proveedores.FirstOrDefault(p => p.Nombre == proveedorSeleccionado.Nombre && p.Apellido == proveedorSeleccionado.Apellido);

                if (proveedor == null)
                {
                    lblAlertaProveedores.Visible = true;
                    lblAlertaProveedores.Text = "No se pudo encontrar el proveedor en la base de datos.";
                    lblAlertaProveedores.ForeColor = Color.Red;
                    return;
                }

                Guid idProveedor = proveedor.Id;
                string cuit = proveedor.CUIT;

                List<Usuario> usuarios = usuarioNegocio.listarUsuarios();
                Usuario usuario = usuarios.FirstOrDefault(u => u.NombreUsuario == userLogueado);

                if (usuario == null)
                {
                    lblAlertaProveedores.Visible = true;
                    lblAlertaProveedores.Text = "No se pudo obtener el usuario logueado.";
                    lblAlertaProveedores.ForeColor = Color.Red;
                    return;
                }


                guidUsuario = usuario.id;



                proveedorNegocio.reactivarProveedor(idProveedor, guidUsuario, cuit);

                cargarProveedores();
                cargarProveedoresCategoria();

                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEmail.Text = "";
                txtCUIT.Text = "";
                checkBoxAudio.Checked = false;
                checkBoxCelulares.Checked = false;
                checkBoxElectro.Checked = false;
                checkBoxInformatica.Checked = false;
                checkBoxSmartTv.Checked = false;

                lblAlertaProveedores.Visible = true;
                lblAlertaProveedores.ForeColor = Color.Green;
                lblAlertaProveedores.Text = "Proveedor reactivado con éxito.";
            }
            catch (Exception ex)
            {
                lblAlertaProveedores.Visible = true;
                lblAlertaProveedores.ForeColor = Color.Red;
                lblAlertaProveedores.Text = "No fue posible el alta de proveedor, \no bien el Proveedor que intenta agregar ya existe";
            }
        }

        private void dataGridViewProveedoresCat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
