using Npgsql;
using Puzzle.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Puzzle.DAO
{
    class ImagenDAO
    {
        internal int InsertImage(byte[] binData)
        {

            //Crear una conexio a partir de la configuracion
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
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
                if (result > 0)
                {
                    MessageBox.Show("Registrado con Exito", "OK", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else {
                    MessageBox.Show("NO FUE REGISTRADO", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sql = "SELECT id"
                    + " FROM imagen where imagen = :i;";
                cmd.Parameters.AddWithValue("i", binData);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                Imagen im = new Imagen();
                if (reader.Read())
                {
                    im.Id = int.Parse(reader.GetString(0));
                }
                con.Close();
                return im.Id;
            }
        }

        internal Image CargarImagen(Usuario u)
        {
            throw new NotImplementedException();
        }
    }
}
