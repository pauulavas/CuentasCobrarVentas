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
    public partial class Tipo_Pagos : Form
    {
        string usuario = "";
        public Tipo_Pagos(string user)
        {
            InitializeComponent();
            usuario = user;
            string[] alias = { "Codigo", "Nombre", "Descripcion", "estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(ColorTranslator.FromHtml("#16235A"));
            navegador1.asignarColorFuente(Color.White);
            navegador1.asignarAyuda("109");
            navegador1.asignarTabla("tbl_tipopago");
            navegador1.asignarNombreForm("Tipos de Pagos");
        }

        private void Tipo_Pagos_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
