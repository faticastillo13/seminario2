using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminario2.Clases_de_Entidad
{
    public class Producto
    {
        private int id_producto;
        private string nombre;
        private string descripcion;
        private double precio;
        private int id_categoria;
        private int id_subcategoria;
        private int stock;
        private Categoria categoria;
        private Subcategoria subcategoria;
        private Boolean activo;

        public int GetIdProducto() 
        { 
            return id_producto; 
        } 

        public string GetNombre()
        {
            return nombre;
        }

        public string GetDescripcion()
        {
            return descripcion;
        }

        public double GetPrecio()
        {
            return precio;
        }

        public int GetIdCategoria()
        {
            return id_categoria;
        }

        public int GetIdSubcategoria()
        {
            return id_subcategoria;
        }

        public int GetStock()
        {
            return stock;
        }

        public Categoria GetCategoria()
        {
            return categoria;
        }

        public Subcategoria GetSubcategoria()
        {
            return subcategoria;
        }
        public void Set_Id_Producto(int id_producto)
        {
            this.id_producto = id_producto;
        }
        public void Set_Nombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void Set_Descripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }
        public void Set_Precio(double precio)
        {
            this.precio = precio;
        }
        public void Set_IdCategoria(int id_categoria)
        {
            this.id_categoria = id_categoria;
        }
        public void Set_IdSubCategoria(int id_subcategoria)
        {
            this.id_subcategoria = id_subcategoria;
        }
        public void Set_Stock(int stock)
        {
            this.stock = stock;
        }
        public void Set_Categoria(Categoria categoria)
        {
            this.categoria = categoria;
        }
        public void Set_Subcategoria(Subcategoria subcategoria)
        {
            this.subcategoria = subcategoria;
        }

        public void Set_Activo(Boolean activo)
        {
            this.activo = activo;
        }
        public Producto()
        {
        }

        public Producto(int id_producto, string nombre, string descripcion, double precio, int stock, Categoria categoria, Subcategoria subcategoria)
        {
            this.id_producto = id_producto;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
            this.categoria = categoria;
            this.subcategoria = subcategoria;
        }

        public Boolean puedoVender (int cantidad)
        {
            if (cantidad < stock)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
