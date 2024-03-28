using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace seminario2.Acceso_a_Datos
{
    //esta clase representa el enlace de nuestra app con la BD
    public class BasedeDatos
    {
        private string tabla;
        static MySqlConnection conexion; 

        public BasedeDatos(string tabla)
        {
            this.tabla = tabla;
            conectar();
        }

        public BasedeDatos()
                    {
            conectar();
        }

        public void conectar()
        {
            string BaseDeDatos="seminario2";
            string NombreDelServidor= "localhost";
            string NombreDeUsuario= "root";
            string Contraseña="seminario2";
            string CadenaDeConexion="server="+NombreDelServidor;
            CadenaDeConexion += ";database="+BaseDeDatos;
            CadenaDeConexion += ";user id="+ NombreDeUsuario;
            CadenaDeConexion += ";password="+ Contraseña;
            conexion = new MySqlConnection(CadenaDeConexion);
            
        }

        public void AbrirConexion()
        {
            try {
                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error al abrir la conexión: " + ex.Message);

            }

        }

        public void CerrarConexion()
        {
            try
            {
                if (conexion.State != System.Data.ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error al cerrar la conexión: " + ex.Message);
            }
        }
        public DataTable TraerTodos()
        {
            
            DataTable table=new DataTable ();
            string consulta= "select * from "+tabla;
            table = TraerTabla(consulta);
            return table;
            
        }

        public int EjecutarComando(string comandoSQL)
        {
            AbrirConexion();
            try
            {
                MySqlCommand comando = new MySqlCommand(comandoSQL, conexion);
                return comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar el comando: " + ex.Message);
                CerrarConexion();
                return -1; // Retorna -1 en caso de error
            }
        }

        public DataTable TraerTabla(string comandoSQL)
        {
            AbrirConexion();
            DataTable table = new DataTable();
           
            MySqlCommand comando = new MySqlCommand(comandoSQL, conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            try
            {
                adaptador.Fill(table);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            CerrarConexion();

            return table;
        }


        //public Ejecutar 
        public string GetTabla()
        {
            return tabla;
        }
        public void SetTabla(string tabla)
        {
            this.tabla = tabla;
        }

    }
}
