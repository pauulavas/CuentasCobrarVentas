namespace Capa_Diseño_VentasyCtasporCobrar_lp
{
    partial class Lista_Precios
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
            this.Cbo_tipolista = new System.Windows.Forms.ComboBox();
            this.Dtp_fechainicio = new System.Windows.Forms.DateTimePicker();
            this.Dtp_fechamodificacion = new System.Windows.Forms.DateTimePicker();
            this.Txt_subtotal = new System.Windows.Forms.TextBox();
            this.Txt_descuento = new System.Windows.Forms.TextBox();
            this.Txt_total = new System.Windows.Forms.TextBox();
            this.Btn_aceptarlista = new System.Windows.Forms.Button();
            this.Btn_cancelarlista = new System.Windows.Forms.Button();
            this.Gpb_producto = new System.Windows.Forms.GroupBox();
            this.Dgv_producto = new System.Windows.Forms.DataGridView();
            this.Lbl_nombreproducto = new System.Windows.Forms.Label();
            this.Lbl_codigoproducto = new System.Windows.Forms.Label();
            this.Btn_cancelarproducto = new System.Windows.Forms.Button();
            this.Btn_agregarproducto = new System.Windows.Forms.Button();
            this.Txt_nombreproducto = new System.Windows.Forms.TextBox();
            this.Cbo_codigoproducto = new System.Windows.Forms.ComboBox();
            this.Lbl_tipolista = new System.Windows.Forms.Label();
            this.Lbl_nombrelista = new System.Windows.Forms.Label();
            this.Lbl_fechainicio = new System.Windows.Forms.Label();
            this.Lbl_fechamodificacion = new System.Windows.Forms.Label();
            this.Lbl_subtotal = new System.Windows.Forms.Label();
            this.Lbl_descuento = new System.Windows.Forms.Label();
            this.Lbl_total = new System.Windows.Forms.Label();
            this.Gpb_lista = new System.Windows.Forms.GroupBox();
            this.Txt_FechaInicio2 = new System.Windows.Forms.TextBox();
            this.Txt_FechaInicio = new System.Windows.Forms.TextBox();
            this.TxtTipoLista2 = new System.Windows.Forms.TextBox();
            this.Txt_TipoLista = new System.Windows.Forms.TextBox();
            this.Txt_NombreLista = new System.Windows.Forms.TextBox();
            this.Cbo_NombreLista = new System.Windows.Forms.ComboBox();
            this.Btn_ConsultarLista = new System.Windows.Forms.Button();
            this.Gpb_costolista = new System.Windows.Forms.GroupBox();
            this.Gpb_accion2 = new System.Windows.Forms.GroupBox();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Gpb_accion = new System.Windows.Forms.GroupBox();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_CrearLista = new System.Windows.Forms.Button();
            this.Btn_ModificarLista = new System.Windows.Forms.Button();
            this.Btn_Guardar3 = new System.Windows.Forms.Button();
            this.Txt_idencabezado = new System.Windows.Forms.TextBox();
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.Gpb_producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_producto)).BeginInit();
            this.Gpb_lista.SuspendLayout();
            this.Gpb_costolista.SuspendLayout();
            this.Gpb_accion2.SuspendLayout();
            this.Gpb_accion.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cbo_tipolista
            // 
            this.Cbo_tipolista.FormattingEnabled = true;
            this.Cbo_tipolista.Location = new System.Drawing.Point(144, 59);
            this.Cbo_tipolista.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_tipolista.Name = "Cbo_tipolista";
            this.Cbo_tipolista.Size = new System.Drawing.Size(134, 21);
            this.Cbo_tipolista.TabIndex = 0;
            this.Cbo_tipolista.SelectedIndexChanged += new System.EventHandler(this.Cbo_tipolista_SelectedIndexChanged);
            this.Cbo_tipolista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cbo_tipolista_KeyPress);
            // 
            // Dtp_fechainicio
            // 
            this.Dtp_fechainicio.Location = new System.Drawing.Point(144, 96);
            this.Dtp_fechainicio.Margin = new System.Windows.Forms.Padding(2);
            this.Dtp_fechainicio.Name = "Dtp_fechainicio";
            this.Dtp_fechainicio.Size = new System.Drawing.Size(192, 20);
            this.Dtp_fechainicio.TabIndex = 2;
            this.Dtp_fechainicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dtp_fechainicio_KeyPress);
            // 
            // Dtp_fechamodificacion
            // 
            this.Dtp_fechamodificacion.Location = new System.Drawing.Point(144, 131);
            this.Dtp_fechamodificacion.Margin = new System.Windows.Forms.Padding(2);
            this.Dtp_fechamodificacion.Name = "Dtp_fechamodificacion";
            this.Dtp_fechamodificacion.Size = new System.Drawing.Size(192, 20);
            this.Dtp_fechamodificacion.TabIndex = 3;
            this.Dtp_fechamodificacion.ValueChanged += new System.EventHandler(this.Dtp_fechamodificacion_ValueChanged);
            this.Dtp_fechamodificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dtp_fechamodificacion_KeyPress);
            // 
            // Txt_subtotal
            // 
            this.Txt_subtotal.Location = new System.Drawing.Point(120, 24);
            this.Txt_subtotal.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_subtotal.Name = "Txt_subtotal";
            this.Txt_subtotal.Size = new System.Drawing.Size(165, 20);
            this.Txt_subtotal.TabIndex = 8;
            // 
            // Txt_descuento
            // 
            this.Txt_descuento.Location = new System.Drawing.Point(120, 53);
            this.Txt_descuento.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_descuento.Name = "Txt_descuento";
            this.Txt_descuento.ReadOnly = true;
            this.Txt_descuento.Size = new System.Drawing.Size(165, 20);
            this.Txt_descuento.TabIndex = 9;
            // 
            // Txt_total
            // 
            this.Txt_total.Location = new System.Drawing.Point(120, 83);
            this.Txt_total.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_total.Name = "Txt_total";
            this.Txt_total.Size = new System.Drawing.Size(165, 20);
            this.Txt_total.TabIndex = 10;
            // 
            // Btn_aceptarlista
            // 
            this.Btn_aceptarlista.ForeColor = System.Drawing.Color.Black;
            this.Btn_aceptarlista.Location = new System.Drawing.Point(381, 123);
            this.Btn_aceptarlista.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_aceptarlista.Name = "Btn_aceptarlista";
            this.Btn_aceptarlista.Size = new System.Drawing.Size(89, 28);
            this.Btn_aceptarlista.TabIndex = 11;
            this.Btn_aceptarlista.Text = "Guardar ";
            this.Btn_aceptarlista.UseVisualStyleBackColor = true;
            this.Btn_aceptarlista.Click += new System.EventHandler(this.Btn_aceptarlista_Click);
            // 
            // Btn_cancelarlista
            // 
            this.Btn_cancelarlista.ForeColor = System.Drawing.Color.Black;
            this.Btn_cancelarlista.Location = new System.Drawing.Point(166, 49);
            this.Btn_cancelarlista.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_cancelarlista.Name = "Btn_cancelarlista";
            this.Btn_cancelarlista.Size = new System.Drawing.Size(92, 28);
            this.Btn_cancelarlista.TabIndex = 12;
            this.Btn_cancelarlista.Text = "Cancelar";
            this.Btn_cancelarlista.UseVisualStyleBackColor = true;
            this.Btn_cancelarlista.Click += new System.EventHandler(this.Btn_cancelarlista_Click);
            // 
            // Gpb_producto
            // 
            this.Gpb_producto.Controls.Add(this.Dgv_producto);
            this.Gpb_producto.Controls.Add(this.Lbl_nombreproducto);
            this.Gpb_producto.Controls.Add(this.Lbl_codigoproducto);
            this.Gpb_producto.Controls.Add(this.Btn_cancelarproducto);
            this.Gpb_producto.Controls.Add(this.Btn_agregarproducto);
            this.Gpb_producto.Controls.Add(this.Txt_nombreproducto);
            this.Gpb_producto.Controls.Add(this.Cbo_codigoproducto);
            this.Gpb_producto.ForeColor = System.Drawing.Color.White;
            this.Gpb_producto.Location = new System.Drawing.Point(23, 183);
            this.Gpb_producto.Margin = new System.Windows.Forms.Padding(2);
            this.Gpb_producto.Name = "Gpb_producto";
            this.Gpb_producto.Padding = new System.Windows.Forms.Padding(2);
            this.Gpb_producto.Size = new System.Drawing.Size(671, 258);
            this.Gpb_producto.TabIndex = 13;
            this.Gpb_producto.TabStop = false;
            this.Gpb_producto.Text = "Producto";
            // 
            // Dgv_producto
            // 
            this.Dgv_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_producto.Location = new System.Drawing.Point(21, 122);
            this.Dgv_producto.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_producto.Name = "Dgv_producto";
            this.Dgv_producto.RowHeadersWidth = 51;
            this.Dgv_producto.RowTemplate.Height = 24;
            this.Dgv_producto.Size = new System.Drawing.Size(628, 119);
            this.Dgv_producto.TabIndex = 14;
            // 
            // Lbl_nombreproducto
            // 
            this.Lbl_nombreproducto.AutoSize = true;
            this.Lbl_nombreproducto.Location = new System.Drawing.Point(26, 69);
            this.Lbl_nombreproducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_nombreproducto.Name = "Lbl_nombreproducto";
            this.Lbl_nombreproducto.Size = new System.Drawing.Size(106, 13);
            this.Lbl_nombreproducto.TabIndex = 13;
            this.Lbl_nombreproducto.Text = "Nombre del producto";
            // 
            // Lbl_codigoproducto
            // 
            this.Lbl_codigoproducto.AutoSize = true;
            this.Lbl_codigoproducto.Location = new System.Drawing.Point(26, 36);
            this.Lbl_codigoproducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_codigoproducto.Name = "Lbl_codigoproducto";
            this.Lbl_codigoproducto.Size = new System.Drawing.Size(102, 13);
            this.Lbl_codigoproducto.TabIndex = 12;
            this.Lbl_codigoproducto.Text = "Código del producto";
            // 
            // Btn_cancelarproducto
            // 
            this.Btn_cancelarproducto.ForeColor = System.Drawing.Color.Black;
            this.Btn_cancelarproducto.Location = new System.Drawing.Point(522, 45);
            this.Btn_cancelarproducto.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_cancelarproducto.Name = "Btn_cancelarproducto";
            this.Btn_cancelarproducto.Size = new System.Drawing.Size(92, 28);
            this.Btn_cancelarproducto.TabIndex = 11;
            this.Btn_cancelarproducto.Text = "Eliminar";
            this.Btn_cancelarproducto.UseVisualStyleBackColor = true;
            // 
            // Btn_agregarproducto
            // 
            this.Btn_agregarproducto.ForeColor = System.Drawing.Color.Black;
            this.Btn_agregarproducto.Location = new System.Drawing.Point(389, 45);
            this.Btn_agregarproducto.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_agregarproducto.Name = "Btn_agregarproducto";
            this.Btn_agregarproducto.Size = new System.Drawing.Size(92, 28);
            this.Btn_agregarproducto.TabIndex = 10;
            this.Btn_agregarproducto.Text = "Añadir";
            this.Btn_agregarproducto.UseVisualStyleBackColor = true;
            this.Btn_agregarproducto.Click += new System.EventHandler(this.Btn_agregarproducto_Click);
            // 
            // Txt_nombreproducto
            // 
            this.Txt_nombreproducto.Location = new System.Drawing.Point(146, 66);
            this.Txt_nombreproducto.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_nombreproducto.Name = "Txt_nombreproducto";
            this.Txt_nombreproducto.ReadOnly = true;
            this.Txt_nombreproducto.Size = new System.Drawing.Size(162, 20);
            this.Txt_nombreproducto.TabIndex = 9;
            this.Txt_nombreproducto.TextChanged += new System.EventHandler(this.Txt_nombreproducto_TextChanged);
            // 
            // Cbo_codigoproducto
            // 
            this.Cbo_codigoproducto.FormattingEnabled = true;
            this.Cbo_codigoproducto.Location = new System.Drawing.Point(146, 31);
            this.Cbo_codigoproducto.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_codigoproducto.Name = "Cbo_codigoproducto";
            this.Cbo_codigoproducto.Size = new System.Drawing.Size(162, 21);
            this.Cbo_codigoproducto.TabIndex = 8;
            this.Cbo_codigoproducto.SelectedIndexChanged += new System.EventHandler(this.Cbo_codigoproducto_SelectedIndexChanged);
            this.Cbo_codigoproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cbo_codigoproducto_KeyPress);
            // 
            // Lbl_tipolista
            // 
            this.Lbl_tipolista.AutoSize = true;
            this.Lbl_tipolista.Location = new System.Drawing.Point(22, 62);
            this.Lbl_tipolista.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_tipolista.Name = "Lbl_tipolista";
            this.Lbl_tipolista.Size = new System.Drawing.Size(68, 13);
            this.Lbl_tipolista.TabIndex = 14;
            this.Lbl_tipolista.Text = "Tipo de Lista";
            // 
            // Lbl_nombrelista
            // 
            this.Lbl_nombrelista.AutoSize = true;
            this.Lbl_nombrelista.Location = new System.Drawing.Point(22, 24);
            this.Lbl_nombrelista.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_nombrelista.Name = "Lbl_nombrelista";
            this.Lbl_nombrelista.Size = new System.Drawing.Size(95, 13);
            this.Lbl_nombrelista.TabIndex = 15;
            this.Lbl_nombrelista.Text = "Nombre de la Lista";
            // 
            // Lbl_fechainicio
            // 
            this.Lbl_fechainicio.AutoSize = true;
            this.Lbl_fechainicio.Location = new System.Drawing.Point(22, 100);
            this.Lbl_fechainicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_fechainicio.Name = "Lbl_fechainicio";
            this.Lbl_fechainicio.Size = new System.Drawing.Size(80, 13);
            this.Lbl_fechainicio.TabIndex = 16;
            this.Lbl_fechainicio.Text = "Fecha de Inicio";
            // 
            // Lbl_fechamodificacion
            // 
            this.Lbl_fechamodificacion.AutoSize = true;
            this.Lbl_fechamodificacion.Location = new System.Drawing.Point(19, 131);
            this.Lbl_fechamodificacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_fechamodificacion.Name = "Lbl_fechamodificacion";
            this.Lbl_fechamodificacion.Size = new System.Drawing.Size(115, 13);
            this.Lbl_fechamodificacion.TabIndex = 17;
            this.Lbl_fechamodificacion.Text = "Fecha de Modificación";
            // 
            // Lbl_subtotal
            // 
            this.Lbl_subtotal.AutoSize = true;
            this.Lbl_subtotal.Location = new System.Drawing.Point(50, 24);
            this.Lbl_subtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_subtotal.Name = "Lbl_subtotal";
            this.Lbl_subtotal.Size = new System.Drawing.Size(50, 13);
            this.Lbl_subtotal.TabIndex = 18;
            this.Lbl_subtotal.Text = "SubTotal";
            // 
            // Lbl_descuento
            // 
            this.Lbl_descuento.AutoSize = true;
            this.Lbl_descuento.Location = new System.Drawing.Point(50, 55);
            this.Lbl_descuento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_descuento.Name = "Lbl_descuento";
            this.Lbl_descuento.Size = new System.Drawing.Size(59, 13);
            this.Lbl_descuento.TabIndex = 19;
            this.Lbl_descuento.Text = "Descuento";
            // 
            // Lbl_total
            // 
            this.Lbl_total.AutoSize = true;
            this.Lbl_total.Location = new System.Drawing.Point(50, 85);
            this.Lbl_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_total.Name = "Lbl_total";
            this.Lbl_total.Size = new System.Drawing.Size(31, 13);
            this.Lbl_total.TabIndex = 20;
            this.Lbl_total.Text = "Total";
            // 
            // Gpb_lista
            // 
            this.Gpb_lista.Controls.Add(this.Lbl_Id);
            this.Gpb_lista.Controls.Add(this.Txt_idencabezado);
            this.Gpb_lista.Controls.Add(this.Txt_FechaInicio2);
            this.Gpb_lista.Controls.Add(this.Txt_FechaInicio);
            this.Gpb_lista.Controls.Add(this.Btn_aceptarlista);
            this.Gpb_lista.Controls.Add(this.TxtTipoLista2);
            this.Gpb_lista.Controls.Add(this.Txt_TipoLista);
            this.Gpb_lista.Controls.Add(this.Txt_NombreLista);
            this.Gpb_lista.Controls.Add(this.Cbo_NombreLista);
            this.Gpb_lista.Controls.Add(this.Lbl_fechamodificacion);
            this.Gpb_lista.Controls.Add(this.Lbl_fechainicio);
            this.Gpb_lista.Controls.Add(this.Btn_ConsultarLista);
            this.Gpb_lista.Controls.Add(this.Lbl_nombrelista);
            this.Gpb_lista.Controls.Add(this.Lbl_tipolista);
            this.Gpb_lista.Controls.Add(this.Dtp_fechamodificacion);
            this.Gpb_lista.Controls.Add(this.Dtp_fechainicio);
            this.Gpb_lista.Controls.Add(this.Cbo_tipolista);
            this.Gpb_lista.ForeColor = System.Drawing.Color.White;
            this.Gpb_lista.Location = new System.Drawing.Point(192, 7);
            this.Gpb_lista.Margin = new System.Windows.Forms.Padding(2);
            this.Gpb_lista.Name = "Gpb_lista";
            this.Gpb_lista.Padding = new System.Windows.Forms.Padding(2);
            this.Gpb_lista.Size = new System.Drawing.Size(502, 167);
            this.Gpb_lista.TabIndex = 21;
            this.Gpb_lista.TabStop = false;
            this.Gpb_lista.Text = "Lista";
            // 
            // Txt_FechaInicio2
            // 
            this.Txt_FechaInicio2.Location = new System.Drawing.Point(144, 93);
            this.Txt_FechaInicio2.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_FechaInicio2.Name = "Txt_FechaInicio2";
            this.Txt_FechaInicio2.ReadOnly = true;
            this.Txt_FechaInicio2.Size = new System.Drawing.Size(192, 20);
            this.Txt_FechaInicio2.TabIndex = 25;
            // 
            // Txt_FechaInicio
            // 
            this.Txt_FechaInicio.Location = new System.Drawing.Point(144, 96);
            this.Txt_FechaInicio.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_FechaInicio.Name = "Txt_FechaInicio";
            this.Txt_FechaInicio.Size = new System.Drawing.Size(192, 20);
            this.Txt_FechaInicio.TabIndex = 24;
            // 
            // TxtTipoLista2
            // 
            this.TxtTipoLista2.Location = new System.Drawing.Point(25, 77);
            this.TxtTipoLista2.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTipoLista2.Name = "TxtTipoLista2";
            this.TxtTipoLista2.ReadOnly = true;
            this.TxtTipoLista2.Size = new System.Drawing.Size(132, 20);
            this.TxtTipoLista2.TabIndex = 23;
            // 
            // Txt_TipoLista
            // 
            this.Txt_TipoLista.Location = new System.Drawing.Point(304, 60);
            this.Txt_TipoLista.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_TipoLista.Name = "Txt_TipoLista";
            this.Txt_TipoLista.Size = new System.Drawing.Size(132, 20);
            this.Txt_TipoLista.TabIndex = 22;
            // 
            // Txt_NombreLista
            // 
            this.Txt_NombreLista.Location = new System.Drawing.Point(144, 22);
            this.Txt_NombreLista.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_NombreLista.Name = "Txt_NombreLista";
            this.Txt_NombreLista.Size = new System.Drawing.Size(132, 20);
            this.Txt_NombreLista.TabIndex = 21;
            // 
            // Cbo_NombreLista
            // 
            this.Cbo_NombreLista.FormattingEnabled = true;
            this.Cbo_NombreLista.Location = new System.Drawing.Point(144, 21);
            this.Cbo_NombreLista.Name = "Cbo_NombreLista";
            this.Cbo_NombreLista.Size = new System.Drawing.Size(134, 21);
            this.Cbo_NombreLista.TabIndex = 20;
            this.Cbo_NombreLista.SelectedIndexChanged += new System.EventHandler(this.Cbo_NombreLista_SelectedIndexChanged);
            this.Cbo_NombreLista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cbo_NombreLista_KeyPress);
            // 
            // Btn_ConsultarLista
            // 
            this.Btn_ConsultarLista.ForeColor = System.Drawing.Color.Black;
            this.Btn_ConsultarLista.Location = new System.Drawing.Point(304, 17);
            this.Btn_ConsultarLista.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ConsultarLista.Name = "Btn_ConsultarLista";
            this.Btn_ConsultarLista.Size = new System.Drawing.Size(96, 28);
            this.Btn_ConsultarLista.TabIndex = 19;
            this.Btn_ConsultarLista.Text = "Consultar Lista";
            this.Btn_ConsultarLista.UseVisualStyleBackColor = true;
            this.Btn_ConsultarLista.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Gpb_costolista
            // 
            this.Gpb_costolista.Controls.Add(this.Lbl_total);
            this.Gpb_costolista.Controls.Add(this.Lbl_descuento);
            this.Gpb_costolista.Controls.Add(this.Lbl_subtotal);
            this.Gpb_costolista.Controls.Add(this.Txt_total);
            this.Gpb_costolista.Controls.Add(this.Txt_descuento);
            this.Gpb_costolista.Controls.Add(this.Txt_subtotal);
            this.Gpb_costolista.ForeColor = System.Drawing.Color.White;
            this.Gpb_costolista.Location = new System.Drawing.Point(25, 452);
            this.Gpb_costolista.Margin = new System.Windows.Forms.Padding(2);
            this.Gpb_costolista.Name = "Gpb_costolista";
            this.Gpb_costolista.Padding = new System.Windows.Forms.Padding(2);
            this.Gpb_costolista.Size = new System.Drawing.Size(351, 125);
            this.Gpb_costolista.TabIndex = 22;
            this.Gpb_costolista.TabStop = false;
            this.Gpb_costolista.Text = "Costo de la Lista";
            // 
            // Gpb_accion2
            // 
            this.Gpb_accion2.Controls.Add(this.Btn_Guardar3);
            this.Gpb_accion2.Controls.Add(this.Btn_guardar);
            this.Gpb_accion2.Controls.Add(this.Btn_cancelarlista);
            this.Gpb_accion2.ForeColor = System.Drawing.Color.White;
            this.Gpb_accion2.Location = new System.Drawing.Point(389, 456);
            this.Gpb_accion2.Margin = new System.Windows.Forms.Padding(2);
            this.Gpb_accion2.Name = "Gpb_accion2";
            this.Gpb_accion2.Padding = new System.Windows.Forms.Padding(2);
            this.Gpb_accion2.Size = new System.Drawing.Size(305, 120);
            this.Gpb_accion2.TabIndex = 23;
            this.Gpb_accion2.TabStop = false;
            this.Gpb_accion2.Text = "Acciones";
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.ForeColor = System.Drawing.Color.Black;
            this.Btn_guardar.Location = new System.Drawing.Point(41, 51);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(89, 28);
            this.Btn_guardar.TabIndex = 13;
            this.Btn_guardar.Text = "Guardar ";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar2_Click);
            // 
            // Gpb_accion
            // 
            this.Gpb_accion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Gpb_accion.Controls.Add(this.Btn_Salir);
            this.Gpb_accion.Controls.Add(this.Btn_CrearLista);
            this.Gpb_accion.Controls.Add(this.Btn_ModificarLista);
            this.Gpb_accion.ForeColor = System.Drawing.Color.White;
            this.Gpb_accion.Location = new System.Drawing.Point(25, 7);
            this.Gpb_accion.Margin = new System.Windows.Forms.Padding(2);
            this.Gpb_accion.Name = "Gpb_accion";
            this.Gpb_accion.Padding = new System.Windows.Forms.Padding(2);
            this.Gpb_accion.Size = new System.Drawing.Size(145, 167);
            this.Gpb_accion.TabIndex = 24;
            this.Gpb_accion.TabStop = false;
            this.Gpb_accion.Text = "Acciones";
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.ForeColor = System.Drawing.Color.Black;
            this.Btn_Salir.Location = new System.Drawing.Point(22, 108);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(96, 28);
            this.Btn_Salir.TabIndex = 22;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_CrearLista
            // 
            this.Btn_CrearLista.ForeColor = System.Drawing.Color.Black;
            this.Btn_CrearLista.Location = new System.Drawing.Point(22, 24);
            this.Btn_CrearLista.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_CrearLista.Name = "Btn_CrearLista";
            this.Btn_CrearLista.Size = new System.Drawing.Size(96, 28);
            this.Btn_CrearLista.TabIndex = 21;
            this.Btn_CrearLista.Text = "Crear Lista";
            this.Btn_CrearLista.UseVisualStyleBackColor = true;
            this.Btn_CrearLista.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Btn_ModificarLista
            // 
            this.Btn_ModificarLista.ForeColor = System.Drawing.Color.Black;
            this.Btn_ModificarLista.Location = new System.Drawing.Point(22, 66);
            this.Btn_ModificarLista.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ModificarLista.Name = "Btn_ModificarLista";
            this.Btn_ModificarLista.Size = new System.Drawing.Size(96, 28);
            this.Btn_ModificarLista.TabIndex = 20;
            this.Btn_ModificarLista.Text = "Modificar Lista";
            this.Btn_ModificarLista.UseVisualStyleBackColor = true;
            this.Btn_ModificarLista.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Btn_Guardar3
            // 
            this.Btn_Guardar3.ForeColor = System.Drawing.Color.Black;
            this.Btn_Guardar3.Location = new System.Drawing.Point(41, 19);
            this.Btn_Guardar3.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Guardar3.Name = "Btn_Guardar3";
            this.Btn_Guardar3.Size = new System.Drawing.Size(89, 28);
            this.Btn_Guardar3.TabIndex = 14;
            this.Btn_Guardar3.Text = "Guardar ";
            this.Btn_Guardar3.UseVisualStyleBackColor = true;
            // 
            // Txt_idencabezado
            // 
            this.Txt_idencabezado.Location = new System.Drawing.Point(355, 22);
            this.Txt_idencabezado.Name = "Txt_idencabezado";
            this.Txt_idencabezado.Size = new System.Drawing.Size(100, 20);
            this.Txt_idencabezado.TabIndex = 26;
            // 
            // Lbl_Id
            // 
            this.Lbl_Id.AutoSize = true;
            this.Lbl_Id.Location = new System.Drawing.Point(331, 25);
            this.Lbl_Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Id.Name = "Lbl_Id";
            this.Lbl_Id.Size = new System.Drawing.Size(19, 13);
            this.Lbl_Id.TabIndex = 27;
            this.Lbl_Id.Text = "Id ";
            // 
            // Lista_Precios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.Controls.Add(this.Gpb_accion);
            this.Controls.Add(this.Gpb_accion2);
            this.Controls.Add(this.Gpb_costolista);
            this.Controls.Add(this.Gpb_lista);
            this.Controls.Add(this.Gpb_producto);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Lista_Precios";
            this.Size = new System.Drawing.Size(723, 593);
            this.Load += new System.EventHandler(this.Lista_Precios_Load);
            this.Gpb_producto.ResumeLayout(false);
            this.Gpb_producto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_producto)).EndInit();
            this.Gpb_lista.ResumeLayout(false);
            this.Gpb_lista.PerformLayout();
            this.Gpb_costolista.ResumeLayout(false);
            this.Gpb_costolista.PerformLayout();
            this.Gpb_accion2.ResumeLayout(false);
            this.Gpb_accion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Cbo_tipolista;
        private System.Windows.Forms.DateTimePicker Dtp_fechainicio;
        private System.Windows.Forms.DateTimePicker Dtp_fechamodificacion;
        private System.Windows.Forms.TextBox Txt_subtotal;
        private System.Windows.Forms.TextBox Txt_descuento;
        private System.Windows.Forms.TextBox Txt_total;
        private System.Windows.Forms.Button Btn_aceptarlista;
        private System.Windows.Forms.Button Btn_cancelarlista;
        private System.Windows.Forms.GroupBox Gpb_producto;
        private System.Windows.Forms.DataGridView Dgv_producto;
        private System.Windows.Forms.Label Lbl_nombreproducto;
        private System.Windows.Forms.Label Lbl_codigoproducto;
        private System.Windows.Forms.Button Btn_cancelarproducto;
        private System.Windows.Forms.Button Btn_agregarproducto;
        private System.Windows.Forms.TextBox Txt_nombreproducto;
        private System.Windows.Forms.ComboBox Cbo_codigoproducto;
        private System.Windows.Forms.Label Lbl_tipolista;
        private System.Windows.Forms.Label Lbl_nombrelista;
        private System.Windows.Forms.Label Lbl_fechainicio;
        private System.Windows.Forms.Label Lbl_fechamodificacion;
        private System.Windows.Forms.Label Lbl_subtotal;
        private System.Windows.Forms.Label Lbl_descuento;
        private System.Windows.Forms.Label Lbl_total;
        private System.Windows.Forms.GroupBox Gpb_lista;
        private System.Windows.Forms.GroupBox Gpb_costolista;
        private System.Windows.Forms.GroupBox Gpb_accion2;
        private System.Windows.Forms.GroupBox Gpb_accion;
        private System.Windows.Forms.Button Btn_CrearLista;
        private System.Windows.Forms.Button Btn_ModificarLista;
        private System.Windows.Forms.Button Btn_ConsultarLista;
        private System.Windows.Forms.ComboBox Cbo_NombreLista;
        private System.Windows.Forms.TextBox Txt_NombreLista;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.TextBox Txt_TipoLista;
        private System.Windows.Forms.TextBox TxtTipoLista2;
        private System.Windows.Forms.TextBox Txt_FechaInicio;
        private System.Windows.Forms.TextBox Txt_FechaInicio2;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_Guardar3;
        private System.Windows.Forms.TextBox Txt_idencabezado;
        private System.Windows.Forms.Label Lbl_Id;
    }
}
