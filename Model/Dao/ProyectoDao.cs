using Entities;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class ProyectoDao
    {

        public DataTable listarProyectosOpcion(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "spListarProyectosOpcion";
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

        public string crearProyecto(Proyecto oPr)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);

                Sqltarea = "spCrearProyecto";

                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("pNombre", oPr.Nombre);
                Comando.Parameters.AddWithValue("pDescripcion", oPr.Descripcion);
                Comando.Parameters.AddWithValue("pFechaInicio", oPr.FechaInicio);
                Comando.Parameters.AddWithValue("pFechaFinalizacion", oPr.FechaFinalizacion);
                

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


        public int obtenerPorcentajeDeProyecto(int idProyecto)
        {
            // Creación de objetos y variables
            MySqlConnection sqlCon = new MySqlConnection();
            MySqlParameter mySqlParameter = new MySqlParameter("@porcentaje", MySqlDbType.Int32);

            try
            {
                // Establecer la conexión a la base de datos
                sqlCon = Conexion.getInstancia().CrearConexion();

                // Definir el nombre del procedimiento almacenado
                string sqlTarea = "spObtenerPorcentajeDeProyecto";
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

        public int consultarEstadoDeProyecto(int idProyecto)
        {
            // Creación de objetos y variables
            MySqlConnection sqlCon = new MySqlConnection();
            MySqlParameter mySqlParameter = new MySqlParameter("@bandera", MySqlDbType.Int32);

            try
            {
                // Establecer la conexión a la base de datos
                sqlCon = Conexion.getInstancia().CrearConexion();

                // Definir el nombre del procedimiento almacenado
                string sqlTarea = "spConsultarEstadoDeProyecto";
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

        public string finalizarProyecto(int idProyecto)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {

                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Sqltarea = "spFinalizarProyecto";

                Comando.Parameters.AddWithValue("pIdProyecto", idProyecto);
                Comando.CommandText = Sqltarea;

                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo finalizar el proyecto";
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
