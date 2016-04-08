using Entidades;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ImagenDAO
    {
        /// <summary>
        /// Método para insertar imagen en la BD
        /// </summary>
        /// <param name="imagen">Recibe Imagen</param>
        /// <returns>ID de imagen, o 0 en caso que no se guarde en a BD</returns>
        /// <param name="con">Recibe la conexión a la base</param>
        public int InsertarImagen(Imagen imagen, NpgsqlConnection con)
        {
            try
            {
                string sql = @"INSERT INTO IMAGEN (imagen) VALUES (:imagen) RETURNING ID";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                MemoryStream stream = new MemoryStream();
                imagen.Img.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = stream.ToArray();
                cmd.Parameters.AddWithValue(":imagen", pic);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// Método para obtener imagen dede la base de datos.
        /// </summary>
        /// <param name="id_foto">Id de la foto a obtener</param>
        /// <returns>Un objeto del tipo Imagen</returns>
        public Imagen ObtenerImagen(int id_foto)
        {
            try
            {
                Imagen img = new Imagen();
                img.Id = id_foto;
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    string sql = @"select imagen
                from imagen WHERE ID = :id_foto";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue(":id_foto", id_foto);

                    byte[] foto = new byte[0];
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        foto = (byte[])reader["imagen"];
                        MemoryStream stream = new MemoryStream(foto);
                        img.Img = Image.FromStream(stream);
                    }
                    return img;
                }
            }
            catch (NpgsqlException)
            {
                throw new Exception("Error a la hora de conectar con el servidor de imágenes.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        /// <summary>
        /// Método que borra la imagen por id.
        /// </summary>
        /// <param name="id">Id de la imagen</param>
        /// <param name="con">Recibe la conexión a la base</param>
        public void BorrarImagen(int id, NpgsqlConnection con)
        {
            try
            {
                string sql = @"DELETE FROM imagen
                                WHERE id=:id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException)
            {
                throw new Exception("Error a la hora de conectar con el servidor de imágenes.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
