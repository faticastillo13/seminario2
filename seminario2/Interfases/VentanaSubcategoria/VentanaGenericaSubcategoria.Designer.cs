namespace seminario2.Interfases.VentanaSubcategoria
{
    partial class VentanaGenericaSubcategoria
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
            cbCategorias = new ComboBox();
            label2 = new Label();
            txtSubcategoria = new TextBox();
            btn = new Button();
            label3 = new Label();
            txtDescripcion = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 53);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Categoria";
            // 
            // cbCategorias
            // 
            cbCategorias.FormattingEnabled = true;
            cbCategorias.Location = new Point(177, 50);
            cbCategorias.Name = "cbCategorias";
            cbCategorias.Size = new Size(163, 23);
            cbCategorias.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 113);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 2;
            label2.Text = "Subcategoria:";
            label2.Click += label2_Click;
            // 
            // txtSubcategoria
            // 
            txtSubcategoria.Location = new Point(178, 113);
            txtSubcategoria.Name = "txtSubcategoria";
            txtSubcategoria.Size = new Size(162, 23);
            txtSubcategoria.TabIndex = 3;
            // 
            // btn
            // 
            btn.Location = new Point(226, 295);
            btn.Name = "btn";
            btn.Size = new Size(75, 23);
            btn.TabIndex = 4;
            btn.Text = "Agregar";
            btn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 172);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 5;
            label3.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(181, 154);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(159, 96);
            txtDescripcion.TabIndex = 6;
            txtDescripcion.Text = "";
            // 
            // VentanaGenericaSubcategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDescripcion);
            Controls.Add(label3);
            Controls.Add(btn);
            Controls.Add(txtSubcategoria);
            Controls.Add(label2);
            Controls.Add(cbCategorias);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VentanaGenericaSubcategoria";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ventana";
            Load += Agregar_Subcategoria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbCategorias;
        private Label label2;
        private TextBox txtSubcategoria;
        private Button btn;
        private Label label3;
        private RichTextBox txtDescripcion;
    }
}