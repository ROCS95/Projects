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

        internal Usuario CagraUser(Usuario us)
        {
            Usuario resultado = new Usuario();
            //Crear una conexio a partir de la configuracion
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
            {
                //Lo que vamos a ejecutar
                string sql = " select * from participante where usuario = :u";
                //Abrimos la conexion
                con.Open();
                //Creamos el comand
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("u", us.User);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    resultado.User = reader.GetString(3);
                    resultado.Nombre = reader.GetString(5);
                    resultado.Contrasenia = reader.GetString(4);
                    resultado.Correo = reader.GetString(7);
                    resultado.IdImagen = Int32.Parse(reader.GetString(2));

                }
                return resultado;
            }
        }

        public Usuario Insertar(Usuario u, int idImagen)
        {
            Usuario resultado = new Usuario();
            //Crear una conexio a partir de la configuracion
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
            {
                //Lo que vamos a ejecutar
                string sql = "INSERT INTO  participante(usuario , contrasena, nombre, correo, id_imagen)"
                    + " values (:u,:c,:n,:c,:i)"; 
                //Abrimos la conexion
                con.Open();
                //Creamos el comand
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("u", u.User);
                cmd.Parameters.AddWithValue("c", u.Contrasenia);
                cmd.Parameters.AddWithValue("n", u.Nombre);
                cmd.Parameters.AddWithValue("c", u.Correo);
                cmd.Parameters.AddWithValue("i", idImagen);
                cmd.ExecuteNonQuery();
                return resultado;
            }
        }
    }

}
