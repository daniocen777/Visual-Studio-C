namespace pjVentaHeredada
{
    partial class frmContado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.lvDetalle = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.lstResumen = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNeto = new System.Windows.Forms.Label();
            this.btnAdquirir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "VENTA DE PRODUCTOS AL CONTADO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRuc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 100);
            this.groupBox1.TabIndex = 1;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "FECHA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(673, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "HORA";
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(564, 74);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(72, 23);
            this.lblFecha.TabIndex = 4;
            // 
            // lblHora
            // 
            this.lblHora.Location = new System.Drawing.Point(673, 74);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(72, 23);
            this.lblHora.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cboProducto);
            this.groupBox2.Location = new System.Drawing.Point(12, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 100);
            this.groupBox2.TabIndex = 6;
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
            // lvDetalle
            // 
            this.lvDetalle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvDetalle.Location = new System.Drawing.Point(12, 260);
            this.lvDetalle.Name = "lvDetalle";
            this.lvDetalle.Size = new System.Drawing.Size(733, 71);
            this.lvDetalle.TabIndex = 7;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "RESUMEN";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lstResumen
            // 
            this.lstResumen.FormattingEnabled = true;
            this.lstResumen.Location = new System.Drawing.Point(12, 373);
            this.lstResumen.Name = "lstResumen";
            this.lstResumen.Size = new System.Drawing.Size(407, 121);
            this.lstResumen.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(576, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "NETO A PAGAR";
            // 
            // lblNeto
            // 
            this.lblNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeto.Location = new System.Drawing.Point(576, 401);
            this.lblNeto.Name = "lblNeto";
            this.lblNeto.Size = new System.Drawing.Size(120, 29);
            this.lblNeto.TabIndex = 11;
            // 
            // btnAdquirir
            // 
            this.btnAdquirir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdquirir.Location = new System.Drawing.Point(579, 182);
            this.btnAdquirir.Name = "btnAdquirir";
            this.btnAdquirir.Size = new System.Drawing.Size(132, 39);
            this.btnAdquirir.TabIndex = 12;
            this.btnAdquirir.Text = "ADQUIRIR";
            this.btnAdquirir.UseVisualStyleBackColor = true;
            this.btnAdquirir.Click += new System.EventHandler(this.btnAdquirir_Click);
            // 
            // frmContado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 508);
            this.Controls.Add(this.btnAdquirir);
            this.Controls.Add(this.lblNeto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lstResumen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lvDetalle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmContado";
            this.Text = "VENTA AL CONTADO";
            this.Load += new System.EventHandler(this.frmContado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.ListView lvDetalle;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstResumen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNeto;
        private System.Windows.Forms.Button btnAdquirir;
    }
}