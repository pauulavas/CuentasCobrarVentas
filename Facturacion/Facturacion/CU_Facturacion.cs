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
        bool encontradoPed = false;
        string iddFactura;
        string iddPedido = "NULL";
        string iddCotizacion = "NULL";
        double subtotal = 0;
        int cantidad = 0;
        public CU_Facturacion()
        {
            InitializeComponent();
            logicaConsulta = new LogicaConsulta();
        }

        private void CU_Facturacion_Load(object sender, EventArgs e)
        {
            Cbo_documento.SelectedIndex = 0;
            logicaConsulta.obtenerSerie(Cbo_serie,listaserie);
            logicaConsulta.obtenerImpuesto(Cbo_impuestos);
            logicaConsulta.obtenerMoneda(Cbo_moneda);
            if (Cbo_serie.Items.Count > 0)
            {
                Cbo_serie.SelectedIndex = 0;
            }
            if (Cbo_impuestos.Items.Count > 0)
            {
                Cbo_impuestos.SelectedIndex = 0;
            }
            if (Cbo_moneda.Items.Count > 0)
            {
                Cbo_moneda.SelectedIndex = 0;
            }
            logicaConsulta.obtenerIdFactura(Txt_correlativo, listaserie.ElementAt(Cbo_serie.SelectedIndex).ToString(), iddFactura);
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
            logicaConsulta.obtenerIdFactura(Txt_correlativo, listaserie.ElementAt(Cbo_serie.SelectedIndex).ToString(), iddFactura);
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
            double subTotal = 0;
            subTotal = Double.Parse(Txt_precioProducto.Text) * Double.Parse(Nup_cantidad.Value.ToString());
            Txt_subtotal.Text = String.Format("{0:0.00}", subTotal);
        }

        private void Dgv_factura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionado = 0;
            seleccionado = e.RowIndex;
        }

        private void Btn_addGrid_Click(object sender, EventArgs e)
        {
            subtotal = 0;
            double total = 0;
            cantidad = 0;

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
            subtotal = 0;
            cantidad = 0;

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

                    Txt_pedido.Text = null;
                    Txt_fechaPed.Text = null;
                    if (encontradoCot == true)
                    {
                        iddCotizacion = Txt_codigoDoc.Text;
                        bcliente = true;
                        logicaConsulta.obtenerCotizacionE(Txt_codigoDoc.Text, Txt_codigo, Txt_fechaCot);
                        logicaConsulta.consultarCliente(Txt_codigo.Text, Txt_nombres, Txt_apellidos, Txt_nit);
                        logicaConsulta.obtenerCotizacionD(Txt_codigoDoc.Text, Dgv_factura);

                        subtotal = 0;
                        cantidad = 0;

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
                    encontradoPed = logicaConsulta.comprobarPedido(Txt_codigoDoc.Text, Txt_pedido);
                    if (encontradoPed == true)
                    {
                        iddPedido = Txt_codigoDoc.Text;
                        bcliente = true;
                        logicaConsulta.obtenerPedidoE(Txt_codigoDoc.Text, Txt_codigo, Txt_fechaCot, Txt_cotizacion, Txt_fechaPed);
                        iddCotizacion = Txt_cotizacion.Text;
                        logicaConsulta.consultarCliente(Txt_codigo.Text, Txt_nombres, Txt_apellidos, Txt_nit);
                        logicaConsulta.obtenerPedidoD(Txt_codigoDoc.Text, Dgv_factura);

                        subtotal = 0;
                        cantidad = 0;

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

        private void Btn_vender_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_factura.Rows.Count - 1 > 0 && bcliente == true)
                {
                    string[] separados;
                    separados = Txt_correlativo.Text.Split('-');
                    DateTime dataTime = DateTime.Now;
                    int iimpuesto = Cbo_serie.SelectedIndex + 1;
                    int imoneda = Cbo_moneda.SelectedIndex + 1;
                    logicaConsulta.agregarFacturaE(separados[1],
                        Txt_codigo.Text,
                        iddCotizacion,
                        iddPedido,
                        "NULL",
                        dataTime,
                        "Factura" + Cbo_serie.SelectedItem.ToString(),
                        listaserie.ElementAt(Cbo_serie.SelectedIndex).ToString(),
                        iimpuesto.ToString(),
                        imoneda.ToString(),
                        "NULL",
                        Txt_iva.Text,
                        subtotal.ToString()
                    );


                    for (int i = 0; i < Dgv_factura.Rows.Count - 1; i++)
                    {
                        logicaConsulta.agregarFacturaD(
                            Dgv_factura.Rows[i].Cells[0].Value.ToString(),
                            separados[1],
                            Dgv_factura.Rows[i].Cells[1].Value.ToString(),
                            Dgv_factura.Rows[i].Cells[4].Value.ToString(),
                            listaserie.ElementAt(Cbo_serie.SelectedIndex).ToString()
                        );
                    }
                    MessageBox.Show("Factura Registrada Correctamente!", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    iddPedido = "";
                    iddCotizacion = "";
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
            }
            catch
            {
                MessageBox.Show("Fallo al Registrar Factura!", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
//Diego Torres