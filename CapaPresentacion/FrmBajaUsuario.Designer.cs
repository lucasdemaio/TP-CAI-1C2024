namespace PresentacionLayer
{
    partial class FrmBajaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBajaUsuario));
            textBox1 = new TextBox();
            txtDNI = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblDNI = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnBajaUsuario = new Button();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            strpProductosMenu = new ToolStripMenuItem();
            strpVentasMenu = new ToolStripMenuItem();
            strpProveedoresMenu = new ToolStripMenuItem();
            strpReportesMenu = new ToolStripMenuItem();
            strpUsuariosMenu = new ToolStripMenuItem();
            strpAltaUsuariosMenu = new ToolStripMenuItem();
            strpBajaUsuariosMenu = new ToolStripMenuItem();
            btnVolverInicio = new Button();
            lstBoxUsuarios = new ListBox();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(231, 56);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ingrese ID del usuario";
            textBox1.Size = new Size(207, 27);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDNI
            // 
            txtDNI.Font = new Font("Ebrima", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDNI.Location = new Point(197, 164);
            txtDNI.Margin = new Padding(4, 3, 4, 3);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(253, 30);
            txtDNI.TabIndex = 18;
            txtDNI.TextAlign = HorizontalAlignment.Center;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Ebrima", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(197, 106);
            txtApellido.Margin = new Padding(4, 3, 4, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(253, 30);
            txtApellido.TabIndex = 17;
            txtApellido.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Ebrima", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(197, 54);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(253, 30);
            txtNombre.TabIndex = 16;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.BackColor = Color.Transparent;
            lblDNI.Font = new Font("Ebrima", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDNI.ForeColor = Color.Black;
            lblDNI.Location = new Point(83, 167);
            lblDNI.Margin = new Padding(4, 0, 4, 0);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(40, 23);
            lblDNI.TabIndex = 15;
            lblDNI.Text = "DNI";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Font = new Font("Ebrima", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.ForeColor = Color.Black;
            lblApellido.Location = new Point(83, 109);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(72, 23);
            lblApellido.TabIndex = 14;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Ebrima", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(83, 57);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(73, 23);
            lblNombre.TabIndex = 13;
            lblNombre.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Ebrima", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(128, 56);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 23);
            label2.TabIndex = 19;
            label2.Text = "Buscar";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDNI);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(lblDNI);
            groupBox1.Controls.Add(lblApellido);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Location = new Point(34, 129);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(534, 218);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resultado Busqueda";
            // 
            // btnBajaUsuario
            // 
            btnBajaUsuario.BackColor = Color.Red;
            btnBajaUsuario.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBajaUsuario.ForeColor = Color.White;
            btnBajaUsuario.Location = new Point(219, 372);
            btnBajaUsuario.Margin = new Padding(4, 3, 4, 3);
            btnBajaUsuario.Name = "btnBajaUsuario";
            btnBajaUsuario.Size = new Size(201, 53);
            btnBajaUsuario.TabIndex = 21;
            btnBajaUsuario.Text = "ELIMINAR";
            btnBajaUsuario.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(10, 372);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(201, 53);
            button1.TabIndex = 22;
            button1.Text = "NUEVA BUSQUEDA";
            button1.UseVisualStyleBackColor = false;
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
            menuStrip1.Size = new Size(1091, 36);
            menuStrip1.TabIndex = 23;
            menuStrip1.Text = "menuStrip1";
            // 
            // strpProductosMenu
            // 
            strpProductosMenu.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            strpProductosMenu.ForeColor = Color.White;
            strpProductosMenu.Name = "strpProductosMenu";
            strpProductosMenu.RightToLeft = RightToLeft.Yes;
            strpProductosMenu.Size = new Size(145, 32);
            strpProductosMenu.Text = "PRODUCTOS";
            // 
            // strpVentasMenu
            // 
            strpVentasMenu.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            strpVentasMenu.ForeColor = Color.White;
            strpVentasMenu.Name = "strpVentasMenu";
            strpVentasMenu.RightToLeft = RightToLeft.Yes;
            strpVentasMenu.Size = new Size(103, 32);
            strpVentasMenu.Text = "VENTAS";
            // 
            // strpProveedoresMenu
            // 
            strpProveedoresMenu.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            strpProveedoresMenu.ForeColor = Color.White;
            strpProveedoresMenu.Name = "strpProveedoresMenu";
            strpProveedoresMenu.RightToLeft = RightToLeft.Yes;
            strpProveedoresMenu.Size = new Size(166, 32);
            strpProveedoresMenu.Text = "PROVEEDORES";
            // 
            // strpReportesMenu
            // 
            strpReportesMenu.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            strpReportesMenu.ForeColor = Color.White;
            strpReportesMenu.Name = "strpReportesMenu";
            strpReportesMenu.RightToLeft = RightToLeft.Yes;
            strpReportesMenu.Size = new Size(124, 32);
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
            strpUsuariosMenu.Size = new Size(124, 32);
            strpUsuariosMenu.Text = "USUARIOS";
            // 
            // strpAltaUsuariosMenu
            // 
            strpAltaUsuariosMenu.Name = "strpAltaUsuariosMenu";
            strpAltaUsuariosMenu.Size = new Size(241, 32);
            strpAltaUsuariosMenu.Text = "ALTA USUARIO";
            strpAltaUsuariosMenu.Click += strpAltaUsuariosMenu_Click;
            // 
            // strpBajaUsuariosMenu
            // 
            strpBajaUsuariosMenu.Name = "strpBajaUsuariosMenu";
            strpBajaUsuariosMenu.Size = new Size(241, 32);
            strpBajaUsuariosMenu.Text = "BAJA USUARIO";
            strpBajaUsuariosMenu.Click += strpBajaUsuariosMenu_Click;
            // 
            // btnVolverInicio
            // 
            btnVolverInicio.BackColor = SystemColors.Info;
            btnVolverInicio.Location = new Point(427, 372);
            btnVolverInicio.Name = "btnVolverInicio";
            btnVolverInicio.Size = new Size(179, 51);
            btnVolverInicio.TabIndex = 24;
            btnVolverInicio.Text = "REGRESAR";
            btnVolverInicio.UseVisualStyleBackColor = false;
            btnVolverInicio.Click += btnVolverInicio_Click;
            // 
            // lstBoxUsuarios
            // 
            lstBoxUsuarios.FormattingEnabled = true;
            lstBoxUsuarios.ItemHeight = 20;
            lstBoxUsuarios.Location = new Point(633, 72);
            lstBoxUsuarios.Name = "lstBoxUsuarios";
            lstBoxUsuarios.ScrollAlwaysVisible = true;
            lstBoxUsuarios.Size = new Size(360, 384);
            lstBoxUsuarios.TabIndex = 25;
            // 
            // FrmBajaUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1091, 494);
            Controls.Add(lstBoxUsuarios);
            Controls.Add(btnVolverInicio);
            Controls.Add(menuStrip1);
            Controls.Add(button1);
            Controls.Add(btnBajaUsuario);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmBajaUsuario";
            Text = "Baja Usuario";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox txtDNI;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblDNI;
        private Label lblApellido;
        private Label lblNombre;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnBajaUsuario;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem strpProductosMenu;
        private ToolStripMenuItem strpVentasMenu;
        private ToolStripMenuItem strpProveedoresMenu;
        private ToolStripMenuItem strpReportesMenu;
        private ToolStripMenuItem strpUsuariosMenu;
        private ToolStripMenuItem strpAltaUsuariosMenu;
        private ToolStripMenuItem strpBajaUsuariosMenu;
        private Button btnVolverInicio;
        private ListBox lstBoxUsuarios;
    }
}