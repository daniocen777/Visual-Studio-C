using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjVentaProductos
{
    class Venta
    {
        // Atributos y método GET y SET (propfull)
        private string _producto;

        public string producto
        {
            get { return _producto; }
            set { _producto = value; }
        }

        private int _cantidad;

        public int cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        // Asignar precio a los productos
        public double asignarPrecio()
        {
            switch (producto)
            {
                case "Mouse":
                    return 20;
                case "Teclado":
                    return 35;
                case "Impresora":
                    return 350;
                case "Monitor":
                    return 550;
                case "Parlantes":
                    return 50;
            }
            return 0; // Si no está en las opciones
        }

        // Método para calcular el subtotal 
        public double calculaSubTotal()
        {
            return asignarPrecio() * cantidad;
        }

        // Método para calcular descuento
        public double calculaDescuento()
        {
            double subTotal = calculaSubTotal();
            if (subTotal <= 300)
            {
                return 0.05 * subTotal;
            }
            else
            {
                if (subTotal >= 301 && subTotal <= 500)
                {
                    return 0.1 * subTotal;
                } else {
                    return 0.125 * subTotal;
                }
            }
        }

        // Método para el precio neto
        public double calculaNeto()
        {
            return calculaSubTotal() - calculaDescuento();
        }
        
    }
}
