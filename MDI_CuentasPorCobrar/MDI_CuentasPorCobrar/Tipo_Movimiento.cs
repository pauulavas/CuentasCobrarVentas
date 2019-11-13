using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//prueba
namespace MDI_CuentasPorCobrar
{
    public partial class Tipo_Movimiento : Form
    {
        
        string usuario = "";
        public Tipo_Movimiento(string user)
        {
            InitializeComponent();
            usuario = user;
            string[] alias = { "Codigo", "Nombre", "Detalle","Naturaleza", "estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(ColorTranslator.FromHtml("#16235A"));
            navegador1.asignarColorFuente(Color.White);
            navegador1.asignarAyuda("112");
            navegador1.asignarTabla("tbl_tipomovimiento");
            navegador1.asignarNombreForm("Tipos Movimientos");
        }

        private void Tipo_Movimiento_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
