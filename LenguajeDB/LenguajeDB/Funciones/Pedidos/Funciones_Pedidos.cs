using LenguajeDB.Conexion;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenguajeDB.Funciones.Pedidos
{
    public class Funciones_Pedidos
    {
        public enum EstadoPedido
        {
            Pendiente = 1,
            EnEntrega = 2,
            Finalizado = 3
        }

        public DataSet FiltrarPedidos(int? idPedido, String idCliente)
        {
            DataSet dataSet = new DataSet();

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    using (OracleCommand command = new OracleCommand("FILTRARPEDIDOS", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Parámetros de entrada
                        command.Parameters.Add("p_id_pedido", OracleDbType.Int32).Value = (object)idPedido ?? DBNull.Value;
                        command.Parameters.Add("p_id_cliente", OracleDbType.Varchar2).Value = (object)idCliente ?? DBNull.Value;

                        // Parámetro de salida
                        OracleParameter p_resultado = new OracleParameter("p_resultado", OracleDbType.RefCursor);
                        p_resultado.Direction = ParameterDirection.Output;
                        command.Parameters.Add(p_resultado);

                        // Ejecutar el comando y cargar el resultado en un DataSet
                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            adapter.Fill(dataSet, "Pedidos");
                        }
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

        public bool RegistrarLineasPedido(int idPedido, List<DetallePedido> Productos)
        {
            bool exito = false;


            using (OracleConnection connection = Conn.GetOpenConnection())
            {
                foreach (var producto in Productos)
                {
                    using (OracleCommand command = new OracleCommand("REGISTRARDETALLEPEDIDO", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        // Añadir los parámetros de entrada para el detalle del pedido
                        command.Parameters.Add("p_id_pedido", OracleDbType.Int32).Value = idPedido;
                        command.Parameters.Add("p_id_producto", OracleDbType.Int32).Value = producto.IdProducto;
                        command.Parameters.Add("p_cantidad", OracleDbType.Int32).Value = producto.Cantidad;
                        command.Parameters.Add("p_precio", OracleDbType.Decimal).Value = producto.Precio;

                        // Ejecutar el procedimiento para cada producto en la lista
                        command.ExecuteNonQuery();
                    }
                }
            }


            return exito;
        }
        public bool RegistrarPedido(int? idCliente, List<DetallePedido> Productos)
        {
            bool exito = false;


            using (OracleConnection connection = Conn.GetOpenConnection())
            {
                using (OracleCommand command = new OracleCommand("REGISTRARPEDIDO", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    // Añadir los parámetros de entrada
                    command.Parameters.Add("p_id_cliente", OracleDbType.Int32).Value = idCliente;
                    command.Parameters.Add("p_fecha_pedido", OracleDbType.Date).Value = DateTime.Now;
                    command.Parameters.Add("p_estado", OracleDbType.Int32).Value = EstadoPedido.Pendiente;

                    // Añadir el parámetro de salida
                    OracleParameter outParam = new OracleParameter("p_id_pedido", OracleDbType.Int32);
                    outParam.Direction = System.Data.ParameterDirection.Output;
                    command.Parameters.Add(outParam);

                    // Ejecutar el procedimiento
                    command.ExecuteNonQuery();

                    // Obtener el valor del parámetro de salida
                    OracleDecimal oracleDecimalValue = (OracleDecimal)command.Parameters["p_id_pedido"].Value;

                    // Luego, convertir OracleDecimal a int? (nullable int)
                    int? idPedido = oracleDecimalValue.IsNull ? (int?)null : oracleDecimalValue.ToInt32();

                    if (idPedido != null)
                    {
                        RegistrarLineasPedido((int)idPedido, Productos);
                    }
                    Console.WriteLine($"ID del pedido insertado: {idPedido}");
                }
            }

            return exito;
        }
        public DataSet FiltrarDetallePedido(int? idPedido)
        {
            DataSet dataSet = new DataSet();

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    using (OracleCommand command = new OracleCommand("FILTRARDETALLEPEDIDO", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Parámetro de entrada
                        command.Parameters.Add("p_id_pedido", OracleDbType.Int32).Value = (object)idPedido ?? DBNull.Value;

                        // Parámetro de salida
                        OracleParameter p_resultado = new OracleParameter("p_resultado", OracleDbType.RefCursor);
                        p_resultado.Direction = ParameterDirection.Output;
                        command.Parameters.Add(p_resultado);

                        // Ejecutar el comando y cargar el resultado en un DataSet
                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            adapter.Fill(dataSet, "DetallePedido");
                        }
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
