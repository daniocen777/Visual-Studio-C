using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjContratistaDataSet
{
    class LogicaNegocio
    {
        // Variables globales
        Conexion conexion = new Conexion();
        SqlConnection sqlConnection = new SqlConnection();

        // Método para listar contratistas
        public DataSet listarContratistas()
        {
            sqlConnection = conexion.getConecta();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SP_LISTACONTRATISTA", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "CONTRATISTA");
            return dataSet;
        }
    }
}
