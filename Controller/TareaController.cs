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
    }
}
