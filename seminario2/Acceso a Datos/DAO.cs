using seminario2.Clases_de_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace seminario2.Acceso_a_Datos
{
    public class DAO: IDAO
    {
        protected static BasedeDatos bd;
        protected static string tabla;

        public void SetTabla(string nombre_tabla)
        {
            if (bd == null)
            {
                bd = TraerBaseDatos();
            }
            if (bd.GetTabla() != nombre_tabla)
            {
                bd.SetTabla(nombre_tabla);
                tabla = nombre_tabla;
            }
        }
        protected static BasedeDatos TraerBaseDatos()
        {
            //preguntamos si la bd ya ha sido creada
            if (bd != null)
            {
                return bd;
            }
            else
            {
                bd = new BasedeDatos(tabla);
                return bd;
            }

        }
        protected static BasedeDatos TraerBaseDatos(string nombre_tabla)
        {
            //preguntamos si la bd ya ha sido creada
            if (bd != null)
            {
                return bd;
            }
            else
            {
                bd = new BasedeDatos(nombre_tabla);
                return bd;
            }

        }
         

        public DataTable TraerTodos()
        {
            TraerBaseDatos();
            return bd.TraerTodos();

        }

        
    }
}
