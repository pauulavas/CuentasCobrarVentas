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
    public partial class Comisiones : Form
    {
        //string usuario = "";
        public Comisiones()
        {
            InitializeComponent();
            //usuario = user;
            string[] alias = { "Codigo", "Codigo_Producto", "Fecha", "Descripcion","Monto","estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.White);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarAyuda("1");
            navegador1.asignarTabla("tbl_comisiones");
            navegador1.asignarNombreForm("Tipos Comisiones");
            navegador1.asignarComboConTabla("tbl_producto", "KidProducto", 1);
        }

        private void Comisiones_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario("admin");
            navegador1.botonesYPermisosInicial("admin", aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
