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
            ((System.ComponentModel.ISupportInitialize)dataGridViewCliente).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCliente
            // 
            dataGridViewCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCliente.Location = new Point(12, 277);
            dataGridViewCliente.MultiSelect = false;
            dataGridViewCliente.Name = "dataGridViewCliente";
            dataGridViewCliente.ReadOnly = true;
            dataGridViewCliente.RowTemplate.Height = 25;
            dataGridViewCliente.Size = new Size(962, 236);
            dataGridViewCliente.TabIndex = 0;
            dataGridViewCliente.CellContentClick += dataGridViewCliente_CellContentClick;
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.BackColor = Color.Transparent;
            lblDatos.Font = new Font("Ebrima", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblDatos.ForeColor = Color.Black;
            lblDatos.Location = new Point(56, 9);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(95, 30);
            lblDatos.TabIndex = 1;
            lblDatos.Text = "Clientes";
            // 
            // dateTimeFechaNacimiento
            // 
            dateTimeFechaNacimiento.Font = new Font("Ebrima", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeFechaNacimiento.Format = DateTimePickerFormat.Short;
            dateTimeFechaNacimiento.Location = new Point(583, 103);
            dateTimeFechaNacimiento.Name = "dateTimeFechaNacimiento";
            dateTimeFechaNacimiento.Size = new Size(250, 26);
            dateTimeFechaNacimiento.TabIndex = 40;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.BackColor = Color.Transparent;
            lblFechaNacimiento.Font = new Font("Ebrima", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaNacimiento.ForeColor = Color.Black;
            lblFechaNacimiento.Location = new Point(444, 105);
            lblFechaNacimiento.Margin = new Padding(4, 0, 4, 0);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(128, 19);
            lblFechaNacimiento.TabIndex = 39;
            lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Ebrima", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(580, 64);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(253, 26);
            txtEmail.TabIndex = 38;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Ebrima", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(141, 233);
            txtTelefono.Margin = new Padding(4, 3, 4, 3);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(253, 26);
            txtTelefono.TabIndex = 37;
            txtTelefono.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Ebrima", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.Location = new Point(141, 187);
            txtDireccion.Margin = new Padding(4, 3, 4, 3);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(253, 26);
            txtDireccion.TabIndex = 36;
            txtDireccion.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDNI
            // 
            txtDNI.Font = new Font("Ebrima", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDNI.Location = new Point(141, 143);
            txtDNI.Margin = new Padding(4, 3, 4, 3);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(253, 26);
            txtDNI.TabIndex = 35;
            txtDNI.TextAlign = HorizontalAlignment.Center;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Ebrima", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(141, 103);
            txtApellido.Margin = new Padding(4, 3, 4, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(253, 26);
            txtApellido.TabIndex = 34;
            txtApellido.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Ebrima", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(141, 57);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(253, 26);
            txtNombre.TabIndex = 33;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.BackColor = Color.Transparent;
            lblDNI.Font = new Font("Ebrima", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblDNI.ForeColor = Color.Black;
            lblDNI.Location = new Point(57, 145);
            lblDNI.Margin = new Padding(4, 0, 4, 0);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(34, 19);
            lblDNI.TabIndex = 30;
            lblDNI.Text = "DNI";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Ebrima", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(444, 71);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(45, 19);
            lblEmail.TabIndex = 28;
            lblEmail.Text = "Email";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.Transparent;
            lblTelefono.Font = new Font("Ebrima", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefono.ForeColor = Color.Black;
            lblTelefono.Location = new Point(57, 235);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(68, 19);
            lblTelefono.TabIndex = 27;
            lblTelefono.Text = "Telefono";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.BackColor = Color.Transparent;
            lblDireccion.Font = new Font("Ebrima", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblDireccion.ForeColor = Color.Black;
            lblDireccion.Location = new Point(57, 189);
            lblDireccion.Margin = new Padding(4, 0, 4, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(72, 19);
            lblDireccion.TabIndex = 26;
            lblDireccion.Text = "Direccion";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Font = new Font("Ebrima", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.ForeColor = Color.Black;
            lblApellido.Location = new Point(57, 105);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 19);
            lblApellido.TabIndex = 25;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Ebrima", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(57, 64);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(65, 19);
            lblNombre.TabIndex = 24;
            lblNombre.Text = "Nombre";
            // 
            // btnVolverInicio
            // 
            btnVolverInicio.BackColor = SystemColors.Info;
            btnVolverInicio.Location = new Point(795, 12);
            btnVolverInicio.Name = "btnVolverInicio";
            btnVolverInicio.Size = new Size(179, 33);
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
            btnAltaCliente.Location = new Point(444, 209);
            btnAltaCliente.Margin = new Padding(4, 3, 4, 3);
            btnAltaCliente.Name = "btnAltaCliente";
            btnAltaCliente.Size = new Size(160, 50);
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
            btnEliminarCliente.Location = new Point(780, 209);
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
            btnModificarCliente.Location = new Point(612, 209);
            btnModificarCliente.Margin = new Padding(4, 3, 4, 3);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(160, 50);
            btnModificarCliente.TabIndex = 44;
            btnModificarCliente.Text = "MODIFICAR";
            btnModificarCliente.UseVisualStyleBackColor = false;
            btnModificarCliente.Click += btnModificarCliente_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.Highlight;
            btnLimpiar.Font = new Font("Ebrima", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(599, 145);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(179, 33);
            btnLimpiar.TabIndex = 45;
            btnLimpiar.Text = "Limpiar Campos";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(986, 525);
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
            Text = "Clientes";
            Load += FrmCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCliente).EndInit();
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
    }
}