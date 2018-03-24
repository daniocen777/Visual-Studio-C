using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjControlLibros
{
    public partial class Form1 : Form
    {

        // Objeto de la clase Queue Cola
        Queue<Libro> aLibros = new Queue<Libro>();

        public Form1()
        {
            InitializeComponent();
        }

        // Método para generar código
        private int generaCodigo()
        {
            int codigo = 0;
            if (aLibros.Count < 1) return 1;
            else
            {
                foreach (Libro l in aLibros)
                {
                    codigo = l.codigo;
                }
            }
            return codigo + 1;
        }

        // Método para listar el componente lv de la página de Listado
        private void listado()
        {
            lvLibros.Items.Clear();
            foreach (Libro l in aLibros)
            {
                ListViewItem fila = new ListViewItem(l.codigo.ToString());
                fila.SubItems.Add(l.titulo);
                fila.SubItems.Add(l.autor);
                fila.SubItems.Add(l.anoEdicion.ToString());
                fila.SubItems.Add(l.costo.ToString());
                lvLibros.Items.Add(fila);
            }
        }

        // Método para limpiar controles
        private void limpiar()
        {
            txtAutor.Clear();
            txtTitulo.Clear();
            txtAnoEdicion.Clear();
            txtConsto.Clear();
            txtTitulo.Focus();
        }

        // Método para llenar el combo autor en tiempo real
        private void llenarAutores()
        {
            // Lista de autores
            var autores = (from Libro a in aLibros select new { a.autor }).Distinct().ToList();
            cboAutor.DataSource = autores; // Llenar el combo de autores
            cboAutor.DisplayMember = "autor"; // = que el atributo de la clase
        }

        // Método para llenar el combo año de edición en tiempo real
        private void llenarAno()
        {
            // Lista de autores
            var anos = (from Libro a in aLibros select new { a.anoEdicion }).Distinct().ToList();
            cboAnoEdicion.DataSource = anos; // Llenar el combo de autores
            cboAnoEdicion.DisplayMember = "anoEdicion"; // = que el atributo de la clase
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCodigo.Text = generaCodigo().ToString();
        }

        // Botón para generar código
        private void btnGeneraCodigo_Click(object sender, EventArgs e)
        {
            lblCodigo.Text = generaCodigo().ToString();
        }

        // Botón Registrar
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Objeto de la clase Libro
            Libro objL = new Libro();

            // Enviando los valores al objeto
            objL.codigo = int.Parse(lblCodigo.Text);
            objL.titulo = txtTitulo.Text;
            objL.autor = txtAutor.Text;
            objL.anoEdicion = int.Parse(txtAnoEdicion.Text);
            objL.costo = double.Parse(txtConsto.Text);
            foreach (Libro l in aLibros)
            {
                if (l.titulo == objL.titulo)
                {
                    MessageBox.Show("El libro ya existe en la BD");
                    return;
                }
            }
            // Agregando el libro si no existe aún
            aLibros.Enqueue(objL);
            listado();
            limpiar();
            lblCodigo.Text = generaCodigo().ToString();
            llenarAutores(); // Llenar autores
            llenarAno(); // Llenar años
        }

        // Búsqueda por autor (combo) => Listado
        private void cboAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvLibrosAutor.Items.Clear(); // Limpiar los items
            foreach (Libro l in aLibros)
            {
                if (l.autor == cboAutor.Text)
                {
                    ListViewItem fila = new ListViewItem(l.codigo.ToString());
                    fila.SubItems.Add(l.titulo);
                    fila.SubItems.Add(l.autor);
                    fila.SubItems.Add(l.anoEdicion.ToString());
                    fila.SubItems.Add(l.costo.ToString());
                    lvLibrosAutor.Items.Add(fila);
                }
            }
        }

        // Búsqueda por año de edición (combo) => Listado
        private void cboAnoEdicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvLibrosxAno.Items.Clear(); // Limpiar los items
            foreach (Libro l in aLibros)
            {
                if (l.anoEdicion.ToString() == cboAnoEdicion.Text)
                {
                    ListViewItem fila = new ListViewItem(l.codigo.ToString());
                    fila.SubItems.Add(l.titulo);
                    fila.SubItems.Add(l.autor);
                    fila.SubItems.Add(l.anoEdicion.ToString());
                    fila.SubItems.Add(l.costo.ToString());
                    lvLibrosxAno.Items.Add(fila);
                }
            }
        }
    }
}
