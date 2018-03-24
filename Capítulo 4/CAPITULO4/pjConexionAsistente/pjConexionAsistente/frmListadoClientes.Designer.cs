namespace pjConexionAsistente
{
    partial class frmListadoClientes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cONTRATODataSet = new pjConexionAsistente.CONTRATODataSet();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTETableAdapter = new pjConexionAsistente.CONTRATODataSetTableAdapters.CLIENTETableAdapter();
            this.iDECLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMCLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATCLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATCLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fONCLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNICLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIRCLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTRATODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTADO DE CLIENTES - USANDO ASISTENTE";
            // 
            // dgClientes
            // 
            this.dgClientes.AutoGenerateColumns = false;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDECLIDataGridViewTextBoxColumn,
            this.nOMCLIDataGridViewTextBoxColumn,
            this.pATCLIDataGridViewTextBoxColumn,
            this.mATCLIDataGridViewTextBoxColumn,
            this.fONCLIDataGridViewTextBoxColumn,
            this.dNICLIDataGridViewTextBoxColumn,
            this.dIRCLIDataGridViewTextBoxColumn});
            this.dgClientes.DataSource = this.cLIENTEBindingSource;
            this.dgClientes.Location = new System.Drawing.Point(12, 35);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.Size = new System.Drawing.Size(548, 227);
            this.dgClientes.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(512, 269);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(50, 16);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "lblTotal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "TOTAL DE CLIENTES";
            // 
            // cONTRATODataSet
            // 
            this.cONTRATODataSet.DataSetName = "CONTRATODataSet";
            this.cONTRATODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.cONTRATODataSet;
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // iDECLIDataGridViewTextBoxColumn
            // 
            this.iDECLIDataGridViewTextBoxColumn.DataPropertyName = "IDE_CLI";
            this.iDECLIDataGridViewTextBoxColumn.HeaderText = "IDE_CLI";
            this.iDECLIDataGridViewTextBoxColumn.Name = "iDECLIDataGridViewTextBoxColumn";
            // 
            // nOMCLIDataGridViewTextBoxColumn
            // 
            this.nOMCLIDataGridViewTextBoxColumn.DataPropertyName = "NOM_CLI";
            this.nOMCLIDataGridViewTextBoxColumn.HeaderText = "NOM_CLI";
            this.nOMCLIDataGridViewTextBoxColumn.Name = "nOMCLIDataGridViewTextBoxColumn";
            // 
            // pATCLIDataGridViewTextBoxColumn
            // 
            this.pATCLIDataGridViewTextBoxColumn.DataPropertyName = "PAT_CLI";
            this.pATCLIDataGridViewTextBoxColumn.HeaderText = "PAT_CLI";
            this.pATCLIDataGridViewTextBoxColumn.Name = "pATCLIDataGridViewTextBoxColumn";
            // 
            // mATCLIDataGridViewTextBoxColumn
            // 
            this.mATCLIDataGridViewTextBoxColumn.DataPropertyName = "MAT_CLI";
            this.mATCLIDataGridViewTextBoxColumn.HeaderText = "MAT_CLI";
            this.mATCLIDataGridViewTextBoxColumn.Name = "mATCLIDataGridViewTextBoxColumn";
            // 
            // fONCLIDataGridViewTextBoxColumn
            // 
            this.fONCLIDataGridViewTextBoxColumn.DataPropertyName = "FON_CLI";
            this.fONCLIDataGridViewTextBoxColumn.HeaderText = "FON_CLI";
            this.fONCLIDataGridViewTextBoxColumn.Name = "fONCLIDataGridViewTextBoxColumn";
            // 
            // dNICLIDataGridViewTextBoxColumn
            // 
            this.dNICLIDataGridViewTextBoxColumn.DataPropertyName = "DNI_CLI";
            this.dNICLIDataGridViewTextBoxColumn.HeaderText = "DNI_CLI";
            this.dNICLIDataGridViewTextBoxColumn.Name = "dNICLIDataGridViewTextBoxColumn";
            // 
            // dIRCLIDataGridViewTextBoxColumn
            // 
            this.dIRCLIDataGridViewTextBoxColumn.DataPropertyName = "DIR_CLI";
            this.dIRCLIDataGridViewTextBoxColumn.HeaderText = "DIR_CLI";
            this.dIRCLIDataGridViewTextBoxColumn.Name = "dIRCLIDataGridViewTextBoxColumn";
            // 
            // frmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 290);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.label1);
            this.Name = "frmListadoClientes";
            this.Text = "Listado de Clientes";
            this.Load += new System.EventHandler(this.frmListadoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTRATODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private CONTRATODataSet cONTRATODataSet;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private CONTRATODataSetTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDECLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMCLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATCLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATCLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fONCLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNICLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRCLIDataGridViewTextBoxColumn;
    }
}

