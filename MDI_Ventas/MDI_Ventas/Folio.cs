using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Ventas
{
    public partial class Folio : Form
    {
        //string usuario = "";
        public Folio()
        {
            InitializeComponent();
            //usuario = user;
            string[] alias = { "Codigo", "Fecha", "estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(ColorTranslator.FromHtml("#16235A"));
            navegador1.asignarColorFuente(Color.White);
            navegador1.asignarAyuda("5");
            navegador1.asignarTabla("tbl_folios");
            navegador1.asignarNombreForm("Folio");
            navegador1.asignarComboConTabla("tbl_clientes", "KidCliente", 1);
        }

        private void Folio_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario("admin");
            navegador1.botonesYPermisosInicial("admin", aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
