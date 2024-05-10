namespace Presentacion
{
    partial class FrmProducto
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducto));
            btnVolverInicio = new Button();
            dataGridViewProducto = new DataGridView();
            checkBoxSmartTv = new CheckBox();
            checkBoxInformatica = new CheckBox();
            checkBoxElectro = new CheckBox();
            checkBoxCelulares = new CheckBox();
            checkBoxAudio = new CheckBox();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            lblStock = new Label();
            lblPrecio = new Label();
            lblNombre = new Label();
            numericUpDownStock = new NumericUpDown();
            lblCategoria = new Label();
            btnEliminarProducto = new Button();
            btnModificarProducto = new Button();
            btnAltaProducto = new Button();
            lblProveedor = new Label();
            dataGridViewProdProv = new DataGridView();
            lblIventario = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdProv).BeginInit();
            SuspendLayout();
            // 
            // btnVolverInicio
            // 
            btnVolverInicio.BackColor = SystemColors.Info;
            btnVolverInicio.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverInicio.Location = new Point(1297, 12);
            btnVolverInicio.Name = "btnVolverInicio";
            btnVolverInicio.Size = new Size(231, 33);
            btnVolverInicio.TabIndex = 42;
            btnVolverInicio.Text = "VOLVER MENU PRINCIPAL";
            btnVolverInicio.UseVisualStyleBackColor = false;
            btnVolverInicio.Click += btnVolverInicio_Click;
            // 
            // dataGridViewProducto
            // 
            dataGridViewProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewProducto.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewProducto.Location = new Point(611, 71);
            dataGridViewProducto.MultiSelect = false;
            dataGridViewProducto.Name = "dataGridViewProducto";
            dataGridViewProducto.ReadOnly = true;
            dataGridViewProducto.RowTemplate.Height = 25;
            dataGridViewProducto.Size = new Size(917, 716);
            dataGridViewProducto.TabIndex = 43;
            dataGridViewProducto.CellContentClick += dataGridViewProducto_CellContentClick_1;
            // 
            // checkBoxSmartTv
            // 
            checkBoxSmartTv.AutoSize = true;
            checkBoxSmartTv.BackColor = Color.Transparent;
            checkBoxSmartTv.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSmartTv.Location = new Point(246, 300);
            checkBoxSmartTv.Name = "checkBoxSmartTv";
            checkBoxSmartTv.Size = new Size(93, 25);
            checkBoxSmartTv.TabIndex = 63;
            checkBoxSmartTv.Text = "Smart TV";
            checkBoxSmartTv.UseVisualStyleBackColor = false;
            // 
            // checkBoxInformatica
            // 
            checkBoxInformatica.AutoSize = true;
            checkBoxInformatica.BackColor = Color.Transparent;
            checkBoxInformatica.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxInformatica.Location = new Point(246, 269);
            checkBoxInformatica.Name = "checkBoxInformatica";
            checkBoxInformatica.Size = new Size(108, 25);
            checkBoxInformatica.TabIndex = 62;
            checkBoxInformatica.Text = "Informática";
            checkBoxInformatica.UseVisualStyleBackColor = false;
            // 
            // checkBoxElectro
            // 
            checkBoxElectro.AutoSize = true;
            checkBoxElectro.BackColor = Color.Transparent;
            checkBoxElectro.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxElectro.Location = new Point(246, 238);
            checkBoxElectro.Name = "checkBoxElectro";
            checkBoxElectro.Size = new Size(123, 25);
            checkBoxElectro.TabIndex = 61;
            checkBoxElectro.Text = "Electro Hogar";
            checkBoxElectro.UseVisualStyleBackColor = false;
            // 
            // checkBoxCelulares
            // 
            checkBoxCelulares.AutoSize = true;
            checkBoxCelulares.BackColor = Color.Transparent;
            checkBoxCelulares.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxCelulares.Location = new Point(246, 207);
            checkBoxCelulares.Name = "checkBoxCelulares";
            checkBoxCelulares.Size = new Size(93, 25);
            checkBoxCelulares.TabIndex = 60;
            checkBoxCelulares.Text = "Celulares";
            checkBoxCelulares.UseVisualStyleBackColor = false;
            // 
            // checkBoxAudio
            // 
            checkBoxAudio.AutoSize = true;
            checkBoxAudio.BackColor = Color.Transparent;
            checkBoxAudio.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAudio.Location = new Point(246, 176);
            checkBoxAudio.Name = "checkBoxAudio";
            checkBoxAudio.Size = new Size(70, 25);
            checkBoxAudio.TabIndex = 59;
            checkBoxAudio.Text = "Audio";
            checkBoxAudio.UseVisualStyleBackColor = false;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Ebrima", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.Location = new Point(172, 71);
            txtPrecio.Margin = new Padding(4, 3, 4, 3);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(253, 26);
            txtPrecio.TabIndex = 68;
            txtPrecio.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Ebrima", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(172, 19);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(253, 26);
            txtNombre.TabIndex = 67;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.BackColor = Color.Transparent;
            lblStock.Font = new Font("Ebrima", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblStock.ForeColor = Color.Black;
            lblStock.Location = new Point(12, 126);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(46, 19);
            lblStock.TabIndex = 66;
            lblStock.Text = "Stock";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.Font = new Font("Ebrima", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecio.ForeColor = Color.Black;
            lblPrecio.Location = new Point(12, 71);
            lblPrecio.Margin = new Padding(4, 0, 4, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(52, 19);
            lblPrecio.TabIndex = 65;
            lblPrecio.Text = "Precio";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Ebrima", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(12, 19);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(65, 19);
            lblNombre.TabIndex = 64;
            lblNombre.Text = "Nombre";
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Location = new Point(172, 127);
            numericUpDownStock.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(120, 23);
            numericUpDownStock.TabIndex = 70;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = Color.Transparent;
            lblCategoria.Font = new Font("Ebrima", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoria.ForeColor = Color.Black;
            lblCategoria.Location = new Point(15, 176);
            lblCategoria.Margin = new Padding(4, 0, 4, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(193, 19);
            lblCategoria.TabIndex = 71;
            lblCategoria.Text = "Categoria que corresponde";
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminarProducto.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarProducto.ForeColor = Color.White;
            btnEliminarProducto.Location = new Point(376, 783);
            btnEliminarProducto.Margin = new Padding(4, 3, 4, 3);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(160, 50);
            btnEliminarProducto.TabIndex = 74;
            btnEliminarProducto.Text = "ELIMINAR";
            btnEliminarProducto.UseVisualStyleBackColor = false;
            btnEliminarProducto.Click += btnEliminarProducto_Click_1;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.BackColor = SystemColors.ActiveCaptionText;
            btnModificarProducto.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificarProducto.ForeColor = Color.White;
            btnModificarProducto.Location = new Point(195, 783);
            btnModificarProducto.Margin = new Padding(4, 3, 4, 3);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(160, 50);
            btnModificarProducto.TabIndex = 73;
            btnModificarProducto.Text = "MODIFICAR";
            btnModificarProducto.UseVisualStyleBackColor = false;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // btnAltaProducto
            // 
            btnAltaProducto.BackColor = SystemColors.ActiveCaptionText;
            btnAltaProducto.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAltaProducto.ForeColor = Color.White;
            btnAltaProducto.Location = new Point(12, 783);
            btnAltaProducto.Margin = new Padding(4, 3, 4, 3);
            btnAltaProducto.Name = "btnAltaProducto";
            btnAltaProducto.Size = new Size(160, 50);
            btnAltaProducto.TabIndex = 72;
            btnAltaProducto.Text = "DAR DE ALTA";
            btnAltaProducto.UseVisualStyleBackColor = false;
            btnAltaProducto.Click += btnAltaProducto_Click;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.BackColor = Color.Transparent;
            lblProveedor.Font = new Font("Ebrima", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblProveedor.ForeColor = Color.Black;
            lblProveedor.Location = new Point(15, 319);
            lblProveedor.Margin = new Padding(4, 0, 4, 0);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(81, 19);
            lblProveedor.TabIndex = 75;
            lblProveedor.Text = "Proveedor";
            // 
            // dataGridViewProdProv
            // 
            dataGridViewProdProv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewProdProv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewProdProv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdProv.Location = new Point(12, 341);
            dataGridViewProdProv.Name = "dataGridViewProdProv";
            dataGridViewProdProv.RowTemplate.Height = 25;
            dataGridViewProdProv.Size = new Size(521, 419);
            dataGridViewProdProv.TabIndex = 76;
            dataGridViewProdProv.CellContentClick += dataGridViewProdProv_CellContentClick;
            // 
            // lblIventario
            // 
            lblIventario.AutoSize = true;
            lblIventario.BackColor = Color.Transparent;
            lblIventario.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblIventario.ForeColor = Color.Black;
            lblIventario.Location = new Point(611, 49);
            lblIventario.Margin = new Padding(4, 0, 4, 0);
            lblIventario.Name = "lblIventario";
            lblIventario.Size = new Size(89, 21);
            lblIventario.TabIndex = 77;
            lblIventario.Text = "Inventario";
            // 
            // FrmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1540, 845);
            Controls.Add(lblIventario);
            Controls.Add(dataGridViewProdProv);
            Controls.Add(lblProveedor);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnModificarProducto);
            Controls.Add(btnAltaProducto);
            Controls.Add(lblCategoria);
            Controls.Add(numericUpDownStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(lblStock);
            Controls.Add(lblPrecio);
            Controls.Add(lblNombre);
            Controls.Add(checkBoxSmartTv);
            Controls.Add(checkBoxInformatica);
            Controls.Add(checkBoxElectro);
            Controls.Add(checkBoxCelulares);
            Controls.Add(checkBoxAudio);
            Controls.Add(dataGridViewProducto);
            Controls.Add(btnVolverInicio);
            Name = "FrmProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Producto";
            WindowState = FormWindowState.Maximized;
            Load += FrmProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdProv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolverInicio;
        private DataGridView dataGridViewProducto;
        private CheckBox checkBoxSmartTv;
        private CheckBox checkBoxInformatica;
        private CheckBox checkBoxElectro;
        private CheckBox checkBoxCelulares;
        private CheckBox checkBoxAudio;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private Label lblStock;
        private Label lblPrecio;
        private Label lblNombre;
        private NumericUpDown numericUpDownStock;
        private Label lblCategoria;
        private Button btnEliminarProducto;
        private Button btnModificarProducto;
        private Button btnAltaProducto;
        private Label lblProveedor;
        private DataGridView dataGridViewProdProv;
        private Label lblIventario;
    }
}