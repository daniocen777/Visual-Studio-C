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

namespace CapasPresentacion
{
    public partial class frmListaGeneral : Form
    {
        ContratistaCN objCO = new ContratistaCN();
        public frmListaGeneral()
        {
            InitializeComponent();
        }

        private void frmListaGeneral_Load(object sender, EventArgs e)
        {
            dgContratista.DataSource = objCO.LISTACONTRATISTA();
        }

    }
}
