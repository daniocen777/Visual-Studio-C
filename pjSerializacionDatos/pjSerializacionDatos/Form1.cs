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

namespace pjSerializacionDatos
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

        // Botón para buscar la foto del cliente
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Objeto de la clase OpenFileDialog
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "Imagenes JPG|*.jpg"; // Tipo de archivo
                if (op.ShowDialog() == DialogResult.OK)
                {
                    pbFoto.Image = Image.FromFile(op.FileName);
                    pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la foto");
            }
           

        }

        // Registrar cliente
        private void tsRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente objC = new Cliente(); // Objeto cliente
                objC.nombres = txtNombres.Text;
                objC.paterno = txtPaterno.Text;
                objC.materno = txtMaterno.Text;
                objC.telefono = txtTelefono.Text;
                objC.email = txtEmail.Text;
                objC.foto = (Bitmap)(pbFoto.Image);

                // Objeto para guardar
                SaveFileDialog sv = new SaveFileDialog();
                sv.Filter = "Archivo binario|*.bin"; // Tipo de dato
                // Mostrar el dialog
                if (sv.ShowDialog() == DialogResult.OK)
                {
                    // Creando el archivo
                    using (FileStream fs = new FileStream(sv.FileName, FileMode.Create))
                    {
                        // Serializando
                        BinaryFormatter bf = new BinaryFormatter();
                        bf.Serialize(fs, objC);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar cliente");
            }
            
        }

        // Mostrar cliente
        private void tsMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog(); //Obj para abrir
                op.Filter = "Archivo binario|*.bin"; // Tipo de archivo
                // Abrir el diálogo
                if (op.ShowDialog() == DialogResult.OK)
                {
                    // Abriendo archivo
                    using(FileStream fs = new FileStream(op.FileName, FileMode.Open))
                    {
                        // Deserializar
                        BinaryFormatter bf = new BinaryFormatter();
                        Cliente objC = (Cliente)(bf.Deserialize(fs));
                        // Enviando los datos
                        txtNombres.Text = objC.nombres;
                        txtPaterno.Text = objC.paterno;
                        txtMaterno.Text = objC.materno;
                        txtTelefono.Text = objC.telefono;
                        txtEmail.Text = objC.email;
                        pbFoto.Image = objC.foto;
                        pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al abrir archivo");
            }
        }
    }
}
