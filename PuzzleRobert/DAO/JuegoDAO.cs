using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Npgsql;
using System.Data;
using System.Drawing;
using System.IO;

namespace DAO
{
    public class JuegoDAO
    {
        /// <summary>
        /// metodo para reguistrar un nuevo juego
        /// </summary>
        /// <param name="juego">Objeto que se refiere al nuevo juego</param>
        /// <returns>retorna true si se registro de lo contrario false</returns>
        public bool RegistrarJuego(Juego juego)
        {

            try
            {


                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    ImagenDAO idao = new ImagenDAO();
                    juego.Foto.Id = idao.InsertarImagen(juego.Foto);
                    string sql = @"INSERT INTO juego(
                                descripcion, id_imagen, fecha_inicio, fecha_fin,
                                id_categoria, id_dimension, estado) VALUES (
                                :des, :ima, :fi, :ff, :cat, :dim, false) returning id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("ima", juego.Foto.Id);
                    cmd.Parameters.AddWithValue("des", juego.Descripcion);
                    cmd.Parameters.AddWithValue("fi", juego.FechaInicio);
                    cmd.Parameters.AddWithValue("ff", juego.FechaFinal);
                    cmd.Parameters.AddWithValue("cat", juego.Categoria.Id);
                    cmd.Parameters.AddWithValue("dim", juego.Dimension.Id);

                    juego.Id = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                    return juego.Id > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// gertea la imagen que se va a usar para jugar
        /// </summary>
        /// <param name="juegos">Objeto que se refiere al juego que el usualiro eligio</param>
        /// <returns>retorna una imagen</returns>
        public Image GetImagen(Juego juegos)
        {
            NpgsqlConnection con = null;
            Image image = null;
            int id = 1; 
            Imagen imagen = null;
            try
            {
                Participante p = new Participante();
                using (con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    string sql = @"Select id_imagen
                                    FROM juego WHERE descripcion = :des;";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("des", juegos.Descripcion);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        id = reader.GetInt32(0);
                    }
                    con.Close();
                    con.Open();
                    sql = @"SELECT imagen
                            FROM imagen
                            WHERE id = :id;";
                    cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("id", id);
                    byte[] foto = new byte[0];
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        foto = (byte[])reader["imagen"];
                        MemoryStream stream = new MemoryStream(foto);
                        image = Image.FromStream(stream);
                    }

                }
                con.Close();
                return image;
            }
            catch (Exception ex)
            {
                 throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// obtiene la descripcion de los juegos
        /// </summary>
        /// <param name="participante">participante que va a jugar</param>
        /// <returns>list con las descripciones de juego</returns>
        public List<Juego> Cargarcombox(Participante participante)
        {
            List<Juego> juego = new List<Juego>();

            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
            {
                con.Open();
                string sql = @"Select juego.id, juego.descripcion, dimension.dimension,
                                   categoria.categoria, imagen.imagen from juego 
                                   inner join dimension on juego.id_dimension=dimension.id_dimension
                                   inner join categoria on juego.id_categoria=categoria.id_categoria 
                                   inner join imagen on juego.id_imagen=imagen.id
                                   WHERE juego.estado = true AND 
                                   dimension.id_dimension = :iddim;";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("iddim", participante.Dimension.Id);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Juego d = new Juego()
                    {
                        Id = reader.GetInt32(0),
                        Descripcion = reader.GetString(1)
                    };
                    juego.Add(d);
                }
            }
            return juego;
        }

        /// <summary>
        /// Carga los juego que el participante tiene permitido jugar
        /// </summary>
        /// <param name="participante">el participante que quiere jugar</param>
        /// <returns> objeto con la informacion de los juegos</returns>
        public object Cargarjuegos(Participante participante)
        {
            try
            {
                DataTable dt = new DataTable();
                DataSet tablaDS = new DataSet();

                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    string sql = @"Select juego.descripcion, dimension.dimension,
                                   categoria.categoria, imagen.imagen from juego 
                                   inner join dimension on juego.id_dimension=dimension.id_dimension
                                   inner join categoria on juego.id_categoria=categoria.id_categoria 
                                   inner join imagen on juego.id_imagen=imagen.id
                                   WHERE juego.estado = true AND 
                                   dimension.id_dimension = :iddim;";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("iddim", participante.Dimension.Id);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter();
                    da.SelectCommand = cmd;

                    da.Fill(tablaDS);
                    dt = tablaDS.Tables[0];
                    con.Close();

                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Hace que un juego no publicado sea publico
        /// </summary>
        /// <param name="j">juego que se quiere publicar</param>
        public void HacerJuegoBublico(Juego j)
        {
            NpgsqlConnection con = null;
            try
            {
                using (con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();

                    string sql = @"UPDATE public.juego
                            SET estado = :est
                            WHERE id = :jid;";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("jid", j.Id);
                    cmd.Parameters.AddWithValue("est", true);
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// carga la lista de juegos
        /// </summary>
        /// <returns>retorna un list de los juegois disponibles</returns>
        public List<Juego> CargarJuegos()
        {
            List<Juego> juego = new List<Juego>();
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
            {
                con.Open();
                string sql = @"select 
                                *
                               from 
                                juego";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Juego j = new Juego()
                    {
                        Id = reader.GetInt32(0),
                        Descripcion = reader.GetString(1),
                    };
                    juego.Add(j);
                }
                con.Close();
            }
            return juego;
        }
    }
}
