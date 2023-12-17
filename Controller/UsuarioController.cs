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

        public DataTable ListarUsuariosOpcion(string cTexto)
        {
            return usuarioDao.listarUsuariosOpcion(cTexto);
        }

        public DataTable ListarUsuariosActivos(string cTexto)
        {
            return usuarioDao.listarUsuariosActivos(cTexto);
        }

        public string CrearUsuario(Usuario oU)
        {
            return usuarioDao.crearUsuario(oU);
        }

        public string EliminarUsuario(int idUsuario)
        {
            string Rpta = usuarioDao.eliminarUsuario(idUsuario);
            return Rpta;
        }

        public string EditarUsuario(Usuario oUs)
        {
            return usuarioDao.editarUsuario(oUs);
        }
    }
}
