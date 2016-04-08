using Entidades;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UsuarioDAO
    {
        private ImagenDAO imgDAO;

        /// <summary>
        /// Método para autentificar el usuario con la BD
        /// </summary>
        /// <param name="us">recibe usuario con username, correo y password</param>
        /// <returns>Usuario con todos sus atributos</returns>
        public Usuario Autentificar(Usuario us)
        {
            Usuario usFinal = new Usuario();
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
            {
                string sql = @"select id, id_imagen, id_dimension, usuario, contrasena, nombre, telefono, correo, tipo_usuario
                from participante where (usuario = :usuario or correo =:usuario) and contrasena = :contrasena";
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("usuario", us.User);
                cmd.Parameters.AddWithValue("contrasena", us.Pass);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    usFinal.Id = reader.GetInt32(0);
                    usFinal.Foto.Id = reader.GetInt32(1);
                    usFinal.Dimension.Id = reader.GetInt32(2);
                    usFinal.User = reader.GetString(3);
                    usFinal.Pass = reader.GetString(4);
                    usFinal.Nombre = reader.GetString(5);
                    usFinal.Telefono = reader.GetString(6);
                    usFinal.Correo = reader.GetString(7);
                    usFinal.Tipo = reader.GetInt32(8);
                }
                return usFinal;
            }
        }

        /// <summary>
        /// Método para insertar usuario en la base de datos
        /// </summary>
        /// <param name="us">Recibe usuario</param>
        /// <returns>Usuario Final con ID</returns>
        public Usuario RegistrarUsuario(Usuario us)
        {
            NpgsqlTransaction tran = null;
            imgDAO = new ImagenDAO();
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    tran = con.BeginTransaction();
                    us.Foto.Id = imgDAO.InsertarImagen(us.Foto, con);
                    string sql = @"Insert into Participante(usuario, contrasena, nombre, telefono, correo, id_imagen, id_dimension, tipo_usuario) 
                    VALUES (:usuario, :contrasena, :nombre, :telefono, :correo, :id_imagen, :id_dimension, :tipo_usuario) RETURNING ID";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("usuario", us.User);
                    cmd.Parameters.AddWithValue("contrasena", us.Pass);
                    cmd.Parameters.AddWithValue("nombre", us.Nombre);
                    cmd.Parameters.AddWithValue("telefono", us.Telefono);
                    cmd.Parameters.AddWithValue("correo", us.Correo);
                    cmd.Parameters.AddWithValue("id_imagen", us.Foto.Id);
                    cmd.Parameters.AddWithValue("id_dimension", us.Dimension.Id);
                    cmd.Parameters.AddWithValue("tipo_usuario", 2);
                    us.Id = Convert.ToInt32(cmd.ExecuteScalar());
                    RegistrarUsCategoria(us, con);
                    tran.Commit();
                    return us;
                }
            }
            catch (Exception)
            {
                if (tran != null)
                {
                    tran.Rollback();
                }
                throw new Exception("¡Error a la hora de registrar usuario!");
            }
        }

        /// <summary>
        /// Método que actualiza los datos del participante
        /// </summary>
        /// <param name="us">Recibe un usuario por parametro</param>
        /// <param name="idImg">La id de la imagen del usuario</param>
        /// <returns>Usuario actualizado</returns>
        public Usuario ActualizarDatos(Usuario us, int idImg)
        {
            NpgsqlTransaction tran = null;
            imgDAO = new ImagenDAO();
            int idImgTemp = us.Foto.Id;
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    tran = con.BeginTransaction();
                    us.Foto.Id = imgDAO.InsertarImagen(us.Foto, con);
                    string sql = @"UPDATE participante
                                SET id_dimension=:id_dimension, id_imagen=:id_imagen, usuario=:usuario, contrasena=:contrasena, nombre=:nombre, 
                                telefono=:telefono, correo=:correo
                                WHERE id= :id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("id_dimension", us.Dimension.Id);
                    cmd.Parameters.AddWithValue("id_imagen", us.Foto.Id);
                    cmd.Parameters.AddWithValue("usuario", us.User);
                    cmd.Parameters.AddWithValue("contrasena", us.Pass);
                    cmd.Parameters.AddWithValue("nombre", us.Nombre);
                    cmd.Parameters.AddWithValue("telefono", us.Telefono);
                    cmd.Parameters.AddWithValue("correo", us.Correo);
                    cmd.Parameters.AddWithValue("id", us.Id);
                    cmd.ExecuteNonQuery();
                    BorrarCat(us, con);
                    RegistrarUsCategoria(us, con);
                    imgDAO.BorrarImagen(idImg, con);
                    Console.WriteLine();
                    tran.Commit();
                    return us;
                }
            }
            catch (Exception )
            {
                if (tran != null)
                {
                    tran.Rollback();
                }
                throw new Exception("¡Error a la hora de actualizar datos!");
            }
        }

        /// <summary>
        /// Método para registrar una categoría
        /// </summary>
        /// <param name="us">Recibe un usuario completo</param>
        /// <param name="con">Recibe la conexión a la base</param>
        public void RegistrarUsCategoria(Usuario us, NpgsqlConnection con)
        {
            try
            {
                string sql = @"INSERT INTO participante_categoria(
                                id_participante, id_categoria) VALUES (
                                :idPar, :idCat)";
                foreach (Categoria item in us.Categorias)
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("idPar", us.Id);
                    cmd.Parameters.AddWithValue("idCat", item.Id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException)
            {
                throw new Exception("Error a la hora de conectar al servidor (Categoría)");
            }
            catch (Exception)
            {
                throw new Exception("Error a la hora de registrar categoría");
            }
        }

        /// <summary>
        /// Método que borra la categoría de un usuario en caso de que el usuario decida actualizar sus datos.
        /// </summary>
        /// <param name="us">Recibe un usuario completo</param>
        /// <param name="con">Recibe la conexión a la base</param>
        public void BorrarCat(Usuario us, NpgsqlConnection con)
        {
            try
            {
                string sql = @"DELETE FROM participante_categoria
                                WHERE id_participante=:id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("id", us.Id);
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException)
            {
                throw new Exception("Error a la hora de conectar al servidor (Categoría)");
            }
            catch (Exception)
            {
                throw new Exception("Error a la hora de borrar categoría");
            }
        }

        /// <summary>
        /// Método para obtener un usuario desde la base de datos.
        /// </summary>
        /// <param name="us">Usuario que trae una ID</param>
        /// <returns>Usuario obtenido desde la base de datos.</returns>
        public Usuario ObtUsuario(Usuario us)
        {
            Usuario usFinal = new Usuario();
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
            {
                string sql = @"select id, id_imagen, id_dimension, usuario, contrasena, nombre, telefono, correo, tipo_usuario
                from participante where id = :id";
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("id", us.Id);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    usFinal.Id = reader.GetInt32(0);
                    usFinal.Foto.Id = reader.GetInt32(1);
                    usFinal.Dimension.Id = reader.GetInt32(2);
                    usFinal.User = reader.GetString(3);
                    usFinal.Pass = reader.GetString(4);
                    usFinal.Nombre = reader.GetString(5);
                    usFinal.Telefono = reader.GetString(6);
                    usFinal.Correo = reader.GetString(7);
                    usFinal.Tipo = reader.GetInt32(8);
                }
                return usFinal;
            }
        }
    }
}
