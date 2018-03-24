using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjFichasReclamoxAñoLinqToSQL
{
    public partial class frmFichasxAño : Form
    {
        dcContratoDataContext db = new dcContratoDataContext();

        public frmFichasxAño()
        {
            InitializeComponent();
        }

        private void frmFichasxAño_Load(object sender, EventArgs e)
        {
            llenaAños();
            llenaFichas();
        }
        void llenaAños()
        {
            cboAño.DataSource = db.SP_LISTAAÑOS();
            cboAño.DisplayMember = "AÑO";
        }
        void llenaFichas()
        {
            var fichas = from f in db.FICHARECLAMO
                         select new
                         {
                             CODIGO = f.COD_FIC,
                             CONTRATISTA = f.IDE_CON,
                             CLIENTE = f.IDE_CLI,
                             FECHA = f.FFI_FIC
                         };
            dgFichas.DataSource = fichas;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int año = int.Parse(cboAño.Text);
            dgFichas.DataSource = db.SP_LISTAFICHASRECLAMOXAÑO(año);
        }
    }
}
