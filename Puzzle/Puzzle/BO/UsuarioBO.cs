using Puzzle.DAO;
using Puzzle.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle.BO
{
    class UsuarioBO
    {
        private UsuarioDAO udao;

        public UsuarioBO()
        {
            udao = new UsuarioDAO();
        }

        public Usuario AutentificarseUsuario(Usuario u)
        {
            return udao.Autentificar(u);
        }
        public Usuario InsertUsuario(Usuario u)
        {
            return udao.Insertar(u);
        }

        internal Usuario CargarUser(Usuario us)
        {
            return udao.CagraUser(us);
        }
    }
}
