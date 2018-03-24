namespace pjSerializacionDatos
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
            this.tsRegistrar = new System.Windows.Forms.ToolStripButton();
            this.tsMostrar = new System.Windows.Forms.ToolStripButton();
            this.tsSalir = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsRegistrar,
            this.tsMostrar,
            this.tsSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(726, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsRegistrar
            // 
            this.tsRegistrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("tsRegistrar.Image")));
            this.tsRegistrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRegistrar.Name = "tsRegistrar";
            this.tsRegistrar.Size = new System.Drawing.Size(118, 22);
            this.tsRegistrar.Text = "REGISTRAR CLIENTE";
            this.tsRegistrar.Click += new System.EventHandler(this.tsRegistrar_Click);
            // 
            // tsMostrar
            // 
            this.tsMostrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsMostrar.Image = ((System.Drawing.Image)(resources.GetObject("tsMostrar.Image")));
            this.tsMostrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMostrar.Name = "tsMostrar";
            this.tsMostrar.Size = new System.Drawing.Size(114, 22);
            this.tsMostrar.Text = "MOSTRAR CLIENTE";
            this.tsMostrar.Click += new System.EventHandler(this.tsMostrar_Click);
            // 
            // tsSalir
            // 
            this.tsSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsSalir.Image")));
            this.tsSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSalir.Name = "tsSalir";
            this.tsSalir.Size = new System.Drawing.Size(41, 22);
            this.tsSalir.Text = "SALIR";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(701, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTROS DE DATOS DE CLIENTES CON IMAGEN - SERIALIZACIÓN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "PATERNO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "MATERNO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "TELÉFONO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "EMAIL";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(116, 98);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(404, 20);
            this.txtNombres.TabIndex = 7;
            // 
            // txtPaterno
            // 
            this.txtPaterno.Location = new System.Drawing.Point(116, 133);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(160, 20);
            this.txtPaterno.TabIndex = 8;
            // 
            // txtMaterno
            // 
            this.txtMaterno.Location = new System.Drawing.Point(360, 133);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(160, 20);
            this.txtMaterno.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(116, 166);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(160, 20);
            this.txtTelefono.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(116, 203);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(404, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(584, 96);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(112, 90);
            this.pbFoto.TabIndex = 12;
            this.pbFoto.TabStop = false;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(584, 206);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(112, 23);
            this.btnExaminar.TabIndex = 13;
            this.btnExaminar.Text = "EXAMINAR";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 240);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtMaterno);
            this.Controls.Add(this.txtPaterno);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsRegistrar;
        private System.Windows.Forms.ToolStripButton tsMostrar;
        private System.Windows.Forms.ToolStripButton tsSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnExaminar;
    }
}

