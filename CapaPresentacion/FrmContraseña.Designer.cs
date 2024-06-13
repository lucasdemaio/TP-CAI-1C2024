namespace Presentacion
{
    partial class FrmContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContraseña));
            lblRestablecerContraseña = new Label();
            txtUsername = new TextBox();
            txtContraseñaActual = new TextBox();
            txtContraseñaNueva = new TextBox();
            lblUsername = new Label();
            lblClaveAnterior = new Label();
            lblClaveNueva = new Label();
            btnCambioContraseña = new Button();
            lblConfirmacionContraseña = new Label();
            txtConfirmacionContraseña = new TextBox();
            lblContraseñaError = new Label();
            lblContraseñaCambiada = new Label();
            btnVolverInicio = new Button();
            SuspendLayout();
            // 
            // lblRestablecerContraseña
            // 
            lblRestablecerContraseña.AutoSize = true;
            lblRestablecerContraseña.BackColor = Color.Transparent;
            lblRestablecerContraseña.Font = new Font("Ebrima", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblRestablecerContraseña.ForeColor = Color.White;
            lblRestablecerContraseña.Location = new Point(31, 9);
            lblRestablecerContraseña.Name = "lblRestablecerContraseña";
            lblRestablecerContraseña.Size = new Size(257, 30);
            lblRestablecerContraseña.TabIndex = 0;
            lblRestablecerContraseña.Text = "Restablecer Contraseña";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(31, 82);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 23);
            txtUsername.TabIndex = 1;
            // 
            // txtContraseñaActual
            // 
            txtContraseñaActual.Location = new Point(31, 144);
            txtContraseñaActual.Name = "txtContraseñaActual";
            txtContraseñaActual.Size = new Size(216, 23);
            txtContraseñaActual.TabIndex = 2;
            txtContraseñaActual.UseSystemPasswordChar = true;
            // 
            // txtContraseñaNueva
            // 
            txtContraseñaNueva.Location = new Point(31, 208);
            txtContraseñaNueva.Name = "txtContraseñaNueva";
            txtContraseñaNueva.Size = new Size(216, 23);
            txtContraseñaNueva.TabIndex = 3;
            txtContraseñaNueva.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Ebrima", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(31, 58);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username";
            // 
            // lblClaveAnterior
            // 
            lblClaveAnterior.AutoSize = true;
            lblClaveAnterior.BackColor = Color.Transparent;
            lblClaveAnterior.Font = new Font("Ebrima", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblClaveAnterior.ForeColor = Color.White;
            lblClaveAnterior.Location = new Point(31, 119);
            lblClaveAnterior.Name = "lblClaveAnterior";
            lblClaveAnterior.Size = new Size(127, 20);
            lblClaveAnterior.TabIndex = 5;
            lblClaveAnterior.Text = "Contraseña actual";
            // 
            // lblClaveNueva
            // 
            lblClaveNueva.AutoSize = true;
            lblClaveNueva.BackColor = Color.Transparent;
            lblClaveNueva.Font = new Font("Ebrima", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblClaveNueva.ForeColor = Color.White;
            lblClaveNueva.Location = new Point(31, 181);
            lblClaveNueva.Name = "lblClaveNueva";
            lblClaveNueva.Size = new Size(129, 20);
            lblClaveNueva.TabIndex = 6;
            lblClaveNueva.Text = "Nueva Contraseña";
            // 
            // btnCambioContraseña
            // 
            btnCambioContraseña.BackColor = Color.ForestGreen;
            btnCambioContraseña.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCambioContraseña.ForeColor = Color.White;
            btnCambioContraseña.Location = new Point(198, 358);
            btnCambioContraseña.Margin = new Padding(4, 3, 4, 3);
            btnCambioContraseña.Name = "btnCambioContraseña";
            btnCambioContraseña.Size = new Size(213, 38);
            btnCambioContraseña.TabIndex = 19;
            btnCambioContraseña.Text = "CAMBIAR CONTRASEÑA";
            btnCambioContraseña.UseVisualStyleBackColor = false;
            btnCambioContraseña.Click += btnCambioContraseña_Click_1;
            // 
            // lblConfirmacionContraseña
            // 
            lblConfirmacionContraseña.AutoSize = true;
            lblConfirmacionContraseña.BackColor = Color.Transparent;
            lblConfirmacionContraseña.Font = new Font("Ebrima", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblConfirmacionContraseña.ForeColor = Color.White;
            lblConfirmacionContraseña.Location = new Point(31, 245);
            lblConfirmacionContraseña.Name = "lblConfirmacionContraseña";
            lblConfirmacionContraseña.Size = new Size(191, 20);
            lblConfirmacionContraseña.TabIndex = 20;
            lblConfirmacionContraseña.Text = "Confirme nueva Contraseña";
            // 
            // txtConfirmacionContraseña
            // 
            txtConfirmacionContraseña.Location = new Point(31, 268);
            txtConfirmacionContraseña.Name = "txtConfirmacionContraseña";
            txtConfirmacionContraseña.Size = new Size(216, 23);
            txtConfirmacionContraseña.TabIndex = 21;
            txtConfirmacionContraseña.UseSystemPasswordChar = true;
            // 
            // lblContraseñaError
            // 
            lblContraseñaError.AutoSize = true;
            lblContraseñaError.BackColor = Color.Transparent;
            lblContraseñaError.Font = new Font("Ebrima", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblContraseñaError.ForeColor = Color.Red;
            lblContraseñaError.Location = new Point(31, 294);
            lblContraseñaError.Name = "lblContraseñaError";
            lblContraseñaError.Size = new Size(69, 20);
            lblContraseñaError.TabIndex = 22;
            lblContraseñaError.Text = "msjerror";
            lblContraseñaError.Visible = false;
            // 
            // lblContraseñaCambiada
            // 
            lblContraseñaCambiada.AutoSize = true;
            lblContraseñaCambiada.BackColor = Color.Transparent;
            lblContraseñaCambiada.Font = new Font("Ebrima", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblContraseñaCambiada.ForeColor = Color.White;
            lblContraseñaCambiada.Location = new Point(274, 268);
            lblContraseñaCambiada.Name = "lblContraseñaCambiada";
            lblContraseñaCambiada.Size = new Size(83, 20);
            lblContraseñaCambiada.TabIndex = 23;
            lblContraseñaCambiada.Text = "CambioOK";
            lblContraseñaCambiada.Visible = false;
            lblContraseñaCambiada.Click += lblContraseñaCambiada_Click;
            // 
            // btnVolverInicio
            // 
            btnVolverInicio.BackColor = SystemColors.Info;
            btnVolverInicio.Location = new Point(395, 12);
            btnVolverInicio.Name = "btnVolverInicio";
            btnVolverInicio.Size = new Size(179, 33);
            btnVolverInicio.TabIndex = 42;
            btnVolverInicio.Text = "VOLVER MENU LOGIN";
            btnVolverInicio.UseVisualStyleBackColor = false;
            btnVolverInicio.Click += btnVolverInicio_Click;
            // 
            // FrmContraseña
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(586, 403);
            Controls.Add(btnVolverInicio);
            Controls.Add(lblContraseñaCambiada);
            Controls.Add(lblContraseñaError);
            Controls.Add(txtConfirmacionContraseña);
            Controls.Add(lblConfirmacionContraseña);
            Controls.Add(btnCambioContraseña);
            Controls.Add(lblClaveNueva);
            Controls.Add(lblClaveAnterior);
            Controls.Add(lblUsername);
            Controls.Add(txtContraseñaNueva);
            Controls.Add(txtContraseñaActual);
            Controls.Add(txtUsername);
            Controls.Add(lblRestablecerContraseña);
            MaximizeBox = false;
            Name = "FrmContraseña";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Cambio de Contraseña";
            Load += FrmContraseña_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRestablecerContraseña;
        private TextBox txtUsername;
        private TextBox txtContraseñaActual;
        private TextBox txtContraseñaNueva;
        private Label lblUsername;
        private Label lblClaveAnterior;
        private Label lblClaveNueva;
        private Button btnCambioContraseña;
        private Label lblConfirmacionContraseña;
        private TextBox txtConfirmacionContraseña;
        private Label lblContraseñaError;
        private Label lblContraseñaCambiada;
        private Button btnVolverInicio;
    }
}