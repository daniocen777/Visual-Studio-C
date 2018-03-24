namespace pjListadoEquipoTableAdapter
{
    partial class frmListadoEquipos
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
            this.dgEquipos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEquipos
            // 
            this.dgEquipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgEquipos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEquipos.Location = new System.Drawing.Point(11, 39);
            this.dgEquipos.Name = "dgEquipos";
            this.dgEquipos.Size = new System.Drawing.Size(566, 223);
            this.dgEquipos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "LISTADO DE EQUIPOS - TABLEADAPTER";
            // 
            // frmListadoEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 270);
            this.Controls.Add(this.dgEquipos);
            this.Controls.Add(this.label1);
            this.Name = "frmListadoEquipos";
            this.Text = "Listado de equipos - TableAdapter";
            this.Load += new System.EventHandler(this.frmListadoEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEquipos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEquipos;
        private System.Windows.Forms.Label label1;
    }
}

