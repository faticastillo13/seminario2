namespace seminario2.Interfases.VentanaFacturas
{
    partial class CargarFactura
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
            dgVentas = new DataGridView();
            id_producto = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            btnGuardar = new Button();
            bConsultarProducto = new Button();
            btCerrar = new Button();
            txtNroFactura = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgVentas).BeginInit();
            SuspendLayout();
            // 
            // dgVentas
            // 
            dgVentas.AllowUserToAddRows = false;
            dgVentas.BackgroundColor = SystemColors.Control;
            dgVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVentas.Columns.AddRange(new DataGridViewColumn[] { id_producto, cantidad, descripcion, precio });
            dgVentas.Location = new Point(53, 73);
            dgVentas.Name = "dgVentas";
            dgVentas.RowTemplate.Height = 25;
            dgVentas.Size = new Size(444, 288);
            dgVentas.TabIndex = 14;
            // 
            // id_producto
            // 
            id_producto.HeaderText = "id_producto";
            id_producto.Name = "id_producto";
            // 
            // cantidad
            // 
            cantidad.HeaderText = "cantidad";
            cantidad.Name = "cantidad";
            // 
            // descripcion
            // 
            descripcion.HeaderText = "nombre";
            descripcion.Name = "descripcion";
            // 
            // precio
            // 
            precio.HeaderText = "precio";
            precio.Name = "precio";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(104, 377);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // bConsultarProducto
            // 
            bConsultarProducto.Location = new Point(207, 377);
            bConsultarProducto.Name = "bConsultarProducto";
            bConsultarProducto.Size = new Size(125, 23);
            bConsultarProducto.TabIndex = 17;
            bConsultarProducto.Text = "Consultar Producto";
            bConsultarProducto.UseVisualStyleBackColor = true;
            bConsultarProducto.Click += bConsultarProducto_Click;
            // 
            // btCerrar
            // 
            btCerrar.Location = new Point(356, 377);
            btCerrar.Name = "btCerrar";
            btCerrar.Size = new Size(75, 23);
            btCerrar.TabIndex = 18;
            btCerrar.Text = "Cerrar";
            btCerrar.UseVisualStyleBackColor = true;
            btCerrar.Click += btCerrar_Click;
            // 
            // txtNroFactura
            // 
            txtNroFactura.Location = new Point(125, 25);
            txtNroFactura.Name = "txtNroFactura";
            txtNroFactura.ReadOnly = true;
            txtNroFactura.Size = new Size(100, 23);
            txtNroFactura.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 25);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Nro Factura";
            // 
            // CargarFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 418);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(btCerrar);
            Controls.Add(txtNroFactura);
            Controls.Add(bConsultarProducto);
            Controls.Add(btnGuardar);
            Controls.Add(dgVentas);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CargarFactura";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CargarFactura";
            Load += CargarFactura_Load;
            ((System.ComponentModel.ISupportInitialize)dgVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgVentas;
        private Button btnGuardar;
        private Button bConsultarProducto;
        private Button btCerrar;
        private DataGridViewTextBoxColumn id_producto;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn precio;
        private Label label2;
        public TextBox txtNroFactura;
    }
}