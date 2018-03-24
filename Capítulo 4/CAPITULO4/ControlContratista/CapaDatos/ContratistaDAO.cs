using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

using CapaEntidad;
namespace CapaDatos
{
  public  class ContratistaDAO
    {
      SqlConnection cn;
      Conexion objCON = new Conexion();

      //listanto contratista

      public DataTable LISTACONTRATISTA() 
      {
          cn = objCON.getConecta();
          SqlDataAdapter da = new SqlDataAdapter("SP_LISTACONTRATISTA", cn);
          DataTable dt = new DataTable();
          da.Fill(dt);
          return dt;
      
      }
      public string NUEVOCODIGO()
      {
          cn = objCON.getConecta();
          cn.Open();
          SqlCommand cmd = new SqlCommand("SP_ULTIMOCONTRATISTA", cn);
          SqlDataAdapter da = new SqlDataAdapter();
          da.SelectCommand = cmd;
          int codigo = int.Parse(cmd.ExecuteScalar().ToString().Substring(3, 3)) + 1;

          return "CON" +codigo.ToString("000");
      }
      public void ACTUALIZACONTRATISTA(ContratistaCE c)
      {
          cn = objCON.getConecta();
          cn.Open();
          SqlCommand cmd = new SqlCommand();
          cmd.CommandText = "SP_ACTUALIZACONTRATISTA";
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Connection = cn;

          cmd.Parameters.Add("@COD", SqlDbType.Char).Value = c.codigo;
          cmd.Parameters.Add("@NOM", SqlDbType.VarChar).Value = c.nombre;
          cmd.Parameters.Add("@PAT", SqlDbType.VarChar).Value = c.paterno;
          cmd.Parameters.Add("@MAT", SqlDbType.VarChar).Value = c.materno;
          cmd.Parameters.Add("@FON", SqlDbType.VarChar).Value = c.telefono;
          cmd.Parameters.Add("@EMA", SqlDbType.VarChar).Value = c.correo;

          try
          {
             cmd.ExecuteNonQuery();
          }
          catch (Exception)
          {
              
              throw;
          }

      }

      public void NUEVOCONTRATISTA(ContratistaCE c)
      {
          cn = objCON.getConecta();
          cn.Open();
          SqlCommand cmd = new SqlCommand();
          cmd.CommandText = "SP_NUEVOCONTRATISTA";
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Connection = cn;

          cmd.Parameters.Add("@COD", SqlDbType.Char).Value = c.codigo;
          cmd.Parameters.Add("@NOM", SqlDbType.VarChar).Value = c.nombre;
          cmd.Parameters.Add("@PAT", SqlDbType.VarChar).Value =c.paterno;
          cmd.Parameters.Add("@MAT", SqlDbType.VarChar).Value = c.materno;
          cmd.Parameters.Add("@FON", SqlDbType.VarChar).Value = c.telefono;
          cmd.Parameters.Add("@EMA", SqlDbType.VarChar).Value = c.correo;

          try
          {
              cmd.ExecuteNonQuery();
          }
          catch (Exception)
          {

          }
      }
      public void ELIMINACONTRATISTA(ContratistaCE C)
      {
          cn = objCON.getConecta();
          cn.Open();
          SqlCommand cmd = new SqlCommand();
          cmd.CommandText = "SP_ELIMINACONTRATISTA";
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Connection = cn;

          cmd.Parameters.Add("@COD", SqlDbType.Char).Value = C.codigo;
          try
          {
               cmd.ExecuteNonQuery();
          }
          catch (Exception)
          {
              
              throw;
          }
      }
      public DataTable BUSCACONTRATISTA(ContratistaCE C)
      {
          cn = objCON.getConecta();
          SqlDataAdapter da = new SqlDataAdapter("SP_BUSCACONTRATISTA", cn);
          da.SelectCommand.CommandType = CommandType.StoredProcedure;
          da.SelectCommand.Parameters.Add("@COD", SqlDbType.Char).Value = C.codigo;
          DataTable dt = new DataTable();
          da.Fill(dt);
          return dt;
      
      }
      public DataTable AGENDACONTRATISTA(string letra)
      {
          cn = objCON.getConecta();
          SqlDataAdapter da = new SqlDataAdapter("SP_AGENDACONTRATISTA", cn);
          da.SelectCommand.CommandType = CommandType.StoredProcedure;
          da.SelectCommand.Parameters.Add("@letra",SqlDbType.VarChar).Value = letra;
          DataTable dt = new DataTable();
          da.Fill(dt);
          return dt;

      }
    }
}
