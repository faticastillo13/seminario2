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

namespace seminario2.Interfases.VentanaProducto
{
    public partial class BorrarProducto : Form
    {
        public BorrarProducto()
        {
            InitializeComponent();
        }




        private void BorrarProducto_Load(object sender, EventArgs e)
        {
            dgProductos.DataSource = ProductoDAO.TraerInfo();

        }

        private void dgProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numeroFila = e.RowIndex;
            txtId.Text = dgProductos.Rows[numeroFila].Cells[0].Value.ToString();
            txtNombre.Text = dgProductos.Rows[numeroFila].Cells[1].Value.ToString();
            rtDescripcion.Text = dgProductos.Rows[numeroFila].Cells[2].Value.ToString();
            txtPrecio.Text = dgProductos.Rows[numeroFila].Cells[3].Value.ToString();
            txtStock.Text = dgProductos.Rows[numeroFila].Cells[4].Value.ToString();
            txtCategoria.Text = dgProductos.Rows[numeroFila].Cells[5].Value.ToString();
            txtSubcategoria.Text = dgProductos.Rows[numeroFila].Cells[6].Value.ToString();

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                btnBorrar.Enabled = false;
            }
            else
            {
                btnBorrar.Enabled = true;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            ProductoDAO.BorrarUno(id);
            dgProductos.DataSource = ProductoDAO.TraerInfo();
        }


    }
}
