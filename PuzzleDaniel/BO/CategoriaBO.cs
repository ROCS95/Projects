using DAO;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class CategoriaBO
    {
        private CategoriaDAO catDAO;

        /// <summary>
        /// Método para Obtener Categorías desde CategoriaDAO
        /// </summary>
        /// <returns>Lista de categorias</returns>
        public List<Categoria> ObtCat()
        {
            try
            {
                catDAO = new CategoriaDAO();
                return catDAO.ObtCat();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        /// <summary>
        /// Método que obtiene las categorías seleccionadas por un usuario.
        /// </summary>
        /// <param name="us">Usuario completo</param>
        /// <returns>Lista de categorías seleccionadas por un usuario</returns>
        public List<Categoria> ObtCatSeleccionada(Usuario us)
        {
            try
            {
                catDAO = new CategoriaDAO();
                return catDAO.ObtCatSeleccionada(us);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        /// <summary>
        /// Método que llama al DAO la acción para borrar una categoría
        /// </summary>
        /// <param name="id_cat">Id de la categoría a eliminar</param>
        /// <returns>True en caso de que la borre.</returns>
        public bool BorrarCat(int id_cat)
        {
            try
            {
                return catDAO.BorrarCat(id_cat);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        /// <summary>
        /// Método para que envia la categoria al DAO para ser insertada
        /// </summary>
        /// <param name="c">Recibe categoria</param>
        public void Insertar(Categoria c)
        {
            try
            {
                catDAO.Insertar(c);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
