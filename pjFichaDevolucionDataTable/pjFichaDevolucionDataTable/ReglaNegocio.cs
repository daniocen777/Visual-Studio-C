using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjFichaDevolucionDataTable
{
    class ReglaNegocio
    {
        // Definir variables
        Conexion conexion = new Conexion();
        SqlConnection sqlConnection;

        // Método para listar las fichas de devolución
        public DataTable listarFichaDevolucion()
        {
            sqlConnection = conexion.getConecta(); // Conexion
            // Puente / sentencias sql => Fill para llenar objetos (DataTable)
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(
                                            "SP_LISTAFICHADEVOLUCION", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable); // Fill, llenando al DataTable
            dataTable.Dispose(); // Liberar recursos
            return dataTable;
        }

    }
}
