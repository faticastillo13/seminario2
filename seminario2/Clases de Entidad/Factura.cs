using seminario2.Acceso_a_Datos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminario2.Clases_de_Entidad
{
    public class Factura
    {
        private int nro_factura, dni;
        private DateTime fecha;
        private string nombre_cliente, domicilio, mail, telefono;
        private List<DetalleFactura> items;
        private int id_detalle_factura = 0;

        public Factura(int nro_factura, DateTime fecha, string nombre_cliente)
        {
            this.nro_factura = nro_factura;
            this.fecha = fecha;
            this.nombre_cliente = nombre_cliente;
            items = new List<DetalleFactura>();
        }

        public Factura()
        {
            items = new List<DetalleFactura>();
        }

        public int Get_NroFactura()
        {
            return nro_factura;
        }

        public DateTime Get_Fecha()
        {
            return fecha;
        }

        public string Get_NombreCliente()
        {
            return nombre_cliente;
        }

        public void Set_NroFactura(int nro_factura)
        {
            this.nro_factura = nro_factura;
        }

        public void Set_Fecha(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public void Set_NombreCliente(string nombre_cliente)
        {
            this.nombre_cliente = nombre_cliente;
        }

        public void Set_Domicilio(string domicilio)
        {
            this.domicilio = domicilio;
        }

        public void Set_Mail(string mail)
        {
            this.mail = mail;
        }

        public void Set_Dni(int dni)
        {
            this.dni = dni;
        }

        public void Set_Telefono(string telefono)
        {
            this.telefono = telefono;
        }

        private DateTime hoy()
        {
            DateTime hoy = DateTime.Now;
            return hoy;
        }

        public DetalleFactura crearDetalleFactura(Producto p, int cantidad)
        {
            if (!p.puedoVender(cantidad))
            {
                throw new Exception("No hay suficiente stock");
            }
            int nro_factura = this.nro_factura;
            string nombre = p.GetNombre();
            int id_producto = p.GetIdProducto();
            double precio = p.GetPrecio();
            DetalleFactura df = new DetalleFactura(nro_factura,nombre,id_detalle_factura,id_producto,precio,cantidad);
            id_detalle_factura++;
            return df;
         }

        public Boolean Add(DetalleFactura df)
        {
            items.Add(df);
            return true;
        }

        public Boolean Add(Producto p, int cantidad)
        {
            try
            {
                DetalleFactura df = this.crearDetalleFactura(p, cantidad);
                return this.Add(df);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                return false;

            }            
        }

        public Double calcularTotal()
        {
            double total = 0;
            foreach (DetalleFactura df in items)
            {
                total = total + df.subtotal();
            }
            return total;
        }

        internal IEnumerable<DetalleFactura> Get_DetalleFactura()
        {
            return items;
        }
    }



}
