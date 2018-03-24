using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjPromedioNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblCondicion_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Objeto de la clase Promedio
            Promedio objPromedio = new Promedio();
            // Enviando los datos
            objPromedio.alumno = txtAlumno.Text; // Alumno
            objPromedio.nota1 = int.Parse(txtNota1.Text); // Parsear la nota1
            objPromedio.nota2 = int.Parse(txtNota2.Text); // Parsear la nota2
            objPromedio.nota3 = int.Parse(txtNota3.Text); // Parsear la nota3
            objPromedio.nota4 = int.Parse(txtNota4.Text); // Parsear la nota4

            // Salidas 
            lblPromedio.Text = objPromedio.calcularPromedio().ToString("0.00");
            lblNotaMasBaja.Text = objPromedio.masBaja().ToString("0.00");
            lblCondicion.Text = objPromedio.asignarCondicion();
        }
    }
}
