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
        List<int> listaClientes = new List<int>();
        string serie = null;
        string correlativo = null;


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
            logicaConsulta.obtenerFacturaE(listaserie.ElementAt(Cbo_serie.SelectedIndex).ToString(), Dgv_facturas, listaClientes);
        }

        private void Dgv_facturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv_facturas.Rows.Count - 1 > 0)
            {
                try
                {
                    int seleccionado = e.RowIndex;
                    double subtotal = 0;
                    string[] separados;
                    separados = Dgv_facturas.Rows[seleccionado].Cells[0].Value.ToString().Split('-');
                    serie = separados[0];
                    correlativo = separados[1];

                    subtotal = Double.Parse(Dgv_facturas.Rows[seleccionado].Cells[6].Value.ToString()) - Double.Parse(Dgv_facturas.Rows[seleccionado].Cells[5].Value.ToString());

                    Txt_correlativo.Text = listaClientes.ElementAt(seleccionado).ToString();
                    logicaConsulta.consultarCliente(listaClientes.ElementAt(seleccionado).ToString(), Txt_nombres, Txt_apellidos, Txt_nit, false);

                    Txt_impuesto.Text = Dgv_facturas.Rows[seleccionado].Cells[5].Value.ToString();
                    Txt_total.Text = Dgv_facturas.Rows[seleccionado].Cells[6].Value.ToString();
                    Txt_subtotal.Text = subtotal.ToString();
                    Txt_fecha.Text = Dgv_facturas.Rows[seleccionado].Cells[1].Value.ToString();
                    logicaConsulta.obtenerNumeroFacturaD(correlativo, serie, Txt_registros);
                }
                catch
                {
                    MessageBox.Show("Error Desconocido!", "Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
