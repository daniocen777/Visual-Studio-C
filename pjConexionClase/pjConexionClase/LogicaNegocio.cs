using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjConexionClase
{
    class LogicaNegocio
    {
        Conexion objCon = new Conexion();// Objeto de la clase Conexion
        SqlConnection cn; // Variable de la clase SqlConnection

        // Método para listar clientes
        public DataTable listaClientes()
        {
            cn = objCon.getConecta();
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTACLIENTE", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
