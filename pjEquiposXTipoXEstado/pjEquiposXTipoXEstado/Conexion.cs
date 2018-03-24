using System.Configuration;
using System.Data.SqlClient;

namespace pjEquiposXTipoXEstado
{
    class Conexion
    {
        // Método para la conexión
        public SqlConnection getConexion()
        {
            SqlConnection sqlConnection = new SqlConnection(
                          ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
            return sqlConnection; 
        }
    }
}
