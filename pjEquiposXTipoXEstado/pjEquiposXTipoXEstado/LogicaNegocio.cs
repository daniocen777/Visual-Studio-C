using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjEquiposXTipoXEstado
{
    class LogicaNegocio
    {
        // Variables globales
        Conexion conexion = new Conexion();
        SqlConnection sqlConnecion;

        // Métood para listar los tipo de equipos (para el combo)
        public  DataTable tipoEquiposCbo()
        {
            sqlConnecion = conexion.getConexion(); // Conexión
            // Trabajando con sql y no con el SP
            string sql = "SELECT T.COD_TIP_EQU AS CODIGO," +
                         "T.DES_TIP AS TIPO FROM TIPO_EQUIPO T"; 
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnecion);
            // Objeto dataTable para llenarlo
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        // Método para listar los tipos de equipos (para el combo de estados)
        public DataTable estadoEquipoCbo()
        {
            sqlConnecion = conexion.getConexion(); // Conexión
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SP_ESTADOEQUIPO", sqlConnecion);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        // Método para listar los equipos por estado y tipo
        public DataTable EquiposXEstadoXTipoQry(string estado, string tipo)
        {
            sqlConnecion = conexion.getConexion(); // Conexión
            sqlConnecion.Open(); // Abrir la conexión
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SP_EQUIPOXESTADOXTIPO", sqlConnecion);
            // Para agregar parámetros (SP lo requiere), se necesita especificar el tipo
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            // Agregando el parámetro estado
            sqlDataAdapter.SelectCommand.Parameters.Add("EST", SqlDbType.Char).Value = estado;
            // Agregando el parámetro tipo
            sqlDataAdapter.SelectCommand.Parameters.Add("TIP", SqlDbType.Char).Value = tipo;

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}
