using LenguajeDB.Conexion;
using LenguajeDB.Utilidad;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LenguajeDB.Funciones.Sucursales
{
    public class Funciones_Sucursal
    {
        public bool RegistrarSucursal(string nombre, string ubicacion, string telefono)
        {
            bool exito = false;

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())  // Obtener conexión abierta
                {
                    using (OracleCommand command = new OracleCommand("registrarSucursal", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        // Parámetros de entrada
                        command.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = nombre;
                        command.Parameters.Add("p_ubicacion", OracleDbType.Varchar2).Value = ubicacion;
                        command.Parameters.Add("p_telefono", OracleDbType.Varchar2).Value = telefono;

                        // Ejecutar el procedimiento almacenado
                        command.ExecuteNonQuery();

                        exito = true;
                    }
                }
            }
            catch (OracleException ex)
            {
                // Manejar excepciones de Oracle
                Console.WriteLine("Error de Oracle: " + ex.Message);
                exito = false;
            }
            catch (Exception ex)
            {
                // Otros errores
                Console.WriteLine("Error: " + ex.Message);
                exito = false;
            }

            return exito;
        }

        public DataSet ObtenerSucursales()
        {
            DataSet dataSet = new DataSet();

            using (OracleConnection connection = Conn.GetOpenConnection())
            {
                try
                {
                    OracleCommand cmd = new OracleCommand("SELECT * FROM DBADMIN.VISTASUCURSALES", connection);
                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);

                    adapter.Fill(dataSet, "Sucursales");

                    return dataSet;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los datos de la vista", ex);
                }
                finally
                {
                    connection.Close();
                }
            }
        }


        // Método para modificar una sucursal y devolver un booleano
        public bool ModificarSucursal(int idSucursal, string nombre, string ubicacion, string telefono)
        {
            bool exito = false;
         

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                

                    using (OracleCommand command = new OracleCommand("modificarSucursal", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        // Parámetros de entrada
                        command.Parameters.Add("p_id_sucursal", OracleDbType.Int32).Value = idSucursal;
                        command.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = nombre;
                        command.Parameters.Add("p_ubicacion", OracleDbType.Varchar2).Value = ubicacion;
                        command.Parameters.Add("p_telefono", OracleDbType.Varchar2).Value = telefono;

                        // Ejecutar el procedimiento almacenado
                        command.ExecuteNonQuery();

                        exito = true;
                    }
                }
            }
            catch (OracleException ex)
            {
                // Manejar excepciones de Oracle
                Console.WriteLine("Error de Oracle: " + ex.Message);
                exito = false;
            }
            catch (Exception ex)
            {
                // Otros errores
                Console.WriteLine("Error: " + ex.Message);
                exito = false;
            }

            return exito;
        }

        public bool EliminarSucursal(int idSucursal)
        {
            bool exito = false;

            // Query para llamar al procedimiento almacenado
            string sqlQuery = "eliminarSucursal";

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        // Parámetros de entrada
                        command.Parameters.Add("p_id_sucursal", OracleDbType.Int32).Value = idSucursal;

                        // Ejecutar el procedimiento almacenado
                        command.ExecuteNonQuery();

                        exito = true;
                    }
                }
            }
            catch (OracleException ex)
            {
                // Manejar excepciones de Oracle
                Console.WriteLine("Error de Oracle: " + ex.Message);
                exito = false;
            }
            catch (Exception ex)
            {
                // Otros errores
                Console.WriteLine("Error: " + ex.Message);
                exito = false;
            }

            return exito;
        }
    }
}
