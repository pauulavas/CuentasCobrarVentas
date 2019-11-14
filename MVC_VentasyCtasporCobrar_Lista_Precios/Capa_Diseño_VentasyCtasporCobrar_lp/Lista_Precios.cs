using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica_VentasyCtasporCobrar_lp;

namespace Capa_Diseño_VentasyCtasporCobrar_lp
{
    public partial class Lista_Precios : UserControl
    {

        logica_lista_precio log;

        //int tipo_lista_precios;
        List<int> listaprecios = new List<int>();
        List<int> tipolistaprecios = new List<int>();
        List<int> listaproducto = new List<int>();
        string fecha_inicio;
        string fecha_modificacion;
        //string sTipolista;

        public Lista_Precios()
        {
            InitializeComponent();
            log = new logica_lista_precio();
        }

        private void Lista_Precios_Load(object sender, EventArgs e)
        {
            Btn_ModificarLista.Enabled = false;
            //VISIBLES
            Gpb_producto.Visible = false;
            Gpb_accion2.Visible = false;
            Gpb_costolista.Visible = false;
            Gpb_lista.Visible = false;
            Txt_TipoLista.Visible = false;
            Txt_TipoLista.Enabled = false;
            TxtTipoLista2.Visible = false;
            TxtTipoLista2.Enabled = false;
            Txt_FechaInicio.Visible = false;
            Txt_FechaInicio.Enabled = false;
            Txt_FechaInicio2.Visible = false;
            Btn_guardar2.Visible = false;
            Btn_guardar2.Enabled = false;
            Txt_id.Visible = false;
            Lbl_Codigo.Visible = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //visible al boton crear
            Gpb_producto.Visible = true;
            Gpb_producto.Enabled = true;
            Gpb_accion2.Visible = true;
            Gpb_accion2.Enabled = true;
            Gpb_costolista.Visible = true;
            Gpb_costolista.Enabled = true;
            Gpb_lista.Visible = true;
            Txt_NombreLista.Visible = true;
            Lbl_tipolista.Visible = true;
            Cbo_tipolista.Visible = true;
            Lbl_fechainicio.Visible = true;
            Dtp_fechainicio.Visible = true;
            Lbl_fechamodificacion.Visible = false;
            Dtp_fechamodificacion.Visible = false;
            Btn_ModificarLista.Visible = false;
            Cbo_NombreLista.Visible = false;
            Cbo_NombreLista.Enabled = false;
            Gpb_accion.Visible = false;
            Btn_ConsultarLista.Visible = false;
            Dtp_fechainicio.ResetText();
            Btn_CrearLista.Visible = true;
            Btn_CrearLista.Enabled = true;
            Btn_aceptarlista.Enabled = true;
            Btn_aceptarlista.Visible = true;
            Btn_guardar2.Visible = false;
            Btn_guardar2.Enabled = false;
            Txt_id.Visible = false;
            Lbl_Codigo.Visible = false;
            Txt_id2.Visible = false;
            Lbl_Codigo2.Visible = false;
            Btn_agregarproducto.Enabled = true;
            //Carga Tabla tipo de listas
            Cbo_tipolista.Items.Clear();
            Cbo_tipolista.Text = "";
            tipolistaprecios.Clear();
            log.CargarTabla2(Cbo_tipolista, tipolistaprecios);

            //Carga Tabla Codigo Producto
            Cbo_codigoproducto.Items.Clear();
            Cbo_codigoproducto.Text = "";
            log.CargarTabla3(Cbo_codigoproducto);
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //visible al boton modificar
            Gpb_lista.Visible = true;
            Gpb_costolista.Visible = false;
            Gpb_accion2.Visible = true;
            Gpb_producto.Visible = false;
            Cbo_tipolista.Visible = false;
            Lbl_tipolista.Visible = false;
            Lbl_fechainicio.Visible = false;
            Lbl_fechamodificacion.Visible = false;
            Dtp_fechainicio.Visible = false;
            Dtp_fechamodificacion.Visible = false;
            Txt_NombreLista.Visible = false;
            Gpb_accion.Visible = false;
            Cbo_NombreLista.Visible = true;
            Cbo_NombreLista.Enabled = true;
            Btn_ConsultarLista.Visible = true;
            Btn_ConsultarLista.Enabled = true;
            Txt_id2.Visible = false;
            Lbl_Codigo2.Visible = false;
            Btn_aceptarlista.Visible = false;
            Btn_aceptarlista.Enabled = false;



            //Cargar datos al combobox de nombre de listas
            Cbo_NombreLista.Items.Clear();
            Cbo_NombreLista.Text = "";
            listaprecios.Clear();
            log.CargarTabla(Cbo_NombreLista, listaprecios);

        }

