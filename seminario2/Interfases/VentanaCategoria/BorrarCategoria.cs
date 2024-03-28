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

namespace seminario2.Interfases
{
    public partial class BorrarCategoria : Form
    {
        CategoriaDAO categoriaDAO = new CategoriaDAO();
        public BorrarCategoria()
        {
            InitializeComponent();
        }

        private void BorrarCategoria_Load(object sender, EventArgs e)
        {
            dgCategorias.DataSource = categoriaDAO.TraerTodos();
        }
        private void RecargarTabla()
        {
            dgCategorias.DataSource = categoriaDAO.TraerTodos();
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            //recuperar id de la categoria a borrar
            int id = Convert.ToInt32(txtId.Text);
            string nombre = txtCategoria.Text;
            DialogResult decision = MessageBox.Show("Desea eliminar la categoria " + nombre, "Eliminar categoria", MessageBoxButtons.YesNo);
            if (decision == DialogResult.Yes)
            {
                categoriaDAO.EliminarUno(id);
                RecargarTabla();
            }
        }

        private void LlenarControladores(object sender, DataGridViewCellEventArgs e)
        {
            int numeroFila = e.RowIndex;
            txtId.Text = dgCategorias.Rows[numeroFila].Cells[0].Value.ToString();
            txtCategoria.Text = dgCategorias.Rows[numeroFila].Cells[1].Value.ToString();
            txtDescripcion.Text = dgCategorias.Rows[numeroFila].Cells[2].Value.ToString();

        }
    }
}
