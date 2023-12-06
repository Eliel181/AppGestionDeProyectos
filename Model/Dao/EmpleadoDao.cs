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
    }
}
