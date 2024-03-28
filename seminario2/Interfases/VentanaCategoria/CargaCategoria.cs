using seminario2.Acceso_a_Datos;
using seminario2.Clases_de_Entidad;
using System;
using System.Collections;
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
    public partial class vtnCargarCategoria : Form
    {
        ArrayList categorias = new ArrayList();
        seminario2.Clases_de_Entidad.Categoria categoria;
        CategoriaDAO categoriaDAO = new CategoriaDAO();
        public vtnCargarCategoria()
        {
            InitializeComponent();
        }

        private void btnCargarCategoria_Load(object sender, EventArgs e)
        {
            dgCategorias.DataSource = categoriaDAO.TraerTodos();
        }
        private void RecargarTabla()
        {
            dgCategorias.DataSource = categoriaDAO.TraerTodos();
        }

        private void btnCargarCategoria_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreCategoria.Text;
            string descripcion = txtDescripcionCategoria.Text;

            if (nombre == "" || descripcion == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }
            categoria = new seminario2.Clases_de_Entidad.Categoria(1, nombre, descripcion);
            categoriaDAO.InsertarUno(categoria);
            RecargarTabla();
            MessageBox.Show("Carga Exitosa");


        }
    }
}
