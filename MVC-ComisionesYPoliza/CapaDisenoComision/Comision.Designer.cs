namespace CapaDisenoComision
{
    partial class Comision
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBO_IDCOMISION = new System.Windows.Forms.ComboBox();
            this.DTG_Muestra = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RD_Linea = new System.Windows.Forms.RadioButton();
            this.RD_Marca = new System.Windows.Forms.RadioButton();
            this.RD_Producto = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CMB_Trabajador = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CMB_Cargo = new System.Windows.Forms.ComboBox();
            this.Txt_Apellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_Muestra)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBO_IDCOMISION);
            this.groupBox1.Controls.Add(this.DTG_Muestra);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(391, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 311);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COMISION";
            // 
            // CBO_IDCOMISION
            // 
            this.CBO_IDCOMISION.FormattingEnabled = true;
            this.CBO_IDCOMISION.Location = new System.Drawing.Point(138, 89);
            this.CBO_IDCOMISION.Name = "CBO_IDCOMISION";
            this.CBO_IDCOMISION.Size = new System.Drawing.Size(166, 21);
            this.CBO_IDCOMISION.TabIndex = 31;
            // 
            // DTG_Muestra
            // 
            this.DTG_Muestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_Muestra.Location = new System.Drawing.Point(53, 128);
            this.DTG_Muestra.Name = "DTG_Muestra";
            this.DTG_Muestra.Size = new System.Drawing.Size(660, 150);
            this.DTG_Muestra.TabIndex = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RD_Linea);
            this.groupBox2.Controls.Add(this.RD_Marca);
            this.groupBox2.Controls.Add(this.RD_Producto);
            this.groupBox2.Location = new System.Drawing.Point(67, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 42);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TIPO";
            // 
            // RD_Linea
            // 
            this.RD_Linea.AutoSize = true;
            this.RD_Linea.Location = new System.Drawing.Point(437, 13);
            this.RD_Linea.Name = "RD_Linea";
            this.RD_Linea.Size = new System.Drawing.Size(56, 17);
            this.RD_Linea.TabIndex = 21;
            this.RD_Linea.TabStop = true;
            this.RD_Linea.Text = "LINEA";
            this.RD_Linea.UseVisualStyleBackColor = true;
            // 
            // RD_Marca
            // 
            this.RD_Marca.AutoSize = true;
            this.RD_Marca.Location = new System.Drawing.Point(242, 13);
            this.RD_Marca.Name = "RD_Marca";
            this.RD_Marca.Size = new System.Drawing.Size(63, 17);
            this.RD_Marca.TabIndex = 20;
            this.RD_Marca.TabStop = true;
            this.RD_Marca.Text = "MARCA";
            this.RD_Marca.UseVisualStyleBackColor = true;
            // 
            // RD_Producto
            // 
            this.RD_Producto.AutoSize = true;
            this.RD_Producto.Location = new System.Drawing.Point(27, 15);
            this.RD_Producto.Name = "RD_Producto";
            this.RD_Producto.Size = new System.Drawing.Size(86, 17);
            this.RD_Producto.TabIndex = 19;
            this.RD_Producto.TabStop = true;
            this.RD_Producto.Text = "PRODUCTO";
            this.RD_Producto.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "ID";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CMB_Trabajador);
            this.groupBox4.Controls.Add(this.Btn_Eliminar);
            this.groupBox4.Controls.Add(this.Btn_Modificar);
            this.groupBox4.Controls.Add(this.Btn_Guardar);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.CMB_Cargo);
            this.groupBox4.Controls.Add(this.Txt_Apellido);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.Txt_Nombre);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(62, 60);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(310, 416);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "INFO. GENERAL";
            // 
            // CMB_Trabajador
            // 
            this.CMB_Trabajador.FormattingEnabled = true;
            this.CMB_Trabajador.Location = new System.Drawing.Point(23, 70);
            this.CMB_Trabajador.Name = "CMB_Trabajador";
            this.CMB_Trabajador.Size = new System.Drawing.Size(166, 21);
            this.CMB_Trabajador.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "CARGO";
            // 
            // CMB_Cargo
            // 
            this.CMB_Cargo.FormattingEnabled = true;
            this.CMB_Cargo.Location = new System.Drawing.Point(23, 274);
            this.CMB_Cargo.Name = "CMB_Cargo";
            this.CMB_Cargo.Size = new System.Drawing.Size(166, 21);
            this.CMB_Cargo.TabIndex = 23;
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido.Location = new System.Drawing.Point(22, 212);
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.Size = new System.Drawing.Size(162, 20);
            this.Txt_Apellido.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "APELLIDOS";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(23, 157);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(162, 20);
            this.Txt_Nombre.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "NOMBRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID TRABAJADOR";
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.Btn_Eliminar.Image = global::CapaDisenoComision.Properties.Resources.clear;
            this.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Eliminar.Location = new System.Drawing.Point(185, 333);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(75, 55);
            this.Btn_Eliminar.TabIndex = 27;
            this.Btn_Eliminar.Text = "ELIMINAR";
            this.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Modificar.ForeColor = System.Drawing.Color.White;
            this.Btn_Modificar.Image = global::CapaDisenoComision.Properties.Resources.edit;
            this.Btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Modificar.Location = new System.Drawing.Point(104, 333);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(75, 55);
            this.Btn_Modificar.TabIndex = 26;
            this.Btn_Modificar.Text = "MODIFICAR";
            this.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.Btn_Guardar.Image = global::CapaDisenoComision.Properties.Resources.save;
            this.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Guardar.Location = new System.Drawing.Point(23, 333);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(75, 55);
            this.Btn_Guardar.TabIndex = 25;
            this.Btn_Guardar.Text = "GUARDAR";
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // Comision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "Comision";
            this.Size = new System.Drawing.Size(1172, 572);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_Muestra)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBO_IDCOMISION;
        private System.Windows.Forms.DataGridView DTG_Muestra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RD_Linea;
        private System.Windows.Forms.RadioButton RD_Marca;
        private System.Windows.Forms.RadioButton RD_Producto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox CMB_Trabajador;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CMB_Cargo;
        private System.Windows.Forms.TextBox Txt_Apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
