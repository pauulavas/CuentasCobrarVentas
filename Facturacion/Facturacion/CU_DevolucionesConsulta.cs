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
    public partial class CU_DevolucionesConsulta : UserControl
    {
        LogicaConsulta logicaConsulta;
        string serie = null;
        string correlativo = null;
        public CU_DevolucionesConsulta()
        {
            InitializeComponent();
            logicaConsulta = new LogicaConsulta();
        }

        private void Dgv_solicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv_solicitudes.Rows.Count - 1 > 0)
            {
                try
                {
                    int seleccionado = e.RowIndex;
                    double subtotal = 0;
                    string[] separados;
                    separados = Dgv_solicitudes.Rows[seleccionado].Cells[3].Value.ToString().Split('-');
                    serie = separados[0];
                    correlativo = separados[1];
                    logicaConsulta.obtenerDatosFactura(correlativo, serie, Txt_codigo, Txt_impuesto, Txt_total, Txt_fecha);
                    subtotal = Double.Parse(Txt_total.Text) - Double.Parse(Txt_impuesto.Text);
                    Txt_subtotal.Text = subtotal.ToString();
                    logicaConsulta.consultarCliente(Txt_codigo.Text, Txt_nombres, Txt_apellidos, Txt_nit, false);
                    logicaConsulta.obtenerNumeroFacturaD(correlativo, serie, Txt_registros);
                }
                catch
                {
                    MessageBox.Show("Error Desconocido!", "Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CU_DevolucionesConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                logicaConsulta.obtenerDevoluciones(Dgv_solicitudes);
            }
            catch
            {
                MessageBox.Show("Error al Cargar Datos!", "Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
