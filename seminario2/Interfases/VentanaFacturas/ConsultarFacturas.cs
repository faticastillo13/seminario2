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
    public partial class ConsultarFacturas : Form
    {
        public ConsultarFacturas()
        {
            InitializeComponent();
        }

        private void ConsultarFacturas_Load(object sender, EventArgs e)
        {
            dgFacturas.DataSource = FacturaDAO.TraerTodos();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            if (txtIdFactura.Text == "")
            {
                return;
            }
            int id = Convert.ToInt32(txtIdFactura.Text);
            ConsultarFactura vtn = new ConsultarFactura(id);
            vtn.ShowDialog();
        }

        private void dgFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = (int)dgFacturas.Rows[e.RowIndex].Cells[0].Value;
            txtIdFactura.Text = id.ToString();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde, fechaHasta;
            fechaDesde = dateTimePicker1.Value;
            fechaHasta = dateTimePicker2.Value;

            dgFacturas.DataSource = FacturaDAO.FiltrarPorFecha(fechaDesde, fechaHasta);
        }
    }
}
