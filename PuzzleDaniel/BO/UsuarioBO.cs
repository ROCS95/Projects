using DAO;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class UsuarioBO
    {
        private UsuarioDAO uDao;
        private Usuario us;
        private ImagenDAO imgDAO;

        /// <summary>
        /// Constructor donde se inicializa uDao, us e imgDAO
        /// </summary>
        public UsuarioBO()
        {
            uDao = new UsuarioDAO();
            us = new Usuario();
            imgDAO = new ImagenDAO();
        }
        /// <summary>
        /// Método para autentificar usuario
        /// </summary>
        /// <param name="us"></param>
        /// <returns></returns>
        public Usuario AutentificarUsuario(Usuario us)
        {
            return uDao.Autentificar(us);
        }

        /// <summary>
        /// Método para validar usuario
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="correo"></param>
        /// <param name="telefono"></param>
        /// <param name="usuario"></param>
        /// <param name="pass"></param>
        /// <returns>Usuario completo, en caso de error, devuelve nuevo usuario</returns>
        public Usuario ValidarUs(string nombre, string correo, string telefono, string usuario, string pass, Dimension dimension, Imagen foto, List<Categoria> cat, int usId, int tipo)
        {
            if (!String.IsNullOrEmpty(nombre) || !String.IsNullOrEmpty(correo)
                || !String.IsNullOrEmpty(pass) || !String.IsNullOrEmpty(usuario)
                || !String.IsNullOrEmpty(telefono))
            {
                us.Id = usId;
                us.Nombre = nombre;
                us.Telefono = telefono;
                us.Tipo = 0;
                us.User = usuario;
                us.Pass = pass;
                us.Correo = correo;
                us.Dimension = dimension;
                us.Foto = foto;
                us.Categorias = cat;
                us.Tipo = tipo;
            }
            return us;
        }

        /// <summary>
        /// Método que envia el usuario a la clase UsuarioDAO
        /// </summary>
        /// <param name="us">Un usuario</param>
        /// <param name="idImg">La id de la imagen del usuario</param>
        /// <returns>Usuario registrado, en caso de error retorna usuario nuevo</returns>
        public Usuario RegistrarUsuario(Usuario us, int idImg)
        {
            try
            {
                if (us.Id > 0)
                {
                    Usuario temp = uDao.ActualizarDatos(us, idImg);
                    return temp;
                }
                else
                {
                    return uDao.RegistrarUsuario(us);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Método para obtener usuario desde la base de datos
        /// </summary>
        /// <param name="us">Recibe el usuario actual que esta conectado que ya trae la ID</param>
        /// <returns>Un usuario existente en la base de datos</returns>
        public Usuario ObtenerUsuario(Usuario us)
        {
            return uDao.ObtUsuario(us);
        }
    }
}
