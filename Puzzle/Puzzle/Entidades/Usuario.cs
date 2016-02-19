using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string User { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }
        public int IdImagen { get; set; }
        public int IdDimenciones { get; set; }
    }
}
