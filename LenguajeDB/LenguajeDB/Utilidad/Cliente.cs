using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenguajeDB.Utilidad
{
    public class Cliente
    {
        public int ID { get; set; }
        public string NombreCompleto { get; set; }
        public string Numero { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public Cliente(int id, string nombreCompleto, string numero, string correo, string telefono)
        {
            ID = id;
            NombreCompleto = nombreCompleto;
            Numero = numero;
            Correo = correo;
            Telefono = telefono;
        }
    }
}
