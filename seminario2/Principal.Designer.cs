namespace seminario2
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cToolStripMenuItem = new ToolStripMenuItem();
            crearCategoríaToolStripMenuItem = new ToolStripMenuItem();
            borrarCategoríaToolStripMenuItem = new ToolStripMenuItem();
            modificarCategoríaToolStripMenuItem = new ToolStripMenuItem();
            subcategoríasToolStripMenuItem = new ToolStripMenuItem();
            crearSubcategoríaToolStripMenuItem = new ToolStripMenuItem();
            eliminarSubcategoríaToolStripMenuItem = new ToolStripMenuItem();
            modificarSubcategoríaToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            cargarProductoToolStripMenuItem = new ToolStripMenuItem();
            eliminarProductoToolStripMenuItem = new ToolStripMenuItem();
            modificarProductoToolStripMenuItem = new ToolStripMenuItem();
            habilitarProductoToolStripMenuItem = new ToolStripMenuItem();
            consultarProductoToolStripMenuItem = new ToolStripMenuItem();
            facturasToolStripMenuItem = new ToolStripMenuItem();
            crearFacturaToolStripMenuItem = new ToolStripMenuItem();
            consultarFacturaToolStripMenuItem = new ToolStripMenuItem();
            panelContenedor = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cToolStripMenuItem, subcategoríasToolStripMenuItem, productosToolStripMenuItem, facturasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(833, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // cToolStripMenuItem
            // 
            cToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearCategoríaToolStripMenuItem, borrarCategoríaToolStripMenuItem, modificarCategoríaToolStripMenuItem });
            cToolStripMenuItem.Name = "cToolStripMenuItem";
            cToolStripMenuItem.Size = new Size(75, 20);
            cToolStripMenuItem.Text = "Categorías";
            // 
            // crearCategoríaToolStripMenuItem
            // 
            crearCategoríaToolStripMenuItem.Name = "crearCategoríaToolStripMenuItem";
            crearCategoríaToolStripMenuItem.Size = new Size(179, 22);
            crearCategoríaToolStripMenuItem.Text = "Crear Categoría";
            crearCategoríaToolStripMenuItem.Click += crearCategoríaToolStripMenuItem_Click;
            // 
            // borrarCategoríaToolStripMenuItem
            // 
            borrarCategoríaToolStripMenuItem.Name = "borrarCategoríaToolStripMenuItem";
            borrarCategoríaToolStripMenuItem.Size = new Size(179, 22);
            borrarCategoríaToolStripMenuItem.Text = "Eliminar Categoría";
            borrarCategoríaToolStripMenuItem.Click += borrarCategoríaToolStripMenuItem_Click;
            // 
            // modificarCategoríaToolStripMenuItem
            // 
            modificarCategoríaToolStripMenuItem.Name = "modificarCategoríaToolStripMenuItem";
            modificarCategoríaToolStripMenuItem.Size = new Size(179, 22);
            modificarCategoríaToolStripMenuItem.Text = "Modificar Categoría";
            modificarCategoríaToolStripMenuItem.Click += modificarCategoríaToolStripMenuItem_Click;
            // 
            // subcategoríasToolStripMenuItem
            // 
            subcategoríasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearSubcategoríaToolStripMenuItem, eliminarSubcategoríaToolStripMenuItem, modificarSubcategoríaToolStripMenuItem });
            subcategoríasToolStripMenuItem.Name = "subcategoríasToolStripMenuItem";
            subcategoríasToolStripMenuItem.Size = new Size(93, 20);
            subcategoríasToolStripMenuItem.Text = "Subcategorías";
            // 
            // crearSubcategoríaToolStripMenuItem
            // 
            crearSubcategoríaToolStripMenuItem.Name = "crearSubcategoríaToolStripMenuItem";
            crearSubcategoríaToolStripMenuItem.Size = new Size(197, 22);
            crearSubcategoríaToolStripMenuItem.Text = "Crear Subcategoría";
            crearSubcategoríaToolStripMenuItem.Click += crearSubcategoríaToolStripMenuItem_Click;
            // 
            // eliminarSubcategoríaToolStripMenuItem
            // 
            eliminarSubcategoríaToolStripMenuItem.Name = "eliminarSubcategoríaToolStripMenuItem";
            eliminarSubcategoríaToolStripMenuItem.Size = new Size(197, 22);
            eliminarSubcategoríaToolStripMenuItem.Text = "Eliminar Subcategoría";
            eliminarSubcategoríaToolStripMenuItem.Click += eliminarSubcategoríaToolStripMenuItem_Click;
            // 
            // modificarSubcategoríaToolStripMenuItem
            // 
            modificarSubcategoríaToolStripMenuItem.Name = "modificarSubcategoríaToolStripMenuItem";
            modificarSubcategoríaToolStripMenuItem.Size = new Size(197, 22);
            modificarSubcategoríaToolStripMenuItem.Text = "Modificar Subcategoría";
            modificarSubcategoríaToolStripMenuItem.Click += modificarSubcategoríaToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cargarProductoToolStripMenuItem, eliminarProductoToolStripMenuItem, modificarProductoToolStripMenuItem, habilitarProductoToolStripMenuItem, consultarProductoToolStripMenuItem });
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(73, 20);
            productosToolStripMenuItem.Text = "Productos";
            // 
            // cargarProductoToolStripMenuItem
            // 
            cargarProductoToolStripMenuItem.Name = "cargarProductoToolStripMenuItem";
            cargarProductoToolStripMenuItem.Size = new Size(177, 22);
            cargarProductoToolStripMenuItem.Text = "Cargar Producto";
            cargarProductoToolStripMenuItem.Click += cargarProductoToolStripMenuItem_Click;
            // 
            // eliminarProductoToolStripMenuItem
            // 
            eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            eliminarProductoToolStripMenuItem.Size = new Size(177, 22);
            eliminarProductoToolStripMenuItem.Text = "Eliminar Producto";
            eliminarProductoToolStripMenuItem.Click += eliminarProductoToolStripMenuItem_Click;
            // 
            // modificarProductoToolStripMenuItem
            // 
            modificarProductoToolStripMenuItem.Name = "modificarProductoToolStripMenuItem";
            modificarProductoToolStripMenuItem.Size = new Size(177, 22);
            modificarProductoToolStripMenuItem.Text = "Modificar Producto";
            modificarProductoToolStripMenuItem.Click += modificarProductoToolStripMenuItem_Click;
            // 
            // habilitarProductoToolStripMenuItem
            // 
            habilitarProductoToolStripMenuItem.Name = "habilitarProductoToolStripMenuItem";
            habilitarProductoToolStripMenuItem.Size = new Size(177, 22);
            habilitarProductoToolStripMenuItem.Text = "Habilitar Producto";
            habilitarProductoToolStripMenuItem.Click += habilitarProductoToolStripMenuItem_Click;
            // 
            // consultarProductoToolStripMenuItem
            // 
            consultarProductoToolStripMenuItem.Name = "consultarProductoToolStripMenuItem";
            consultarProductoToolStripMenuItem.Size = new Size(177, 22);
            consultarProductoToolStripMenuItem.Text = "Consultar Producto";
            consultarProductoToolStripMenuItem.Click += consultarProductoToolStripMenuItem_Click;
            // 
            // facturasToolStripMenuItem
            // 
            facturasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearFacturaToolStripMenuItem, consultarFacturaToolStripMenuItem });
            facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            facturasToolStripMenuItem.Size = new Size(63, 20);
            facturasToolStripMenuItem.Text = "Facturas";
            // 
            // crearFacturaToolStripMenuItem
            // 
            crearFacturaToolStripMenuItem.Name = "crearFacturaToolStripMenuItem";
            crearFacturaToolStripMenuItem.Size = new Size(167, 22);
            crearFacturaToolStripMenuItem.Text = "Crear Factura";
            crearFacturaToolStripMenuItem.Click += crearFacturaToolStripMenuItem_Click;
            // 
            // consultarFacturaToolStripMenuItem
            // 
            consultarFacturaToolStripMenuItem.Name = "consultarFacturaToolStripMenuItem";
            consultarFacturaToolStripMenuItem.Size = new Size(167, 22);
            consultarFacturaToolStripMenuItem.Text = "Consultar Factura";
            consultarFacturaToolStripMenuItem.Click += consultarFacturaToolStripMenuItem_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContenedor.Location = new Point(0, 27);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(833, 423);
            panelContenedor.TabIndex = 7;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 450);
            Controls.Add(panelContenedor);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Principal";
            Text = "Menu Principal";
            WindowState = FormWindowState.Maximized;
            Load += Principal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cToolStripMenuItem;
        private ToolStripMenuItem crearCategoríaToolStripMenuItem;
        private ToolStripMenuItem borrarCategoríaToolStripMenuItem;
        private ToolStripMenuItem modificarCategoríaToolStripMenuItem;
        private ToolStripMenuItem subcategoríasToolStripMenuItem;
        private ToolStripMenuItem crearSubcategoríaToolStripMenuItem;
        private ToolStripMenuItem eliminarSubcategoríaToolStripMenuItem;
        private ToolStripMenuItem modificarSubcategoríaToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem cargarProductoToolStripMenuItem;
        private ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private ToolStripMenuItem modificarProductoToolStripMenuItem;
        private ToolStripMenuItem habilitarProductoToolStripMenuItem;
        private ToolStripMenuItem consultarProductoToolStripMenuItem;
        private ToolStripMenuItem facturasToolStripMenuItem;
        private ToolStripMenuItem crearFacturaToolStripMenuItem;
        private ToolStripMenuItem consultarFacturaToolStripMenuItem;
        private Panel panelContenedor;
    }
}