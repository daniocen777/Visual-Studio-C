using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjFichaDevolucionDataTable
{
    class Conexion
    {
        public SqlConnection getConecta()
        {
            SqlConnection sqlConnection = new SqlConnection(
                          ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
            return sqlConnection;
        }
    }
}
