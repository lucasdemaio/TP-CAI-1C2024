namespace Presentacion
{
    partial class FrmProveedores
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
            btnVolverInicio = new Button();
            dataGridViewProveedores = new DataGridView();
            txtEmail = new TextBox();
            txtCUIT = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblCUIT = new Label();
            lblEmail = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            lblCategorias = new Label();
            checkBoxAudio = new CheckBox();
            checkBoxCelulares = new CheckBox();
            checkBoxElectro = new CheckBox();
            checkBoxInformatica = new CheckBox();
            checkBoxSmartTv = new CheckBox();
            btnAltaProveedor = new Button();
            groupBoxABMProveedor = new GroupBox();
            lblAlertaProveedores = new Label();
            btnLimpiar = new Button();
            btnEliminarProveedor = new Button();
            btnModificarProveedor = new Button();
            btnReactivarProveedor = new Button();
            cbCategorias = new ComboBox();
            dataGridViewProveedoresCat = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedores).BeginInit();
            groupBoxABMProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedoresCat).BeginInit();
            SuspendLayout();
            // 
            // btnVolverInicio
            // 
            btnVolverInicio.BackColor = SystemColors.Info;
            btnVolverInicio.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverInicio.Location = new Point(1308, 800);
            btnVolverInicio.Name = "btnVolverInicio";
            btnVolverInicio.Size = new Size(220, 33);
            btnVolverInicio.TabIndex = 43;
            btnVolverInicio.Text = "VOLVER MENU PRINCIPAL";
            btnVolverInicio.UseVisualStyleBackColor = false;
            btnVolverInicio.Click += btnVolverInicio_Click;
            // 
            // dataGridViewProveedores
            // 
            dataGridViewProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewProveedores.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewProveedores.Location = new Point(13, 380);
            dataGridViewProveedores.MultiSelect = false;
            dataGridViewProveedores.Name = "dataGridViewProveedores";
            dataGridViewProveedores.RowTemplate.Height = 25;
            dataGridViewProveedores.Size = new Size(1515, 406);
            dataGridViewProveedores.TabIndex = 44;
            dataGridViewProveedores.CellContentClick += dataGridViewProveedores_CellContentClick;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(166, 131);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(253, 29);
            txtEmail.TabIndex = 52;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCUIT
            // 
            txtCUIT.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCUIT.Location = new Point(166, 185);
            txtCUIT.Margin = new Padding(4, 3, 4, 3);
            txtCUIT.Name = "txtCUIT";
            txtCUIT.Size = new Size(253, 29);
            txtCUIT.TabIndex = 51;
            txtCUIT.TextAlign = HorizontalAlignment.Center;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(166, 79);
            txtApellido.Margin = new Padding(4, 3, 4, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(253, 29);
            txtApellido.TabIndex = 50;
            txtApellido.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(166, 27);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(253, 29);
            txtNombre.TabIndex = 49;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCUIT
            // 
            lblCUIT.AutoSize = true;
            lblCUIT.BackColor = Color.Transparent;
            lblCUIT.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCUIT.ForeColor = Color.Black;
            lblCUIT.Location = new Point(6, 185);
            lblCUIT.Margin = new Padding(4, 0, 4, 0);
            lblCUIT.Name = "lblCUIT";
            lblCUIT.Size = new Size(46, 21);
            lblCUIT.TabIndex = 48;
            lblCUIT.Text = "CUIT";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(6, 134);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 21);
            lblEmail.TabIndex = 47;
            lblEmail.Text = "eMail";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.ForeColor = Color.Black;
            lblApellido.Location = new Point(6, 79);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(75, 21);
            lblApellido.TabIndex = 46;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(6, 27);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(73, 21);
            lblNombre.TabIndex = 45;
            lblNombre.Text = "Nombre";
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.BackColor = Color.Transparent;
            lblCategorias.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategorias.ForeColor = Color.Black;
            lblCategorias.Location = new Point(479, 34);
            lblCategorias.Margin = new Padding(4, 0, 4, 0);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(107, 21);
            lblCategorias.TabIndex = 53;
            lblCategorias.Text = "CATEGORIAS";
            // 
            // checkBoxAudio
            // 
            checkBoxAudio.AutoSize = true;
            checkBoxAudio.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAudio.Location = new Point(639, 30);
            checkBoxAudio.Name = "checkBoxAudio";
            checkBoxAudio.Size = new Size(70, 25);
            checkBoxAudio.TabIndex = 54;
            checkBoxAudio.Text = "Audio";
            checkBoxAudio.UseVisualStyleBackColor = true;
            // 
            // checkBoxCelulares
            // 
            checkBoxCelulares.AutoSize = true;
            checkBoxCelulares.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxCelulares.Location = new Point(639, 55);
            checkBoxCelulares.Name = "checkBoxCelulares";
            checkBoxCelulares.Size = new Size(93, 25);
            checkBoxCelulares.TabIndex = 55;
            checkBoxCelulares.Text = "Celulares";
            checkBoxCelulares.UseVisualStyleBackColor = true;
            // 
            // checkBoxElectro
            // 
            checkBoxElectro.AutoSize = true;
            checkBoxElectro.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxElectro.Location = new Point(639, 80);
            checkBoxElectro.Name = "checkBoxElectro";
            checkBoxElectro.Size = new Size(123, 25);
            checkBoxElectro.TabIndex = 56;
            checkBoxElectro.Text = "Electro Hogar";
            checkBoxElectro.UseVisualStyleBackColor = true;
            // 
            // checkBoxInformatica
            // 
            checkBoxInformatica.AutoSize = true;
            checkBoxInformatica.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxInformatica.Location = new Point(639, 105);
            checkBoxInformatica.Name = "checkBoxInformatica";
            checkBoxInformatica.Size = new Size(108, 25);
            checkBoxInformatica.TabIndex = 57;
            checkBoxInformatica.Text = "Informática";
            checkBoxInformatica.UseVisualStyleBackColor = true;
            // 
            // checkBoxSmartTv
            // 
            checkBoxSmartTv.AutoSize = true;
            checkBoxSmartTv.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSmartTv.Location = new Point(639, 130);
            checkBoxSmartTv.Name = "checkBoxSmartTv";
            checkBoxSmartTv.Size = new Size(93, 25);
            checkBoxSmartTv.TabIndex = 58;
            checkBoxSmartTv.Text = "Smart TV";
            checkBoxSmartTv.UseVisualStyleBackColor = true;
            // 
            // btnAltaProveedor
            // 
            btnAltaProveedor.BackColor = SystemColors.ActiveCaptionText;
            btnAltaProveedor.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAltaProveedor.ForeColor = Color.White;
            btnAltaProveedor.Location = new Point(26, 256);
            btnAltaProveedor.Margin = new Padding(4, 3, 4, 3);
            btnAltaProveedor.Name = "btnAltaProveedor";
            btnAltaProveedor.Size = new Size(160, 50);
            btnAltaProveedor.TabIndex = 59;
            btnAltaProveedor.Text = "DAR DE ALTA";
            btnAltaProveedor.UseVisualStyleBackColor = false;
            btnAltaProveedor.Click += btnAltaProveedor_Click;
            // 
            // groupBoxABMProveedor
            // 
            groupBoxABMProveedor.Controls.Add(lblAlertaProveedores);
            groupBoxABMProveedor.Controls.Add(btnLimpiar);
            groupBoxABMProveedor.Controls.Add(btnEliminarProveedor);
            groupBoxABMProveedor.Controls.Add(btnModificarProveedor);
            groupBoxABMProveedor.Controls.Add(btnAltaProveedor);
            groupBoxABMProveedor.Controls.Add(checkBoxSmartTv);
            groupBoxABMProveedor.Controls.Add(checkBoxInformatica);
            groupBoxABMProveedor.Controls.Add(checkBoxElectro);
            groupBoxABMProveedor.Controls.Add(checkBoxCelulares);
            groupBoxABMProveedor.Controls.Add(checkBoxAudio);
            groupBoxABMProveedor.Controls.Add(lblCategorias);
            groupBoxABMProveedor.Controls.Add(txtEmail);
            groupBoxABMProveedor.Controls.Add(txtCUIT);
            groupBoxABMProveedor.Controls.Add(txtApellido);
            groupBoxABMProveedor.Controls.Add(txtNombre);
            groupBoxABMProveedor.Controls.Add(lblCUIT);
            groupBoxABMProveedor.Controls.Add(lblEmail);
            groupBoxABMProveedor.Controls.Add(lblApellido);
            groupBoxABMProveedor.Controls.Add(lblNombre);
            groupBoxABMProveedor.Font = new Font("Ebrima", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxABMProveedor.Location = new Point(7, 6);
            groupBoxABMProveedor.Name = "groupBoxABMProveedor";
            groupBoxABMProveedor.Size = new Size(780, 349);
            groupBoxABMProveedor.TabIndex = 60;
            groupBoxABMProveedor.TabStop = false;
            groupBoxABMProveedor.Text = "ABM Proveedor";
            // 
            // lblAlertaProveedores
            // 
            lblAlertaProveedores.AutoSize = true;
            lblAlertaProveedores.Font = new Font("Ebrima", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblAlertaProveedores.Location = new Point(105, 228);
            lblAlertaProveedores.Name = "lblAlertaProveedores";
            lblAlertaProveedores.Size = new Size(0, 21);
            lblAlertaProveedores.TabIndex = 63;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.Highlight;
            btnLimpiar.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(576, 185);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(160, 41);
            btnLimpiar.TabIndex = 63;
            btnLimpiar.Text = "Limpiar Campos";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminarProveedor
            // 
            btnEliminarProveedor.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminarProveedor.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarProveedor.ForeColor = Color.White;
            btnEliminarProveedor.Location = new Point(576, 256);
            btnEliminarProveedor.Margin = new Padding(4, 3, 4, 3);
            btnEliminarProveedor.Name = "btnEliminarProveedor";
            btnEliminarProveedor.Size = new Size(160, 50);
            btnEliminarProveedor.TabIndex = 61;
            btnEliminarProveedor.Text = "ELIMINAR";
            btnEliminarProveedor.UseVisualStyleBackColor = false;
            btnEliminarProveedor.Click += btnEliminarProveedor_Click;
            // 
            // btnModificarProveedor
            // 
            btnModificarProveedor.BackColor = SystemColors.ActiveCaptionText;
            btnModificarProveedor.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificarProveedor.ForeColor = Color.White;
            btnModificarProveedor.Location = new Point(204, 256);
            btnModificarProveedor.Margin = new Padding(4, 3, 4, 3);
            btnModificarProveedor.Name = "btnModificarProveedor";
            btnModificarProveedor.Size = new Size(160, 50);
            btnModificarProveedor.TabIndex = 60;
            btnModificarProveedor.Text = "MODIFICAR";
            btnModificarProveedor.UseVisualStyleBackColor = false;
            btnModificarProveedor.Click += btnModificarProveedor_Click;
            // 
            // btnReactivarProveedor
            // 
            btnReactivarProveedor.BackColor = SystemColors.ActiveCaptionText;
            btnReactivarProveedor.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReactivarProveedor.ForeColor = Color.White;
            btnReactivarProveedor.Location = new Point(1087, 305);
            btnReactivarProveedor.Margin = new Padding(4, 3, 4, 3);
            btnReactivarProveedor.Name = "btnReactivarProveedor";
            btnReactivarProveedor.Size = new Size(160, 50);
            btnReactivarProveedor.TabIndex = 62;
            btnReactivarProveedor.Text = "REACTIVAR";
            btnReactivarProveedor.UseVisualStyleBackColor = false;
            btnReactivarProveedor.Click += btnReactivarProveedor_Click;
            // 
            // cbCategorias
            // 
            cbCategorias.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategorias.FormattingEnabled = true;
            cbCategorias.Location = new Point(1054, 54);
            cbCategorias.Name = "cbCategorias";
            cbCategorias.Size = new Size(215, 29);
            cbCategorias.TabIndex = 61;
            cbCategorias.SelectedIndexChanged += cbCategorias_SelectedIndexChanged_1;
            // 
            // dataGridViewProveedoresCat
            // 
            dataGridViewProveedoresCat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProveedoresCat.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewProveedoresCat.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewProveedoresCat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewProveedoresCat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewProveedoresCat.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewProveedoresCat.Location = new Point(862, 89);
            dataGridViewProveedoresCat.MultiSelect = false;
            dataGridViewProveedoresCat.Name = "dataGridViewProveedoresCat";
            dataGridViewProveedoresCat.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewProveedoresCat.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewProveedoresCat.RowTemplate.Height = 25;
            dataGridViewProveedoresCat.Size = new Size(607, 205);
            dataGridViewProveedoresCat.TabIndex = 62;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(1016, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(298, 21);
            label1.TabIndex = 62;
            label1.Text = "FILTRAR PROVEEDOR POR CATEGORIA";
            // 
            // FrmProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1540, 845);
            Controls.Add(label1);
            Controls.Add(dataGridViewProveedoresCat);
            Controls.Add(btnReactivarProveedor);
            Controls.Add(cbCategorias);
            Controls.Add(groupBoxABMProveedor);
            Controls.Add(dataGridViewProveedores);
            Controls.Add(btnVolverInicio);
            Name = "FrmProveedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proveedores";
            WindowState = FormWindowState.Maximized;
            Load += FrmProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedores).EndInit();
            groupBoxABMProveedor.ResumeLayout(false);
            groupBoxABMProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedoresCat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolverInicio;
        private DataGridView dataGridViewProveedores;
        private TextBox txtEmail;
        private TextBox txtCUIT;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblCUIT;
        private Label lblEmail;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblCategorias;
        private CheckBox checkBoxAudio;
        private CheckBox checkBoxCelulares;
        private CheckBox checkBoxElectro;
        private CheckBox checkBoxInformatica;
        private CheckBox checkBoxSmartTv;
        private Button btnAltaProveedor;
        private GroupBox groupBoxABMProveedor;
        private Button btnEliminarProveedor;
        private Button btnModificarProveedor;
        private ComboBox cbCategorias;
        private DataGridView dataGridViewProveedoresCat;
        private Label label1;
        private Button btnReactivarProveedor;
        private Button btnLimpiar;
        private Label lblAlertaProveedores;
    }
}