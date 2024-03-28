namespace seminario2.Interfases.VentanaProducto
{
    partial class BorrarProducto
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
            txtStock = new TextBox();
            rtDescripcion = new RichTextBox();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgProductos = new DataGridView();
            txtCategoria = new TextBox();
            txtSubcategoria = new TextBox();
            btnBorrar = new Button();
            label7 = new Label();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgProductos).BeginInit();
            SuspendLayout();
            // 
            // txtStock
            // 
            txtStock.Location = new Point(109, 211);
            txtStock.Name = "txtStock";
            txtStock.ReadOnly = true;
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 27;
            txtStock.Text = "0";
            // 
            // rtDescripcion
            // 
            rtDescripcion.Location = new Point(109, 79);
            rtDescripcion.Name = "rtDescripcion";
            rtDescripcion.ReadOnly = true;
            rtDescripcion.Size = new Size(214, 74);
            rtDescripcion.TabIndex = 26;
            rtDescripcion.Text = "";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(109, 164);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 25;
            txtPrecio.Text = "0";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(109, 47);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese el nombre del producto";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(214, 23);
            txtNombre.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 211);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 23;
            label6.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 167);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 22;
            label5.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 86);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 21;
            label4.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 47);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 20;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 331);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 19;
            label2.Text = "Subcategoria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 267);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 18;
            label1.Text = "Categoria";
            // 
            // dgProductos
            // 
            dgProductos.AllowUserToAddRows = false;
            dgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductos.Location = new Point(346, 67);
            dgProductos.Name = "dgProductos";
            dgProductos.RowTemplate.Height = 25;
            dgProductos.Size = new Size(524, 348);
            dgProductos.TabIndex = 15;
            dgProductos.CellContentDoubleClick += dgProductos_CellContentDoubleClick;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(113, 267);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.ReadOnly = true;
            txtCategoria.Size = new Size(210, 23);
            txtCategoria.TabIndex = 28;
            // 
            // txtSubcategoria
            // 
            txtSubcategoria.Location = new Point(112, 329);
            txtSubcategoria.Name = "txtSubcategoria";
            txtSubcategoria.ReadOnly = true;
            txtSubcategoria.Size = new Size(211, 23);
            txtSubcategoria.TabIndex = 29;
            // 
            // btnBorrar
            // 
            btnBorrar.Enabled = false;
            btnBorrar.Location = new Point(155, 405);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(93, 23);
            btnBorrar.TabIndex = 30;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 12);
            label7.Name = "label7";
            label7.Size = new Size(18, 15);
            label7.TabIndex = 31;
            label7.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(105, 15);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 32;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // BorrarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 520);
            ControlBox = false;
            Controls.Add(txtId);
            Controls.Add(label7);
            Controls.Add(btnBorrar);
            Controls.Add(txtSubcategoria);
            Controls.Add(txtCategoria);
            Controls.Add(txtStock);
            Controls.Add(rtDescripcion);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgProductos);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BorrarProducto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BorrarProducto";
            Load += BorrarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStock;
        private RichTextBox rtDescripcion;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgProductos;
        private TextBox txtCategoria;
        private TextBox txtSubcategoria;
        private Button btnBorrar;
        private Label label7;
        private TextBox txtId;
    }
}