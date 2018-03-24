using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjSerializacionTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Botón para serializar
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog(); // Objeto (mostrar cuadro de diálogo)
            sv.Filter = "Archivo binario|*.bin"; // Definiendo tipo de archivo
            // Mostrando cuadro de diálogo de grabación (dónde guerdarlo)
            if (sv.ShowDialog() == DialogResult.OK)
            {
                // Se crea el archivo FileStream (leer, escribir, abrir y cerrar archivos)
                // COloca el nombre que se pone en el diálogo
                using (FileStream fs = new FileStream(sv.FileName, FileMode.Create))
                {
                    // Convirtiendo a cadena
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, txtCadena.Text);
                }
            }
        }

        // Botón para deserializar
        private void tsDeserializar_Click(object sender, EventArgs e)
        {
            // Para abrir el archivo a deserializar
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Archivo binario|*.bin"; //  Definiendo tipo de archivo
            // Mostrar el cuadro de diálogo
            if (op.ShowDialog() == DialogResult.OK)
            {
                // Abriendo archivo
                using(FileStream fs = new FileStream(op.FileName, FileMode.Open))
                {
                    // Convirtiendo el archivo binario a texto
                    BinaryFormatter bf = new BinaryFormatter();
                    txtCadena.Text = bf.Deserialize(fs).ToString();
                }
            }
        }
    }
}
