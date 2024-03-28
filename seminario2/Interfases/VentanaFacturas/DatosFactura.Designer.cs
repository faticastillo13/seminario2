namespace seminario2.Interfases.VentanaFacturas
{
    partial class DatosFactura
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtFecha = new TextBox();
            label2 = new Label();
            txtMail = new TextBox();
            txtNroFactura = new TextBox();
            label7 = new Label();
            txtxDomicilio = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            label6 = new Label();
            label4 = new Label();
            btGuardar = new Button();
            btVolver = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtFecha);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMail);
            groupBox1.Controls.Add(txtNroFactura);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtxDomicilio);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtDNI);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(39, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(717, 187);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Factura";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(50, 25);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(152, 23);
            txtFecha.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 33);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Nro Factura";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(368, 141);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(280, 23);
            txtMail.TabIndex = 13;
            // 
            // txtNroFactura
            // 
            txtNroFactura.Location = new Point(321, 33);
            txtNroFactura.Name = "txtNroFactura";
            txtNroFactura.Size = new Size(100, 23);
            txtNroFactura.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(332, 144);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 8;
            label7.Text = "Mail";
            // 
            // txtxDomicilio
            // 
            txtxDomicilio.Location = new Point(70, 136);
            txtxDomicilio.Name = "txtxDomicilio";
            txtxDomicilio.Size = new Size(217, 23);
            txtxDomicilio.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 80);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(549, 87);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(156, 23);
            txtTelefono.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 139);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 6;
            label5.Text = "Domicilio";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(63, 77);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(214, 23);
            txtNombre.TabIndex = 9;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(332, 82);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(132, 23);
            txtDNI.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(491, 90);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 7;
            label6.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(299, 85);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 5;
            label4.Text = "DNI";
            // 
            // btGuardar
            // 
            btGuardar.Location = new Point(260, 275);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(75, 23);
            btGuardar.TabIndex = 18;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // btVolver
            // 
            btVolver.Location = new Point(385, 275);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(75, 23);
            btVolver.TabIndex = 19;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = true;
            btVolver.Click += btVolver_Click;
            // 
            // DatosFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btVolver);
            Controls.Add(btGuardar);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DatosFactura";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DatosFactura";
            Load += DatosFactura_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMail;
        private Label label7;
        private TextBox txtxDomicilio;
        private Label label3;
        private TextBox txtTelefono;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private Label label6;
        private Label label4;
        private Label label1;
        private TextBox txtFecha;
        private Label label2;
        private TextBox txtNroFactura;
        private Button btGuardar;
        private Button btVolver;
    }
}