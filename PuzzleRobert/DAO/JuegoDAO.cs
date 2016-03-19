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
                    juego.Imagen.Id = idao.InsertarImagen(juego.Imagen, con);
                    string sql = @"INSERT INTO juego(
                                descripcion, id_imagen, fecha_inicio, fecha_fin,
                                id_categoria, id_dimension, estado) VALUES (
                                :des, :ima, :fi, :ff, :cat, :dim, false) returning id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("ima", juego.Imagen.Id);
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
    }
}
