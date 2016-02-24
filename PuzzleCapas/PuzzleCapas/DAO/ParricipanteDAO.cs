using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuzzleCapas.Entidades;
using Npgsql;

namespace PuzzleCapas.DAO
{
    public class ParticipanteDAO
    {
        public Participante Autentificar(Participante participante)
        {
            Participante p = new Participante();
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
            {
                con.Open();
                string sql = @"select 
                                id, id_dimension, id_imagen, 
                                usuario, contrasena, nombre, 
                                telefono, correo 
                               from 
                                participante 
                               where 
                                usuario = :usu
                                and contrasena = :con";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("usu", participante.Usuario);
                cmd.Parameters.AddWithValue("con", participante.Contrasena);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    p.Id = reader.GetInt32(0);
                    p.Dimension = reader.IsDBNull(1) ? new Dimension() : new Dimension { Id = reader.GetInt32(0)};
                    ImagenDAO idao = new ImagenDAO();
                    p.Imagen = reader.IsDBNull(2) ? new Imagen() : idao.CargarFoto(reader.GetInt32(2));
                    p.Usuario = reader.GetString(3);
                    p.Contrasena = reader.GetString(4);
                    p.Nombre = reader.GetString(5);
                    p.Telefono = reader.GetString(6);
                    p.Correo = reader.GetString(7);
                }
            }
            return p;
        }

        public bool Registrar(Participante participante)
        {
            ImagenDAO idao = new ImagenDAO();
            participante.Imagen.Id = idao.InsertarImagen(participante.Imagen);
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
            {
                con.Open();
                string sql = @"INSERT INTO participante(
                                id_imagen, usuario, contrasena, nombre,
                                telefono, correo, id_dimension) VALUES (
                                :ima, :usu, :con, :nom, :tel, :cor, :dim)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

                cmd.Parameters.AddWithValue("ima", participante.Imagen.Id);
                cmd.Parameters.AddWithValue("usu", participante.Usuario);
                cmd.Parameters.AddWithValue("con", participante.Contrasena);
                cmd.Parameters.AddWithValue("nom", participante.Nombre);
                cmd.Parameters.AddWithValue("tel", participante.Telefono);
                cmd.Parameters.AddWithValue("cor", participante.Correo);
                cmd.Parameters.AddWithValue("dim", participante.Dimension.Id);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
