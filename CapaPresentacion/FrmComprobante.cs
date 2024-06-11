using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Presentacion
{
    public partial class FrmComprobante : Form
    {
        public FrmComprobante()
        {
            InitializeComponent();
        }

        private void FrmComprobante_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarComoPDF_Click(object sender, EventArgs e)
        {
            string basePath = @"C:\ElectroHogarDB\Comprobantes";

            if (!Directory.Exists(basePath))
            {
                Directory.CreateDirectory(basePath);
            }

            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string fileName = $"Comprobante_{timestamp}.pdf";
            string filePath = Path.Combine(basePath, fileName);

            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

            Pdf eventHandler = new Pdf();
            writer.PageEvent = eventHandler;

            document.Open();

            document.Add(new Paragraph("Comprobante de Venta"));
            document.Add(new Paragraph("Fecha: " + txtFecha.Text));
            document.Add(new Paragraph("Cliente: " + txtCliente.Text));
            document.Add(new Paragraph(" "));

            PdfPTable table = new PdfPTable(4);
            table.AddCell("Descripción");
            table.AddCell("Cantidad");
            table.AddCell("Monto Unitario");
            table.AddCell("Monto Total");

            foreach (DataGridViewRow row in dataGridViewDetalles.Rows)
            {
                if (row.IsNewRow) continue;

                table.AddCell(row.Cells["Descripción"].Value?.ToString());
                table.AddCell(row.Cells["Cantidad"].Value?.ToString());
                table.AddCell(row.Cells["MontoUnitario"].Value?.ToString());
                table.AddCell(row.Cells["MontoTotal"].Value?.ToString());
            }

            document.Add(table);

            document.Add(new Paragraph(" "));
            document.Add(new Paragraph("Descuento: " + txtDescuento.Text));
            document.Add(new Paragraph("Total a Pagar: " + txtTotalAPagar.Text));

            document.Close();

            MessageBox.Show($"El comprobante se ha guardado correctamente como PDF en: {filePath}",
                "Guardado Exitoso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }

    }
}
