using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAO;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace BO
{
    public class JuegoBO
    {
        JuegoDAO jdao = new JuegoDAO();

        /// <summary>
        /// metodo para reguistrar un nuevo juego
        /// </summary>
        /// <param name="juego">Objeto que se refiere al nuevo juego</param>
        /// <returns>retorna true si se registro de lo contrario false</returns>
        public bool RegistrarJuego(Juego juego)
        {
            if (String.IsNullOrEmpty(juego.Descripcion))
            {
                throw new Exception("La descripcion es requerida");
            }
            if (juego.FechaInicio >= juego.FechaFinal)
            {
                throw new Exception("La fecha inicio no puede ser igual ni menor al fecha final");
            }
            return jdao.RegistrarJuego(juego);
        }

        /// <summary>
        /// cambia el tamaño de la imagen para ponerla en el puzzle
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public Bitmap Resize(Image img)
        {
            int w = 280;
            int h = 280;

            //create a new Bitmap the size of the new image
            Bitmap bmp = new Bitmap(w, h);
            //create a new graphic from the Bitmap
            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
            //draw the newly resized image
            graphic.DrawImage(img, 0, 0, w, h);
            //dispose and free up the resources
            graphic.Dispose();
            //return the image
            return bmp;
        }

        /// <summary>
        /// gertea la imagen que se va a usar para jugar
        /// </summary>
        /// <param name="juegos">Objeto que se refiere al juego que el usualiro eligio</param>
        /// <returns>retorna una imagen</returns>
        public Image GetImagen(Juego juegos)
        {
            return jdao.GetImagen(juegos);
        }

        /// <summary>
        /// devuelve un array de imagenes recortadas para poner en los botones del puzzle
        /// </summary>
        /// <param name="ToBeCropped">imagen que sera recortada</param>
        /// <param name="x">ancho de la imagen que se quiere optener</param>
        /// <param name="y">alto de la imagen que se quiere optener</param>
        /// <returns>list de imagenes recortadas</returns>
        public ArrayList ReturnCroppedList(Bitmap ToBeCropped, int x, int y)
        {
            ArrayList img_pieces = new ArrayList();
            int moveright = 0;
            int movedown = 0;


            for (int k = 0; k < 15; k++)
            {
                Bitmap piece = new Bitmap(x, y);

                for (int i = 0; i < x; i++)
                    for (int j = 0; j < y; j++)
                        piece.SetPixel(i, j, ToBeCropped.GetPixel(i + moveright, j + movedown));
                img_pieces.Add(piece);

                moveright += 70;

                if (moveright == 280) { moveright = 0; movedown += 70; }
                if (movedown == 280) { break; }

            }
            return img_pieces;
        }

        /// <summary>
        /// carga la lista de juegos
        /// </summary>
        /// <returns>retorna un list de los juegois disponibles</returns>
        public List<Juego> CargarJuegos()
        {
            return jdao.CargarJuegos();
        }

        /// <summary>
        /// Hace que un juego no publicado sea publico
        /// </summary>
        /// <param name="j">juego que se quiere publicar</param>
        public void HacerJuegoBublico(Juego j)
        {
            jdao.HacerJuegoBublico(j);
        }

        /// <summary>
        /// Carga los juego que el participante tiene permitido jugar
        /// </summary>
        /// <param name="participante">el participante que quiere jugar</param>
        /// <returns> objeto con la informacion de los juegos</returns>
        public object Cargarjuegos(Participante participante)
        {
            return jdao.Cargarjuegos(participante);
        }

        /// <summary>
        /// obtiene la descripcion de los juegos
        /// </summary>
        /// <param name="participante">participante que va a jugar</param>
        /// <returns>list con las descripciones de juego</returns>
        public List<Juego> Cargarcombox(Participante participante)
        {
            return jdao.Cargarcombox(participante);
        }

        /// <summary>
        /// hace un shuffle de un arry
        /// </summary>
        /// <param name="array">array que se quiere revolver</param>
        /// <returns>array revuelto</returns>
        public int[] Shuffle(int[] array)
        {
            Random r = new Random();

            int start = r.Next(1, array.Length);

            for (int i = 0; i < array.Length; i++)
                for (int j = start; j > 0; j--)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            return array;
        }
    }
}