        private void Cbo_tipolista_SelectedIndexChanged(object sender, EventArgs e)
        {
            //mostrar el descuento de la lista de precios según tipo de lista
            if (Cbo_tipolista.Items.Count > 0)
            {
                log.CargarTexto2(Txt_descuento, Cbo_tipolista.Text);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(Cbo_NombreLista.Text == "")
            {
                MessageBox.Show("Existen Campos Vacíos");
            }
            else {
                //buscar tipo de lista segun el nombre de la lista
                if (Cbo_NombreLista.Items.Count > 0)
                {
                    //me muestra el id del tipo de lista
                    TxtTipoLista2.Visible = true;
                    TxtTipoLista2.Enabled = true;
                    Lbl_tipolista.Visible = true;
                    log.CargarTipoLista(Txt_TipoLista, Cbo_NombreLista.Text);
                    //cargo el nombre del tipo de lista en el combobox según el id
                    log.CargarTipoLista2(TxtTipoLista2, Txt_TipoLista.Text);
                    //cargo el descuento según el tipo de lista
                    log.CargarDescuento(Txt_descuento, Txt_TipoLista.Text);
                    //cargar id de la fecha inicio
                    Lbl_fechainicio.Visible = true;
                    Txt_FechaInicio2.Visible = true;
                    Txt_FechaInicio2.Enabled = true;
                    log.CargarFechaInicio(Txt_FechaInicio, Cbo_NombreLista.Text);
                    //cargar la fecha de inicio según id de encabezado
                    log.CargarFechaInicio2(Txt_FechaInicio2, Txt_FechaInicio.Text);
                    //muestra campos para ingresar fecha modificación
                    Lbl_fechamodificacion.Visible = true;
                    Lbl_fechamodificacion.Enabled = true;
                    Dtp_fechamodificacion.Enabled = true;
                    Dtp_fechamodificacion.Visible = true;
                    //producto
                    Gpb_producto.Visible = true;
                    Gpb_producto.Enabled = true;
                    //costo lista
                    Gpb_costolista.Visible = true;
                    Gpb_costolista.Enabled = true;
                    //visible aceptar lista
                    Btn_guardar2.Visible = true;
                    Btn_guardar2.Enabled = true;
                    //busca id de encabezado
                    log.BuscarId(Txt_id, fecha_inicio);
                    //buscar id de tipo de lista
                    string tipolista_1 = Cbo_tipolista.Text;
                    log.BuscarIdTipoLista(Txt_id2, tipolista_1);
                }
            }
        }

        private void Btn_cancelarlista_Click(object sender, EventArgs e)
        {
            Btn_ModificarLista.Enabled = false;
            //Aparezca el primer submenu
            Gpb_accion.Visible = true;
            Gpb_accion.Enabled = true;
            Btn_ModificarLista.Visible = true;
            Btn_ModificarLista.Enabled = true;
            Gpb_producto.Visible = false;
            Gpb_accion2.Visible = false;
            Gpb_costolista.Visible = false;
            Gpb_lista.Visible = false;
            Txt_nombreproducto.Text = "";
            Txt_descuento.Text = "";
            Dtp_fechainicio.ResetText();
            TxtTipoLista2.Visible = false;
            Txt_FechaInicio2.Enabled = false;
            TxtTipoLista2.Enabled = false;
            Txt_FechaInicio2.Visible = false;
            Dtp_fechamodificacion.ResetText();
            Cbo_NombreLista.Items.Clear();
            Txt_NombreLista.Text = "";
            Txt_NombreLista.Clear();
            Txt_descuento.Clear();
            Txt_FechaInicio.Clear();
            TxtTipoLista2.Clear();
            Txt_FechaInicio2.Clear();
            Txt_nombreproducto.Clear();
            Txt_precio.Clear();
            Txt_TipoLista.Clear();
            
            Cbo_codigoproducto.Items.Clear();
            Cbo_NombreLista.Items.Clear();
            Cbo_tipolista.Items.Clear();
            Btn_CrearLista.Enabled = true;
            Btn_CrearLista.Visible = true;
            Txt_id.Clear();
            Txt_id2.Clear();
            
        }

        private void Cbo_NombreLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txt_nombreproducto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Cbo_codigoproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //mostrar el nombre del producto según codigo
            if (Cbo_codigoproducto.Items.Count > 0)
            {
                log.CargarTexto(Txt_nombreproducto, Cbo_codigoproducto.Text);
            }
        }

        private void Cbo_tipolista_KeyPress(object sender, KeyPressEventArgs e)
        {
            //no deja modificar el texto del combobox
            e.Handled = true;
        }

        private void Cbo_codigoproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //no deja modificar el texto del combobox
            e.Handled = true;
        }

        private void Cbo_NombreLista_KeyPress(object sender, KeyPressEventArgs e)
        {
            //no deja modificar el texto del combobox
            e.Handled = true;
        }

