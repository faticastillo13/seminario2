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

namespace seminario2.Interfases.VentanaSubcategoria
{
    public partial class ModificarSubcategoria : Form
    {
        SubcategoriaDAO subcategoriaDAO = new SubcategoriaDAO();
        CategoriaDAO categoriaDAO = new CategoriaDAO();
        Subcategoria subcategoria;
        int i = 0;
        public ModificarSubcategoria()
        {
            InitializeComponent();
        }

        private void CambiarItemsSeleccionados(string? categoria)
        {
            cbCategoria.Text = categoria;
        }
        private void LlenarControladores(object sender, DataGridViewCellEventArgs e)
        {
            int numeroFila = e.RowIndex;
            i = numeroFila;
            string categoria = dgSubcategorias.Rows[numeroFila].Cells[0].Value.ToString();
            CambiarItemsSeleccionados(categoria);
            txtId.Text = dgSubcategorias.Rows[numeroFila].Cells[1].Value.ToString();
            txtDescripcion.Text = dgSubcategorias.Rows[numeroFila].Cells[3].Value.ToString();
            txtSubcategoria.Text = dgSubcategorias.Rows[numeroFila].Cells[2].Value.ToString();
        }

        private void ModificarSubcategoria_Load(object sender, EventArgs e)
        {
            cbCategoria.DataSource = categoriaDAO.TraerTodos();
            cbCategoria.DisplayMember = "nombre";
            cbCategoria.ValueMember = "id_categoria";
            dgSubcategorias.DataSource = subcategoriaDAO.TraerInfo();

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

        private void btn_Click(object sender, EventArgs e)
        {
            string categoria;
            string nombre_subcategoria;
            int idsubcategoria;
            string descripcion;
            int idcategoria;
            int idcategoria_vieja;

            categoria = cbCategoria.SelectedText;
            nombre_subcategoria = txtSubcategoria.Text;
            idsubcategoria = Convert.ToInt32(txtId.Text);
            descripcion = txtDescripcion.Text;
            idcategoria = Convert.ToInt32(cbCategoria.SelectedValue);
            idcategoria_vieja = categoriaDAO.ObtenerID(dgSubcategorias.Rows[i].Cells[0].Value.ToString());
            Subcategoria subcategoria = subcategoriaDAO.TraerUno(idsubcategoria, idcategoria_vieja);
            subcategoria.SetNombre(nombre_subcategoria);
            subcategoria.SetDescripcion(descripcion);
            subcategoriaDAO.ModificarUno(subcategoria, idcategoria);
            MessageBox.Show("Modificacion exitosa");
            dgSubcategorias.DataSource = subcategoriaDAO.TraerInfo();

        }
    }
}
