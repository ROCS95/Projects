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
        /// <summary>
        /// metodo que se conecta a la vase de datos para optener los datos de la 
        /// tabla Dimensiones
        /// </summary>
        /// <returns>retorna un list tipo Dimencion</returns>
        public List<Dimension> CargarDimensiones()
        {
            List<Dimension> dimensiones = new List<Dimension>();
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
            {
                con.Open();
                string sql = @"select 
                                id_dimension, dimension
                               from 
                                dimension";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Dimension d = new Dimension()
                    {
                        Id = reader.GetInt32(0),
                        Descripcion = reader.GetString(1),
                        
                    };
                    dimensiones.Add(d);
                }
                con.Close();
            }
            return dimensiones;
            
        }

        /// <summary>
        /// incerta una nueva dimencion el la base de datos
        /// </summary>
        /// <param name="text1"></param>
        /// <param name="text2"></param>
        public void InsertDimencion(string text1, string text2)
        {
            string dim = text1 + "x" + text2;
            try
            {

                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    string sql = @"INSERT INTO public.dimension(dimension) VALUES (:dim);";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("dim", dim);

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
