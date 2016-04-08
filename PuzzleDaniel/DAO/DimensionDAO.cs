using Entidades;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DimensionDAO
    {
        private Dimension dim;

        /// <summary>
        /// Método que obtiene las dimensiones desde la base de datos..
        /// </summary>
        /// <returns>Lista de dimensiones</returns>
        public List<Dimension> ObtDim()
        {
            try
            {
                List<Dimension> listDim = new List<Dimension>();
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    string sql = @"select id_dimension, dimension
                from dimension";
                    con.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        dim = new Dimension();
                        dim.Id = reader.GetInt32(0);
                        dim.Dim = reader.GetString(1);
                        listDim.Add(dim);
                    }
                    return listDim;
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
        /// Método que inserta dimensión en la base de datos
        /// </summary>
        /// <param name="d">recibe una dimensión</param>
        public void Insertar(Dimension d)
        {
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    string sql = @"insert into dimension(dimension)
                    values (:dim)";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("dim", d.Dim);
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
        /// Método para obtener la dimension por medio de id
        /// </summary>
        /// <param name="dim">id de la dimension</param>
        /// <returns>Dimension obtenida</returns>
        public string ObtDim(int dim)
        {
            try
            {
                string dimension = "";
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    string sql = @"select dimension
                    from dimension where id_dimension =:id_dim";
                    con.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("id_dim", dim);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        dimension = reader.GetString(0);
                    }
                    return dimension;
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
        /// Método para borrar la dimensión desde de la base de datos.
        /// </summary>
        /// <param name="id_dim">Id de la dimensión a borrar</param>
        /// <returns>True en caso de que la borre</returns>
        public bool BorrarDim(int id_dim)
        {
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    string sql = @"DELETE FROM Dimension
                                WHERE id_dimension=:id_dimension";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("id_dimension", id_dim);
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
    }
}
