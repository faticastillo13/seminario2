using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminario2.Clases_de_Entidad
{
    public class Subcategoria
    {
        private Categoria _categoria;
        private string nombre;
        private string descripcion;
        private int id;
       
        public Subcategoria(Categoria categoria, string nombre, string descripcion)
        {
            _categoria = categoria;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public Subcategoria(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public Subcategoria()
        {
        }

        public Subcategoria(int ids, string? nombre, string? descripcion, Categoria categoria)
        {
            this.id = ids;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this._categoria = categoria;
        }

        public Categoria GetCategoria()
        {
            return _categoria;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetDescripcion() 
        {
            return descripcion;
        }

        public void SetCategoria(Categoria categoria)
        {
            _categoria = categoria;
        }

        public void SetNombre(string nombre)
        {
            this.nombre=nombre; 
        }

        public void SetDescripcion(string descripcion)
        {
           this.descripcion=descripcion;
        }

        internal int GetIdCategoria()
        {
            return _categoria.getId();
        }

        internal int GetIdSubCategoria()
        {
            return this.id;
        }
    }
}



