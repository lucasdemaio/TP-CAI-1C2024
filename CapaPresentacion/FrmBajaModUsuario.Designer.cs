namespace Presentacion
{
    partial class FrmBajaModUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBajaModUsuario));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnBajaUsuario = new Button();
            menuStrip1 = new MenuStrip();
            strpProductosMenu = new ToolStripMenuItem();
            strpVentasMenu = new ToolStripMenuItem();
            strpProveedoresMenu = new ToolStripMenuItem();
            strpReportesMenu = new ToolStripMenuItem();
            strpUsuariosMenu = new ToolStripMenuItem();
            strpAltaUsuariosMenu = new ToolStripMenuItem();
            strpBajaUsuariosMenu = new ToolStripMenuItem();
            btnVolverInicio = new Button();
            dataGridViewUsuario = new DataGridView();
            lblDNI = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            txtApellido = new TextBox();
            btnModificarCliente = new Button();
            lblusuario = new Label();
            txtUsername = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuario).BeginInit();
            SuspendLayout();
            // 
            // btnBajaUsuario
            // 
            btnBajaUsuario.BackColor = Color.Red;
            btnBajaUsuario.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBajaUsuario.ForeColor = Color.White;
            btnBajaUsuario.Location = new Point(563, 362);
            btnBajaUsuario.Margin = new Padding(4, 2, 4, 2);
            btnBajaUsuario.Name = "btnBajaUsuario";
            btnBajaUsuario.Size = new Size(176, 40);
            btnBajaUsuario.TabIndex = 21;
            btnBajaUsuario.Text = "ELIMINAR";
            btnBajaUsuario.UseVisualStyleBackColor = false;
            btnBajaUsuario.Click += btnBajaUsuario_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.BackgroundImage = (Image)resources.GetObject("menuStrip1.BackgroundImage");
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { strpProductosMenu, strpVentasMenu, strpProveedoresMenu, strpReportesMenu, strpUsuariosMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 2, 0, 2);
            menuStrip1.RightToLeft = RightToLeft.No;
            menuStrip1.Size = new Size(955, 29);
            menuStrip1.TabIndex = 23;
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
            btnVolverInicio.Location = new Point(786, 365);
            btnVolverInicio.Margin = new Padding(3, 2, 3, 2);
            btnVolverInicio.Name = "btnVolverInicio";
            btnVolverInicio.Size = new Size(157, 38);
            btnVolverInicio.TabIndex = 24;
            btnVolverInicio.Text = "VOLVER MENU PRINCIPAL";
            btnVolverInicio.UseVisualStyleBackColor = false;
            btnVolverInicio.Click += btnVolverInicio_Click;
            // 
            // dataGridViewUsuario
            // 
            dataGridViewUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsuario.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewUsuario.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewUsuario.Location = new Point(350, 62);
            dataGridViewUsuario.MultiSelect = false;
            dataGridViewUsuario.Name = "dataGridViewUsuario";
            dataGridViewUsuario.ReadOnly = true;
            dataGridViewUsuario.RowTemplate.Height = 25;
            dataGridViewUsuario.Size = new Size(593, 295);
            dataGridViewUsuario.TabIndex = 25;
            dataGridViewUsuario.CellContentClick += dataGridViewUsuario_CellContentClick;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.BackColor = Color.Transparent;
            lblDNI.Font = new Font("Ebrima", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblDNI.ForeColor = Color.Black;
            lblDNI.Location = new Point(13, 143);
            lblDNI.Margin = new Padding(4, 0, 4, 0);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(34, 19);
            lblDNI.TabIndex = 28;
            lblDNI.Text = "DNI";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Font = new Font("Ebrima", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.ForeColor = Color.Black;
            lblApellido.Location = new Point(13, 103);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 19);
            lblApellido.TabIndex = 27;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Ebrima", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(13, 62);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(65, 19);
            lblNombre.TabIndex = 26;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(102, 62);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(208, 23);
            txtNombre.TabIndex = 30;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(102, 143);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(208, 23);
            txtDNI.TabIndex = 31;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(102, 103);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(208, 23);
            txtApellido.TabIndex = 31;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.BackColor = SystemColors.ActiveCaptionText;
            btnModificarCliente.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificarCliente.ForeColor = Color.White;
            btnModificarCliente.Location = new Point(75, 290);
            btnModificarCliente.Margin = new Padding(4, 3, 4, 3);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(160, 50);
            btnModificarCliente.TabIndex = 45;
            btnModificarCliente.Text = "MODIFICAR";
            btnModificarCliente.UseVisualStyleBackColor = false;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.BackColor = Color.Transparent;
            lblusuario.Font = new Font("Ebrima", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblusuario.ForeColor = Color.Black;
            lblusuario.Location = new Point(13, 190);
            lblusuario.Margin = new Padding(4, 0, 4, 0);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(76, 19);
            lblusuario.TabIndex = 46;
            lblusuario.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(102, 190);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(208, 23);
            txtUsername.TabIndex = 47;
            // 
            // FrmBajaModUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(955, 411);
            Controls.Add(txtUsername);
            Controls.Add(lblusuario);
            Controls.Add(btnModificarCliente);
            Controls.Add(txtApellido);
            Controls.Add(txtDNI);
            Controls.Add(txtNombre);
            Controls.Add(lblDNI);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(dataGridViewUsuario);
            Controls.Add(btnVolverInicio);
            Controls.Add(menuStrip1);
            Controls.Add(btnBajaUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmBajaModUsuario";
            Text = "Baja-Modificacion Usuario";
            Load += FrmBajaModUsuario_Load_1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBajaUsuario;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem strpProductosMenu;
        private ToolStripMenuItem strpVentasMenu;
        private ToolStripMenuItem strpProveedoresMenu;
        private ToolStripMenuItem strpReportesMenu;
        private ToolStripMenuItem strpUsuariosMenu;
        private ToolStripMenuItem strpAltaUsuariosMenu;
        private ToolStripMenuItem strpBajaUsuariosMenu;
        private Button btnVolverInicio;
        private DataGridView dataGridViewUsuario;
        private Label lblDNI;
        private Label lblApellido;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private TextBox txtApellido;
        private Button btnModificarCliente;
        private Label lblusuario;
        private TextBox txtUsername;
    }
}