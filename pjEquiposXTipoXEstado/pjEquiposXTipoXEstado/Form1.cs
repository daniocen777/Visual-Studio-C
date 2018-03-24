using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjEquiposXTipoXEstado
{
    public partial class Form1 : Form
    {
        // Objeto Logica de Negocio
        private LogicaNegocio logicaNegocio = new LogicaNegocio();
        public Form1()
        {
            InitializeComponent();
        }

        // Método para llenar los tipo en el combo
        private void tipoEquipoCbo()
        {
            cboTipo.DataSource= logicaNegocio.tipoEquiposCbo();
            cboTipo.DisplayMember = "TIPO";
            cboTipo.ValueMember = "CODIGO";
        }

        // Método para llenar los estados en el combo
        private void estadoEquipoCbo()
        {
            cboEstado.DataSource = logicaNegocio.estadoEquipoCbo();
            cboEstado.DisplayMember = "ESTADO";
            cboEstado.ValueMember = "CODIGO";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tipoEquipoCbo();
            estadoEquipoCbo();
        }

        // Botón buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string estado = cboEstado.SelectedValue.ToString();
            string tipo = cboTipo.SelectedValue.ToString();

            // Agregar al dataGridView
            dgEquipo.DataSource = logicaNegocio.EquiposXEstadoXTipoQry(estado, tipo);
        }
    }
}
