namespace pjFichasReclamoxAñoLinqToSQL
{
    partial class frmFichasxAño
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
            this.cboAño = new System.Windows.Forms.ComboBox();
            this.dgFichas = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(519, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "FICHA DE RECLAMO POR AÑO - LINQ TO SQL ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "SELECCIONE AÑO";
            // 
            // cboAño
            // 
            this.cboAño.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAño.FormattingEnabled = true;
            this.cboAño.Location = new System.Drawing.Point(145, 49);
            this.cboAño.Name = "cboAño";
            this.cboAño.Size = new System.Drawing.Size(121, 26);
            this.cboAño.TabIndex = 1;
            // 
            // dgFichas
            // 
            this.dgFichas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgFichas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgFichas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFichas.Location = new System.Drawing.Point(12, 87);
            this.dgFichas.Name = "dgFichas";
            this.dgFichas.Size = new System.Drawing.Size(519, 185);
            this.dgFichas.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(283, 47);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 28);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmFichasxAño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 284);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgFichas);
            this.Controls.Add(this.cboAño);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFichasxAño";
            this.Text = "Ficha de reclamo por año - LinQ To SQL";
            this.Load += new System.EventHandler(this.frmFichasxAño_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFichas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboAño;
        private System.Windows.Forms.DataGridView dgFichas;
        private System.Windows.Forms.Button btnBuscar;
    }
}

