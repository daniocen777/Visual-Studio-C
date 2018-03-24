namespace pjControlPersonal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPeterno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lvPersonal = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtFechaContrato = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(733, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONSTROL DE REGISTRO PERSONAL - ARRAYLIST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CÓDIGO";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(83, 58);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(81, 13);
            this.lblCodigo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "PATERNO";
            // 
            // txtPeterno
            // 
            this.txtPeterno.Location = new System.Drawing.Point(16, 116);
            this.txtPeterno.Name = "txtPeterno";
            this.txtPeterno.Size = new System.Drawing.Size(177, 20);
            this.txtPeterno.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "MATERNO";
            // 
            // txtMaterno
            // 
            this.txtMaterno.Location = new System.Drawing.Point(217, 116);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(177, 20);
            this.txtMaterno.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "NOMBRES";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(420, 116);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(310, 20);
            this.txtNombres.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "FECHA DE NACIMIENTO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "FECHA DE CONTRATO";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNuevo.Location = new System.Drawing.Point(16, 232);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(93, 40);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.BackgroundImage")));
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(115, 232);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(114, 40);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnModificar.Location = new System.Drawing.Point(235, 232);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(114, 40);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEliminar.Location = new System.Drawing.Point(355, 232);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 40);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSalir.Location = new System.Drawing.Point(650, 232);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 40);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lvPersonal
            // 
            this.lvPersonal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvPersonal.Location = new System.Drawing.Point(16, 293);
            this.lvPersonal.Name = "lvPersonal";
            this.lvPersonal.Size = new System.Drawing.Size(714, 115);
            this.lvPersonal.TabIndex = 18;
            this.lvPersonal.UseCompatibleStateImageBehavior = false;
            this.lvPersonal.View = System.Windows.Forms.View.Details;
            this.lvPersonal.SelectedIndexChanged += new System.EventHandler(this.lvPersonal_SelectedIndexChanged);
            this.lvPersonal.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvPersonal_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CÓDIGO";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PATERNO";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "METERNO";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "NOMBRES";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 190;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "FECHA NAC.";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "FECHA CONTRAT.";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 100;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaNacimiento.Location = new System.Drawing.Point(16, 185);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(177, 20);
            this.txtFechaNacimiento.TabIndex = 21;
            // 
            // txtFechaContrato
            // 
            this.txtFechaContrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaContrato.Location = new System.Drawing.Point(217, 185);
            this.txtFechaContrato.Name = "txtFechaContrato";
            this.txtFechaContrato.Size = new System.Drawing.Size(177, 20);
            this.txtFechaContrato.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 425);
            this.Controls.Add(this.txtFechaContrato);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.lvPersonal);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaterno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPeterno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ARRAYLIST";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPeterno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListView lvPersonal;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.DateTimePicker txtFechaNacimiento;
        private System.Windows.Forms.DateTimePicker txtFechaContrato;
    }
}

