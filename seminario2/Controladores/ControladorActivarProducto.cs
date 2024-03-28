using seminario2.Acceso_a_Datos;
using seminario2.Interfases.VentanaProducto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminario2.Controladores
{
    internal class ControladorActivarProducto
    {
        int nroFila;
        ActivarProducto ventana;
        string nombreProducto;
        int id;

        public ControladorActivarProducto(ActivarProducto ventana)
        {
            this.ventana = ventana;
            ventana.dgProductos.CellContentDoubleClick += SeleccionarProducto;

            ventana.btActivar.Click += ActivarProducto;
            ventana.btEliminar.Click += EliminarProducto;
        }
        

        public void LlenarGrilla()
        {
            ventana.dgProductos.DataSource = ProductoDAO.TraerInactivos();
           
        }

        private void SeleccionarProducto(object sender, DataGridViewCellEventArgs e)
        {
            nroFila = e.RowIndex;

            ventana.txtId.Text = ventana.dgProductos.Rows[nroFila].Cells[0].Value.ToString();
            ventana.txtCategoria.Text = ventana.dgProductos.Rows[nroFila].Cells[1].Value.ToString();
            ventana.txtSubcategoria.Text = ventana.dgProductos.Rows[nroFila].Cells[2].Value.ToString();
            ventana.txtNombre.Text = ventana.dgProductos.Rows[nroFila].Cells[3].Value.ToString();
            ventana.rtDescripcion.Text = ventana.dgProductos.Rows[nroFila].Cells[4].Value.ToString();
            ventana.txtPrecio.Text = ventana.dgProductos.Rows[nroFila].Cells[5].Value.ToString();

        }

        private void ActivarProducto(object sender, EventArgs e)
        {
            id = Convert.ToInt32(ventana.txtId.Text);
            if (ventana.ConfirmarActivacion(nombreProducto = ventana.txtNombre.Text))
            {
                ProductoDAO.ActivarProducto(id);
                MessageBox.Show("La activación del producto fue correcta");
                ventana.dgProductos.Rows.RemoveAt(nroFila);
                LimpiarControladores();
            }
            
        } 

        private void EliminarProducto(object sender, EventArgs e)
        {
            id = Convert.ToInt32(ventana.txtId.Text);
            if (ventana.ConfirmarEliminacion(nombreProducto = ventana.txtNombre.Text))
            {
                if (ProductoDAO.EliminarProducto(id))
                {
                    MessageBox.Show("La eliminación del producto fue correcta");
                    ventana.dgProductos.Rows.RemoveAt(nroFila);
                    LimpiarControladores();
                }
                                            
            }
        }
        private void LimpiarControladores()
        {
            ventana.txtId.Text = "";
            ventana.txtNombre.Text = "";
            ventana.rtDescripcion.Text = "";
            ventana.txtPrecio.Text = "";
            ventana.txtCategoria.Text = "";
            ventana.txtSubcategoria.Text = "";
        }
    }
}
 