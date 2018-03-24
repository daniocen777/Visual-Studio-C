using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Librerias ADO NET
using System.Data.SqlClient;
using System.Configuration;

namespace pjConexionClase
{
    public class Conexion
    {
        public SqlConnection getConecta()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
            return cn;
        }
    }
}
