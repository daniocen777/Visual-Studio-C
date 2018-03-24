using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjVentaHeredada
{
    class Credito : Venta // Clase heredada de Venta
    {
        // Variable "x" para saber la cantidad de productos comprados
        public int x;

        // COnstructor para el conteo
        public Credito()
        {
            x += 1;
        }

        // Método GET
        public int getX() 
        {
            return x;
        }

        // Cantidad de letras (por ser a crédito)
        public int letras { get; set; }

        // Calcular el monto del interés
        public double calculaMontoInteres()
        {
            switch (letras)
            {
                case 3: return 0.05 * calculaSubTotal();
                case 6: return 0.1 * calculaSubTotal();
                case 9: return 0.15 * calculaSubTotal();
                case 12: return 0.25 * calculaSubTotal();
            }
            return 0;
        }

        // Calcular monto mensual
        public double calculaMontoMensual() 
        {
            return (calculaSubTotal() + calculaMontoInteres()) / letras;
        }

    }
}
