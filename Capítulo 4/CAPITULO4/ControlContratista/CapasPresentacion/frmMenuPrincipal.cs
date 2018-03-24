using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapasPresentacion
{
    public partial class frmMenuPrincipal : Form
    {
      

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
           
        }

       

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void actualizarContratistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActualizarContratista childForm = new frmActualizarContratista();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void agendaContratistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void buscarContratistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarContratista childForm = new frmBuscarContratista
                ();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void eliminarContratistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminarContratista childForm = new frmEliminarContratista();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void listaContratistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nuevoContratistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevoContratista childForm = new frmNuevoContratista();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listaGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaGeneral childForm = new frmListaGeneral();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void agendaContratistaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAgendaContratista childForm = new frmAgendaContratista();
            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}
