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
    public partial class frmContado : Form
    {

        // Arreglo de productos
        private static string[] productos = { "Lavadora", "Refrigeradora", "Licuadora",
                                     "Extractora", "Radiograbadora", "DVD", "Blue Ray"};

        // Colocando el arreglo a un objeto de tipo ArrayList
        private ArrayList aProductos = new ArrayList(productos);

        // Acumulador de sutotoal, inicializado en cero
        private double tSubTotales = 0;


        public frmContado()
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void frmContado_Load(object sender, EventArgs e)
        {
            cboProducto.DataSource = aProductos; // Llenar el combo don DataSource
            mostrarFecha(); // Cargar al inicio la fecha
            mostrarHora(); // Cargar al inicio la hora
        }

        private void btnAdquirir_Click(object sender, EventArgs e)
        {
            // Creando el objeto de la clase Contadado
            Contado objConstado = new Contado();

            // Datos del cliente
            objConstado.cliente = txtCliente.Text; // Nombre de cliente
            objConstado.ruc = txtRuc.Text; // RUC
            objConstado.fecha = DateTime.Parse(lblFecha.Text); // Fecha
            objConstado.hora = DateTime.Parse(lblHora.Text); // Fecha

            // Datos del producto
            objConstado.producto = cboProducto.Text;
            objConstado.cantidad = int.Parse(txtCantidad.Text);

            // Agregar al listado
            ListViewItem fila = new ListViewItem(objConstado.getN().ToString());
            fila.SubItems.Add(objConstado.producto);
            fila.SubItems.Add(objConstado.cantidad.ToString());
            fila.SubItems.Add(objConstado.asignaPrecio().ToString("C"));
            fila.SubItems.Add(objConstado.calculaSubTotal().ToString(""));
            lvDetalle.Items.Add(fila);

            // Listar => Método
            listado(objConstado);
        }

        // Método para listar el resultado
        private void listado(Contado objC)
        {
            tSubTotales += objC.calculaSubTotal();
            lstResumen.Items.Clear();
            lstResumen.Items.Add("*** RESUMEN DE VENTA ***");
            lstResumen.Items.Add("-----------------------------------------------------------------");
            lstResumen.Items.Add("Cliente: " + objC.cliente);
            lstResumen.Items.Add("RUC: " + objC.ruc);
            lstResumen.Items.Add("Fecha: " + objC.fecha);
            lstResumen.Items.Add("Hora: " + objC.hora);
            lstResumen.Items.Add("-----------------------------------------------------------------");
            lstResumen.Items.Add("SubTotal: " + tSubTotales.ToString("C"));
            // Calculando descuento
            double descuento = objC.calculaDescuento(tSubTotales);
            // Calculando Neto
            double neto = objC.calculaNeto(tSubTotales, descuento);
            // Añadir a la lista
            lstResumen.Items.Add("Descuento: " + descuento.ToString("C"));
            lstResumen.Items.Add("Neto: " + neto.ToString("C"));

            lblNeto.Text = neto.ToString("C");
        }
    }
}
