using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Librerias ADO NET
using System.Data;
using System.Data.SqlClient;

namespace pjConexionClase
{
    public class LogicaNegocio
    {
        //Objeto de la clase Conexion 
        Conexion objCon = new Conexion();

        //Variable de la clase SqlConnection
        SqlConnection cn;

        //Metodo que lista los clientes
        public DataTable listaClientes()
        {
            cn = objCon.getConecta();
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTACLIENTE",cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
