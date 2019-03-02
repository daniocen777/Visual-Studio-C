using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Practicando
{
    class DaoClientesImpl : DaoCliente
    {

        private Conexion conexion;
        private string message;

        public DaoClientesImpl()
        {
            this.conexion = new Conexion();
            message = null;
        }
        public List<object[]> ClientesQry()
        {
            List<Object[]> list = null;
            string sql = "SELECT IDE_CLI, "
                         + "NOM_CLI,"
                         + "PAT_CLI,"
                         + "MAT_CLI,"
                         + "FON_CLI,"
                         + "DNI_CLI,"
                         + "DIR_CLI "
                         + "FROM cliente";
            SqlConnection cn = conexion.getConexion();

            try 
            {
                SqlCommand sqlCommand = new SqlCommand(sql, cn);
                cn.Open();
                using(SqlDataReader r = sqlCommand.ExecuteReader())
                {
                    list = new List<object[]>();
                    while (r.Read())
                    {
                        Object[] fila = new Object[7];
                        fila[0] = r[0].ToString();
                        fila[1] = r[1].ToString();
                        fila[2] = r[2].ToString();
                        fila[3] = r[3].ToString();
                        fila[4] = r[4].ToString();
                        fila[5] = r[5].ToString();
                        fila[6] = r[6].ToString();

                        list.Add(fila);
                    }
                }
            }
            catch (SQLException ex)
            {
                message = ex.Message;
            } finally
            {
                cn.Close();
            }

            return list;
        }

        // Insertar
        public string ClienteIns(Cliente cliente)
        {
            string sql = "INSERT INTO cliente(IDE_CLI, NOM_CLI, PAT_CLI, MAT_CLI, FON_CLI, DNI_CLI, DIR_CLI) VALUES(@id, @nombre, @apPaterno, @apMaterno, @telef, @dni, @direcc)";
            
            using (SqlConnection cn = conexion.getConexion())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id", cliente.getIDE_CLI());
                cmd.Parameters.AddWithValue("@nombre", cliente.getNOM_CLI());
                cmd.Parameters.AddWithValue("@apPaterno", cliente.getPAT_CLI());
                cmd.Parameters.AddWithValue("@apMaterno", cliente.getMAT_CLI());
                cmd.Parameters.AddWithValue("@telef", cliente.getFON_CLI());
                cmd.Parameters.AddWithValue("@dni", cliente.getDNI_CLI());
                cmd.Parameters.AddWithValue("@direcc", cliente.getDIR_CLI());

                int result = cmd.ExecuteNonQuery();
                this.message = result > 0 ? null : "ERROR";
                //cn.Close(); using lo cierra
            } 

            return message;
        }

        public string ClienteDel(string id)
        {
            string sql = "DELETE FROM CLIENTE WHERE IDE_CLI = @id";
            using(SqlConnection cn = conexion.getConexion())
            {
                cn.Open();
                
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id", id);
                int result = cmd.ExecuteNonQuery();
                this.message = result > 0 ? null : "ERROR: " + result;

            }
            return message;
        }

        public string ClienteDelMass(List<string> ids)
        {
            string sql = "";
            bool ok = true;
            SqlConnection cn = conexion.getConexion();
            cn.Open();
            using (SqlTransaction sqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable))
            {
                
                
                foreach (string id in ids)
                {
                    sql = "DELETE FROM CLIENTE WHERE IDE_CLI = @id";
                    SqlCommand cmd = new SqlCommand(sql, cn, sqlTransaction);
                    cmd.Parameters.AddWithValue("@id", id);
                    
                    int result = cmd.ExecuteNonQuery();
                    if (result != 1)
                    {
                        ok = false;
                        this.message = "ID: " + id + " no encontrado";
                        break;
                    }
                }
                if (ok == true)
                {
                    sqlTransaction.Commit();
                    this.message = "ok";
                }
                else
                {
                    sqlTransaction.Rollback();
                    //this.message = "ME HACE EL ROOLBACK";
                }

                cn.Close();
            }

            return message;
        }

        public Object[] ClienteGet(string id)
        {
            Object[] cliente = new object[7];
            string sql = "SELECT IDE_CLI, "
                         + "NOM_CLI,"
                         + "PAT_CLI,"
                         + "MAT_CLI,"
                         + "FON_CLI,"
                         + "DNI_CLI,"
                         + "DIR_CLI "
                         + "FROM cliente WHERE IDE_CLI = @id";

            SqlConnection cn = conexion.getConexion();
            try
            {
                SqlCommand sqlCommand = new SqlCommand(sql, cn);
                sqlCommand.Parameters.AddWithValue("@id", id);

                cn.Open();
                using (SqlDataReader r = sqlCommand.ExecuteReader())
                {
                    if (r.Read())
                    {
                        cliente[0] =  r[0].ToString();
                        cliente[1] = r[1].ToString();
                        cliente[2] = r[2].ToString();
                        cliente[3] = r[3].ToString();
                        cliente[4] = r[4].ToString();
                        cliente[5] = r[5].ToString();
                        cliente[6] = r[6].ToString();
                    }
                    else
                    {
                        cliente = null;
                    }
                }
            }
            catch (SQLException ex)
            {
                message = ex.Message;
            }
            finally
            {
                cn.Close();
            }

            return cliente;
        }

        public string ClienteUpd(Cliente cliente)
        {
            string sql = "UPDATE CLIENTE SET IDE_CLI = @id, NOM_CLI = @nombre," +
                "PAT_CLI = @paterno, MAT_CLI = @materno, FON_CLI = @telef," +
                "DNI_CLI = @dni, DIR_CLI = @direc WHERE IDE_CLI = @id";

            using (SqlConnection cn = conexion.getConexion())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id", cliente.getIDE_CLI());
                cmd.Parameters.AddWithValue("@nombre", cliente.getNOM_CLI());
                cmd.Parameters.AddWithValue("@paterno", cliente.getPAT_CLI());
                cmd.Parameters.AddWithValue("@materno", cliente.getMAT_CLI());
                cmd.Parameters.AddWithValue("@telef", cliente.getFON_CLI());
                cmd.Parameters.AddWithValue("@dni", cliente.getDNI_CLI());
                cmd.Parameters.AddWithValue("@direc", cliente.getDIR_CLI());

                int result = cmd.ExecuteNonQuery();
                this.message = result > 0 ? null : "ERROR";
            }

            return message;
        }

        public string GetMessage()
        {
            return this.message;
        }

    }
}
