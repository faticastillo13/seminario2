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
    public partial class CargarFactura : Form
    {
        Factura factura = new Factura();
        public CargarFactura()
        {
            InitializeComponent();
        }

        private void bConsultarProducto_Click(object sender, EventArgs e)
        {

            ConsultarProducto consultarProducto = new ConsultarProducto(factura, this);
            
            consultarProducto.Show();
           

        }

        public void ActualizarTabla()
        {
            dgVentas.Rows.Clear();
            dgVentas.AllowUserToAddRows = true;
            int nro_fila = 0;
            foreach (DetalleFactura d in factura.Get_DetalleFactura())
            {
                
                dgVentas.Rows.Add();


                dgVentas.Rows[nro_fila].Cells[0].Value = d.Get_IdProducto();
                dgVentas.Rows[nro_fila].Cells[1].Value = d.Get_Cantidad();
                dgVentas.Rows[nro_fila].Cells[2].Value = d.Get_Nombre();
                dgVentas.Rows[nro_fila].Cells[3].Value = d.Get_Precio();
                nro_fila++;
            }
            dgVentas.AllowUserToAddRows = false;
        }
        private void CargarFactura_Load(object sender, EventArgs e)
        {
            int nro_factura = FacturaDAO.ObtenerProximoId();
            txtNroFactura.Text = nro_factura.ToString();
            

            factura.Set_NroFactura(nro_factura);
            factura.Set_Fecha(DateTime.Now);
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DatosFactura vtn = new DatosFactura(this, factura);
            vtn.Show();
            this.Hide();

        }
    }
}
