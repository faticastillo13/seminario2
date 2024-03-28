using seminario2.Acceso_a_Datos;
using seminario2.Clases_de_Entidad;
using seminario2.Interfases.VentanaProducto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seminario2.Interfases.VentanaFacturas
{
    public partial class AñadirDetalleFactura : Form
    {

        Factura factura;
        Producto producto;
        private ConsultarProducto consultarProducto;

        public AñadirDetalleFactura(Factura factura, Producto producto)
        {
            this.producto = producto;
            this.factura = factura;
            InitializeComponent();
        }

        public AñadirDetalleFactura(Factura factura, Producto producto, ConsultarProducto consultarProducto) : this(factura, producto)
        {
            this.consultarProducto = consultarProducto;
        }

        private void AñadirDetalleFactura_Load(object sender, EventArgs e)
        {
            nupCantidad.Maximum = producto.GetStock();
            txtIdProducto.Text = producto.GetIdProducto().ToString();
            txtNombreProducto.Text = producto.GetNombre();
            txtNroFactura.Text = factura.Get_NroFactura().ToString();
        }



        private void btCargar_Click(object sender, EventArgs e)
        {
            if (nupCantidad.Value == 0)

            {
                MessageBox.Show("Debe vender al menos un producto");
                return;
            }
            int cantidad = (int)nupCantidad.Value;
            factura.Add(producto, cantidad);
            consultarProducto.cargarFactura.ActualizarTabla();
            Close();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
