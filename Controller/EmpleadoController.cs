using Model.Dao;
using System;
using System.Collections.Generic;
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
    }
}
