using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Npgsql;

namespace DAO
{
    public class JuegoDAO
    {
        private ImagenDAO imgDAO;

        /// <summary>
        /// Método para insertar un nuevo juego en la base de datos.
        /// </summary>
        /// <param name="juego">Recibe el juego a insertar</param>
        /// <returns>El juego ya insertado con la ID</returns>
        public Juego InsertarJuego(Juego juego)
        {
            NpgsqlTransaction tran = null;
            imgDAO = new ImagenDAO();
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    tran = con.BeginTransaction();
                    juego.Imagen.Id = imgDAO.InsertarImagen(juego.Imagen, con);
                    string sql = @"Insert into Juego(descripcion, id_imagen, fecha_inicio, fecha_fin, id_categoria, id_dimension, estado) 
                    VALUES (:descripcion, :id_imagen, :fecha_inicio, :fecha_fin, :id_categoria, :id_dimension, :estado) RETURNING ID";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("descripcion", juego.Descripcion);
                    cmd.Parameters.AddWithValue("id_imagen", juego.Imagen.Id);
                    cmd.Parameters.AddWithValue("fecha_inicio", juego.Fecha_inicio);
                    cmd.Parameters.AddWithValue("fecha_fin", juego.Fecha_fin);
                    cmd.Parameters.AddWithValue("id_categoria", juego.Categoria.Id);
                    cmd.Parameters.AddWithValue("id_dimension", juego.Dimension.Id);
                    cmd.Parameters.AddWithValue("estado", juego.Estado);
                    juego.Id = Convert.ToInt32(cmd.ExecuteScalar());
                    tran.Commit();
                    return juego;
                }
            }
            catch (Exception e)
            {
                if (tran != null)
                {
                    tran.Rollback();
                }
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Método que obtiene los juegos en los que puede participar el usuario
        /// </summary>
        /// <param name="us">Usuario a verificar</param>
        /// <returns>Lista juegos</returns>
        public List<Juego> ObtJuegoUs(Usuario us)
        {
            List<Juego> juegos = new List<Juego>();
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
            {
                string sql = @"select j.* from juego j inner join participante_categoria pc on pc.id_categoria = j.id_categoria and j.estado = true inner join participante p
                on p.id = pc.id_participante and j.id_dimension = p.id_dimension and p.id =:id";
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("id", us.Id);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Juego juego = new Juego();
                    juego.Id = reader.GetInt32(0);
                    juego.Descripcion = reader.GetString(1);
                    juego.Imagen.Id = reader.GetInt32(2);
                    juego.Fecha_inicio = reader.GetDateTime(3);
                    juego.Fecha_fin = reader.GetDateTime(4);
                    juego.Categoria.Id = reader.GetInt32(5);
                    juego.Dimension.Id = reader.GetInt32(6);
                    juego.Estado = reader.GetBoolean(7);
                    juegos.Add(juego);
                }
                return juegos;
            }
        }

        /// <summary>
        /// Método para publicar juego, cambia el estado a true.
        /// </summary>
        /// <param name="jg">recibe el juego por parametro</param>
        public void PublicarJuego(Juego jg)
        {
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    string sql = @"UPDATE juego
                                SET estado=:estado
                                WHERE id= :id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("estado", true);
                    cmd.Parameters.AddWithValue("id", jg.Id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("¡Error a la hora de actualizar datos!");
            }
        }

        /// <summary>
        /// Método que obtiene la lista de juegos desde la base de datos.
        /// </summary>
        /// <returns>Una lista con todos los juegos que esta en la BD</returns>
        public List<Juego> ObtJuegos()
        {
            List<Juego> juegos = new List<Juego>();
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    string sql = @"SELECT * FROM juego WHERE estado = false";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Juego juego = new Juego();
                        juego.Id = reader.GetInt32(0);
                        juego.Descripcion = reader.GetString(1);
                        juego.Imagen.Id = reader.GetInt32(2);
                        juego.Fecha_inicio = reader.GetDateTime(3);
                        juego.Fecha_fin = reader.GetDateTime(4);
                        juego.Categoria.Id = reader.GetInt32(5);
                        juego.Dimension.Id = reader.GetInt32(6);
                        juego.Estado = reader.GetBoolean(7);
                        juegos.Add(juego);
                    }
                    return juegos;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
