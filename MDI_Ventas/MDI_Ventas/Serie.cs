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
    public partial class Serie : Form
    {
        string usuario = "";
        public Serie(string user)
        {
            InitializeComponent();
            usuario = user;
            string[] alias = { "Codigo", "Codigo Folio","Serie","Certificado","Regimen Fiscal","Formato", "estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(ColorTranslator.FromHtml("#16235A"));
            navegador1.asignarColorFuente(Color.White);
            navegador1.asignarAyuda("6");
            navegador1.asignarTabla("tbl_serie");
            navegador1.asignarNombreForm("Serie Factura");
            navegador1.asignarComboConTabla("tbl_folios", "KidFolio", 1);
        }

        private void Serie_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
