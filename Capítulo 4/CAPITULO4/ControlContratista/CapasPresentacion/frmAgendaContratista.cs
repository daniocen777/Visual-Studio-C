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
    public partial class frmAgendaContratista : Form
    {
        ContratistaCN objCon = new ContratistaCN();
        public frmAgendaContratista()
        {
            InitializeComponent();
        }

        private void frmAgendaContratista_Load(object sender, EventArgs e)
        {
            dgContratista.DataSource = objCon.LISTACONTRATISTA();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
           dgContratista.DataSource = objCon.AGENDACONTRATISTA("A");
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            dgContratista.DataSource = objCon.AGENDACONTRATISTA("P");
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            dgContratista.DataSource = objCon.AGENDACONTRATISTA("B");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            dgContratista.DataSource = objCon.AGENDACONTRATISTA("C");
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            dgContratista.DataSource = objCon.AGENDACONTRATISTA("D");
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            dgContratista.DataSource = objCon.AGENDACONTRATISTA("E");
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            dgContratista.DataSource = objCon.AGENDACONTRATISTA("F");
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            dgContratista.DataSource = objCon.AGENDACONTRATISTA("G");
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            dgContratista.DataSource = objCon.AGENDACONTRATISTA("H");
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            dgContratista.DataSource = objCon.AGENDACONTRATISTA("I");
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            dgContratista.DataSource = objCon.AGENDACONTRATISTA("J");
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            dgContratista.DataSource = objCon.AGENDACONTRATISTA("K");
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            dgContratista.DataSource = objCon.AGENDACONTRATISTA("L");
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            dgContratista.DataSource = objCon.AGENDACONTRATISTA("M");
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            dgContratista.DataSource = objCon.AGENDACONTRATISTA("N");
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            dgContratista.DataSource = objCon.AGENDACONTRATISTA("O");
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            dgContratista.DataSource = objCon.AGENDACONTRATISTA("Q");
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            dgContratista.DataSource = objCon.AGENDACONTRATISTA("R");
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            dgContratista.DataSource = objCon.AGENDACONTRATISTA("S");
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            dgContratista.DataSource = objCon.AGENDACONTRATISTA("T");
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            dgContratista.DataSource = objCon.AGENDACONTRATISTA("U");
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            dgContratista.DataSource = objCon.AGENDACONTRATISTA("V");
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            dgContratista.DataSource = objCon.AGENDACONTRATISTA("W");
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            dgContratista.DataSource = objCon.AGENDACONTRATISTA("X");
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            dgContratista.DataSource = objCon.AGENDACONTRATISTA("Y");
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            dgContratista.DataSource = objCon.AGENDACONTRATISTA("Z");
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            dgContratista.DataSource = objCon.LISTACONTRATISTA();
        }


    }
}
