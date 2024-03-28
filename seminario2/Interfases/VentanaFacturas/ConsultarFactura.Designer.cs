namespace seminario2.Interfases.VentanaFacturas
{
    partial class ConsultarFactura
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
            dgDetalleFactura = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtFecha = new TextBox();
            label3 = new Label();
            btSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgDetalleFactura).BeginInit();
            SuspendLayout();
            // 
            // dgDetalleFactura
            // 
            dgDetalleFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDetalleFactura.Location = new Point(12, 49);
            dgDetalleFactura.Name = "dgDetalleFactura";
            dgDetalleFactura.RowTemplate.Height = 25;
            dgDetalleFactura.Size = new Size(707, 276);
            dgDetalleFactura.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 12);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "Id Factura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 12);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtId
            // 
            txtId.Location = new Point(93, 9);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(302, 9);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(194, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(581, 12);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(127, 23);
            txtFecha.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(537, 15);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "Fecha";
            // 
            // btSalir
            // 
            btSalir.Location = new Point(251, 338);
            btSalir.Name = "btSalir";
            btSalir.Size = new Size(75, 23);
            btSalir.TabIndex = 7;
            btSalir.Text = "Cerrar";
            btSalir.UseVisualStyleBackColor = true;
            btSalir.Click += btSalir_Click;
            // 
            // ConsultarFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btSalir);
            Controls.Add(label3);
            Controls.Add(txtFecha);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgDetalleFactura);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConsultarFactura";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ConsultarFactura";
            Load += ConsultarFactura_Load;
            ((System.ComponentModel.ISupportInitialize)dgDetalleFactura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgDetalleFactura;
        private Label label1;
        private Label label2;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtFecha;
        private Label label3;
        private Button btSalir;
    }
}