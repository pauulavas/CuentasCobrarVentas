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
namespace MDI_Ventas
{
    public partial class Tipo_Descuentos : Form
    {
        string usuario = "";
        public Tipo_Descuentos(string user)
        {
            InitializeComponent();
            usuario = user;
            string[] alias = { "Codigo", "Codigo Producto","Nombre","porcentaje_descuentos","Fecha Inicio","Fecha Final", "estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(ColorTranslator.FromHtml("#16235A"));
            navegador1.asignarColorFuente(Color.White);
            navegador1.asignarAyuda("106");
            navegador1.asignarTabla("tbl_descuentos");
            navegador1.asignarNombreForm("Tipos Descuentos");
            navegador1.asignarComboConTabla("tbl_producto", "KidProducto", 1);
        }

        private void Tipo_Descuentos_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
