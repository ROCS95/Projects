using Npgsql;
using Puzzle.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Puzzle.DAO
{
    class ImagenDAO
    {
        internal void InsertImage(byte[] binData)
        {

            //Crear una conexio a partir de la configuracion
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
            {
                if (binData.Length > -1)
                {
                    //Lo que vamos a ejecutar
                    string sql = "INSERT INTO  imagen(imagen)"
                        + " values (:i)";
                    //Abrimos la conexion
                    con.Open();
                    //Creamos el comand
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("i", binData);
                    int result = cmd.ExecuteNonQuery();
                }
                
                con.Close();

            }
        }

        internal Image CargarImagen(Usuario u)
        {
            byte[] binData;
            //Crear una conexio a partir de la configuracion
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
            {
                //Lo que vamos a ejecutar
                string sql = "SELECT imagen FROM imagen;"
                    + " where id = :i;";
                //Abrimos la conexion
                con.Open();
                //Creamos el comand
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("i", u.Id);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                Imagen im = new Imagen();
                if (reader.Read())
                {
                    binData = BitConverter.GetBytes(reader.GetByte(1));
                    im.Foto = byteArrayToImage(binData);
                }
                    con.Close();
                return im.Foto;
            }
        }

            //convert bytearray to image
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }
    }
}
