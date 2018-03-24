using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjListadoContratistaLinQ
{
    public partial class frmListadoContratistas : Form
    {
        public frmListadoContratistas()
        {
            InitializeComponent();
        }

        private void frmListadoContratistas_Load(object sender, EventArgs e)
        {
            llenaContratista();
        }
        void llenaContratista()
        {
            dcContratoDataContext da = new dcContratoDataContext();
            var contratistas = from c in da.CONTRATISTA select c;
            dgContratistas.DataSource = contratistas;
        }
    }
}
