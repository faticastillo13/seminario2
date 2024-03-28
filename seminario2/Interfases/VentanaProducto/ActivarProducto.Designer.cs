namespace seminario2.Interfases.VentanaProducto
{
    partial class ActivarProducto
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
            label8 = new Label();
            label2 = new Label();
            label1 = new Label();
            btActivar = new Button();
            txtId = new TextBox();
            rtDescripcion = new RichTextBox();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dgProductos = new DataGridView();
            btEliminar = new Button();
            txtCategoria = new TextBox();
            txtSubcategoria = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgProductos).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 37);
            label8.Name = "label8";
            label8.Size = new Size(18, 15);
            label8.TabIndex = 67;
            label8.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 334);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 66;
            label2.Text = "Subcategoria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 278);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 65;
            label1.Text = "Categoria";
            // 
            // btActivar
            // 
            btActivar.Enabled = false;
            btActivar.Location = new Point(111, 400);
            btActivar.Name = "btActivar";
            btActivar.Size = new Size(75, 23);
            btActivar.TabIndex = 62;
            btActivar.Text = "Activar";
            btActivar.UseVisualStyleBackColor = true;
            btActivar.Click += btActivar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(86, 28);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 61;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // rtDescripcion
            // 
            rtDescripcion.Location = new Point(86, 96);
            rtDescripcion.Name = "rtDescripcion";
            rtDescripcion.Size = new Size(214, 74);
            rtDescripcion.TabIndex = 59;
            rtDescripcion.Text = "";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(86, 203);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 58;
            txtPrecio.Text = "0";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(86, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese el nombre del producto";
            txtNombre.Size = new Size(214, 23);
            txtNombre.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 206);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 55;
            label5.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-13, 114);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 54;
            label4.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 60);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 53;
            label3.Text = "Nombre";
            // 
            // dgProductos
            // 
            dgProductos.AllowUserToAddRows = false;
            dgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductos.Location = new Point(317, 28);
            dgProductos.Name = "dgProductos";
            dgProductos.ReadOnly = true;
            dgProductos.RowTemplate.Height = 25;
            dgProductos.Size = new Size(636, 348);
            dgProductos.TabIndex = 52;
            // 
            // btEliminar
            // 
            btEliminar.Enabled = false;
            btEliminar.Location = new Point(216, 400);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(75, 23);
            btEliminar.TabIndex = 68;
            btEliminar.Text = "Eliminar";
            btEliminar.UseVisualStyleBackColor = true;
            btEliminar.Click += btEliminar_Click;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(80, 278);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(198, 23);
            txtCategoria.TabIndex = 69;
            // 
            // txtSubcategoria
            // 
            txtSubcategoria.Location = new Point(82, 335);
            txtSubcategoria.Name = "txtSubcategoria";
            txtSubcategoria.Size = new Size(196, 23);
            txtSubcategoria.TabIndex = 70;
            // 
            // ActivarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 453);
            ControlBox = false;
            Controls.Add(txtSubcategoria);
            Controls.Add(txtCategoria);
            Controls.Add(btEliminar);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btActivar);
            Controls.Add(txtId);
            Controls.Add(rtDescripcion);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgProductos);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ActivarProducto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ActivarProducto";
            Load += ActivarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        public DataGridView dgProductos;
        public TextBox txtId;
        public RichTextBox rtDescripcion;
        public TextBox txtPrecio;
        public TextBox txtNombre;
        public TextBox txtCategoria;
        public TextBox txtSubcategoria;
        public Button btActivar;
        public Button btEliminar;
    }
}