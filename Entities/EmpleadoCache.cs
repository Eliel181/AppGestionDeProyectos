using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EmpleadoCache
    {
        public static int IdEmpleado { get; set; }
        public static string Dni { get; set; }
        public static string Apellido { get; set; }
        public static string Nombre { get; set; }
        public static string Role { get; set; }
        public static string Telefono { get; set; }
        public static DateTime FechaNacimiento { get; set; }
        public static string LoginName { get; set; }
        public static string Password { get; set; }
        public static bool Estado { get; set; }
        public static string Habilidad { get; set; }
        public static byte[] Foto { get; set; }
    }
}
