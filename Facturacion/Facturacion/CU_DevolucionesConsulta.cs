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

                    Txt_solicitud.Text = Dgv_solicitudes.Rows[seleccionado].Cells[0].Value.ToString();
                    Txt_factura.Text = Dgv_solicitudes.Rows[seleccionado].Cells[3].Value.ToString();
                    Txt_fechaDev.Text = Dgv_solicitudes.Rows[seleccionado].Cells[2].Value.ToString();
                    Txt_desc.Text = Dgv_solicitudes.Rows[seleccionado].Cells[1].Value.ToString();
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
                logicaConsulta.obtenerDevoluciones(Dgv_solicitudes, true);
            }
            catch
            {
                MessageBox.Show("Error al Cargar Datos!", "Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_aprobar_Click(object sender, EventArgs e)
        {
            try
            {
                logicaConsulta.validarDevolucion(Txt_solicitud.Text);
                logicaConsulta.anularFactura(correlativo, serie);

                Txt_codigo.Text = null;
                Txt_impuesto.Text = null;
                Txt_total.Text = null;
                Txt_fecha.Text = null;
                Txt_subtotal.Text = null;
                Txt_nombres.Text = null;
                Txt_apellidos.Text = null;
                Txt_nit.Text = null;
                Txt_registros.Text = null;

                Txt_solicitud.Text = null;
                Txt_factura.Text = null;
                Txt_fechaDev.Text = null;
                Txt_desc.Text = null;

                logicaConsulta.obtenerDevoluciones(Dgv_solicitudes,false);
                MessageBox.Show("Factura Anulada Correctamente!", "Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error al Validar Solicitud!", "Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void Btn_rechazar_Click(object sender, EventArgs e)
        {
            try
            {
                logicaConsulta.validarDevolucion(Txt_solicitud.Text);

                Txt_codigo.Text = null;
                Txt_impuesto.Text = null;
                Txt_total.Text = null;
                Txt_fecha.Text = null;
                Txt_subtotal.Text = null;
                Txt_nombres.Text = null;
                Txt_apellidos.Text = null;
                Txt_nit.Text = null;
                Txt_registros.Text = null;

                Txt_solicitud.Text = null;
                Txt_factura.Text = null;
                Txt_fechaDev.Text = null;
                Txt_desc.Text = null;

                MessageBox.Show("Solicitud Rechazada Correctamente!", "Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logicaConsulta.obtenerDevoluciones(Dgv_solicitudes, false);
                
            }
            catch
            {
                MessageBox.Show("Error al Rechazar Solicitud!", "Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
