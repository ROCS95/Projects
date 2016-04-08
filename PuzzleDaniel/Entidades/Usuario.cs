using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        /// <summary>
        /// Constructor donde se inicializa Foto y Dimension
        /// </summary>
        public Usuario()
        {
            Foto = new Imagen();
            Dimension = new Dimension();
        }

        public string User { get; set; }
        public string Correo { get; set; }
        public string Pass { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public Imagen Foto { get; set; }
        public int Tipo { get; set; }
        public int Id { get; set; }
        public Dimension Dimension { get; set; }
        public List<Categoria> Categorias { get; set; }
    }
}
