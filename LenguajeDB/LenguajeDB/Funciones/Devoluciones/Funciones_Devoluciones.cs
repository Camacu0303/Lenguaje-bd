using LenguajeDB.Conexion;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LenguajeDB.Funciones.Devoluciones
{
    public class Funciones_Devolucion
    {

        public bool EliminarDevolucion(int idDevolucion)
        {
            bool exito = false;

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    using (OracleCommand command = new OracleCommand("pkg_devoluciones.eliminardevolucion", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        // Parámetro de entrada
                        command.Parameters.Add("p_id_devolucion", OracleDbType.Int32).Value = idDevolucion;

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

        public bool RegistrarDevolucion(int idDetalle, DateTime fechaDevolucion, int cantidad, string motivo)
        {
            bool exito = false;

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    using (OracleCommand command = new OracleCommand("pkg_devoluciones.registrardevolucion", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        // Parámetros de entrada
                        command.Parameters.Add("p_id_detalle", OracleDbType.Int32).Value = idDetalle;
                        command.Parameters.Add("p_fecha_devolucion", OracleDbType.Date).Value = fechaDevolucion;
                        command.Parameters.Add("p_cantidad", OracleDbType.Int32).Value = cantidad;
                        command.Parameters.Add("p_motivo", OracleDbType.Varchar2).Value = motivo;

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

        public bool ModificarDevolucion(int idDevolucion, DateTime fechaDevolucion, int cantidad, string motivo)
        {
            bool exito = false;

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    using (OracleCommand command = new OracleCommand("pkg_devoluciones.modificardevolucion", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        // Parámetros de entrada
                        command.Parameters.Add("p_id_devolucion", OracleDbType.Int32).Value = idDevolucion;
                        command.Parameters.Add("p_fecha_devolucion", OracleDbType.Date).Value = fechaDevolucion;
                        command.Parameters.Add("p_cantidad", OracleDbType.Int32).Value = cantidad;
                        command.Parameters.Add("p_motivo", OracleDbType.Varchar2).Value = motivo;

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

        public DataSet ObtenerDevoluciones()
        {
            DataSet dataSet = new DataSet();

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    string sqlQuery = "SELECT * FROM DEVOLUCION";

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
