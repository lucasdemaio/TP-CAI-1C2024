namespace Presentacion
{
    partial class FrmDevolverVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDevolverVenta));
            Cliente = new Label();
            cbClientes = new ComboBox();
            dataGridViewVentas = new DataGridView();
            btnDevolver = new Button();
            btnVolverInicio = new Button();
            lblHistorialCompras = new Label();
            lblAlertaDevolucion = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVentas).BeginInit();
            SuspendLayout();
            // 
            // Cliente
            // 
            Cliente.AutoSize = true;
            Cliente.BackColor = Color.Transparent;
            Cliente.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Cliente.Location = new Point(113, 33);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(58, 21);
            Cliente.TabIndex = 55;
            Cliente.Text = "Cliente";
            // 
            // cbClientes
            // 
            cbClientes.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(114, 57);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(338, 29);
            cbClientes.TabIndex = 54;
            cbClientes.SelectedIndexChanged += cbClientes_SelectedIndexChanged_1;
            // 
            // dataGridViewVentas
            // 
            dataGridViewVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewVentas.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewVentas.Location = new Point(113, 156);
            dataGridViewVentas.MultiSelect = false;
            dataGridViewVentas.Name = "dataGridViewVentas";
            dataGridViewVentas.ReadOnly = true;
            dataGridViewVentas.RowTemplate.Height = 25;
            dataGridViewVentas.Size = new Size(508, 198);
            dataGridViewVentas.TabIndex = 56;
            // 
            // btnDevolver
            // 
            btnDevolver.BackColor = Color.Black;
            btnDevolver.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDevolver.ForeColor = Color.White;
            btnDevolver.Location = new Point(277, 394);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(185, 63);
            btnDevolver.TabIndex = 57;
            btnDevolver.Text = "REALIZAR DEVOLUCION";
            btnDevolver.UseVisualStyleBackColor = false;
            btnDevolver.Click += btnDevolver_Click;
            // 
            // btnVolverInicio
            // 
            btnVolverInicio.BackColor = SystemColors.Info;
            btnVolverInicio.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverInicio.Location = new Point(495, 9);
            btnVolverInicio.Name = "btnVolverInicio";
            btnVolverInicio.Size = new Size(220, 33);
            btnVolverInicio.TabIndex = 58;
            btnVolverInicio.Text = "VOLVER MENU PRINCIPAL";
            btnVolverInicio.UseVisualStyleBackColor = false;
            btnVolverInicio.Click += btnVolverInicio_Click;
            // 
            // lblHistorialCompras
            // 
            lblHistorialCompras.AutoSize = true;
            lblHistorialCompras.BackColor = Color.Transparent;
            lblHistorialCompras.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHistorialCompras.Location = new Point(114, 120);
            lblHistorialCompras.Name = "lblHistorialCompras";
            lblHistorialCompras.Size = new Size(150, 21);
            lblHistorialCompras.TabIndex = 59;
            lblHistorialCompras.Text = "Compras del Cliente";
            // 
            // lblAlertaDevolucion
            // 
            lblAlertaDevolucion.AutoSize = true;
            lblAlertaDevolucion.BackColor = Color.Transparent;
            lblAlertaDevolucion.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlertaDevolucion.Location = new Point(281, 365);
            lblAlertaDevolucion.Name = "lblAlertaDevolucion";
            lblAlertaDevolucion.Size = new Size(172, 21);
            lblAlertaDevolucion.TabIndex = 60;            
            // 
            // FrmDevolverVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(727, 469);
            Controls.Add(lblAlertaDevolucion);
            Controls.Add(lblHistorialCompras);
            Controls.Add(btnVolverInicio);
            Controls.Add(btnDevolver);
            Controls.Add(dataGridViewVentas);
            Controls.Add(Cliente);
            Controls.Add(cbClientes);
            Name = "FrmDevolverVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Devoluciones";
            Load += FrmDevolverVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Cliente;
        private ComboBox cbClientes;
        private DataGridView dataGridViewVentas;
        private Button btnDevolver;
        private Button btnVolverInicio;
        private Label lblHistorialCompras;
        private Label lblAlertaDevolucion;
    }
}