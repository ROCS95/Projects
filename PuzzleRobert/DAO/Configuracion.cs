using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Configuracion
    {
        /// <summary>
        /// cadena de coneccion a la base de datos
        /// </summary>
        private static string cadenaConexion = String.Format("Server={0};Port={1};" +
                 "User Id={2};Password={3};Database={4};",
                 "localhost", 5432, "postgres",
                 123456, "puzzle");
        /// <summary>
        /// metodo que getea la cadena de coneccion a base de datos
        /// </summary>
        public static string CadenaConexion
        {
            get { return cadenaConexion; }
        }

    }
}
