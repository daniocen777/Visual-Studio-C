using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjListadoEquipoTableAdapter
{
    public partial class frmListadoEquipos : Form
    {
        public frmListadoEquipos()
        {
            InitializeComponent();
        }

        private void frmListadoEquipos_Load(object sender, EventArgs e)
        {
            dsContrato ds = new dsContrato();
            dsContratoTableAdapters.SP_LISTAEQUIPOSTableAdapter da= new dsContratoTableAdapters.SP_LISTAEQUIPOSTableAdapter();
            da.Fill(ds.SP_LISTAEQUIPOS);

            dgEquipos.DataSource = ds.SP_LISTAEQUIPOS;
        }
    }
}
