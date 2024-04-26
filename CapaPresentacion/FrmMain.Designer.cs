namespace Presentacion
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            menuStrip1 = new MenuStrip();
            strpProductosMenu = new ToolStripMenuItem();
            strpVentasMenu = new ToolStripMenuItem();
            vENTASToolStripMenuItem = new ToolStripMenuItem();
            strpProveedoresMenu = new ToolStripMenuItem();
            strpReportesMenu = new ToolStripMenuItem();
            strpClientesMenu = new ToolStripMenuItem();
            strpUsuariosMenu = new ToolStripMenuItem();
            strpAltaUsuariosMenu = new ToolStripMenuItem();
            strpBajaUsuariosMenu = new ToolStripMenuItem();
            btnLogOut = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.BackgroundImage = (Image)resources.GetObject("menuStrip1.BackgroundImage");
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { strpProductosMenu, strpVentasMenu, strpProveedoresMenu, strpReportesMenu, strpClientesMenu, strpUsuariosMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 2, 0, 2);
            menuStrip1.RightToLeft = RightToLeft.No;
            menuStrip1.Size = new Size(1194, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // strpProductosMenu
            // 
            strpProductosMenu.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            strpProductosMenu.ForeColor = Color.White;
            strpProductosMenu.Name = "strpProductosMenu";
            strpProductosMenu.RightToLeft = RightToLeft.Yes;
            strpProductosMenu.Size = new Size(118, 25);
            strpProductosMenu.Text = "PRODUCTOS";
            strpProductosMenu.Click += strpProductosMenu_Click;
            // 
            // strpVentasMenu
            // 
            strpVentasMenu.DropDownItems.AddRange(new ToolStripItem[] { vENTASToolStripMenuItem });
            strpVentasMenu.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            strpVentasMenu.ForeColor = Color.White;
            strpVentasMenu.Name = "strpVentasMenu";
            strpVentasMenu.RightToLeft = RightToLeft.Yes;
            strpVentasMenu.Size = new Size(84, 25);
            strpVentasMenu.Text = "VENTAS";
            strpVentasMenu.Click += strpVentasMenu_Click;
            // 
            // vENTASToolStripMenuItem
            // 
            vENTASToolStripMenuItem.Name = "vENTASToolStripMenuItem";
            vENTASToolStripMenuItem.Size = new Size(142, 26);
            vENTASToolStripMenuItem.Text = "VENTAS";
            // 
            // strpProveedoresMenu
            // 
            strpProveedoresMenu.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            strpProveedoresMenu.ForeColor = Color.White;
            strpProveedoresMenu.Name = "strpProveedoresMenu";
            strpProveedoresMenu.RightToLeft = RightToLeft.Yes;
            strpProveedoresMenu.Size = new Size(135, 25);
            strpProveedoresMenu.Text = "PROVEEDORES";
            strpProveedoresMenu.Click += strpProveedoresMenu_Click;
            // 
            // strpReportesMenu
            // 
            strpReportesMenu.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            strpReportesMenu.ForeColor = Color.White;
            strpReportesMenu.Name = "strpReportesMenu";
            strpReportesMenu.RightToLeft = RightToLeft.Yes;
            strpReportesMenu.Size = new Size(100, 25);
            strpReportesMenu.Text = "REPORTES";
            strpReportesMenu.Click += strpReportesMenu_Click;
            // 
            // strpClientesMenu
            // 
            strpClientesMenu.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            strpClientesMenu.ForeColor = Color.White;
            strpClientesMenu.Name = "strpClientesMenu";
            strpClientesMenu.Size = new Size(94, 25);
            strpClientesMenu.Text = "CLIENTES";
            strpClientesMenu.Click += strpClientesMenu_Click;
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
            // btnLogOut
            // 
            btnLogOut.Location = new Point(1107, 32);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(75, 30);
            btnLogOut.TabIndex = 1;
            btnLogOut.Text = "Logout";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.MenuBar;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1194, 595);
            Controls.Add(btnLogOut);
            Controls.Add(menuStrip1);
            Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(192, 0, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "FrmMain";
            Text = "Inicio";
            Load += FrmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem strpUsuariosMenu;
        private ToolStripMenuItem strpProductosMenu;
        private ToolStripMenuItem strpVentasMenu;
        private ToolStripMenuItem strpProveedoresMenu;
        private ToolStripMenuItem strpReportesMenu;
        private ToolStripMenuItem strpAltaUsuariosMenu;
        private ToolStripMenuItem strpBajaUsuariosMenu;
        private ToolStripMenuItem vENTASToolStripMenuItem;
        private ToolStripMenuItem strpClientesMenu;
        private Button btnLogOut;
    }
}
