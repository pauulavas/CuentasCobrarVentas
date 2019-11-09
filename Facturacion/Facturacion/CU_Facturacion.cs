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
    public partial class CU_Facturacion : UserControl
    {
        LogicaConsulta logicaConsulta;
        int seleccionado = 0;
        bool bproducto = false;
        bool bcliente = false;
        List<int> listaserie = new List<int>();
        bool encontradoCot = false;
        public CU_Facturacion()
        {
            InitializeComponent();
            logicaConsulta = new LogicaConsulta();
        }

        private void CU_Facturacion_Load(object sender, EventArgs e)
        {
            Cbo_documento.SelectedIndex = 0;
            logicaConsulta.obtenerSerie(Cbo_serie,listaserie);
            if (Cbo_serie.Items.Count > 0)
            {
                Cbo_serie.SelectedIndex = 0;
            }
            logicaConsulta.obtenerIdFactura(Txt_correlativo, listaserie.ElementAt(Cbo_serie.SelectedIndex).ToString());
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

        private void Cbo_serie_SelectedIndexChanged(object sender, EventArgs e)
        {
            logicaConsulta.obtenerIdFactura(Txt_correlativo, listaserie.ElementAt(Cbo_serie.SelectedIndex).ToString());
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

        private void Button8_Click(object sender, EventArgs e)
        {

        }

        private void Dgv_factura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionado = 0;
            seleccionado = e.RowIndex;
        }

        private void Btn_addGrid_Click(object sender, EventArgs e)
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

        private void Btn_consultaDoc_Click(object sender, EventArgs e)
        {
            switch (Cbo_documento.SelectedIndex)
            {
                case 0:
                    break;

                case 1:
                    encontradoCot = logicaConsulta.comprobarCotizacion(Txt_codigoDoc.Text, Txt_cotizacion);

                    if (encontradoCot == true)
                    {
                        bcliente = true;
                        logicaConsulta.obtenerCotizacionE(Txt_codigoDoc.Text, Txt_codigo, Txt_fechaCot);
                        logicaConsulta.consultarCliente(Txt_codigo.Text, Txt_nombres, Txt_apellidos, Txt_nit);
                        logicaConsulta.obtenerCotizacionD(Txt_codigoDoc.Text, Dgv_factura);

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
                            int registros = Dgv_factura.Rows.Count - 1;
                            Txt_registros.Text = registros.ToString();
                        }
                    }
                    break;

                case 2:
                    break;
            }
        }

        private void Cbo_documento_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Cbo_documento.SelectedIndex)
            {
                case 0:
                    Gpb_encabezado.Enabled = true;
                    Txt_codigoDoc.Text = "";
                    Txt_cotizacion.Text = "";
                    Txt_pedido.Text = "";
                    Txt_codigoDoc.Enabled = false;
                    Btn_consultaDoc.Enabled = false;
                    Dgv_factura.Rows.Clear();
                    /*Gpb_configuracion.Enabled = true;
                    Gpb_producto.Enabled = true;
                    Gpb_acciones.Enabled = true;*/
                    break;

                case 1:
                    Gpb_encabezado.Enabled = false;
                    Txt_codigoDoc.Enabled = true;
                    Btn_consultaDoc.Enabled = true;
                    /*Gpb_configuracion.Enabled = false;
                    Gpb_producto.Enabled = false;
                    Gpb_acciones.Enabled = false;*/
                    break;

                case 2:
                    Gpb_encabezado.Enabled = false;
                    Txt_codigoDoc.Enabled = true;
                    Btn_consultaDoc.Enabled = true;
                    /*Gpb_configuracion.Enabled = false;
                    Gpb_producto.Enabled = false;
                    Gpb_acciones.Enabled = false;*/
                    break;
            }
        }
    }
}
