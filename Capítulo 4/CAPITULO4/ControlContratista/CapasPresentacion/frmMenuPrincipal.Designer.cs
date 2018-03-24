namespace CapasPresentacion
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mantenimientoContratistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarContratistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarContratistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarContratistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoContratistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaContratistaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoContratistaToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 26);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mantenimientoContratistaToolStripMenuItem
            // 
            this.mantenimientoContratistaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarContratistaToolStripMenuItem,
            this.buscarContratistaToolStripMenuItem,
            this.eliminarContratistaToolStripMenuItem,
            this.nuevoContratistaToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.mantenimientoContratistaToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mantenimientoContratistaToolStripMenuItem.Name = "mantenimientoContratistaToolStripMenuItem";
            this.mantenimientoContratistaToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.mantenimientoContratistaToolStripMenuItem.Text = "Mantenimiento Contratista";
            // 
            // actualizarContratistaToolStripMenuItem
            // 
            this.actualizarContratistaToolStripMenuItem.Name = "actualizarContratistaToolStripMenuItem";
            this.actualizarContratistaToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.actualizarContratistaToolStripMenuItem.Text = "Actualizar Contratista";
            this.actualizarContratistaToolStripMenuItem.Click += new System.EventHandler(this.actualizarContratistaToolStripMenuItem_Click);
            // 
            // buscarContratistaToolStripMenuItem
            // 
            this.buscarContratistaToolStripMenuItem.Name = "buscarContratistaToolStripMenuItem";
            this.buscarContratistaToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.buscarContratistaToolStripMenuItem.Text = "Buscar Contratista";
            this.buscarContratistaToolStripMenuItem.Click += new System.EventHandler(this.buscarContratistaToolStripMenuItem_Click);
            // 
            // eliminarContratistaToolStripMenuItem
            // 
            this.eliminarContratistaToolStripMenuItem.Name = "eliminarContratistaToolStripMenuItem";
            this.eliminarContratistaToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.eliminarContratistaToolStripMenuItem.Text = "Eliminar Contratista";
            this.eliminarContratistaToolStripMenuItem.Click += new System.EventHandler(this.eliminarContratistaToolStripMenuItem_Click);
            // 
            // nuevoContratistaToolStripMenuItem
            // 
            this.nuevoContratistaToolStripMenuItem.Name = "nuevoContratistaToolStripMenuItem";
            this.nuevoContratistaToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.nuevoContratistaToolStripMenuItem.Text = "Nuevo Contratista";
            this.nuevoContratistaToolStripMenuItem.Click += new System.EventHandler(this.nuevoContratistaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(249, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaGeneralToolStripMenuItem,
            this.agendaContratistaToolStripMenuItem1});
            this.consultasToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // listaGeneralToolStripMenuItem
            // 
            this.listaGeneralToolStripMenuItem.Name = "listaGeneralToolStripMenuItem";
            this.listaGeneralToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.listaGeneralToolStripMenuItem.Text = "Lista General";
            this.listaGeneralToolStripMenuItem.Click += new System.EventHandler(this.listaGeneralToolStripMenuItem_Click);
            // 
            // agendaContratistaToolStripMenuItem1
            // 
            this.agendaContratistaToolStripMenuItem1.Name = "agendaContratistaToolStripMenuItem1";
            this.agendaContratistaToolStripMenuItem1.Size = new System.Drawing.Size(220, 22);
            this.agendaContratistaToolStripMenuItem1.Text = "Agenda Contratista";
            this.agendaContratistaToolStripMenuItem1.Click += new System.EventHandler(this.agendaContratistaToolStripMenuItem1_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMenuPrincipal";
            this.Text = "SISTEMA DE CONTROL DE CONTRATISTA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoContratistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarContratistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarContratistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarContratistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoContratistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaContratistaToolStripMenuItem1;
    }
}



