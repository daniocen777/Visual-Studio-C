using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicando
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DaoCliente dao = new DaoClientesImpl();
            // ---  PROBANDO CONSULTA --- //
            List<Object[]> lista = dao.ClientesQry();
            //foreach (Object[] obj in lista)
            //{
            //    Console.WriteLine("ID: " + obj[0] + " -- "
            //        + "Nombre: " + obj[1] + " " + obj[2] + " " + obj[3] + " -- "
            //        + "Teléfono: " + obj[4] + " -- "
            //        + "DNI: " + obj[5] + " -- "
            //        + "Dirección: " + obj[6] + " -- ");

            //}
            //var json = JsonConvert.SerializeObject(lista);
            //string resultado = json.ToString();
            //Console.WriteLine(resultado);
            //Console.ReadLine();

            // --- PROBANDO EL INSERTAR --- //
            //Cliente cliente = new Cliente();
            //cliente.setIDE_CLI("CL0005");
            //cliente.setNOM_CLI("NOMBRE DE PRUEBA");
            //cliente.setPAT_CLI("PAT DE PRUEBA");
            //cliente.setMAT_CLI("MAT DE PRUEBA");
            //cliente.setFON_CLI("98812222");
            //cliente.setDNI_CLI("12345678");
            //cliente.setDIR_CLI("CL0005");

            //string result = dao.ClienteIns(cliente);

            //if (result == null)
            //{
            //    Console.WriteLine("ok");
            //} else
            //{
            //    Console.WriteLine(result);
            //}
            //Console.ReadLine();

            // PROBANDO LA ELIMINACIÓN
            //string id = "CL0003";
            //string result = dao.ClienteDel(id);
            //if (result == null)
            //{
            //    Console.WriteLine("ok");
            //}
            //else
            //{
            //    Console.WriteLine(result);
            //}
            //Console.ReadLine();

            // GET CLIENTE X ID
            //Object[] cliente = dao.ClienteGet("CL0001");
            //string output = JsonConvert.SerializeObject(cliente);
            //Console.WriteLine(output);
            //Console.ReadLine();

            //Console.WriteLine("ID: " + cliente.getIDE_CLI() + " -- " +
            //    "Nombre: " + cliente.getNOM_CLI() + " " +  cliente.getPAT_CLI() + " " + cliente.getMAT_CLI());
            //Console.ReadLine();

            // ACTUALIZAR
            //Cliente cliente = new Cliente();
            //cliente.setIDE_CLI("CL0004");
            //cliente.setNOM_CLI("NOMBRE ACTUALIZADO");
            //cliente.setPAT_CLI("PAT ACTUALIZADO");
            //cliente.setMAT_CLI("MAT ACTUALIZADO");
            //cliente.setFON_CLI("98812222");
            //cliente.setDNI_CLI("12345678");
            //cliente.setDIR_CLI("DIRECCIÓN ACTUALIZADA");

            //string result = dao.ClienteUpd(cliente);
            //if (result == null)
            //{
            //    Console.WriteLine("ok");
            //}
            //else
            //{
            //    Console.WriteLine(result);
            //}
            //Console.ReadLine();

            // -- PROBANDO ELIMINACIÓN MASIVA -- //
            List<string> ids = new List<string>();
            //ids.Add("QWF");
            //ids.Add("ssa");
            ids.Add("12345");
            ids.Add("xw");

            string result = dao.ClienteDelMass(ids);
            if (result.Equals("ok"))
            {
                Console.WriteLine("--- /// ok --- ////");
            }
            else
            {
                Console.WriteLine(result);
            }

            Console.ReadLine();

        }
    }
}
