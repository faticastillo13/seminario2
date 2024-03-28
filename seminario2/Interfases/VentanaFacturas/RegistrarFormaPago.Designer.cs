namespace seminario2.Interfases.VentanaFacturas
{
    partial class RegistrarFormaPago
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
            cbFormaPago = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtMonto = new TextBox();
            btAceptar = new Button();
            btCancelar = new Button();
            label3 = new Label();
            txtNroFactura = new TextBox();
            SuspendLayout();
            // 
            // cbFormaPago
            // 
            cbFormaPago.FormattingEnabled = true;
            cbFormaPago.Location = new Point(139, 70);
            cbFormaPago.Name = "cbFormaPago";
            cbFormaPago.Size = new Size(121, 23);
            cbFormaPago.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 73);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 1;
            label1.Text = "Forma de pago";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 121);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Monto";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(139, 113);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 3;
            // 
            // btAceptar
            // 
            btAceptar.Location = new Point(78, 172);
            btAceptar.Name = "btAceptar";
            btAceptar.Size = new Size(75, 23);
            btAceptar.TabIndex = 4;
            btAceptar.Text = "Aceptar";
            btAceptar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(185, 172);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(75, 23);
            btCancelar.TabIndex = 5;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 28);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 6;
            label3.Text = "Nro de factura";
            // 
            // txtNroFactura
            // 
            txtNroFactura.Location = new Point(139, 25);
            txtNroFactura.Name = "txtNroFactura";
            txtNroFactura.Size = new Size(100, 23);
            txtNroFactura.TabIndex = 7;
            // 
            // RegistrarFormaPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 281);
            Controls.Add(txtNroFactura);
            Controls.Add(label3);
            Controls.Add(btCancelar);
            Controls.Add(btAceptar);
            Controls.Add(txtMonto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbFormaPago);
            Name = "RegistrarFormaPago";
            Text = "RegistrarFormaPago";
            Load += RegistrarFormaPago_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbFormaPago;
        private Label label1;
        private Label label2;
        private TextBox txtMonto;
        private Button btAceptar;
        private Button btCancelar;
        private Label label3;
        private TextBox txtNroFactura;
    }
}