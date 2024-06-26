﻿namespace Presentacion
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
            strpVentasMenu = new ToolStripMenuItem();
            strpNuevaVenta = new ToolStripMenuItem();
            strpDevolucionVenta = new ToolStripMenuItem();
            strpClientesMenu = new ToolStripMenuItem();
            strpProductosMenu = new ToolStripMenuItem();
            strpProveedoresMenu = new ToolStripMenuItem();
            strpReportesMenu = new ToolStripMenuItem();
            strpUsuariosMenu = new ToolStripMenuItem();
            strpAltaUsuariosMenu = new ToolStripMenuItem();
            strpBajaUsuariosMenu = new ToolStripMenuItem();
            btnLogOut = new Button();
            lblBienvenido = new Label();
            lblStockCritico = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.BackgroundImage = (Image)resources.GetObject("menuStrip1.BackgroundImage");
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { strpVentasMenu, strpClientesMenu, strpProductosMenu, strpProveedoresMenu, strpReportesMenu, strpUsuariosMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 2, 0, 2);
            menuStrip1.RightToLeft = RightToLeft.No;
            menuStrip1.Size = new Size(1540, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // strpVentasMenu
            // 
            strpVentasMenu.DropDownItems.AddRange(new ToolStripItem[] { strpNuevaVenta, strpDevolucionVenta });
            strpVentasMenu.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            strpVentasMenu.ForeColor = Color.White;
            strpVentasMenu.Name = "strpVentasMenu";
            strpVentasMenu.RightToLeft = RightToLeft.Yes;
            strpVentasMenu.Size = new Size(84, 25);
            strpVentasMenu.Text = "VENTAS";
            // 
            // strpNuevaVenta
            // 
            strpNuevaVenta.Name = "strpNuevaVenta";
            strpNuevaVenta.Size = new Size(193, 26);
            strpNuevaVenta.Text = "NUEVA VENTA";
            strpNuevaVenta.Click += strpNuevaVenta_Click;
            // 
            // strpDevolucionVenta
            // 
            strpDevolucionVenta.Name = "strpDevolucionVenta";
            strpDevolucionVenta.Size = new Size(193, 26);
            strpDevolucionVenta.Text = "DEVOLUCION";
            strpDevolucionVenta.Click += strpDevolucionVenta_Click;
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
            strpAltaUsuariosMenu.Size = new Size(211, 26);
            strpAltaUsuariosMenu.Text = "ALTA";
            strpAltaUsuariosMenu.Click += strpAltaUsuariosMenu_Click;
            // 
            // strpBajaUsuariosMenu
            // 
            strpBajaUsuariosMenu.Name = "strpBajaUsuariosMenu";
            strpBajaUsuariosMenu.Size = new Size(211, 26);
            strpBajaUsuariosMenu.Text = "BAJA-REACTIVAR";
            strpBajaUsuariosMenu.Click += strpBajaUsuariosMenu_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(1453, 32);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(75, 30);
            btnLogOut.TabIndex = 1;
            btnLogOut.Text = "Logout";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.BackColor = Color.Transparent;
            lblBienvenido.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblBienvenido.ForeColor = Color.MidnightBlue;
            lblBienvenido.Location = new Point(403, 259);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(876, 65);
            lblBienvenido.TabIndex = 2;
            lblBienvenido.Text = "Bienvenido al Sistema de ElectroHogar";
            lblBienvenido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStockCritico
            // 
            lblStockCritico.AutoSize = true;
            lblStockCritico.BackColor = Color.Transparent;
            lblStockCritico.Font = new Font("Ebrima", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblStockCritico.ForeColor = Color.Red;
            lblStockCritico.Location = new Point(672, 447);
            lblStockCritico.Name = "lblStockCritico";
            lblStockCritico.Size = new Size(76, 30);
            lblStockCritico.TabIndex = 3;
            lblStockCritico.Text = "label1";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1540, 845);
            Controls.Add(lblStockCritico);
            Controls.Add(lblBienvenido);
            Controls.Add(btnLogOut);
            Controls.Add(menuStrip1);
            Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(192, 0, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            WindowState = FormWindowState.Maximized;
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
        private Label lblBienvenido;
        private ToolStripMenuItem strpNuevaVenta;
        private ToolStripMenuItem strpDevolucionVenta;
        private Label lblStockCritico;
    }
}
