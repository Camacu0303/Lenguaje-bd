using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenguajeDB.Utilidad
{
    public class LineaFactura
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal
        {
            get { return Precio * Cantidad; }
        }

        public LineaFactura(int id, string descripcion, decimal precio, int cantidad)
        {
            ID = id;
            Descripcion = descripcion;
            Precio = precio;
            Cantidad = cantidad;
        }
    }
}
