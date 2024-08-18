using LenguajeDB.Conexion;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenguajeDB.Funciones.Clientes
{
    public class Funciones_Clientes
    {
        public bool RegistrarCliente(string nombre, string apellido, string telefono, string correo, string direccion, int activo)
        {
            bool exito = false;

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    using (OracleCommand command = new OracleCommand("REGISTRARCLIENTE", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Input parameters
                        command.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = nombre;
                        command.Parameters.Add("p_apellido", OracleDbType.Varchar2).Value = apellido;
                        command.Parameters.Add("p_telefono", OracleDbType.Varchar2).Value = telefono;
                        command.Parameters.Add("p_correo", OracleDbType.Varchar2).Value = correo;
                        command.Parameters.Add("p_direccion", OracleDbType.Varchar2).Value = direccion;
                        command.Parameters.Add("p_activo", OracleDbType.Int32).Value = activo;

                        // Execute the stored procedure
                        command.ExecuteNonQuery();

                        exito = true;
                    }
                }
            }
            catch (OracleException ex)
            {
                // Handle Oracle exceptions
                Console.WriteLine("Oracle Error: " + ex.Message);
                exito = false;
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                Console.WriteLine("Error: " + ex.Message);
                exito = false;
            }

            return exito;
        }

        // Method to retrieve clientes using a ref cursor
        public DataSet ObtenerClientes()
        {
            DataSet dataSet = new DataSet();

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    string sqlQuery = "SELECT * FROM VISTACLIENTES";

                    using (OracleDataAdapter adapter = new OracleDataAdapter(sqlQuery, connection))
                    {
                        adapter.Fill(dataSet);
                    }
                }
            }
            catch (OracleException ex)
            {
                // Manejar excepciones de Oracle
                Console.WriteLine("Error de Oracle: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Otros errores
                Console.WriteLine("Error: " + ex.Message);
            }

            return dataSet;
        }

        // Method to modify an existing cliente
        public bool ModificarCliente(int idCliente, string nombre, string apellido, string telefono, string correo, string direccion, int activo)
        {
            bool exito = false;

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    using (OracleCommand command = new OracleCommand("MODIFICARCLIENTE", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Input parameters
                        command.Parameters.Add("p_id_cliente", OracleDbType.Int32).Value = idCliente;
                        command.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = nombre;
                        command.Parameters.Add("p_apellido", OracleDbType.Varchar2).Value = apellido;
                        command.Parameters.Add("p_telefono", OracleDbType.Varchar2).Value = telefono;
                        command.Parameters.Add("p_correo", OracleDbType.Varchar2).Value = correo;
                        command.Parameters.Add("p_direccion", OracleDbType.Varchar2).Value = direccion;
                        command.Parameters.Add("p_activo", OracleDbType.Int32).Value = activo;

                        // Execute the stored procedure
                        command.ExecuteNonQuery();

                        exito = true;
                    }
                }
            }
            catch (OracleException ex)
            {
                // Handle Oracle exceptions
                Console.WriteLine("Oracle Error: " + ex.Message);
                exito = false;
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                Console.WriteLine("Error: " + ex.Message);
                exito = false;
            }

            return exito;
        }

        // Method to delete a cliente
        public bool EliminarCliente(int idCliente)
        {
            bool exito = false;

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    using (OracleCommand command = new OracleCommand("ELIMINARCLIENTE", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Input parameter
                        command.Parameters.Add("p_id_cliente", OracleDbType.Int32).Value = idCliente;

                        // Execute the stored procedure
                        command.ExecuteNonQuery();

                        exito = true;
                    }
                }
            }
            catch (OracleException ex)
            {
                // Handle Oracle exceptions
                Console.WriteLine("Oracle Error: " + ex.Message);
                exito = false;
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                Console.WriteLine("Error: " + ex.Message);
                exito = false;
            }

            return exito;
        }
    }
}
