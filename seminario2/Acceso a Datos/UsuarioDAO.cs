using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminario2.Acceso_a_Datos
{
    internal class UsuarioDAO:DAO
    {
        static string tabla = "usuarios";
        
        public static bool esUsuarioValido(string nombre, string contraseña)
        {
            TraerBaseDatos(tabla);
            string consulta = "select count(*) as cantidad from usuarios where nombre='"+nombre+"' and contraseña='"+contraseña+"'";
            DataTable resultado = bd.TraerTabla(consulta);
            if (Convert.ToInt32(resultado.Rows[0]["cantidad"]) == 1)
            {
                return true;
            }
                return false;
        }
    }
}
