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
        bool bproducto = false;
        bool bcliente = false;
        public CU_Pedido()
        {
            InitializeComponent();
            logicaConsulta = new LogicaConsulta();
        }

        private void CU_Pedido_Load(object sender, EventArgs e)
        {
            logicaConsulta.obtenerIdPedido(Txt_correlativo);
        }

        private void Btn_consultarCot_Click(object sender, EventArgs e)
        {
            logicaConsulta.comprobarCotizacion(Txt_codigoCot.Text, Txt_cotizacion);
        }
    }
}
