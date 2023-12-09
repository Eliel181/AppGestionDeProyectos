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
    public class EmpleadoController
    {
        EmpleadoDao empleadoDao = new EmpleadoDao();

        public bool LoginEmpleado(string username, string password)
        {
            return empleadoDao.loginEmpleado(username, password);
        }

        public DataTable ListarEmpleados(string cTexto)
        {
            return empleadoDao.listarEmpleados(cTexto);
        }

        public string CrearEmpleado(Empleado oEm)
        {
            return empleadoDao.crearEmpleado(oEm);
        }

        public string EliminarEmpleado(int idEmpleado)
        {
            string Rpta = empleadoDao.eliminarEmpleado(idEmpleado);
            return Rpta;
        }

        public string EditarEmpleado(Empleado oEm)
        {
            return empleadoDao.editarEmpleado(oEm);
        }
    }
}
