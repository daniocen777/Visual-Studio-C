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

namespace pjVentaHeredada
{
    public partial class frmCredito : Form
    {

        // Arreglos de prodcutos y letras
        private static string[] productos = { "Lavadora", "Refrigeradora", "Licuadora",
                                     "Extractora", "Radiograbadora", "DVD", "Blue Ray"};
        private static int[] letras = { 3, 6, 9, 12};

        // Declarando los arreglos para productos y letras
        private ArrayList aProductos = new ArrayList(productos);

        private ArrayList aLetras = new ArrayList(letras);

        // Subtotal
        double tSubTotal = 0;
        public frmCredito()
        {
            InitializeComponent();
        }

        // Método para parsear la fecha
        private void mostrarFecha()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        // Método para mostrar la hora
        private void mostrarHora()
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void frmCredito_Load(object sender, EventArgs e)
        {
            cboProducto.DataSource = aProductos; // Llenar el combo don DataSource
            cboLetras.DataSource = aLetras; // Llenar el combo don DataSource
            mostrarFecha(); // Cargar al inicio la fecha
            mostrarHora(); // Cargar al inicio la hora
        }

        private void btnAdquirir_Click(object sender, EventArgs e)
        {
            // Objeto de la clase Credito
            Credito objCredito = new Credito();

            // Datos del cliente
            objCredito.cliente = txtCliente.Text;
            objCredito.ruc = txtRuc.Text;
            objCredito.fecha = DateTime.Parse(lblFecha.Text);
            objCredito.hora = DateTime.Parse(lblHora.Text);

            // Datos del producto => Viene de la clase padre Venta
            objCredito.producto = cboProducto.Text;
            objCredito.cantidad = int.Parse(txtCantidad.Text);

            // Cantidad de letras
            objCredito.letras = int.Parse(cboLetras.Text);

            // Calculando interés
            double interes = objCredito.calculaMontoInteres();

            // Imprimiendo
            ListViewItem fila = new ListViewItem(objCredito.getX().ToString());
            fila.SubItems.Add(objCredito.producto);
            fila.SubItems.Add(objCredito.cantidad.ToString());
            fila.SubItems.Add(objCredito.asignaPrecio().ToString("C"));
            fila.SubItems.Add(objCredito.calculaSubTotal().ToString(""));
            lvDetalle.Items.Add(fila);

            // Subtotal + interés
            tSubTotal += objCredito.calculaSubTotal() + interes;
            lblMonto.Text = tSubTotal.ToString("0.00");
        }

        // Método para calcular el monto de cada letra
        private void montoLetras(int letras)
        {
            double montoMensual = double.Parse(lblMonto.Text) / letras;
            lvResumen.Items.Clear();
            for (int i = 1; i <= letras; i++)
            {
                ListViewItem fila = new ListViewItem(i.ToString());
                fila.SubItems.Add(montoMensual.ToString("C"));
                lvResumen.Items.Add(fila);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int letras = int.Parse(cboLetras.Text);

            switch (letras)
            {
                case 3: montoLetras(3); break;
                case 6: montoLetras(6); break;
                case 9: montoLetras(9); break;
                case 12: montoLetras(12); break;
                default:
                    break;
            }
        }
    }
}
