using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using CapaDatos;


namespace CapaNegocio
{
  public  class ContratistaCN
    {
      ContratistaDAO objDAO = new ContratistaDAO();

      //lista contratista

      public DataTable LISTACONTRATISTA()
      {
          return objDAO.LISTACONTRATISTA();
      }
      public string NUEVOCODIGO()
      {
          return objDAO.NUEVOCODIGO();
      }
      public void NUEVOCONTRATISTA(ContratistaCE c)
      {
          objDAO.NUEVOCONTRATISTA(c);
      }
      public void ACTUALIZACONTRATISTA(ContratistaCE c)
      {
          objDAO.ACTUALIZACONTRATISTA(c);
      }

       public void ELIMINACONTRATISTA(ContratistaCE c)
      {
          objDAO.ELIMINACONTRATISTA(c);
      }
       public DataTable BUSCACONTRATISTA(ContratistaCE c)
       {
           return objDAO.BUSCACONTRATISTA(c);
       }
       public DataTable AGENDACONTRATISTA(string letra)
       {
           return objDAO.AGENDACONTRATISTA(letra);
       }
    }
}
