using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenguajeDB.Funciones.Clientes
{
    public class ClienteClass
    {
        private int id;
        private String Nombre;
        private String Apellido;
        private String numero;

        public int Id { get => id; set => id = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string Numero { get => numero; set => numero = value; }

        public ClienteClass(int id, string nombre, string apellido, string numero)
        {
            this.id = id;
            Nombre = nombre;
            Apellido = apellido;
            this.numero = numero;
        }

        public ClienteClass()
        {
        }
    }
}
