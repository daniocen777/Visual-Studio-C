using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjControlProductos
{
    class Producto
    {
        public string codigo { get; set; }

        public string descripcion { get; set; }

        public string categoria { get; set; }

        public double precio { get; set; }

        public int stockActual { get; set; }

        public int stockMinimo{ get; set; }
    }
}
