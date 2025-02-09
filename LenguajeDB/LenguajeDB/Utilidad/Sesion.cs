﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenguajeDB.Utilidad
{
    public enum Rol
    {
        Cliente = 1,
        Empleado = 2,
        Admin = 3
    }
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

        public Rol UserRole { get; set; }

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

        public Sesion(string username, string password, string nombre, string apellido, string correo, string telefono, bool activo, Rol Rol, int idUsuario)
        {
            Username = username;
            Password = password;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Telefono = telefono;
            Activo = activo;
            UserRole = Rol;
            IdUsuario = idUsuario;
        }


    }

}
