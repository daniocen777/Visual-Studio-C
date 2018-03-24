using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjSueldoEmpleado
{
    public partial class Form1 : Form
    {
        // Arreglo para el combo 
        private static string[] categoria = { "CAS", "CAP" };
        ArrayList acategoria = new ArrayList(categoria);

        public Form1()
        {
            InitializeComponent();
        }

        // Método para llenar el combo
        private void llenaCombo()
        {
            foreach (string c in acategoria)
            {
                cboCategoria.Items.Add(c);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Capturando valores del formulario
            string nombre = txtEmpleado.Text;
            string categ = cboCategoria.Text;
            int horas = int.Parse(txtHoras.Text);

            // Capturando los métodos (resultados)
            double costo = Empleado.asignarCostoHora(categ);
            double bruto = Empleado.calculaBruto(horas, costo);
            double descuento = Empleado.calculaDescuento(bruto);
            double neto = Empleado.calculaNeto(bruto, descuento);

            // Imprimiendo en la lista (listView)
            ListViewItem fila = new ListViewItem(nombre);
            fila.SubItems.Add(categ);
            fila.SubItems.Add(horas.ToString());
            fila.SubItems.Add(costo.ToString("C"));
            fila.SubItems.Add(bruto.ToString("C"));
            fila.SubItems.Add(descuento.ToString("C"));
            fila.SubItems.Add(neto.ToString("C"));
            lvPago.Items.Add(fila);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            llenaCombo();
        }
    }
}
