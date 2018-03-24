using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjVentaHeredada
{
    class Contado : Venta // : Venta => Hereda de la clase Venta
    {
        public static int n; // Cantidad de productos que lleva el cliente

        // Constructor para el conteo (cada vez que se crea un objeto, aumenta)
        public Contado()
        {
            n += 1; 
        }

        // Método GET para n
        public int getN()
        {
            return n; 
        }

        // Método que calcula descuento
        public double calculaDescuento(double subTotal)
        {
            if (subTotal < 1000)
            {
                return 0.02 * subTotal;
            }
            else
            {
                if (subTotal >= 1000 && subTotal <= 3000)
                {
                    return 0.05 * subTotal;
                }
                else
                {
                    return 0.12 * subTotal;
                }
            }
        }

        // Método para el calculo neto
        public double calculaNeto(double subTotal, double descuento)
        {
            return subTotal - descuento;
        }
    }
}
