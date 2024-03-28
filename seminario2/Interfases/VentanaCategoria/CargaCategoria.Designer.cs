namespace seminario2.Interfases
{
    partial class vtnCargarCategoria
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
            txtNombreCategoria = new TextBox();
            label2 = new Label();
            txtDescripcionCategoria = new RichTextBox();
            btnCargarCategoria = new Button();
            dgCategorias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgCategorias).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 55);
            label1.Name = "label1";
            label1.Size = new Size(182, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el nombre de la categoria";
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(322, 52);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(100, 23);
            txtNombreCategoria.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 117);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "Descripcion";
            // 
            // txtDescripcionCategoria
            // 
            txtDescripcionCategoria.Location = new Point(322, 117);
            txtDescripcionCategoria.Name = "txtDescripcionCategoria";
            txtDescripcionCategoria.Size = new Size(155, 96);
            txtDescripcionCategoria.TabIndex = 4;
            txtDescripcionCategoria.Text = "";
            // 
            // btnCargarCategoria
            // 
            btnCargarCategoria.Location = new Point(134, 314);
            btnCargarCategoria.Name = "btnCargarCategoria";
            btnCargarCategoria.Size = new Size(127, 23);
            btnCargarCategoria.TabIndex = 5;
            btnCargarCategoria.Text = "Cargar Categoria";
            btnCargarCategoria.UseVisualStyleBackColor = true;
            btnCargarCategoria.Click += btnCargarCategoria_Click;
            // 
            // dgCategorias
            // 
            dgCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCategorias.Location = new Point(322, 264);
            dgCategorias.Name = "dgCategorias";
            dgCategorias.RowTemplate.Height = 25;
            dgCategorias.Size = new Size(240, 150);
            dgCategorias.TabIndex = 6;
            // 
            // vtnCargarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(dgCategorias);
            Controls.Add(btnCargarCategoria);
            Controls.Add(txtDescripcionCategoria);
            Controls.Add(label2);
            Controls.Add(txtNombreCategoria);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "vtnCargarCategoria";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cargar Categoria";
            Load += btnCargarCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombreCategoria;
        private Label label2;
        private RichTextBox txtDescripcionCategoria;
        private Button btnCargarCategoria;
        private DataGridView dgCategorias;
    }
}