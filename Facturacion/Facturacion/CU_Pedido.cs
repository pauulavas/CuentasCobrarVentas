using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica_Facturacion;

namespace Facturacion
{
    public partial class CU_Pedido : UserControl
    {
        LogicaConsulta logicaConsulta;
        int seleccionado = 0;
        bool encontradoCot = false;
        public CU_Pedido()
        {
            InitializeComponent();
            logicaConsulta = new LogicaConsulta();
        }

        private void CU_Pedido_Load(object sender, EventArgs e)
        {
            logicaConsulta.obtenerIdPedido(Txt_correlativo);
            Cbo_opcion.SelectedIndex = 0;
        }

        private void Btn_consultarCot_Click(object sender, EventArgs e)
        {
            encontradoCot = logicaConsulta.comprobarCotizacion(Txt_codigoCot.Text, Txt_cotizacion);

            if (encontradoCot == true)
            {
                logicaConsulta.obtenerCotizacionE(Txt_codigoCot.Text, Txt_codigo, Txt_fecha);
                logicaConsulta.consultarCliente(Txt_codigo.Text, Txt_nombres, Txt_apellidos, Txt_nit);
            }
        }

        private void Btn_consultarCliente_Click(object sender, EventArgs e)
        {
            logicaConsulta.consultarCliente(Txt_codigo.Text, Txt_nombres, Txt_apellidos, Txt_nit);
        }

        private void Cbo_opcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Cbo_opcion.SelectedIndex)
            {
                case 0:
                    Gpb_encabezado.Enabled = true;
                    Txt_codigoCot.Text = "";
                    Txt_cotizacion.Text = "";
                    Txt_fecha.Text = "";
                    Txt_codigoCot.Enabled = false;
                    Btn_consultarCot.Enabled = false;
                    /*Gpb_configuracion.Enabled = true;
                    Gpb_producto.Enabled = true;
                    Gpb_acciones.Enabled = true;*/
                    break;

                case 1:
                    Gpb_encabezado.Enabled = false;
                    Txt_codigoCot.Enabled = true;
                    Btn_consultarCot.Enabled = true;
                    /*Gpb_configuracion.Enabled = false;
                    Gpb_producto.Enabled = false;
                    Gpb_acciones.Enabled = false;*/
                    break;
            }
        }
    }
}
