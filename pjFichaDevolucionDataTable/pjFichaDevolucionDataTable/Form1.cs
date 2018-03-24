using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjFichaDevolucionDataTable
{
    public partial class Form1 : Form
    {
        // Definiendo el objeto de Logica...
        ReglaNegocio reglaNegocio = new ReglaNegocio();
        public Form1()
        {
            InitializeComponent();
        }

        // Método para listar 
        private void listarFichaDevolucion()
        {
            dgFichaDevolucion.DataSource = reglaNegocio.listarFichaDevolucion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listarFichaDevolucion();
        }
    }
}
