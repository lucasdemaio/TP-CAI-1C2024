namespace Presentacion
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            dataGridViewCliente = new DataGridView();
            lblDatos = new Label();
            dateTimeFechaNacimiento = new DateTimePicker();
            lblFechaNacimiento = new Label();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtDNI = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblDNI = new Label();
            lblEmail = new Label();
            lblTelefono = new Label();
            lblDireccion = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            btnVolverInicio = new Button();
            btnAltaCliente = new Button();
            btnEliminarCliente = new Button();
            btnModificarCliente = new Button();
            btnLimpiar = new Button();
            groupBox1 = new GroupBox();
            btnReactivarCliente = new Button();
            cbReactivarCliente = new ComboBox();
            lblAlertaClientes = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCliente).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewCliente
            // 
            dataGridViewCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCliente.Location = new Point(12, 359);
            dataGridViewCliente.MultiSelect = false;
            dataGridViewCliente.Name = "dataGridViewCliente";
            dataGridViewCliente.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCliente.RowTemplate.Height = 25;
            dataGridViewCliente.Size = new Size(1516, 474);
            dataGridViewCliente.TabIndex = 0;
            dataGridViewCliente.CellContentClick += dataGridViewCliente_CellContentClick;
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.BackColor = Color.Transparent;
            lblDatos.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDatos.ForeColor = Color.Black;
            lblDatos.Location = new Point(56, 9);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(71, 21);
            lblDatos.TabIndex = 1;
            lblDatos.Text = "Clientes";
            // 
            // dateTimeFechaNacimiento
            // 
            dateTimeFechaNacimiento.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeFechaNacimiento.Format = DateTimePickerFormat.Short;
            dateTimeFechaNacimiento.Location = new Point(616, 100);
            dateTimeFechaNacimiento.Name = "dateTimeFechaNacimiento";
            dateTimeFechaNacimiento.Size = new Size(250, 29);
            dateTimeFechaNacimiento.TabIndex = 40;
            dateTimeFechaNacimiento.Value = new DateTime(2006, 5, 30, 0, 0, 0, 0);
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.BackColor = Color.Transparent;
            lblFechaNacimiento.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaNacimiento.ForeColor = Color.Black;
            lblFechaNacimiento.Location = new Point(444, 105);
            lblFechaNacimiento.Margin = new Padding(4, 0, 4, 0);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(148, 21);
            lblFechaNacimiento.TabIndex = 39;
            lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(613, 61);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(253, 29);
            txtEmail.TabIndex = 38;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(141, 233);
            txtTelefono.Margin = new Padding(4, 3, 4, 3);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(253, 29);
            txtTelefono.TabIndex = 37;
            txtTelefono.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.Location = new Point(141, 187);
            txtDireccion.Margin = new Padding(4, 3, 4, 3);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(253, 29);
            txtDireccion.TabIndex = 36;
            txtDireccion.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDNI
            // 
            txtDNI.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDNI.Location = new Point(141, 143);
            txtDNI.Margin = new Padding(4, 3, 4, 3);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(253, 29);
            txtDNI.TabIndex = 35;
            txtDNI.TextAlign = HorizontalAlignment.Center;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(141, 103);
            txtApellido.Margin = new Padding(4, 3, 4, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(253, 29);
            txtApellido.TabIndex = 34;
            txtApellido.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(141, 57);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(253, 29);
            txtNombre.TabIndex = 33;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.BackColor = Color.Transparent;
            lblDNI.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDNI.ForeColor = Color.Black;
            lblDNI.Location = new Point(57, 145);
            lblDNI.Margin = new Padding(4, 0, 4, 0);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(40, 21);
            lblDNI.TabIndex = 30;
            lblDNI.Text = "DNI";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(444, 71);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 21);
            lblEmail.TabIndex = 28;
            lblEmail.Text = "Email";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.Transparent;
            lblTelefono.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefono.ForeColor = Color.Black;
            lblTelefono.Location = new Point(57, 235);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(78, 21);
            lblTelefono.TabIndex = 27;
            lblTelefono.Text = "Telefono";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.BackColor = Color.Transparent;
            lblDireccion.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDireccion.ForeColor = Color.Black;
            lblDireccion.Location = new Point(57, 189);
            lblDireccion.Margin = new Padding(4, 0, 4, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(83, 21);
            lblDireccion.TabIndex = 26;
            lblDireccion.Text = "Direccion";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.ForeColor = Color.Black;
            lblApellido.Location = new Point(57, 105);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(75, 21);
            lblApellido.TabIndex = 25;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(57, 64);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(73, 21);
            lblNombre.TabIndex = 24;
            lblNombre.Text = "Nombre";
            // 
            // btnVolverInicio
            // 
            btnVolverInicio.BackColor = SystemColors.Info;
            btnVolverInicio.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverInicio.Location = new Point(1296, 12);
            btnVolverInicio.Name = "btnVolverInicio";
            btnVolverInicio.Size = new Size(231, 33);
            btnVolverInicio.TabIndex = 41;
            btnVolverInicio.Text = "VOLVER MENU PRINCIPAL";
            btnVolverInicio.UseVisualStyleBackColor = false;
            btnVolverInicio.Click += btnVolverInicio_Click;
            // 
            // btnAltaCliente
            // 
            btnAltaCliente.BackColor = SystemColors.ActiveCaptionText;
            btnAltaCliente.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAltaCliente.ForeColor = Color.White;
            btnAltaCliente.Location = new Point(205, 291);
            btnAltaCliente.Margin = new Padding(4, 3, 4, 3);
            btnAltaCliente.Name = "btnAltaCliente";
            btnAltaCliente.Size = new Size(160, 45);
            btnAltaCliente.TabIndex = 42;
            btnAltaCliente.Text = "DAR DE ALTA";
            btnAltaCliente.UseVisualStyleBackColor = false;
            btnAltaCliente.Click += btnAltaCliente_Click;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminarCliente.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarCliente.ForeColor = Color.White;
            btnEliminarCliente.Location = new Point(571, 286);
            btnEliminarCliente.Margin = new Padding(4, 3, 4, 3);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(160, 50);
            btnEliminarCliente.TabIndex = 43;
            btnEliminarCliente.Text = "ELIMINAR";
            btnEliminarCliente.UseVisualStyleBackColor = false;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.BackColor = SystemColors.ActiveCaptionText;
            btnModificarCliente.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificarCliente.ForeColor = Color.White;
            btnModificarCliente.Location = new Point(387, 291);
            btnModificarCliente.Margin = new Padding(4, 3, 4, 3);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(160, 45);
            btnModificarCliente.TabIndex = 44;
            btnModificarCliente.Text = "MODIFICAR";
            btnModificarCliente.UseVisualStyleBackColor = false;
            btnModificarCliente.Click += btnModificarCliente_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.Highlight;
            btnLimpiar.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(556, 158);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(179, 38);
            btnLimpiar.TabIndex = 45;
            btnLimpiar.Text = "Limpiar Campos";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnReactivarCliente);
            groupBox1.Controls.Add(cbReactivarCliente);
            groupBox1.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(987, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(541, 223);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reactivar Clientes";
            // 
            // btnReactivarCliente
            // 
            btnReactivarCliente.BackColor = SystemColors.ActiveCaptionText;
            btnReactivarCliente.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReactivarCliente.ForeColor = Color.White;
            btnReactivarCliente.Location = new Point(208, 159);
            btnReactivarCliente.Margin = new Padding(4, 3, 4, 3);
            btnReactivarCliente.Name = "btnReactivarCliente";
            btnReactivarCliente.Size = new Size(160, 45);
            btnReactivarCliente.TabIndex = 47;
            btnReactivarCliente.Text = "REACTIVAR";
            btnReactivarCliente.UseVisualStyleBackColor = false;
            btnReactivarCliente.Click += btnReactivarCliente_Click;
            // 
            // cbReactivarCliente
            // 
            cbReactivarCliente.FormattingEnabled = true;
            cbReactivarCliente.Location = new Point(92, 58);
            cbReactivarCliente.Name = "cbReactivarCliente";
            cbReactivarCliente.Size = new Size(388, 29);
            cbReactivarCliente.TabIndex = 0;
            // 
            // lblAlertaClientes
            // 
            lblAlertaClientes.AutoSize = true;
            lblAlertaClientes.BackColor = Color.Transparent;
            lblAlertaClientes.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlertaClientes.ForeColor = Color.Green;
            lblAlertaClientes.Location = new Point(461, 209);
            lblAlertaClientes.Name = "lblAlertaClientes";
            lblAlertaClientes.Size = new Size(52, 21);
            lblAlertaClientes.TabIndex = 51;
            lblAlertaClientes.Text = "label1";
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1540, 845);
            Controls.Add(lblAlertaClientes);
            Controls.Add(groupBox1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnModificarCliente);
            Controls.Add(btnEliminarCliente);
            Controls.Add(btnAltaCliente);
            Controls.Add(btnVolverInicio);
            Controls.Add(dateTimeFechaNacimiento);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtDNI);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblDNI);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefono);
            Controls.Add(lblDireccion);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblDatos);
            Controls.Add(dataGridViewCliente);
            Name = "FrmCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            WindowState = FormWindowState.Maximized;
            Load += FrmCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCliente).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCliente;
        private Label lblDatos;
        private DateTimePicker dateTimeFechaNacimiento;
        private Label lblFechaNacimiento;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtDNI;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblDNI;
        private Label lblEmail;
        private Label lblTelefono;
        private Label lblDireccion;
        private Label lblApellido;
        private Label lblNombre;
        private Button btnVolverInicio;
        private Button btnAltaCliente;
        private Button btnEliminarCliente;
        private Button btnModificarCliente;
        private Button btnLimpiar;
        private GroupBox groupBox1;
        private Button btnReactivarCliente;
        private ComboBox cbReactivarCliente;
        private Label lblAlertaClientes;
    }
}