namespace Presentacion
{
    partial class FrmAltaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaUsuario));
            lblNombre = new Label();
            lblApellido = new Label();
            lblDireccion = new Label();
            lblTelefono = new Label();
            lblEmail = new Label();
            lblUsuario = new Label();
            lblDNI = new Label();
            lblPerfil = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDireccion = new TextBox();
            txtDNI = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtUsuario = new TextBox();
            btnAltaUsuario = new Button();
            menuStrip1 = new MenuStrip();
            strpProductosMenu = new ToolStripMenuItem();
            strpVentasMenu = new ToolStripMenuItem();
            strpProveedoresMenu = new ToolStripMenuItem();
            strpReportesMenu = new ToolStripMenuItem();
            strpUsuariosMenu = new ToolStripMenuItem();
            strpAltaUsuariosMenu = new ToolStripMenuItem();
            strpBajaUsuariosMenu = new ToolStripMenuItem();
            btnVolverInicio = new Button();
            lblFechaNacimiento = new Label();
            dateTimeFechaNacimiento = new DateTimePicker();
            cbPerfiles = new ComboBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(60, 55);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(73, 21);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.ForeColor = Color.Black;
            lblApellido.Location = new Point(60, 107);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(75, 21);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.BackColor = Color.Transparent;
            lblDireccion.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDireccion.ForeColor = Color.Black;
            lblDireccion.Location = new Point(60, 218);
            lblDireccion.Margin = new Padding(4, 0, 4, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(83, 21);
            lblDireccion.TabIndex = 2;
            lblDireccion.Text = "Direccion";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.Transparent;
            lblTelefono.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefono.ForeColor = Color.Black;
            lblTelefono.Location = new Point(60, 269);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(78, 21);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Telefono";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(60, 323);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 21);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "eMail";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.Black;
            lblUsuario.Location = new Point(60, 443);
            lblUsuario.Margin = new Padding(4, 0, 4, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(69, 21);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Usuario";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.BackColor = Color.Transparent;
            lblDNI.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDNI.ForeColor = Color.Black;
            lblDNI.Location = new Point(60, 165);
            lblDNI.Margin = new Padding(4, 0, 4, 0);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(40, 21);
            lblDNI.TabIndex = 6;
            lblDNI.Text = "DNI";
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.BackColor = Color.Transparent;
            lblPerfil.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPerfil.ForeColor = Color.Black;
            lblPerfil.Location = new Point(60, 506);
            lblPerfil.Margin = new Padding(4, 0, 4, 0);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(51, 21);
            lblPerfil.TabIndex = 8;
            lblPerfil.Text = "Perfil";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(220, 55);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(253, 29);
            txtNombre.TabIndex = 10;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(220, 107);
            txtApellido.Margin = new Padding(4, 3, 4, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(253, 29);
            txtApellido.TabIndex = 11;
            txtApellido.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.Location = new Point(220, 217);
            txtDireccion.Margin = new Padding(4, 3, 4, 3);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(253, 29);
            txtDireccion.TabIndex = 13;
            txtDireccion.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDNI
            // 
            txtDNI.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDNI.Location = new Point(220, 165);
            txtDNI.Margin = new Padding(4, 3, 4, 3);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(253, 29);
            txtDNI.TabIndex = 12;
            txtDNI.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(220, 320);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(253, 29);
            txtEmail.TabIndex = 15;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(220, 269);
            txtTelefono.Margin = new Padding(4, 3, 4, 3);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(253, 29);
            txtTelefono.TabIndex = 14;
            txtTelefono.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(223, 441);
            txtUsuario.Margin = new Padding(4, 3, 4, 3);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(253, 29);
            txtUsuario.TabIndex = 16;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAltaUsuario
            // 
            btnAltaUsuario.BackColor = SystemColors.ActiveCaptionText;
            btnAltaUsuario.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAltaUsuario.ForeColor = Color.White;
            btnAltaUsuario.Location = new Point(627, 212);
            btnAltaUsuario.Margin = new Padding(4, 3, 4, 3);
            btnAltaUsuario.Name = "btnAltaUsuario";
            btnAltaUsuario.Size = new Size(319, 86);
            btnAltaUsuario.TabIndex = 18;
            btnAltaUsuario.Text = "DAR DE ALTA";
            btnAltaUsuario.UseVisualStyleBackColor = false;
            btnAltaUsuario.Click += btnAltaUsuario_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.BackgroundImage = (Image)resources.GetObject("menuStrip1.BackgroundImage");
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { strpProductosMenu, strpVentasMenu, strpProveedoresMenu, strpReportesMenu, strpUsuariosMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 2, 0, 2);
            menuStrip1.RightToLeft = RightToLeft.No;
            menuStrip1.Size = new Size(1540, 29);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // strpProductosMenu
            // 
            strpProductosMenu.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            strpProductosMenu.ForeColor = Color.White;
            strpProductosMenu.Name = "strpProductosMenu";
            strpProductosMenu.RightToLeft = RightToLeft.Yes;
            strpProductosMenu.Size = new Size(118, 25);
            strpProductosMenu.Text = "PRODUCTOS";
            // 
            // strpVentasMenu
            // 
            strpVentasMenu.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            strpVentasMenu.ForeColor = Color.White;
            strpVentasMenu.Name = "strpVentasMenu";
            strpVentasMenu.RightToLeft = RightToLeft.Yes;
            strpVentasMenu.Size = new Size(84, 25);
            strpVentasMenu.Text = "VENTAS";
            // 
            // strpProveedoresMenu
            // 
            strpProveedoresMenu.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            strpProveedoresMenu.ForeColor = Color.White;
            strpProveedoresMenu.Name = "strpProveedoresMenu";
            strpProveedoresMenu.RightToLeft = RightToLeft.Yes;
            strpProveedoresMenu.Size = new Size(135, 25);
            strpProveedoresMenu.Text = "PROVEEDORES";
            // 
            // strpReportesMenu
            // 
            strpReportesMenu.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            strpReportesMenu.ForeColor = Color.White;
            strpReportesMenu.Name = "strpReportesMenu";
            strpReportesMenu.RightToLeft = RightToLeft.Yes;
            strpReportesMenu.Size = new Size(100, 25);
            strpReportesMenu.Text = "REPORTES";
            // 
            // strpUsuariosMenu
            // 
            strpUsuariosMenu.BackColor = Color.Transparent;
            strpUsuariosMenu.DropDownItems.AddRange(new ToolStripItem[] { strpAltaUsuariosMenu, strpBajaUsuariosMenu });
            strpUsuariosMenu.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            strpUsuariosMenu.ForeColor = Color.White;
            strpUsuariosMenu.Name = "strpUsuariosMenu";
            strpUsuariosMenu.RightToLeft = RightToLeft.Yes;
            strpUsuariosMenu.Size = new Size(102, 25);
            strpUsuariosMenu.Text = "USUARIOS";
            // 
            // strpAltaUsuariosMenu
            // 
            strpAltaUsuariosMenu.Name = "strpAltaUsuariosMenu";
            strpAltaUsuariosMenu.Size = new Size(194, 26);
            strpAltaUsuariosMenu.Text = "ALTA USUARIO";
            strpAltaUsuariosMenu.Click += strpAltaUsuariosMenu_Click;
            // 
            // strpBajaUsuariosMenu
            // 
            strpBajaUsuariosMenu.Name = "strpBajaUsuariosMenu";
            strpBajaUsuariosMenu.Size = new Size(194, 26);
            strpBajaUsuariosMenu.Text = "BAJA USUARIO";
            strpBajaUsuariosMenu.Click += strpBajaUsuariosMenu_Click;
            // 
            // btnVolverInicio
            // 
            btnVolverInicio.BackColor = SystemColors.Info;
            btnVolverInicio.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverInicio.Location = new Point(667, 486);
            btnVolverInicio.Name = "btnVolverInicio";
            btnVolverInicio.Size = new Size(225, 51);
            btnVolverInicio.TabIndex = 20;
            btnVolverInicio.Text = "VOLVER MENU PRINCIPAL";
            btnVolverInicio.UseVisualStyleBackColor = false;
            btnVolverInicio.Click += btnVolverInicio_Click;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.BackColor = Color.Transparent;
            lblFechaNacimiento.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaNacimiento.ForeColor = Color.Black;
            lblFechaNacimiento.Location = new Point(60, 382);
            lblFechaNacimiento.Margin = new Padding(4, 0, 4, 0);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(148, 21);
            lblFechaNacimiento.TabIndex = 21;
            lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // dateTimeFechaNacimiento
            // 
            dateTimeFechaNacimiento.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeFechaNacimiento.Format = DateTimePickerFormat.Short;
            dateTimeFechaNacimiento.Location = new Point(223, 377);
            dateTimeFechaNacimiento.Name = "dateTimeFechaNacimiento";
            dateTimeFechaNacimiento.Size = new Size(250, 29);
            dateTimeFechaNacimiento.TabIndex = 23;
            // 
            // cbPerfiles
            // 
            cbPerfiles.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbPerfiles.FormattingEnabled = true;
            cbPerfiles.Location = new Point(220, 498);
            cbPerfiles.Name = "cbPerfiles";
            cbPerfiles.Size = new Size(256, 29);
            cbPerfiles.TabIndex = 24;
            // 
            // FrmAltaUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1540, 703);
            Controls.Add(cbPerfiles);
            Controls.Add(dateTimeFechaNacimiento);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(btnVolverInicio);
            Controls.Add(menuStrip1);
            Controls.Add(btnAltaUsuario);
            Controls.Add(txtUsuario);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtDNI);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblPerfil);
            Controls.Add(lblDNI);
            Controls.Add(lblUsuario);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefono);
            Controls.Add(lblDireccion);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Font = new Font("Ebrima", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmAltaUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Usuario";
            WindowState = FormWindowState.Maximized;
            Load += FrmAltaUsuario_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblDireccion;
        private Label lblTelefono;
        private Label lblEmail;
        private Label lblUsuario;
        private Label lblDNI;
        private Label lblPerfil;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDireccion;
        private TextBox txtDNI;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtUsuario;
        private Button btnAltaUsuario;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem strpProductosMenu;
        private ToolStripMenuItem strpVentasMenu;
        private ToolStripMenuItem strpProveedoresMenu;
        private ToolStripMenuItem strpReportesMenu;
        private ToolStripMenuItem strpUsuariosMenu;
        private ToolStripMenuItem strpAltaUsuariosMenu;
        private ToolStripMenuItem strpBajaUsuariosMenu;
        private Button btnVolverInicio;
        private Label lblFechaNacimiento;
        private DateTimePicker dateTimeFechaNacimiento;
        private ComboBox cbPerfiles;
    }
}