using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleCapas.Entidades
{
    public class Categoria
    {
        /// <summary>
        /// propertis de la categoria
        /// </summary>
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }

    }
}
