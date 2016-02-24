using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleCapas.Entidades
{
    public class Participante
    {
        public int Id { get; set; }
        public Dimension Dimension { get; set; }
        public Imagen Imagen { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public List<Categoria> Categorias { get; set; }
    }
}