        private void Dtp_fechainicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //no deja modificar el texto del combobox
            e.Handled = true;
        }

        private void Dtp_fechamodificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //no deja modificar el texto del combobox
            e.Handled = true;
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_aceptarlista_Click(object sender, EventArgs e)
        {
            //Aparezca el primer submenu
            Gpb_accion.Visible = true;
            Gpb_accion.Enabled = true;
            Btn_ModificarLista.Visible = true;
            Btn_ModificarLista.Enabled = true;
            Gpb_producto.Visible = false;
            Gpb_accion2.Visible = false;
            Gpb_costolista.Visible = false;
            Gpb_lista.Visible = false;
            Txt_nombreproducto.Text = "";
            Txt_descuento.Text = "";
            Dtp_fechainicio.ResetText();
            TxtTipoLista2.Visible = false;
            Txt_FechaInicio2.Enabled = false;
            TxtTipoLista2.Enabled = false;
            Txt_FechaInicio2.Visible = false;
            Dtp_fechamodificacion.ResetText();
            Cbo_NombreLista.Items.Clear();
            Txt_NombreLista.Text = "";
            Txt_NombreLista.Clear();
            Txt_descuento.Clear();
            Txt_FechaInicio.Clear();
            TxtTipoLista2.Clear();
            Txt_FechaInicio2.Clear();
            Txt_nombreproducto.Clear();

            Txt_TipoLista.Clear();

            Cbo_codigoproducto.Items.Clear();
            Cbo_NombreLista.Items.Clear();
            Cbo_tipolista.Items.Clear();
            Btn_CrearLista.Enabled = true;
            Btn_CrearLista.Visible = true;
            Txt_id.Clear();
            Txt_id2.Clear();
            Txt_precio.Clear();
            MessageBox.Show("Lista Creada Con Exito");
        }

        private void Btn_guardar2_Click(object sender, EventArgs e)
        {
            //Aparezca el primer submenu
            Gpb_accion.Visible = true;
            Gpb_accion.Enabled = true;
            Btn_ModificarLista.Visible = true;
            Btn_ModificarLista.Enabled = true;
            Gpb_producto.Visible = false;
            Gpb_accion2.Visible = false;
            Gpb_costolista.Visible = false;
            Gpb_lista.Visible = false;
            Txt_nombreproducto.Text = "";
            Txt_descuento.Text = "";
            Dtp_fechainicio.ResetText();
            TxtTipoLista2.Visible = false;
            Txt_FechaInicio2.Enabled = false;
            TxtTipoLista2.Enabled = false;
            Txt_FechaInicio2.Visible = false;
            Dtp_fechamodificacion.ResetText();
            Cbo_NombreLista.Items.Clear();
            Txt_NombreLista.Text = "";
            Txt_NombreLista.Clear();
            Txt_descuento.Clear();
            Txt_FechaInicio.Clear();
            TxtTipoLista2.Clear();
            Txt_FechaInicio2.Clear();
            Txt_nombreproducto.Clear();

            Txt_TipoLista.Clear();

            Cbo_codigoproducto.Items.Clear();
            Cbo_NombreLista.Items.Clear();
            Cbo_tipolista.Items.Clear();
            Btn_CrearLista.Enabled = true;
            Btn_CrearLista.Visible = true;
            Txt_id.Clear();
            Txt_id2.Clear();
            Txt_precio.Clear();

        }

        private void Dtp_fechamodificacion_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void Btn_agregarproducto_Click(object sender, EventArgs e)
        {
            if (Cbo_tipolista.Text == "" | Dtp_fechainicio.Checked == false | Txt_NombreLista.Text == "")
            {
                MessageBox.Show("Existen Campos Vacíos");
            }
            else
            {
                MessageBox.Show("Lista Creada con Exito");
                Txt_NombreLista.Enabled = false;
                Cbo_tipolista.Enabled = false;
                Dtp_fechainicio.Enabled = false;
                Btn_agregarproducto.Enabled = false;
            }
        }

        private void Btn_crear_Click(object sender, EventArgs e)
        {
            if (Cbo_tipolista.Text == "" | Dtp_fechainicio.Checked == false | Txt_NombreLista.Text == "")
            {
                MessageBox.Show("Existen Campos Vacíos");
            }
            else
            {
                //guardar datos al encabezado de la lista de precios
                fecha_inicio = Dtp_fechainicio.Text;
                fecha_inicio = Dtp_fechainicio.Value.Date.ToString("yyyy/MM/dd");
                log.insertarencabezado1(fecha_inicio);
                MessageBox.Show("Se ha Creado con exito");
                //busca id de encabezado
                log.BuscarId(Txt_id, fecha_inicio);
                //buscar id de tipo de lista
                string tipolista_1 = Cbo_tipolista.Text;
                log.BuscarIdTipoLista(Txt_id2, tipolista_1);
                //crear lista detalle con nombre
                string nombrelista = Txt_NombreLista.Text;
                string txt1 = Txt_id.Text;
                string txt2 = Txt_id2.Text;
                string codigoproducto = Cbo_codigoproducto.Text;
                string precio = Txt_precio.Text;
                log.InsertarDetalle1(nombrelista, txt1, txt2,codigoproducto,precio);
                //Data
                
                DataTable dtDatosDiseno = log.consultaId();
                Dgv_producto.DataSource = dtDatosDiseno;
            }

        }

        private void Lbl_precio_Click(object sender, EventArgs e)
        {

        }

        private void Dgv_producto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
