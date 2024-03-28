using Org.BouncyCastle.Tls;
using seminario2.Clases_de_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminario2.Acceso_a_Datos
{
    public class ProductoDAO:DAO
    {
        static string tabla = "productos";

      
        
        public static DataTable TraerTodos()
        {
            TraerBaseDatos(tabla);
            return bd.TraerTodos();
        }
        public static DataTable TraerInfo()
        {

            return TraerInfo(true);
        }

        public static DataTable TraerInfo(bool soloActivo)
        {
            TraerBaseDatos(tabla);
            string consulta = "select p.id_producto, p.nombre, p.descripcion, p.precio, p.stock, c.nombre as 'categoria', s.nombre as 'subcategoria'" +
                                 "from productos p inner join categorias c on p.id_categoria = c.id_categoria" +
                                 " inner join subcategorias s on p.id_categoria = s.id_categoria and p.id_subcategoria = s.id_subcategoria";
            if (soloActivo)
            {
                consulta += " where activo = true";
            } 
            return bd.TraerTabla(consulta);
        }                       

        public static void InsertarUno(Producto p)
              {
                  string consulta = "insert into productos (nombre, descripcion,precio, id_categoria, id_subcategoria, stock, activo) values ";
                  consulta += string.Format("('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', true);", p.GetNombre(), p.GetDescripcion(), p.GetPrecio(), p.GetIdCategoria(), p.GetIdSubcategoria(), p.GetStock());

                  MessageBox.Show(consulta);

                  bd.EjecutarComando(consulta);
              }

        public static void BorrarUno(Producto p) 
        {
            BorrarUno(p.GetIdProducto());
        }

        public static void BorrarUno(int id)
        {
            string consulta = "update productos set activo = false where id_producto = '" + id + "'";
            bd.EjecutarComando(consulta);
            MessageBox.Show("Borrado del producto exitoso");
        }

        public static void ModificarUno(Producto p)
        {
            string consulta = "update productos set nombre ='{0}' , descripcion = '{1}', precio = {2}, id_categoria = {3}, id_subcategoria = {4}, stock = {5} where id_producto = '{6}'";
                   consulta = string.Format(consulta,p.GetNombre(),p.GetDescripcion(),p.GetPrecio(),p.GetIdCategoria(),p.GetIdSubcategoria(),p.GetStock(),p.GetIdProducto());
            MessageBox.Show(consulta);
            bd.EjecutarComando(consulta);
            MessageBox.Show("Modificacion del producto exitoso");
        }

        public static Producto TraerUno(int id)
        {

            Producto producto = new Producto();
            string consulta = "select * from productos where id_producto = '" + id + "'";
            DataTable table = bd.TraerTabla(consulta);

            if (table.Rows.Count < 1)
            {
                MessageBox.Show("No se encontro ningun producto con el ID: " + id);
                return producto;
            }

            string nombre = table.Rows[0]["nombre"].ToString();
            string descripcion = table.Rows[0]["descripcion"].ToString();
            double precio = Convert.ToDouble(table.Rows[0]["precio"].ToString());
            int idcategoria = Convert.ToInt32(table.Rows[0]["id_categoria"].ToString());
            int idsubcategoria = Convert.ToInt32(table.Rows[0]["id_subcategoria"].ToString());
            int stock = Convert.ToInt32(table.Rows[0]["stock"].ToString());
            Boolean activo = Convert.ToBoolean(table.Rows[0]["activo"].ToString());

            producto.Set_Id_Producto(id);
            producto.Set_Nombre(nombre);
            producto.Set_Descripcion(descripcion);  
            producto.Set_Precio(precio);
            producto.Set_IdCategoria(idcategoria);
            producto.Set_IdSubCategoria(idsubcategoria);
            producto.Set_Stock(stock);
            producto.Set_Activo(activo);
            return producto;

        }

        public static DataTable BuscarPorNombre(string nombre)
        {
            string consulta = "select * from productos where nombre like '%"+nombre+"%'";
            DataTable table = bd.TraerTabla(consulta);
            return table;
        }

        public static DataTable BuscarPorCategoria(int id)
        {
            string consulta = "select * from productos where id_categoria = "+id+"";
            DataTable table = bd.TraerTabla(consulta);
            return table;
        }

        public static DataTable BuscarPorId (int id)
        {
            string consulta = "select * from productos where id_producto = " + id + "";
            DataTable table = bd.TraerTabla(consulta);
            return table;
        }

        public static object TraerAtributo(int id_producto, string campo)
        {
            string consulta = "select "+campo+" from productos where id_producto = "+id_producto+"";
            TraerBaseDatos(tabla);
            DataTable respuesta = bd.TraerTabla(consulta);
            return respuesta.Rows[0][0];
        }

        public static DataTable TraerInactivos()
        {
            string consulta = "select p.id_producto, c.nombre as categoria, s.nombre as subcategoria, p.nombre, p.descripcion, p.precio from categorias c inner join subcategorias s on c.id_categoria = s.id_categoria inner join productos p on (p.id_categoria = c.id_categoria and p.id_subcategoria = s.id_subcategoria) where p.activo = 0";
            TraerBaseDatos(tabla);
            DataTable table = bd.TraerTabla(consulta);
            return table;
        }

        public static void ActivarProducto(int id)
        {
            string consulta = "update productos set activo =1 where id_producto = "+id+"";
            TraerBaseDatos(tabla);
            DataTable table = bd.TraerTabla(consulta);
        }

        public static Boolean EliminarProducto (int id)
        {
            string consulta = "delete from productos where id_producto = "+id+"";
            TraerBaseDatos(tabla);
           DataTable resultado = bd.TraerTabla(consulta);
            if (resultado.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }
    }
}
