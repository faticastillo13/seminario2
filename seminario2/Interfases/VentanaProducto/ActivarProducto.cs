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
    public partial class ActivarProducto : Form
    {
        public ActivarProducto()
        {
            InitializeComponent();
        }

        private void ActivarProducto_Load(object sender, EventArgs e)
        {

            Controladores.ControladorActivarProducto controlador = new Controladores.ControladorActivarProducto(this);
            controlador.LlenarGrilla();
        }
        private void LlenarControladores()
        {

        }



        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                btActivar.Enabled = false;
                btEliminar.Enabled = false;
            }
            else
            {
                btActivar.Enabled = true;
                btEliminar.Enabled = true;
            }
        }

        public Boolean ConfirmarActivacion(string nombreProducto)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro que quiere activar el producto " + nombreProducto + "?", "Confirmacion de activación de producto ", MessageBoxButtons.YesNo);
            return respuesta == DialogResult.Yes;
        }
        private void btActivar_Click(object sender, EventArgs e)
        {

        }
        public Boolean ConfirmarEliminacion(string nombreProducto)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro que quiere eliminar el producto " + nombreProducto + "?", "Confirmacion de eliminación de producto ", MessageBoxButtons.YesNo);
            return respuesta == DialogResult.Yes;
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
