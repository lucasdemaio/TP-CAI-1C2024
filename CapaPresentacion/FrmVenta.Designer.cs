namespace Presentacion
{
    partial class FrmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenta));
            btnVolverInicio = new Button();
            listView1 = new ListView();
            groupBoxCarrito = new GroupBox();
            cbCliente = new ComboBox();
            dateTimePickerVenta = new DateTimePicker();
            dataGridViewProducto = new DataGridView();
            btnAgregar = new Button();
            button1 = new Button();
            groupBoxCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducto).BeginInit();
            SuspendLayout();
            // 
            // btnVolverInicio
            // 
            btnVolverInicio.BackColor = SystemColors.Info;
            btnVolverInicio.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverInicio.Location = new Point(1171, 752);
            btnVolverInicio.Margin = new Padding(4);
            btnVolverInicio.Name = "btnVolverInicio";
            btnVolverInicio.Size = new Size(294, 46);
            btnVolverInicio.TabIndex = 43;
            btnVolverInicio.Text = "VOLVER MENU PRINCIPAL";
            btnVolverInicio.UseVisualStyleBackColor = false;
            btnVolverInicio.Click += btnVolverInicio_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(26, 48);
            listView1.Margin = new Padding(4);
            listView1.Name = "listView1";
            listView1.Size = new Size(624, 264);
            listView1.TabIndex = 44;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBoxCarrito
            // 
            groupBoxCarrito.Controls.Add(listView1);
            groupBoxCarrito.Location = new Point(774, 195);
            groupBoxCarrito.Margin = new Padding(4);
            groupBoxCarrito.Name = "groupBoxCarrito";
            groupBoxCarrito.Padding = new Padding(4);
            groupBoxCarrito.Size = new Size(675, 352);
            groupBoxCarrito.TabIndex = 45;
            groupBoxCarrito.TabStop = false;
            groupBoxCarrito.Text = "Carrito";
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(51, 169);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(309, 29);
            cbCliente.TabIndex = 46;
            // 
            // dateTimePickerVenta
            // 
            dateTimePickerVenta.Location = new Point(51, 81);
            dateTimePickerVenta.Name = "dateTimePickerVenta";
            dateTimePickerVenta.Size = new Size(309, 29);
            dateTimePickerVenta.TabIndex = 47;
            // 
            // dataGridViewProducto
            // 
            dataGridViewProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducto.Location = new Point(51, 246);
            dataGridViewProducto.MultiSelect = false;
            dataGridViewProducto.Name = "dataGridViewProducto";
            dataGridViewProducto.ReadOnly = true;
            dataGridViewProducto.RowTemplate.Height = 25;
            dataGridViewProducto.Size = new Size(648, 270);
            dataGridViewProducto.TabIndex = 48;
            dataGridViewProducto.CellContentClick += dataGridViewProducto_CellContentClick;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Green;
            btnAgregar.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(134, 541);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(196, 30);
            btnAgregar.TabIndex = 49;
            btnAgregar.Text = "AGREGAR AL CARRITO";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(440, 541);
            button1.Name = "button1";
            button1.Size = new Size(206, 30);
            button1.TabIndex = 50;
            button1.Text = "REMOVER DEL CARRITO";
            button1.UseVisualStyleBackColor = false;
            // 
            // FrmVenta
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1481, 815);
            Controls.Add(button1);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridViewProducto);
            Controls.Add(dateTimePickerVenta);
            Controls.Add(cbCliente);
            Controls.Add(groupBoxCarrito);
            Controls.Add(btnVolverInicio);
            Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FrmVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventas";
            WindowState = FormWindowState.Maximized;
            Load += FrmVenta_Load;
            groupBoxCarrito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolverInicio;
        private ListView listView1;
        private GroupBox groupBoxCarrito;
        private ComboBox cbCliente;
        private DateTimePicker dateTimePickerVenta;
        private DataGridView dataGridViewProducto;
        private Button btnAgregar;
        private Button button1;
    }
}