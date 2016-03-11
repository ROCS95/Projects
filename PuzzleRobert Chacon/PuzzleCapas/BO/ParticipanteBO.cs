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

        /// <summary>
        /// metodo que llama al metodo udao.Autentificar(participante);
        /// </summary>
        /// <param name="participante"></param>
        /// <returns> retorna un objeto tipo Participante</returns>
        public Participante Autentificiar(Participante participante)
        {
            return udao.Autentificar(participante);
        }

        /// <summary>
        /// verifica que los datos de regiestro no esten vacios y llama el metodo 
        /// udao.Registrar(participante)
        /// </summary>
        /// <param name="participante"></param>
        /// <param name="contrasenaDos"></param>
        /// <returns>retorna un boleano </returns>
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

        /// <summary>
        /// verifica que los espacios requeridos para editar un usuario
        /// no esten vascion y llama al metodo udao.Editar(participante, i);
        /// </summary>
        /// <param name="participante"></param>
        /// <param name="contrasenaDos"></param>
        /// <param name="i"></param>
        /// <returns>retorna un buleano</returns>
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
