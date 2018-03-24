namespace pjFichaDevolucionXContratista
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboContratista = new System.Windows.Forms.ComboBox();
            this.dgFichaDevolucion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgFichaDevolucion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(663, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTADO DE FICHAS DE DEVOLUCIÓN POR CONTRATISTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONTRATISTA";
            // 
            // cboContratista
            // 
            this.cboContratista.FormattingEnabled = true;
            this.cboContratista.Location = new System.Drawing.Point(196, 53);
            this.cboContratista.Name = "cboContratista";
            this.cboContratista.Size = new System.Drawing.Size(304, 21);
            this.cboContratista.TabIndex = 2;
            this.cboContratista.SelectionChangeCommitted += new System.EventHandler(this.cboContratista_SelectionChangeCommitted);
            // 
            // dgFichaDevolucion
            // 
            this.dgFichaDevolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFichaDevolucion.Location = new System.Drawing.Point(17, 80);
            this.dgFichaDevolucion.Name = "dgFichaDevolucion";
            this.dgFichaDevolucion.Size = new System.Drawing.Size(658, 178);
            this.dgFichaDevolucion.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 271);
            this.Controls.Add(this.dgFichaDevolucion);
            this.Controls.Add(this.cboContratista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFichaDevolucion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboContratista;
        private System.Windows.Forms.DataGridView dgFichaDevolucion;
    }
}

