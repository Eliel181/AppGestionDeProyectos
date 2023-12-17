using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class UsuarioDao
    {
        public bool loginUsuario(string user, string pass)
        {
            MySqlDataReader Resultado;
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                string sql_tarea = "spLoginUsuario";
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(sql_tarea, SqlCon);

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("pLoginName", user);
                Comando.Parameters.AddWithValue("pPassword", pass);
                Comando.CommandTimeout = 60;

                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                if (Resultado.HasRows)
                {
                    while (Resultado.Read())
                    {
                        UsuarioCache.IdUsuario = Resultado.GetInt32(0);
                        UsuarioCache.Dni = Resultado.GetString(1);
                        UsuarioCache.Apellido = Resultado.GetString(2);
                        UsuarioCache.Nombre = Resultado.GetString(3);
                        UsuarioCache.Role = Resultado.GetString(4);
                        UsuarioCache.Telefono = Resultado.GetString(5);
                        UsuarioCache.FechaNacimiento = Resultado.GetDateTime(6);
                        UsuarioCache.LoginName = Resultado.GetString(7);
                        UsuarioCache.Password = Resultado.GetString(8);
                        UsuarioCache.Estado = Resultado.GetBoolean(9);
                        UsuarioCache.Habilidad = Resultado.GetString(10);
                        UsuarioCache.Foto = (byte[])Resultado.GetValue(11);
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); }
        }

        public DataTable listarUsuariosOpcion(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "spListarUsuariosOpcion";
                MySqlCommand Comando = new MySqlCommand(sql_tarea, SqlCon);
                Comando.CommandTimeout = 60;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("cTexto", cTexto);
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); }
        }

        public DataTable listarUsuariosActivos(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "spListarUsuariosActivos";
                MySqlCommand Comando = new MySqlCommand(sql_tarea, SqlCon);
                Comando.CommandTimeout = 60;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("cTexto", cTexto);
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); }
        }

        public string crearUsuario(Usuario oUs)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);

                Sqltarea = "spCrearUsuario";

                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("pDni", oUs.Dni);
                Comando.Parameters.AddWithValue("pApellido", oUs.Apellido);
                Comando.Parameters.AddWithValue("pNombre", oUs.Nombre);
                Comando.Parameters.AddWithValue("pRole", oUs.Role);
                Comando.Parameters.AddWithValue("pTelefono", oUs.Telefono);
                Comando.Parameters.AddWithValue("pFechaNacimiento", oUs.FechaNacimiento);
                Comando.Parameters.AddWithValue("pLoginName", oUs.LoginName);
                Comando.Parameters.AddWithValue("pPassword", oUs.Password);
                Comando.Parameters.AddWithValue("pEstado", oUs.Estado);
                Comando.Parameters.AddWithValue("pHabilidad", oUs.Habilidad);
                Comando.Parameters.AddWithValue("pFoto", oUs.Foto);

                Comando.CommandText = Sqltarea;

                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo ingresar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string eliminarUsuario(int idUsuario)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {

                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Sqltarea = "spEliminarUsuario";

                Comando.Parameters.AddWithValue("pIdUsuario", idUsuario);
                Comando.CommandText = Sqltarea;

                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {

                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }


        public string editarUsuario(Usuario oUs)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);

                Sqltarea = "spActualizarUsuario";

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("pIdUsuario", oUs.IdUsuario);
                Comando.Parameters.AddWithValue("pDni", oUs.Dni);
                Comando.Parameters.AddWithValue("pApellido", oUs.Apellido);
                Comando.Parameters.AddWithValue("pNombre", oUs.Nombre);
                Comando.Parameters.AddWithValue("pRole", oUs.Role);
                Comando.Parameters.AddWithValue("pTelefono", oUs.Telefono);
                Comando.Parameters.AddWithValue("pFechaNacimiento", oUs.FechaNacimiento);
                Comando.Parameters.AddWithValue("pLoginName", oUs.LoginName);
                Comando.Parameters.AddWithValue("pPassword", oUs.Password);
                Comando.Parameters.AddWithValue("pEstado", oUs.Estado);
                Comando.Parameters.AddWithValue("pHabilidad", oUs.Habilidad);
                Comando.Parameters.AddWithValue("pFoto", oUs.Foto);

                Comando.CommandText = Sqltarea;

                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo Actualizar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
    }
}
