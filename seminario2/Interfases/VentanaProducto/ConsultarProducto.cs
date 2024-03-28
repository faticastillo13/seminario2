using seminario2.Acceso_a_Datos;
using seminario2.Clases_de_Entidad;
using seminario2.Interfases.VentanaFacturas;
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
    public partial class ConsultarProducto : Form
    {
        int id_factura = -1;
        Factura factura;
        public CargarFactura cargarFactura;

        public ConsultarProducto(int id)
        {
            id_factura = id;
            if (factura == null)
            {
                factura = FacturaDAO.TraerUno(id_factura);
            }
            InitializeComponent();
        }

        public ConsultarProducto(Factura factura) : this(factura.Get_NroFactura())
        {
            this.factura = factura;
        }
        public ConsultarProducto() : this(-1)
        {
            btAñadir.Visible = false;
        }

        public ConsultarProducto(Factura factura, CargarFactura cargarFactura) : this(factura)
        {
            this.cargarFactura = cargarFactura;
        }

        private void VisualizarControladores()
        {
            if (rbNombre.Checked)
            {
                gbNombre.Visible = true;
                gbCategoria.Visible = false;
                gbId.Visible = false;
            }
            else if (rbCategoria.Checked)
            {
                gbNombre.Visible = false;
                gbCategoria.Visible = true;
                gbId.Visible = false;
            }
            else
            {
                gbNombre.Visible = false;
                gbCategoria.Visible = false;
                gbId.Visible = true;
            }
        }

        private void rbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            VisualizarControladores();
        }

        private void rbId_CheckedChanged(object sender, EventArgs e)
        {
            VisualizarControladores();
        }
        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {
            VisualizarControladores();
        }

        private void ConsultarProducto_Load(object sender, EventArgs e)
        {
            dgProductos.DataSource = ProductoDAO.TraerInfo();
            CategoriaDAO categoriaDao = new CategoriaDAO();
            cbCategoria.DataSource = categoriaDao.TraerTodos();
            cbCategoria.DisplayMember = "nombre";
            cbCategoria.ValueMember = "id_categoria";
            rbNombre.Checked = true;
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            object aBuscar;
            if (rbNombre.Checked)
            {
                aBuscar = txtProducto.Text;
                dgProductos.DataSource = ProductoDAO.BuscarPorNombre(aBuscar.ToString());
            }
            else if (rbCategoria.Checked)
            {
                aBuscar = cbCategoria.SelectedValue;
                dgProductos.DataSource = ProductoDAO.BuscarPorCategoria((int)aBuscar);
            }
            else
            {
                aBuscar = nupId.Value;
                dgProductos.DataSource = ProductoDAO.BuscarPorId((int)aBuscar);
            }

        }

        private void dgProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numeroFila = e.RowIndex;

            txtId.Text = dgProductos.Rows[numeroFila].Cells[0].Value.ToString();
            txtNombreProducto.Text = dgProductos.Rows[numeroFila].Cells[1].Value.ToString();

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                btAñadir.Enabled = false;
            }
            else
            {
                btAñadir.Enabled = true;
            }
        }

        private void btAñadir_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(txtId.Text);
            Producto producto = ProductoDAO.TraerUno(id);
            AñadirDetalleFactura vtn = new AñadirDetalleFactura(factura, producto, this);
            vtn.ShowDialog();
            Hide();
        }
    }
}

