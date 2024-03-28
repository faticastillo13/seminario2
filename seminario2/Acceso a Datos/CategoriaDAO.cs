using MySql.Data.MySqlClient;
using seminario2.Clases_de_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminario2.Acceso_a_Datos
{
    public class CategoriaDAO:DAO
    {
        
        public CategoriaDAO()
        {
            bd = new BasedeDatos("categorias");
            
        }
        public DataTable TraerTodos () { return bd.TraerTodos(); 
        
        }
        public void InsertarUno(Categoria c) {
            string consulta = "insert into categorias (nombre, descripcion) values ";
            consulta += string.Format("('{0}', '{1}');", c.getNombre(), c.getDescripcion());
            Console.WriteLine(consulta);

            MessageBox.Show(consulta);

            bd.EjecutarComando(consulta);
        }
        public Categoria TraerUno(int id)
        {
            Categoria categoria = new Categoria();
            string consulta = "select * from categorias where id_categoria = " + id;
            
            DataTable table = bd.TraerTabla(consulta);

            if (table.Rows.Count <1)
            {
                MessageBox.Show("No se encontro ninguna categoria con el ID: "+id);
                return categoria;
            }
           
            string nombre = table.Rows[0]["nombre"].ToString();
            string descripcion= table.Rows[0]["descripcion"].ToString();
            categoria = new Categoria(id, nombre, descripcion);
            return categoria;
        }
        public void EliminarUno(Categoria c) {
            EliminarUno(c.getId());
        }

        public void EliminarUno(int id)

        {
            bd.EjecutarComando("delete from subcategorias where id_categoria = " + id);
            string consulta = "delete from categorias where id_categoria = "+id;
            bd.EjecutarComando(consulta);
            MessageBox.Show("Borrado Exitoso");
        }

        public void ModificarUno(Categoria c)
        {
            string consulta = "update categorias set ";
            consulta += " nombre = ' " + c.getNombre() + "',";
            consulta += " descripcion = ' " + c.getDescripcion() + "'";
            consulta += " where id_categoria = " + c.getId();

            bd.EjecutarComando(consulta);
            MessageBox.Show("Modificacion Exitosa");
        }

        public int ObtenerID(string nombre)
        {
            string consulta = "select id_categoria from categorias where nombre = '" +nombre +"'";
            DataTable table = bd.TraerTabla(consulta);
            int id = Convert.ToInt32(table.Rows[0][0].ToString());
            return id;
        }
    }
          
}
