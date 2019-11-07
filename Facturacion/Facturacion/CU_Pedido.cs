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
    public partial class CU_Pedido : UserControl
    {
        LogicaConsulta logicaConsulta;
        int seleccionado = 0;
        bool encontradoCot = false;
        bool bproducto = false;
        bool bcliente = false;
        public CU_Pedido()
        {
            InitializeComponent();
            logicaConsulta = new LogicaConsulta();
        }

        private void CU_Pedido_Load(object sender, EventArgs e)
        {
            logicaConsulta.obtenerIdPedido(Txt_correlativo);
            Cbo_opcion.SelectedIndex = 0;
        }

        private void Btn_consultarCot_Click(object sender, EventArgs e)
        {
            encontradoCot = logicaConsulta.comprobarCotizacion(Txt_codigoCot.Text, Txt_cotizacion);

            if (encontradoCot == true)
            {
                bcliente = true;
                logicaConsulta.obtenerCotizacionE(Txt_codigoCot.Text, Txt_codigo, Txt_fecha);
                logicaConsulta.consultarCliente(Txt_codigo.Text, Txt_nombres, Txt_apellidos, Txt_nit);
                logicaConsulta.obtenerCotizacionD(Txt_codigoCot.Text, Dgv_factura);

                double subtotal = 0;
                int cantidad = 0;

                if (Dgv_factura.Rows.Count - 1 > 0)
                {
                    for (int i = 0; i < Dgv_factura.Rows.Count - 1; i++)
                    {
                        subtotal += Double.Parse(Dgv_factura.Rows[i].Cells[4].Value.ToString());
                        cantidad += Int32.Parse(Dgv_factura.Rows[i].Cells[1].Value.ToString());
                    }

                    Txt_subtotalGeneral.Text = "Q. " + String.Format("{0:0.00}", subtotal);
                    Txt_total.Text = "Q. " + String.Format("{0:0.00}", subtotal);
                    int registros = cantidad;
                    Txt_registros.Text = registros.ToString();
                }
            }
        }

        private void Btn_consultarCliente_Click(object sender, EventArgs e)
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

        private void Cbo_opcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Cbo_opcion.SelectedIndex)
            {
                case 0:
                    Gpb_encabezado.Enabled = true;
                    Txt_codigoCot.Text = "";
                    Txt_cotizacion.Text = "";
                    Txt_fecha.Text = "";
                    Txt_codigoCot.Enabled = false;
                    Btn_consultarCot.Enabled = false;
                    Dgv_factura.Rows.Clear();
                    /*Gpb_configuracion.Enabled = true;
                    Gpb_producto.Enabled = true;
                    Gpb_acciones.Enabled = true;*/
                    break;

                case 1:
                    Gpb_encabezado.Enabled = false;
                    Txt_codigoCot.Enabled = true;
                    Btn_consultarCot.Enabled = true;
                    /*Gpb_configuracion.Enabled = false;
                    Gpb_producto.Enabled = false;
                    Gpb_acciones.Enabled = false;*/
                    break;
            }
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

        private void Nup_cantidad_ValueChanged(object sender, EventArgs e)
        {
            double subtotal = 0;
            subtotal = Double.Parse(Txt_precioProducto.Text) * Double.Parse(Nup_cantidad.Value.ToString());
            Txt_subtotal.Text = String.Format("{0:0.00}", subtotal);
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
            int registros = cantidad;
            Txt_registros.Text = registros.ToString();
        }

        private void Dgv_factura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionado = e.RowIndex;
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
                int registros = cantidad;
                Txt_registros.Text = registros.ToString();
            }
            else
            {
                MessageBox.Show("No hay Datos en la Factura!", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            if (Dgv_factura.Rows.Count - 1 > 0 && bcliente == true)
            {
                logicaConsulta.agregarPedidoE(Txt_correlativo.Text,
                    Txt_codigoCot.Text,
                    Txt_codigo.Text,
                    Dtp_actual.Value.Date,
                    Dtp_final.Value.Date
                );

                for (int i = 0; i < Dgv_factura.Rows.Count - 1; i++)
                {
                    logicaConsulta.agregarPedidoD(
                        Dgv_factura.Rows[i].Cells[0].Value.ToString(),
                        Txt_correlativo.Text,
                        Dgv_factura.Rows[i].Cells[1].Value.ToString(),
                        Dgv_factura.Rows[i].Cells[4].Value.ToString()
                    );
                }
                MessageBox.Show("Pedido Registrado Correctamente!", "Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                logicaConsulta.obtenerIdPedido(Txt_correlativo);
            }
            else
            {
                MessageBox.Show("Fallo al Registrar Pedido!", "Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
