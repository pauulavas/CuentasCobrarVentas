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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovimientoClientes));
            this.tbc_ListarMovimientos = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumeroComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Haber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbp_Listar = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_CodigoClientes = new System.Windows.Forms.TextBox();
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.cbo_Periodo = new System.Windows.Forms.ComboBox();
            this.lbl_Período = new System.Windows.Forms.Label();
            this.tbc_Generar = new System.Windows.Forms.TabPage();
            this.Btn_generar = new System.Windows.Forms.Button();
            this.Gpb_DetalleComprobante = new System.Windows.Forms.GroupBox();
            this.cbo_Descuento = new System.Windows.Forms.ComboBox();
            this.lbl_Descuento = new System.Windows.Forms.Label();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.chk_IVA = new System.Windows.Forms.CheckBox();
            this.cbo_Servicio = new System.Windows.Forms.ComboBox();
            this.Dgv_detalleComprobante = new System.Windows.Forms.DataGridView();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.btn_Plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_Concepto = new System.Windows.Forms.TextBox();
            this.lbl_Concepto = new System.Windows.Forms.Label();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_Articulo = new System.Windows.Forms.Label();
            this.Gpb_EncabezadoComprobante = new System.Windows.Forms.GroupBox();
            this.txt_CentroCosto = new System.Windows.Forms.TextBox();
            this.lbl_CentroCosto = new System.Windows.Forms.Label();
            this.cbo_codigoVendedor = new System.Windows.Forms.ComboBox();
            this.lbl_CodigoVendedor = new System.Windows.Forms.Label();
            this.txt_CodigoCliente = new System.Windows.Forms.TextBox();
            this.lbl_CodigoCliente = new System.Windows.Forms.Label();
            this.txt_Cotización = new System.Windows.Forms.TextBox();
            this.lbl_cotizacion = new System.Windows.Forms.Label();
            this.cbo_TipoMoneda = new System.Windows.Forms.ComboBox();
            this.lbl_Moneda = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.txt_NoComprobante = new System.Windows.Forms.TextBox();
            this.txt_serieComprobante = new System.Windows.Forms.TextBox();
            this.lbl_Serie = new System.Windows.Forms.Label();
            this.lbl_NoComprobante = new System.Windows.Forms.Label();
            this.cbo_TipoComprobante = new System.Windows.Forms.ComboBox();
            this.lbl_TipoComprobante = new System.Windows.Forms.Label();
            this.tbc_MovimientosClientes = new System.Windows.Forms.TabControl();
            this.btn_Saldar = new System.Windows.Forms.Button();
            this.lbl_codigoCompro = new System.Windows.Forms.Label();
            this.lbl_SaldoaPag = new System.Windows.Forms.Label();
            this.txt_saldo = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.tbc_ListarMovimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbp_Listar.SuspendLayout();
            this.tbc_Generar.SuspendLayout();
            this.Gpb_DetalleComprobante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalleComprobante)).BeginInit();
            this.Gpb_EncabezadoComprobante.SuspendLayout();
            this.tbc_MovimientosClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_ListarMovimientos
            // 
            this.tbc_ListarMovimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.tbc_ListarMovimientos.Controls.Add(this.txt_codigo);
            this.tbc_ListarMovimientos.Controls.Add(this.txt_saldo);
            this.tbc_ListarMovimientos.Controls.Add(this.lbl_SaldoaPag);
            this.tbc_ListarMovimientos.Controls.Add(this.lbl_codigoCompro);
            this.tbc_ListarMovimientos.Controls.Add(this.btn_Saldar);
            this.tbc_ListarMovimientos.Controls.Add(this.dataGridView1);
            this.tbc_ListarMovimientos.Controls.Add(this.gbp_Listar);
            this.tbc_ListarMovimientos.Location = new System.Drawing.Point(4, 22);
            this.tbc_ListarMovimientos.Name = "tbc_ListarMovimientos";
            this.tbc_ListarMovimientos.Padding = new System.Windows.Forms.Padding(3);
            this.tbc_ListarMovimientos.Size = new System.Drawing.Size(1016, 703);
            this.tbc_ListarMovimientos.TabIndex = 1;
            this.tbc_ListarMovimientos.Text = "Listar Movimientos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroComprobante,
            this.TipoMovimiento,
            this.FechaEmision,
            this.FechaVencimiento,
            this.Debe,
            this.Haber,
            this.SaldoComprobante,
            this.SaldoCliente});
            this.dataGridView1.Location = new System.Drawing.Point(34, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(938, 255);
            this.dataGridView1.TabIndex = 2;
            // 
            // NumeroComprobante
            // 
            this.NumeroComprobante.HeaderText = "No. Comprobante";
            this.NumeroComprobante.Name = "NumeroComprobante";
            // 
            // TipoMovimiento
            // 
            this.TipoMovimiento.HeaderText = "Tipo de Movimiento";
            this.TipoMovimiento.Name = "TipoMovimiento";
            // 
            // FechaEmision
            // 
            this.FechaEmision.HeaderText = "Fecha de Emision";
            this.FechaEmision.Name = "FechaEmision";
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.HeaderText = "Fecha de Vencimiento";
            this.FechaVencimiento.Name = "FechaVencimiento";
            // 
            // Debe
            // 
            this.Debe.HeaderText = "Debe";
            this.Debe.Name = "Debe";
            // 
            // Haber
            // 
            this.Haber.HeaderText = "Haber";
            this.Haber.Name = "Haber";
            // 
            // SaldoComprobante
            // 
            this.SaldoComprobante.HeaderText = "Saldo de Comprobante";
            this.SaldoComprobante.Name = "SaldoComprobante";
            // 
            // SaldoCliente
            // 
            this.SaldoCliente.HeaderText = "Saldo del Cliente";
            this.SaldoCliente.Name = "SaldoCliente";
            // 
            // gbp_Listar
            // 
            this.gbp_Listar.Controls.Add(this.btn_buscar);
            this.gbp_Listar.Controls.Add(this.txt_CodigoClientes);
            this.gbp_Listar.Controls.Add(this.lbl_Cliente);
            this.gbp_Listar.Controls.Add(this.cbo_Periodo);
            this.gbp_Listar.Controls.Add(this.lbl_Período);
            this.gbp_Listar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbp_Listar.Location = new System.Drawing.Point(7, 16);
            this.gbp_Listar.Name = "gbp_Listar";
            this.gbp_Listar.Size = new System.Drawing.Size(983, 110);
            this.gbp_Listar.TabIndex = 1;
            this.gbp_Listar.TabStop = false;
            this.gbp_Listar.Text = "Listado Movimiento";
            // 
            // btn_buscar
            // 
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_buscar.Location = new System.Drawing.Point(702, 33);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(55, 41);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // txt_CodigoClientes
            // 
            this.txt_CodigoClientes.Location = new System.Drawing.Point(485, 49);
            this.txt_CodigoClientes.Name = "txt_CodigoClientes";
            this.txt_CodigoClientes.Size = new System.Drawing.Size(100, 20);
            this.txt_CodigoClientes.TabIndex = 3;
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Cliente.Location = new System.Drawing.Point(325, 52);
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(90, 13);
            this.lbl_Cliente.TabIndex = 2;
            this.lbl_Cliente.Text = "Codigo de Cliente";
            // 
            // cbo_Periodo
            // 
            this.cbo_Periodo.FormattingEnabled = true;
            this.cbo_Periodo.Location = new System.Drawing.Point(126, 53);
            this.cbo_Periodo.Name = "cbo_Periodo";
            this.cbo_Periodo.Size = new System.Drawing.Size(135, 21);
            this.cbo_Periodo.TabIndex = 1;
            // 
            // lbl_Período
            // 
            this.lbl_Período.AutoSize = true;
            this.lbl_Período.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Período.Location = new System.Drawing.Point(55, 56);
            this.lbl_Período.Name = "lbl_Período";
            this.lbl_Período.Size = new System.Drawing.Size(45, 13);
            this.lbl_Período.TabIndex = 0;
            this.lbl_Período.Text = "Período";
            // 
            // tbc_Generar
            // 
            this.tbc_Generar.Controls.Add(this.Btn_generar);
            this.tbc_Generar.Controls.Add(this.Gpb_DetalleComprobante);
            this.tbc_Generar.Controls.Add(this.Gpb_EncabezadoComprobante);
            this.tbc_Generar.Location = new System.Drawing.Point(4, 22);
            this.tbc_Generar.Name = "tbc_Generar";
            this.tbc_Generar.Padding = new System.Windows.Forms.Padding(3);
            this.tbc_Generar.Size = new System.Drawing.Size(1016, 703);
            this.tbc_Generar.TabIndex = 0;
            this.tbc_Generar.Text = "Generar Comprobante";
            this.tbc_Generar.UseVisualStyleBackColor = true;
            // 
            // Btn_generar
            // 
            this.Btn_generar.Location = new System.Drawing.Point(858, 650);
            this.Btn_generar.Name = "Btn_generar";
            this.Btn_generar.Size = new System.Drawing.Size(85, 30);
            this.Btn_generar.TabIndex = 15;
            this.Btn_generar.Text = "Generar";
            this.Btn_generar.UseVisualStyleBackColor = true;
            // 
            // Gpb_DetalleComprobante
            // 
            this.Gpb_DetalleComprobante.Controls.Add(this.cbo_Descuento);
            this.Gpb_DetalleComprobante.Controls.Add(this.lbl_Descuento);
            this.Gpb_DetalleComprobante.Controls.Add(this.Btn_Agregar);
            this.Gpb_DetalleComprobante.Controls.Add(this.chk_IVA);
            this.Gpb_DetalleComprobante.Controls.Add(this.cbo_Servicio);
            this.Gpb_DetalleComprobante.Controls.Add(this.Dgv_detalleComprobante);
            this.Gpb_DetalleComprobante.Controls.Add(this.txt_Precio);
            this.Gpb_DetalleComprobante.Controls.Add(this.btn_Plus);
            this.Gpb_DetalleComprobante.Controls.Add(this.btn_minus);
            this.Gpb_DetalleComprobante.Controls.Add(this.txt_cantidad);
            this.Gpb_DetalleComprobante.Controls.Add(this.txt_Concepto);
            this.Gpb_DetalleComprobante.Controls.Add(this.lbl_Concepto);
            this.Gpb_DetalleComprobante.Controls.Add(this.lbl_Cantidad);
            this.Gpb_DetalleComprobante.Controls.Add(this.lbl_Precio);
            this.Gpb_DetalleComprobante.Controls.Add(this.lbl_Articulo);
            this.Gpb_DetalleComprobante.Location = new System.Drawing.Point(1, 214);
            this.Gpb_DetalleComprobante.Name = "Gpb_DetalleComprobante";
            this.Gpb_DetalleComprobante.Size = new System.Drawing.Size(994, 430);
            this.Gpb_DetalleComprobante.TabIndex = 1;
            this.Gpb_DetalleComprobante.TabStop = false;
            this.Gpb_DetalleComprobante.Text = "Detalle Comprobante";
            // 
            // cbo_Descuento
            // 
            this.cbo_Descuento.FormattingEnabled = true;
            this.cbo_Descuento.Location = new System.Drawing.Point(899, 35);
            this.cbo_Descuento.Name = "cbo_Descuento";
            this.cbo_Descuento.Size = new System.Drawing.Size(33, 21);
            this.cbo_Descuento.TabIndex = 14;
            // 
            // lbl_Descuento
            // 
            this.lbl_Descuento.AutoSize = true;
            this.lbl_Descuento.Location = new System.Drawing.Point(834, 38);
            this.lbl_Descuento.Name = "lbl_Descuento";
            this.lbl_Descuento.Size = new System.Drawing.Size(59, 13);
            this.lbl_Descuento.TabIndex = 13;
            this.lbl_Descuento.Text = "Descuento";
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Location = new System.Drawing.Point(837, 102);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(85, 30);
            this.Btn_Agregar.TabIndex = 12;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // chk_IVA
            // 
            this.chk_IVA.AutoSize = true;
            this.chk_IVA.Location = new System.Drawing.Point(734, 58);
            this.chk_IVA.Name = "chk_IVA";
            this.chk_IVA.Size = new System.Drawing.Size(82, 17);
            this.chk_IVA.TabIndex = 11;
            this.chk_IVA.Text = "IVA incluido";
            this.chk_IVA.UseVisualStyleBackColor = true;
            // 
            // cbo_Servicio
            // 
            this.cbo_Servicio.FormattingEnabled = true;
            this.cbo_Servicio.Location = new System.Drawing.Point(118, 31);
            this.cbo_Servicio.Name = "cbo_Servicio";
            this.cbo_Servicio.Size = new System.Drawing.Size(110, 21);
            this.cbo_Servicio.TabIndex = 10;
            // 
            // Dgv_detalleComprobante
            // 
            this.Dgv_detalleComprobante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_detalleComprobante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Articulo,
            this.Concepto,
            this.Cantidad,
            this.Precio});
            this.Dgv_detalleComprobante.Location = new System.Drawing.Point(20, 159);
            this.Dgv_detalleComprobante.Name = "Dgv_detalleComprobante";
            this.Dgv_detalleComprobante.Size = new System.Drawing.Size(941, 256);
            this.Dgv_detalleComprobante.TabIndex = 9;
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Articulo";
            this.Articulo.Name = "Articulo";
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(727, 32);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(89, 20);
            this.txt_Precio.TabIndex = 8;
            // 
            // btn_Plus
            // 
            this.btn_Plus.Image = ((System.Drawing.Image)(resources.GetObject("btn_Plus.Image")));
            this.btn_Plus.Location = new System.Drawing.Point(622, 29);
            this.btn_Plus.Name = "btn_Plus";
            this.btn_Plus.Size = new System.Drawing.Size(20, 24);
            this.btn_Plus.TabIndex = 7;
            this.btn_Plus.UseVisualStyleBackColor = true;
            // 
            // btn_minus
            // 
            this.btn_minus.Image = ((System.Drawing.Image)(resources.GetObject("btn_minus.Image")));
            this.btn_minus.Location = new System.Drawing.Point(599, 29);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(17, 24);
            this.btn_minus.TabIndex = 6;
            this.btn_minus.UseVisualStyleBackColor = true;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(559, 31);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(34, 20);
            this.txt_cantidad.TabIndex = 5;
            // 
            // txt_Concepto
            // 
            this.txt_Concepto.Location = new System.Drawing.Point(308, 32);
            this.txt_Concepto.Multiline = true;
            this.txt_Concepto.Name = "txt_Concepto";
            this.txt_Concepto.Size = new System.Drawing.Size(164, 22);
            this.txt_Concepto.TabIndex = 4;
            // 
            // lbl_Concepto
            // 
            this.lbl_Concepto.AutoSize = true;
            this.lbl_Concepto.Location = new System.Drawing.Point(249, 35);
            this.lbl_Concepto.Name = "lbl_Concepto";
            this.lbl_Concepto.Size = new System.Drawing.Size(53, 13);
            this.lbl_Concepto.TabIndex = 3;
            this.lbl_Concepto.Text = "Concepto";
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Location = new System.Drawing.Point(490, 34);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(49, 13);
            this.lbl_Cantidad.TabIndex = 2;
            this.lbl_Cantidad.Text = "Cantidad";
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Location = new System.Drawing.Point(675, 35);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(37, 13);
            this.lbl_Precio.TabIndex = 1;
            this.lbl_Precio.Text = "Precio";
            // 
            // lbl_Articulo
            // 
            this.lbl_Articulo.AutoSize = true;
            this.lbl_Articulo.Location = new System.Drawing.Point(17, 35);
            this.lbl_Articulo.Name = "lbl_Articulo";
            this.lbl_Articulo.Size = new System.Drawing.Size(85, 13);
            this.lbl_Articulo.TabIndex = 0;
            this.lbl_Articulo.Text = "Articulo/Servicio";
            // 
            // Gpb_EncabezadoComprobante
            // 
            this.Gpb_EncabezadoComprobante.Controls.Add(this.txt_CentroCosto);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.lbl_CentroCosto);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.cbo_codigoVendedor);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.lbl_CodigoVendedor);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.txt_CodigoCliente);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.lbl_CodigoCliente);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.txt_Cotización);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.lbl_cotizacion);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.cbo_TipoMoneda);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.lbl_Moneda);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.txt_fecha);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.lbl_Fecha);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.txt_NoComprobante);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.txt_serieComprobante);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.lbl_Serie);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.lbl_NoComprobante);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.cbo_TipoComprobante);
            this.Gpb_EncabezadoComprobante.Controls.Add(this.lbl_TipoComprobante);
            this.Gpb_EncabezadoComprobante.Location = new System.Drawing.Point(5, 10);
            this.Gpb_EncabezadoComprobante.Name = "Gpb_EncabezadoComprobante";
            this.Gpb_EncabezadoComprobante.Size = new System.Drawing.Size(994, 198);
            this.Gpb_EncabezadoComprobante.TabIndex = 0;
            this.Gpb_EncabezadoComprobante.TabStop = false;
            this.Gpb_EncabezadoComprobante.Text = "Encabezado Comprobante";
            // 
            // txt_CentroCosto
            // 
            this.txt_CentroCosto.Location = new System.Drawing.Point(140, 163);
            this.txt_CentroCosto.Name = "txt_CentroCosto";
            this.txt_CentroCosto.Size = new System.Drawing.Size(110, 20);
            this.txt_CentroCosto.TabIndex = 17;
            // 
            // lbl_CentroCosto
            // 
            this.lbl_CentroCosto.AutoSize = true;
            this.lbl_CentroCosto.Location = new System.Drawing.Point(15, 166);
            this.lbl_CentroCosto.Name = "lbl_CentroCosto";
            this.lbl_CentroCosto.Size = new System.Drawing.Size(38, 13);
            this.lbl_CentroCosto.TabIndex = 16;
            this.lbl_CentroCosto.Text = "Centro";
            // 
            // cbo_codigoVendedor
            // 
            this.cbo_codigoVendedor.FormattingEnabled = true;
            this.cbo_codigoVendedor.Location = new System.Drawing.Point(375, 118);
            this.cbo_codigoVendedor.Name = "cbo_codigoVendedor";
            this.cbo_codigoVendedor.Size = new System.Drawing.Size(110, 21);
            this.cbo_codigoVendedor.TabIndex = 15;
            // 
            // lbl_CodigoVendedor
            // 
            this.lbl_CodigoVendedor.AutoSize = true;
            this.lbl_CodigoVendedor.Location = new System.Drawing.Point(280, 121);
            this.lbl_CodigoVendedor.Name = "lbl_CodigoVendedor";
            this.lbl_CodigoVendedor.Size = new System.Drawing.Size(89, 13);
            this.lbl_CodigoVendedor.TabIndex = 14;
            this.lbl_CodigoVendedor.Text = "Codigo Vendedor";
            // 
            // txt_CodigoCliente
            // 
            this.txt_CodigoCliente.Location = new System.Drawing.Point(140, 118);
            this.txt_CodigoCliente.Name = "txt_CodigoCliente";
            this.txt_CodigoCliente.Size = new System.Drawing.Size(110, 20);
            this.txt_CodigoCliente.TabIndex = 13;
            // 
            // lbl_CodigoCliente
            // 
            this.lbl_CodigoCliente.AutoSize = true;
            this.lbl_CodigoCliente.Location = new System.Drawing.Point(15, 121);
            this.lbl_CodigoCliente.Name = "lbl_CodigoCliente";
            this.lbl_CodigoCliente.Size = new System.Drawing.Size(75, 13);
            this.lbl_CodigoCliente.TabIndex = 12;
            this.lbl_CodigoCliente.Text = "Codigo Cliente";
            // 
            // txt_Cotización
            // 
            this.txt_Cotización.Location = new System.Drawing.Point(375, 71);
            this.txt_Cotización.Name = "txt_Cotización";
            this.txt_Cotización.Size = new System.Drawing.Size(110, 20);
            this.txt_Cotización.TabIndex = 11;
            // 
            // lbl_cotizacion
            // 
            this.lbl_cotizacion.AutoSize = true;
            this.lbl_cotizacion.Location = new System.Drawing.Point(280, 74);
            this.lbl_cotizacion.Name = "lbl_cotizacion";
            this.lbl_cotizacion.Size = new System.Drawing.Size(62, 13);
            this.lbl_cotizacion.TabIndex = 10;
            this.lbl_cotizacion.Text = "Contización";
            // 
            // cbo_TipoMoneda
            // 
            this.cbo_TipoMoneda.FormattingEnabled = true;
            this.cbo_TipoMoneda.Location = new System.Drawing.Point(140, 71);
            this.cbo_TipoMoneda.Name = "cbo_TipoMoneda";
            this.cbo_TipoMoneda.Size = new System.Drawing.Size(110, 21);
            this.cbo_TipoMoneda.TabIndex = 9;
            // 
            // lbl_Moneda
            // 
            this.lbl_Moneda.AutoSize = true;
            this.lbl_Moneda.Location = new System.Drawing.Point(15, 74);
            this.lbl_Moneda.Name = "lbl_Moneda";
            this.lbl_Moneda.Size = new System.Drawing.Size(46, 13);
            this.lbl_Moneda.TabIndex = 8;
            this.lbl_Moneda.Text = "Moneda";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(375, 28);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(110, 20);
            this.txt_fecha.TabIndex = 7;
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Location = new System.Drawing.Point(280, 32);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(37, 13);
            this.lbl_Fecha.TabIndex = 6;
            this.lbl_Fecha.Text = "Fecha";
            // 
            // txt_NoComprobante
            // 
            this.txt_NoComprobante.Location = new System.Drawing.Point(795, 29);
            this.txt_NoComprobante.Name = "txt_NoComprobante";
            this.txt_NoComprobante.Size = new System.Drawing.Size(110, 20);
            this.txt_NoComprobante.TabIndex = 5;
            // 
            // txt_serieComprobante
            // 
            this.txt_serieComprobante.Location = new System.Drawing.Point(541, 28);
            this.txt_serieComprobante.Name = "txt_serieComprobante";
            this.txt_serieComprobante.Size = new System.Drawing.Size(89, 20);
            this.txt_serieComprobante.TabIndex = 4;
            // 
            // lbl_Serie
            // 
            this.lbl_Serie.AutoSize = true;
            this.lbl_Serie.Location = new System.Drawing.Point(504, 31);
            this.lbl_Serie.Name = "lbl_Serie";
            this.lbl_Serie.Size = new System.Drawing.Size(31, 13);
            this.lbl_Serie.TabIndex = 3;
            this.lbl_Serie.Text = "Serie";
            // 
            // lbl_NoComprobante
            // 
            this.lbl_NoComprobante.AutoSize = true;
            this.lbl_NoComprobante.Location = new System.Drawing.Point(684, 32);
            this.lbl_NoComprobante.Name = "lbl_NoComprobante";
            this.lbl_NoComprobante.Size = new System.Drawing.Size(105, 13);
            this.lbl_NoComprobante.TabIndex = 2;
            this.lbl_NoComprobante.Text = "No. de Comprobante";
            // 
            // cbo_TipoComprobante
            // 
            this.cbo_TipoComprobante.FormattingEnabled = true;
            this.cbo_TipoComprobante.Location = new System.Drawing.Point(140, 28);
            this.cbo_TipoComprobante.Name = "cbo_TipoComprobante";
            this.cbo_TipoComprobante.Size = new System.Drawing.Size(110, 21);
            this.cbo_TipoComprobante.TabIndex = 1;
            // 
            // lbl_TipoComprobante
            // 
            this.lbl_TipoComprobante.AutoSize = true;
            this.lbl_TipoComprobante.Location = new System.Drawing.Point(15, 31);
            this.lbl_TipoComprobante.Name = "lbl_TipoComprobante";
            this.lbl_TipoComprobante.Size = new System.Drawing.Size(109, 13);
            this.lbl_TipoComprobante.TabIndex = 0;
            this.lbl_TipoComprobante.Text = "Tipo de Comprobante";
            // 
            // tbc_MovimientosClientes
            // 
            this.tbc_MovimientosClientes.Controls.Add(this.tbc_Generar);
            this.tbc_MovimientosClientes.Controls.Add(this.tbc_ListarMovimientos);
            this.tbc_MovimientosClientes.Location = new System.Drawing.Point(0, 0);
            this.tbc_MovimientosClientes.Name = "tbc_MovimientosClientes";
            this.tbc_MovimientosClientes.SelectedIndex = 0;
            this.tbc_MovimientosClientes.Size = new System.Drawing.Size(1024, 729);
            this.tbc_MovimientosClientes.TabIndex = 1;
            // 
            // btn_Saldar
            // 
            this.btn_Saldar.Location = new System.Drawing.Point(633, 546);
            this.btn_Saldar.Name = "btn_Saldar";
            this.btn_Saldar.Size = new System.Drawing.Size(100, 33);
            this.btn_Saldar.TabIndex = 3;
            this.btn_Saldar.Text = "Saldar";
            this.btn_Saldar.UseVisualStyleBackColor = true;
            // 
            // lbl_codigoCompro
            // 
            this.lbl_codigoCompro.AutoSize = true;
            this.lbl_codigoCompro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_codigoCompro.Location = new System.Drawing.Point(78, 556);
            this.lbl_codigoCompro.Name = "lbl_codigoCompro";
            this.lbl_codigoCompro.Size = new System.Drawing.Size(106, 13);
            this.lbl_codigoCompro.TabIndex = 4;
            this.lbl_codigoCompro.Text = "Codigo Comprobante";
            // 
            // lbl_SaldoaPag
            // 
            this.lbl_SaldoaPag.AutoSize = true;
            this.lbl_SaldoaPag.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_SaldoaPag.Location = new System.Drawing.Point(393, 556);
            this.lbl_SaldoaPag.Name = "lbl_SaldoaPag";
            this.lbl_SaldoaPag.Size = new System.Drawing.Size(74, 13);
            this.lbl_SaldoaPag.TabIndex = 5;
            this.lbl_SaldoaPag.Text = "Saldo a Pagar";
            // 
            // txt_saldo
            // 
            this.txt_saldo.Location = new System.Drawing.Point(473, 553);
            this.txt_saldo.Name = "txt_saldo";
            this.txt_saldo.Size = new System.Drawing.Size(89, 20);
            this.txt_saldo.TabIndex = 6;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(209, 553);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(89, 20);
            this.txt_codigo.TabIndex = 7;
            // 
            // MovimientoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbc_MovimientosClientes);
            this.Name = "MovimientoClientes";
            this.Size = new System.Drawing.Size(1024, 728);
            this.tbc_ListarMovimientos.ResumeLayout(false);
            this.tbc_ListarMovimientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbp_Listar.ResumeLayout(false);
            this.gbp_Listar.PerformLayout();
            this.tbc_Generar.ResumeLayout(false);
            this.Gpb_DetalleComprobante.ResumeLayout(false);
            this.Gpb_DetalleComprobante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalleComprobante)).EndInit();
            this.Gpb_EncabezadoComprobante.ResumeLayout(false);
            this.Gpb_EncabezadoComprobante.PerformLayout();
            this.tbc_MovimientosClientes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbc_ListarMovimientos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Haber;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoCliente;
        private System.Windows.Forms.GroupBox gbp_Listar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_CodigoClientes;
        private System.Windows.Forms.Label lbl_Cliente;
        private System.Windows.Forms.ComboBox cbo_Periodo;
        private System.Windows.Forms.Label lbl_Período;
        private System.Windows.Forms.TabPage tbc_Generar;
        private System.Windows.Forms.Button Btn_generar;
        private System.Windows.Forms.GroupBox Gpb_DetalleComprobante;
        private System.Windows.Forms.ComboBox cbo_Descuento;
        private System.Windows.Forms.Label lbl_Descuento;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.CheckBox chk_IVA;
        private System.Windows.Forms.ComboBox cbo_Servicio;
        private System.Windows.Forms.DataGridView Dgv_detalleComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Button btn_Plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_Concepto;
        private System.Windows.Forms.Label lbl_Concepto;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Label lbl_Articulo;
        private System.Windows.Forms.GroupBox Gpb_EncabezadoComprobante;
        private System.Windows.Forms.TextBox txt_CentroCosto;
        private System.Windows.Forms.Label lbl_CentroCosto;
        private System.Windows.Forms.ComboBox cbo_codigoVendedor;
        private System.Windows.Forms.Label lbl_CodigoVendedor;
        private System.Windows.Forms.TextBox txt_CodigoCliente;
        private System.Windows.Forms.Label lbl_CodigoCliente;
        private System.Windows.Forms.TextBox txt_Cotización;
        private System.Windows.Forms.Label lbl_cotizacion;
        private System.Windows.Forms.ComboBox cbo_TipoMoneda;
        private System.Windows.Forms.Label lbl_Moneda;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.TextBox txt_NoComprobante;
        private System.Windows.Forms.TextBox txt_serieComprobante;
        private System.Windows.Forms.Label lbl_Serie;
        private System.Windows.Forms.Label lbl_NoComprobante;
        private System.Windows.Forms.ComboBox cbo_TipoComprobante;
        private System.Windows.Forms.Label lbl_TipoComprobante;
        private System.Windows.Forms.TabControl tbc_MovimientosClientes;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_saldo;
        private System.Windows.Forms.Label lbl_SaldoaPag;
        private System.Windows.Forms.Label lbl_codigoCompro;
        private System.Windows.Forms.Button btn_Saldar;
    }
}
