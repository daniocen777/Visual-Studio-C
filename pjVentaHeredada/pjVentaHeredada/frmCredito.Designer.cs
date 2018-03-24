namespace pjVentaHeredada
{
    partial class frmCredito
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
            this.btnAdquirir = new System.Windows.Forms.Button();
            this.lvDetalle = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboLetras = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lvResumen = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblMonto = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "VENTA DE PRODUCTOS AL CRÉDITO";
            // 
            // btnAdquirir
            // 
            this.btnAdquirir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdquirir.Location = new System.Drawing.Point(579, 176);
            this.btnAdquirir.Name = "btnAdquirir";
            this.btnAdquirir.Size = new System.Drawing.Size(132, 39);
            this.btnAdquirir.TabIndex = 20;
            this.btnAdquirir.Text = "ADQUIRIR";
            this.btnAdquirir.UseVisualStyleBackColor = true;
            this.btnAdquirir.Click += new System.EventHandler(this.btnAdquirir_Click);
            // 
            // lvDetalle
            // 
            this.lvDetalle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvDetalle.Location = new System.Drawing.Point(12, 254);
            this.lvDetalle.Name = "lvDetalle";
            this.lvDetalle.Size = new System.Drawing.Size(733, 71);
            this.lvDetalle.TabIndex = 19;
            this.lvDetalle.UseCompatibleStateImageBehavior = false;
            this.lvDetalle.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ITEM";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "DESCRIPCIÓN DEL PRODUCTO";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CANTIDAD";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "PRECIO";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SUBTOTAL";
            this.columnHeader5.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cboProducto);
            this.groupBox2.Location = new System.Drawing.Point(12, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 100);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS DE LA VENTA";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(221, 55);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(125, 20);
            this.txtCantidad.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "CANTIDAD SOLICITADA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "SELECCIONE UN PRODUCTO";
            // 
            // cboProducto
            // 
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(9, 55);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(185, 21);
            this.cboProducto.TabIndex = 0;
            // 
            // lblHora
            // 
            this.lblHora.Location = new System.Drawing.Point(673, 68);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(72, 23);
            this.lblHora.TabIndex = 17;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(564, 68);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(72, 23);
            this.lblFecha.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(673, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "HORA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "FECHA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRuc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL CLIENTE";
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(325, 51);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(150, 20);
            this.txtRuc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "RUC";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(9, 51);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(297, 20);
            this.txtCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "CLIENTE O RAZÓN SOCIAL";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cboLetras);
            this.groupBox3.Location = new System.Drawing.Point(12, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 127);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OPCIONES DE CRÉDITO";
            // 
            // cboLetras
            // 
            this.cboLetras.FormattingEnabled = true;
            this.cboLetras.Location = new System.Drawing.Point(9, 60);
            this.cboLetras.Name = "cboLetras";
            this.cboLetras.Size = new System.Drawing.Size(128, 21);
            this.cboLetras.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "SELECCIONE LETRAS";
            // 
            // lvResumen
            // 
            this.lvResumen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.lvResumen.Location = new System.Drawing.Point(214, 346);
            this.lvResumen.Name = "lvResumen";
            this.lvResumen.Size = new System.Drawing.Size(222, 127);
            this.lvResumen.TabIndex = 22;
            this.lvResumen.UseCompatibleStateImageBehavior = false;
            this.lvResumen.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 87);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "MOSTRAR RESUMEN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "N° DE LETRA";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "MONTO";
            this.columnHeader7.Width = 90;
            // 
            // lblMonto
            // 
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(591, 374);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(120, 29);
            this.lblMonto.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(576, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "MPONTO A PAGAR";
            // 
            // frmCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 530);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lvResumen);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnAdquirir);
            this.Controls.Add(this.lvDetalle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmCredito";
            this.Text = "VENTA CRÉDITO";
            this.Load += new System.EventHandler(this.frmCredito_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdquirir;
        private System.Windows.Forms.ListView lvDetalle;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboLetras;
        private System.Windows.Forms.ListView lvResumen;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label label9;
    }
}