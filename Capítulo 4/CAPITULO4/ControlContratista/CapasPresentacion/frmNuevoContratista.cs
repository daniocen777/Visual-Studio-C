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
    public partial class frmNuevoContratista : Form
    {
        ContratistaCN objCon = new ContratistaCN();
        public frmNuevoContratista()
        {
            InitializeComponent();
        }

        private void frmNuevoContratista_Load(object sender, EventArgs e)
        {
            generarCodigo();
            
       }
        void generarCodigo() 
        {
            lblCodigo.Text = objCon.NUEVOCODIGO();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (valida() == "")
            {
                ContratistaCE objCE = new ContratistaCE();
                objCE.codigo = lblCodigo.Text;
                objCE.nombre = txtNombre.Text;
                objCE.paterno = txtPaterno.Text;
                objCE.materno = txtMaterno.Text;
                objCE.telefono = txtTelefono.Text;
                objCE.correo = txtCorreo.Text;

                try
                {
                    objCon.NUEVOCONTRATISTA(objCE);
                    generarCodigo();
                    MessageBox.Show("CONTRATISTA REGISTRADO CORRECTAMENTE..!!", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
                MessageBox.Show("El error se encuentra en "+valida());
        }

        //Metodo de validacion de datos 
        string valida() {
            if (txtNombre.Text.Trim().Length == 0) {
                return " nombre del contratista";
            }else if (txtPaterno.Text.Trim().Length == 0) {
                return " paterno del contratista";
            }else if (txtMaterno.Text.Trim().Length == 0) {
                return " materno del contratista";
            }else if (txtTelefono.Text.Trim().Length == 0) {
                return " telefono del contratista";
            }
            else if (txtCorreo.Text.Trim().Length == 0)
            {
                return " correo del contratista";
            }
            else {
                return "";
            } 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

    }
}
