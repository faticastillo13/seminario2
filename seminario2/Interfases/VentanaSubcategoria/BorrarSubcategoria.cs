using seminario2.Acceso_a_Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seminario2.Interfases.VentanaSubcategoria
{
    public partial class BorrarSubcategoria : Form
    {
        SubcategoriaDAO subcategoriaDAO = new SubcategoriaDAO();
        CategoriaDAO categoriaDAO = new CategoriaDAO();
        public BorrarSubcategoria()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LlenarControladores(object sender, DataGridViewCellEventArgs e)
        {
            int numeroFila = e.RowIndex;
            string categoria = dgSubcategorias.Rows[numeroFila].Cells[0].Value.ToString();
            CambiarItemsSeleccionados(categoria);
            txtId.Text = dgSubcategorias.Rows[numeroFila].Cells[1].Value.ToString();
            txtDescripcion.Text = dgSubcategorias.Rows[numeroFila].Cells[3].Value.ToString();
            txtSubcategoria.Text = dgSubcategorias.Rows[numeroFila].Cells[2].Value.ToString();
        }

        private void CambiarItemsSeleccionados(string? categoria)
        {
            cbCategoria.Text = categoria;
        }

        private void BorrarSubcategoria_Load(object sender, EventArgs e)
        {
            dgSubcategorias.DataSource = subcategoriaDAO.TraerInfo();
            cbCategoria.DataSource = categoriaDAO.TraerTodos();
            cbCategoria.ValueMember = "id_categoria";
            cbCategoria.DisplayMember = "nombre";

        }

        private void btn_Click(object sender, EventArgs e)
        {
            int id_subcategoria;
            int id_categoria;

            id_subcategoria = Convert.ToInt32(txtId.Text);
            id_categoria = Convert.ToInt32(cbCategoria.SelectedValue);

            subcategoriaDAO.BorrarUno(id_subcategoria, id_categoria);
            MessageBox.Show("Eliminacion Exitosa");
            dgSubcategorias.DataSource = subcategoriaDAO.TraerInfo();
            LimpiarControladores();

        }

        private void LimpiarControladores()
        {
            txtId.Text = "";
            txtSubcategoria.Text = "";
            txtDescripcion.Text = "";
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                btn.Enabled = false;
            }
            else
            {
                btn.Enabled = true;
            }
        }
    }
}
