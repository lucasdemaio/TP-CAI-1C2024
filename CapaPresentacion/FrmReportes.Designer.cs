namespace Presentacion
{
    partial class FrmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            btnVolverInicio = new Button();
            cbReportes = new ComboBox();
            dataGridViewReportes = new DataGridView();
            lblReportes = new Label();
            lblReporteserror = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReportes).BeginInit();
            SuspendLayout();
            // 
            // btnVolverInicio
            // 
            btnVolverInicio.BackColor = SystemColors.Info;
            btnVolverInicio.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverInicio.Location = new Point(565, 414);
            btnVolverInicio.Name = "btnVolverInicio";
            btnVolverInicio.Size = new Size(231, 33);
            btnVolverInicio.TabIndex = 43;
            btnVolverInicio.Text = "VOLVER MENU PRINCIPAL";
            btnVolverInicio.UseVisualStyleBackColor = false;
            btnVolverInicio.Click += btnVolverInicio_Click;
            // 
            // cbReportes
            // 
            cbReportes.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbReportes.FormattingEnabled = true;
            cbReportes.Location = new Point(217, 56);
            cbReportes.Name = "cbReportes";
            cbReportes.Size = new Size(403, 29);
            cbReportes.TabIndex = 44;
            cbReportes.SelectedIndexChanged += cbReportes_SelectedIndexChanged;
            // 
            // dataGridViewReportes
            // 
            dataGridViewReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewReportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewReportes.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewReportes.Location = new Point(36, 104);
            dataGridViewReportes.Name = "dataGridViewReportes";
            dataGridViewReportes.RowTemplate.Height = 25;
            dataGridViewReportes.Size = new Size(760, 267);
            dataGridViewReportes.TabIndex = 45;
            // 
            // lblReportes
            // 
            lblReportes.AutoSize = true;
            lblReportes.BackColor = Color.Transparent;
            lblReportes.Font = new Font("Ebrima", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblReportes.ForeColor = Color.Black;
            lblReportes.Location = new Point(364, 9);
            lblReportes.Name = "lblReportes";
            lblReportes.Size = new Size(123, 32);
            lblReportes.TabIndex = 46;
            lblReportes.Text = "REPORTES";
            // 
            // lblReporteserror
            // 
            lblReporteserror.AutoSize = true;
            lblReporteserror.BackColor = Color.Transparent;
            lblReporteserror.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblReporteserror.ForeColor = Color.Black;
            lblReporteserror.Location = new Point(189, 385);
            lblReporteserror.Name = "lblReporteserror";
            lblReporteserror.Size = new Size(52, 21);
            lblReporteserror.TabIndex = 47;
            lblReporteserror.Text = "label1";
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(821, 459);
            Controls.Add(btnVolverInicio);
            Controls.Add(lblReporteserror);
            Controls.Add(lblReportes);
            Controls.Add(dataGridViewReportes);
            Controls.Add(cbReportes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportes";
            Load += FrmReportes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewReportes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnVolverInicio;
        private ComboBox cbReportes;
        private DataGridView dataGridViewReportes;
        private Label lblReportes;
        private Label lblReporteserror;
    }
}