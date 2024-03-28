using MySqlX.XDevAPI.Relational;
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
    internal class SubcategoriaDAO
    {
        private static BasedeDatos bd;

        public SubcategoriaDAO()
        { 
            bd = new BasedeDatos("subcategorias");
        }

        public DataTable TraerTodos()
        {
            return bd.TraerTodos();

        }

        public void InsertarUno (Subcategoria s)
        {
            string consulta = "insert into subcategorias (nombre, descripcion, id_categoria, id_subcategoria) values ";
            consulta += string.Format("('{0}', '{1}', '{2}', '{3}');", s.GetNombre(), s.GetDescripcion(), s.GetCategoria().getId(), ObtenerProximoId());
            
            MessageBox.Show(consulta);

            bd.EjecutarComando(consulta);
        }

        public int ObtenerProximoID(int id_categoria)
        {
            int id = 0;
            //se consulta a la bd para q retorne el max valor de id_subcategoria y si lo ecnuentra, a ese se le suma 1
            string consulta = "select max(id_subcategoria) from subcategoria where id_categoria = '"+ id_categoria +"';";
            DataTable dt = bd.TraerTabla(consulta);

            if (dt != null)
            {
                try
                {
                    id = Convert.ToInt32(dt.Rows[0][0]);
                    id++;
                }
                catch (Exception)
                {
                    MessageBox.Show("" + dt.Rows[0][0]);
                    id = 0;
                }
            }
            return id;

        }
        public int ObtenerProximoId()
        {
            int id = 0;
            //se consulta a la bd para q retorne el max valor de id_subcategoria y si lo ecnuentra, a ese se le suma 1
            string consulta = "select max(id_subcategoria) from subcategorias;";
            DataTable dt = bd.TraerTabla(consulta);

            if (dt != null)
            {
                try
                {
                    id = Convert.ToInt32(dt.Rows[0][0]);
                    id++;
                }
                catch (Exception)
                {
                    MessageBox.Show("" + dt.Rows[0][0]);
                    id = 0;
                }
            }
            return id;

        }

        public DataTable TraerInfo ()
        {
            string consulta = "select c.nombre as 'categoria', s.id_subcategoria, s.nombre, s.descripcion from  categorias c inner join subcategorias s on c.id_categoria = s.id_categoria";
            return bd.TraerTabla(consulta);
        }

        public void BorrarUno(int id_sub, int id_cat)
        {
            string consulta = "delete from subcategorias where id_subcategoria = '"+ id_sub +"' and id_categoria = '"+ id_cat +"';";
            bd.EjecutarComando (consulta);
        }

        public void ModificarUno(Subcategoria s, int Id_nueva_categoria)
        {
            string consulta = "update subcategorias set ";
            consulta += " nombre = ' " + s.GetNombre() + "',";
            consulta += " descripcion = ' " + s.GetDescripcion() + "',";
            consulta += " id_categoria = ' " + Id_nueva_categoria + "'";
            consulta += " where id_categoria = '" + s.GetIdCategoria();
            consulta += "' and id_subcategoria = '" + s.GetIdSubCategoria() + "';";
            MessageBox.Show(consulta);
            bd.EjecutarComando(consulta);
            MessageBox.Show("Modificacion Exitosa");

        }

        public void ModificarUno(Subcategoria s)
        {
            ModificarUno(s,s.GetIdSubCategoria());
           
        }

        public Subcategoria TraerUno(int ids, int idc)
        {
            Subcategoria subcategoria = new Subcategoria();
            string consulta = "select * from subcategorias where id_subcategoria = '" + ids;
            consulta += "' and id_categoria = '" + idc + "'";
            DataTable table = bd.TraerTabla(consulta);

            if (table.Rows.Count < 1)
            {
                MessageBox.Show("No se encontro ninguna subcategoria con el ID: " + ids);
                return subcategoria;
            }

            string nombre = table.Rows[0]["nombre"].ToString();
            string descripcion = table.Rows[0]["descripcion"].ToString();
            int idsubcategoria = Convert.ToInt32(table.Rows[0]["id_subcategoria"].ToString());
            int idcategoria = Convert.ToInt32(table.Rows[0]["id_categoria"].ToString());
            CategoriaDAO categoriaDAO = new CategoriaDAO();
            Categoria categoria = categoriaDAO.TraerUno(idcategoria);
             

            subcategoria = new Subcategoria(ids, nombre, descripcion, categoria);
            return subcategoria;
        }

        // Metodo que en base al id de la categoría trae toda la info de las subcategorías
        // cuya categoría sea la del id

        public DataTable TraerDeCategoria(int id)
        {

            string consulta = "select id_subcategoria, nombre from subcategorias where id_categoria = '" + id + "'";
            return bd.TraerTabla(consulta);
        }

    }




}
