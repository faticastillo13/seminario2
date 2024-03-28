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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace seminario2.Interfases.VentanaFacturas
{
    public partial class RegistrarFormaPago : Form
    {
        public RegistrarFormaPago(Factura f)
        {
            InitializeComponent();
            Factura factura = f;
        }

        private void RegistrarFormaPago_Load(object sender, EventArgs e)
        {
            cbFormaPago.DataSource = formadePagoDAO.traerTodo();
        }
    }
}
