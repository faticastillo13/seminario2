using seminario2.Acceso_a_Datos;
using seminario2.Clases_de_Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seminario2.Interfases.VentanaProducto
{
    public partial class vtnCargarProductos : Form
    {
        public vtnCargarProductos()
        {
            InitializeComponent();
        }

        private void vtnCargarProductos_Load(object sender, EventArgs e)
        {
            dgProductos.DataSource = ProductoDAO.TraerInfo();
            CategoriaDAO categoriaDAO = new CategoriaDAO();
            cbCategoria.DataSource = categoriaDAO.TraerTodos();
            cbCategoria.DisplayMember = "nombre";
            cbCategoria.ValueMember = "id_categoria";

        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

            SubcategoriaDAO subcategoriaDAO = new SubcategoriaDAO();

            try
            {
                int id = Convert.ToInt32(cbCategoria.SelectedValue.ToString());
                cbSubcategoria.DataSource = subcategoriaDAO.TraerDeCategoria(id);
                cbSubcategoria.DisplayMember = "nombre";
                cbSubcategoria.ValueMember = "id_subcategoria";
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string descripcion = rtDescripcion.Text;
            double precio = Convert.ToDouble(txtPrecio.Text);
            int stock = Convert.ToInt32(txtStock.Text);
            int idCategoria = Convert.ToInt32(cbCategoria.SelectedValue);
            int idSubcategoria = Convert.ToInt32(cbSubcategoria.SelectedValue);

            Producto producto = new Producto();
            producto.Set_Nombre(nombre);
            producto.Set_Descripcion(descripcion);
            producto.Set_Precio(precio);
            producto.Set_Stock(stock);
            producto.Set_IdCategoria(idCategoria);
            producto.Set_IdSubCategoria(idSubcategoria);
            ProductoDAO.InsertarUno(producto);
            LimpiarControladores();
            dgProductos.DataSource = ProductoDAO.TraerInfo();
        }

        private void LimpiarControladores()
        {
            txtNombre.Text = "";
            rtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            cbCategoria.SelectedIndex = 0;
            cbSubcategoria.SelectedIndex = 0;
        }

        private void dgProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
