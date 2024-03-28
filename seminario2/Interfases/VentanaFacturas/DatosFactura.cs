using seminario2.Acceso_a_Datos;
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

namespace seminario2.Interfases.VentanaFacturas
{
    public partial class DatosFactura : Form
    {
        private CargarFactura cargarFactura;
        private Factura factura;

        public DatosFactura()
        {
            InitializeComponent();
        }

        public DatosFactura(CargarFactura cargarFactura, Factura factura)
        {
            this.cargarFactura = cargarFactura;
            this.factura = factura;
            InitializeComponent();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            cargarFactura.Show();
            this.Close();

        }

        private void DatosFactura_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToString();
            txtNroFactura.Text = cargarFactura.txtNroFactura.Text;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            string nombre, domicilio, mail, telefono;
            int dni;

            nombre = txtNombre.Text;
            domicilio = txtxDomicilio.Text;
            mail = txtMail.Text;
            dni = Convert.ToInt32(txtDNI.Text);
            telefono = (txtTelefono.Text);

            factura.Set_NombreCliente(nombre);
            factura.Set_Domicilio(domicilio);
            factura.Set_Mail(mail);
            factura.Set_Dni(dni);
            factura.Set_Telefono(telefono);

            if (MessageBox.Show("Está seguro de guardar los datos de la factura?","Confirmación de guardar factura",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FacturaDAO.InsertarUno(factura);
                MessageBox.Show("se cargó correctamente la factura");
                this.Close();
            }
        }
    }
}
