using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjFichasReclamoxCliente
{
    public partial class frmFichasxCliente : Form
    {
        dcContratoDataContext db = new dcContratoDataContext();

        public frmFichasxCliente()
        {
            InitializeComponent();
        }

        private void frmFichasxCliente_Load(object sender, EventArgs e)
        {
            llenaClientes();
            llenaFichasReclamo();
        }
        void llenaClientes()
        {
            var clientes = from c in db.CLIENTE
                           select new
                           {
                               codigo = c.IDE_CLI,
                               nombres = c.NOM_CLI + " " +c.PAT_CLI + " "+c.MAT_CLI 
                           };
            cboCliente.DataSource = clientes;
            cboCliente.DisplayMember = "nombres";
            cboCliente.ValueMember = "codigo";
        }
        void llenaFichasReclamo()
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

        private void cboCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var fichas = from f in db.FICHARECLAMO
                         where f.IDE_CLI == cboCliente.SelectedValue.ToString()
                         select new
                         {
                             CODIGO = f.COD_FIC,
                             CONTRATISTA = f.IDE_CON,
                             CLIENTE = f.IDE_CLI,
                             FECHA = f.FFI_FIC
                         };
            dgFichas.DataSource = fichas;
        }
    }
}
