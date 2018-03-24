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

namespace pjVentaProductos
{
    public partial class Form1 : Form
    {
        // Arreglo de productos
        private static string[] productos = {"Teclado", "Impresora", "Monitor",
                                                "Mouse", "Parlantes" };

        // Objeto de tipo array
        ArrayList aproductos = new ArrayList(productos);

        // Objeto de la clase Venta
        Venta objVenta = new Venta();

        // Acumulador de los totales
        double total;

        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cargar
            llenaProductos(); // Combo
            muestraFecha(); // Fecha actual
            muestraHora(); // Hora
            limpiaControles(); // Limpiar controles
        }

        // LLenado del combo
        private void llenaProductos()
        {
            foreach (string p in aproductos)
            {
                cboProducto.Items.Add(p);
            }
        }

        // Método para la fecha actual
        private void muestraFecha() 
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        // Método para mostrar la hora actual
        private void muestraHora()
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        // Método para limpiar controles
        private void limpiaControles()
        {
            txtCliente.Clear();
            cboProducto.Text = "[Seleccione unproducto]";
            txtCantidad.Clear();
            lblPrecio.Text = "";
            txtCliente.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Enviando los datos 
            objVenta.producto = cboProducto.Text; // EL producto
            objVenta.cantidad = int.Parse(txtCantidad.Text);

            // Imprimir las respuestas en la lista (listView)
            ListViewItem fila = new ListViewItem(objVenta.producto);
            fila.SubItems.Add(objVenta.cantidad.ToString());
            fila.SubItems.Add(objVenta.asignarPrecio().ToString("C"));
            fila.SubItems.Add(objVenta.calculaSubTotal().ToString("C"));
            fila.SubItems.Add(objVenta.calculaDescuento().ToString("C"));
            fila.SubItems.Add(objVenta.calculaNeto().ToString("C"));
            lvVenta.Items.Add(fila); // Agregar a la lista

            // Calculando el total de netos
            total += objVenta.calculaNeto();
            lblTotal.Text = total.ToString("C");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            objVenta.producto = cboProducto.Text;
            lblPrecio.Text = objVenta.asignarPrecio().ToString("C"); // C => 2 decimales
        }
    }
}
