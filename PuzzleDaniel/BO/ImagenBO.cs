using DAO;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class ImagenBO
    {
        private ImagenDAO imD;

        /// <summary>
        /// Método que obtiene la Imagen por id
        /// </summary>
        /// <param name="id_foto">id de la imagen a buscar</param>
        /// <returns>La imagen almacenada en la base de datos</returns>
        public Imagen ObtImg(int id_foto)
        {
            try
            {
                imD = new ImagenDAO();
                return imD.ObtenerImagen(id_foto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
