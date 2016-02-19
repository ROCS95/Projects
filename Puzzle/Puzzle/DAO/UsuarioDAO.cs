using Npgsql;
using Puzzle.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle.DAO
{
    class UsuarioDAO
    {
        public Usuario Autentificar(Usuario u)
        {
            Usuario resultado = new Usuario();
            //Crear una conexio a partir de la configuracion
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
            { 
                //Lo que vamos a ejecutar
                string sql = " select id, usuario, contrasena from participante where usuario = :u and contrasena = :c";
                //Abrimos la conexion
                con.Open();
                //Creamos el comand
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("u", u.User);
                cmd.Parameters.AddWithValue("c", u.Contrasenia);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    resultado.Id = reader.GetInt32(0);
                    resultado.User = reader.GetString(1);
                    resultado.Contrasenia = reader.GetString(2);
                }
                return resultado;
            }
        }
        public int InsertarFoto(Foto foto)
        {
            try
            {
                using (NpgsqlConnection cn = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    cn.Open();
                    string sql = @"INSERT INTO foto (foto) VALUES (:foto) RETURNING id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                    MemoryStream stream = new MemoryStream();
                  //  foto.Imagen.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();
                    cmd.Parameters.AddWithValue(":foto", pic);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception)
            {

                throw;
            }
                
            }
        public Usuario Insertar(Usuario u)
        {
            Usuario resultado = new Usuario();
            //Crear una conexio a partir de la configuracion
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
            {
                //Lo que vamos a ejecutar
                string sql = "INSERT INTO  participante(usuario , contrasena, nombre, correo)"
                    + " values (:u,:c,:n,:c)"; 
                //Abrimos la conexion
                con.Open();
                //Creamos el comand
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("u", u.User);
                cmd.Parameters.AddWithValue("c", u.Contrasenia);
                cmd.Parameters.AddWithValue("n", u.Nombre);
                cmd.Parameters.AddWithValue("c", u.Correo);
                cmd.ExecuteNonQuery();
                return resultado;
            }
        }
    }

}
