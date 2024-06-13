namespace Presentacion
{
    partial class FrmVenta
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenta));
            btnVolverInicio = new Button();
            listCarrito = new ListView();
            groupBoxCarrito = new GroupBox();
            cbCliente = new ComboBox();
            dateTimePickerVenta = new DateTimePicker();
            dataGridViewProducto = new DataGridView();
            btnAgregar = new Button();
            btnRemover = new Button();
            btnCompletarVenta = new Button();
            lblFecha = new Label();
            Cliente = new Label();
            numericUpDownCantidad = new NumericUpDown();
            labelCantidad = new Label();
            lblTotal = new Label();
            lblClienteNuevo = new Label();
            lblalertaVentas = new Label();
            lblAlertaCarrito = new Label();
            lblAlertadecuentoCatElectroHogar = new Label();
            lblAlertaVenta = new Label();
            groupBoxCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidad).BeginInit();
            SuspendLayout();
            // 
            // btnVolverInicio
            // 
            btnVolverInicio.BackColor = SystemColors.Info;
            btnVolverInicio.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverInicio.Location = new Point(1247, 752);
            btnVolverInicio.Margin = new Padding(4);
            btnVolverInicio.Name = "btnVolverInicio";
            btnVolverInicio.Size = new Size(218, 46);
            btnVolverInicio.TabIndex = 43;
            btnVolverInicio.Text = "VOLVER MENU PRINCIPAL";
            btnVolverInicio.UseVisualStyleBackColor = false;
            btnVolverInicio.Click += btnVolverInicio_Click;
            // 
            // listCarrito
            // 
            listCarrito.Location = new Point(12, 30);
            listCarrito.Margin = new Padding(4);
            listCarrito.Name = "listCarrito";
            listCarrito.Size = new Size(766, 300);
            listCarrito.TabIndex = 44;
            listCarrito.UseCompatibleStateImageBehavior = false;
            // 
            // groupBoxCarrito
            // 
            groupBoxCarrito.Controls.Add(listCarrito);
            groupBoxCarrito.Location = new Point(61, 450);
            groupBoxCarrito.Margin = new Padding(4);
            groupBoxCarrito.Name = "groupBoxCarrito";
            groupBoxCarrito.Padding = new Padding(4);
            groupBoxCarrito.Size = new Size(790, 352);
            groupBoxCarrito.TabIndex = 45;
            groupBoxCarrito.TabStop = false;
            groupBoxCarrito.Text = "Carrito";
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(61, 105);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(309, 29);
            cbCliente.TabIndex = 46;
            cbCliente.SelectedIndexChanged += cbCliente_SelectedIndexChanged;
            // 
            // dateTimePickerVenta
            // 
            dateTimePickerVenta.Enabled = false;
            dateTimePickerVenta.Location = new Point(61, 38);
            dateTimePickerVenta.Name = "dateTimePickerVenta";
            dateTimePickerVenta.Size = new Size(309, 29);
            dateTimePickerVenta.TabIndex = 47;
            // 
            // dataGridViewProducto
            // 
            dataGridViewProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducto.Location = new Point(61, 158);
            dataGridViewProducto.MultiSelect = false;
            dataGridViewProducto.Name = "dataGridViewProducto";
            dataGridViewProducto.ReadOnly = true;
            dataGridViewProducto.RowTemplate.Height = 25;
            dataGridViewProducto.Size = new Size(778, 270);
            dataGridViewProducto.TabIndex = 48;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Green;
            btnAgregar.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(935, 277);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(206, 37);
            btnAgregar.TabIndex = 49;
            btnAgregar.Text = "AGREGAR AL CARRITO";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.Red;
            btnRemover.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemover.ForeColor = Color.White;
            btnRemover.Location = new Point(953, 494);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(206, 37);
            btnRemover.TabIndex = 50;
            btnRemover.Text = "REMOVER DEL CARRITO";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnCompletarVenta
            // 
            btnCompletarVenta.BackColor = Color.Green;
            btnCompletarVenta.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCompletarVenta.ForeColor = Color.White;
            btnCompletarVenta.Location = new Point(953, 591);
            btnCompletarVenta.Name = "btnCompletarVenta";
            btnCompletarVenta.Size = new Size(206, 45);
            btnCompletarVenta.TabIndex = 51;
            btnCompletarVenta.Text = "COMPLETAR VENTA";
            btnCompletarVenta.UseVisualStyleBackColor = false;
            btnCompletarVenta.Click += btnCompletarVenta_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Location = new Point(61, 9);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 21);
            lblFecha.TabIndex = 52;
            lblFecha.Text = "Fecha";
            // 
            // Cliente
            // 
            Cliente.AutoSize = true;
            Cliente.BackColor = Color.Transparent;
            Cliente.Location = new Point(61, 81);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(58, 21);
            Cliente.TabIndex = 53;
            Cliente.Text = "Cliente";
            // 
            // numericUpDownCantidad
            // 
            numericUpDownCantidad.Location = new Point(1021, 237);
            numericUpDownCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCantidad.Name = "numericUpDownCantidad";
            numericUpDownCantidad.Size = new Size(120, 29);
            numericUpDownCantidad.TabIndex = 0;
            numericUpDownCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelCantidad
            // 
            labelCantidad.AutoSize = true;
            labelCantidad.BackColor = Color.Transparent;
            labelCantidad.Location = new Point(935, 239);
            labelCantidad.Name = "labelCantidad";
            labelCantidad.Size = new Size(72, 21);
            labelCantidad.TabIndex = 55;
            labelCantidad.Text = "Cantidad";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Ebrima", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(959, 639);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(149, 32);
            lblTotal.TabIndex = 54;
            lblTotal.Text = "Total: $0.00";
            // 
            // lblClienteNuevo
            // 
            lblClienteNuevo.AutoSize = true;
            lblClienteNuevo.ForeColor = Color.Red;
            lblClienteNuevo.Location = new Point(400, 105);
            lblClienteNuevo.Name = "lblClienteNuevo";
            lblClienteNuevo.Size = new Size(0, 21);
            lblClienteNuevo.TabIndex = 54;
            lblClienteNuevo.Visible = false;
            // 
            // lblalertaVentas
            // 
            lblalertaVentas.AutoSize = true;
            lblalertaVentas.Font = new Font("Ebrima", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblalertaVentas.Location = new Point(953, 558);
            lblalertaVentas.Name = "lblalertaVentas";
            lblalertaVentas.Size = new Size(0, 21);
            lblalertaVentas.TabIndex = 56;
            // 
            // lblAlertaCarrito
            // 
            lblAlertaCarrito.AutoSize = true;
            lblAlertaCarrito.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlertaCarrito.Location = new Point(941, 330);
            lblAlertaCarrito.Name = "lblAlertaCarrito";
            lblAlertaCarrito.Size = new Size(0, 21);
            lblAlertaCarrito.TabIndex = 57;
            // 
            // lblAlertadecuentoCatElectroHogar
            // 
            lblAlertadecuentoCatElectroHogar.AutoSize = true;
            lblAlertadecuentoCatElectroHogar.Location = new Point(906, 688);
            lblAlertadecuentoCatElectroHogar.Name = "lblAlertadecuentoCatElectroHogar";
            lblAlertadecuentoCatElectroHogar.Size = new Size(0, 21);
            lblAlertadecuentoCatElectroHogar.TabIndex = 58;
            // 
            // lblAlertaVenta
            // 
            lblAlertaVenta.AutoSize = true;
            lblAlertaVenta.BackColor = Color.Transparent;
            lblAlertaVenta.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlertaVenta.ForeColor = Color.Green;
            lblAlertaVenta.Location = new Point(872, 407);
            lblAlertaVenta.Name = "lblAlertaVenta";
            lblAlertaVenta.Size = new Size(52, 21);
            lblAlertaVenta.TabIndex = 59;
            lblAlertaVenta.Text = "label1";
            // 
            // FrmVenta
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1481, 815);
            Controls.Add(lblAlertaVenta);
            Controls.Add(lblAlertadecuentoCatElectroHogar);
            Controls.Add(lblAlertaCarrito);
            Controls.Add(lblalertaVentas);
            Controls.Add(lblClienteNuevo);
            Controls.Add(lblTotal);
            Controls.Add(labelCantidad);
            Controls.Add(numericUpDownCantidad);
            Controls.Add(Cliente);
            Controls.Add(lblFecha);
            Controls.Add(btnCompletarVenta);
            Controls.Add(btnRemover);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridViewProducto);
            Controls.Add(dateTimePickerVenta);
            Controls.Add(cbCliente);
            Controls.Add(groupBoxCarrito);
            Controls.Add(btnVolverInicio);
            Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FrmVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventas";
            WindowState = FormWindowState.Maximized;
            Load += FrmVenta_Load;
            groupBoxCarrito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnVolverInicio;
        private System.Windows.Forms.ListView listCarrito;
        private System.Windows.Forms.GroupBox groupBoxCarrito;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.DateTimePicker dateTimePickerVenta;
        private System.Windows.Forms.DataGridView dataGridViewProducto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnCompletarVenta;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.Label labelCantidad;
        private Label lblTotal;
        private Label lblClienteNuevo;
        private Label lblalertaVentas;
        private Label lblAlertaCarrito;
        private Label lblAlertadecuentoCatElectroHogar;
        private Label lblAlertaVenta;
    }
}
