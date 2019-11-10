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
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.Dgv_facturas = new System.Windows.Forms.DataGridView();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.Txt_descripcion = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.Correlativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox13.Controls.Add(this.textBox24);
            this.groupBox13.Controls.Add(this.label34);
            this.groupBox13.Controls.Add(this.textBox25);
            this.groupBox13.Controls.Add(this.label35);
            this.groupBox13.Controls.Add(this.textBox26);
            this.groupBox13.Controls.Add(this.label36);
            this.groupBox13.Controls.Add(this.textBox27);
            this.groupBox13.Controls.Add(this.label37);
            this.groupBox13.Controls.Add(this.textBox28);
            this.groupBox13.Controls.Add(this.label38);
            this.groupBox13.ForeColor = System.Drawing.Color.White;
            this.groupBox13.Location = new System.Drawing.Point(550, 349);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(365, 161);
            this.groupBox13.TabIndex = 34;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Detalle-Factura";
            // 
            // textBox24
            // 
            this.textBox24.Enabled = false;
            this.textBox24.Location = new System.Drawing.Point(91, 124);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(242, 20);
            this.textBox24.TabIndex = 17;
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
            // textBox25
            // 
            this.textBox25.Enabled = false;
            this.textBox25.Location = new System.Drawing.Point(91, 98);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(242, 20);
            this.textBox25.TabIndex = 15;
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
            // textBox26
            // 
            this.textBox26.Enabled = false;
            this.textBox26.Location = new System.Drawing.Point(91, 20);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(242, 20);
            this.textBox26.TabIndex = 13;
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
            // textBox27
            // 
            this.textBox27.Enabled = false;
            this.textBox27.Location = new System.Drawing.Point(91, 72);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(242, 20);
            this.textBox27.TabIndex = 11;
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
            // textBox28
            // 
            this.textBox28.Enabled = false;
            this.textBox28.Location = new System.Drawing.Point(91, 46);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(242, 20);
            this.textBox28.TabIndex = 9;
            // 
            // label38
            // 
            this.label38.Location = new System.Drawing.Point(24, 47);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(61, 17);
            this.label38.TabIndex = 8;
            this.label38.Text = "IVA:";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.textBox29);
            this.groupBox15.Controls.Add(this.label39);
            this.groupBox15.Controls.Add(this.textBox30);
            this.groupBox15.Controls.Add(this.label40);
            this.groupBox15.Controls.Add(this.textBox31);
            this.groupBox15.Controls.Add(this.label41);
            this.groupBox15.Controls.Add(this.textBox32);
            this.groupBox15.Controls.Add(this.label42);
            this.groupBox15.ForeColor = System.Drawing.Color.White;
            this.groupBox15.Location = new System.Drawing.Point(27, 349);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(517, 161);
            this.groupBox15.TabIndex = 33;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Encabezado-Factura";
            // 
            // textBox29
            // 
            this.textBox29.Enabled = false;
            this.textBox29.Location = new System.Drawing.Point(77, 112);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(418, 20);
            this.textBox29.TabIndex = 15;
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
            // textBox30
            // 
            this.textBox30.Enabled = false;
            this.textBox30.Location = new System.Drawing.Point(77, 33);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(418, 20);
            this.textBox30.TabIndex = 13;
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
            // textBox31
            // 
            this.textBox31.Enabled = false;
            this.textBox31.Location = new System.Drawing.Point(77, 86);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(418, 20);
            this.textBox31.TabIndex = 11;
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
            // textBox32
            // 
            this.textBox32.Enabled = false;
            this.textBox32.Location = new System.Drawing.Point(77, 60);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(418, 20);
            this.textBox32.TabIndex = 9;
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
            this.groupBox8.Controls.Add(this.button11);
            this.groupBox8.ForeColor = System.Drawing.Color.White;
            this.groupBox8.Location = new System.Drawing.Point(921, 349);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(132, 161);
            this.groupBox8.TabIndex = 36;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Acciones";
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.Black;
            this.button11.Image = global::Facturacion.Properties.Resources.clipboard;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button11.Location = new System.Drawing.Point(27, 47);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.button11.Size = new System.Drawing.Size(79, 69);
            this.button11.TabIndex = 35;
            this.button11.Text = "Solicitar";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox textBox32;
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
