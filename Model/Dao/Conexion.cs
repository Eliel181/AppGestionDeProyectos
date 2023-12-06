using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class Conexion
    {
        private string dataBase;
        private string servidor; //nombre del servidor
        private string puerto;
        private string usuario;
        private string clave;

        private static Conexion con = null;

        //constructor de esta clase

        public Conexion()
        {
            this.dataBase = "DB_GestionProyectos";
            this.servidor = "localhost";
            this.puerto = "3007";
            this.usuario = "root";
            this.clave = "2new.born2";
        }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection cadena = new MySqlConnection();
            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                                          "; port=" + this.puerto +
                                          "; username=" + this.usuario +
                                          "; password=" + this.clave +
                                          "; database=" + this.dataBase;
            }
            catch (Exception ex)
            {

                cadena = null;
                throw ex;
            }
            return cadena;
        }


        //este metodo me sirve para no tener varias instacias a la vez
        public static Conexion getInstancia()
        {
            if (con == null)//no tengo instacia
            {
                con = new Conexion();
            }

            return con;
        }
    }
}
