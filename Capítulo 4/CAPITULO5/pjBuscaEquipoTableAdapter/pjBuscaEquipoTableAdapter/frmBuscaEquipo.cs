using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjBuscaEquipoTableAdapter
{
    public partial class frmBuscaEquipo : Form
    {
        //GLOBAL
        dsContrato ds = new dsContrato();
        
        public frmBuscaEquipo()
        {
            InitializeComponent();
        }

        private void frmBuscaEquipo_Load(object sender, EventArgs e)
        {
            llenaEstado();
            llenaTipo();
            llenaEquipo();
        }

        void llenaEstado()
        {
            dsContratoTableAdapters.SP_ESTADOEQUIPOTableAdapter da = new dsContratoTableAdapters.SP_ESTADOEQUIPOTableAdapter();
            da.Fill(ds.SP_ESTADOEQUIPO);
            cboEstado.DataSource = ds.SP_ESTADOEQUIPO;
            cboEstado.DisplayMember = "ESTADO";
            cboEstado.ValueMember = "CODIGO";

        }
        void llenaTipo()
        {
            dsContratoTableAdapters.SP_TIPOEQUIPOTableAdapter da = new dsContratoTableAdapters.SP_TIPOEQUIPOTableAdapter();
            da.Fill(ds.SP_TIPOEQUIPO);
            cboTipo.DataSource = ds.SP_TIPOEQUIPO;
            cboTipo.DisplayMember = "TIPO";
            cboTipo.ValueMember = "CODIGO";

        }

        void llenaEquipo()
        {
            dsContratoTableAdapters.SP_LISTAEQUIPOSTableAdapter da = new dsContratoTableAdapters.SP_LISTAEQUIPOSTableAdapter();
            da.Fill(ds.SP_LISTAEQUIPOS);
            dgEquipo.DataSource = ds.SP_LISTAEQUIPOS;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string estado = cboEstado.SelectedValue.ToString();
            string tipo = cboTipo.SelectedValue.ToString();

            dsContratoTableAdapters.SP_EQUIPOSXESTADOXTIPOTableAdapter da = new dsContratoTableAdapters.SP_EQUIPOSXESTADOXTIPOTableAdapter();
            da.Fill(ds.SP_EQUIPOSXESTADOXTIPO, estado, tipo);

            dgEquipo.DataSource = ds.SP_EQUIPOSXESTADOXTIPO;
        }
    }
}
