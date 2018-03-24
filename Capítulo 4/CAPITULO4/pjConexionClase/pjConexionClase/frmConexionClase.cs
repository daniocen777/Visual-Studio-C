using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjConexionClase
{
    public partial class frmConexionClase : Form
    {
        //Objeto de la clase LogicaNegocio
        LogicaNegocio objL = new LogicaNegocio();

        public frmConexionClase()
        {
            InitializeComponent();
        }

        private void frmConexionClase_Load(object sender, EventArgs e)
        {
            dgClientes.DataSource = objL.listaClientes();
            lblTotal.Text = objL.listaClientes().Rows.ToString();
        }
    }
}
