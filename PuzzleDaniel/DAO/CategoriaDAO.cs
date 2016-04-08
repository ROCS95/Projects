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
        private Categoria categoria;

        /// <summary>
        /// Método que obtiene las categorías desde la basa de datos
        /// </summary>
        /// <returns>Lista de categorías</returns>
        public List<Categoria> ObtCat()
        {
            try
            {
                List<Categoria> cat = new List<Categoria>();
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    string sql = @"select id_categoria, categoria
                from categoria";
                    con.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        categoria = new Categoria();
                        categoria.Id = reader.GetInt32(0);
                        categoria.Categ = reader.GetString(1);
                        cat.Add(categoria);
                    }
                    return cat;
                }
            }
            catch (NpgsqlException)
            {
                throw new Exception("Problemas al conectar con el servidor.");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        /// <summary>
        /// Método que borra una categoria de la base de datos
        /// </summary>
        /// <param name="id_cat">Id de la categoria a borrar</param>
        /// <returns>True en caso de que la borre</returns>
        public bool BorrarCat(int id_cat)
        {
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    string sql = @"DELETE FROM Categoria
                                WHERE id_categoria=:id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("id", id_cat);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (NpgsqlException)
            {
                throw new Exception("Problemas al conectar con el servidor.");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Método que inserta categoría en la base de datos
        /// </summary>
        /// <param name="c">Recibe categoría</param>
        public void Insertar(Categoria c)
        {
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    string sql = @"insert into categoria(categoria)
                    values (:cat)";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("cat", c.Categ);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException)
            {
                throw new Exception("Problemas al conectar con el servidor.");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Método que obtiene categorías seleccionadas por el usuario.
        /// </summary>
        /// <param name="us">Usuario completo</param>
        /// <returns>Lista con las categorías seleccionadas por el usuario</returns>
        public List<Categoria> ObtCatSeleccionada(Usuario us)
        {
            try
            {
                List<Categoria> cat = new List<Categoria>();
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    string sql = @"select categoria.id_categoria, categoria from categoria INNER JOIN participante_categoria  
                ON participante_categoria.id_categoria = categoria.id_categoria
                WHERE participante_categoria.id_participante = :id";
                    con.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("id", us.Id);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        categoria = new Categoria();
                        categoria.Id = reader.GetInt32(0);
                        categoria.Categ = reader.GetString(1);
                        cat.Add(categoria);
                    }
                    return cat;
                }
            }
            catch (NpgsqlException)
            {
                throw new Exception("Problemas al conectar con el servidor.");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
