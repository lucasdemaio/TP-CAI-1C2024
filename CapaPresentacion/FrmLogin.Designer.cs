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
            imgPerfil = new PictureBox();
            lblLoginIncorrecto = new Label();
            linklblCambioClave = new LinkLabel();
            btnLogin = new Button();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgPerfil).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Ebrima", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = SystemColors.GrayText;
            txtUsuario.Location = new Point(90, 79);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Escriba su usuario";
            txtUsuario.Size = new Size(208, 27);
            txtUsuario.TabIndex = 0;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Ebrima", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtClave.Location = new Point(90, 134);
            txtClave.Margin = new Padding(3, 2, 3, 2);
            txtClave.Name = "txtClave";
            txtClave.PlaceholderText = "Escriba su clave";
            txtClave.Size = new Size(208, 27);
            txtClave.TabIndex = 1;
            txtClave.TextAlign = HorizontalAlignment.Center;
            txtClave.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Ebrima", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(4, 76);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(63, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Usuario";
            // 
            // lblUserClave
            // 
            lblUserClave.AutoSize = true;
            lblUserClave.Font = new Font("Ebrima", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserClave.ForeColor = Color.White;
            lblUserClave.Location = new Point(13, 131);
            lblUserClave.Name = "lblUserClave";
            lblUserClave.Size = new Size(46, 20);
            lblUserClave.TabIndex = 3;
            lblUserClave.Text = "Clave";
            // 
            // panelLogin
            // 
            panelLogin.AutoSize = true;
            panelLogin.BackColor = Color.Transparent;
            panelLogin.Controls.Add(imgPerfil);
            panelLogin.Controls.Add(lblLoginIncorrecto);
            panelLogin.Controls.Add(linklblCambioClave);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(lblUserClave);
            panelLogin.Controls.Add(lblUsername);
            panelLogin.Controls.Add(txtClave);
            panelLogin.Controls.Add(txtUsuario);
            panelLogin.ForeColor = Color.Transparent;
            panelLogin.Location = new Point(106, 11);
            panelLogin.Margin = new Padding(3, 2, 3, 2);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(515, 389);
            panelLogin.TabIndex = 4;
            // 
            // imgPerfil
            // 
            imgPerfil.BackColor = Color.Transparent;
            imgPerfil.Image = (Image)resources.GetObject("imgPerfil.Image");
            imgPerfil.Location = new Point(373, 234);
            imgPerfil.Margin = new Padding(3, 2, 3, 2);
            imgPerfil.Name = "imgPerfil";
            imgPerfil.Size = new Size(139, 153);
            imgPerfil.SizeMode = PictureBoxSizeMode.AutoSize;
            imgPerfil.TabIndex = 5;
            imgPerfil.TabStop = false;
            // 
            // lblLoginIncorrecto
            // 
            lblLoginIncorrecto.Font = new Font("Ebrima", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoginIncorrecto.ForeColor = Color.Red;
            lblLoginIncorrecto.Location = new Point(30, 172);
            lblLoginIncorrecto.Name = "lblLoginIncorrecto";
            lblLoginIncorrecto.Size = new Size(325, 19);
            lblLoginIncorrecto.TabIndex = 6;
            lblLoginIncorrecto.Text = "lblLoginIncorrecto";
            lblLoginIncorrecto.Visible = false;
            // 
            // linklblCambioClave
            // 
            linklblCambioClave.Font = new Font("Ebrima", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            linklblCambioClave.LinkColor = Color.WhiteSmoke;
            linklblCambioClave.Location = new Point(13, 257);
            linklblCambioClave.Name = "linklblCambioClave";
            linklblCambioClave.Size = new Size(323, 41);
            linklblCambioClave.TabIndex = 5;
            linklblCambioClave.TabStop = true;
            linklblCambioClave.Text = "Ha olvidado su contraseña o desea cambiarla? Ingrese aqui";
            linklblCambioClave.TextAlign = ContentAlignment.MiddleCenter;
            linklblCambioClave.LinkClicked += linklblCambioClave_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 0, 192);
            btnLogin.Font = new Font("Ebrima", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(127, 213);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(126, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(597, 378);
            Controls.Add(panelLogin);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
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
        private LinkLabel linklblCambioClave;
        private Label lblLoginIncorrecto;
    }
}