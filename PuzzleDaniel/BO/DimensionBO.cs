using DAO;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class DimensionBO
    {
        private DimensionDAO dimDAO;
        /// <summary>
        /// Método para obtener dimensiones desde DimensionDAO
        /// </summary>
        /// <returns>Una lista de Dimensiones</returns>
        public List<Dimension> ObtDim()
        {
            try
            {
                dimDAO = new DimensionDAO();
                return dimDAO.ObtDim();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        /// <summary>
        /// Método que llama al DAO el método para borrar dimensión
        /// </summary>
        /// <param name="id_dim">Id de la dimensión a borrar</param>
        /// <returns>True en caso de que la borre.</returns>
        public bool BorrarDim(int id_dim)
        {
            try
            {
                dimDAO = new DimensionDAO();
                return dimDAO.BorrarDim(id_dim);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Método para Insertar dimensiones en la base de datos
        /// </summary>
        /// <param name="d">Recibe una dimensión</param>
        public void Insertar(Dimension d)
        {
            try
            {
                dimDAO = new DimensionDAO();
                dimDAO.Insertar(d);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Método que obtiene la dimension por medio de ID
        /// </summary>
        /// <param name="dim">Id de la dimension</param>
        /// <returns>La dimension obtenida</returns>
        public string ObtDim(int dim)
        {
            try
            {
                dimDAO = new DimensionDAO();
                return dimDAO.ObtDim(dim);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
