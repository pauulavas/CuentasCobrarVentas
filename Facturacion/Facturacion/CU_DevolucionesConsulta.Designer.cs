namespace Facturacion
{
    partial class CU_DevolucionesConsulta
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
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.Btn_rechazar = new System.Windows.Forms.Button();
            this.Txt_fechaDev = new System.Windows.Forms.TextBox();
            this.Btn_aprobar = new System.Windows.Forms.Button();
            this.label50 = new System.Windows.Forms.Label();
            this.Txt_factura = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.Txt_solicitud = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.Txt_desc = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.Txt_fecha = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.Txt_registros = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.Txt_subtotal = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.Txt_total = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.Txt_impuesto = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.Dgv_solicitudes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.Txt_nit = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.Txt_codigo = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.Txt_apellidos = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.Txt_nombres = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.groupBox18.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_solicitudes)).BeginInit();
            this.groupBox22.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.Btn_rechazar);
            this.groupBox18.Controls.Add(this.Txt_fechaDev);
            this.groupBox18.Controls.Add(this.Btn_aprobar);
            this.groupBox18.Controls.Add(this.label50);
            this.groupBox18.Controls.Add(this.Txt_factura);
            this.groupBox18.Controls.Add(this.label49);
            this.groupBox18.Controls.Add(this.Txt_solicitud);
            this.groupBox18.Controls.Add(this.label48);
            this.groupBox18.Controls.Add(this.Txt_desc);
            this.groupBox18.Controls.Add(this.label47);
            this.groupBox18.ForeColor = System.Drawing.Color.White;
            this.groupBox18.Location = new System.Drawing.Point(28, 339);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(1026, 110);
            this.groupBox18.TabIndex = 30;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Detalle-Solicitud";
            // 
            // Btn_rechazar
            // 
            this.Btn_rechazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_rechazar.ForeColor = System.Drawing.Color.Black;
            this.Btn_rechazar.Image = global::Facturacion.Properties.Resources.cancel;
            this.Btn_rechazar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_rechazar.Location = new System.Drawing.Point(932, 21);
            this.Btn_rechazar.Name = "Btn_rechazar";
            this.Btn_rechazar.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.Btn_rechazar.Size = new System.Drawing.Size(77, 67);
            this.Btn_rechazar.TabIndex = 26;
            this.Btn_rechazar.Text = "Rechazar";
            this.Btn_rechazar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_rechazar.UseVisualStyleBackColor = true;
            this.Btn_rechazar.Click += new System.EventHandler(this.Btn_rechazar_Click);
            // 
            // Txt_fechaDev
            // 
            this.Txt_fechaDev.Enabled = false;
            this.Txt_fechaDev.Location = new System.Drawing.Point(78, 74);
            this.Txt_fechaDev.Name = "Txt_fechaDev";
            this.Txt_fechaDev.Size = new System.Drawing.Size(210, 20);
            this.Txt_fechaDev.TabIndex = 19;
            // 
            // Btn_aprobar
            // 
            this.Btn_aprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_aprobar.ForeColor = System.Drawing.Color.Black;
            this.Btn_aprobar.Image = global::Facturacion.Properties.Resources._checked;
            this.Btn_aprobar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_aprobar.Location = new System.Drawing.Point(849, 21);
            this.Btn_aprobar.Name = "Btn_aprobar";
            this.Btn_aprobar.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.Btn_aprobar.Size = new System.Drawing.Size(77, 67);
            this.Btn_aprobar.TabIndex = 25;
            this.Btn_aprobar.Text = "Aprobar";
            this.Btn_aprobar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_aprobar.UseVisualStyleBackColor = true;
            this.Btn_aprobar.Click += new System.EventHandler(this.Btn_aprobar_Click);
            // 
            // label50
            // 
            this.label50.Location = new System.Drawing.Point(19, 74);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(43, 20);
            this.label50.TabIndex = 18;
            this.label50.Text = "Fecha:";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_factura
            // 
            this.Txt_factura.Enabled = false;
            this.Txt_factura.Location = new System.Drawing.Point(78, 47);
            this.Txt_factura.Name = "Txt_factura";
            this.Txt_factura.Size = new System.Drawing.Size(210, 20);
            this.Txt_factura.TabIndex = 17;
            // 
            // label49
            // 
            this.label49.Location = new System.Drawing.Point(19, 47);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(53, 20);
            this.label49.TabIndex = 16;
            this.label49.Text = "Factura:";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_solicitud
            // 
            this.Txt_solicitud.Enabled = false;
            this.Txt_solicitud.Location = new System.Drawing.Point(78, 21);
            this.Txt_solicitud.Name = "Txt_solicitud";
            this.Txt_solicitud.Size = new System.Drawing.Size(210, 20);
            this.Txt_solicitud.TabIndex = 15;
            // 
            // label48
            // 
            this.label48.Location = new System.Drawing.Point(19, 21);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(32, 20);
            this.label48.TabIndex = 14;
            this.label48.Text = "Id:";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_desc
            // 
            this.Txt_desc.Enabled = false;
            this.Txt_desc.Location = new System.Drawing.Point(322, 39);
            this.Txt_desc.Multiline = true;
            this.Txt_desc.Name = "Txt_desc";
            this.Txt_desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt_desc.Size = new System.Drawing.Size(503, 55);
            this.Txt_desc.TabIndex = 13;
            // 
            // label47
            // 
            this.label47.Location = new System.Drawing.Point(322, 19);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(64, 17);
            this.label47.TabIndex = 12;
            this.label47.Text = "Descripcion";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.Txt_fecha);
            this.groupBox20.Controls.Add(this.label51);
            this.groupBox20.Controls.Add(this.Txt_registros);
            this.groupBox20.Controls.Add(this.label52);
            this.groupBox20.Controls.Add(this.Txt_subtotal);
            this.groupBox20.Controls.Add(this.label53);
            this.groupBox20.Controls.Add(this.Txt_total);
            this.groupBox20.Controls.Add(this.label54);
            this.groupBox20.Controls.Add(this.Txt_impuesto);
            this.groupBox20.Controls.Add(this.label55);
            this.groupBox20.ForeColor = System.Drawing.Color.White;
            this.groupBox20.Location = new System.Drawing.Point(551, 223);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(503, 110);
            this.groupBox20.TabIndex = 29;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Detalle-Factura";
            // 
            // Txt_fecha
            // 
            this.Txt_fecha.Enabled = false;
            this.Txt_fecha.Location = new System.Drawing.Point(326, 44);
            this.Txt_fecha.Name = "Txt_fecha";
            this.Txt_fecha.Size = new System.Drawing.Size(151, 20);
            this.Txt_fecha.TabIndex = 17;
            // 
            // label51
            // 
            this.label51.Location = new System.Drawing.Point(259, 44);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(61, 20);
            this.label51.TabIndex = 16;
            this.label51.Text = "Fecha:";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_registros
            // 
            this.Txt_registros.Enabled = false;
            this.Txt_registros.Location = new System.Drawing.Point(326, 18);
            this.Txt_registros.Name = "Txt_registros";
            this.Txt_registros.Size = new System.Drawing.Size(151, 20);
            this.Txt_registros.TabIndex = 15;
            // 
            // label52
            // 
            this.label52.Location = new System.Drawing.Point(259, 19);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(61, 20);
            this.label52.TabIndex = 14;
            this.label52.Text = "Registros:";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_subtotal
            // 
            this.Txt_subtotal.Enabled = false;
            this.Txt_subtotal.Location = new System.Drawing.Point(96, 18);
            this.Txt_subtotal.Name = "Txt_subtotal";
            this.Txt_subtotal.Size = new System.Drawing.Size(151, 20);
            this.Txt_subtotal.TabIndex = 13;
            // 
            // label53
            // 
            this.label53.Location = new System.Drawing.Point(29, 19);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(61, 20);
            this.label53.TabIndex = 12;
            this.label53.Text = "SubTotal:";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_total
            // 
            this.Txt_total.Enabled = false;
            this.Txt_total.Location = new System.Drawing.Point(96, 70);
            this.Txt_total.Name = "Txt_total";
            this.Txt_total.Size = new System.Drawing.Size(151, 20);
            this.Txt_total.TabIndex = 11;
            // 
            // label54
            // 
            this.label54.Location = new System.Drawing.Point(29, 71);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(56, 17);
            this.label54.TabIndex = 10;
            this.label54.Text = "Total:";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_impuesto
            // 
            this.Txt_impuesto.Enabled = false;
            this.Txt_impuesto.Location = new System.Drawing.Point(96, 44);
            this.Txt_impuesto.Name = "Txt_impuesto";
            this.Txt_impuesto.Size = new System.Drawing.Size(151, 20);
            this.Txt_impuesto.TabIndex = 9;
            // 
            // label55
            // 
            this.label55.Location = new System.Drawing.Point(29, 45);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(56, 17);
            this.label55.TabIndex = 8;
            this.label55.Text = "IVA:";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.Dgv_solicitudes);
            this.groupBox21.ForeColor = System.Drawing.Color.Black;
            this.groupBox21.Location = new System.Drawing.Point(28, 13);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(1026, 204);
            this.groupBox21.TabIndex = 28;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Solicitudes";
            // 
            // Dgv_solicitudes
            // 
            this.Dgv_solicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_solicitudes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion,
            this.Fecha,
            this.Factura});
            this.Dgv_solicitudes.Location = new System.Drawing.Point(22, 19);
            this.Dgv_solicitudes.Name = "Dgv_solicitudes";
            this.Dgv_solicitudes.Size = new System.Drawing.Size(987, 169);
            this.Dgv_solicitudes.TabIndex = 19;
            this.Dgv_solicitudes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_solicitudes_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 490;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 150;
            // 
            // Factura
            // 
            this.Factura.HeaderText = "Factura";
            this.Factura.Name = "Factura";
            this.Factura.ReadOnly = true;
            this.Factura.Width = 150;
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.Txt_nit);
            this.groupBox22.Controls.Add(this.label56);
            this.groupBox22.Controls.Add(this.Txt_codigo);
            this.groupBox22.Controls.Add(this.label57);
            this.groupBox22.Controls.Add(this.Txt_apellidos);
            this.groupBox22.Controls.Add(this.label58);
            this.groupBox22.Controls.Add(this.Txt_nombres);
            this.groupBox22.Controls.Add(this.label59);
            this.groupBox22.ForeColor = System.Drawing.Color.White;
            this.groupBox22.Location = new System.Drawing.Point(28, 223);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(517, 110);
            this.groupBox22.TabIndex = 27;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Encabezado-Factura";
            // 
            // Txt_nit
            // 
            this.Txt_nit.Enabled = false;
            this.Txt_nit.Location = new System.Drawing.Point(325, 18);
            this.Txt_nit.Name = "Txt_nit";
            this.Txt_nit.Size = new System.Drawing.Size(169, 20);
            this.Txt_nit.TabIndex = 15;
            // 
            // label56
            // 
            this.label56.Location = new System.Drawing.Point(292, 19);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(27, 17);
            this.label56.TabIndex = 14;
            this.label56.Text = "Nit:";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_codigo
            // 
            this.Txt_codigo.Enabled = false;
            this.Txt_codigo.Location = new System.Drawing.Point(76, 19);
            this.Txt_codigo.Name = "Txt_codigo";
            this.Txt_codigo.Size = new System.Drawing.Size(210, 20);
            this.Txt_codigo.TabIndex = 13;
            // 
            // label57
            // 
            this.label57.Location = new System.Drawing.Point(17, 19);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(53, 20);
            this.label57.TabIndex = 12;
            this.label57.Text = "Codigo:";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_apellidos
            // 
            this.Txt_apellidos.Enabled = false;
            this.Txt_apellidos.Location = new System.Drawing.Point(76, 72);
            this.Txt_apellidos.Name = "Txt_apellidos";
            this.Txt_apellidos.Size = new System.Drawing.Size(418, 20);
            this.Txt_apellidos.TabIndex = 11;
            // 
            // label58
            // 
            this.label58.Location = new System.Drawing.Point(14, 73);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(56, 17);
            this.label58.TabIndex = 10;
            this.label58.Text = "Apellidos:";
            this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_nombres
            // 
            this.Txt_nombres.Enabled = false;
            this.Txt_nombres.Location = new System.Drawing.Point(76, 46);
            this.Txt_nombres.Name = "Txt_nombres";
            this.Txt_nombres.Size = new System.Drawing.Size(418, 20);
            this.Txt_nombres.TabIndex = 9;
            // 
            // label59
            // 
            this.label59.Location = new System.Drawing.Point(14, 47);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(56, 17);
            this.label59.TabIndex = 8;
            this.label59.Text = "Nombres:";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CU_DevolucionesConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.Controls.Add(this.groupBox18);
            this.Controls.Add(this.groupBox20);
            this.Controls.Add(this.groupBox21);
            this.Controls.Add(this.groupBox22);
            this.Name = "CU_DevolucionesConsulta";
            this.Size = new System.Drawing.Size(1080, 475);
            this.Load += new System.EventHandler(this.CU_DevolucionesConsulta_Load);
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_solicitudes)).EndInit();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.TextBox Txt_fechaDev;
        private System.Windows.Forms.Button Btn_aprobar;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox Txt_factura;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox Txt_solicitud;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox Txt_desc;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.TextBox Txt_fecha;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox Txt_registros;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox Txt_subtotal;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox Txt_total;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox Txt_impuesto;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.DataGridView Dgv_solicitudes;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.TextBox Txt_nit;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox Txt_codigo;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox Txt_apellidos;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TextBox Txt_nombres;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
        private System.Windows.Forms.Button Btn_rechazar;
    }
}
