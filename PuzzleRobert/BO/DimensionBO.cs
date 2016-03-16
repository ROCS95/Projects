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
        private DimensionDAO ddao;

        public DimensionBO()
        {
            ddao = new DimensionDAO();
        }
        /// <summary>
        /// metodo que llama al metodo ddao.CargarDimensiones();
        /// </summary>
        /// <returns>retorna un list tipo Dimencion</returns>
        public List<Dimension> CargarDimensiones()
        {
            return ddao.CargarDimensiones();
        }
        /// <summary>
        /// llama al metodo ddao.InsertDimencion(text1, text2);
        /// </summary>
        /// <param name="text1"></param>
        /// <param name="text2"></param>
        public void InsertDimencion(string text1, string text2)
        {
            ddao.InsertDimencion(text1, text2);
        }
    }
}
