using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjFichaDevolucionXContratista
{
    public partial class Form1 : Form
    {
        // Objeto Logica
        private LogicaNegocio logicaNegocio = new LogicaNegocio();
        public Form1()
        {
            InitializeComponent();
        }

        // Métood para llenar el combo de contratistas
        private void contratistasCbo()
        {
            cboContratista.DataSource = logicaNegocio.contratistasCbo();
            cboContratista.DisplayMember = "CONTRATISTA";
            cboContratista.ValueMember = "CODIGO";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contratistasCbo();
        }

        // Métoodo para llenar la tabla según contratista
        private void cboContratista_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Captando contratista
            string contratista = cboContratista.SelectedValue.ToString();
            dgFichaDevolucion.DataSource = logicaNegocio.listarFichasXContratista(contratista);
        }
    }
}
