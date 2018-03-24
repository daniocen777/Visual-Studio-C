using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace pjProductosXML
{
    public partial class Form1 : Form
    {
        // Objeto de la clase ArregloProductos
        ArregloProductos aProductos = new ArregloProductos();

        // Arreglo para las categorías
        static string[] categorias = { "Abarrotes", "Bebidas", "Golosinas", "Lácteos" };

        ArrayList aCategoria = new ArrayList(categorias);
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string c in aCategoria)
            {
                cboCategoria.Items.Add(c);
            }
        }

        // Método para listar
        private void listar()
        {
            lvProductos.Items.Clear();
            foreach (Producto p in aProductos.listado)
            {
                ListViewItem fila = new ListViewItem(p.descripcion);
                fila.SubItems.Add(p.categoria);
                fila.SubItems.Add(p.precio.ToString());
                fila.SubItems.Add(p.fechVenc.ToShortDateString());
                fila.SubItems.Add(p.cantidad.ToString());
                lvProductos.Items.Add(fila);
            }
        }

        // Botón Agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Enviando los valores a la clase Producto
            Producto objP = new Producto();
            objP.descripcion = txtDescripcion.Text;
            objP.categoria = cboCategoria.Text;
            objP.precio = double.Parse(txtPrecio.Text);
            objP.fechVenc = DateTime.Parse(dtFechaVencimiento.Text);
            objP.cantidad = int.Parse(txtCantidad.Text);

            // Enviando al arreglo
            aProductos.listado.Add(objP);

            // Llamar al método de listado
            listar();
        }

        // Botón para grabar en XML
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Objeto para abrir diálogo
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Archivo XML|*.xml"; // Tipo de archivo
            // Abrir diálogo
            if (sv.ShowDialog() == DialogResult.OK)
            {
                // Crear archivo
                using(FileStream fs = new FileStream(sv.FileName, FileMode.Create))
                {
                    // Siempre especificar el tipo de datos en el XML
                    XmlSerializer xml = new XmlSerializer(typeof(ArregloProductos));
                    xml.Serialize(fs, aProductos);
                }
            }
        }
    }
}
