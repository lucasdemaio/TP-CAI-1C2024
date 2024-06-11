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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBajaModUsuario));
            btnBajaUsuario = new Button();
            btnVolverInicio = new Button();
            dataGridViewUsuario = new DataGridView();
            lblDNI = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            txtApellido = new TextBox();
            lblusuario = new Label();
            txtUsername = new TextBox();
            lblBAJA = new Label();
            label2 = new Label();
            dataGridViewReactivar = new DataGridView();
            btnReactivar = new Button();
            lblAlertaUsuarios = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReactivar).BeginInit();
            SuspendLayout();
            // 
            // btnBajaUsuario
            // 
            btnBajaUsuario.BackColor = Color.Red;
            btnBajaUsuario.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBajaUsuario.ForeColor = Color.White;
            btnBajaUsuario.Location = new Point(127, 353);
            btnBajaUsuario.Margin = new Padding(4, 2, 4, 2);
            btnBajaUsuario.Name = "btnBajaUsuario";
            btnBajaUsuario.Size = new Size(140, 40);
            btnBajaUsuario.TabIndex = 21;
            btnBajaUsuario.Text = "DAR DE BAJA";
            btnBajaUsuario.UseVisualStyleBackColor = false;
            btnBajaUsuario.Click += btnBajaUsuario_Click;
            // 
            // btnVolverInicio
            // 
            btnVolverInicio.BackColor = SystemColors.Info;
            btnVolverInicio.Font = new Font("Ebrima", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverInicio.Location = new Point(1317, 11);
            btnVolverInicio.Margin = new Padding(3, 2, 3, 2);
            btnVolverInicio.Name = "btnVolverInicio";
            btnVolverInicio.Size = new Size(211, 38);
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
            dataGridViewUsuario.Location = new Point(350, 78);
            dataGridViewUsuario.MultiSelect = false;
            dataGridViewUsuario.Name = "dataGridViewUsuario";
            dataGridViewUsuario.ReadOnly = true;
            dataGridViewUsuario.RowTemplate.Height = 25;
            dataGridViewUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsuario.Size = new Size(1158, 421);
            dataGridViewUsuario.TabIndex = 25;
            dataGridViewUsuario.CellContentClick += dataGridViewUsuario_CellContentClick;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.BackColor = Color.Transparent;
            lblDNI.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDNI.ForeColor = Color.Black;
            lblDNI.Location = new Point(13, 238);
            lblDNI.Margin = new Padding(4, 0, 4, 0);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(40, 21);
            lblDNI.TabIndex = 28;
            lblDNI.Text = "DNI";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.ForeColor = Color.Black;
            lblApellido.Location = new Point(13, 198);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(75, 21);
            lblApellido.TabIndex = 27;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(13, 157);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(73, 21);
            lblNombre.TabIndex = 26;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(102, 157);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(208, 29);
            txtNombre.TabIndex = 30;
            // 
            // txtDNI
            // 
            txtDNI.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDNI.Location = new Point(102, 238);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(208, 29);
            txtDNI.TabIndex = 31;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(102, 198);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(208, 29);
            txtApellido.TabIndex = 31;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.BackColor = Color.Transparent;
            lblusuario.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblusuario.ForeColor = Color.Black;
            lblusuario.Location = new Point(13, 285);
            lblusuario.Margin = new Padding(4, 0, 4, 0);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(87, 21);
            lblusuario.TabIndex = 46;
            lblusuario.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(102, 285);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(208, 29);
            txtUsername.TabIndex = 47;
            // 
            // lblBAJA
            // 
            lblBAJA.AutoSize = true;
            lblBAJA.BackColor = Color.Transparent;
            lblBAJA.Font = new Font("Ebrima", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblBAJA.ForeColor = Color.Black;
            lblBAJA.Location = new Point(872, 43);
            lblBAJA.Margin = new Padding(4, 0, 4, 0);
            lblBAJA.Name = "lblBAJA";
            lblBAJA.Size = new Size(185, 32);
            lblBAJA.TabIndex = 48;
            lblBAJA.Text = "BAJA USUARIOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Ebrima", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(836, 537);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(251, 32);
            label2.TabIndex = 50;
            label2.Text = "REACTIVAR USUARIOS";
            // 
            // dataGridViewReactivar
            // 
            dataGridViewReactivar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewReactivar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewReactivar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewReactivar.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewReactivar.Location = new Point(601, 572);
            dataGridViewReactivar.MultiSelect = false;
            dataGridViewReactivar.Name = "dataGridViewReactivar";
            dataGridViewReactivar.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewReactivar.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewReactivar.RowTemplate.Height = 25;
            dataGridViewReactivar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReactivar.Size = new Size(692, 247);
            dataGridViewReactivar.TabIndex = 52;
            dataGridViewReactivar.CellContentClick += dataGridViewReactivar_CellContentClick;
            // 
            // btnReactivar
            // 
            btnReactivar.BackColor = Color.Green;
            btnReactivar.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReactivar.ForeColor = Color.White;
            btnReactivar.Location = new Point(404, 671);
            btnReactivar.Margin = new Padding(4, 2, 4, 2);
            btnReactivar.Name = "btnReactivar";
            btnReactivar.Size = new Size(140, 40);
            btnReactivar.TabIndex = 53;
            btnReactivar.Text = "REACTIVAR";
            btnReactivar.UseVisualStyleBackColor = false;
            btnReactivar.Click += btnReactivar_Click;
            // 
            // lblAlertaUsuarios
            // 
            lblAlertaUsuarios.AutoSize = true;
            lblAlertaUsuarios.BackColor = Color.Transparent;
            lblAlertaUsuarios.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlertaUsuarios.ForeColor = Color.Green;
            lblAlertaUsuarios.Location = new Point(34, 514);
            lblAlertaUsuarios.Name = "lblAlertaUsuarios";
            lblAlertaUsuarios.Size = new Size(52, 21);
            lblAlertaUsuarios.TabIndex = 54;
            lblAlertaUsuarios.Text = "label1";
            // 
            // FrmBajaModUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1540, 845);
            Controls.Add(lblAlertaUsuarios);
            Controls.Add(btnReactivar);
            Controls.Add(dataGridViewReactivar);
            Controls.Add(label2);
            Controls.Add(lblBAJA);
            Controls.Add(txtUsername);
            Controls.Add(lblusuario);
            Controls.Add(txtApellido);
            Controls.Add(txtDNI);
            Controls.Add(txtNombre);
            Controls.Add(lblDNI);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(dataGridViewUsuario);
            Controls.Add(btnVolverInicio);
            Controls.Add(btnBajaUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmBajaModUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Baja-Modificacion Usuario";
            WindowState = FormWindowState.Maximized;
            Load += FrmBajaModUsuario_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReactivar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBajaUsuario;
        private Button btnVolverInicio;
        private DataGridView dataGridViewUsuario;
        private Label lblDNI;
        private Label lblApellido;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private TextBox txtApellido;
        private Label lblusuario;
        private TextBox txtUsername;
        private Label lblBAJA;
        private Label label2;
        private DataGridView dataGridViewReactivar;
        private Button btnReactivar;
        private Label lblAlertaUsuarios;
    }
}