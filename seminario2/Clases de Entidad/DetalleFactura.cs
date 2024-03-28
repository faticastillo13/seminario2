using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminario2.Clases_de_Entidad
{
    public class DetalleFactura
    {
       private int nro_factura;
       private int id_detalle_factura;
       private int id_producto;
       private double precio;
       private int cantidad;
       private string nombre;
       private Producto producto;

        public int Get_NroFactura()
        {
            return nro_factura;
        }

        public string Get_Nombre()
        {
            return nombre;
        }
        public int Get_IdDetalleFactura()
        {
            return id_detalle_factura;
        }

        public int Get_IdProducto()
        {
            return id_producto;
        }

        public double Get_Precio()
        {
            return precio;
        }

        public int Get_Cantidad()
        {
            return cantidad;
        }

        public DetalleFactura()
        {
        }

        public void Set_NroFactura(int nro_factura)
        {
            this.nro_factura = nro_factura;
        }

        public void Set_IdDetalleFactura(int id_detalle_factura)
        {
            this.id_detalle_factura = id_detalle_factura;
        }

        public void Set_IdProducto(int id_producto)
        {
            this.id_producto = id_producto;
        }

        public DetalleFactura(int nro_factura, int id_detalle_factura, int id_producto, double precio, int cantidad)
        {
            this.nro_factura = nro_factura;
            this.id_detalle_factura = id_detalle_factura;
            this.id_producto = id_producto;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public DetalleFactura(int nro_factura, string nombre, int id_detalle_factura, int id_producto, double precio, int cantidad)
        {
            this.nro_factura = nro_factura;
            this.nombre = nombre;
            this.id_detalle_factura = id_detalle_factura;
            this.id_producto = id_producto;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public override string? ToString()
        {
            string cadena = "";
            cadena += " Id: "+this.id_producto;
            cadena += " Cantidad: "+this.cantidad;
            cadena += " Nombre: "+this.nombre;
            cadena += " Precio: "+this.precio;
            return cadena;
        }

        public void Set_Precio(double precio)
        {
            this.precio = precio;
        }

        public void Set_Nombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void Set_Cantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public double subtotal()
        {
            
            double subtotal = 0;
            subtotal = precio * cantidad;
            return subtotal;
        }
    }
}
