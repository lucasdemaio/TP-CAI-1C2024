using Datos;
using iTextSharp.text;
using Microsoft.VisualBasic.ApplicationServices;
using Negocio;
using Negocio.Negocio;
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
    public partial class FrmDevolverVenta : Form
    {
        private int perfilUsuario;
        private Guid guidUsuario;
        string userLogueado = UsuarioLogueado.NombreUsuario;
        UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        ClienteNegocio clienteNegocio = new ClienteNegocio();
        VentaNegocio ventaNegocio = new VentaNegocio();

        public FrmDevolverVenta()
        {
            InitializeComponent();
        }

        public FrmDevolverVenta(int perfilUsuario)
        {
            InitializeComponent();
            this.FormClosing += FrmDevolverVenta_FormClosing;
            this.perfilUsuario = perfilUsuario;
        }

        private void FrmDevolverVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void FrmDevolverVenta_Load(object sender, EventArgs e)
        {
            List<Cliente> clientes = clienteNegocio.listarClientes();
            clientes = clientes.OrderBy(c => c.Apellido).ToList();
            cbClientes.DataSource = clientes;
            cbClientes.DisplayMember = "NombreCompleto";
            cbClientes.ValueMember = "Id";
            cbClientes.SelectedIndex = -1;
        }


        private void btnDevolver_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios = usuarioNegocio.listarUsuarios();
            Usuario usuario = usuarios.FirstOrDefault(u => u.NombreUsuario == userLogueado);

            if (dataGridViewVentas.SelectedRows.Count == 0)
            {
                lblAlertaDevolucion.Text = "Seleccione una venta para devolver.";
                return;
            }

            var filaSeleccionada = dataGridViewVentas.SelectedRows[0];
            Guid idVenta = (Guid)filaSeleccionada.Cells["Id"].Value;
            guidUsuario = usuario.id;

            VentaDevolucion devolucion = new VentaDevolucion(idVenta.ToString(), guidUsuario.ToString());
            ventaNegocio.DevolverVenta(devolucion);
            lblAlertaDevolucion.Text = "Devolución Realizada correctamente.";
            cbClientes_SelectedIndexChanged_1(sender, e);
        }

        private void cbClientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lblAlertaDevolucion.Text = "";

            if (cbClientes.SelectedIndex != -1)
            {
                Cliente clienteSeleccionado = cbClientes.SelectedItem as Cliente;
                if (clienteSeleccionado != null)
                {
                    Guid idCliente = clienteSeleccionado.Id;
                    List<VentaGET> ventas = ventaNegocio.GetVentasPorCliente(idCliente);
                    TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById("Argentina Standard Time");

                    var ventasOrdenadas = ventas.Select(v => new
                    {
                        v.Id,
                        FechaAlta = TimeZoneInfo.ConvertTimeFromUtc(v.FechaAlta, timeZone),
                        v.Cantidad,
                        Estado = v.Estado == 0 ? "DEVUELTO" : ""
                    })
                    .OrderBy(v => v.FechaAlta)
                    .ToList();

                    dataGridViewVentas.DataSource = ventasOrdenadas;
                }
            }
        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain(perfilUsuario);
            frmMain.Show();
            this.Hide();
        }
    }
}
