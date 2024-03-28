namespace seminario2.Interfases.VentanaFacturas
{
    partial class ConsultarFacturas
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
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            dgFacturas = new DataGridView();
            btBuscar = new Button();
            btConsultar = new Button();
            label3 = new Label();
            txtIdFactura = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgFacturas).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(66, 54);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(217, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(342, 54);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(212, 23);
            dateTimePicker2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 60);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Desde";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 60);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 3;
            label2.Text = "Hasta";
            // 
            // dgFacturas
            // 
            dgFacturas.AllowUserToAddRows = false;
            dgFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgFacturas.Location = new Point(12, 105);
            dgFacturas.Name = "dgFacturas";
            dgFacturas.RowTemplate.Height = 25;
            dgFacturas.Size = new Size(713, 340);
            dgFacturas.TabIndex = 4;
            dgFacturas.CellContentClick += dgFacturas_CellContentClick;
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(608, 12);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(75, 23);
            btBuscar.TabIndex = 5;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // btConsultar
            // 
            btConsultar.Location = new Point(607, 64);
            btConsultar.Name = "btConsultar";
            btConsultar.Size = new Size(75, 23);
            btConsultar.TabIndex = 6;
            btConsultar.Text = "Consultar";
            btConsultar.UseVisualStyleBackColor = true;
            btConsultar.Click += btConsultar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 17);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 7;
            label3.Text = "Id Factura";
            // 
            // txtIdFactura
            // 
            txtIdFactura.Location = new Point(100, 13);
            txtIdFactura.Name = "txtIdFactura";
            txtIdFactura.Size = new Size(100, 23);
            txtIdFactura.TabIndex = 8;
            // 
            // ConsultarFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(txtIdFactura);
            Controls.Add(label3);
            Controls.Add(btConsultar);
            Controls.Add(btBuscar);
            Controls.Add(dgFacturas);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConsultarFacturas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ConsultarFacturas";
            Load += ConsultarFacturas_Load;
            ((System.ComponentModel.ISupportInitialize)dgFacturas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private DataGridView dgFacturas;
        private Button btBuscar;
        private Button btConsultar;
        private Label label3;
        private TextBox txtIdFactura;
    }
}