using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenguajeDB.Utilidad
{
    public class Sesion
    {
        // Propiedades del usuario
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public bool Activo { get; set; }
        public int IdRol { get; set; }

        public int IdUsuario { get; set; }
        // Instancia Singleton
        private static Sesion instancia;

        // Objeto para asegurar la concurrencia
        private static readonly object bloqueo = new object();

        // Constructor privado para evitar instanciación externa
        private Sesion()
        {
        }

        // Método estático para obtener la instancia Singleton
        public static Sesion ObtenerInstancia()
        {
            lock (bloqueo)
            {
                if (instancia == null)
                {
                    instancia = new Sesion();
                }
                return instancia;
            }
        }

        public Sesion(string username, string password, string nombre, string apellido, string correo, string telefono, bool activo, int idRol, int idUsuario)
        {
            Username = username;
            Password = password;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Telefono = telefono;
            Activo = activo;
            IdRol = idRol;
            IdUsuario = idUsuario;
        }

        // Método para establecer los datos del usuario

    }

}
