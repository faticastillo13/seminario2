using seminario2.Interfases;
using seminario2.Interfases.Categoria;
using seminario2.Interfases.VentanaFacturas;
using seminario2.Interfases.VentanaProducto;
using seminario2.Interfases.VentanaSubcategoria;
using seminario2.Interfases.VentanaUsuario;

namespace seminario2
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }



        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            fh.StartPosition = FormStartPosition.CenterParent;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }



        private void crearCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new vtnCargarCategoria());
        }

        private void borrarCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new BorrarCategoria());
        }

        private void modificarCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ModificarCategoria());
        }

        private void crearSubcategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new CargarSubcategoria());
        }

        private void eliminarSubcategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new BorrarSubcategoria());
        }

        private void modificarSubcategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ModificarSubcategoria());
        }

        private void cargarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new vtnCargarProductos());
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new BorrarProducto());
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ModificarProducto());
        }

        private void habilitarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ActivarProducto());
        }

        private void consultarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ConsultarProducto());

        }

        private void crearFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new CargarFactura());

        }

        private void consultarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ConsultarFacturas());

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            AbrirFormHija(new Comienzo());
        }
    }
}

