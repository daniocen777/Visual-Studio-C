using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjSerializacionDatos
{
    [Serializable()]
    class Cliente
    {
        public string nombres { get; set; }

        public string paterno { get; set; }

        public string materno { get; set; }

        public string telefono { get; set; }

        public string email { get; set; }

        public Bitmap foto { get; set; }

    }
}
