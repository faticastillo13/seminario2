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
    public partial class CargarSubcategoria : Form
    {
        CategoriaDAO categoriaDAO = new CategoriaDAO();
        SubcategoriaDAO subcategoriaDAO = new SubcategoriaDAO();

        Clases_de_Entidad.Categoria categoria;
        Subcategoria subcategoria;

        public CargarSubcategoria()
        {
            InitializeComponent();
        }

        private void CargarSubcategoria_Load(object sender, EventArgs e)
        {
            LlenarComboBox();
            cbCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void LlenarComboBox()
        {
            cbCategorias.DataSource = categoriaDAO.TraerTodos();
            cbCategorias.DisplayMember = "nombre";
            cbCategorias.ValueMember = "id_categoria";
        }

        private void LlenarTabla()
        {
            dgSubcategorias.DataSource = subcategoriaDAO.TraerTodos();
        }



        private void btn_Click(object sender, EventArgs e)
        {
            if (txtSubcategoria.Text == "" || txtDescripcion.Text == "")
                return;

            CrearSubcategoria();
            LlenarTabla();
        }

        private void CrearSubcategoria()
        {
            int id = Convert.ToInt32(cbCategorias.SelectedValue);
            categoria = categoriaDAO.TraerUno(id);
            string nombre = txtSubcategoria.Text;
            string descripcion = txtDescripcion.Text;
            subcategoria = new Subcategoria(categoria, nombre, descripcion);
            subcategoriaDAO.InsertarUno(subcategoria);
            LimpiarControladores();
        }

        private void LimpiarControladores()
        {
            txtDescripcion.Text = "";
            txtSubcategoria.Text = "";
            cbCategorias.SelectedItem = null;
        }
    }
}
