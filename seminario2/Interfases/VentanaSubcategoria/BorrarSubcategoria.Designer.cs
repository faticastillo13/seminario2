namespace seminario2.Interfases.VentanaSubcategoria
{
    partial class BorrarSubcategoria
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
            dgSubcategorias = new DataGridView();
            txtDescripcion = new RichTextBox();
            label3 = new Label();
            btn = new Button();
            txtSubcategoria = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtId = new TextBox();
            label4 = new Label();
            cbCategoria = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgSubcategorias).BeginInit();
            SuspendLayout();
            // 
            // dgSubcategorias
            // 
            dgSubcategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSubcategorias.Location = new Point(201, 268);
            dgSubcategorias.Name = "dgSubcategorias";
            dgSubcategorias.RowTemplate.Height = 25;
            dgSubcategorias.Size = new Size(370, 150);
            dgSubcategorias.TabIndex = 22;
            dgSubcategorias.CellContentDoubleClick += LlenarControladores;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(281, 153);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ReadOnly = true;
            txtDescripcion.Size = new Size(159, 96);
            txtDescripcion.TabIndex = 21;
            txtDescripcion.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 153);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 20;
            label3.Text = "Descripcion:";
            // 
            // btn
            // 
            btn.Enabled = false;
            btn.Location = new Point(464, 171);
            btn.Name = "btn";
            btn.Size = new Size(75, 23);
            btn.TabIndex = 19;
            btn.Text = "Borrar";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // txtSubcategoria
            // 
            txtSubcategoria.Location = new Point(278, 110);
            txtSubcategoria.Name = "txtSubcategoria";
            txtSubcategoria.ReadOnly = true;
            txtSubcategoria.Size = new Size(137, 23);
            txtSubcategoria.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 113);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 17;
            label2.Text = "Subcategoria:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 23);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 15;
            label1.Text = "Categoria";
            // 
            // txtId
            // 
            txtId.Location = new Point(278, 68);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(137, 23);
            txtId.TabIndex = 24;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(183, 71);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 25;
            label4.Text = "Id Subcategoria";
            // 
            // cbCategoria
            // 
            cbCategoria.Enabled = false;
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(278, 23);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(137, 23);
            cbCategoria.TabIndex = 26;
            // 
            // BorrarSubcategoria
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
            Name = "BorrarSubcategoria";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BorrarSubcategoria";
            Load += BorrarSubcategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgSubcategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgSubcategorias;
        private RichTextBox txtDescripcion;
        private Label label3;
        private Button btn;
        private TextBox txtSubcategoria;
        private Label label2;
        private Label label1;
        private TextBox txtId;
        private Label label4;
        private ComboBox cbCategoria;
    }
}