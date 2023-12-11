using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Tarea
    {
        public int IdTarea { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        
        public DateTime FechaInicio { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Estado { get; set; }
        public string Prioridad { get; set; }
        public int IdEmpleado { get; set; }
        public int IdUsuario { get; set; }
        public int IdProyecto { get; set; }

        public Tarea()
        {
        }
    }
}
