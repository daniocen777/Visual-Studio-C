using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjSueldoEmpleado
{
    class Empleado
    {
        // Método constructor vacío (Siempre privado)
        private Empleado()
        {

        }

        // Método (Serán estáticas) para determinar el costo de la hora
        public static double asignarCostoHora(string categoria)
        {
            switch (categoria)
            {
                case "CAS":
                    return 15;
                case "CAP":
                    return 25;
            }
            return 0; // Si no, retorna cero
        }

        // Método para determinar el monto bruto
        public static double calculaBruto(int horas, double costo)
        {
            return horas * costo;
        }

        // Método para determinar el descuento
        public static double calculaDescuento(double bruto)
        {
            return 0.12 * bruto;
        }

        // Métood para calcular el neto
        public static double calculaNeto(double bruto, double descuento)
        {
            return bruto - descuento;
        }

    }
}
