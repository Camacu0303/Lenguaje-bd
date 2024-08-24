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
        public bool EliminarEmpleado(int idEmpleado)
        {
            bool exito = false;

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    using (OracleCommand command = new OracleCommand("ELIMINAREMPLEADO", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        // Parameter for ID_EMPLEADO
                        command.Parameters.Add("p_id_empleado", OracleDbType.Int32).Value = idEmpleado;

                        // Execute the stored procedure
                        command.ExecuteNonQuery();

                        exito = true;
                    }
                }
            }
            catch (OracleException ex)
            {
                // Handle Oracle exceptions
                Console.WriteLine("Error de Oracle: " + ex.Message);
                exito = false;
            }
            catch (Exception ex)
            {
                // Handle other errors
                Console.WriteLine("Error: " + ex.Message);
                exito = false;
            }

            return exito;
        }
        public bool ModificarEmpleado(
    int idEmpleado,
    string nombre,
    string apellido,
    string correo,
    string telefono,
    int idSucursal,
    int activo,
    int idUsuario)
        {
            bool exito = false;

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    using (OracleCommand command = new OracleCommand("MODIFICAREMPLEADO", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        // Parameters for the stored procedure
                        command.Parameters.Add("p_id_empleado", OracleDbType.Int32).Value = idEmpleado;
                        command.Parameters.Add("p_nombre", OracleDbType.Varchar2, 100).Value = nombre;
                        command.Parameters.Add("p_apellido", OracleDbType.Varchar2, 100).Value = apellido;
                        command.Parameters.Add("p_correo", OracleDbType.Varchar2, 200).Value = correo;
                        command.Parameters.Add("p_telefono", OracleDbType.Varchar2, 20).Value = telefono;
                        command.Parameters.Add("p_id_sucursal", OracleDbType.Int32).Value = idSucursal;
                        command.Parameters.Add("p_activo", OracleDbType.Int32).Value = activo;
                        command.Parameters.Add("p_id_usuario", OracleDbType.Int32).Value = idUsuario;

                        // Execute the stored procedure
                        command.ExecuteNonQuery();

                        exito = true;
                    }
                }
            }
            catch (OracleException ex)
            {
                // Handle Oracle exceptions
                Console.WriteLine("Error de Oracle: " + ex.Message);
                exito = false;
            }
            catch (Exception ex)
            {
                // Handle other errors
                Console.WriteLine("Error: " + ex.Message);
                exito = false;
            }

            return exito;
        }
        public DataSet ObtenerEmpleados()
        {
            DataSet dataSet = new DataSet();

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    string sqlQuery = "SELECT * FROM VISTAEMPLEADOS";

                    using (OracleDataAdapter adapter = new OracleDataAdapter(sqlQuery, connection))
                    {
                        adapter.Fill(dataSet);
                    }
                }
            }
            catch (OracleException ex)
            {
                // Handle Oracle exceptions
                Console.WriteLine("Error de Oracle: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other errors
                Console.WriteLine("Error: " + ex.Message);
            }

            return dataSet;
        }


    }


}
