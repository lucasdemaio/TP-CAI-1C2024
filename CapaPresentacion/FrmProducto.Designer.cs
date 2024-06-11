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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            groupBoxStock = new GroupBox();
            groupBoxProductosBaja = new GroupBox();
            btnReactivarProducto = new Button();
            listViewProductosBaja = new ListView();
            linkLblReactivarProductos = new LinkLabel();
            btnLimpiar = new Button();
            lblalertaProductos = new Label();
            linkLabelProductosporCategoria = new LinkLabel();
            groupBoxProdporCategoria = new GroupBox();
            dataGridViewProductoporCategoria = new DataGridView();
            cbProductosporCategoria = new ComboBox();
            linkLabelStock = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdProv).BeginInit();
            groupBoxStock.SuspendLayout();
            groupBoxProductosBaja.SuspendLayout();
            groupBoxProdporCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductoporCategoria).BeginInit();
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
            dataGridViewProducto.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewProducto.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProducto.Location = new Point(0, 22);
            dataGridViewProducto.MultiSelect = false;
            dataGridViewProducto.Name = "dataGridViewProducto";
            dataGridViewProducto.ReadOnly = true;
            dataGridViewProducto.RowTemplate.Height = 25;
            dataGridViewProducto.Size = new Size(948, 625);
            dataGridViewProducto.TabIndex = 43;
            dataGridViewProducto.CellContentClick += dataGridViewProducto_CellContentClick_1;
            // 
            // checkBoxSmartTv
            // 
            checkBoxSmartTv.AutoSize = true;
            checkBoxSmartTv.BackColor = Color.Transparent;
            checkBoxSmartTv.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSmartTv.Location = new Point(222, 267);
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
            checkBoxInformatica.Location = new Point(222, 236);
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
            checkBoxElectro.Location = new Point(222, 205);
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
            checkBoxCelulares.Location = new Point(222, 174);
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
            checkBoxAudio.Location = new Point(222, 143);
            checkBoxAudio.Name = "checkBoxAudio";
            checkBoxAudio.Size = new Size(70, 25);
            checkBoxAudio.TabIndex = 59;
            checkBoxAudio.Text = "Audio";
            checkBoxAudio.UseVisualStyleBackColor = false;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.Location = new Point(172, 58);
            txtPrecio.Margin = new Padding(4, 3, 4, 3);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(253, 29);
            txtPrecio.TabIndex = 68;
            txtPrecio.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(172, 19);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(253, 29);
            txtNombre.TabIndex = 67;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.BackColor = Color.Transparent;
            lblStock.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStock.ForeColor = Color.Black;
            lblStock.Location = new Point(12, 99);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(52, 21);
            lblStock.TabIndex = 66;
            lblStock.Text = "Stock";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecio.ForeColor = Color.Black;
            lblPrecio.Location = new Point(12, 58);
            lblPrecio.Margin = new Padding(4, 0, 4, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(58, 21);
            lblPrecio.TabIndex = 65;
            lblPrecio.Text = "Precio";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(12, 19);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(100, 21);
            lblNombre.TabIndex = 64;
            lblNombre.Text = "Descripcion";
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownStock.Location = new Point(172, 99);
            numericUpDownStock.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(120, 29);
            numericUpDownStock.TabIndex = 70;
            numericUpDownStock.ValueChanged += numericUpDownStock_ValueChanged;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = Color.Transparent;
            lblCategoria.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoria.ForeColor = Color.Black;
            lblCategoria.Location = new Point(15, 143);
            lblCategoria.Margin = new Padding(4, 0, 4, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(186, 21);
            lblCategoria.TabIndex = 71;
            lblCategoria.Text = "Categoria del Producto";
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
            lblProveedor.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblProveedor.ForeColor = Color.Black;
            lblProveedor.Location = new Point(15, 317);
            lblProveedor.Margin = new Padding(4, 0, 4, 0);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(283, 21);
            lblProveedor.TabIndex = 75;
            lblProveedor.Text = "Seleccionar Proveedor del Producto";
            // 
            // dataGridViewProdProv
            // 
            dataGridViewProdProv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProdProv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewProdProv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewProdProv.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewProdProv.Location = new Point(12, 341);
            dataGridViewProdProv.MultiSelect = false;
            dataGridViewProdProv.Name = "dataGridViewProdProv";
            dataGridViewProdProv.ReadOnly = true;
            dataGridViewCellStyle4.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewProdProv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewProdProv.RowTemplate.Height = 25;
            dataGridViewProdProv.Size = new Size(521, 357);
            dataGridViewProdProv.TabIndex = 76;
            dataGridViewProdProv.CellContentClick += dataGridViewProdProv_CellContentClick;
            // 
            // groupBoxStock
            // 
            groupBoxStock.BackColor = Color.Transparent;
            groupBoxStock.Controls.Add(dataGridViewProducto);
            groupBoxStock.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxStock.Location = new Point(574, 51);
            groupBoxStock.Name = "groupBoxStock";
            groupBoxStock.Size = new Size(954, 661);
            groupBoxStock.TabIndex = 78;
            groupBoxStock.TabStop = false;
            groupBoxStock.Text = "Stock Actual";
            // 
            // groupBoxProductosBaja
            // 
            groupBoxProductosBaja.Controls.Add(btnReactivarProducto);
            groupBoxProductosBaja.Controls.Add(listViewProductosBaja);
            groupBoxProductosBaja.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxProductosBaja.Location = new Point(627, 205);
            groupBoxProductosBaja.Name = "groupBoxProductosBaja";
            groupBoxProductosBaja.Size = new Size(847, 493);
            groupBoxProductosBaja.TabIndex = 81;
            groupBoxProductosBaja.TabStop = false;
            groupBoxProductosBaja.Text = "Productos dados de Baja";
            groupBoxProductosBaja.Visible = false;
            // 
            // btnReactivarProducto
            // 
            btnReactivarProducto.BackColor = SystemColors.ActiveCaptionText;
            btnReactivarProducto.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReactivarProducto.ForeColor = Color.White;
            btnReactivarProducto.Location = new Point(334, 437);
            btnReactivarProducto.Margin = new Padding(4, 3, 4, 3);
            btnReactivarProducto.Name = "btnReactivarProducto";
            btnReactivarProducto.Size = new Size(160, 50);
            btnReactivarProducto.TabIndex = 85;
            btnReactivarProducto.Text = "REACTIVAR";
            btnReactivarProducto.UseVisualStyleBackColor = false;
            btnReactivarProducto.Click += btnReactivarProducto_Click;
            // 
            // listViewProductosBaja
            // 
            listViewProductosBaja.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listViewProductosBaja.FullRowSelect = true;
            listViewProductosBaja.Location = new Point(12, 27);
            listViewProductosBaja.Name = "listViewProductosBaja";
            listViewProductosBaja.Size = new Size(816, 401);
            listViewProductosBaja.TabIndex = 82;
            listViewProductosBaja.UseCompatibleStateImageBehavior = false;
            listViewProductosBaja.View = View.Details;
            listViewProductosBaja.SelectedIndexChanged += listViewProductosBaja_SelectedIndexChanged;
            // 
            // linkLblReactivarProductos
            // 
            linkLblReactivarProductos.AutoSize = true;
            linkLblReactivarProductos.BackColor = Color.Transparent;
            linkLblReactivarProductos.Font = new Font("Ebrima", 12F, FontStyle.Underline, GraphicsUnit.Point);
            linkLblReactivarProductos.ForeColor = Color.Blue;
            linkLblReactivarProductos.LinkColor = Color.Black;
            linkLblReactivarProductos.Location = new Point(733, 715);
            linkLblReactivarProductos.Name = "linkLblReactivarProductos";
            linkLblReactivarProductos.Size = new Size(248, 21);
            linkLblReactivarProductos.TabIndex = 44;
            linkLblReactivarProductos.TabStop = true;
            linkLblReactivarProductos.Text = "Reactivar Productos dados de baja";
            linkLblReactivarProductos.LinkClicked += linkLblReactivarProductos_LinkClicked;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.Highlight;
            btnLimpiar.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(373, 258);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(160, 41);
            btnLimpiar.TabIndex = 79;
            btnLimpiar.Text = "Limpiar Campos";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblalertaProductos
            // 
            lblalertaProductos.AutoSize = true;
            lblalertaProductos.BackColor = Color.Transparent;
            lblalertaProductos.Font = new Font("Ebrima", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblalertaProductos.ForeColor = Color.FromArgb(192, 0, 0);
            lblalertaProductos.Location = new Point(15, 733);
            lblalertaProductos.Margin = new Padding(4, 0, 4, 0);
            lblalertaProductos.Name = "lblalertaProductos";
            lblalertaProductos.Size = new Size(0, 21);
            lblalertaProductos.TabIndex = 80;
            // 
            // linkLabelProductosporCategoria
            // 
            linkLabelProductosporCategoria.AutoSize = true;
            linkLabelProductosporCategoria.BackColor = Color.Transparent;
            linkLabelProductosporCategoria.Font = new Font("Ebrima", 12F, FontStyle.Underline, GraphicsUnit.Point);
            linkLabelProductosporCategoria.LinkColor = Color.Black;
            linkLabelProductosporCategoria.Location = new Point(1161, 715);
            linkLabelProductosporCategoria.Name = "linkLabelProductosporCategoria";
            linkLabelProductosporCategoria.Size = new Size(207, 21);
            linkLabelProductosporCategoria.TabIndex = 82;
            linkLabelProductosporCategoria.TabStop = true;
            linkLabelProductosporCategoria.Text = "Ver Productos por Categoria";
            linkLabelProductosporCategoria.LinkClicked += linkLabelProductosporCategoria_LinkClicked;
            // 
            // groupBoxProdporCategoria
            // 
            groupBoxProdporCategoria.Controls.Add(dataGridViewProductoporCategoria);
            groupBoxProdporCategoria.Controls.Add(cbProductosporCategoria);
            groupBoxProdporCategoria.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxProdporCategoria.Location = new Point(627, 83);
            groupBoxProdporCategoria.Name = "groupBoxProdporCategoria";
            groupBoxProdporCategoria.Size = new Size(847, 408);
            groupBoxProdporCategoria.TabIndex = 83;
            groupBoxProdporCategoria.TabStop = false;
            groupBoxProdporCategoria.Text = "Productos Por Categoria";
            groupBoxProdporCategoria.Visible = false;
            // 
            // dataGridViewProductoporCategoria
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewProductoporCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewProductoporCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridViewProductoporCategoria.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewProductoporCategoria.Location = new Point(16, 88);
            dataGridViewProductoporCategoria.MultiSelect = false;
            dataGridViewProductoporCategoria.Name = "dataGridViewProductoporCategoria";
            dataGridViewProductoporCategoria.ReadOnly = true;
            dataGridViewProductoporCategoria.RowTemplate.Height = 25;
            dataGridViewProductoporCategoria.Size = new Size(812, 307);
            dataGridViewProductoporCategoria.TabIndex = 1;
            dataGridViewProductoporCategoria.CellFormatting += dataGridViewProductoporCategoria_CellFormatting;
            // 
            // cbProductosporCategoria
            // 
            cbProductosporCategoria.FormattingEnabled = true;
            cbProductosporCategoria.Location = new Point(16, 36);
            cbProductosporCategoria.Name = "cbProductosporCategoria";
            cbProductosporCategoria.Size = new Size(179, 29);
            cbProductosporCategoria.TabIndex = 0;
            cbProductosporCategoria.SelectedIndexChanged += cbProductosporCategoria_SelectedIndexChanged;
            // 
            // linkLabelStock
            // 
            linkLabelStock.AutoSize = true;
            linkLabelStock.BackColor = Color.Transparent;
            linkLabelStock.Font = new Font("Ebrima", 12F, FontStyle.Underline, GraphicsUnit.Point);
            linkLabelStock.ForeColor = Color.Blue;
            linkLabelStock.LinkColor = Color.Black;
            linkLabelStock.Location = new Point(931, 762);
            linkLabelStock.Name = "linkLabelStock";
            linkLabelStock.Size = new Size(158, 21);
            linkLabelStock.TabIndex = 84;
            linkLabelStock.TabStop = true;
            linkLabelStock.Text = "Volver al Stock actual";
            linkLabelStock.LinkClicked += linkLabelStock_LinkClicked;
            // 
            // FrmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1540, 845);
            Controls.Add(linkLabelStock);
            Controls.Add(groupBoxProdporCategoria);
            Controls.Add(linkLabelProductosporCategoria);
            Controls.Add(groupBoxProductosBaja);
            Controls.Add(linkLblReactivarProductos);
            Controls.Add(lblalertaProductos);
            Controls.Add(btnLimpiar);
            Controls.Add(groupBoxStock);
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
            Controls.Add(btnVolverInicio);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Producto";
            WindowState = FormWindowState.Maximized;
            Load += FrmProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdProv).EndInit();
            groupBoxStock.ResumeLayout(false);
            groupBoxProductosBaja.ResumeLayout(false);
            groupBoxProdporCategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductoporCategoria).EndInit();
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
        private GroupBox groupBoxStock;
        private Button btnLimpiar;
        private Label lblalertaProductos;
        private LinkLabel linkLblReactivarProductos;
        private GroupBox groupBoxProductosBaja;
        private ListView listViewProductosBaja;
        private LinkLabel linkLabelProductosporCategoria;
        private GroupBox groupBoxProdporCategoria;
        private DataGridView dataGridViewProductoporCategoria;
        private ComboBox cbProductosporCategoria;
        private LinkLabel linkLabelStock;
        private Button btnReactivarProducto;
    }
}