using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjConexionAsistente
{
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }

        private void frmListadoClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cONTRATODataSet.CLIENTE' Puede moverla o quitarla según sea necesario.
            this.cLIENTETableAdapter.Fill(this.cONTRATODataSet.CLIENTE);
            lblTotal.Text = dgClientes.RowCount.ToString();
        }
    }
}
