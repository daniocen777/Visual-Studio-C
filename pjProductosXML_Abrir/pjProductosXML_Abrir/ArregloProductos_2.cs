using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace pjProductosXML_Abrir
{
    [XmlRoot("Producto")] // Raiz del XML => Clase Producto
    public class ArregloProductos
    {
        [XmlArrayItem(typeof(Producto))] // Se necesita el tipo de dato en el Xml
        public List<Producto> listado = new List<Producto>();
    }
}
