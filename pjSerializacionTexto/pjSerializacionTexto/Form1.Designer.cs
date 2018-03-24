namespace pjSerializacionTexto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsSerializar = new System.Windows.Forms.ToolStripButton();
            this.tsDeserializar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSerializar,
            this.tsDeserializar,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(619, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsSerializar
            // 
            this.tsSerializar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsSerializar.Image = ((System.Drawing.Image)(resources.GetObject("tsSerializar.Image")));
            this.tsSerializar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSerializar.Name = "tsSerializar";
            this.tsSerializar.Size = new System.Drawing.Size(72, 22);
            this.tsSerializar.Text = "SERIALIZAR";
            this.tsSerializar.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsDeserializar
            // 
            this.tsDeserializar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsDeserializar.Image = ((System.Drawing.Image)(resources.GetObject("tsDeserializar.Image")));
            this.tsDeserializar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDeserializar.Name = "tsDeserializar";
            this.tsDeserializar.Size = new System.Drawing.Size(86, 22);
            this.tsDeserializar.Text = "DESERIALIZAR";
            this.tsDeserializar.Click += new System.EventHandler(this.tsDeserializar_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(41, 22);
            this.toolStripButton3.Text = "SALIR";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "SERIALIACIÓN DE CADENA";
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(12, 70);
            this.txtCadena.Multiline = true;
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(595, 158);
            this.txtCadena.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 243);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsSerializar;
        private System.Windows.Forms.ToolStripButton tsDeserializar;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCadena;
    }
}

