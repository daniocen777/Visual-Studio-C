using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjMantenimientoLinQtoSQL
{
    public partial class frmMantenimientoEquipos : Form
    {
        dcContratoDataContext db = new dcContratoDataContext();

        public frmMantenimientoEquipos()
        {
            InitializeComponent();
        }

        private void frmMantenimientoEquipos_Load(object sender, EventArgs e)
        {
            llenaEstado();
            llenaTipo();
            lblCodigo.Text = determinaCodigo();
            llenaEquipos();
        }
        void llenaEstado()
        {
            var estado = from e in db.ESTADO_EQUIPO
                         select new
                         {
                             codigo = e.COD_EST,
                             estado = e.DES_EST
                         };
            cboEstado.DataSource= estado;
            cboEstado.DisplayMember = "ESTADO";
            cboEstado.ValueMember = "CODIGO";
        }
        void llenaTipo()
        {
            var tipo = from t in db.TIPO_EQUIPO
                         select new
                         {
                             codigo = t.COD_TIP_EQU,
                             tipo = t.DES_TIP
                         };
            cboTipo.DataSource = tipo;
            cboTipo.DisplayMember = "TIPO";
            cboTipo.ValueMember = "CODIGO";
        }

        string determinaCodigo()
        {
            var equipos = (from e in db.EQUIPO
                               orderby e.IDE_EQU descending
                               select new { e.IDE_EQU }).Take(1);

            string codigo = "";
            foreach (var equ in equipos.ToList())
                codigo = equ.IDE_EQU;

            return "EQ" + (int.Parse(codigo.Substring(2, 4)) + 1).ToString("0000");
        }
        void llenaEquipos()
        {
            var equipos = from e in db.EQUIPO
                          select e;
            dgEquipos.DataSource = equipos;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            EQUIPO objE = new EQUIPO();

            objE.IDE_EQU = lblCodigo.Text;
            objE.COD_TIP_EQU = cboTipo.SelectedValue.ToString();
            objE.DESC_EQU = txtDescripcion.Text;
            objE.PREC_EQU = int.Parse(txtPrecio.Text);
            objE.COD_EST = cboEstado.SelectedValue.ToString();

            db.EQUIPO.InsertOnSubmit(objE);
            db.SubmitChanges();
            llenaEquipos();
        }
    }
}
