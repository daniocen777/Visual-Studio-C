using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapasPresentacion
{
    public partial class frmActualizarContratista : Form
    {
        ContratistaCN objCon = new ContratistaCN();
        public frmActualizarContratista()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (valida() == "")
            {
                ContratistaCE objCE = new ContratistaCE();
                objCE.codigo = txtCodigo.Text;
                objCE.nombre = txtNombre.Text;
                objCE.paterno = txtPaterno.Text;
                objCE.materno = txtMaterno.Text;
                objCE.telefono = txtTelefono.Text;
                objCE.correo = txtCorreo.Text;

                try
                {
                    objCon.ACTUALIZACONTRATISTA(objCE);
                    MessageBox.Show("CONTRATISTA ACTUALIZA CORRECTAMENTE..!!", "ACTUALIZA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgContratista.DataSource = objCon.LISTACONTRATISTA();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
                MessageBox.Show("El error se encuentra en " + valida());
        }

        private void frmActualizarContratista_Load(object sender, EventArgs e)
        {
            dgContratista.DataSource = objCon.LISTACONTRATISTA();
        }

        private void dgContratista_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            txtCodigo.Text = dgContratista.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgContratista.CurrentRow.Cells[1].Value.ToString();
            txtPaterno.Text = dgContratista.CurrentRow.Cells[2].Value.ToString();
            txtMaterno.Text = dgContratista.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Text = dgContratista.CurrentRow.Cells[4].Value.ToString();
            txtCorreo.Text = dgContratista.CurrentRow.Cells[5].Value.ToString();

        }
        //Metodo de validacion de datos 
        string valida()
        {
            if (txtNombre.Text.Trim().Length == 0)
            {
                return " nombre del contratista";
            }
            else if (txtPaterno.Text.Trim().Length == 0)
            {
                return " paterno del contratista";
            }
            else if (txtMaterno.Text.Trim().Length == 0)
            {
                return " materno del contratista";
            }
            else if (txtTelefono.Text.Trim().Length == 0)
            {
                return " telefono del contratista";
            }
            else if (txtCorreo.Text.Trim().Length == 0)
            {
                return " correo del contratista";
            }
            else
            {
                return "";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static void limpiar(Form ofrm)
        {
            foreach (Control oControls in ofrm.Controls)
            {
                if (oControls is TextBox)
                {
                    oControls.Text = "";
                }
            }

        }
    }
}
