using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicando
{
    interface DaoCliente
    {
        List<Object[]> ClientesQry(); // listar 

        string ClienteIns(Cliente cliente); // Insertar

        string ClienteDel(string id); // Eliminar

        string ClienteDelMass(List<string> ids); // Eliminar masivo

        Object[] ClienteGet(string id); // Captar cliente x id

        string ClienteUpd(Cliente cliente); // Actualizar

        String GetMessage();
    }
}
