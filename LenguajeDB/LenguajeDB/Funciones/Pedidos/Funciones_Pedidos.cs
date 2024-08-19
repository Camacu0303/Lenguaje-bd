using LenguajeDB.Conexion;
using Oracle.ManagedDataAccess.Client;
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
        public DataSet FiltrarPedidos(int? idPedido, int? idCliente)
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
                        command.Parameters.Add("p_id_cliente", OracleDbType.Int32).Value = (object)idCliente ?? DBNull.Value;

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
}
}
