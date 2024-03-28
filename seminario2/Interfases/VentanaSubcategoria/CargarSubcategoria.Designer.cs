namespace seminario2.Interfases.VentanaSubcategoria
{
    partial class CargarSubcategoria
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
            txtDescripcion = new RichTextBox();
            label3 = new Label();
            btn = new Button();
            txtSubcategoria = new TextBox();
            label2 = new Label();
            cbCategorias = new ComboBox();
            label1 = new Label();
            dgSubcategorias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgSubcategorias).BeginInit();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(363, 195);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(159, 96);
            txtDescripcion.TabIndex = 13;
            txtDescripcion.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(285, 213);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 12;
            label3.Text = "Descripcion:";
            // 
            // btn
            // 
            btn.Location = new Point(548, 231);
            btn.Name = "btn";
            btn.Size = new Size(75, 23);
            btn.TabIndex = 11;
            btn.Text = "Agregar";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // txtSubcategoria
            // 
            txtSubcategoria.Location = new Point(360, 154);
            txtSubcategoria.Name = "txtSubcategoria";
            txtSubcategoria.Size = new Size(162, 23);
            txtSubcategoria.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 154);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 9;
            label2.Text = "Subcategoria:";
            // 
            // cbCategorias
            // 
            cbCategorias.FormattingEnabled = true;
            cbCategorias.Location = new Point(359, 91);
            cbCategorias.Name = "cbCategorias";
            cbCategorias.Size = new Size(163, 23);
            cbCategorias.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 94);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 7;
            label1.Text = "Categoria";
            // 
            // dgSubcategorias
            // 
            dgSubcategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSubcategorias.Location = new Point(320, 330);
            dgSubcategorias.Name = "dgSubcategorias";
            dgSubcategorias.RowTemplate.Height = 25;
            dgSubcategorias.Size = new Size(370, 150);
            dgSubcategorias.TabIndex = 14;
            // 
            // CargarSubcategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 559);
            ControlBox = false;
            Controls.Add(dgSubcategorias);
            Controls.Add(txtDescripcion);
            Controls.Add(label3);
            Controls.Add(btn);
            Controls.Add(txtSubcategoria);
            Controls.Add(label2);
            Controls.Add(cbCategorias);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CargarSubcategoria";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CargarSubcategoria";
            Load += CargarSubcategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgSubcategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtDescripcion;
        private Label label3;
        private Button btn;
        private TextBox txtSubcategoria;
        private Label label2;
        private ComboBox cbCategorias;
        private Label label1;
        private DataGridView dgSubcategorias;
    }
}