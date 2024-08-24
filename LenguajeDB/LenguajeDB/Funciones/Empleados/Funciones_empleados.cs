using LenguajeDB.Conexion;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenguajeDB.Funciones.Empleados
{
    public class Funciones_empleados
    {
        public bool RegistrarEmpleado(string nombre, string apellido, string correo, string telefono, int idSucursal, int activo)
        {
            bool exito = false;

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    using (OracleCommand command = new OracleCommand("REGISTRAREMPLEADO", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        
                        command.Parameters.Add("p_nombre", OracleDbType.Varchar2, 100).Value = nombre;
                        command.Parameters.Add("p_apellido", OracleDbType.Varchar2, 100).Value = apellido;
                        command.Parameters.Add("p_correo", OracleDbType.Varchar2, 200).Value = correo;
                        command.Parameters.Add("p_telefono", OracleDbType.Varchar2, 20).Value = telefono;
                        command.Parameters.Add("p_id_sucursal", OracleDbType.Int32).Value = idSucursal;
                        command.Parameters.Add("p_activo", OracleDbType.Int32).Value = activo;
                       

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
        public bool ModificarEmpleado(
    int idEmpleado,
    string nombre,
    string apellido,
    string correo,
    string telefono,
    int idSucursal,
    int activo
    )
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


    }
}
