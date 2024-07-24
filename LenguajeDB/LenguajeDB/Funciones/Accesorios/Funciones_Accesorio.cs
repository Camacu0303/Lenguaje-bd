using LenguajeDB.Conexion;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenguajeDB.Funciones.Accesorios
{
    public class Funciones_Accesorio
    {
        public bool EliminarAccesorio(int idAccesorio)
        {
            bool exito = false;

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    using (OracleCommand command = new OracleCommand("eliminarAccesorio", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        // Parámetro de entrada
                        command.Parameters.Add("p_id_accesorio", OracleDbType.Int32).Value = idAccesorio;

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

        // Método para registrar un nuevo accesorio
        public bool RegistrarAccesorio(string nombre, string descripcion, decimal precio, int stock, int idCategoria)
        {
            bool exito = false;

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    using (OracleCommand command = new OracleCommand("registrarAccesorio", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        // Parámetros de entrada
                        command.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = nombre;
                        command.Parameters.Add("p_descripcion", OracleDbType.Varchar2).Value = descripcion;
                        command.Parameters.Add("p_precio", OracleDbType.Decimal).Value = precio;
                        command.Parameters.Add("p_stock", OracleDbType.Int32).Value = stock;
                        command.Parameters.Add("p_id_categoria", OracleDbType.Int32).Value = idCategoria;

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

        // Método para modificar un accesorio existente
        public bool ModificarAccesorio(int idAccesorio, string nombre, string descripcion, decimal precio, int stock, int idCategoria)
        {
            bool exito = false;

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    using (OracleCommand command = new OracleCommand("modificarAccesorio", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        // Parámetros de entrada
                        command.Parameters.Add("p_id_accesorio", OracleDbType.Int32).Value = idAccesorio;
                        command.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = nombre;
                        command.Parameters.Add("p_descripcion", OracleDbType.Varchar2).Value = descripcion;
                        command.Parameters.Add("p_precio", OracleDbType.Decimal).Value = precio;
                        command.Parameters.Add("p_stock", OracleDbType.Int32).Value = stock;
                        command.Parameters.Add("p_id_categoria", OracleDbType.Int32).Value = idCategoria;

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

        // Método para cargar los datos de la vista VISTAACCESORIOS en un DataSet
        public DataSet ObtenerAccesorios()
        {
            DataSet dataSet = new DataSet();

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    string sqlQuery = "SELECT * FROM VISTAACCESORIOS";

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
    }
}
