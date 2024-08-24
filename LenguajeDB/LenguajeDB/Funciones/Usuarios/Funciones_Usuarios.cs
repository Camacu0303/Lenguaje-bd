using LenguajeDB.Conexion;
using LenguajeDB.Utilidad;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LenguajeDB.Funciones
{
    public class Funciones_Usuarios
    {
        public bool RegistrarUsuario(string username, string password, string nombre, string apellido, string correo, string telefono, Rol rol )
        {
            using (OracleConnection connection = Conn.GetOpenConnection())
            {
                try
                {
                    OracleCommand cmd = new OracleCommand("registrarusuario", connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Parámetros de entrada
                    cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                    cmd.Parameters.Add("p_password", OracleDbType.Varchar2).Value = password;
                    cmd.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = nombre;
                    cmd.Parameters.Add("p_apellido", OracleDbType.Varchar2).Value = apellido;
                    cmd.Parameters.Add("p_correo", OracleDbType.Varchar2).Value = correo;
                    cmd.Parameters.Add("p_telefono", OracleDbType.Varchar2).Value = telefono;
                    cmd.Parameters.Add("p_id_rol", OracleDbType.Int32).Value = (int) rol;
                    cmd.ExecuteNonQuery();
                    
                    Console.WriteLine("Usuario registrado correctamente en Oracle.");
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al registrar usuario en Oracle: " + ex.Message);
                    connection.Close();
                    throw;
                }
               
            }
        }
        public bool Login(string username, string password)
        {
            using (OracleConnection connection = Conn.GetOpenConnection())
            {
                try
                {
                    OracleCommand cmd = new OracleCommand("consultarUsuarioPorUsername", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros de entrada
                    cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                    cmd.Parameters.Add("p_password", OracleDbType.Varchar2).Value = password;

                    // Parámetro de salida (cursor)
                    cmd.Parameters.Add("p_resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    // Ejecutar el procedimiento almacenado
                    cmd.ExecuteNonQuery();

                    using (OracleDataReader reader = ((OracleRefCursor)cmd.Parameters["p_resultado"].Value).GetDataReader())
                    {
                        if (reader.Read())
                        {
                            if (Convert.ToBoolean(reader["activo"]) == false) {
                                MessageBox.Show("Usuario inactivo, contacte al administrador");
                                return false;
                            }
                            Sesion sesion = Sesion.ObtenerInstancia();
                            sesion.Activo = Convert.ToBoolean(reader["activo"]);
                            sesion.Username = reader["username"].ToString();
                            sesion.Password = reader["password"].ToString();
                            sesion.Nombre = reader["nombre"].ToString();
                            sesion.Apellido = reader["apellido"].ToString();
                            sesion.Correo = reader["correo"].ToString();
                            sesion.Telefono = reader["telefono"].ToString();
                            
                            sesion.UserRole= (Rol) Convert.ToInt32(reader["id_rol"]);
                            sesion.IdUsuario = Convert.ToInt32(reader["id_usuario"]);
                            reader.Close();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }

                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public bool ModificarUsuario(int idUsuario, string username, string nombre, string apellido, string correo, string telefono)
        {
            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("modificarUsuario", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        // Parámetros de entrada
                        cmd.Parameters.Add("p_id_usuario", OracleDbType.Int32, ParameterDirection.Input).Value = idUsuario;
                        cmd.Parameters.Add("p_username", OracleDbType.Varchar2, ParameterDirection.Input).Value = username;
                        cmd.Parameters.Add("p_nombre", OracleDbType.Varchar2, ParameterDirection.Input).Value = nombre;
                        cmd.Parameters.Add("p_apellido", OracleDbType.Varchar2, ParameterDirection.Input).Value = apellido;
                        cmd.Parameters.Add("p_correo", OracleDbType.Varchar2, ParameterDirection.Input).Value = correo;
                        cmd.Parameters.Add("p_telefono", OracleDbType.Varchar2, ParameterDirection.Input).Value = telefono;

                        // Parámetro de salida para verificar si se actualizó algún registro
                        OracleParameter pResultado = cmd.Parameters.Add("p_resultado", OracleDbType.Int32);
                        pResultado.Direction = ParameterDirection.ReturnValue;

                        // Ejecutar el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        // Verificar el resultado (número de filas afectadas)
                        int filasAfectadas = Convert.ToInt32(pResultado.Value);
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al modificar usuario en Oracle: " + ex.Message);
                throw;
            }
        }


        public bool DesactivarUsuario(int idUsuario)
        {
            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("desactivarUsuario", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        // Parámetros de entrada
                        cmd.Parameters.Add("p_id_usuario", OracleDbType.Int32, ParameterDirection.Input).Value = idUsuario;

                        // Ejecutar el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        Console.WriteLine($"Usuario con ID {idUsuario} desactivado correctamente en Oracle.");
                        return true; // Return true indicating success
                    }
                }
            }
            catch (OracleException ex)
            {
                if (ex.Number == 20001) // NO_DATA_FOUND
                {
                    Console.WriteLine("Error: Usuario no encontrado.");
                }
                else
                {
                    Console.WriteLine("Error al desactivar usuario en Oracle: " + ex.Message);
                }
                return false; // Return false indicating failure
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al desactivar usuario en Oracle: " + ex.Message);
                throw;
            }
        }

        public bool EliminarUsuario(int idUsuario)
        {
            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("eliminarUsuario", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        // Parámetros de entrada
                        cmd.Parameters.Add("p_id_usuario", OracleDbType.Int32, ParameterDirection.Input).Value = idUsuario;

                        // Ejecutar el procedimiento almacenado
                        int rowsAffected = cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar usuario en Oracle: " + ex.Message);
                throw;
            }
        }
        public DataSet LeerUsuarios(string username, string password)
        {
            using (OracleConnection connection = Conn.GetOpenConnection())
            {
                try
                {
                    OracleCommand cmd = new OracleCommand("consultarUsuarioPorUsername", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros de entrada
                    cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                    cmd.Parameters.Add("p_password", OracleDbType.Varchar2).Value = password;

                    // Parámetro de salida (cursor)
                    cmd.Parameters.Add("p_resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    // Crear el adaptador de datos
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        // Crear un DataSet para llenar con los datos
                        DataSet dataSet = new DataSet();

                        // Llenar el DataSet con los datos de la consulta
                        adapter.Fill(dataSet);

                        return dataSet;
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    // Aquí podrías registrar el error o manejarlo de acuerdo a tus necesidades
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public DataSet FiltrarUsuariosPorNombre(string nombre)
        {
            using (OracleConnection connection = Conn.GetOpenConnection())
            {
                try
                {
                    OracleCommand cmd = new OracleCommand("filtrarUsuariosPorNombre", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetro de entrada
                    cmd.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = (object)nombre ?? DBNull.Value;

                    // Parámetro de salida (cursor)
                    cmd.Parameters.Add("p_resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    // Crear el adaptador de datos
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        // Crear un DataSet para llenar con los datos
                        DataSet dataSet = new DataSet();

                        // Llenar el DataSet con los datos de la consulta
                        adapter.Fill(dataSet);

                        return dataSet;
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    // Aquí podrías registrar el error o manejarlo de acuerdo a tus necesidades
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public bool ModificarUsuario(int idUsuario, string username, string password, string nombre, string apellido, string correo, string telefono, int activo, int idRol)
        {
            bool exito = false;

            try
            {
                using (OracleConnection connection = Conn.GetOpenConnection())
                {
                    using (OracleCommand command = new OracleCommand("MODIFICARUSUARIO", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        // Parámetros de entrada
                        command.Parameters.Add("p_id_usuario", OracleDbType.Int32).Value = idUsuario;
                        command.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                        command.Parameters.Add("p_password", OracleDbType.Varchar2).Value = password;
                        command.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = nombre;
                        command.Parameters.Add("p_apellido", OracleDbType.Varchar2).Value = apellido;
                        command.Parameters.Add("p_correo", OracleDbType.Varchar2).Value = correo;
                        command.Parameters.Add("p_telefono", OracleDbType.Varchar2).Value = telefono;
                        command.Parameters.Add("p_activo", OracleDbType.Int32).Value = activo;
                        command.Parameters.Add("p_id_rol", OracleDbType.Int32).Value = idRol;

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
