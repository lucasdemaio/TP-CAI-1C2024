using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Negocio;


namespace Presentacion
{
    public partial class FrmReportes : Form
    {
        private ReporteNegocio reporteNegocio;
        private int perfilUsuario;


        public FrmReportes(int perfilUsuario)
        {
            InitializeComponent();
            this.FormClosing += FrmReportes_FormClosing;
            this.perfilUsuario = perfilUsuario;
            string pathDB = @"C:\ElectroHogarDB\ventas.json";
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            ProductoNegocio productoNegocio = new ProductoNegocio();
            reporteNegocio = new ReporteNegocio(pathDB, usuarioNegocio, productoNegocio);
        }

        private readonly Dictionary<int, string> categorias = new Dictionary<int, string>
        {
            { 1, "Audio" },
            { 2, "Celulares" },
            { 3, "Electro Hogar" },
            { 4, "Informatica" },
            { 5, "Smart TV" }
        };

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
            if (perfilUsuario == 1)
            {
                cbReportes.Items.Add("Reporte de ventas por vendedor");
            }
            else if (perfilUsuario == 2 || perfilUsuario == 3) 
            {
                cbReportes.Items.Add("Reporte de ventas por vendedor");
                cbReportes.Items.Add("Reporte de productos más vendido por categoría");
                cbReportes.Items.Add("Productos con Stock Critico");
            }            
            cbReportes.SelectedIndex = -1;
        }

        private void cbReportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string reporteSeleccionado = cbReportes.SelectedItem.ToString();

            if (reporteSeleccionado == "Reporte de ventas por vendedor")
            {
                GenerarReporteVentasPorVendedor();
            }
            else if (reporteSeleccionado == "Reporte de productos más vendido por categoría")
            {
                GenerarReporteProductosMasVendidos();
            }
            else if (reporteSeleccionado == "Productos con Stock Critico")
            {
                GenerarReporteProductosConStockCritico();
            }
        }

        private void GenerarReporteVentasPorVendedor()
        {
            var informe = reporteNegocio.GenerarReporteVentasPorVendedor();
            dataGridViewReportes.DataSource = informe;
            dataGridViewReportes.Columns["MontoTotal"].DefaultCellStyle.Format = "C";
            dataGridViewReportes.Columns["MontoTotal"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("es-AR");
        }

        private void GenerarReporteProductosMasVendidos()
        {
            var informe = reporteNegocio.GenerarReporteProductosMasVendidos();
            dataGridViewReportes.DataSource = informe;
        }

        private void GenerarReporteProductosConStockCritico()
        {
            var informe = reporteNegocio.GenerarReporteProductosConStockCritico();
            dataGridViewReportes.DataSource = informe;
        }

    }
}
