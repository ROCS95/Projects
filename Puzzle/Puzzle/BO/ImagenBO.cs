using Npgsql;
using Puzzle.DAO;
using Puzzle.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle.BO
{
    class ImagenBO
    {
        private ImagenDAO idao;

        public ImagenBO()
        {
            idao = new ImagenDAO();
        }

        internal void InsertImagen(byte[] binData)
        {
           idao.InsertImage(binData);
        }

        internal Image CagarImagen(Usuario u)
        {
            return idao.CargarImagen(u);
        }
    }
}
