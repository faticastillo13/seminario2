namespace seminario2.Interfases
{
    partial class BorrarCategoria
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
            txtCategoria = new TextBox();
            txtDescripcion = new RichTextBox();
            btBorrar = new Button();
            dgCategorias = new DataGridView();
            label3 = new Label();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgCategorias).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 64);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 141);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Descripcion";
            // 
            // txtCategoria
            // 
            txtCategoria.Enabled = false;
            txtCategoria.Location = new Point(225, 65);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(133, 23);
            txtCategoria.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new Point(225, 119);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(133, 96);
            txtDescripcion.TabIndex = 3;
            txtDescripcion.Text = "";
            // 
            // btBorrar
            // 
            btBorrar.Location = new Point(109, 292);
            btBorrar.Name = "btBorrar";
            btBorrar.Size = new Size(75, 23);
            btBorrar.TabIndex = 4;
            btBorrar.Text = "Borrar";
            btBorrar.UseVisualStyleBackColor = true;
            btBorrar.Click += btBorrar_Click;
            // 
            // dgCategorias
            // 
            dgCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCategorias.Location = new Point(215, 249);
            dgCategorias.Name = "dgCategorias";
            dgCategorias.RowTemplate.Height = 25;
            dgCategorias.Size = new Size(240, 150);
            dgCategorias.TabIndex = 5;
            dgCategorias.CellDoubleClick += LlenarControladores;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 24);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 6;
            label3.Text = "ID";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(229, 23);
            txtId.Name = "txtId";
            txtId.Size = new Size(72, 23);
            txtId.TabIndex = 7;
            // 
            // BorrarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(dgCategorias);
            Controls.Add(btBorrar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtCategoria);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BorrarCategoria";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BorrarCategoria";
            Load += BorrarCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCategoria;
        private RichTextBox txtDescripcion;
        private Button btBorrar;
        private DataGridView dgCategorias;
        private Label label3;
        private TextBox txtId;
    }
}