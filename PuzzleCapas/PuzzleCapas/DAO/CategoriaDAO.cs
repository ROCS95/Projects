using Npgsql;
using PuzzleCapas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleCapas.DAO
{
    public class CategoriaDAO
    {
        public List<Categoria> CargarCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
            {
                con.Open();
                string sql = @"select 
                                id_categoria, categoria
                               from 
                                categoria";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Categoria d = new Categoria()
                    {
                        Id = reader.GetInt32(0),
                        Descripcion = reader.GetString(1)
                    };
                    categorias.Add(d);
                }
            }
            return categorias;
        }
    }
}
