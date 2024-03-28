namespace seminario2.Interfases.VentanaProducto
{
    partial class vtnCargarProductos
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
            dgProductos = new DataGridView();
            cbCategoria = new ComboBox();
            cbSubcategoria = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btCargar = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            rtDescripcion = new RichTextBox();
            txtStock = new TextBox();
            btAñadir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgProductos).BeginInit();
            SuspendLayout();
            // 
            // dgProductos
            // 
            dgProductos.AllowUserToAddRows = false;
            dgProductos.AllowUserToResizeRows = false;
            dgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductos.Location = new Point(386, 38);
            dgProductos.Name = "dgProductos";
            dgProductos.RowTemplate.Height = 25;
            dgProductos.Size = new Size(402, 336);
            dgProductos.TabIndex = 0;
            dgProductos.CellContentDoubleClick += dgProductos_CellContentDoubleClick;
            // 
            // cbCategoria
            // 
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(124, 235);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(214, 23);
            cbCategoria.TabIndex = 1;
            cbCategoria.SelectedIndexChanged += cbCategoria_SelectedIndexChanged;
            // 
            // cbSubcategoria
            // 
            cbSubcategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSubcategoria.FormattingEnabled = true;
            cbSubcategoria.Location = new Point(124, 294);
            cbSubcategoria.Name = "cbSubcategoria";
            cbSubcategoria.Size = new Size(214, 23);
            cbSubcategoria.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 238);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 3;
            label1.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 302);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 4;
            label2.Text = "Subcategoria";
            // 
            // btCargar
            // 
            btCargar.Location = new Point(48, 370);
            btCargar.Name = "btCargar";
            btCargar.Size = new Size(75, 23);
            btCargar.TabIndex = 5;
            btCargar.Text = "Cargar";
            btCargar.UseVisualStyleBackColor = true;
            btCargar.Click += btCargar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 18);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 57);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 7;
            label4.Text = "Descripcion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 138);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 8;
            label5.Text = "Precio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 182);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 9;
            label6.Text = "Stock";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(124, 18);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese el nombre del producto";
            txtNombre.Size = new Size(214, 23);
            txtNombre.TabIndex = 10;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(124, 135);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 12;
            txtPrecio.Text = "0";
            // 
            // rtDescripcion
            // 
            rtDescripcion.Location = new Point(124, 50);
            rtDescripcion.Name = "rtDescripcion";
            rtDescripcion.Size = new Size(214, 74);
            rtDescripcion.TabIndex = 13;
            rtDescripcion.Text = "";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(124, 182);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 14;
            txtStock.Text = "0";
            // 
            // btAñadir
            // 
            btAñadir.Location = new Point(177, 370);
            btAñadir.Name = "btAñadir";
            btAñadir.Size = new Size(106, 23);
            btAñadir.TabIndex = 15;
            btAñadir.Text = "Añadir a compra";
            btAñadir.UseVisualStyleBackColor = true;
            // 
            // vtnCargarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btAñadir);
            Controls.Add(txtStock);
            Controls.Add(rtDescripcion);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btCargar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbSubcategoria);
            Controls.Add(cbCategoria);
            Controls.Add(dgProductos);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "vtnCargarProductos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CargarProducto";
            Load += vtnCargarProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgProductos;
        private ComboBox cbCategoria;
        private ComboBox cbSubcategoria;
        private Label label1;
        private Label label2;
        private Button btCargar;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private RichTextBox rtDescripcion;
        private TextBox txtStock;
        private Button btAñadir;
    }
}