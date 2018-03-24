using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Librerias ADO NET
using System.Data.SqlClient;

namespace pjConexionDirecta
{
    public partial class frmConexionDirecta : Form
    {
        public frmConexionDirecta()
        {
            InitializeComponent();
        }

        private void frmConexionDirecta_Load(object sender, EventArgs e)
        {
            dgClientes.DataSource = listaClientes();
            lblTotal.Text = listaClientes().Rows.Count.ToString();
        }

        //Metodo de conexion 
        SqlConnection getConecta()
        {
            SqlConnection cn = new SqlConnection("server=.;database=contrato;integrated security=SSPI");
            return cn;
        }

        //Metodo que lista los clientes
        DataTable listaClientes()
        {
            SqlConnection cn = getConecta();
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTACLIENTE",cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
