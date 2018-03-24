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
    public partial class Form1 : Form
    {
        LogicaNegocio objL = new LogicaNegocio(); // Objeto
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgClientes.DataSource = objL.listaClientes();
            lblTotal.Text = objL.listaClientes().Rows.Count.ToString();
        }
    }
}
