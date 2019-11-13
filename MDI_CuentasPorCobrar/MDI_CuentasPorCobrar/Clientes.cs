using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_CuentasPorCobrar
{
    public partial class Clientes : Form
    {
        string usuario = "";
        public Clientes(string user)
        {
            InitializeComponent();
            usuario = user;
            string[] alias = { "Codigo", "Nombre", "Apellido", "Telefono", "Direccion", "DPI", "NIT", "Nombre Contacto", "Telefono Contacto", "Tipo Cliente", "estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(ColorTranslator.FromHtml("#16235A"));
            navegador1.asignarColorFuente(Color.White);
            navegador1.asignarAyuda("110");
            navegador1.asignarTabla("tbl_clientes");
            navegador1.asignarNombreForm("Clientes");
            navegador1.asignarComboConTabla("tbl_tipocliente", "kidtipocliente", 1);
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
