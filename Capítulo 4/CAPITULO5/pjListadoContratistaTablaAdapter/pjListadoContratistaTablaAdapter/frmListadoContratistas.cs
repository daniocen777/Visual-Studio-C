using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjListadoContratistaTablaAdapter
{
    public partial class frmListadoContratistas : Form
    {
        public frmListadoContratistas()
        {
            InitializeComponent();
        }

        private void frmListadoContratistas_Load(object sender, EventArgs e)
        {
            llenaContratistas();
        }
        void llenaContratistas()
        {
            dsContratoTableAdapters.CONTRATISTATableAdapter da = new dsContratoTableAdapters.CONTRATISTATableAdapter();
            dsContrato ds = new dsContrato();

            da.Fill(ds.CONTRATISTA);
            dgContratistas.DataSource = ds.Tables["CONTRATISTA"];
        }
    }
}
