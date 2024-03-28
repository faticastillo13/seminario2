namespace seminario2.Interfases.VentanaFacturas
{
    partial class AñadirDetalleFactura
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNroFactura = new TextBox();
            txtIdProducto = new TextBox();
            txtNombreProducto = new TextBox();
            btCargar = new Button();
            nupCantidad = new NumericUpDown();
            button1 = new Button();
            btVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)nupCantidad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 28);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Nro Factura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 78);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 1;
            label2.Text = "Id del producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 124);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre del Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 172);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Cantidad";
            // 
            // txtNroFactura
            // 
            txtNroFactura.Location = new Point(160, 28);
            txtNroFactura.Name = "txtNroFactura";
            txtNroFactura.ReadOnly = true;
            txtNroFactura.Size = new Size(100, 23);
            txtNroFactura.TabIndex = 4;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(160, 78);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.ReadOnly = true;
            txtIdProducto.Size = new Size(100, 23);
            txtIdProducto.TabIndex = 5;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(160, 124);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.ReadOnly = true;
            txtNombreProducto.Size = new Size(191, 23);
            txtNombreProducto.TabIndex = 6;
            // 
            // btCargar
            // 
            btCargar.Location = new Point(106, 237);
            btCargar.Name = "btCargar";
            btCargar.Size = new Size(75, 23);
            btCargar.TabIndex = 8;
            btCargar.Text = "Cargar";
            btCargar.UseVisualStyleBackColor = true;
            btCargar.Click += btCargar_Click;
            // 
            // nupCantidad
            // 
            nupCantidad.Location = new Point(163, 172);
            nupCantidad.Name = "nupCantidad";
            nupCantidad.Size = new Size(120, 23);
            nupCantidad.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(938, 513);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btVolver
            // 
            btVolver.Location = new Point(208, 237);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(75, 23);
            btVolver.TabIndex = 11;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = true;
            btVolver.Click += btVolver_Click;
            // 
            // AñadirDetalleFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 293);
            ControlBox = false;
            Controls.Add(btVolver);
            Controls.Add(button1);
            Controls.Add(nupCantidad);
            Controls.Add(btCargar);
            Controls.Add(txtNombreProducto);
            Controls.Add(txtIdProducto);
            Controls.Add(txtNroFactura);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AñadirDetalleFactura";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AñadirDetalleFactura";
            Load += AñadirDetalleFactura_Load;
            ((System.ComponentModel.ISupportInitialize)nupCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNroFactura;
        private TextBox txtIdProducto;
        private TextBox txtNombreProducto;
        private Button btCargar;
        private NumericUpDown nupCantidad;
        private Button button1;
        private Button btVolver;
    }
}