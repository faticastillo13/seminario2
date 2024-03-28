using seminario2.Clases_de_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminario2.Acceso_a_Datos
{
    public class FacturaDAO:DAO
    {
        static string tabla = "factura";

        public static DataTable TraerTodos()
        {
            TraerBaseDatos(tabla);
            return bd.TraerTodos();
        }
        //metodo que retorna un dato como objeto que es el campo de la tabla para cierto id
        public static object TraerAtributo(int id, string campo)
        {
            string consulta = "select " + campo + " from factura where nro_factura = '" + id + "'";
            TraerBaseDatos(tabla);
            DataTable respuesta = bd.TraerTabla(consulta);
            return respuesta.Rows[0][0];
        }

        public static DataTable FiltrarPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            string consulta = "select * from factura where fecha between str_to_date('"+fechaDesde.ToString()+"','%d/%m/%Y %H:%i:%s') and str_to_date('"+fechaHasta.ToString()+"','%d/%m/%Y %H:%i:%s')";
            return bd.TraerTabla(consulta);
        }

        public static int ObtenerProximoId()
        {
            TraerBaseDatos("factura");
            int id = 0;
            string consulta = "select max(nro_factura) from factura";
            DataTable tabla = bd.TraerTabla(consulta);
            id = (int)tabla.Rows[0][0] + 1;   
            return id;
        }

        public static Factura TraerUno(int nro_factura)
        {
            TraerBaseDatos("factura");
            string consulta = "select *from factura where nro_factura = "+nro_factura+"";
            return null;
        }

        public static DataTable MostrarDetalleFactura(int nro_factura)
        {
            return DetalleFacturaDAO.TraerInfo(nro_factura);
         
        }
         
        public static void InsertarUno(Factura f)
        {
            string consulta = "insert into factura (nro_factura, fecha, nombre_cliente, total) values (";
            consulta += f.Get_NroFactura() + ", ";
            consulta += "str_to_date('"+f.Get_Fecha()+"','%d/%m/%Y %H:%i:%s')" + ", '";
            consulta += f.Get_NombreCliente() + "', ";
            consulta += f.calcularTotal() + ")";
            bd.EjecutarComando(consulta);
            MessageBox.Show(consulta);
            //ahora se insertarán los detalles de factura
            foreach (DetalleFactura df in f.Get_DetalleFactura())
            {
                DetalleFacturaDAO.InsertarUno(df);
            }


        }
    }
}
