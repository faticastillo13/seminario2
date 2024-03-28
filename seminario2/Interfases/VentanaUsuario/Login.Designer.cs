namespace seminario2.Interfases.VentanaUsuario
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnAceptar = new Button();
            btnVerContraseña = new Button();
            lbError = new Label();
            reloj = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 54);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 104);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(114, 54);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingrese el usuario";
            txtUsuario.Size = new Size(129, 23);
            txtUsuario.TabIndex = 2;
            txtUsuario.KeyPress += txtUsuario_KeyPress;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(114, 105);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.PlaceholderText = "Ingrese la contraseña";
            txtContraseña.Size = new Size(129, 23);
            txtContraseña.TabIndex = 3;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(131, 160);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnVerContraseña
            // 
            btnVerContraseña.Location = new Point(254, 105);
            btnVerContraseña.Name = "btnVerContraseña";
            btnVerContraseña.Size = new Size(75, 23);
            btnVerContraseña.TabIndex = 5;
            btnVerContraseña.Text = "Ver";
            btnVerContraseña.UseVisualStyleBackColor = true;
            btnVerContraseña.Click += btnVerContraseña_Click;
            // 
            // lbError
            // 
            lbError.AutoSize = true;
            lbError.ForeColor = Color.Red;
            lbError.Location = new Point(84, 19);
            lbError.Name = "lbError";
            lbError.Size = new Size(185, 15);
            lbError.TabIndex = 6;
            lbError.Text = "Error en el usuario o la contraseña";
            lbError.Visible = false;
            // 
            // reloj
            // 
            reloj.Tick += reloj_Tick;
            reloj.Disposed += (sender, e) =>
            {
                btnAceptar.Enabled = true;
            };
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 250);
            Controls.Add(lbError);
            Controls.Add(btnVerContraseña);
            Controls.Add(btnAceptar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            KeyPress += Login_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnAceptar;
        private Button btnVerContraseña;
        private Label lbError;
        private System.Windows.Forms.Timer reloj;
    }
}