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

namespace pjControlPersonal
{
    public partial class Form1 : Form
    {
        // ArrayList para almacenar el personal
        ArrayList aPersonal = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCodigo.Text = generaCodigo();
        }

        private void lvPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Método para llenar los campos al hacer doble clic al ListView
        private void lvPersonal_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Obtener la posición del elemento seleccionado (doble en el código)
            ListViewItem elemento = lvPersonal.GetItemAt(e.X, e.Y); // (X, Y)

            // Verificación si existe elemento
            if (elemento != null)
            {
                lblCodigo.Text = elemento.Text;
                txtPeterno.Text = elemento.SubItems[1].Text;
                txtMaterno.Text = elemento.SubItems[2].Text;
                txtNombres.Text = elemento.SubItems[3].Text;
                txtFechaNacimiento.Text = elemento.SubItems[4].Text;
                txtFechaContrato.Text = elemento.SubItems[5].Text;
            }
        }

        // Generar nuevo código al hacer clic en el botón "Nuevo"
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            lblCodigo.Text = generaCodigo();
            limpiarControles();
        }

        // Botón "Registrar"
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // try
            try
            {
                // Objeto Personal
                Personal objP = new Personal();

                // Agregar los datos 
                objP.codigo = lblCodigo.Text;
                objP.paterno = txtPeterno.Text;
                objP.materno = txtMaterno.Text;
                objP.nombres = txtNombres.Text;
                objP.fechaNac = DateTime.Parse(txtFechaNacimiento.Text);
                objP.fechaCon = DateTime.Parse(txtFechaContrato.Text);

                // Agregar a la lista este personal ingresdo
                aPersonal.Add(objP);

                listado();// Listar
                limpiarControles(); // Limpiar Controles
                lblCodigo.Text = generaCodigo(); // Generar nuevo código
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al ingrsar");
            }
        }

        // Método para genrar código automático
        public string generaCodigo()
        {
            string codigo = "";
            if (aPersonal.Count < 1) return "P001";
            else
            {
                // Para hallar el último código
                foreach (Personal p in aPersonal)
                {
                    codigo = p.codigo.ToString(); 
                }
            }
            return "P" + (int.Parse(codigo.Substring(1, 3)) + 1).ToString("000");
        }

        // Método para listado
        private void listado()
        {
            lvPersonal.Items.Clear(); // Simpre limpiar antes de insertar
            foreach (Personal p in aPersonal)
            {
                ListViewItem fila = new ListViewItem(p.codigo);
                fila.SubItems.Add(p.paterno);
                fila.SubItems.Add(p.materno);
                fila.SubItems.Add(p.nombres);
                fila.SubItems.Add(p.fechaNac.ToShortDateString());
                fila.SubItems.Add(p.fechaCon.ToShortDateString());
                lvPersonal.Items.Add(fila);
            }
        }

        // Método para limpiar los controles
        public void limpiarControles()
        {
            txtPeterno.Clear();
            txtMaterno.Clear();
            txtNombres.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Personal p in aPersonal)
                {
                    if (p.codigo == lblCodigo.Text)
                    {
                        p.paterno = txtPeterno.Text;
                        p.materno = txtMaterno.Text;
                        p.nombres = txtNombres.Text;
                        p.fechaNac = DateTime.Parse(txtFechaNacimiento.Text);
                        p.fechaCon = DateTime.Parse(txtFechaContrato.Text);
                        break;
                    }
                }
                listado();
                lblCodigo.Text = generaCodigo();
                limpiarControles();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar registro");
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Personal p in aPersonal)
                {
                    if (p.codigo == lblCodigo.Text)
                    {
                        DialogResult dialog = MessageBox.Show("¿Desea eliminar?",
                            "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialog == DialogResult.Yes)
                        {
                            aPersonal.Remove(p);
                            break;
                        }
                    }
                }
                listado();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
             DialogResult dialog = MessageBox.Show("¿Desea salir?",
                          "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialog == DialogResult.Yes) 
            {
                this.Close();
            }
        }
    }
}
