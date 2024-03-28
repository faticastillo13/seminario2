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
    public partial class VentanaGenericaSubcategoria : Form
    {
        CategoriaDAO categoriaDAO = new CategoriaDAO();
        SubcategoriaDAO subcategoriaDAO = new SubcategoriaDAO();
        public VentanaGenericaSubcategoria()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        //metodo
        private void LlenarComboBox()
        {
            cbCategorias.DataSource = categoriaDAO.TraerTodos();
            cbCategorias.DisplayMember = "nombre";
            cbCategorias.ValueMember = "id_categoria";
        }

        private void Agregar_Subcategoria_Load(object sender, EventArgs e)
        {
            cbCategorias.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
