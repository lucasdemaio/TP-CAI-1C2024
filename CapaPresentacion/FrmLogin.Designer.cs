namespace PresentacionLayer
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            lblUsername = new Label();
            lblUserClave = new Label();
            panelLogin = new Panel();
            btnLogin = new Button();
            imgPerfil = new PictureBox();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgPerfil).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Ebrima", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = SystemColors.GrayText;
            txtUsuario.Location = new Point(103, 105);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Escriba su usuario";
            txtUsuario.Size = new Size(237, 32);
            txtUsuario.TabIndex = 0;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Ebrima", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtClave.Location = new Point(103, 179);
            txtClave.Name = "txtClave";
            txtClave.PlaceholderText = "Escriba su clave";
            txtClave.Size = new Size(237, 32);
            txtClave.TabIndex = 1;
            txtClave.TextAlign = HorizontalAlignment.Center;
            txtClave.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Ebrima", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(4, 101);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(81, 25);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Usuario";
            // 
            // lblUserClave
            // 
            lblUserClave.AutoSize = true;
            lblUserClave.Font = new Font("Ebrima", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserClave.ForeColor = Color.White;
            lblUserClave.Location = new Point(15, 175);
            lblUserClave.Name = "lblUserClave";
            lblUserClave.Size = new Size(59, 25);
            lblUserClave.TabIndex = 3;
            lblUserClave.Text = "Clave";
            // 
            // panelLogin
            // 
            panelLogin.AutoSize = true;
            panelLogin.BackColor = Color.Transparent;
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(lblUserClave);
            panelLogin.Controls.Add(lblUsername);
            panelLogin.Controls.Add(txtClave);
            panelLogin.Controls.Add(txtUsuario);
            panelLogin.ForeColor = Color.Transparent;
            panelLogin.Location = new Point(155, 12);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(418, 442);
            panelLogin.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 0, 192);
            btnLogin.Font = new Font("Ebrima", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(15, 246);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(144, 39);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // imgPerfil
            // 
            imgPerfil.BackColor = Color.Transparent;
            imgPerfil.Image = (Image)resources.GetObject("imgPerfil.Image");
            imgPerfil.Location = new Point(537, 329);
            imgPerfil.Name = "imgPerfil";
            imgPerfil.Size = new Size(147, 125);
            imgPerfil.TabIndex = 5;
            imgPerfil.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Navy;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(682, 453);
            Controls.Add(imgPerfil);
            Controls.Add(panelLogin);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmLogin";
            Text = "ElectroHogar SA - Login";
            Load += FrmLogin_Load;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgPerfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtClave;
        private Label lblUsername;
        private Label lblUserClave;
        private Panel panelLogin;
        private Button btnLogin;
        private PictureBox imgPerfil;
    }
}