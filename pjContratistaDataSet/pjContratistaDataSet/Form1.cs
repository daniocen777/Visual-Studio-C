using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjContratistaDataSet
{
    public partial class Form1 : Form
    {

        // Variable globaal
        LogicaNegocio logicaNegocio = new LogicaNegocio();
        public Form1()
        {
            InitializeComponent();
        }

        // Método para listar contratistas
        private void listarContratistas()
        {
            dgContratista.DataSource = logicaNegocio.listarContratistas().Tables["CONTRATISTA"];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listarContratistas();
        }
    }
}
