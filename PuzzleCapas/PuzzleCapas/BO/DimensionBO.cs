using PuzzleCapas.DAO;
using PuzzleCapas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleCapas.BO
{
    public class DimensionBO
    {
        private DimensionDAO ddao;

        public DimensionBO()
        {
            ddao = new DimensionDAO();
        }
        public List<Dimension> CargarDimensiones()
        {
            return ddao.CargarDimensiones();
        }
    }
}
