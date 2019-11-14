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
        List<int> listaClientes = new List<int>();
        List<int> listaProductos = new List<int>();
        public CU_Cotizacion()
        {
            InitializeComponent();
            logicaConsulta = new LogicaConsulta();
        }

        private void CU_Cotizacion_Load(object sender, EventArgs e)
        {
            try
            {
                logicaConsulta.obtenerIdCotizacion(Txt_correlativo);
                logicaConsulta.cargarClientes(Cbo_clientes, listaClientes);
                logicaConsulta.cargarProductos(Cbo_productos, listaProductos);
                Cbo_clientes.SelectedIndex = 0;
                Cbo_productos.SelectedIndex = 0;
                Txt_subtotal.Text = Txt_precioProducto.Text;
            }
            catch
            {
                MessageBox.Show("Error Desconocido!", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                int codigoActual = Int32.Parse(listaProductos.ElementAt(Cbo_productos.SelectedIndex).ToString());

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
                        listaProductos.ElementAt(Cbo_productos.SelectedIndex).ToString(),
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

        private void Btn_vender_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_factura.Rows.Count - 1 > 0 && bcliente == true)
                {
                    logicaConsulta.agregarCotizacionE(Txt_correlativo.Text,
                    listaClientes.ElementAt(Cbo_clientes.SelectedIndex).ToString(),
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
                    logicaConsulta.obtenerIdCotizacion(Txt_correlativo);
                }
            }
            catch
            {
                MessageBox.Show("Fallo al Registrar Cotizacion!", "Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Dtp_actual.Value.Date.ToShortDateString());
        }

        private void Cbo_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(listaClientes.ElementAt(Cbo_clientes.SelectedIndex).ToString()))
            {
                bcliente = logicaConsulta.consultarCliente(listaClientes.ElementAt(Cbo_clientes.SelectedIndex).ToString(), Txt_nombres, Txt_apellidos, Txt_nit, false);
            }
            else
            {
                MessageBox.Show("Campo Vacio!", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cbo_productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(listaProductos.ElementAt(Cbo_productos.SelectedIndex).ToString()))
            {
                bcliente = logicaConsulta.obtenerProducto(listaProductos.ElementAt(Cbo_productos.SelectedIndex).ToString(), Txt_nombreProducto, Txt_descProducto);
            }
            else
            {
                MessageBox.Show("Campo Vacio!", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
