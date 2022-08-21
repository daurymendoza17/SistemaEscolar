using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Capas.Data
{
   public class  ConexDB
    {
        public static string sConnection = ConfigurationManager.ConnectionStrings["DBConexion"].ConnectionString;

    }
}
