using CapaDatos_Facturacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLogica_Facturacion
{
    public class LogicaConsulta
    {
        public bool consultarCliente(string sidCliente, TextBox nombre, TextBox apellido, TextBox nit, bool mensaje)
        {
            bool encontrado = false;
            Sentencias sentencias = new Sentencias();
            OdbcDataAdapter datos = sentencias.consultarClientes(sidCliente);
            DataTable dtDatos = new DataTable();
            datos.Fill(dtDatos);
            if (dtDatos.Rows.Count > 0)
            {
                for (int i = 0; i < dtDatos.Rows.Count; i++)
                {
                    DataRow row = dtDatos.Rows[i];
                    nombre.Text = row["nombres_cliente"].ToString();
                    apellido.Text = row["apellidos_cliente"].ToString();
                    nit.Text = row["nit_cliente"].ToString();
                }
                if (mensaje)
                {
                    MessageBox.Show("Cliente Encontrado!", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                encontrado = true;
            }
            else
            {
                MessageBox.Show("Cliente Inexistente!", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                encontrado = false;
            }
            return encontrado;
        }

        public void cargarClientes(ComboBox comboBox, List<int> idCliente)
        {
            Sentencias sentencias = new Sentencias();
            OdbcDataAdapter datos = sentencias.obtenerClientes();
            DataTable dtDatos = new DataTable();
            datos.Fill(dtDatos);
            if (dtDatos.Rows.Count > 0)
            {
                for (int i = 0; i < dtDatos.Rows.Count; i++)
                {
                    DataRow row = dtDatos.Rows[i];
                    comboBox.Items.Add(row["nombre"].ToString());
                    idCliente.Add(Int32.Parse(row["KidCliente"].ToString()));
                }
            }
            else
            {
                MessageBox.Show("Error al Obtener Clientes!", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarProductos(ComboBox comboBox, List<int> idProductos)
        {
            Sentencias sentencias = new Sentencias();
            OdbcDataAdapter datos = sentencias.cargarProductos();
            DataTable dtDatos = new DataTable();
            datos.Fill(dtDatos);
            if (dtDatos.Rows.Count > 0)
            {
                for (int i = 0; i < dtDatos.Rows.Count; i++)
                {
                    DataRow row = dtDatos.Rows[i];
                    comboBox.Items.Add(row["productos"].ToString());
                    idProductos.Add(Int32.Parse(row["KidProducto"].ToString()));
                }
            }
            else
            {
                MessageBox.Show("Error al Obtener Clientes!", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void obtenerSerie(ComboBox comboBox, List<int> idSerie)
        {
            Sentencias sentencias = new Sentencias();
            OdbcDataAdapter datos = sentencias.cargarSeries();
            DataTable dtDatos = new DataTable();
            datos.Fill(dtDatos);
            if (dtDatos.Rows.Count > 0)
            {
                for (int i = 0; i < dtDatos.Rows.Count; i++)
                {
                    DataRow row = dtDatos.Rows[i];
                    comboBox.Items.Add(row["serie_serie"].ToString());
                    idSerie.Add(Int32.Parse(row["KidSerie"].ToString()));
                }
            }
            else
            {
                MessageBox.Show("NO HAY SERIES!", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void obtenerMoneda(ComboBox comboBox)
        {
            Sentencias sentencias = new Sentencias();
            OdbcDataAdapter datos = sentencias.cargarMonedas();
            DataTable dtDatos = new DataTable();
            datos.Fill(dtDatos);
            comboBox.Items.Add("Q");

            if (dtDatos.Rows.Count > 0)
            {
                for (int i = 0; i < dtDatos.Rows.Count; i++)
                {
                    DataRow row = dtDatos.Rows[i];
                    comboBox.Items.Add(row["nombre_moneda"].ToString());
                }
            }
            else
            {
                MessageBox.Show("NO HAY MONEDAS!", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void obtenerImpuesto(ComboBox comboBox)
        {
            Sentencias sentencias = new Sentencias();
            OdbcDataAdapter datos = sentencias.cargarImpuestos();
            DataTable dtDatos = new DataTable();
            datos.Fill(dtDatos);
            comboBox.Items.Add("Sin Impuesto");

            if (dtDatos.Rows.Count > 0)
            {
                for (int i = 0; i < dtDatos.Rows.Count; i++)
                {
                    DataRow row = dtDatos.Rows[i];
                    comboBox.Items.Add(row["nombre_impuesto"].ToString());
                }
            }
            else
            {
                MessageBox.Show("NO HAY IMPUESTOS!", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void obtenerIdFactura(TextBox correlativo, string idserie, string idd)
        {
            Sentencias sentencias = new Sentencias();
            OdbcDataAdapter datos = sentencias.obtenerIdFactura(idserie);
            DataTable dtDatos = new DataTable();
            datos.Fill(dtDatos);
            if (dtDatos.Rows.Count > 0)
            {
                for (int i = 0; i < dtDatos.Rows.Count; i++)
                {
                    DataRow row = dtDatos.Rows[i];
                    idd = row["id"].ToString();
                    correlativo.Text = idserie + "-" + idd;
                }
            }
            else
            {
                MessageBox.Show("Error al Obtener Id Factura", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void obtenerIdCotizacion(TextBox correlativo)
        {
            Sentencias sentencias = new Sentencias();
            OdbcDataAdapter datos = sentencias.obtenerIdCotizacion();
            DataTable dtDatos = new DataTable();
            datos.Fill(dtDatos);
            if (dtDatos.Rows.Count > 0)
            {
                for (int i = 0; i < dtDatos.Rows.Count; i++)
                {
                    DataRow row = dtDatos.Rows[i];
                    correlativo.Text = row["id"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Error al Obtener Id Cotizacion", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void obtenerIdPedido(TextBox correlativo)
        {
            Sentencias sentencias = new Sentencias();
            OdbcDataAdapter datos = sentencias.obtenerIdPedido();
            DataTable dtDatos = new DataTable();
            datos.Fill(dtDatos);
            if (dtDatos.Rows.Count > 0)
            {
                for (int i = 0; i < dtDatos.Rows.Count; i++)
                {
                    DataRow row = dtDatos.Rows[i];
                    correlativo.Text = row["id"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Error al Obtener Id Pedido", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool obtenerProducto(string sIdProducto, TextBox nombre, TextBox descripcion)
        {
            bool encontrado = false;
            Sentencias sentencias = new Sentencias();
            OdbcDataAdapter datos = sentencias.obtenerProducto(sIdProducto);
            DataTable dtDatos = new DataTable();
            datos.Fill(dtDatos);
            if (dtDatos.Rows.Count > 0)
            {
                for (int i = 0; i < dtDatos.Rows.Count; i++)
                {
                    DataRow row = dtDatos.Rows[i];
                    nombre.Text = row["nombre_producto"].ToString();
                    descripcion.Text = row["descripcion_producto"].ToString();
                }
                encontrado = true;            }
            else
            {
                MessageBox.Show("Error al Obtener Producto", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                encontrado = false;
            }
            return encontrado;
        }

        public void agregarCotizacionE(string id, string idCliente, DateTime fechaI, DateTime fechaF)
        {
            Sentencias sentencias = new Sentencias();
            OdbcCommand command = sentencias.insertarCotizacionE(id, idCliente, fechaI, fechaF);
            command.ExecuteNonQuery();
        }

        public void agregarCotizacionD(string idProducto, string idCotizacion, string cantidad, string monto)
        {
            Sentencias sentencias = new Sentencias();
            OdbcCommand command = sentencias.insertarCotizacionD(idProducto, idCotizacion, cantidad, monto);
            command.ExecuteNonQuery();
        }

        public bool comprobarCotizacion(string idCotizacion, TextBox cotizacion)
        {
            bool encontrado = false;
            Sentencias sentencias = new Sentencias();
            OdbcDataAdapter datos = sentencias.comprobarCotizacion(idCotizacion);
            DataTable dtDatos = new DataTable();
            datos.Fill(dtDatos);

            int contador = 0;

            if (dtDatos.Rows.Count > 0)
            {
                DataRow row;
                for (int i = 0; i < dtDatos.Rows.Count; i++)
                {
                    row = dtDatos.Rows[i];
                    contador = Int32.Parse(row["id"].ToString());
                }
                if (contador > 0)
                {
                    cotizacion.Text = "COTIZACION VIGENTE";
                    encontrado = true;
                }
                else
                {
                    cotizacion.Text = "COTIZACION INEXISTENTE";
                    encontrado = false;
                }
            }
            else
            {
                MessageBox.Show("Error al Obtener Id Cotizacion", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                encontrado = false;
            }
            return encontrado;
        }

        public void obtenerCotizacionE(string idCotizacion, TextBox idCliente, TextBox fecha, bool validado)
        {
            Sentencias sentencias = new Sentencias();
            OdbcDataAdapter datos = sentencias.obtenerCotizacionE(idCotizacion);
            DataTable dtDatos = new DataTable();
            datos.Fill(dtDatos);
            if (dtDatos.Rows.Count > 0)
            {
                for (int i = 0; i < dtDatos.Rows.Count; i++)
                {
                    DataRow row = dtDatos.Rows[i];
                    idCliente.Text = row["KidCliente"].ToString();
                    fecha.Text = row["vencimiento_cotizacionEncabezado"].ToString();
                }
            }
            else
            {
                if (validado)
                {
                    MessageBox.Show("No existe una cotizacion!", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void obtenerCotizacionD(string idCotizacion, DataGridView tablaFactura)
        {
            Sentencias sentencias = new Sentencias();
            OdbcDataAdapter datos = sentencias.obtenerCotizacionD(idCotizacion);
            DataTable dtDatos = new DataTable();
            datos.Fill(dtDatos);
            if (dtDatos.Rows.Count > 0)
            {
                tablaFactura.Rows.Clear();
                for (int i = 0; i < dtDatos.Rows.Count; i++)
                {
                    DataRow row = dtDatos.Rows[i];
                    tablaFactura.Rows.Add(
                        row["KidProducto"].ToString(),
                        row["cantidad_cotizacionDetalle"].ToString(),
                        row["descripcion"].ToString(),
                        row["precio"].ToString(),
                        row["monto_cotizacionDetalle"].ToString(),
                        "-"
                        );
                }
            }
            else
            {
                MessageBox.Show("Error al Obtener el Encabezado de Cotizacion", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void agregarPedidoE(string id, string idCotizacion, string idCliente, DateTime fechaI, DateTime fechaF)
        {
            Sentencias sentencias = new Sentencias();
            OdbcCommand command = sentencias.insertarPedidoE(id, idCliente, idCotizacion, fechaI, fechaF);
            command.ExecuteNonQuery();
        }

        public void agregarPedidoD(string idProducto, string idPedido, string cantidad, string monto)
        {
            Sentencias sentencias = new Sentencias();
            OdbcCommand command = sentencias.insertarPedidoD(idProducto, idPedido, cantidad, monto);
            command.ExecuteNonQuery();
        }

        public bool comprobarPedido(string idPedido, TextBox pedido)
        {
            bool encontrado = false;
            Sentencias sentencias = new Sentencias();
            OdbcDataAdapter datos = sentencias.comprobarPedido(idPedido);
            DataTable dtDatos = new DataTable();
            datos.Fill(dtDatos);

            int contador = 0;

            if (dtDatos.Rows.Count > 0)
            {
                DataRow row;
                for (int i = 0; i < dtDatos.Rows.Count; i++)
                {
                    row = dtDatos.Rows[i];
                    contador = Int32.Parse(row["id"].ToString());
                }
                if (contador > 0)
                {
                    pedido.Text = "PEDIDO VIGENTE";
                    encontrado = true;
                }
                else
                {
                    pedido.Text = "PEDIDO INEXISTENTE";
                    encontrado = false;
                }
            }
            else
            {
                MessageBox.Show("Error al Obtener Id Cotizacion", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                encontrado = false;
            }
            return encontrado;
        }

        public void obtenerPedidoE(string idCotizacion, TextBox idCliente, TextBox fechaC, TextBox cotizacion, TextBox fechaP)
        {
            Sentencias sentencias = new Sentencias();
            OdbcDataAdapter datos = sentencias.obtenerPedidoE(idCotizacion);
            DataTable dtDatos = new DataTable();
            datos.Fill(dtDatos);
            string cot;
            TextBox aux = new TextBox();
            if (dtDatos.Rows.Count > 0)
            {
                for (int i = 0; i < dtDatos.Rows.Count; i++)
                {
                    DataRow row = dtDatos.Rows[i];
                    idCliente.Text = row["KidCliente"].ToString();
                    fechaP.Text = row["vencimiento_encabezadopedido"].ToString();
                    cot = row["KidCotizacionEncabezado"].ToString();

                    if (String.IsNullOrEmpty(cot))
                    {
                        cotizacion.Text = "-";
                    }
                    else
                    {
                        cotizacion.Text = cot;
                        obtenerCotizacionE(idCotizacion, aux, fechaC, false);
                    }
                }
            }
            else
            {
                MessageBox.Show("No existe el pedido", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void obtenerPedidoD(string idCotizacion, DataGridView tablaFactura)
        {
            Sentencias sentencias = new Sentencias();
            OdbcDataAdapter datos = sentencias.obtenerPedidoD(idCotizacion);
            DataTable dtDatos = new DataTable();
            datos.Fill(dtDatos);
            if (dtDatos.Rows.Count > 0)
            {
                tablaFactura.Rows.Clear();
                for (int i = 0; i < dtDatos.Rows.Count; i++)
                {
                    DataRow row = dtDatos.Rows[i];
                    tablaFactura.Rows.Add(
                        row["KidProducto"].ToString(),
                        row["cantidad_Detallepedido"].ToString(),
                        row["descripcion"].ToString(),
                        row["precio"].ToString(),
                        row["monto_Detallepedido"].ToString(),
                        "-"
                        );
                }
            }
            else
            {
                MessageBox.Show("Error al Obtener Pedido", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void agregarFacturaE(string id, string idCliente, string idCotizacion, string idPedido, string idLista, DateTime fecha, string desc, string idSerie, string idImpuesto, string idMoneda, string idDescuentos, string impuesto, string total)
        {
            Sentencias sentencias = new Sentencias();
            OdbcCommand command = sentencias.insertarFacturaE(id,
                idCliente, idCotizacion, idPedido, idLista,
                fecha, desc, idSerie, idImpuesto, idMoneda,
                idDescuentos, impuesto, total);
            command.ExecuteNonQuery();
        }

        public void agregarFacturaD(string idProducto, string idFactura, string cantidad, string monto, string idSerie)
        {
            Sentencias sentencias = new Sentencias();
            OdbcCommand command = sentencias.insertarFacturaD(idProducto, idFactura, cantidad, monto, idSerie);
            command.ExecuteNonQuery();
        }
        public void obtenerFacturaE(string idSerie, DataGridView tablaFactura, List<int> listaClientes)
        {
            Sentencias sentencias = new Sentencias();
            OdbcDataAdapter datos = sentencias.obtenerFacturaE(idSerie);
            DataTable dtDatos = new DataTable();
            datos.Fill(dtDatos);
            tablaFactura.Rows.Clear();
            if (dtDatos.Rows.Count > 0)
            {
                for (int i = 0; i < dtDatos.Rows.Count; i++)
                {
                    DataRow row = dtDatos.Rows[i];
                    tablaFactura.Rows.Add(
                         row["idFactura"].ToString(),
                         row["fecha_facturaencabezado"].ToString(),
                         row["descripcion_facturaencabezado"].ToString(),
                         row["moneda"].ToString(),
                         row["tipo_impuesto"].ToString(),
                         row["impuesto"].ToString(),
                         row["monto"].ToString()
                    );
                    listaClientes.Add(Int32.Parse(row["KidCliente"].ToString()));
                }
            }
            else
            {
                MessageBox.Show("No Se Encontraron Coincidencias", "Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void obtenerNumeroFacturaD(string idFactura, string idSerie, TextBox contador)
        {
            Sentencias sentencias = new Sentencias();
            OdbcDataAdapter datos = sentencias.obtenerNumeroFacturaD(idFactura, idSerie);
            DataTable dtDatos = new DataTable();
            datos.Fill(dtDatos);
            if (dtDatos.Rows.Count > 0)
            {
                for (int i = 0; i < dtDatos.Rows.Count; i++)
                {
                    DataRow row = dtDatos.Rows[i];
                    contador.Text = row["conteo"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Error al Obtener el Encabezado de Cotizacion", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void agregarDevolucion(string idFactura, string idSerie, string descripcion)
        {
            Sentencias sentencias = new Sentencias();
            OdbcCommand command = sentencias.insertarDevulucion(idFactura, idSerie, descripcion);
            command.ExecuteNonQuery();
        }

        public int comprobarDevolucion(string idFactura, string idSerie, int contador)
        {
            Sentencias sentencias = new Sentencias();
            OdbcDataAdapter datos = sentencias.comprobarDevolucion(idFactura, idSerie);
            DataTable dtDatos = new DataTable();
            datos.Fill(dtDatos);
            if (dtDatos.Rows.Count > 0)
            {
                for (int i = 0; i < dtDatos.Rows.Count; i++)
                {
                    DataRow row = dtDatos.Rows[i];
                    contador = Int32.Parse(row["conteo"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Error al Obtener Devolucion!", "Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return contador;
        }

        public void obtenerDevoluciones(DataGridView tablaDevoluciones, bool validado)
        {
            Sentencias sentencias = new Sentencias();
            OdbcDataAdapter datos = sentencias.obtenerDevoluciones();
            DataTable dtDatos = new DataTable();
            datos.Fill(dtDatos);
            tablaDevoluciones.Rows.Clear();
            if (dtDatos.Rows.Count > 0)
            {
                for (int i = 0; i < dtDatos.Rows.Count; i++)
                {
                    DataRow row = dtDatos.Rows[i];
                    tablaDevoluciones.Rows.Add(
                        row["kidDevoluciones"].ToString(),
                        row["motivo_devoluciones"].ToString(),
                        row["fecha_devoluciones"].ToString(),
                        row["idFactura"].ToString()
                        );
                }
            }
            else
            {
                if (validado)
                {
                    MessageBox.Show("No hay Devoluciones!", "Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void obtenerDatosFactura(string idFactura, string idSerie, TextBox correlativo, TextBox impuesto, TextBox total, TextBox fecha)
        {
            Sentencias sentencias = new Sentencias();
            OdbcDataAdapter datos = sentencias.obtenerDatosFactura(idFactura, idSerie);
            DataTable dtDatos = new DataTable();
            datos.Fill(dtDatos);
            if (dtDatos.Rows.Count > 0)
            {
                for (int i = 0; i < dtDatos.Rows.Count; i++)
                {
                    DataRow row = dtDatos.Rows[i];
                    correlativo.Text = row["KidCliente"].ToString();
                    impuesto.Text = row["impuesto"].ToString();
                    total.Text = row["monto"].ToString();
                    fecha.Text = row["fecha_facturaencabezado"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Error al Obtener Factura!", "Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void validarDevolucion(string correlativo)
        {
            Sentencias sentencias = new Sentencias();
            OdbcCommand command = sentencias.validarSolicitud(correlativo);
            command.ExecuteNonQuery();
        }

        public void anularFactura(string idFactura, string idSerie)
        {
            Sentencias sentencias = new Sentencias();
            OdbcCommand command = sentencias.anularFactura(idFactura, idSerie);
            command.ExecuteNonQuery();
        }

        public void cargarCotizaciones(ComboBox comboBox, List<int> idCotizacion)
        {
            Sentencias sentencias = new Sentencias();
            OdbcDataAdapter datos = sentencias.cargarCotizaciones();
            DataTable dtDatos = new DataTable();
            datos.Fill(dtDatos);
            if (dtDatos.Rows.Count > 0)
            {
                for (int i = 0; i < dtDatos.Rows.Count; i++)
                {
                    DataRow row = dtDatos.Rows[i];
                    comboBox.Items.Add(row["nombre"].ToString());
                    idCotizacion.Add(Int32.Parse(row["KidCotizacionEncabezado"].ToString()));
                }
            }
            else
            {
                MessageBox.Show("Error al Obtener Cotizaciones!", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarPedidos(ComboBox comboBox, List<int> idPedido)
        {
            Sentencias sentencias = new Sentencias();
            OdbcDataAdapter datos = sentencias.cargarPedidos();
            DataTable dtDatos = new DataTable();
            datos.Fill(dtDatos);
            if (dtDatos.Rows.Count > 0)
            {
                for (int i = 0; i < dtDatos.Rows.Count; i++)
                {
                    DataRow row = dtDatos.Rows[i];
                    comboBox.Items.Add(row["nombre"].ToString());
                    idPedido.Add(Int32.Parse(row["KidEncabezadoPedido"].ToString()));
                }
            }
            else
            {
                MessageBox.Show("Error al Obtener Cotizaciones!", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
