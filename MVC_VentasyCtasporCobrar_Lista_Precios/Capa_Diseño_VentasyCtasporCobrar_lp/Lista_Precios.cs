using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Diseño_VentasyCtasporCobrar_lp
{
    public partial class Lista_Precios : UserControl
    {
        public Lista_Precios()
        {
            InitializeComponent();
        }

        private void Lista_Precios_Load(object sender, EventArgs e)
        {
            Gpb_accion.ForeColor = Color.White;
            
            Gpb_accion.ForeColor = Color.Black;
        }
    }
}
