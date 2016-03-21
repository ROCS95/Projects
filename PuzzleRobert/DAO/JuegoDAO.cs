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
        public bool RegistrarJuego(Juego juego)
        {
            NpgsqlTransaction tran = null;
            try
            {


                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    tran = con.BeginTransaction();
                    ImagenDAO idao = new ImagenDAO();
                    juego.Foto.Id = idao.InsertarImagen(juego.Foto, con);
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

                    tran.Commit();
                    return juego.Id > 0;
                }
            }
            catch (Exception ex)
            {
                if (tran != null)
                {
                    tran.Rollback();
                }
                throw new Exception(ex.Message);
            }
        }

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
