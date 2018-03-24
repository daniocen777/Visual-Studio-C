using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjEquipoDataView
{
    class LogicaNegocio
    {
        // Variables globales
        Conexion conexion = new Conexion();
        SqlConnection sqlConnection;

        // Métood para listar equipos
        public DataView listarEquipos()
        {
            sqlConnection = conexion.getConecta(); // Conectar a la BD
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SP_LISTAEQUIPO", sqlConnection);
            DataSet dataSet = new DataSet(); // Objeto para establecer data
            sqlDataAdapter.Fill(dataSet, "EQUIPOS"); // Agregar los datos de EQUIPOS
            // DataView
            DataView dataView = new DataView();
            dataView.Table = dataSet.Tables[0];
            return dataView;
        }
    }
}
