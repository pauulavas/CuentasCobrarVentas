using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_VentasyCtasPorCobrar
{
    public partial class Serie : Form
    {
        //string usuario = "";
        public Serie()
        {
            InitializeComponent();
            //usuario = user;
            string[] alias = { "Codigo", "Codigo Folio", "Serie", "Certificado", "Regimen Fiscal","Formato","estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.White);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarAyuda("1");

            navegador1.asignarTabla("tbl_serie");
            navegador1.asignarNombreForm("Serie");
            navegador1.asignarComboConTabla("tbl_folios", "KidFolio");
        }

        private void Serie_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario("admin");
            navegador1.botonesYPermisosInicial("admin", aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
