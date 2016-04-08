using DAO;
using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class JuegoBO
    {
        private JuegoDAO jgDAO;
        public Image[,] MatrizImg { get; set; }
        public Image[,] MatrizImgTemp { get; set; }
        private Random rnd;

        /// <summary>
        /// Método para verificar si un usuario ganó o no.
        /// </summary>
        /// <returns>True en caso de que resolviera el puzzle correctamente</returns>
        public bool Estado()
        {
            bool estado = false;
            for (int i = 0; i < MatrizImg.GetLength(0); i++)
            {
                for (int j = 0; j < MatrizImg.GetLength(1); j++)
                {
                    if (MatrizImg[i, j] == MatrizImgTemp[i, j])
                    {
                        estado = true;
                    }
                    else
                    {
                        estado = false;
                        break;
                    }
                }
            }
            return estado;
        }

        /// <summary>
        /// Método usado para desordenar la matriz de imágenes.
        /// </summary>
        public void Desordenar()
        {
            rnd = new Random();
            for (int i = 0; i < MatrizImg.GetLength(0); i++)
            {
                for (int j = 0; j < MatrizImg.GetLength(1); j++)
                {
                    int x = rnd.Next(MatrizImg.GetLength(0));
                    int y = rnd.Next(MatrizImg.GetLength(1));

                    Image temp = MatrizImgTemp[i, j];
                    MatrizImgTemp[i, j] = MatrizImgTemp[x, y];
                    MatrizImgTemp[x, y] = temp;
                }
            }
        }
        /// <summary>
        /// Método que valida el juego y si es correcto lo inserta.
        /// </summary>
        /// <param name="juego">Recibe el juego por parametro</param>
        /// <returns>el juego ya insertado con ID</returns>
        public Juego InsertarJuego(Juego juego)
        {
            if (juego.Categoria == null)
            {
                throw new Exception("Debe seleccionar una categoría");
            }
            if (juego.Dimension == null)
            {
                throw new Exception("Debe seleccionar una Dimension");
            }
            if (String.IsNullOrEmpty(juego.Descripcion))
            {
                throw new Exception("Debe ingresar una descripción");
            }
            if (juego.Fecha_inicio > juego.Fecha_fin)
            {
                throw new Exception("La fecha final no puede ser antes que la de inicio.");
            }
            if ((juego.Fecha_inicio < DateTime.Today) || (juego.Fecha_fin < DateTime.Today) )
            {
                throw new Exception("No puede seleccionar fechas anteriores a la actual");
            }
            if (juego.Imagen.Img==null)
            {
                throw new Exception("Debe insertar una imagen");
            }
            jgDAO = new JuegoDAO();
            return jgDAO.InsertarJuego(juego);
        }

        /// <summary>
        /// Método que obtiene el juego del participante.
        /// </summary>
        /// <param name="us">Usuario conectado</param>
        /// <returns>Lista de jeugos</returns>
        public List<Juego> ObtJuegosUsuario(Usuario us)
        {
            jgDAO = new JuegoDAO();
            return jgDAO.ObtJuegoUs(us);
        }

        /// <summary>
        /// Método que obtiene juegos desde la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Juego> ObtJuegos()
        {
            jgDAO = new JuegoDAO();
            return jgDAO.ObtJuegos();
        }

        /// <summary>
        /// Método para publicar juego
        /// </summary>
        /// <param name="jg"></param>
        public void PublicarJuego(Juego jg)
        {
            jgDAO.PublicarJuego(jg);
        }
    }
}
