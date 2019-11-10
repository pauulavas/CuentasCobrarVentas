using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica_Facturacion;

namespace Facturacion
{
    public partial class CU_Devoluciones : UserControl
    {
        LogicaConsulta logicaConsulta;
        List<int> listaserie = new List<int>();
        public CU_Devoluciones()
        {
            InitializeComponent();
            logicaConsulta = new LogicaConsulta();
        }

        private void CU_Devoluciones_Load(object sender, EventArgs e)
        {
            try
            {
                logicaConsulta.obtenerSerie(Cbo_serie, listaserie);
                Cbo_serie.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Fallo al Cargar Datos!", "Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_consultarFacturas_Click(object sender, EventArgs e)
        {
            logicaConsulta.obtenerFacturaE(listaserie.ElementAt(Cbo_serie.SelectedIndex).ToString(), Dgv_facturas);
        }
    }
}
