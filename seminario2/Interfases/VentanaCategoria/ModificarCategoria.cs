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

namespace seminario2.Interfases.Categoria
{
    public partial class ModificarCategoria : Form
    {
        CategoriaDAO categoriaDAO = new CategoriaDAO();

        seminario2.Clases_de_Entidad.Categoria categoria;
        public ModificarCategoria()
        {
            InitializeComponent();
        }

        private void ModificarCategoria_Load(object sender, EventArgs e)
        {
            RecargarTabla();
        }

        private void RecargarTabla()
        {
            dgCategorias.DataSource = categoriaDAO.TraerTodos();
        }

        private void LlenarControladores(object sender, DataGridViewCellEventArgs e)
        {
            int numeroFila = e.RowIndex;
            txtId.Text = dgCategorias.Rows[numeroFila].Cells[0].Value.ToString();
            txtCategoria.Text = dgCategorias.Rows[numeroFila].Cells[1].Value.ToString();
            txtDescripcion.Text = dgCategorias.Rows[numeroFila].Cells[2].Value.ToString();

            txtCategoria.Enabled = true;
            txtDescripcion.Enabled = true;

        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtCategoria.Text;
            string descripcion = txtDescripcion.Text;
            int id = Convert.ToInt32(txtId.Text);

            if (nombre == "" || descripcion == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }
            categoria = new seminario2.Clases_de_Entidad.Categoria(id, nombre, descripcion);
            categoriaDAO.ModificarUno(categoria);
            RecargarTabla();

        }
    }

}
