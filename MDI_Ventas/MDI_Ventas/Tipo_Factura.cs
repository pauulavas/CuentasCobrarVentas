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
    public partial class Tipo_Factura : Form
    {
        //string usuario = "";
        public Tipo_Factura()
        {
            InitializeComponent();
            //usuario = user;
            string[] alias = { "Codigo", "Nombre",  "estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(ColorTranslator.FromHtml("#16235A"));
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarAyuda("10");
            navegador1.asignarTabla("tbl_tipofactura");
            navegador1.asignarNombreForm("Tipos Facturas");
        }

        private void Tipo_Factura_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario("admin");
            navegador1.botonesYPermisosInicial("admin", aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
