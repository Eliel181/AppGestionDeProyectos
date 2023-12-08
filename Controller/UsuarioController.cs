using Entities;
using Model.Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UsuarioController
    {
        UsuarioDao usuarioDao = new UsuarioDao();

        public bool LoginUsuario(string  username, string password)
        {
            return usuarioDao.loginUsuario(username, password);
        }

        public DataTable ListarUsuarios(string cTexto)
        {
            return usuarioDao.listarUsuarios(cTexto);
        }

        public string CrearUsuario(Usuario oU)
        {
            return usuarioDao.crearUsuario(oU);
        }
    }
}
