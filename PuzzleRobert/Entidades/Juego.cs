using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Juego
    {
        public string Descripcion { get; set; }
        public Dimension Dimension { get; set; }
        public Imagen Foto { get; set; }
        public Categoria Categoria { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }

    }
}
