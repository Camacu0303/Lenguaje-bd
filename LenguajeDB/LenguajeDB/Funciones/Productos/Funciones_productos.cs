using LenguajeDB.Conexion;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenguajeDB.Funciones.Productos
{
    public class Funciones_productos
    {
        public DataSet ConsultarProductos()
        {
            DataSet dataSet = new DataSet();

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    string sqlQuery = "SELECT * FROM VISTAPRODUCTOS";

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

        public bool EliminarProducto(int idProducto)
        {
            bool exito = false;

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    using (OracleCommand command = new OracleCommand("ELIMINARPRODUCTO", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Parámetro de entrada
                        command.Parameters.Add("p_id_producto", OracleDbType.Int32).Value = idProducto;

                        command.ExecuteNonQuery();
                        exito = true;
                    }
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Error de Oracle: " + ex.Message);
                exito = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                exito = false;
            }

            return exito;
        }
        public bool ModificarProducto(int idProducto, string descripcion, decimal precio, int stock, int idCategoria, int idSucursal, int activo)
        {
            bool exito = false;

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    using (OracleCommand command = new OracleCommand("MODIFICARPRODUCTO", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Parámetros de entrada
                        command.Parameters.Add("p_id_producto", OracleDbType.Int32).Value = idProducto;
                        command.Parameters.Add("p_descripcion", OracleDbType.Varchar2).Value = descripcion;
                        command.Parameters.Add("p_precio", OracleDbType.Decimal).Value = precio;
                        command.Parameters.Add("p_stock", OracleDbType.Int32).Value = stock;
                        command.Parameters.Add("p_id_categoria", OracleDbType.Int32).Value = idCategoria;
                        command.Parameters.Add("p_id_sucursal", OracleDbType.Int32).Value = idSucursal;
                        command.Parameters.Add("p_activo", OracleDbType.Int32).Value = activo;

                        command.ExecuteNonQuery();
                        exito = true;
                    }
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Error de Oracle: " + ex.Message);
                exito = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                exito = false;
            }

            return exito;
        }
        public bool RegistrarProducto(string descripcion, decimal precio, int stock, int idCategoria, int idSucursal, int activo)
        {
            bool exito = false;

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    using (OracleCommand command = new OracleCommand("REGISTRARPRODUCTO", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Parámetros de entrada
                        command.Parameters.Add("p_descripcion", OracleDbType.Varchar2).Value = descripcion;
                        command.Parameters.Add("p_precio", OracleDbType.Decimal).Value = precio;
                        command.Parameters.Add("p_stock", OracleDbType.Int32).Value = stock;
                        command.Parameters.Add("p_id_categoria", OracleDbType.Int32).Value = idCategoria;
                        command.Parameters.Add("p_id_sucursal", OracleDbType.Int32).Value = idSucursal;
                        command.Parameters.Add("p_activo", OracleDbType.Int32).Value = activo;

                        command.ExecuteNonQuery();
                        exito = true;
                    }
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Error de Oracle: " + ex.Message);
                exito = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                exito = false;
            }

            return exito;
        }
        public DataSet FiltrarProducto(int? idProducto, string descripcion)
        {
            DataSet dataSet = new DataSet();

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("FiltrarProductos", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("p_id_producto", OracleDbType.Int32).Value = idProducto.HasValue ? (object)idProducto.Value : DBNull.Value;
                        cmd.Parameters.Add("p_descripcion", OracleDbType.Varchar2).Value = string.IsNullOrEmpty(descripcion) ? DBNull.Value : (object)descripcion;
                        cmd.Parameters.Add("cur_resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        OracleDataAdapter da = new OracleDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        return ds;
                    }
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Error de Oracle: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return dataSet;
        }
    }
}
