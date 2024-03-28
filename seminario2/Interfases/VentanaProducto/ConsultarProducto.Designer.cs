namespace seminario2.Interfases.VentanaProducto
{
    partial class ConsultarProducto
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
            label1 = new Label();
            dgProductos = new DataGridView();
            txtProducto = new TextBox();
            txtBuscar = new Button();
            gbFiltros = new GroupBox();
            rbId = new RadioButton();
            rbCategoria = new RadioButton();
            rbNombre = new RadioButton();
            gbCategoria = new GroupBox();
            cbCategoria = new ComboBox();
            label2 = new Label();
            gbId = new GroupBox();
            nupId = new NumericUpDown();
            label3 = new Label();
            gbNombre = new GroupBox();
            btAñadir = new Button();
            label4 = new Label();
            txtId = new TextBox();
            label5 = new Label();
            txtNombreProducto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgProductos).BeginInit();
            gbFiltros.SuspendLayout();
            gbCategoria.SuspendLayout();
            gbId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupId).BeginInit();
            gbNombre.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Producto";
            // 
            // dgProductos
            // 
            dgProductos.AllowUserToAddRows = false;
            dgProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductos.Location = new Point(0, 300);
            dgProductos.Name = "dgProductos";
            dgProductos.RowTemplate.Height = 25;
            dgProductos.Size = new Size(800, 150);
            dgProductos.TabIndex = 1;
            dgProductos.CellContentDoubleClick += dgProductos_CellContentDoubleClick;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(6, 52);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(177, 23);
            txtProducto.TabIndex = 2;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(339, 256);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(75, 23);
            txtBuscar.TabIndex = 3;
            txtBuscar.Text = "Buscar";
            txtBuscar.UseVisualStyleBackColor = true;
            txtBuscar.Click += txtBuscar_Click;
            // 
            // gbFiltros
            // 
            gbFiltros.Controls.Add(rbId);
            gbFiltros.Controls.Add(rbCategoria);
            gbFiltros.Controls.Add(rbNombre);
            gbFiltros.Location = new Point(406, 13);
            gbFiltros.Name = "gbFiltros";
            gbFiltros.Size = new Size(200, 100);
            gbFiltros.TabIndex = 4;
            gbFiltros.TabStop = false;
            gbFiltros.Text = "Filtros";
            // 
            // rbId
            // 
            rbId.AutoSize = true;
            rbId.Location = new Point(49, 72);
            rbId.Name = "rbId";
            rbId.Size = new Size(89, 19);
            rbId.TabIndex = 2;
            rbId.Text = "Filtrar por id";
            rbId.UseVisualStyleBackColor = true;
            rbId.CheckedChanged += rbId_CheckedChanged;
            // 
            // rbCategoria
            // 
            rbCategoria.AutoSize = true;
            rbCategoria.Location = new Point(49, 49);
            rbCategoria.Name = "rbCategoria";
            rbCategoria.Size = new Size(128, 19);
            rbCategoria.TabIndex = 1;
            rbCategoria.Text = "Filtrar por categoria";
            rbCategoria.UseVisualStyleBackColor = true;
            rbCategoria.CheckedChanged += rbCategoria_CheckedChanged;
            // 
            // rbNombre
            // 
            rbNombre.AutoSize = true;
            rbNombre.Location = new Point(49, 22);
            rbNombre.Name = "rbNombre";
            rbNombre.Size = new Size(121, 19);
            rbNombre.TabIndex = 0;
            rbNombre.Text = "Filtrar por nombre";
            rbNombre.UseVisualStyleBackColor = true;
            rbNombre.CheckedChanged += rbNombre_CheckedChanged;
            // 
            // gbCategoria
            // 
            gbCategoria.Controls.Add(cbCategoria);
            gbCategoria.Controls.Add(label2);
            gbCategoria.Location = new Point(276, 131);
            gbCategoria.Name = "gbCategoria";
            gbCategoria.Size = new Size(200, 100);
            gbCategoria.TabIndex = 5;
            gbCategoria.TabStop = false;
            gbCategoria.Text = "Categoria";
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(24, 53);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(153, 23);
            cbCategoria.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 24);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Categoria";
            // 
            // gbId
            // 
            gbId.Controls.Add(nupId);
            gbId.Controls.Add(label3);
            gbId.Location = new Point(548, 131);
            gbId.Name = "gbId";
            gbId.Size = new Size(200, 100);
            gbId.TabIndex = 6;
            gbId.TabStop = false;
            gbId.Text = "Id";
            // 
            // nupId
            // 
            nupId.Location = new Point(17, 52);
            nupId.Name = "nupId";
            nupId.Size = new Size(120, 23);
            nupId.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 24);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 1;
            label3.Text = "Id";
            // 
            // gbNombre
            // 
            gbNombre.Controls.Add(label1);
            gbNombre.Controls.Add(txtProducto);
            gbNombre.Location = new Point(12, 131);
            gbNombre.Name = "gbNombre";
            gbNombre.Size = new Size(200, 100);
            gbNombre.TabIndex = 7;
            gbNombre.TabStop = false;
            gbNombre.Text = "Nombre";
            // 
            // btAñadir
            // 
            btAñadir.Enabled = false;
            btAñadir.Location = new Point(469, 260);
            btAñadir.Name = "btAñadir";
            btAñadir.Size = new Size(113, 23);
            btAñadir.TabIndex = 8;
            btAñadir.Text = "Añadir producto";
            btAñadir.UseVisualStyleBackColor = true;
            btAñadir.Click += btAñadir_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 13);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 9;
            label4.Text = "Id Producto";
            // 
            // txtId
            // 
            txtId.Location = new Point(95, 12);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(66, 23);
            txtId.TabIndex = 10;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 55);
            label5.Name = "label5";
            label5.Size = new Size(122, 15);
            label5.TabIndex = 11;
            label5.Text = "Nombre del producto";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(146, 52);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.ReadOnly = true;
            txtNombreProducto.Size = new Size(143, 23);
            txtNombreProducto.TabIndex = 12;
            // 
            // ConsultarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(txtNombreProducto);
            Controls.Add(label5);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(btAñadir);
            Controls.Add(gbNombre);
            Controls.Add(gbId);
            Controls.Add(gbCategoria);
            Controls.Add(gbFiltros);
            Controls.Add(txtBuscar);
            Controls.Add(dgProductos);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConsultarProducto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ConsultarProducto";
            Load += ConsultarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgProductos).EndInit();
            gbFiltros.ResumeLayout(false);
            gbFiltros.PerformLayout();
            gbCategoria.ResumeLayout(false);
            gbCategoria.PerformLayout();
            gbId.ResumeLayout(false);
            gbId.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupId).EndInit();
            gbNombre.ResumeLayout(false);
            gbNombre.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgProductos;
        private TextBox txtProducto;
        private Button txtBuscar;
        private GroupBox gbFiltros;
        private RadioButton rbId;
        private RadioButton rbCategoria;
        private RadioButton rbNombre;
        private GroupBox gbCategoria;
        private GroupBox gbId;
        private GroupBox gbNombre;
        private ComboBox cbCategoria;
        private Label label2;
        private NumericUpDown nupId;
        private Label label3;
        private Button btAñadir;
        private Label label4;
        private TextBox txtId;
        private Label label5;
        private TextBox txtNombreProducto;
    }
}