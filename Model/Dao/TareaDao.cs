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
    public class TareaDao
    {

        public DataTable listarTareas(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "spListarTareas";
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

        public string crearTarea(Tarea oTa)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);

                Sqltarea = "spCrearTarea";

                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("pNombre", oTa.Nombre);
                Comando.Parameters.AddWithValue("pDescripcion", oTa.Descripcion);
                Comando.Parameters.AddWithValue("pFechaInicio", oTa.FechaInicio);
                Comando.Parameters.AddWithValue("pFechaVencimiento", oTa.FechaVencimiento);
                Comando.Parameters.AddWithValue("pPrioridad", oTa.Prioridad);
                Comando.Parameters.AddWithValue("pIdEmpleado", oTa.IdEmpleado);
                Comando.Parameters.AddWithValue("pIdUsuario", oTa.IdUsuario);
                Comando.Parameters.AddWithValue("pIdProyecto", oTa.IdProyecto);


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
    }
}
