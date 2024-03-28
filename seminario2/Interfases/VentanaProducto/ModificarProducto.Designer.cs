namespace seminario2.Interfases.VentanaProducto
{
    partial class ModificarProducto
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
            txtId = new TextBox();
            label7 = new Label();
            txtStock = new TextBox();
            rtDescripcion = new RichTextBox();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dgProductos = new DataGridView();
            btModificar = new Button();
            label2 = new Label();
            label1 = new Label();
            cbSubcategoria = new ComboBox();
            cbCategoria = new ComboBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgProductos).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(157, 27);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 45;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(-19, 24);
            label7.Name = "label7";
            label7.Size = new Size(18, 15);
            label7.TabIndex = 44;
            label7.Text = "ID";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(157, 223);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 42;
            txtStock.Text = "0";
            // 
            // rtDescripcion
            // 
            rtDescripcion.Location = new Point(157, 95);
            rtDescripcion.Name = "rtDescripcion";
            rtDescripcion.Size = new Size(214, 74);
            rtDescripcion.TabIndex = 41;
            rtDescripcion.Text = "";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(157, 179);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 40;
            txtPrecio.Text = "0";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(157, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese el nombre del producto";
            txtNombre.Size = new Size(214, 23);
            txtNombre.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(87, 231);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 38;
            label6.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 187);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 37;
            label5.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 113);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 36;
            label4.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 59);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 35;
            label3.Text = "Nombre";
            // 
            // dgProductos
            // 
            dgProductos.AllowUserToAddRows = false;
            dgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductos.Location = new Point(388, 27);
            dgProductos.Name = "dgProductos";
            dgProductos.RowTemplate.Height = 25;
            dgProductos.Size = new Size(497, 348);
            dgProductos.TabIndex = 33;
            dgProductos.CellContentDoubleClick += dgProductos_CellContentDoubleClick;
            // 
            // btModificar
            // 
            btModificar.Enabled = false;
            btModificar.Location = new Point(182, 399);
            btModificar.Name = "btModificar";
            btModificar.Size = new Size(75, 23);
            btModificar.TabIndex = 46;
            btModificar.Text = "Modificar";
            btModificar.UseVisualStyleBackColor = true;
            btModificar.Click += btModificar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 333);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 50;
            label2.Text = "Subcategoria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 277);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 49;
            label1.Text = "Categoria";
            // 
            // cbSubcategoria
            // 
            cbSubcategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSubcategoria.FormattingEnabled = true;
            cbSubcategoria.Location = new Point(157, 333);
            cbSubcategoria.Name = "cbSubcategoria";
            cbSubcategoria.Size = new Size(214, 23);
            cbSubcategoria.TabIndex = 48;
            // 
            // cbCategoria
            // 
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(157, 274);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(214, 23);
            cbCategoria.TabIndex = 47;
            cbCategoria.SelectedIndexChanged += cbCategoria_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(87, 36);
            label8.Name = "label8";
            label8.Size = new Size(18, 15);
            label8.TabIndex = 51;
            label8.Text = "ID";
            // 
            // ModificarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 471);
            ControlBox = false;
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbSubcategoria);
            Controls.Add(cbCategoria);
            Controls.Add(btModificar);
            Controls.Add(txtId);
            Controls.Add(label7);
            Controls.Add(txtStock);
            Controls.Add(rtDescripcion);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgProductos);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ModificarProducto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ModificarProducto";
            Load += ModificarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label7;
        private TextBox txtStock;
        private RichTextBox rtDescripcion;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dgProductos;
        private Button btModificar;
        private Label label2;
        private Label label1;
        private ComboBox cbSubcategoria;
        private ComboBox cbCategoria;
        private Label label8;
    }
}