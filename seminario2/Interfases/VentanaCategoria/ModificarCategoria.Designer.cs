namespace seminario2.Interfases.Categoria
{
    partial class ModificarCategoria
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
            label3 = new Label();
            dgCategorias = new DataGridView();
            btModificar = new Button();
            txtDescripcion = new RichTextBox();
            txtCategoria = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgCategorias).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(347, 37);
            txtId.Name = "txtId";
            txtId.Size = new Size(72, 23);
            txtId.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 38);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 14;
            label3.Text = "ID";
            // 
            // dgCategorias
            // 
            dgCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCategorias.Location = new Point(333, 263);
            dgCategorias.Name = "dgCategorias";
            dgCategorias.RowTemplate.Height = 25;
            dgCategorias.Size = new Size(240, 150);
            dgCategorias.TabIndex = 13;
            dgCategorias.CellDoubleClick += LlenarControladores;
            // 
            // btModificar
            // 
            btModificar.Location = new Point(227, 306);
            btModificar.Name = "btModificar";
            btModificar.Size = new Size(75, 23);
            btModificar.TabIndex = 12;
            btModificar.Text = "Modificar";
            btModificar.UseVisualStyleBackColor = true;
            btModificar.Click += btModificar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new Point(343, 133);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(133, 96);
            txtDescripcion.TabIndex = 11;
            txtDescripcion.Text = "";
            // 
            // txtCategoria
            // 
            txtCategoria.Enabled = false;
            txtCategoria.Location = new Point(343, 79);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(133, 23);
            txtCategoria.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 155);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 9;
            label2.Text = "Descripcion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 78);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 8;
            label1.Text = "Categoria";
            // 
            // ModificarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(dgCategorias);
            Controls.Add(btModificar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtCategoria);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ModificarCategoria";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ModificarCategoria";
            Load += ModificarCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label3;
        private DataGridView dgCategorias;
        private Button btModificar;
        private RichTextBox txtDescripcion;
        private TextBox txtCategoria;
        private Label label2;
        private Label label1;
    }
}