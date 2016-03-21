using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Entidades;

namespace DAO
{
    public class ParticipanteDAO
    {
        /// <summary>
        /// petodo que se conecta a la base de datos para optener
        /// los datos del suario si este introdujo su username y passwork
        /// bien
        /// </summary>
        /// <param name="participante"></param>
        /// <returns>retorna un objeto tipo Participante</returns>
        public Participante Autentificar(Participante participante)
        {
            NpgsqlConnection con = null;
            try
            {
                Participante p = new Participante();
                using (con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    string sql = @"select 
                                id, id_dimension, id_imagen, 
                                usuario, contrasena, nombre, 
                                telefono, correo, tipo_usuario 
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
                        p.Dimension = reader.IsDBNull(1) ? new Dimension() : new Dimension { Id = reader.GetInt32(0) };
                        ImagenDAO idao = new ImagenDAO();
                        p.Imagen = reader.IsDBNull(2) ? new Imagen() : idao.CargarFoto(reader.GetInt32(2));
                        p.Imagen.Id = reader.GetInt32(2);
                        p.Usuario = reader.GetString(3);
                        p.Contrasena = reader.GetString(4);
                        p.Nombre = reader.GetString(5);
                        p.Telefono = reader.GetString(6);
                        p.Correo = reader.GetString(7);
                        p.TipoUsuario = reader.GetInt32(8);
                    }
                    con.Close();
                }
                return p;
            }
            catch (Exception ex)
            {
                if (con != null)
                {
                    con.Close();
                }

                throw new Exception(ex.Message);
            }
        }

        public void RefrescarUsuario(Participante participante)
        {
            NpgsqlConnection con = null;
            try
            {
                Participante p = new Participante();
                using (con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    string sql = @"select 
                                id, id_dimension, id_imagen, 
                                usuario, contrasena, nombre, 
                                telefono, correo, tipo_usuario 
                               from 
                                participante 
                               where 
                                usuario = :usu";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("usu", participante.Usuario);
                    cmd.Parameters.AddWithValue("con", participante.Contrasena);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        p.Id = reader.GetInt32(0);
                        p.Dimension = reader.IsDBNull(1) ? new Dimension() : new Dimension { Id = reader.GetInt32(0) };
                        ImagenDAO idao = new ImagenDAO();
                        p.Imagen = reader.IsDBNull(2) ? new Imagen() : idao.CargarFoto(reader.GetInt32(2));
                        p.Imagen.Id = reader.GetInt32(2);
                        p.Usuario = reader.GetString(3);
                        p.Contrasena = reader.GetString(4);
                        p.Nombre = reader.GetString(5);
                        p.Telefono = reader.GetString(6);
                        p.Correo = reader.GetString(7);
                        p.TipoUsuario = reader.GetInt32(8);
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                if (con != null)
                {
                    con.Close();
                }

                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// se conecta a la base de datos para hacer el updater de el usuario que
        /// esta siendo editado
        /// (editar la imagen y la contrasenia no estan implementados)
        /// </summary>
        /// <param name="participante"></param>
        /// <param name="i"></param>
        /// <returns>retorna un buleano</returns>
        public bool Editar(Participante participante, int i)
        {
            
            NpgsqlConnection con = null;
            try
            {
                participante.Id = i;
                using (con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    
                    ImagenDAO idao = new ImagenDAO();
                    idao.EditarImagen(participante.Imagen, participante.Imagen.Id, con);
                    string sql = @"UPDATE participante SET id_dimension = :dim,
                                    usuario= :usu, nombre= :nom, contrasena = :con 
                                    WHERE id = :idu;";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("idu", participante.Id);
                    cmd.Parameters.AddWithValue("usu", participante.Usuario);
                    cmd.Parameters.AddWithValue("con", participante.Contrasena);
                    cmd.Parameters.AddWithValue("nom", participante.Nombre);
                    cmd.Parameters.AddWithValue("tel", participante.Telefono);
                    cmd.Parameters.AddWithValue("cor", participante.Correo);
                    cmd.Parameters.AddWithValue("dim", participante.Dimension.Id);
                    cmd.ExecuteNonQuery();
                    //Edita categorias 
                    EditarCategorias(participante);
                    
                    return participante.Id > 0;
                }
            }
            catch (Exception ex)
            {
                if (con != null)
                {
                    con.Close();
                }
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// seconecta a la base de datos para hacer una actualizacion de 
        /// cuales son las categorias en las que un usuario participa
        /// </summary>
        /// <param name="participante">Objeto de tipo participante</param>
        private void EditarCategorias(Participante participante)
        {
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    string sql = @"DELETE FROM participante_categoria
                                    WHERE id_participante = :idpart;";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue(":idPart", participante.Id);
                    cmd.ExecuteNonQuery();

                    sql = @"INSERT INTO participante_categoria(
                                id_participante, id_categoria) VALUES (
                                :idPar, :idCat)";

                    foreach (Categoria item in participante.Categorias)
                    {
                        cmd = new NpgsqlCommand(sql, con);
                        cmd.Parameters.AddWithValue(":idPar", participante.Id);
                        cmd.Parameters.AddWithValue(":idCat", item.Id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// se conecta a la base de datos para hacer el insert de un nuevo usuario
        /// </summary>
        /// <param name="participante"></param>
        /// <returns>retorna un boleano</returns>
        public bool Registrar(Participante participante)
        {
            NpgsqlConnection con = null;
            try
            {


                using (con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    ImagenDAO idao = new ImagenDAO();
                    participante.Imagen.Id = idao.InsertarImagen(participante.Imagen, con);
                    string sql = @"INSERT INTO participante(
                                id_imagen, usuario, contrasena, nombre,
                                telefono, correo, id_dimension, tipo_usuario) VALUES (
                                :ima, :usu, :con, :nom, :tel, :cor, :dim, 2) returning id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("ima", participante.Imagen.Id);
                    cmd.Parameters.AddWithValue("usu", participante.Usuario);
                    cmd.Parameters.AddWithValue("con", participante.Contrasena);
                    cmd.Parameters.AddWithValue("nom", participante.Nombre);
                    cmd.Parameters.AddWithValue("tel", participante.Telefono);
                    cmd.Parameters.AddWithValue("cor", participante.Correo);
                    cmd.Parameters.AddWithValue("dim", participante.Dimension.Id);

                    participante.Id = Convert.ToInt32(cmd.ExecuteScalar());

                    //Registrar categorias 
                    RegistrarCategorias(participante, con);
                    
                    con.Close();
                    return participante.Id > 0;
                }
            }
            catch (Exception ex)
            {
                if (con != null)
                {
                    con.Close();
                }
                throw new Exception(ex.Message);
            }
        }

        private void RegistrarCategorias(Participante participante, NpgsqlConnection con)
        {
            try
            {

                string sql = @"INSERT INTO participante_categoria(
                                id_participante, id_categoria) VALUES (
                                :idPar, :idCat)";

                foreach (Categoria item in participante.Categorias)
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue(":idPar", participante.Id);
                    cmd.Parameters.AddWithValue(":idCat", item.Id);
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// se conecta a la base de datos para registras las categorias en las que
        /// participa un usuario
        /// </summary>
        /// <param name="participante"></param>
        public void RegistrarCategorias(Participante participante)
        {
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    string sql = @"INSERT INTO participante_categoria(
                                id_participante, id_categoria) VALUES (
                                :idPar, :idCat)";

                    foreach (Categoria item in participante.Categorias)
                    {
                        NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                        cmd.Parameters.AddWithValue(":idPar", participante.Id);
                        cmd.Parameters.AddWithValue(":idCat", item.Id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
