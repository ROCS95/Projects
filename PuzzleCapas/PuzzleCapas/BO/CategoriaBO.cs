using PuzzleCapas.DAO;
using PuzzleCapas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleCapas.BO
{
    public class CategoriaBO
    {
        private CategoriaDAO ddao;

        public CategoriaBO()
        {
            ddao = new CategoriaDAO();
        }
        public List<Categoria> CargarCategorias()
        {
            return ddao.CargarCategorias();
        }
    }
}
