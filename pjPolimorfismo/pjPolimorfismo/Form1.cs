using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjPolimorfismo
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Objeto de la clase PromedioProgramacion
            Promedioprogramacion objP = new Promedioprogramacion();

            // En viando valores a la clase
            objP.estudiante = txtEstudiante.Text;
            objP.evaluacion1 = int.Parse(txtEva1.Text);
            objP.evaluacion2 = int.Parse(txtEva2.Text);
            objP.evaluacion3 = int.Parse(txtEva3.Text);
            objP.actitudinal= int.Parse(txtActitudinal.Text);

            // Imprimiendo a la lista
            ListViewItem fila = new ListViewItem(objP.estudiante);
            fila.SubItems.Add(objP.evaluacion1.ToString("0.00"));
            fila.SubItems.Add(objP.evaluacion2.ToString("0.00"));
            fila.SubItems.Add(objP.evaluacion3.ToString("0.00"));
            fila.SubItems.Add(objP.actitudinal.ToString("0.00"));
            fila.SubItems.Add(objP.calculaPromedio().ToString("0.00"));
            fila.SubItems.Add(objP.determinarCondicion());
            lvEvaluaciones.Items.Add(fila);

            // Invocar al método para imprimir las estadísticas
            estadisticas();
        }

        // Método para la suma de promedios
        public double sumaPromedios()
        {
            double suma = 0;
            for (int i = 0; i < lvEvaluaciones.Items.Count; i++)
            {
                suma += double.Parse(lvEvaluaciones.Items[i].SubItems[5].Text);
            }
            return suma;
        }

        // Método para el promedio más alto
        public double promedioMasAlto()
        {
            double mayor = 0;
            for (int i = 0; i < lvEvaluaciones.Items.Count; i++)
            {
                double promedio = double.Parse(lvEvaluaciones.Items[i].SubItems[5].Text);
                mayor = (promedio > mayor) ? promedio : mayor;
            }
            return mayor;
        }

        // Método para el promedio más bajo
        public double promedioMasBajo()
        {
            double menor = int.MaxValue; // Un máximo, para hacer la compración
            for (int i = 0; i < lvEvaluaciones.Items.Count; i++)
            {
                double promedio = double.Parse(lvEvaluaciones.Items[i].SubItems[5].Text);
                menor = (promedio < menor) ? promedio : menor;
            }
            return menor;
        }

        // Método para hallar la cantidad de aprobados
        public int totalAprobados()
        {
            int cantidadAprob = 0;

            for (int i = 0; i < lvEvaluaciones.Items.Count; i++)
            {
                if (double.Parse(lvEvaluaciones.Items[i].SubItems[5].Text) > 12.5)
                {
                    cantidadAprob += 1;
                }
            }
            return cantidadAprob;
        }

        // Método para hallar la cantidad de desaprobados
        public int totalDesaprobados()
        {
            int cantidadDesap = 0;

            for (int i = 0; i < lvEvaluaciones.Items.Count; i++)
            {
                if (double.Parse(lvEvaluaciones.Items[i].SubItems[5].Text) <= 12.5)
                {
                    cantidadDesap += 1;
                }
            }
            return cantidadDesap;
        }

        // Método para imprimir las estadísticas
        private void estadisticas()
        {
            lstR.Items.Clear();
            lstR.Items.Add("Suma de promedios: " + sumaPromedios().ToString("0.00"));
            lstR.Items.Add("Promedio más alto: " + promedioMasAlto().ToString("0.00"));
            lstR.Items.Add("Promedios ás bajo: " + promedioMasBajo().ToString("0.00"));
            lstR.Items.Add("Total de aprobados: " + totalAprobados().ToString("0.00"));
            lstR.Items.Add("Total de desaprobados: " + totalDesaprobados().ToString("0.00"));
        } 
    }
}

