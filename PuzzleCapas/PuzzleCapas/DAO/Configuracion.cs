using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleCapas.DAO
{
    public class Configuracion
    {
        private static string cadenaConexion = String.Format("Server={0};Port={1};" +
                 "User Id={2};Password={3};Database={4};",
                 "localhost", 5432, "postgres",
                 "sa123456", "puzzle");

        public static string CadenaConexion
        {
            get { return cadenaConexion; }
        }

    }
}
