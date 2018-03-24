using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapasPresentacion
{
    public partial class frmEliminarContratista : Form
    {
        ContratistaCN objCon = new ContratistaCN();

        public frmEliminarContratista()
        {
            InitializeComponent();
        }

        private void frmEliminarContratista_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ContratistaCE objC = new ContratistaCE();
            objC.codigo = txtCodigo.Text;

            if (valida() == "")
            {
                DataRow fila = objCon.BUSCACONTRATISTA(objC).Rows[0];
                txtNombre.Text = fila[1].ToString();
                txtPaterno.Text = fila[2].ToString();
                txtMaterno.Text = fila[3].ToString();
                txtTelefono.Text = fila[4].ToString();
                txtCorreo.Text = fila[5].ToString();
            }
            else
                MessageBox.Show("El error se encuentra en " + valida());

        }

        string valida()
        {
            if (txtCodigo.Text.Trim().Length == 0)
            {
                return " Codigo del contratista";
            }

            else
            {
                return "";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ContratistaCE objC = new ContratistaCE();
            objC.codigo = txtCodigo.Text;

            try
            {
                objCon.ELIMINACONTRATISTA(objC);
                MessageBox.Show("CONTRATISTA ELIMINADO CORRECTAMENTE..!!", "ELIMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                throw;
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
  

    


