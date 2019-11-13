namespace CapaDiseno_CxC_MovClientes
{
    partial class MovimientoClientes
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbc_Generar = new System.Windows.Forms.TabPage();
            this.gb_DetalleMov = new System.Windows.Forms.GroupBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_Descuento = new System.Windows.Forms.ComboBox();
            this.Dgv_detalleComprobante = new System.Windows.Forms.DataGridView();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Descuento = new System.Windows.Forms.Label();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.Gpb_EncabezadoComprobante = new System.Windows.Forms.GroupBox();
            this.cbo_per = new System.Windows.Forms.ComboBox();
            this.lbl_periodo = new System.Windows.Forms.Label();
            this.txt_vigencia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_codigoMov = new System.Windows.Forms.TextBox();
            this.lbl_CodigoMovimiento = new System.Windows.Forms.Label();
            this.cbo_codigoCliente = new System.Windows.Forms.ComboBox();
            this.cbo_factura = new System.Windows.Forms.ComboBox();
            this.date_FechaEmision = new System.Windows.Forms.DateTimePicker();
            this.txt_CentroCosto = new System.Windows.Forms.TextBox();
            this.lbl_CentroCosto = new System.Windows.Forms.Label();
            this.cbo_codigoVendedor = new System.Windows.Forms.ComboBox();
            this.lbl_CodigoVendedor = new System.Windows.Forms.Label();
            this.lbl_CodigoCliente = new System.Windows.Forms.Label();
            this.txt_Cotización = new System.Windows.Forms.TextBox();
            this.lbl_cotizacion = new System.Windows.Forms.Label();
            this.cbo_TipoMoneda = new System.Windows.Forms.ComboBox();
            this.lbl_Moneda = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.lbl_NoComprobante = new System.Windows.Forms.Label();
            this.cbo_TipoComprobante = new System.Windows.Forms.ComboBox();
            this.lbl_TipoComprobante = new System.Windows.Forms.Label();
            this.tbc_MovimientosClientes = new System.Windows.Forms.TabControl();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_war10 = new System.Windows.Forms.Label();
            this.lbl_war9 = new System.Windows.Forms.Label();
            this.lbl_war8 = new System.Windows.Forms.Label();
            this.Btn_generar = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.lbl_war3 = new System.Windows.Forms.Label();
            this.lbl_war7 = new System.Windows.Forms.Label();
            this.lbl_war6 = new System.Windows.Forms.Label();
            this.lbl_war5 = new System.Windows.Forms.Label();
            this.lbl_war4 = new System.Windows.Forms.Label();
            this.lbl_war2 = new System.Windows.Forms.Label();
            this.lbl_war = new System.Windows.Forms.Label();
            this.btn_detalle = new System.Windows.Forms.Button();
            this.tbc_Generar.SuspendLayout();
            this.gb_DetalleMov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalleComprobante)).BeginInit();
            this.Gpb_EncabezadoComprobante.SuspendLayout();
            this.tbc_MovimientosClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_Generar
            // 
            this.tbc_Generar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.tbc_Generar.Controls.Add(this.gb_DetalleMov);
            this.tbc_Generar.Controls.Add(this.Gpb_EncabezadoComprobante);
            this.tbc_Generar.Location = new System.Drawing.Point(4, 25);
            this.tbc_Generar.Margin = new System.Windows.Forms.Padding(4);
            this.tbc_Generar.Name = "tbc_Generar";
            this.tbc_Generar.Padding = new System.Windows.Forms.Padding(4);
            this.tbc_Generar.Size = new System.Drawing.Size(1353, 864);
            this.tbc_Generar.TabIndex = 0;
            this.tbc_Generar.Text = "Movimientos de Clientes";
            // 
            // gb_DetalleMov
            // 
            this.gb_DetalleMov.Controls.Add(this.btn_Cancelar);
            this.gb_DetalleMov.Controls.Add(this.lbl_war10);
            this.gb_DetalleMov.Controls.Add(this.lbl_war9);
            this.gb_DetalleMov.Controls.Add(this.lbl_war8);
            this.gb_DetalleMov.Controls.Add(this.txt_descripcion);
            this.gb_DetalleMov.Controls.Add(this.label2);
            this.gb_DetalleMov.Controls.Add(this.Btn_generar);
            this.gb_DetalleMov.Controls.Add(this.cbo_Descuento);
            this.gb_DetalleMov.Controls.Add(this.Dgv_detalleComprobante);
            this.gb_DetalleMov.Controls.Add(this.lbl_Descuento);
            this.gb_DetalleMov.Controls.Add(this.txt_Precio);
            this.gb_DetalleMov.Controls.Add(this.lbl_Precio);
            this.gb_DetalleMov.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_DetalleMov.Location = new System.Drawing.Point(13, 321);
            this.gb_DetalleMov.Margin = new System.Windows.Forms.Padding(4);
            this.gb_DetalleMov.Name = "gb_DetalleMov";
            this.gb_DetalleMov.Padding = new System.Windows.Forms.Padding(4);
            this.gb_DetalleMov.Size = new System.Drawing.Size(1319, 537);
            this.gb_DetalleMov.TabIndex = 1;
            this.gb_DetalleMov.TabStop = false;
            this.gb_DetalleMov.Text = "Detalle Movimiento";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(215, 63);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(800, 52);
            this.txt_descripcion.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Descripcion";
            // 
            // cbo_Descuento
            // 
            this.cbo_Descuento.FormattingEnabled = true;
            this.cbo_Descuento.Location = new System.Drawing.Point(686, 142);
            this.cbo_Descuento.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_Descuento.Name = "cbo_Descuento";
            this.cbo_Descuento.Size = new System.Drawing.Size(43, 24);
            this.cbo_Descuento.TabIndex = 34;
            this.cbo_Descuento.SelectedIndexChanged += new System.EventHandler(this.cbo_Descuento_SelectedIndexChanged);
            this.cbo_Descuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbo_Descuento_KeyPress);
            // 
            // Dgv_detalleComprobante
            // 
            this.Dgv_detalleComprobante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_detalleComprobante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Articulo,
            this.Concepto,
            this.Cantidad,
            this.Precio});
            this.Dgv_detalleComprobante.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dgv_detalleComprobante.Location = new System.Drawing.Point(23, 241);
            this.Dgv_detalleComprobante.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_detalleComprobante.Name = "Dgv_detalleComprobante";
            this.Dgv_detalleComprobante.ReadOnly = true;
            this.Dgv_detalleComprobante.RowHeadersWidth = 51;
            this.Dgv_detalleComprobante.Size = new System.Drawing.Size(1255, 242);
            this.Dgv_detalleComprobante.TabIndex = 31;
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Tipo Movimiento";
            this.Articulo.MinimumWidth = 6;
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            this.Articulo.Width = 175;
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "Descripcion";
            this.Concepto.MinimumWidth = 6;
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            this.Concepto.Width = 175;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Debe";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 175;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Saldo de Comprobante";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 175;
            // 
            // lbl_Descuento
            // 
            this.lbl_Descuento.AutoSize = true;
            this.lbl_Descuento.Location = new System.Drawing.Point(530, 149);
            this.lbl_Descuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Descuento.Name = "lbl_Descuento";
            this.lbl_Descuento.Size = new System.Drawing.Size(123, 17);
            this.lbl_Descuento.TabIndex = 33;
            this.lbl_Descuento.Text = "Descuento/Interes";
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(215, 139);
            this.txt_Precio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(145, 22);
            this.txt_Precio.TabIndex = 30;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Location = new System.Drawing.Point(48, 150);
            this.lbl_Precio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(150, 17);
            this.lbl_Precio.TabIndex = 29;
            this.lbl_Precio.Text = "Valor de Comprobante";
            // 
            // Gpb_EncabezadoComprobante
            // 
            this.Gpb_EncabezadoComprobante.Controls.Add(this.btn_info);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.cbo_per);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.lbl_war3);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.lbl_war7);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.lbl_war6);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.lbl_war5);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.lbl_war4);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.lbl_war2);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.lbl_war);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.btn_detalle);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.lbl_periodo);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.txt_vigencia);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.label1);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.txt_codigoMov);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.lbl_CodigoMovimiento);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.cbo_codigoCliente);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.cbo_factura);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.date_FechaEmision);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.txt_CentroCosto);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.lbl_CentroCosto);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.cbo_codigoVendedor);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.lbl_CodigoVendedor);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.lbl_CodigoCliente);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.txt_Cotización);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.lbl_cotizacion);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.cbo_TipoMoneda);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.lbl_Moneda);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.lbl_Fecha);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.lbl_NoComprobante);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.cbo_TipoComprobante);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.lbl_TipoComprobante);
            this.Gpb_EncabezadoComprobante.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Gpb_EncabezadoComprobante.Location = new System.Drawing.Point(7, 12);
            this.Gpb_EncabezadoComprobante.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_EncabezadoComprobante.Name = "Gpb_EncabezadoComprobante";
            this.Gpb_EncabezadoComprobante.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_EncabezadoComprobante.Size = new System.Drawing.Size(1325, 302);
            this.Gpb_EncabezadoComprobante.TabIndex = 0;
            this.Gpb_EncabezadoComprobante.TabStop = false;
            this.Gpb_EncabezadoComprobante.Text = "Movimiento Clientes";
            this.Gpb_EncabezadoComprobante.Enter += new System.EventHandler(this.Gpb_EncabezadoComprobante_Enter);
            // 
            // cbo_per
            // 
            this.cbo_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_per.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cbo_per.FormattingEnabled = true;
            this.cbo_per.Location = new System.Drawing.Point(1020, 92);
            this.cbo_per.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_per.Name = "cbo_per";
            this.cbo_per.Size = new System.Drawing.Size(143, 25);
            this.cbo_per.TabIndex = 46;
            this.cbo_per.SelectedIndexChanged += new System.EventHandler(this.cbo_per_SelectedIndexChanged);
            this.cbo_per.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbo_per_KeyPress);
            // 
            // lbl_periodo
            // 
            this.lbl_periodo.AutoSize = true;
            this.lbl_periodo.Location = new System.Drawing.Point(884, 98);
            this.lbl_periodo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_periodo.Name = "lbl_periodo";
            this.lbl_periodo.Size = new System.Drawing.Size(57, 17);
            this.lbl_periodo.TabIndex = 25;
            this.lbl_periodo.Text = "Periodo";
            // 
            // txt_vigencia
            // 
            this.txt_vigencia.Location = new System.Drawing.Point(623, 95);
            this.txt_vigencia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_vigencia.Name = "txt_vigencia";
            this.txt_vigencia.Size = new System.Drawing.Size(145, 22);
            this.txt_vigencia.TabIndex = 24;
            this.txt_vigencia.Text = "30";
            this.txt_vigencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_vigencia_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Vigencia";
            // 
            // txt_codigoMov
            // 
            this.txt_codigoMov.Location = new System.Drawing.Point(1017, 36);
            this.txt_codigoMov.Margin = new System.Windows.Forms.Padding(4);
            this.txt_codigoMov.Name = "txt_codigoMov";
            this.txt_codigoMov.Size = new System.Drawing.Size(145, 22);
            this.txt_codigoMov.TabIndex = 22;
            this.txt_codigoMov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigoMov_KeyPress);
            // 
            // lbl_CodigoMovimiento
            // 
            this.lbl_CodigoMovimiento.AutoSize = true;
            this.lbl_CodigoMovimiento.Location = new System.Drawing.Point(872, 38);
            this.lbl_CodigoMovimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CodigoMovimiento.Name = "lbl_CodigoMovimiento";
            this.lbl_CodigoMovimiento.Size = new System.Drawing.Size(127, 17);
            this.lbl_CodigoMovimiento.TabIndex = 21;
            this.lbl_CodigoMovimiento.Text = "Codigo Movimiento";
            // 
            // cbo_codigoCliente
            // 
            this.cbo_codigoCliente.FormattingEnabled = true;
            this.cbo_codigoCliente.Location = new System.Drawing.Point(187, 203);
            this.cbo_codigoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_codigoCliente.Name = "cbo_codigoCliente";
            this.cbo_codigoCliente.Size = new System.Drawing.Size(145, 24);
            this.cbo_codigoCliente.TabIndex = 20;
            this.cbo_codigoCliente.SelectedIndexChanged += new System.EventHandler(this.cbo_codigoCliente_SelectedIndexChanged);
            this.cbo_codigoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbo_codigoCliente_KeyPress);
            // 
            // cbo_factura
            // 
            this.cbo_factura.FormattingEnabled = true;
            this.cbo_factura.Location = new System.Drawing.Point(623, 41);
            this.cbo_factura.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_factura.Name = "cbo_factura";
            this.cbo_factura.Size = new System.Drawing.Size(145, 24);
            this.cbo_factura.TabIndex = 19;
            this.cbo_factura.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cbo_factura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbo_factura_KeyPress);
            // 
            // date_FechaEmision
            // 
            this.date_FechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_FechaEmision.Location = new System.Drawing.Point(187, 91);
            this.date_FechaEmision.Margin = new System.Windows.Forms.Padding(4);
            this.date_FechaEmision.Name = "date_FechaEmision";
            this.date_FechaEmision.Size = new System.Drawing.Size(265, 22);
            this.date_FechaEmision.TabIndex = 18;
            this.date_FechaEmision.Value = new System.DateTime(2019, 11, 13, 0, 0, 0, 0);
            // 
            // txt_CentroCosto
            // 
            this.txt_CentroCosto.Location = new System.Drawing.Point(1017, 146);
            this.txt_CentroCosto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CentroCosto.Name = "txt_CentroCosto";
            this.txt_CentroCosto.Size = new System.Drawing.Size(145, 22);
            this.txt_CentroCosto.TabIndex = 17;
            this.txt_CentroCosto.Text = "Ventas";
            this.txt_CentroCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CentroCosto_KeyPress);
            // 
            // lbl_CentroCosto
            // 
            this.lbl_CentroCosto.AutoSize = true;
            this.lbl_CentroCosto.Location = new System.Drawing.Point(891, 149);
            this.lbl_CentroCosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CentroCosto.Name = "lbl_CentroCosto";
            this.lbl_CentroCosto.Size = new System.Drawing.Size(50, 17);
            this.lbl_CentroCosto.TabIndex = 16;
            this.lbl_CentroCosto.Text = "Centro";
            // 
            // cbo_codigoVendedor
            // 
            this.cbo_codigoVendedor.FormattingEnabled = true;
            this.cbo_codigoVendedor.Location = new System.Drawing.Point(623, 203);
            this.cbo_codigoVendedor.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_codigoVendedor.Name = "cbo_codigoVendedor";
            this.cbo_codigoVendedor.Size = new System.Drawing.Size(145, 24);
            this.cbo_codigoVendedor.TabIndex = 15;
            this.cbo_codigoVendedor.SelectedIndexChanged += new System.EventHandler(this.cbo_codigoVendedor_SelectedIndexChanged);
            this.cbo_codigoVendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbo_codigoVendedor_KeyPress);
            // 
            // lbl_CodigoVendedor
            // 
            this.lbl_CodigoVendedor.AutoSize = true;
            this.lbl_CodigoVendedor.Location = new System.Drawing.Point(496, 207);
            this.lbl_CodigoVendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CodigoVendedor.Name = "lbl_CodigoVendedor";
            this.lbl_CodigoVendedor.Size = new System.Drawing.Size(118, 17);
            this.lbl_CodigoVendedor.TabIndex = 14;
            this.lbl_CodigoVendedor.Text = "Codigo Vendedor";
            // 
            // lbl_CodigoCliente
            // 
            this.lbl_CodigoCliente.AutoSize = true;
            this.lbl_CodigoCliente.Location = new System.Drawing.Point(25, 207);
            this.lbl_CodigoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CodigoCliente.Name = "lbl_CodigoCliente";
            this.lbl_CodigoCliente.Size = new System.Drawing.Size(99, 17);
            this.lbl_CodigoCliente.TabIndex = 12;
            this.lbl_CodigoCliente.Text = "Codigo Cliente";
            // 
            // txt_Cotización
            // 
            this.txt_Cotización.Location = new System.Drawing.Point(623, 145);
            this.txt_Cotización.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Cotización.Name = "txt_Cotización";
            this.txt_Cotización.Size = new System.Drawing.Size(145, 22);
            this.txt_Cotización.TabIndex = 11;
            // 
            // lbl_cotizacion
            // 
            this.lbl_cotizacion.AutoSize = true;
            this.lbl_cotizacion.Location = new System.Drawing.Point(496, 149);
            this.lbl_cotizacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cotizacion.Name = "lbl_cotizacion";
            this.lbl_cotizacion.Size = new System.Drawing.Size(81, 17);
            this.lbl_cotizacion.TabIndex = 10;
            this.lbl_cotizacion.Text = "Contización";
            // 
            // cbo_TipoMoneda
            // 
            this.cbo_TipoMoneda.FormattingEnabled = true;
            this.cbo_TipoMoneda.Location = new System.Drawing.Point(187, 145);
            this.cbo_TipoMoneda.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_TipoMoneda.Name = "cbo_TipoMoneda";
            this.cbo_TipoMoneda.Size = new System.Drawing.Size(145, 24);
            this.cbo_TipoMoneda.TabIndex = 9;
            this.cbo_TipoMoneda.SelectedIndexChanged += new System.EventHandler(this.cbo_TipoMoneda_SelectedIndexChanged);
            this.cbo_TipoMoneda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbo_TipoMoneda_KeyPress);
            // 
            // lbl_Moneda
            // 
            this.lbl_Moneda.AutoSize = true;
            this.lbl_Moneda.Location = new System.Drawing.Point(24, 149);
            this.lbl_Moneda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Moneda.Name = "lbl_Moneda";
            this.lbl_Moneda.Size = new System.Drawing.Size(59, 17);
            this.lbl_Moneda.TabIndex = 8;
            this.lbl_Moneda.Text = "Moneda";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Location = new System.Drawing.Point(24, 98);
            this.lbl_Fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(100, 17);
            this.lbl_Fecha.TabIndex = 6;
            this.lbl_Fecha.Text = "Fecha Emision";
            // 
            // lbl_NoComprobante
            // 
            this.lbl_NoComprobante.AutoSize = true;
            this.lbl_NoComprobante.Location = new System.Drawing.Point(496, 44);
            this.lbl_NoComprobante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NoComprobante.Name = "lbl_NoComprobante";
            this.lbl_NoComprobante.Size = new System.Drawing.Size(102, 17);
            this.lbl_NoComprobante.TabIndex = 2;
            this.lbl_NoComprobante.Text = "No. de Factura";
            // 
            // cbo_TipoComprobante
            // 
            this.cbo_TipoComprobante.FormattingEnabled = true;
            this.cbo_TipoComprobante.Location = new System.Drawing.Point(187, 34);
            this.cbo_TipoComprobante.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_TipoComprobante.Name = "cbo_TipoComprobante";
            this.cbo_TipoComprobante.Size = new System.Drawing.Size(145, 24);
            this.cbo_TipoComprobante.TabIndex = 1;
            this.cbo_TipoComprobante.SelectedIndexChanged += new System.EventHandler(this.cbo_TipoComprobante_SelectedIndexChanged);
            this.cbo_TipoComprobante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbo_TipoComprobante_KeyPress);
            // 
            // lbl_TipoComprobante
            // 
            this.lbl_TipoComprobante.AutoSize = true;
            this.lbl_TipoComprobante.Location = new System.Drawing.Point(20, 38);
            this.lbl_TipoComprobante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TipoComprobante.Name = "lbl_TipoComprobante";
            this.lbl_TipoComprobante.Size = new System.Drawing.Size(131, 17);
            this.lbl_TipoComprobante.TabIndex = 0;
            this.lbl_TipoComprobante.Text = "Tipo de Movimiento";
            // 
            // tbc_MovimientosClientes
            // 
            this.tbc_MovimientosClientes.Controls.Add(this.tbc_Generar);
            this.tbc_MovimientosClientes.Location = new System.Drawing.Point(0, 4);
            this.tbc_MovimientosClientes.Margin = new System.Windows.Forms.Padding(4);
            this.tbc_MovimientosClientes.Name = "tbc_MovimientosClientes";
            this.tbc_MovimientosClientes.SelectedIndex = 0;
            this.tbc_MovimientosClientes.Size = new System.Drawing.Size(1361, 893);
            this.tbc_MovimientosClientes.TabIndex = 1;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Cancelar.Image = global::CapaDiseno_CxC_MovClientes.Properties.Resources.Cancel_32px;
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancelar.Location = new System.Drawing.Point(1027, 138);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(116, 37);
            this.btn_Cancelar.TabIndex = 49;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_war10
            // 
            this.lbl_war10.Image = global::CapaDiseno_CxC_MovClientes.Properties.Resources.High_Priority;
            this.lbl_war10.Location = new System.Drawing.Point(738, 138);
            this.lbl_war10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_war10.Name = "lbl_war10";
            this.lbl_war10.Size = new System.Drawing.Size(55, 39);
            this.lbl_war10.TabIndex = 46;
            // 
            // lbl_war9
            // 
            this.lbl_war9.Image = global::CapaDiseno_CxC_MovClientes.Properties.Resources.High_Priority;
            this.lbl_war9.Location = new System.Drawing.Point(369, 138);
            this.lbl_war9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_war9.Name = "lbl_war9";
            this.lbl_war9.Size = new System.Drawing.Size(55, 39);
            this.lbl_war9.TabIndex = 47;
            // 
            // lbl_war8
            // 
            this.lbl_war8.Image = global::CapaDiseno_CxC_MovClientes.Properties.Resources.High_Priority;
            this.lbl_war8.Location = new System.Drawing.Point(1024, 66);
            this.lbl_war8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_war8.Name = "lbl_war8";
            this.lbl_war8.Size = new System.Drawing.Size(55, 39);
            this.lbl_war8.TabIndex = 48;
            // 
            // Btn_generar
            // 
            this.Btn_generar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_generar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_generar.Image = global::CapaDiseno_CxC_MovClientes.Properties.Resources.Save;
            this.Btn_generar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_generar.Location = new System.Drawing.Point(900, 139);
            this.Btn_generar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_generar.Name = "Btn_generar";
            this.Btn_generar.Size = new System.Drawing.Size(116, 37);
            this.Btn_generar.TabIndex = 35;
            this.Btn_generar.Text = "Registrar";
            this.Btn_generar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_generar.UseVisualStyleBackColor = true;
            this.Btn_generar.Click += new System.EventHandler(this.Btn_generar_Click);
            // 
            // btn_info
            // 
            this.btn_info.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_info.Image = global::CapaDiseno_CxC_MovClientes.Properties.Resources.Help_32px;
            this.btn_info.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_info.Location = new System.Drawing.Point(1245, 23);
            this.btn_info.Margin = new System.Windows.Forms.Padding(4);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(50, 43);
            this.btn_info.TabIndex = 47;
            this.btn_info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // lbl_war3
            // 
            this.lbl_war3.Image = global::CapaDiseno_CxC_MovClientes.Properties.Resources.High_Priority;
            this.lbl_war3.Location = new System.Drawing.Point(341, 140);
            this.lbl_war3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_war3.Name = "lbl_war3";
            this.lbl_war3.Size = new System.Drawing.Size(55, 39);
            this.lbl_war3.TabIndex = 45;
            // 
            // lbl_war7
            // 
            this.lbl_war7.Image = global::CapaDiseno_CxC_MovClientes.Properties.Resources.High_Priority;
            this.lbl_war7.Location = new System.Drawing.Point(341, 203);
            this.lbl_war7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_war7.Name = "lbl_war7";
            this.lbl_war7.Size = new System.Drawing.Size(55, 39);
            this.lbl_war7.TabIndex = 44;
            // 
            // lbl_war6
            // 
            this.lbl_war6.Image = global::CapaDiseno_CxC_MovClientes.Properties.Resources.High_Priority;
            this.lbl_war6.Location = new System.Drawing.Point(777, 203);
            this.lbl_war6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_war6.Name = "lbl_war6";
            this.lbl_war6.Size = new System.Drawing.Size(55, 39);
            this.lbl_war6.TabIndex = 43;
            // 
            // lbl_war5
            // 
            this.lbl_war5.Image = global::CapaDiseno_CxC_MovClientes.Properties.Resources.High_Priority;
            this.lbl_war5.Location = new System.Drawing.Point(1184, 140);
            this.lbl_war5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_war5.Name = "lbl_war5";
            this.lbl_war5.Size = new System.Drawing.Size(55, 39);
            this.lbl_war5.TabIndex = 42;
            // 
            // lbl_war4
            // 
            this.lbl_war4.Image = global::CapaDiseno_CxC_MovClientes.Properties.Resources.High_Priority;
            this.lbl_war4.Location = new System.Drawing.Point(1184, 91);
            this.lbl_war4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_war4.Name = "lbl_war4";
            this.lbl_war4.Size = new System.Drawing.Size(55, 39);
            this.lbl_war4.TabIndex = 41;
            // 
            // lbl_war2
            // 
            this.lbl_war2.Image = global::CapaDiseno_CxC_MovClientes.Properties.Resources.High_Priority;
            this.lbl_war2.Location = new System.Drawing.Point(777, 34);
            this.lbl_war2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_war2.Name = "lbl_war2";
            this.lbl_war2.Size = new System.Drawing.Size(55, 39);
            this.lbl_war2.TabIndex = 40;
            // 
            // lbl_war
            // 
            this.lbl_war.Image = global::CapaDiseno_CxC_MovClientes.Properties.Resources.High_Priority;
            this.lbl_war.Location = new System.Drawing.Point(341, 27);
            this.lbl_war.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_war.Name = "lbl_war";
            this.lbl_war.Size = new System.Drawing.Size(55, 39);
            this.lbl_war.TabIndex = 39;
            // 
            // btn_detalle
            // 
            this.btn_detalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_detalle.Image = global::CapaDiseno_CxC_MovClientes.Properties.Resources.Add;
            this.btn_detalle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_detalle.Location = new System.Drawing.Point(1084, 207);
            this.btn_detalle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_detalle.Name = "btn_detalle";
            this.btn_detalle.Size = new System.Drawing.Size(80, 76);
            this.btn_detalle.TabIndex = 38;
            this.btn_detalle.Text = "Agregar Detalle";
            this.btn_detalle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_detalle.UseVisualStyleBackColor = true;
            this.btn_detalle.Click += new System.EventHandler(this.btn_detalle_Click);
            // 
            // MovimientoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbc_MovimientosClientes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MovimientoClientes";
            this.Size = new System.Drawing.Size(1365, 896);
            this.tbc_Generar.ResumeLayout(false);
            this.gb_DetalleMov.ResumeLayout(false);
            this.gb_DetalleMov.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalleComprobante)).EndInit();
            this.Gpb_EncabezadoComprobante.ResumeLayout(false);
            this.Gpb_EncabezadoComprobante.PerformLayout();
            this.tbc_MovimientosClientes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbc_Generar;
        private System.Windows.Forms.GroupBox gb_DetalleMov;
        private System.Windows.Forms.Label lbl_war10;
        private System.Windows.Forms.Label lbl_war9;
        private System.Windows.Forms.Label lbl_war8;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_generar;
        private System.Windows.Forms.ComboBox cbo_Descuento;
        private System.Windows.Forms.DataGridView Dgv_detalleComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label lbl_Descuento;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.GroupBox Gpb_EncabezadoComprobante;
        private System.Windows.Forms.ComboBox cbo_per;
        private System.Windows.Forms.Label lbl_war3;
        private System.Windows.Forms.Label lbl_war7;
        private System.Windows.Forms.Label lbl_war6;
        private System.Windows.Forms.Label lbl_war5;
        private System.Windows.Forms.Label lbl_war4;
        private System.Windows.Forms.Label lbl_war2;
        private System.Windows.Forms.Label lbl_war;
        private System.Windows.Forms.Button btn_detalle;
        private System.Windows.Forms.Label lbl_periodo;
        private System.Windows.Forms.TextBox txt_vigencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_codigoMov;
        private System.Windows.Forms.Label lbl_CodigoMovimiento;
        private System.Windows.Forms.ComboBox cbo_codigoCliente;
        private System.Windows.Forms.ComboBox cbo_factura;
        private System.Windows.Forms.DateTimePicker date_FechaEmision;
        private System.Windows.Forms.TextBox txt_CentroCosto;
        private System.Windows.Forms.Label lbl_CentroCosto;
        private System.Windows.Forms.ComboBox cbo_codigoVendedor;
        private System.Windows.Forms.Label lbl_CodigoVendedor;
        private System.Windows.Forms.Label lbl_CodigoCliente;
        private System.Windows.Forms.TextBox txt_Cotización;
        private System.Windows.Forms.Label lbl_cotizacion;
        private System.Windows.Forms.ComboBox cbo_TipoMoneda;
        private System.Windows.Forms.Label lbl_Moneda;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_NoComprobante;
        private System.Windows.Forms.ComboBox cbo_TipoComprobante;
        private System.Windows.Forms.Label lbl_TipoComprobante;
        private System.Windows.Forms.TabControl tbc_MovimientosClientes;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_info;
    }
}
