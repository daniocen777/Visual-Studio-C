namespace pjFichasReclamoxCliente
{
    partial class frmFichasxCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.dgFichas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgFichas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTADO DE FICHAS DE RECLAMO POR CLIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "SELECCIONE CLIENTE";
            // 
            // cboCliente
            // 
            this.cboCliente.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(188, 51);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(278, 26);
            this.cboCliente.TabIndex = 1;
            this.cboCliente.SelectionChangeCommitted += new System.EventHandler(this.cboCliente_SelectionChangeCommitted);
            // 
            // dgFichas
            // 
            this.dgFichas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFichas.Location = new System.Drawing.Point(12, 90);
            this.dgFichas.Name = "dgFichas";
            this.dgFichas.Size = new System.Drawing.Size(522, 159);
            this.dgFichas.TabIndex = 2;
            // 
            // frmFichasxCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 264);
            this.Controls.Add(this.dgFichas);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFichasxCliente";
            this.Text = "Listado de fichas de reclamo por cliente";
            this.Load += new System.EventHandler(this.frmFichasxCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFichas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.DataGridView dgFichas;
    }
}

