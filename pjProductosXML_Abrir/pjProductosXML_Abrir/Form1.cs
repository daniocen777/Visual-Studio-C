using System;
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

namespace pjProductosXML_Abrir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lvProductos.Items.Clear();
            // Objeto OpenFileDialig para abrir el diálogo
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Archivo XML|*.xml"; // Tipo de archivo
            // Abrir diálogo
            if (open.ShowDialog() == DialogResult.OK)
            {
                // Abrir
                using(FileStream fs = new FileStream(open.FileName, FileMode.Open))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(ArregloProductos));
                    ArregloProductos pro = (ArregloProductos)xml.Deserialize(fs); 

                    // llenar
                    foreach (Producto p in pro.listado)
                    {
                        ListViewItem fila = new ListViewItem(p.descripcion);
                        fila.SubItems.Add(p.categoria);
                        fila.SubItems.Add(p.precio.ToString());
                        fila.SubItems.Add(p.fechVenc.ToShortDateString());
                        fila.SubItems.Add(p.cantidad.ToString());
                        lvProductos.Items.Add(fila);
                    }
                }
            }
        }
    }
}
