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

namespace seminario2.Interfases.VentanaUsuario
{
    public partial class Login : Form
    {
        int cantidadIntentos = 0;
        int minutosDemora = 1;
        public Login()
        {
            InitializeComponent();
        }

        private void btnVerContraseña_Click(object sender, EventArgs e)
        {
            if (txtContraseña.PasswordChar == '*')
            {
                txtContraseña.PasswordChar = '\0';
                btnVerContraseña.Text = "Ocultar";

            }
            else
            {
                txtContraseña.PasswordChar = '*';
                btnVerContraseña.Text = "Ver";
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre, contraseña;
            nombre = txtUsuario.Text;
            contraseña = txtContraseña.Text;

            Boolean esUsuarioValido = UsuarioDAO.esUsuarioValido(nombre, contraseña);
            if (esUsuarioValido)
            {
                AccederVentanaPrincipal();
            }
            else
            {

                txtUsuario.Focus();
                txtContraseña.Text = "";
                lbError.Visible = true;
                cantidadIntentos++;
                if (cantidadIntentos == 4)
                {

                    reloj.Interval = minutosDemora * 1000;
                    cantidadIntentos = 0;
                    MessageBox.Show("Excedio la cantidad de intentos, intente dentro de 5 minutos");
                    btnAceptar.Enabled = false;
                    reloj.Start();
                    btnAceptar.Enabled = true;
                    minutosDemora = minutosDemora * 2;
                }
            }

        }
        private void AccederVentanaPrincipal()
        {
            Principal vtn = new Principal();
            this.Hide();
            vtn.Show();

        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.W)
            {
                AccederVentanaPrincipal();
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (lbError.Visible)
            {
                lbError.Visible = false;
            }
        }

        private void reloj_Tick(object sender, EventArgs e)
        {
            btnAceptar.Enabled = false;
            
        }
    }
}
