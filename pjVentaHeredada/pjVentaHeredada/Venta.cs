using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjVentaHeredada
{
    class Venta
    {
        public string cliente { get; set; }

        public string ruc { get; set; }

        public DateTime fecha { get; set; }

        public DateTime hora { get; set; }

        public string producto { get; set; }

        public int cantidad { get; set; }

        // Método para asignar precios según producto
        public double asignaPrecio()
        {
            switch (producto)
            {
                case "Lavadora": return 1500;
                case "Refrigeradora": return 3500;
                case "Licuadora": return 500;
                case "Extractora": return 150;
                case "Radiograbadora": return 750;
                case "DVD": return 100;
                case "Blue Ray": return 250;
            }

            return 0; // Si no está 
        }

        // Método para calcular el subtotal
        public double calculaSubTotal()
        {
            return asignaPrecio() * cantidad;
        }
    }
}
