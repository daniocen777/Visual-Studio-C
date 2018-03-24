using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjVentaHeredada
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnContado_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de venta al constado
            frmContado formContado = new frmContado();
            formContado.Show();
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de venta al crédito
            frmCredito formCrdito = new frmCredito();
            formCrdito.Show();
        }


    }
}
