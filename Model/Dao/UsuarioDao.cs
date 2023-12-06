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
    }
}
