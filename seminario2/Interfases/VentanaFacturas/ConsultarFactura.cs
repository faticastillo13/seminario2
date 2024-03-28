using seminario2.Clases_de_Entidad;
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

namespace seminario2.Interfases.VentanaFacturas
{
    public partial class ConsultarFactura : Form
    {
        int id;
        public ConsultarFactura()
        {
            InitializeComponent();
        }

        public ConsultarFactura(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void ConsultarFactura_Load(object sender, EventArgs e)
        {
            dgDetalleFactura.DataSource = DetalleFacturaDAO.TraerInfo(id);
            txtId.Text = id.ToString();
            txtNombre.Text = FacturaDAO.TraerAtributo(id, "nombre_cliente").ToString();
            txtFecha.Text = FacturaDAO.TraerAtributo(id, "fecha").ToString();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
