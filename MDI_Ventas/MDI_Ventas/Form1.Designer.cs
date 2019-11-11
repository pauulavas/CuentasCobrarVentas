namespace MDI_Ventas
{
    partial class Form1
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
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoPagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeListaDePreciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descuentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDePreciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comisionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.polizasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nominasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_id_usuario = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1649, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.inicioToolStripMenuItem.Text = "Inicio ";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoClientesToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.impuestoToolStripMenuItem,
            this.tipoPagosToolStripMenuItem,
            this.tipoFacturaToolStripMenuItem,
            this.serieToolStripMenuItem,
            this.tipoDeListaDePreciosToolStripMenuItem,
            this.descuentosToolStripMenuItem,
            this.folioToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // tipoClientesToolStripMenuItem
            // 
            this.tipoClientesToolStripMenuItem.Name = "tipoClientesToolStripMenuItem";
            this.tipoClientesToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.tipoClientesToolStripMenuItem.Text = "Tipo Clientes";
            this.tipoClientesToolStripMenuItem.Click += new System.EventHandler(this.TipoClientesToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.ClientesToolStripMenuItem_Click);
            // 
            // impuestoToolStripMenuItem
            // 
            this.impuestoToolStripMenuItem.Name = "impuestoToolStripMenuItem";
            this.impuestoToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.impuestoToolStripMenuItem.Text = "Impuestos";
            this.impuestoToolStripMenuItem.Click += new System.EventHandler(this.ImpuestoToolStripMenuItem_Click);
            // 
            // tipoPagosToolStripMenuItem
            // 
            this.tipoPagosToolStripMenuItem.Name = "tipoPagosToolStripMenuItem";
            this.tipoPagosToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.tipoPagosToolStripMenuItem.Text = "Tipo Pagos";
            this.tipoPagosToolStripMenuItem.Click += new System.EventHandler(this.TipoPagosToolStripMenuItem_Click);
            // 
            // tipoFacturaToolStripMenuItem
            // 
            this.tipoFacturaToolStripMenuItem.Name = "tipoFacturaToolStripMenuItem";
            this.tipoFacturaToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.tipoFacturaToolStripMenuItem.Text = "Tipo Factura";
            this.tipoFacturaToolStripMenuItem.Click += new System.EventHandler(this.TipoFacturaToolStripMenuItem_Click);
            // 
            // serieToolStripMenuItem
            // 
            this.serieToolStripMenuItem.Name = "serieToolStripMenuItem";
            this.serieToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.serieToolStripMenuItem.Text = "Serie";
            this.serieToolStripMenuItem.Click += new System.EventHandler(this.SerieToolStripMenuItem_Click);
            // 
            // tipoDeListaDePreciosToolStripMenuItem
            // 
            this.tipoDeListaDePreciosToolStripMenuItem.Name = "tipoDeListaDePreciosToolStripMenuItem";
            this.tipoDeListaDePreciosToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.tipoDeListaDePreciosToolStripMenuItem.Text = "Tipo de Lista de Precios";
            this.tipoDeListaDePreciosToolStripMenuItem.Click += new System.EventHandler(this.TipoDeListaDePreciosToolStripMenuItem_Click);
            // 
            // descuentosToolStripMenuItem
            // 
            this.descuentosToolStripMenuItem.Name = "descuentosToolStripMenuItem";
            this.descuentosToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.descuentosToolStripMenuItem.Text = "Tipos Descuentos";
            this.descuentosToolStripMenuItem.Click += new System.EventHandler(this.DescuentosToolStripMenuItem_Click);
            // 
            // folioToolStripMenuItem
            // 
            this.folioToolStripMenuItem.Name = "folioToolStripMenuItem";
            this.folioToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.folioToolStripMenuItem.Text = "Folio";
            this.folioToolStripMenuItem.Click += new System.EventHandler(this.FolioToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDePreciosToolStripMenuItem,
            this.facturaciónToolStripMenuItem,
            this.movimientoDeClientesToolStripMenuItem,
            this.comisionesToolStripMenuItem1,
            this.polizasToolStripMenuItem,
            this.nominasToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // listaDePreciosToolStripMenuItem
            // 
            this.listaDePreciosToolStripMenuItem.Name = "listaDePreciosToolStripMenuItem";
            this.listaDePreciosToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.listaDePreciosToolStripMenuItem.Text = "Lista de Precios";
            this.listaDePreciosToolStripMenuItem.Click += new System.EventHandler(this.ListaDePreciosToolStripMenuItem_Click);
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cotizaciónToolStripMenuItem,
            this.pedidoToolStripMenuItem,
            this.facturaToolStripMenuItem,
            this.devolucionesToolStripMenuItem});
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.facturaciónToolStripMenuItem.Text = "Ventas";
            // 
            // cotizaciónToolStripMenuItem
            // 
            this.cotizaciónToolStripMenuItem.Name = "cotizaciónToolStripMenuItem";
            this.cotizaciónToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.cotizaciónToolStripMenuItem.Text = "Cotización";
            this.cotizaciónToolStripMenuItem.Click += new System.EventHandler(this.CotizaciónToolStripMenuItem_Click);
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.pedidoToolStripMenuItem.Text = "Pedido";
            this.pedidoToolStripMenuItem.Click += new System.EventHandler(this.PedidoToolStripMenuItem_Click);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.facturaToolStripMenuItem.Text = "Factura";
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.FacturaToolStripMenuItem_Click);
            // 
            // devolucionesToolStripMenuItem
            // 
            this.devolucionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.devolucionesToolStripMenuItem.Name = "devolucionesToolStripMenuItem";
            this.devolucionesToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.devolucionesToolStripMenuItem.Text = "Devoluciones";
            // 
            // ingresoToolStripMenuItem
            // 
            this.ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            this.ingresoToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.ingresoToolStripMenuItem.Text = "Ingreso";
            this.ingresoToolStripMenuItem.Click += new System.EventHandler(this.IngresoToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.ConsultaToolStripMenuItem_Click);
            // 
            // movimientoDeClientesToolStripMenuItem
            // 
            this.movimientoDeClientesToolStripMenuItem.Name = "movimientoDeClientesToolStripMenuItem";
            this.movimientoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.movimientoDeClientesToolStripMenuItem.Text = "Movimiento de Clientes";
            this.movimientoDeClientesToolStripMenuItem.Click += new System.EventHandler(this.MovimientoDeClientesToolStripMenuItem_Click);
            // 
            // comisionesToolStripMenuItem1
            // 
            this.comisionesToolStripMenuItem1.Name = "comisionesToolStripMenuItem1";
            this.comisionesToolStripMenuItem1.Size = new System.Drawing.Size(249, 26);
            this.comisionesToolStripMenuItem1.Text = "Comisiones";
            this.comisionesToolStripMenuItem1.Click += new System.EventHandler(this.ComisionesToolStripMenuItem1_Click);
            // 
            // polizasToolStripMenuItem
            // 
            this.polizasToolStripMenuItem.Name = "polizasToolStripMenuItem";
            this.polizasToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.polizasToolStripMenuItem.Text = "Polizas";
            this.polizasToolStripMenuItem.Click += new System.EventHandler(this.PolizasToolStripMenuItem_Click);
            // 
            // nominasToolStripMenuItem
            // 
            this.nominasToolStripMenuItem.Name = "nominasToolStripMenuItem";
            this.nominasToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.nominasToolStripMenuItem.Text = "Nominas";
            this.nominasToolStripMenuItem.Click += new System.EventHandler(this.NominasToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // ayudasToolStripMenuItem
            // 
            this.ayudasToolStripMenuItem.Name = "ayudasToolStripMenuItem";
            this.ayudasToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.ayudasToolStripMenuItem.Text = "Ayudas";
            this.ayudasToolStripMenuItem.Click += new System.EventHandler(this.AyudasToolStripMenuItem_Click);
            // 
            // lbl_id_usuario
            // 
            this.lbl_id_usuario.AutoSize = true;
            this.lbl_id_usuario.Location = new System.Drawing.Point(738, 9);
            this.lbl_id_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id_usuario.Name = "lbl_id_usuario";
            this.lbl_id_usuario.Size = new System.Drawing.Size(46, 17);
            this.lbl_id_usuario.TabIndex = 5;
            this.lbl_id_usuario.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1649, 857);
            this.Controls.Add(this.lbl_id_usuario);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impuestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoPagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeListaDePreciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descuentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDePreciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comisionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem polizasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nominasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.Label lbl_id_usuario;
    }
}

