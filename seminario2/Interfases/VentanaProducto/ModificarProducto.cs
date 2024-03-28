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
    public partial class ModificarProducto : Form
    {
        Producto producto = new Producto();
        public ModificarProducto()
        {
            InitializeComponent();
        }

        private void ModificarProducto_Load(object sender, EventArgs e)
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

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                btModificar.Enabled = false;
            }
            else
            {
                btModificar.Enabled = true;
            }
        }

        private void dgProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numeroFila = e.RowIndex;
            txtId.Text = dgProductos.Rows[numeroFila].Cells[0].Value.ToString();
            producto = ProductoDAO.TraerUno(Convert.ToInt32(txtId.Text));
            txtNombre.Text = dgProductos.Rows[numeroFila].Cells[1].Value.ToString();
            rtDescripcion.Text = dgProductos.Rows[numeroFila].Cells[2].Value.ToString();
            txtPrecio.Text = dgProductos.Rows[numeroFila].Cells[3].Value.ToString();
            txtStock.Text = dgProductos.Rows[numeroFila].Cells[4].Value.ToString();
            cbCategoria.Text = dgProductos.Rows[numeroFila].Cells[5].Value.ToString();
            cbSubcategoria.Text = dgProductos.Rows[numeroFila].Cells[6].Value.ToString();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string descripcion = rtDescripcion.Text;
            double precio = Convert.ToDouble(txtPrecio.Text);
            int stock = Convert.ToInt32(txtStock.Text);
            int categoria = Convert.ToInt32(cbCategoria.SelectedValue);
            int subcategoria = Convert.ToInt32(cbSubcategoria.SelectedValue);

            producto.Set_Nombre(nombre);
            producto.Set_Descripcion(descripcion);
            producto.Set_Precio(precio);
            producto.Set_Stock(stock);
            producto.Set_IdCategoria(categoria);
            producto.Set_IdSubCategoria(subcategoria);

            ProductoDAO.ModificarUno(producto);
            dgProductos.DataSource = ProductoDAO.TraerInfo();
        }
    }


}
