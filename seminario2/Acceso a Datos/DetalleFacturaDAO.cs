using seminario2.Clases_de_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace seminario2.Acceso_a_Datos
{
  

    public class DetalleFacturaDAO:DAO

    {
        static string tabla = "detalle_factura";
        public static DataTable TraerTodos()
            
        {
            bd = new BasedeDatos(tabla);
            return bd.TraerTodos();
        }

        public static DataTable TraerInfo(int id)
        {

            string consulta = "select d.id_detalle_factura, p.nombre, d.precio, d.cantidad, d.cantidad* d.precio as 'subtotal' from detalle_factura d inner join productos p on d.id_producto = p.id_producto where nro_factura = '"+id+"'";
            return bd.TraerTabla(consulta);
            
        }

        public static int ObtenerProximoId(int id_factura)
        {
            int id = 0;
            string consulta = "select max(id_detalle_factura) from detalle_factura where nro_factura = '"+id+"'";
            DataTable resultado = bd.TraerTabla(consulta);
            id = (int)resultado.Rows[0][0];
            id = id + 1;
            return id;

        }
        public static void InsertarUno(DetalleFactura df)
        {
            string consulta = "insert into detalle_factura (nro_factura, id_detalle_factura, id_producto, precio,cantidad) values (";
            consulta += df.Get_NroFactura() + ", ";
            consulta += df.Get_IdDetalleFactura() + ", ";
            consulta += df.Get_IdProducto() + ", ";
            consulta += df.Get_Precio() + ", ";
            consulta += df.Get_Cantidad() +")";
            bd.EjecutarComando(consulta);
        }

    }
}
