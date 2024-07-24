using LenguajeDB.Conexion;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenguajeDB.Funciones.Categoria
{
    public class Funciones_Categoria
    {
        public DataSet ObtenerCategorias()
        {
            DataSet dataSet = new DataSet();

            using (OracleConnection connection = Conn.GetOpenConnection())
            {
                try
                {
                    OracleCommand cmd = new OracleCommand("SELECT * FROM DBADMIN.VISTACATEGORIAS", connection);
                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);

                    adapter.Fill(dataSet, "Categorias");

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

        // Método para modificar una categoría y devolver un booleano
        public bool ModificarCategoria(int idCategoria, string nombre, int activo, string descripcion)
        {
            bool exito = false;

            // Query para llamar al procedimiento almacenado
            string sqlQuery = "BEGIN modificarCategoria(:p_id_categoria, :p_nombre, :p_activo, :p_descripcion); END;";

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                    {
                        command.CommandType = CommandType.Text;

                        // Parámetros de entrada
                        command.Parameters.Add("p_id_categoria", OracleDbType.Int32).Value = idCategoria;
                        command.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = nombre;
                        command.Parameters.Add("p_activo", OracleDbType.Int32).Value = activo;
                        command.Parameters.Add("p_descripcion", OracleDbType.Varchar2).Value = descripcion;

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

        // Método para registrar una nueva categoría y devolver un booleano
        public bool RegistrarCategoria(string nombre, int activo, string descripcion)
        {
            bool exito = false;

            // Query para llamar al procedimiento almacenado
           

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    using (OracleCommand command = new OracleCommand("registrarCategoria", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Parámetros de entrada
                        command.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = nombre;
                        command.Parameters.Add("p_activo", OracleDbType.Int32).Value = activo;
                        command.Parameters.Add("p_descripcion", OracleDbType.Varchar2).Value = descripcion;

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
        public bool EliminarCategoria(int idCategoria)
        {
            bool exito = false;

            // Query para llamar al procedimiento almacenado
            string sqlQuery = "eliminarCategoria";

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        // Parámetros de entrada
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
    }

}
