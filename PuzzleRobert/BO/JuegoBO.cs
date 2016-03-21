using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAO;

namespace BO
{
    public class JuegoBO
    {
        JuegoDAO jdao = new JuegoDAO();
        public bool RegistrarJuego(Juego juego)
        {
            if (String.IsNullOrEmpty(juego.Descripcion))
            {
                throw new Exception("La descripcion es requerida");
            }
            if (juego.FechaInicio >= juego.FechaFinal)
            {
                throw new Exception("La fecha inicio no puede ser igual ni menor al fecha final");
            }
            return jdao.RegistrarJuego(juego);
        }

        public List<Juego> CargarJuegos()
        {
            return jdao.CargarJuegos();
        }

        public void HacerJuegoBublico(Juego j)
        {
            jdao.HacerJuegoBublico(j);
        }
    }
}
