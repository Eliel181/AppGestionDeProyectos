using Entities;
using Model.Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    
    public class TareaController
    {
        TareaDao tareaDao = new TareaDao();

        public DataTable ListarTareas(string cTexto)
        {
            return tareaDao.listarTareas(cTexto);
        }

        public DataTable ListarTareasPorProyecto(int idProyecto)
        {
            return tareaDao.listarTareasPorProyecto(idProyecto);
        }

        public string CrearTarea(Tarea oTa)
        {
            return tareaDao.crearTarea(oTa);
        }

        public int ObtenerTareasPorProyecto(int idProyecto)
        {
            return tareaDao.obtenerTotalTareasPorProyecto(idProyecto);
        }

        public DataTable ListarTareasPorEmpleado(int idEmpleado)
        {
            return tareaDao.listarTareasPorEmpleado(idEmpleado);
        }

        public DataTable ListarTareasPorVencimiento(int idEmpleado)
        {
            return tareaDao.listarTareasPorVencimiento(idEmpleado);
        }

        public DataTable ListarTareasPorEstado(int idEmpleado, string estado)
        {
            return tareaDao.listarTareasPorEstado(idEmpleado, estado);
        }

        public DataTable ListarTareasPorPrioridad(int idEmpleado, string prioridad)
        {
            return tareaDao.listarTareasPorPrioridad(idEmpleado, prioridad);
        }

        public String ActualizarEstadoDeTarea(int idTarea, string estado)
        {
            return tareaDao.actualizarEstadoDeTarea(idTarea, estado);
        }
    }
}
