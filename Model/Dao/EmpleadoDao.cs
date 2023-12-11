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
    public class EmpleadoDao
    {
        public bool loginEmpleado(string user, string pass)
        {
            MySqlDataReader Resultado;
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                string sql_tarea = "spLoginEmpleado";
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
                        EmpleadoCache.IdEmpleado = Resultado.GetInt32(0);
                        EmpleadoCache.Dni = Resultado.GetString(1);
                        EmpleadoCache.Apellido = Resultado.GetString(2);
                        EmpleadoCache.Nombre = Resultado.GetString(3);
                        EmpleadoCache.Role = Resultado.GetString(4);
                        EmpleadoCache.Telefono = Resultado.GetString(5);
                        EmpleadoCache.FechaNacimiento = Resultado.GetDateTime(6);
                        EmpleadoCache.LoginName = Resultado.GetString(7);
                        EmpleadoCache.Password = Resultado.GetString(8);
                        EmpleadoCache.Estado = Resultado.GetBoolean(9);
                        EmpleadoCache.Habilidad = Resultado.GetString(10);
                        EmpleadoCache.Foto = (byte[])Resultado.GetValue(11);
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

        public DataTable listarEmpleadosOpcion(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "spListarEmpleadosOpcion";
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

        public DataTable listarEmpleados(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "spListarEmpleados";
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


        public string crearEmpleado(Empleado oEm)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);

                Sqltarea = "spCrearEmpleado";

                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("pDni", oEm.Dni);
                Comando.Parameters.AddWithValue("pApellido", oEm.Apellido);
                Comando.Parameters.AddWithValue("pNombre", oEm.Nombre);
                Comando.Parameters.AddWithValue("pRole", oEm.Role);
                Comando.Parameters.AddWithValue("pTelefono", oEm.Telefono);
                Comando.Parameters.AddWithValue("pFechaNacimiento", oEm.FechaNacimiento);
                Comando.Parameters.AddWithValue("pLoginName", oEm.LoginName);
                Comando.Parameters.AddWithValue("pPassword", oEm.Password);
                Comando.Parameters.AddWithValue("pEstado", oEm.Estado);
                Comando.Parameters.AddWithValue("pHabilidad", oEm.Habilidad);
                Comando.Parameters.AddWithValue("pFoto", oEm.Foto);

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

        public string eliminarEmpleado(int idEmpleado)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {

                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Sqltarea = "spEliminarEmpleado";

                Comando.Parameters.AddWithValue("pIdEmpleado", idEmpleado);
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


        public string editarEmpleado(Empleado oEm)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);

                Sqltarea = "spActualizarEmpleado";

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("pIdEmpleado", oEm.IdEmpleado);
                Comando.Parameters.AddWithValue("pDni", oEm.Dni);
                Comando.Parameters.AddWithValue("pApellido", oEm.Apellido);
                Comando.Parameters.AddWithValue("pNombre", oEm.Nombre);
                Comando.Parameters.AddWithValue("pRole", oEm.Role);
                Comando.Parameters.AddWithValue("pTelefono", oEm.Telefono);
                Comando.Parameters.AddWithValue("pFechaNacimiento", oEm.FechaNacimiento);
                Comando.Parameters.AddWithValue("pLoginName", oEm.LoginName);
                Comando.Parameters.AddWithValue("pPassword", oEm.Password);
                Comando.Parameters.AddWithValue("pEstado", oEm.Estado);
                Comando.Parameters.AddWithValue("pHabilidad", oEm.Habilidad);
                Comando.Parameters.AddWithValue("pFoto", oEm.Foto);

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
