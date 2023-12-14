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

        public DataTable listarTareasPorProyecto(int idProyecto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "spListarTareasPorProyecto";
                MySqlCommand Comando = new MySqlCommand(sql_tarea, SqlCon);
                Comando.CommandTimeout = 60;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("pIdProyecto", idProyecto);
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

        public int obtenerTotalTareasPorProyecto(int idProyecto)
        {
            // Creación de objetos y variables
            MySqlConnection sqlCon = new MySqlConnection();
            MySqlParameter mySqlParameter = new MySqlParameter("@totalTareas", MySqlDbType.Int32);

            try
            {
                // Establecer la conexión a la base de datos
                sqlCon = Conexion.getInstancia().CrearConexion();

                // Definir el nombre del procedimiento almacenado
                string sqlTarea = "spTareasPorProyecto";
                MySqlCommand comando = new MySqlCommand(sqlTarea, sqlCon);
                comando.CommandTimeout = 60;
                comando.CommandType = CommandType.StoredProcedure;

                // Configurar parámetro de entrada
                comando.Parameters.AddWithValue("pIdProyecto", idProyecto);

                // Configurar parámetro de salida
                mySqlParameter.Direction = ParameterDirection.Output;
                comando.Parameters.Add(mySqlParameter);

                // Abrir la conexión y ejecutar el procedimiento almacenado
                sqlCon.Open();
                comando.ExecuteReader();
                

                // Obtener el valor de salida del parámetro
                int valorDeSalida = Convert.ToInt32(mySqlParameter.Value);
                return valorDeSalida;
            }
            catch (Exception ex)
            {
                // Manejar excepciones y propagarlas
                throw ex;
            }
            finally
            {
                // Cerrar la conexión en caso de estar abierta
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
        }
    }
}
