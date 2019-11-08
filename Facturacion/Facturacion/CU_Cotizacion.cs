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
    public partial class CU_Cotizacion : UserControl
    {
        LogicaConsulta logicaConsulta;
        int seleccionado = 0;
        bool bproducto = false;
        bool bcliente = false;
        public CU_Cotizacion()
        {
            InitializeComponent();
            logicaConsulta = new LogicaConsulta();
        }

        private void Btn_consultaCliente_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Txt_codigo.Text))
            {
                bcliente = logicaConsulta.consultarCliente(Txt_codigo.Text, Txt_nombres, Txt_apellidos, Txt_nit);
            }
            else
            {
                MessageBox.Show("Campo Vacio!", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CU_Cotizacion_Load(object sender, EventArgs e)
        {
            logicaConsulta.obtenerIdCotizacion(Txt_correlativo);
        }

        private void Btn_consultarProducto_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Txt_codigoProducto.Text))
            {
                bproducto = logicaConsulta.obtenerProducto(Txt_codigoProducto.Text, Txt_nombreProducto, Txt_descProducto);
            }
            else
            {
                MessageBox.Show("Campo Vacio!", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_addGrid_Click(object sender, EventArgs e)
        {
            double subtotal = 0;
            double total = 0;
            int cantidad = 0;

            subtotal = Double.Parse(Txt_precioProducto.Text) * Double.Parse(Nup_cantidad.Value.ToString());

            Dgv_factura.Rows.Add(
                Txt_codigoProducto.Text,
                Nup_cantidad.Value.ToString(),
                Txt_descProducto.Text,
                Txt_precioProducto.Text,
                String.Format("{0:0.00}", subtotal),
                "-"
                );
            subtotal = 0;

            if (Dgv_factura.Rows.Count - 1 > 0)
            {
                for (int i = 0; i < Dgv_factura.Rows.Count - 1; i++)
                {
                    subtotal += Double.Parse(Dgv_factura.Rows[i].Cells[4].Value.ToString());
                    cantidad += Int32.Parse(Dgv_factura.Rows[i].Cells[1].Value.ToString());
                }
            }

            Txt_subtotalGeneral.Text = "Q. " + String.Format("{0:0.00}", subtotal);
            Txt_total.Text = "Q. " + String.Format("{0:0.00}", subtotal);
            int registros = Dgv_factura.Rows.Count - 1;
            Txt_registros.Text = registros.ToString();
        }

        private void Dgv_factura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionado = e.RowIndex;
        }

        private void Nup_cantidad_ValueChanged(object sender, EventArgs e)
        {
            double subtotal = 0;
            subtotal = Double.Parse(Txt_precioProducto.Text) * Double.Parse(Nup_cantidad.Value.ToString());
            Txt_subtotal.Text = String.Format("{0:0.00}", subtotal);
        }

        private void Btn_remGrid_Click(object sender, EventArgs e)
        {
            double subtotal = 0;
            int cantidad = 0;

            if (Dgv_factura.Rows.Count - 1 > 0)
            {
                Dgv_factura.Rows.RemoveAt(seleccionado);

                for (int i = 0; i < Dgv_factura.Rows.Count - 1; i++)
                {
                    subtotal += Double.Parse(Dgv_factura.Rows[i].Cells[4].Value.ToString());
                    cantidad += Int32.Parse(Dgv_factura.Rows[i].Cells[1].Value.ToString());
                }

                Txt_subtotalGeneral.Text = "Q. " + String.Format("{0:0.00}", subtotal);
                Txt_total.Text = "Q. " + String.Format("{0:0.00}", subtotal);
                int registros = Dgv_factura.Rows.Count - 1;
                Txt_registros.Text = registros.ToString();
            }
            else
            {
                MessageBox.Show("No hay datos en el grid");
            }
        }

        private void Btn_vender_Click(object sender, EventArgs e)
        {
            if (Dgv_factura.Rows.Count - 1 > 0 && bcliente == true)
            {
                logicaConsulta.agregarCotizacionE(Txt_correlativo.Text,
                Txt_codigo.Text,
                Dtp_actual.Value.Date,
                Dtp_final.Value.Date
                );

                for (int i = 0; i < Dgv_factura.Rows.Count - 1; i++)
                {
                    logicaConsulta.agregarCotizacionD(
                        Dgv_factura.Rows[i].Cells[0].Value.ToString(),
                        Txt_correlativo.Text,
                        Dgv_factura.Rows[i].Cells[1].Value.ToString(),
                        Dgv_factura.Rows[i].Cells[4].Value.ToString()
                        );
                }
                MessageBox.Show("Cotizacion Registrada Correctamente!", "Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Txt_codigo.Text = "";
                Txt_nombres.Text = "";
                Txt_apellidos.Text = "";
                Txt_nit.Text = "";
                Txt_codigoProducto.Text = "";
                Txt_nombreProducto.Text = "";
                Txt_descProducto.Text = "";
                Txt_subtotal.Text = "0.00";
                Txt_subtotalGeneral.Text = "Q. 0.00";
                Txt_total.Text = "Q. 0.00";
                Txt_registros.Text = "0";

                bcliente = false;
                bproducto = false;

                Nup_cantidad.Value = 1;
                Dgv_factura.Rows.Clear();
                logicaConsulta.obtenerIdCotizacion(Txt_correlativo);
            }
            else
            {
                MessageBox.Show("Fallo al Registrar Cotizacion!", "Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Dtp_actual.Value.Date.ToShortDateString());
        }
    }
}
