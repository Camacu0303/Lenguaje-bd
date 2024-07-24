using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
namespace LenguajeDB.Conexion
{
    public class Conn
    {
        private static OracleConnectionStringBuilder connectionStringBuilder;

        // Constructor que recibe los parámetros de conexión
        public Conn()
        {
            connectionStringBuilder = new OracleConnectionStringBuilder
            {
                UserID = "DbAdmin",
                Password = "Password",
                DataSource = "(DESCRIPTION =    (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))    (CONNECT_DATA =      (SERVER = DEDICATED)      (SERVICE_NAME = orcl.localdomain)    )  )"
            };
        }

        // Método para obtener y abrir una conexión Oracle
        public static OracleConnection GetOpenConnection()
        {
            Console.WriteLine(connectionStringBuilder.ToString());
            OracleConnection connection = new OracleConnection(connectionStringBuilder.ConnectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Conexión exitosa a Oracle");
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a Oracle: " + ex.Message);
                connection.Dispose();
                throw;
            }
        }
    }
}