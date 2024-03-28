using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminario2.Clases_de_Entidad
{
    public class Categoria
    {
        private int id;
        private string nombre;
        private string descripcion;

        public override string ToString()
        {
            string cadena = "id: " + id;
            cadena += " nombre: "+ nombre;
            cadena += " descripcion: " + descripcion;
            return cadena;
        }
        public Categoria(int id, string nombre, string descripcion)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        //???
        public Categoria()
        {
        }
        public int getId()
        {
            return id;
        }
        public string getNombre()   
        { return nombre; 
        }
        public string getDescripcion()
        {   return descripcion; 
        }

        public void setNombre(string nombre)
        { this.nombre = nombre;
        }

        public void setDescripcion (string descripcion)
        { this.descripcion = descripcion;
        }
    }
}
