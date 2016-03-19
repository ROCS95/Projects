using Entidades;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ImagenDAO
    {
        public ImagenDAO()
        {

        }



        /// <summary>
        /// se conecta a la base de datos para inc\sertar la imagen de un usuario
        /// </summary>
        /// <param name="imagen"></param>
        /// <returns>returna in int</returns>
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

        /// <summary>
        /// se conecta a la base de datos para optener la imagen de perfil del usuario
        /// conectado
        /// </summary>
        /// <param name="id_foto"></param>
        /// <returns>retona un objeto tipo Imagen</returns>
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
        /// <summary>
        /// se conecta a la base de datos para hacer un update a la imagen 
        /// de perfil de un usuario que esta siendo editado
        /// (aun no esta implementado)
        /// </summary>
        /// <param name="imagen"></param>
        /// <param name="id"></param>
        internal void EditarImagen(Imagen imagen, int id)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
            {
                con.Open();
                string sql = @"UPDATE imagen
                                imagen= :ima
                                WHERE id = :id;";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

                MemoryStream stream = new MemoryStream();
                imagen.Foto.Save(stream, ImageFormat.Jpeg);
                byte[] pic = stream.ToArray();

                cmd.Parameters.AddWithValue("ima", pic);
                cmd.Parameters.AddWithValue(":id", id);
                cmd.ExecuteReader();
            }
        }

        internal int InsertarImagen(Imagen imagen, NpgsqlConnection con)
        {
            string sql = @"INSERT INTO imagen(imagen) VALUES (:ima) returning id";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

            MemoryStream stream = new MemoryStream();
            imagen.Foto.Save(stream, ImageFormat.Jpeg);
            byte[] pic = stream.ToArray();

            cmd.Parameters.AddWithValue("ima", pic);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
