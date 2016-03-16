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
        public void InsertCategoria(string text)
        {
            ddao.InsertCategoria(text);
        }
    }
}
