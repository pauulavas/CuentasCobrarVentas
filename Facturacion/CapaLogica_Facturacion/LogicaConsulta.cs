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
        public bool consultarCliente(string sidCliente, TextBox nombre, TextBox apellido, TextBox nit)
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
                MessageBox.Show("Cliente Encontrado!", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                encontrado = true;
            }
            else
            {
                MessageBox.Show("Cliente Inexistente!", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                encontrado = false;
            }
            return encontrado;
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
                MessageBox.Show("Cliente Inexistente!", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void obtenerIdFactura(TextBox correlativo, string idserie)
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
                    correlativo.Text = row["id"].ToString() + "-" + idserie;
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
                encontrado = true;
                MessageBox.Show("Producto Encontrado!", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        public void comprobarCotizacion(string idCotizacion, TextBox cotizacion)
        {
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
                }
                else
                {
                    cotizacion.Text = "COTIZACION INEXISTENTE";
                }
            }
            else
            {
                MessageBox.Show("Error al Obtener Id Cotizacion", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
