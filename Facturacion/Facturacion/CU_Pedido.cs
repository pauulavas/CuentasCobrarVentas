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
        List<int> listaCot = new List<int>();
        List<int> listaClientes = new List<int>();
        List<int> listaProductos = new List<int>();
        string iddCotizacion = "NULL";
        public CU_Pedido()
        {
            InitializeComponent();
            logicaConsulta = new LogicaConsulta();
        }

        private void CU_Pedido_Load(object sender, EventArgs e)
        {
            logicaConsulta.obtenerIdPedido(Txt_correlativo);
            logicaConsulta.cargarCotizaciones(Cbo_codCot,listaCot);
            logicaConsulta.cargarClientes(Cbo_cliente,listaClientes);
            logicaConsulta.cargarProductos(Cbo_codProducto, listaProductos);
            Cbo_opcion.SelectedIndex = 0;
            //Cbo_codCot.SelectedIndex = 0;
            Cbo_codProducto.SelectedIndex = 0;
        }

        private void Btn_consultarCot_Click(object sender, EventArgs e)
        {
            /*
            encontradoCot = logicaConsulta.comprobarCotizacion(Txt_codigoCot.Text, Txt_cotizacion);

            if (encontradoCot == true)
            {
                bcliente = true;
                logicaConsulta.obtenerCotizacionE(Txt_codigoCot.Text, Txt_codigo, Txt_fecha);
                logicaConsulta.consultarCliente(Txt_codigo.Text, Txt_nombres, Txt_apellidos, Txt_nit, false);
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
            */
        }

        /*
            encontradoCot = logicaConsulta.comprobarCotizacion(Txt_codigoCot.Text, Txt_cotizacion);

            if (encontradoCot == true)
            {
                bcliente = true;
                logicaConsulta.obtenerCotizacionE(Txt_codigoCot.Text, Txt_codigo, Txt_fecha);
                logicaConsulta.consultarCliente(Txt_codigo.Text, Txt_nombres, Txt_apellidos, Txt_nit, false);
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
            */

        private void Btn_consultarCliente_Click(object sender, EventArgs e)
        {
            /*
            if (!String.IsNullOrEmpty(Txt_codigo.Text))
            {
                bcliente = logicaConsulta.consultarCliente(Txt_codigo.Text, Txt_nombres, Txt_apellidos, Txt_nit, true);
            }
            else
            {
                MessageBox.Show("Campo Vacio!", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }

        private void Cbo_opcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (Cbo_opcion.SelectedIndex)
            {
                case 0:
                    Gpb_encabezado.Enabled = true;
                    Cbo_codCot.Enabled = false;
                    Txt_cotizacion.Text = "";
                    Txt_fecha.Text = "";
                    iddCotizacion = "NULL";
                    break;

                case 1:
                    Gpb_encabezado.Enabled = false;
                    Cbo_codCot.Enabled = true;
                    break;
            }
        }

        private void Btn_consultarProducto_Click(object sender, EventArgs e)
        {
            /*
            if (!String.IsNullOrEmpty(Txt_codigoProducto.Text))
            {
                bproducto = logicaConsulta.obtenerProducto(Txt_codigoProducto.Text, Txt_nombreProducto, Txt_descProducto);
            }
            else
            {
                MessageBox.Show("Campo Vacio!", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }

        private void Nup_cantidad_ValueChanged(object sender, EventArgs e)
        {
            double subtotal = 0;
            subtotal = Double.Parse(Txt_precioProducto.Text) * Double.Parse(Nup_cantidad.Value.ToString());
            Txt_subtotal.Text = String.Format("{0:0.00}", subtotal);
        }

        private void Txt_addGrid_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Txt_descProducto.Text) && !String.IsNullOrEmpty(Txt_precioProducto.Text))
            {
                double subtotal = 0;
                double total = 0;
                int fila = -1;
                int cantidad;
                int contador = 0;
                int codigoFactura = 0;
                int codigoActual = Int32.Parse(listaProductos.ElementAt(Cbo_codProducto.SelectedIndex).ToString());

                if (Dgv_factura.Rows.Count - 1 > 0)
                {
                    for (int i = 0; i < Dgv_factura.Rows.Count - 1; i++)
                    {
                        codigoFactura = Int32.Parse(Dgv_factura.Rows[i].Cells[0].Value.ToString());
                        if (codigoActual == codigoFactura)
                        {
                            fila = i;
                            contador = 1;
                        }
                    }
                }

                if (contador == 0)
                {
                    subtotal = Double.Parse(Txt_precioProducto.Text) * Double.Parse(Nup_cantidad.Value.ToString());
                    Dgv_factura.Rows.Add(
                        listaProductos.ElementAt(Cbo_codProducto.SelectedIndex).ToString(),
                        Nup_cantidad.Value.ToString(),
                        Txt_descProducto.Text,
                        Txt_precioProducto.Text,
                        String.Format("{0:0.00}", subtotal),
                        "-"
                    );
                }
                else
                {
                    cantidad = Int32.Parse(Dgv_factura.Rows[fila].Cells[1].Value.ToString()) + Int32.Parse(Nup_cantidad.Value.ToString());
                    double subtotal2 = Double.Parse(Txt_precioProducto.Text) * cantidad;
                    Dgv_factura.Rows[fila].Cells[1].Value = cantidad.ToString();
                    Dgv_factura.Rows[fila].Cells[4].Value = String.Format("{0:0.00}", subtotal2);
                }


                if (Dgv_factura.Rows.Count - 1 > 0)
                {
                    for (int i = 0; i < Dgv_factura.Rows.Count - 1; i++)
                    {
                        subtotal += Double.Parse(Dgv_factura.Rows[i].Cells[4].Value.ToString());
                    }
                }

                Txt_subtotalGeneral.Text = "Q. " + String.Format("{0:0.00}", subtotal);
                Txt_total.Text = "Q. " + String.Format("{0:0.00}", subtotal);
                int registros = Dgv_factura.Rows.Count - 1;
                Txt_registros.Text = registros.ToString();
            }
            else
            {
                MessageBox.Show("Hay Campos Vacios!", "Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                cantidad = Int32.Parse(Dgv_factura.Rows[seleccionado].Cells[1].Value.ToString());
                cantidad--;

                if (cantidad < 1)
                {
                    Dgv_factura.Rows.RemoveAt(seleccionado);
                }
                else
                {
                    Dgv_factura.Rows[seleccionado].Cells[1].Value = cantidad;
                    Dgv_factura.Rows[seleccionado].Cells[4].Value = cantidad * Double.Parse(Dgv_factura.Rows[seleccionado].Cells[3].Value.ToString());
                }

                for (int i = 0; i < Dgv_factura.Rows.Count - 1; i++)
                {
                    subtotal += Double.Parse(Dgv_factura.Rows[i].Cells[4].Value.ToString());
                }

                Txt_subtotalGeneral.Text = "Q. " + String.Format("{0:0.00}", subtotal);
                Txt_total.Text = "Q. " + String.Format("{0:0.00}", subtotal);
                int registros = Dgv_factura.Rows.Count - 1;
                Txt_registros.Text = registros.ToString();
            }
            else
            {
                MessageBox.Show("No hay filas en la Tabla!", "Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (Dgv_factura.Rows.Count - 1 > 0 && bcliente == true)
                {
                    logicaConsulta.agregarPedidoE(Txt_correlativo.Text,
                        iddCotizacion,
                        listaClientes.ElementAt(Cbo_cliente.SelectedIndex).ToString(),
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

                    Txt_nombres.Text = "";
                    Txt_apellidos.Text = "";
                    Txt_nit.Text = "";
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
            //}
            //catch
            //{
            //    MessageBox.Show("Fallo al Registrar Pedido!", "Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            
        }

        private void Cbo_codCot_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (Cbo_opcion.SelectedIndex == 1) {
                encontradoCot = logicaConsulta.comprobarCotizacion(listaCot.ElementAt(Cbo_codCot.SelectedIndex).ToString(), Txt_cotizacion);

                if (encontradoCot == true)
                {
                    TextBox textBox = new TextBox();
                    bcliente = true;
                    
                    logicaConsulta.obtenerCotizacionE(listaCot.ElementAt(Cbo_codCot.SelectedIndex).ToString(), textBox, Txt_fecha, true);
                    logicaConsulta.consultarCliente(listaClientes.ElementAt(Int32.Parse(textBox.Text) - 1).ToString(), Txt_nombres, Txt_apellidos, Txt_nit, false);
                    logicaConsulta.obtenerCotizacionD(listaCot.ElementAt(Cbo_codCot.SelectedIndex).ToString(), Dgv_factura);
                    Cbo_cliente.SelectedIndex = Int32.Parse(textBox.Text) - 1;

                    iddCotizacion = listaCot.ElementAt(Cbo_codCot.SelectedIndex).ToString();

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

            if (Cbo_opcion.SelectedIndex == 0)
            {
                iddCotizacion = "NULL";
            }
        }

        private void Cbo_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(listaClientes.ElementAt(Cbo_cliente.SelectedIndex).ToString()))
            {
                bcliente = logicaConsulta.consultarCliente(listaClientes.ElementAt(Cbo_cliente.SelectedIndex).ToString(), Txt_nombres, Txt_apellidos, Txt_nit, true);
            }
            else
            {
                MessageBox.Show("Campo Vacio!", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cbo_codProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(listaProductos.ElementAt(Cbo_codProducto.SelectedIndex).ToString()))
            {
                bcliente = logicaConsulta.obtenerProducto(listaProductos.ElementAt(Cbo_codProducto.SelectedIndex).ToString(), Txt_nombreProducto, Txt_descProducto);
            }
            else
            {
                MessageBox.Show("Campo Vacio!", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GroupBox19_Enter(object sender, EventArgs e)
        {

        }
    }
}
