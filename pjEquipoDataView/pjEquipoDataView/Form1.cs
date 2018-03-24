using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjEquipoDataView
{
    public partial class Form1 : Form
    {
        // Objeto LogicaNegocio
        LogicaNegocio logicaNegocio = new LogicaNegocio();
        public Form1()
        {
            InitializeComponent();
        }

        // Método para listar equipos
        private void listarEquipos()
        {
            dgEquipo.DataSource = logicaNegocio.listarEquipos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listarEquipos();
        }
    }
}
