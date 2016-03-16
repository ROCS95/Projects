using Entidades;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CategoriaDAO
    {
        /// <summary>
        /// metodo que se conecta a la vase de datos para optener los datos de la 
        /// tabla categorias
        /// </summary>
        /// <returns>retorna un list tipo Categoria</returns>
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
        /// <summary>
        /// incerta una nueva categoria en la base de datos
        /// </summary>
        /// <param name="text"></param>
        public void InsertCategoria(string text)
        {
            try
            {

                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    string sql = @"INSERT INTO public.categoria(categoria) VALUES ( :cat);";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("cat", text);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
