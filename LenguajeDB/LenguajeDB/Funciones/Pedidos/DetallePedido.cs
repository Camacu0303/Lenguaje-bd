using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenguajeDB.Funciones.Pedidos
{
    public class DetallePedido
    { 
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

  
        public DetallePedido(int idDetalle, int idPedido, int idProducto, int cantidad, decimal precio)
        {
            IdProducto = idProducto;
            Cantidad = cantidad;
            Precio = precio;  
        }
    }
}
