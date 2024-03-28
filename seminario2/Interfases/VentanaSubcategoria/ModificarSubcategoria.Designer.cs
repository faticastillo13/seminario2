namespace seminario2.Interfases.VentanaSubcategoria
{
    partial class ModificarSubcategoria
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
            cbCategoria = new ComboBox();
            label4 = new Label();
            txtId = new TextBox();
            dgSubcategorias = new DataGridView();
            txtDescripcion = new RichTextBox();
            label3 = new Label();
            btn = new Button();
            txtSubcategoria = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgSubcategorias).BeginInit();
            SuspendLayout();
            // 
            // cbCategoria
            // 
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(301, 28);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(137, 23);
            cbCategoria.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(206, 76);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 35;
            label4.Text = "Id Subcategoria";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(301, 73);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(137, 23);
            txtId.TabIndex = 34;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // dgSubcategorias
            // 
            dgSubcategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSubcategorias.Location = new Point(224, 273);
            dgSubcategorias.Name = "dgSubcategorias";
            dgSubcategorias.RowTemplate.Height = 25;
            dgSubcategorias.Size = new Size(370, 150);
            dgSubcategorias.TabIndex = 33;
            dgSubcategorias.CellContentDoubleClick += LlenarControladores;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(304, 158);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(159, 96);
            txtDescripcion.TabIndex = 32;
            txtDescripcion.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 158);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 31;
            label3.Text = "Descripcion:";
            // 
            // btn
            // 
            btn.Enabled = false;
            btn.Location = new Point(487, 176);
            btn.Name = "btn";
            btn.Size = new Size(75, 23);
            btn.TabIndex = 30;
            btn.Text = "Modificar";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // txtSubcategoria
            // 
            txtSubcategoria.Location = new Point(301, 115);
            txtSubcategoria.Name = "txtSubcategoria";
            txtSubcategoria.Size = new Size(137, 23);
            txtSubcategoria.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 118);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 28;
            label2.Text = "Subcategoria:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(216, 28);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 27;
            label1.Text = "Categoria";
            // 
            // ModificarSubcategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(cbCategoria);
            Controls.Add(label4);
            Controls.Add(txtId);
            Controls.Add(dgSubcategorias);
            Controls.Add(txtDescripcion);
            Controls.Add(label3);
            Controls.Add(btn);
            Controls.Add(txtSubcategoria);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ModificarSubcategoria";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ModificarSubcategoria";
            Load += ModificarSubcategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgSubcategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbCategoria;
        private Label label4;
        private TextBox txtId;
        private DataGridView dgSubcategorias;
        private RichTextBox txtDescripcion;
        private Label label3;
        private Button btn;
        private TextBox txtSubcategoria;
        private Label label2;
        private Label label1;
    }
}