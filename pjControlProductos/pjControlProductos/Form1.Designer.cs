namespace pjControlProductos
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
            this.tsNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsRegistrar = new System.Windows.Forms.ToolStripButton();
            this.tsModificar = new System.Windows.Forms.ToolStripButton();
            this.tsEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsSalir = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStockActual = new System.Windows.Forms.TextBox();
            this.txtStockMinimo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lvProductos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNuevo,
            this.tsRegistrar,
            this.tsModificar,
            this.tsEliminar,
            this.tsBuscar,
            this.tsSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(760, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsNuevo
            // 
            this.tsNuevo.AccessibleName = "NUEVO";
            this.tsNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsNuevo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsNuevo.Image")));
            this.tsNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNuevo.Name = "tsNuevo";
            this.tsNuevo.Size = new System.Drawing.Size(87, 25);
            this.tsNuevo.Tag = "";
            this.tsNuevo.Text = "NUEVO";
            this.tsNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsNuevo.ToolTipText = "NUEVO\r\n";
            this.tsNuevo.Click += new System.EventHandler(this.tsNuevo_Click);
            // 
            // tsRegistrar
            // 
            this.tsRegistrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("tsRegistrar.Image")));
            this.tsRegistrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRegistrar.Name = "tsRegistrar";
            this.tsRegistrar.Size = new System.Drawing.Size(114, 25);
            this.tsRegistrar.Text = "REGISTRAR";
            this.tsRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsRegistrar.Click += new System.EventHandler(this.tsRegistrar_Click);
            // 
            // tsModificar
            // 
            this.tsModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsModificar.Image")));
            this.tsModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsModificar.Name = "tsModificar";
            this.tsModificar.Size = new System.Drawing.Size(118, 25);
            this.tsModificar.Text = "MODIFICAR";
            this.tsModificar.Click += new System.EventHandler(this.tsModificar_Click);
            // 
            // tsEliminar
            // 
            this.tsEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsEliminar.Image")));
            this.tsEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEliminar.Name = "tsEliminar";
            this.tsEliminar.Size = new System.Drawing.Size(106, 25);
            this.tsEliminar.Text = "ELIMINAR";
            this.tsEliminar.Click += new System.EventHandler(this.tsEliminar_Click);
            // 
            // tsBuscar
            // 
            this.tsBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsBuscar.Image")));
            this.tsBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBuscar.Name = "tsBuscar";
            this.tsBuscar.Size = new System.Drawing.Size(92, 25);
            this.tsBuscar.Text = "BUSCAR";
            this.tsBuscar.Click += new System.EventHandler(this.tsBuscar_Click);
            // 
            // tsSalir
            // 
            this.tsSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsSalir.Image")));
            this.tsSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSalir.Name = "tsSalir";
            this.tsSalir.Size = new System.Drawing.Size(73, 25);
            this.tsSalir.Text = "SALIR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CÓDIGO";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(117, 47);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(77, 13);
            this.lblCodigo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DESCRIPCIÓN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CATEGORÍA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "STOCK ACTUAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "STOCK MÍNIMO";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(120, 77);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(335, 20);
            this.txtDescripcion.TabIndex = 7;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Items.AddRange(new object[] {
            "Bebida",
            "Otro"});
            this.cboCategoria.Location = new System.Drawing.Point(120, 106);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(174, 21);
            this.cboCategoria.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "PRECIO";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(355, 107);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 10;
            // 
            // txtStockActual
            // 
            this.txtStockActual.Location = new System.Drawing.Point(120, 139);
            this.txtStockActual.Name = "txtStockActual";
            this.txtStockActual.Size = new System.Drawing.Size(129, 20);
            this.txtStockActual.TabIndex = 11;
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.Location = new System.Drawing.Point(355, 139);
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.Size = new System.Drawing.Size(100, 20);
            this.txtStockMinimo.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Beige;
            this.label7.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(479, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 75);
            this.label7.TabIndex = 13;
            this.label7.Text = "CONTROL DE REGISTRO DE PRODUCTOS - LIST";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvProductos
            // 
            this.lvProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvProductos.Location = new System.Drawing.Point(15, 175);
            this.lvProductos.Name = "lvProductos";
            this.lvProductos.Size = new System.Drawing.Size(733, 97);
            this.lvProductos.TabIndex = 14;
            this.lvProductos.UseCompatibleStateImageBehavior = false;
            this.lvProductos.View = System.Windows.Forms.View.Details;
            this.lvProductos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvProductos_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CÓDIGO";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "DESCRIPCIÓN";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CATEGORÍA";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "PRECIO";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "STOCK ACT.";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "STOCK MÍN.";
            this.columnHeader6.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 297);
            this.Controls.Add(this.lvProductos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStockMinimo);
            this.Controls.Add(this.txtStockActual);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "CONTROL DE REGISTRO DE PRODUCTOS - LIST";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsRegistrar;
        private System.Windows.Forms.ToolStripButton tsNuevo;
        private System.Windows.Forms.ToolStripButton tsModificar;
        private System.Windows.Forms.ToolStripButton tsEliminar;
        private System.Windows.Forms.ToolStripButton tsBuscar;
        private System.Windows.Forms.ToolStripButton tsSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStockActual;
        private System.Windows.Forms.TextBox txtStockMinimo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvProductos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

