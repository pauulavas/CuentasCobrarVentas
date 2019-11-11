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
    
        logica_lista_precio capalogica;
        int tipo_lista_precios;
        List<int> lista2 = new List<int>();


        public Lista_Precios()
        {
            InitializeComponent();
        }

        private void Lista_Precios_Load(object sender, EventArgs e)
        {
            Gpb_lista.Enabled = false;
            Gpb_producto.Enabled = false;
            Gpb_costolista.Enabled = false;
            Gpb_accion2.Enabled = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Gpb_lista.Enabled = true;
            Gpb_producto.Enabled = true;
            Gpb_costolista.Enabled = true;
            Gpb_accion2.Enabled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Gpb_lista.Enabled = true;
            Cbo_tipolista.Enabled = false;
            Dtp_fechainicio.Enabled = false;
            Dtp_fechamodificacion.Enabled = false;
        }

        private void Cbo_tipolista_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cbo_tipolista.Items.Clear();
            if (Cbo_tipolista.Items.Count > 0)
            {
               
            }
        }
           
    }
}
