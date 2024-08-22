using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenguajeDB.Utilidad
{
    public class Totales
    {
        private decimal total;
        public Totales(List<LineaFactura> lineasFactura)
        {
            Total = CalcularTotal(lineasFactura);
        }

        public decimal Total { get => total; set => total = value; }

        public decimal CalcularTotal(List<LineaFactura> lineasFactura)
        {
            decimal total = 0;
            foreach (var linea in lineasFactura)
            {
                total += linea.Subtotal;
            }
            return total;
        }
    }
}
