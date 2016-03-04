using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuzzleCapas.Entidades;
using PuzzleCapas.DAO;

namespace PuzzleCapas.BO
{
    public class ParticipanteBO
    {
        private ParticipanteDAO udao;

        public ParticipanteBO()
        {
            udao = new ParticipanteDAO();
        }

        public Participante Autentificiar(Participante participante)
        {
            return udao.Autentificar(participante);
        }

        public bool Registrar(Participante participante, string contrasenaDos)
        {
            if (String.IsNullOrEmpty(participante.Usuario))
            {
                throw new Exception("El usuario es requerido");
            }
            if (participante.Categorias.Count <= 0)
            {
                throw new Exception("Seleccione al menos una categoría");
            }
            if (!participante.Contrasena.Equals(contrasenaDos))
            {
                throw new Exception("Contraseñas no coinciden");
            }

            return udao.Registrar(participante);
        }

        internal bool Editar(Participante participante, string contrasenaDos, int i)
        {
            if (String.IsNullOrEmpty(participante.Usuario))
            {
                throw new Exception("El usuario es requerido");
            }
            if (participante.Categorias.Count <= 0)
            {
                throw new Exception("Seleccione al menos una categoría");
            }
            if (!participante.Contrasena.Equals(contrasenaDos))
            {
                throw new Exception("Contraseñas no coinciden");
            }

            return udao.Editar(participante, i);
        }
    }
}
