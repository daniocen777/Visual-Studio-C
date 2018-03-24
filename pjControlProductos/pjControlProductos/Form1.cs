using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace pjControlProductos
{
    public partial class Form1 : Form
    {

        // Lista de productos
        List<Producto> aProductos = new List<Producto>();

        public Form1()
        {
            InitializeComponent();
        }

        // Método para generar código
        private string generaCodigo()
        {
            string codigo = "";
            if (aProductos.Count < 1)
            {
                return "PR-001";
            }
            else
            {
                foreach (Producto p in aProductos)
                {
                    codigo = p.codigo.ToString();
                }
            }
            return "PR-" + (int.Parse(codigo.Substring(3, 3)) + 1).ToString("000");
        }

        // Método para listar
        private void listar()
        {
            lvProductos.Items.Clear();
            foreach (Producto p in aProductos)
            {
                ListViewItem fila = new ListViewItem(p.codigo);
                fila.SubItems.Add(p.descripcion);
                fila.SubItems.Add(p.categoria);
                fila.SubItems.Add(p.precio.ToString("0.00"));
                fila.SubItems.Add(p.stockActual.ToString());
                fila.SubItems.Add(p.stockMinimo.ToString());
                lvProductos.Items.Add(fila);
            }
        }

        // Método para limpiar controles
        private void limpiar()
        {
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStockActual.Clear();
            txtStockMinimo.Clear();
            cboCategoria.SelectedIndex = -1;
        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {
            lblCodigo.Text = generaCodigo();
        }

        private void lvProductos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Obtener la posición del elemento
            ListViewItem elemento = lvProductos.GetItemAt(e.X, e.Y);

            // Verificando existencia del elemento
            if (elemento != null)
            {
                lblCodigo.Text = elemento.Text;
                txtDescripcion.Text = elemento.SubItems[1].Text;
                cboCategoria.Text = elemento.SubItems[2].Text;
                txtPrecio.Text = elemento.SubItems[3].Text;
                txtStockActual.Text = elemento.SubItems[4].Text;
                txtStockMinimo.Text = elemento.SubItems[5].Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCodigo.Text = generaCodigo();
        }

        // Bótón (toolStrip) Nuevo
        private void tsRegistrar_Click(object sender, EventArgs e)
        {
            // Objeto de la clase Producto
            Producto objP = new Producto();
            objP.codigo = lblCodigo.Text;
            objP.descripcion = txtDescripcion.Text;
            objP.categoria = cboCategoria.Text;
            objP.precio = double.Parse(txtPrecio.Text);
            objP.stockActual = int.Parse(txtStockActual.Text);
            objP.stockMinimo = int.Parse(txtStockMinimo.Text);

            // Verificando existencia del producto
            foreach (Producto p in aProductos)
            {
                if (objP.descripcion == p.descripcion)
                {
                    MessageBox.Show("Ya existe el producto");
                    return; // Si existe producto, cierra proceso del botón
                }
            }
            // Agregando a la lista
            aProductos.Add(objP);
            listar(); // Listar producto agregado
            limpiar();
            lblCodigo.Text = generaCodigo(); // Genera código
        }

        // Botón Modificar
        private void tsModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Buscar, de la lista, el código que sea = al que se desea modificar
                foreach (Producto p in aProductos)
                {
                    if (p.codigo == lblCodigo.Text)
                    {
                        p.descripcion = txtDescripcion.Text;
                        p.categoria = cboCategoria.Text;
                        p.precio = double.Parse(txtPrecio.Text);
                        p.stockActual = int.Parse(txtStockActual.Text);
                        p.stockMinimo = int.Parse(txtStockMinimo.Text);
                        break; // Cortarlo cuando lo encuentre y llene el objeto
                    }
                }
                listar(); // Listar producto agregado
                lblCodigo.Text = generaCodigo(); // Genera código
                limpiar();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar");
            }
        }

        // Botón eliminar
        private void tsEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                 // Buscar, de la lista, el código que sea = al que se desea eliminar
                foreach (Producto p in aProductos)
                {
                    if (p.codigo == lblCodigo.Text)
                    {
                        aProductos.Remove(p);
                        break;
                    }
                }
                listar(); // Listar sin el producto
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar");
            }
        }

        // Botón buscar producto
        private void tsBuscar_Click(object sender, EventArgs e)
        {
            string codigo = Interaction.InputBox("Ingrese código de producto");
            foreach (Producto p in aProductos)
            {
                if (p.codigo == codigo)
                {
                    txtDescripcion.Text = p.descripcion;
                    cboCategoria.Text = p.categoria;
                    txtPrecio.Text = p.precio.ToString();
                    txtStockActual.Text = p.stockActual.ToString();
                    txtStockMinimo.Text = p.stockMinimo.ToString();
                    break;
                }
            }
        }

    }
}
