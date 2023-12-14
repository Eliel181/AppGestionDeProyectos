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

        public int ObtenerPorcentajeDeProyecto(int idProyecto)
        {
            return proyectoDao.obtenerPorcentajeDeProyecto(idProyecto);
        }
    }
}
