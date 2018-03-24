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
    public partial class frmBuscarContratista : Form
    {
        ContratistaCN objCon = new ContratistaCN();
        public frmBuscarContratista()
        {
            InitializeComponent();
        }

        private void frmBuscarContratista_Load(object sender, EventArgs e)
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
            {
           
            }
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
    }
}


