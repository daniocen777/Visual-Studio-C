using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjListaEquiposLinQ
{
    public partial class frmListadoEquipos : Form
    {
        public frmListadoEquipos()
        {
            InitializeComponent();
        }

        private void frmListadoEquipos_Load(object sender, EventArgs e)
        {
            llenaEquipos();
        }
        void llenaEquipos()
        {
            dcContratoDataContext db = new dcContratoDataContext();
            dgEquipos.DataSource = db.SP_LISTAEQUIPOS(); 
        }
    }
}
