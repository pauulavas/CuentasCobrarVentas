namespace Facturacion
{
    partial class CU_Devoluciones
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
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.Cbo_serie = new System.Windows.Forms.ComboBox();
            this.Btn_consultarFacturas = new System.Windows.Forms.Button();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.Txt_fecha = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.Txt_registros = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.Txt_subtotal = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.Txt_total = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.Txt_impuesto = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.Txt_nit = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.Txt_correlativo = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.Txt_apellidos = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.Txt_nombres = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.Dgv_facturas = new System.Windows.Forms.DataGridView();
            this.Correlativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.Txt_descripcion = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.Btn_solicitar = new System.Windows.Forms.Button();
            this.groupBox16.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_facturas)).BeginInit();
            this.groupBox17.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.Cbo_serie);
            this.groupBox16.Controls.Add(this.Btn_consultarFacturas);
            this.groupBox16.Controls.Add(this.label45);
            this.groupBox16.ForeColor = System.Drawing.Color.White;
            this.groupBox16.Location = new System.Drawing.Point(27, 26);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(479, 107);
            this.groupBox16.TabIndex = 30;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Documento";
            // 
            // Cbo_serie
            // 
            this.Cbo_serie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_serie.FormattingEnabled = true;
            this.Cbo_serie.Location = new System.Drawing.Point(93, 53);
            this.Cbo_serie.Name = "Cbo_serie";
            this.Cbo_serie.Size = new System.Drawing.Size(175, 21);
            this.Cbo_serie.TabIndex = 18;
            this.Cbo_serie.SelectedIndexChanged += new System.EventHandler(this.Cbo_serie_SelectedIndexChanged);
            // 
            // Btn_consultarFacturas
            // 
            this.Btn_consultarFacturas.ForeColor = System.Drawing.Color.Black;
            this.Btn_consultarFacturas.Image = global::Facturacion.Properties.Resources.search;
            this.Btn_consultarFacturas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_consultarFacturas.Location = new System.Drawing.Point(307, 29);
            this.Btn_consultarFacturas.Name = "Btn_consultarFacturas";
            this.Btn_consultarFacturas.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.Btn_consultarFacturas.Size = new System.Drawing.Size(69, 54);
            this.Btn_consultarFacturas.TabIndex = 14;
            this.Btn_consultarFacturas.Text = "Consultar";
            this.Btn_consultarFacturas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultarFacturas.UseVisualStyleBackColor = true;
            this.Btn_consultarFacturas.Click += new System.EventHandler(this.Btn_consultarFacturas_Click);
            // 
            // label45
            // 
            this.label45.Location = new System.Drawing.Point(90, 29);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(36, 21);
            this.label45.TabIndex = 17;
            this.label45.Text = "Serie:";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label46
            // 
            this.label46.Location = new System.Drawing.Point(21, 22);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(64, 17);
            this.label46.TabIndex = 10;
            this.label46.Text = "Descripcion";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.Txt_fecha);
            this.groupBox13.Controls.Add(this.label34);
            this.groupBox13.Controls.Add(this.Txt_registros);
            this.groupBox13.Controls.Add(this.label35);
            this.groupBox13.Controls.Add(this.Txt_subtotal);
            this.groupBox13.Controls.Add(this.label36);
            this.groupBox13.Controls.Add(this.Txt_total);
            this.groupBox13.Controls.Add(this.label37);
            this.groupBox13.Controls.Add(this.Txt_impuesto);
            this.groupBox13.Controls.Add(this.label38);
            this.groupBox13.ForeColor = System.Drawing.Color.White;
            this.groupBox13.Location = new System.Drawing.Point(550, 349);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(365, 161);
            this.groupBox13.TabIndex = 34;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Detalle-Factura";
            // 
            // Txt_fecha
            // 
            this.Txt_fecha.Enabled = false;
            this.Txt_fecha.Location = new System.Drawing.Point(91, 124);
            this.Txt_fecha.Name = "Txt_fecha";
            this.Txt_fecha.Size = new System.Drawing.Size(242, 20);
            this.Txt_fecha.TabIndex = 17;
            // 
            // label34
            // 
            this.label34.Location = new System.Drawing.Point(24, 124);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(61, 20);
            this.label34.TabIndex = 16;
            this.label34.Text = "Fecha:";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Txt_registros
            // 
            this.Txt_registros.Enabled = false;
            this.Txt_registros.Location = new System.Drawing.Point(91, 98);
            this.Txt_registros.Name = "Txt_registros";
            this.Txt_registros.Size = new System.Drawing.Size(242, 20);
            this.Txt_registros.TabIndex = 15;
            // 
            // label35
            // 
            this.label35.Location = new System.Drawing.Point(24, 98);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(61, 20);
            this.label35.TabIndex = 14;
            this.label35.Text = "Registros:";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Txt_subtotal
            // 
            this.Txt_subtotal.Enabled = false;
            this.Txt_subtotal.Location = new System.Drawing.Point(91, 20);
            this.Txt_subtotal.Name = "Txt_subtotal";
            this.Txt_subtotal.Size = new System.Drawing.Size(242, 20);
            this.Txt_subtotal.TabIndex = 13;
            // 
            // label36
            // 
            this.label36.Location = new System.Drawing.Point(24, 21);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(61, 20);
            this.label36.TabIndex = 12;
            this.label36.Text = "SubTotal:";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Txt_total
            // 
            this.Txt_total.Enabled = false;
            this.Txt_total.Location = new System.Drawing.Point(91, 72);
            this.Txt_total.Name = "Txt_total";
            this.Txt_total.Size = new System.Drawing.Size(242, 20);
            this.Txt_total.TabIndex = 11;
            // 
            // label37
            // 
            this.label37.Location = new System.Drawing.Point(24, 73);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(61, 17);
            this.label37.TabIndex = 10;
            this.label37.Text = "Total:";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Txt_impuesto
            // 
            this.Txt_impuesto.Enabled = false;
            this.Txt_impuesto.Location = new System.Drawing.Point(91, 46);
            this.Txt_impuesto.Name = "Txt_impuesto";
            this.Txt_impuesto.Size = new System.Drawing.Size(242, 20);
            this.Txt_impuesto.TabIndex = 9;
            // 
            // label38
            // 
            this.label38.Location = new System.Drawing.Point(24, 47);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(61, 17);
            this.label38.TabIndex = 8;
            this.label38.Text = "Impuesto:";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.Txt_nit);
            this.groupBox15.Controls.Add(this.label39);
            this.groupBox15.Controls.Add(this.Txt_correlativo);
            this.groupBox15.Controls.Add(this.label40);
            this.groupBox15.Controls.Add(this.Txt_apellidos);
            this.groupBox15.Controls.Add(this.label41);
            this.groupBox15.Controls.Add(this.Txt_nombres);
            this.groupBox15.Controls.Add(this.label42);
            this.groupBox15.ForeColor = System.Drawing.Color.White;
            this.groupBox15.Location = new System.Drawing.Point(27, 349);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(517, 161);
            this.groupBox15.TabIndex = 33;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Encabezado-Factura";
            // 
            // Txt_nit
            // 
            this.Txt_nit.Enabled = false;
            this.Txt_nit.Location = new System.Drawing.Point(77, 112);
            this.Txt_nit.Name = "Txt_nit";
            this.Txt_nit.Size = new System.Drawing.Size(418, 20);
            this.Txt_nit.TabIndex = 15;
            // 
            // label39
            // 
            this.label39.Location = new System.Drawing.Point(44, 113);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(27, 17);
            this.label39.TabIndex = 14;
            this.label39.Text = "Nit:";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_correlativo
            // 
            this.Txt_correlativo.Enabled = false;
            this.Txt_correlativo.Location = new System.Drawing.Point(77, 33);
            this.Txt_correlativo.Name = "Txt_correlativo";
            this.Txt_correlativo.Size = new System.Drawing.Size(418, 20);
            this.Txt_correlativo.TabIndex = 13;
            // 
            // label40
            // 
            this.label40.Location = new System.Drawing.Point(18, 33);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(53, 20);
            this.label40.TabIndex = 12;
            this.label40.Text = "Codigo:";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_apellidos
            // 
            this.Txt_apellidos.Enabled = false;
            this.Txt_apellidos.Location = new System.Drawing.Point(77, 86);
            this.Txt_apellidos.Name = "Txt_apellidos";
            this.Txt_apellidos.Size = new System.Drawing.Size(418, 20);
            this.Txt_apellidos.TabIndex = 11;
            // 
            // label41
            // 
            this.label41.Location = new System.Drawing.Point(15, 87);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(56, 17);
            this.label41.TabIndex = 10;
            this.label41.Text = "Apellidos:";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_nombres
            // 
            this.Txt_nombres.Enabled = false;
            this.Txt_nombres.Location = new System.Drawing.Point(77, 60);
            this.Txt_nombres.Name = "Txt_nombres";
            this.Txt_nombres.Size = new System.Drawing.Size(418, 20);
            this.Txt_nombres.TabIndex = 9;
            // 
            // label42
            // 
            this.label42.Location = new System.Drawing.Point(15, 61);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(56, 17);
            this.label42.TabIndex = 8;
            this.label42.Text = "Nombres:";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.Dgv_facturas);
            this.groupBox14.ForeColor = System.Drawing.Color.Black;
            this.groupBox14.Location = new System.Drawing.Point(27, 139);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(1026, 204);
            this.groupBox14.TabIndex = 32;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Facturas";
            // 
            // Dgv_facturas
            // 
            this.Dgv_facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_facturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Correlativo,
            this.Fecha,
            this.Descripcion,
            this.Moneda,
            this.TipoImpuesto,
            this.Impuesto,
            this.MontoTotal});
            this.Dgv_facturas.Location = new System.Drawing.Point(22, 19);
            this.Dgv_facturas.Name = "Dgv_facturas";
            this.Dgv_facturas.Size = new System.Drawing.Size(987, 169);
            this.Dgv_facturas.TabIndex = 19;
            this.Dgv_facturas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_facturas_CellClick);
            // 
            // Correlativo
            // 
            this.Correlativo.HeaderText = "Correlativo";
            this.Correlativo.Name = "Correlativo";
            this.Correlativo.ReadOnly = true;
            this.Correlativo.Width = 150;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 173;
            // 
            // Moneda
            // 
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.Name = "Moneda";
            this.Moneda.ReadOnly = true;
            this.Moneda.Width = 70;
            // 
            // TipoImpuesto
            // 
            this.TipoImpuesto.HeaderText = "TipoImpuesto";
            this.TipoImpuesto.Name = "TipoImpuesto";
            this.TipoImpuesto.ReadOnly = true;
            this.TipoImpuesto.Width = 150;
            // 
            // Impuesto
            // 
            this.Impuesto.HeaderText = "Impuesto";
            this.Impuesto.Name = "Impuesto";
            this.Impuesto.ReadOnly = true;
            this.Impuesto.Width = 125;
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "MontoTotal";
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            this.MontoTotal.Width = 125;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.Txt_descripcion);
            this.groupBox17.Controls.Add(this.label46);
            this.groupBox17.ForeColor = System.Drawing.Color.White;
            this.groupBox17.Location = new System.Drawing.Point(512, 26);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(541, 107);
            this.groupBox17.TabIndex = 31;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Detalle";
            // 
            // Txt_descripcion
            // 
            this.Txt_descripcion.Location = new System.Drawing.Point(21, 42);
            this.Txt_descripcion.Multiline = true;
            this.Txt_descripcion.Name = "Txt_descripcion";
            this.Txt_descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt_descripcion.Size = new System.Drawing.Size(503, 47);
            this.Txt_descripcion.TabIndex = 11;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.Btn_solicitar);
            this.groupBox8.ForeColor = System.Drawing.Color.White;
            this.groupBox8.Location = new System.Drawing.Point(921, 349);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(132, 161);
            this.groupBox8.TabIndex = 36;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Acciones";
            // 
            // Btn_solicitar
            // 
            this.Btn_solicitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_solicitar.ForeColor = System.Drawing.Color.Black;
            this.Btn_solicitar.Image = global::Facturacion.Properties.Resources.clipboard;
            this.Btn_solicitar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_solicitar.Location = new System.Drawing.Point(27, 47);
            this.Btn_solicitar.Name = "Btn_solicitar";
            this.Btn_solicitar.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.Btn_solicitar.Size = new System.Drawing.Size(79, 69);
            this.Btn_solicitar.TabIndex = 35;
            this.Btn_solicitar.Text = "Solicitar";
            this.Btn_solicitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_solicitar.UseVisualStyleBackColor = true;
            this.Btn_solicitar.Click += new System.EventHandler(this.Btn_solicitar_Click);
            // 
            // CU_Devoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox16);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.groupBox15);
            this.Controls.Add(this.groupBox14);
            this.Controls.Add(this.groupBox17);
            this.Name = "CU_Devoluciones";
            this.Size = new System.Drawing.Size(1080, 550);
            this.Load += new System.EventHandler(this.CU_Devoluciones_Load);
            this.groupBox16.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_facturas)).EndInit();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.ComboBox Cbo_serie;
        private System.Windows.Forms.Button Btn_consultarFacturas;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Button Btn_solicitar;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox Txt_fecha;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox Txt_registros;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox Txt_subtotal;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox Txt_total;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox Txt_impuesto;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.TextBox Txt_nit;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox Txt_correlativo;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox Txt_apellidos;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox Txt_nombres;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.DataGridView Dgv_facturas;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.TextBox Txt_descripcion;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correlativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
    }
}
