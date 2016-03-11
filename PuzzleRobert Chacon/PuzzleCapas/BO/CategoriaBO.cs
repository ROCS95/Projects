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
        /// <summary>
        /// metodo que llama al metodo CargarCategorias 
        /// </summary>
        /// <returns>retorna una lista tipo categoria</returns>
        public List<Categoria> CargarCategorias()
        {
            return ddao.CargarCategorias();
        }

        /// <summary>
        /// llam al metodo ddao.InsertCategoria(text);
        /// </summary>
        /// <param name="text"></param>
        internal void InsertCategoria(string text)
        {
            ddao.InsertCategoria(text);
        }
    }
}
