using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        public int Id { get; set; }
        public String Categ { get; set; }

        public override string ToString()
        {
            return Categ;
        }
    }
}
