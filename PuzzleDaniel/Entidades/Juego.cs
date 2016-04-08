using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Juego
    {
        /// <summary>
        /// Constructor donde inicializa Categoría, Dimensión e Imagen
        /// </summary>
        public Juego()
        {
            Categoria = new Categoria();
            Dimension = new Dimension();
            Imagen = new Imagen();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public Imagen Imagen { get; set; }
        public DateTime Fecha_inicio { get; set; }
        public DateTime Fecha_fin { get; set; }
        public Categoria Categoria { get; set; }
        public Dimension Dimension { get; set; }
        public bool Estado { get; set; }


        public override string ToString()
        {
            return Descripcion;
        }
    }
}
