using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dimension
    {
        public int Id { get; set; }
        public string Dim { get; set; }

        public override string ToString()
        {
            return Dim;
        }
    }
}
