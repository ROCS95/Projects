using Npgsql;
using PuzzleCapas.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleCapas.DAO
{
    public class ImagenDAO
    {
        public int InsertarImagen(Imagen imagen)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
            {
                con.Open();
                string sql = @"INSERT INTO imagen(imagen) VALUES (:ima) returning id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

                MemoryStream stream = new MemoryStream();
                imagen.Foto.Save(stream, ImageFormat.Jpeg);
                byte[] pic = stream.ToArray();

                cmd.Parameters.AddWithValue("ima", pic);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public Imagen CargarFoto(int id_foto)
        {
            Imagen f = new Imagen();
            f.Id = id_foto;
            using (NpgsqlConnection cn = new NpgsqlConnection(Configuracion.CadenaConexion))
            {
                cn.Open();
                string sql = @"select imagen from imagen where id = :id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue(":id", id_foto);

                byte[] foto = new byte[0];
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    foto = (byte[])reader["imagen"];
                    MemoryStream stream = new MemoryStream(foto);
                    f.Foto = Image.FromStream(stream);
                }
                return f;
            }

        }
    }
}
