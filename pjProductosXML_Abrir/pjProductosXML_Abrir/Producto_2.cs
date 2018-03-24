using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pjProductosXML_Abrir
{
    public class Producto
    {
        public string descripcion { get; set; }

        public string categoria { get; set; }

        public double precio { get; set; }

        public DateTime fechVenc { get; set; }

        public int cantidad { get; set; }

    }
}
