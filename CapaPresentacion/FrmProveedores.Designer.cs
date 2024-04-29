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
            btnEliminarProveedor = new Button();
            btnModificarProveedor = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedores).BeginInit();
            groupBoxABMProveedor.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolverInicio
            // 
            btnVolverInicio.BackColor = SystemColors.Info;
            btnVolverInicio.Location = new Point(840, 405);
            btnVolverInicio.Name = "btnVolverInicio";
            btnVolverInicio.Size = new Size(179, 33);
            btnVolverInicio.TabIndex = 43;
            btnVolverInicio.Text = "VOLVER MENU PRINCIPAL";
            btnVolverInicio.UseVisualStyleBackColor = false;
            btnVolverInicio.Click += btnVolverInicio_Click;
            // 
            // dataGridViewProveedores
            // 
            dataGridViewProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProveedores.Location = new Point(558, 12);
            dataGridViewProveedores.Name = "dataGridViewProveedores";
            dataGridViewProveedores.RowTemplate.Height = 25;
            dataGridViewProveedores.Size = new Size(491, 370);
            dataGridViewProveedores.TabIndex = 44;
            dataGridViewProveedores.CellContentClick += dataGridViewProveedores_CellContentClick;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Ebrima", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(166, 131);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(253, 26);
            txtEmail.TabIndex = 52;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCUIT
            // 
            txtCUIT.Font = new Font("Ebrima", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCUIT.Location = new Point(166, 185);
            txtCUIT.Margin = new Padding(4, 3, 4, 3);
            txtCUIT.Name = "txtCUIT";
            txtCUIT.Size = new Size(253, 26);
            txtCUIT.TabIndex = 51;
            txtCUIT.TextAlign = HorizontalAlignment.Center;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Ebrima", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(166, 79);
            txtApellido.Margin = new Padding(4, 3, 4, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(253, 26);
            txtApellido.TabIndex = 50;
            txtApellido.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Ebrima", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(166, 27);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(253, 26);
            txtNombre.TabIndex = 49;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCUIT
            // 
            lblCUIT.AutoSize = true;
            lblCUIT.BackColor = Color.Transparent;
            lblCUIT.Font = new Font("Ebrima", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblCUIT.ForeColor = Color.Black;
            lblCUIT.Location = new Point(6, 185);
            lblCUIT.Margin = new Padding(4, 0, 4, 0);
            lblCUIT.Name = "lblCUIT";
            lblCUIT.Size = new Size(40, 19);
            lblCUIT.TabIndex = 48;
            lblCUIT.Text = "CUIT";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Ebrima", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(6, 134);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 19);
            lblEmail.TabIndex = 47;
            lblEmail.Text = "eMail";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Font = new Font("Ebrima", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.ForeColor = Color.Black;
            lblApellido.Location = new Point(6, 79);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 19);
            lblApellido.TabIndex = 46;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Ebrima", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(6, 27);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(65, 19);
            lblNombre.TabIndex = 45;
            lblNombre.Text = "Nombre";
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.BackColor = Color.Transparent;
            lblCategorias.Font = new Font("Ebrima", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategorias.ForeColor = Color.Black;
            lblCategorias.Location = new Point(6, 242);
            lblCategorias.Margin = new Padding(4, 0, 4, 0);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(95, 19);
            lblCategorias.TabIndex = 53;
            lblCategorias.Text = "CATEGORIAS";
            // 
            // checkBoxAudio
            // 
            checkBoxAudio.AutoSize = true;
            checkBoxAudio.Font = new Font("Ebrima", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAudio.Location = new Point(166, 238);
            checkBoxAudio.Name = "checkBoxAudio";
            checkBoxAudio.Size = new Size(64, 23);
            checkBoxAudio.TabIndex = 54;
            checkBoxAudio.Text = "Audio";
            checkBoxAudio.UseVisualStyleBackColor = true;
            // 
            // checkBoxCelulares
            // 
            checkBoxCelulares.AutoSize = true;
            checkBoxCelulares.Font = new Font("Ebrima", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxCelulares.Location = new Point(166, 263);
            checkBoxCelulares.Name = "checkBoxCelulares";
            checkBoxCelulares.Size = new Size(83, 23);
            checkBoxCelulares.TabIndex = 55;
            checkBoxCelulares.Text = "Celulares";
            checkBoxCelulares.UseVisualStyleBackColor = true;
            // 
            // checkBoxElectro
            // 
            checkBoxElectro.AutoSize = true;
            checkBoxElectro.Font = new Font("Ebrima", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxElectro.Location = new Point(166, 288);
            checkBoxElectro.Name = "checkBoxElectro";
            checkBoxElectro.Size = new Size(111, 23);
            checkBoxElectro.TabIndex = 56;
            checkBoxElectro.Text = "Electro Hogar";
            checkBoxElectro.UseVisualStyleBackColor = true;
            // 
            // checkBoxInformatica
            // 
            checkBoxInformatica.AutoSize = true;
            checkBoxInformatica.Font = new Font("Ebrima", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxInformatica.Location = new Point(166, 313);
            checkBoxInformatica.Name = "checkBoxInformatica";
            checkBoxInformatica.Size = new Size(97, 23);
            checkBoxInformatica.TabIndex = 57;
            checkBoxInformatica.Text = "Informática";
            checkBoxInformatica.UseVisualStyleBackColor = true;
            // 
            // checkBoxSmartTv
            // 
            checkBoxSmartTv.AutoSize = true;
            checkBoxSmartTv.Font = new Font("Ebrima", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSmartTv.Location = new Point(166, 338);
            checkBoxSmartTv.Name = "checkBoxSmartTv";
            checkBoxSmartTv.Size = new Size(84, 23);
            checkBoxSmartTv.TabIndex = 58;
            checkBoxSmartTv.Text = "Smart TV";
            checkBoxSmartTv.UseVisualStyleBackColor = true;
            // 
            // btnAltaProveedor
            // 
            btnAltaProveedor.BackColor = SystemColors.ActiveCaptionText;
            btnAltaProveedor.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAltaProveedor.ForeColor = Color.White;
            btnAltaProveedor.Location = new Point(7, 382);
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
            groupBoxABMProveedor.Location = new Point(7, 6);
            groupBoxABMProveedor.Name = "groupBoxABMProveedor";
            groupBoxABMProveedor.Size = new Size(533, 440);
            groupBoxABMProveedor.TabIndex = 60;
            groupBoxABMProveedor.TabStop = false;
            groupBoxABMProveedor.Text = "ABM Proveedor";
            groupBoxABMProveedor.Enter += groupBoxABMProveedor_Enter;
            // 
            // btnEliminarProveedor
            // 
            btnEliminarProveedor.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminarProveedor.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarProveedor.ForeColor = Color.White;
            btnEliminarProveedor.Location = new Point(366, 382);
            btnEliminarProveedor.Margin = new Padding(4, 3, 4, 3);
            btnEliminarProveedor.Name = "btnEliminarProveedor";
            btnEliminarProveedor.Size = new Size(160, 50);
            btnEliminarProveedor.TabIndex = 61;
            btnEliminarProveedor.Text = "ELIMINAR";
            btnEliminarProveedor.UseVisualStyleBackColor = false;
            // 
            // btnModificarProveedor
            // 
            btnModificarProveedor.BackColor = SystemColors.ActiveCaptionText;
            btnModificarProveedor.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificarProveedor.ForeColor = Color.White;
            btnModificarProveedor.Location = new Point(185, 382);
            btnModificarProveedor.Margin = new Padding(4, 3, 4, 3);
            btnModificarProveedor.Name = "btnModificarProveedor";
            btnModificarProveedor.Size = new Size(160, 50);
            btnModificarProveedor.TabIndex = 60;
            btnModificarProveedor.Text = "MODIFICAR";
            btnModificarProveedor.UseVisualStyleBackColor = false;
            // 
            // FrmProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 450);
            Controls.Add(groupBoxABMProveedor);
            Controls.Add(dataGridViewProveedores);
            Controls.Add(btnVolverInicio);
            Name = "FrmProveedores";
            Text = "Proveedores";
            Load += FrmProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedores).EndInit();
            groupBoxABMProveedor.ResumeLayout(false);
            groupBoxABMProveedor.PerformLayout();
            ResumeLayout(false);
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
    }
}