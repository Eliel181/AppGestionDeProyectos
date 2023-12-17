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
    public class ProyectoController
    {

        ProyectoDao proyectoDao = new ProyectoDao();

        public DataTable ListarProyectosOpcion(string cTexto)
        {
            return proyectoDao.listarProyectosOpcion(cTexto);
        }

        public string CrearEmpleado(Proyecto oPr)
        {
            return proyectoDao.crearProyecto(oPr);
        }

        public string EditarProyecto(Proyecto oPr)
        {
            return proyectoDao.editarProyecto(oPr);
        }

        public string EliminarProyecto(int idProyecto)
        {
            return proyectoDao.eliminarProyecto(idProyecto);
        }

        public int ObtenerPorcentajeDeProyecto(int idProyecto)
        {
            return proyectoDao.obtenerPorcentajeDeProyecto(idProyecto);
        }

        public int ConsultarEstadoDeProyecto(int idProyecto)
        {
            return proyectoDao.consultarEstadoDeProyecto(idProyecto);
        }

        public string FInalizarProyecto(int idProyecto)
        {
            return proyectoDao.finalizarProyecto(idProyecto);
        }
    }
}
