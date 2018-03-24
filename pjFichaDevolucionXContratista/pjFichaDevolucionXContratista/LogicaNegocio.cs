using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjFichaDevolucionXContratista
{
    class LogicaNegocio
    {
        // Variables globales
        private Conexion conexion = new Conexion();
        private SqlConnection sqlConnection;

        // Método para listar los contratista (para el combo)
        public DataTable contratistasCbo()
        {
            sqlConnection = conexion.getConexion(); // Conexión a la BD
            // Para ejecutar el query o SP
            string sql = "SELECT C.IDE_CON AS CODIGO," 
            + "C.NOM_CON + SPACE(1) + C.PAT_CON + SPACE(1) + C.MAT_CON AS CONTRATISTA FROM CONTRATISTA C";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(
                           sql, sqlConnection);
            // Llenar al DataTable
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable); // Llenar al dataTable
            return dataTable; // Retorna la data
        }

        // Método para listar las fichas de devolución X contratista
        public DataTable listarFichasXContratista(string contratista)
        {
            sqlConnection = conexion.getConexion(); // Conexión a la BD
            sqlConnection.Open(); // Abrir la conexión
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(
                           "SP_LISTAFICHADEVOLUCIONXCONTRATISTA", sqlConnection);
            // El SP requiere de un parámetro, por esta razón, cambia un poco las líneas
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure; //Tipo
            // Agregando parámetro
            sqlDataAdapter.SelectCommand.Parameters.Add("CON", SqlDbType.Char).Value = contratista;
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable); // Llenar al dataTable
            return dataTable; // Retorna la data
        }
    }
}
