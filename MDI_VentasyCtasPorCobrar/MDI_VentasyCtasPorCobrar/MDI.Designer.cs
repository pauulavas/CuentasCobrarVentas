namespace MDI_VentasyCtasPorCobrar
{
    partial class MDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cuentasPorCobrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comisionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaPreciosDetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descuentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDePreciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polizasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comisionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentasPorCobrarToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.listaDePreciosToolStripMenuItem,
            this.polizasToolStripMenuItem,
            this.comisionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1712, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cuentasPorCobrarToolStripMenuItem
            // 
            this.cuentasPorCobrarToolStripMenuItem.Checked = true;
            this.cuentasPorCobrarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cuentasPorCobrarToolStripMenuItem.Name = "cuentasPorCobrarToolStripMenuItem";
            this.cuentasPorCobrarToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.cuentasPorCobrarToolStripMenuItem.Text = "Inicio";
            this.cuentasPorCobrarToolStripMenuItem.Click += new System.EventHandler(this.CuentasPorCobrarToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.tipoClienteToolStripMenuItem,
            this.impuestosToolStripMenuItem,
            this.pagosToolStripMenuItem,
            this.comisionesToolStripMenuItem1,
            this.tipoFacturaToolStripMenuItem,
            this.impuestoToolStripMenuItem,
            this.serieToolStripMenuItem,
            this.listaPreciosDetalleToolStripMenuItem,
            this.descuentosToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            this.mantenimientoToolStripMenuItem.Click += new System.EventHandler(this.MantenimientoToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.ClienteToolStripMenuItem_Click);
            // 
            // tipoClienteToolStripMenuItem
            // 
            this.tipoClienteToolStripMenuItem.Name = "tipoClienteToolStripMenuItem";
            this.tipoClienteToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.tipoClienteToolStripMenuItem.Text = "Tipo Cliente";
            this.tipoClienteToolStripMenuItem.Click += new System.EventHandler(this.TipoClienteToolStripMenuItem_Click);
            // 
            // impuestosToolStripMenuItem
            // 
            this.impuestosToolStripMenuItem.Name = "impuestosToolStripMenuItem";
            this.impuestosToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.impuestosToolStripMenuItem.Text = "Impuesto";
            this.impuestosToolStripMenuItem.Click += new System.EventHandler(this.ImpuestosToolStripMenuItem_Click);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.pagosToolStripMenuItem.Text = "Tipo Pagos";
            this.pagosToolStripMenuItem.Click += new System.EventHandler(this.PagosToolStripMenuItem_Click);
            // 
            // comisionesToolStripMenuItem1
            // 
            this.comisionesToolStripMenuItem1.Name = "comisionesToolStripMenuItem1";
            this.comisionesToolStripMenuItem1.Size = new System.Drawing.Size(228, 26);
            this.comisionesToolStripMenuItem1.Text = "Comisiones";
            this.comisionesToolStripMenuItem1.Click += new System.EventHandler(this.ComisionesToolStripMenuItem1_Click);
            // 
            // tipoFacturaToolStripMenuItem
            // 
            this.tipoFacturaToolStripMenuItem.Name = "tipoFacturaToolStripMenuItem";
            this.tipoFacturaToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.tipoFacturaToolStripMenuItem.Text = "Tipo Factura";
            this.tipoFacturaToolStripMenuItem.Click += new System.EventHandler(this.TipoFacturaToolStripMenuItem_Click);
            // 
            // impuestoToolStripMenuItem
            // 
            this.impuestoToolStripMenuItem.Name = "impuestoToolStripMenuItem";
            this.impuestoToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.impuestoToolStripMenuItem.Text = "Impuesto";
            this.impuestoToolStripMenuItem.Click += new System.EventHandler(this.ImpuestoToolStripMenuItem_Click);
            // 
            // serieToolStripMenuItem
            // 
            this.serieToolStripMenuItem.Name = "serieToolStripMenuItem";
            this.serieToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.serieToolStripMenuItem.Text = "Serie";
            this.serieToolStripMenuItem.Click += new System.EventHandler(this.SerieToolStripMenuItem_Click);
            // 
            // listaPreciosDetalleToolStripMenuItem
            // 
            this.listaPreciosDetalleToolStripMenuItem.Name = "listaPreciosDetalleToolStripMenuItem";
            this.listaPreciosDetalleToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.listaPreciosDetalleToolStripMenuItem.Text = "Tipo de Lista Precios";
            this.listaPreciosDetalleToolStripMenuItem.Click += new System.EventHandler(this.ListaPreciosDetalleToolStripMenuItem_Click);
            // 
            // descuentosToolStripMenuItem
            // 
            this.descuentosToolStripMenuItem.Name = "descuentosToolStripMenuItem";
            this.descuentosToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.descuentosToolStripMenuItem.Text = "Descuentos";
            this.descuentosToolStripMenuItem.Click += new System.EventHandler(this.DescuentosToolStripMenuItem_Click);
            // 
            // listaDePreciosToolStripMenuItem
            // 
            this.listaDePreciosToolStripMenuItem.Name = "listaDePreciosToolStripMenuItem";
            this.listaDePreciosToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.listaDePreciosToolStripMenuItem.Text = "Reportes";
            // 
            // polizasToolStripMenuItem
            // 
            this.polizasToolStripMenuItem.Name = "polizasToolStripMenuItem";
            this.polizasToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.polizasToolStripMenuItem.Text = "Herramientas";
            // 
            // comisionesToolStripMenuItem
            // 
            this.comisionesToolStripMenuItem.Name = "comisionesToolStripMenuItem";
            this.comisionesToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.comisionesToolStripMenuItem.Text = "Ayudas";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1712, 922);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDI";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.MDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cuentasPorCobrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDePreciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polizasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comisionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comisionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tipoFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impuestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaPreciosDetalleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descuentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
    }
}

