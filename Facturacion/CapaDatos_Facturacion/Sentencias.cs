using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos_Facturacion
{
    public class Sentencias
    {
        public OdbcDataAdapter consultarClientes(string sidCliente)
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string sConsulta = "SELECT nombres_cliente,apellidos_cliente,nit_cliente FROM tbl_clientes WHERE estado = 1 AND KidCliente = " + sidCliente;
            OdbcDataAdapter data = new OdbcDataAdapter(sConsulta, conexion.Conectar());
            return data;
        }

        public OdbcDataAdapter obtenerClientes()
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string sConsulta = "SELECT KidCliente,CONCAT(KidCliente,' - ',nombres_cliente,' ',apellidos_cliente) AS nombre FROM tbl_clientes WHERE estado = 1";
            OdbcDataAdapter data = new OdbcDataAdapter(sConsulta, conexion.Conectar());
            return data;
        }

        public OdbcDataAdapter cargarProductos()
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string sConsulta = "SELECT KidProducto,CONCAT(KidProducto,' - ',nombre_producto) AS productos FROM tbl_producto WHERE estado = 1";
            OdbcDataAdapter data = new OdbcDataAdapter(sConsulta, conexion.Conectar());
            return data;
        }

        public OdbcDataAdapter cargarSeries()
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string sConsulta = "SELECT KidSerie,serie_serie FROM tbl_serie WHERE estado = 1";
            OdbcDataAdapter data = new OdbcDataAdapter(sConsulta, conexion.Conectar());
            return data;
        }

        public OdbcDataAdapter cargarImpuestos()
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string sConsulta = "SELECT KidImpuesto,nombre_impuesto FROM tbl_impuesto WHERE estado = 1";
            OdbcDataAdapter data = new OdbcDataAdapter(sConsulta, conexion.Conectar());
            return data;
        }

        public OdbcDataAdapter cargarMonedas()
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string sConsulta = "SELECT KidMoneda,nombre_moneda FROM tbl_moneda WHERE estado = 1";
            OdbcDataAdapter data = new OdbcDataAdapter(sConsulta, conexion.Conectar());
            return data;
        }

        public OdbcDataAdapter obtenerIdFactura(string sSerie)
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string sConsulta = "SELECT COUNT(*)+1 AS id FROM tbl_facturaencabezado WHERE KidSerie = " + sSerie;
            OdbcDataAdapter data = new OdbcDataAdapter(sConsulta, conexion.Conectar());
            return data;
        }

        public OdbcDataAdapter obtenerIdCotizacion()
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string sConsulta = "SELECT COUNT(*)+1 AS id FROM tbl_cotizacionencabezado";
            OdbcDataAdapter data = new OdbcDataAdapter(sConsulta, conexion.Conectar());
            return data;
        }

        public OdbcDataAdapter obtenerIdPedido()
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string sConsulta = "SELECT COUNT(*)+1 AS id FROM tbl_encabezadopedido";
            OdbcDataAdapter data = new OdbcDataAdapter(sConsulta, conexion.Conectar());
            return data;
        }

        public OdbcDataAdapter obtenerProducto(string sIdProducto)
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string sConsulta = "SELECT nombre_producto,descripcion_producto FROM tbl_producto WHERE KidProducto = " + sIdProducto;
            OdbcDataAdapter data = new OdbcDataAdapter(sConsulta, conexion.Conectar());
            return data;
        }

        public OdbcCommand insertarCotizacionE(string id, string idCliente, DateTime fechaI, DateTime fechaF)
        {
            Conexion conexion = new Conexion();
            OdbcCommand command = new OdbcCommand();
            command.Connection = conexion.Conectar();

            command.CommandText = "INSERT INTO tbl_cotizacionencabezado " +
             "VALUES (" + id +
             "," + idCliente + ",'" + fechaI.ToString("yyyy-MM-dd") + "','" + fechaF.ToString("yyyy-MM-dd") + "')";
            return command;
        }

        public OdbcCommand insertarCotizacionD(string idProducto, string idCotizacion, string cantidad, string monto)
        {
            Conexion conexion = new Conexion();
            OdbcCommand command = new OdbcCommand();
            command.Connection = conexion.Conectar();
            command.CommandText = "SELECT COUNT(*)+1 AS id FROM tbl_cotizaciondetalle";
            command.Connection = conexion.Conectar();

            OdbcDataAdapter mySqlDataAdapter = new OdbcDataAdapter(command);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            int iConteo = 0;

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                iConteo = Convert.ToInt32(row["id"]);
            }

            command.CommandText = "INSERT INTO tbl_cotizaciondetalle " +
             "VALUES (" + iConteo +
             "," + idProducto + "," + idCotizacion + "," + cantidad + "," + monto + ")";
            return command;
        }

        public OdbcDataAdapter comprobarCotizacion(string idCotizacion)
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string sConsulta = "SELECT COUNT(*) AS id FROM tbl_cotizacionencabezado WHERE KidCotizacionEncabezado = " + idCotizacion;
            OdbcDataAdapter data = new OdbcDataAdapter(sConsulta, conexion.Conectar());
            return data;
        }

        public OdbcDataAdapter obtenerCotizacionE(string idCotizacion)
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string sConsulta = "SELECT KidCliente,vencimiento_cotizacionEncabezado FROM tbl_cotizacionencabezado WHERE KidCotizacionEncabezado = " + idCotizacion;
            OdbcDataAdapter data = new OdbcDataAdapter(sConsulta, conexion.Conectar());
            return data;
        }

        public OdbcDataAdapter obtenerCotizacionD(string idCotizacion)
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string sConsulta = "SELECT KidProducto,(SELECT descripcion_producto FROM tbl_producto WHERE KidProducto = tbl_cotizaciondetalle.KidProducto) AS descripcion,(monto_cotizacionDetalle / cantidad_cotizacionDetalle) AS precio,cantidad_cotizacionDetalle,monto_cotizacionDetalle FROM tbl_cotizaciondetalle WHERE KidCotizacionEncabezado = " + idCotizacion;
            OdbcDataAdapter data = new OdbcDataAdapter(sConsulta, conexion.Conectar());
            return data;
        }

        public OdbcCommand insertarPedidoE(string id, string idCliente, string idCotizacion ,DateTime fechaI, DateTime fechaF)
        {
            Conexion conexion = new Conexion();
            OdbcCommand command = new OdbcCommand();
            command.Connection = conexion.Conectar();

            command.CommandText = "INSERT INTO tbl_encabezadopedido " +
             "VALUES (" + id + "," + idCotizacion +
             "," + idCliente + ",'" + fechaI.ToString("yyyy-MM-dd") + "','" + fechaF.ToString("yyyy-MM-dd") + "')";
            return command;
        }

        public OdbcCommand insertarPedidoD(string idProducto, string idPedido, string cantidad, string monto)
        {
            Conexion conexion = new Conexion();
            OdbcCommand command = new OdbcCommand();
            command.Connection = conexion.Conectar();
            command.CommandText = "SELECT COUNT(*)+1 AS id FROM tbl_detallepedido";
            command.Connection = conexion.Conectar();

            OdbcDataAdapter mySqlDataAdapter = new OdbcDataAdapter(command);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            int iConteo = 0;

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                iConteo = Convert.ToInt32(row["id"]);
            }

            command.CommandText = "INSERT INTO tbl_detallepedido " +
             "VALUES (" + iConteo +
             "," + idPedido + "," + idProducto + "," + cantidad + "," + monto + ")";
            return command;
        }

        public OdbcDataAdapter comprobarPedido(string idCotizacion)
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string sConsulta = "SELECT COUNT(*) AS id FROM tbl_encabezadopedido WHERE KidEncabezadoPedido = " + idCotizacion;
            OdbcDataAdapter data = new OdbcDataAdapter(sConsulta, conexion.Conectar());
            return data;
        }

        public OdbcDataAdapter obtenerPedidoE(string idCotizacion)
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string sConsulta = "SELECT KidCotizacionEncabezado,KidCliente,fecha_encabezadopedido,vencimiento_encabezadopedido FROM tbl_encabezadopedido WHERE KidEncabezadoPedido = " + idCotizacion;
            OdbcDataAdapter data = new OdbcDataAdapter(sConsulta, conexion.Conectar());
            return data;
        }

        public OdbcDataAdapter obtenerPedidoD(string idPedido)
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string sConsulta = "SELECT KidProducto,(SELECT descripcion_producto FROM tbl_producto WHERE KidProducto = tbl_detallepedido.KidProducto) AS descripcion,(monto_Detallepedido / cantidad_Detallepedido) AS precio,cantidad_Detallepedido,monto_Detallepedido FROM tbl_detallepedido WHERE KidEncabezadoPedido = " + idPedido;
            OdbcDataAdapter data = new OdbcDataAdapter(sConsulta, conexion.Conectar());
            return data;
        }

        public OdbcCommand insertarFacturaE(string id, string idCliente, string idCotizacion,string idPedido, string idLista, DateTime fechaI, string desc, string idSerie, string idImpuesto, string idMoneda, string idDescuentos, string impuesto, string total)
        {
            Conexion conexion = new Conexion();
            OdbcCommand command = new OdbcCommand();
            command.Connection = conexion.Conectar();

            command.CommandText = "INSERT INTO tbl_facturaencabezado " +
             "VALUES (" + id + "," + idLista +
             "," + idPedido + "," + idCotizacion + ",'" + 
             fechaI.ToString("yyyy-MM-dd") + "','" + desc + "'," + 
             idSerie + "," + idCliente + "," + idImpuesto + "," + idMoneda + 
             "," + idDescuentos + "," + impuesto + "," + total + ", 1)";
            return command;
        }

        public OdbcCommand insertarFacturaD(string idProducto, string idFactura, string cantidad, string monto, string idSerie)
        {
            Conexion conexion = new Conexion();
            OdbcCommand command = new OdbcCommand();
            command.Connection = conexion.Conectar();
            command.CommandText = "SELECT COUNT(*)+1 AS id FROM tbl_facturadetalle";

            OdbcDataAdapter mySqlDataAdapter = new OdbcDataAdapter(command);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            int iConteo = 0;

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                iConteo = Convert.ToInt32(row["id"]);
            }

            command.CommandText = "INSERT INTO tbl_facturadetalle " +
             "VALUES (" + iConteo +
             "," + cantidad + "," + monto + "," + idProducto + "," + idFactura + "," + idSerie +")";
            return command;
        }

        public OdbcDataAdapter obtenerFacturaE(string idSerie)
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string sConsulta = "SELECT CONCAT(KidSerie,'-',KidFacturaEncabezado) As idFactura," +
                "DATE_FORMAT(fecha_facturaencabezado, '%d/%m/%y') AS fecha_facturaencabezado,descripcion_facturaencabezado," +
                "(SELECT nombre_moneda FROM tbl_moneda WHERE KidMoneda = tbl_facturaencabezado.KidMoneda) AS moneda," +
                "(SELECT nombre_impuesto FROM tbl_impuesto WHERE KidImpuesto = tbl_facturaencabezado.KidImpuesto) AS tipo_impuesto," +
                "FORMAT(impuesto_facturaencabezado,2) AS impuesto,FORMAT(monto_facturaencabezado,2) AS monto, KidCliente " +
                "FROM tbl_facturaencabezado WHERE estado = 1 AND KidSerie = " + idSerie;
            OdbcDataAdapter data = new OdbcDataAdapter(sConsulta, conexion.Conectar());
            return data;
        }

        public OdbcDataAdapter obtenerNumeroFacturaD(string idFactura, string idSerie)
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string sConsulta = "SELECT COUNT(*) AS conteo FROM tbl_facturadetalle WHERE KidFacturaEncabezado = " + idFactura + " AND KidSerie = " + idSerie;
            OdbcDataAdapter data = new OdbcDataAdapter(sConsulta, conexion.Conectar());
            return data;
        }

        public OdbcCommand insertarDevulucion(string idFactura, string idSerie, string descripcion)
        {
            Conexion conexion = new Conexion();
            OdbcCommand command = new OdbcCommand();
            command.Connection = conexion.Conectar();
            command.CommandText = "SELECT COUNT(*)+1 AS id FROM tbl_devoluciones";
            command.Connection = conexion.Conectar();

            OdbcDataAdapter mySqlDataAdapter = new OdbcDataAdapter(command);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            int iConteo = 0;

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                iConteo = Convert.ToInt32(row["id"]);
            }

            DateTime dateTime = DateTime.Now;

            command.CommandText = "INSERT INTO tbl_devoluciones " +
             "VALUES (" + iConteo +
             ",'" + descripcion + "','" + dateTime.ToString("yyyy-MM-dd") + "'," + idFactura + "," + idSerie + ", 1)";
            return command;
        }

        public OdbcDataAdapter comprobarDevolucion(string idFactura, string idSerie)
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string sConsulta = "SELECT IFNULL(COUNT(*),0) AS conteo FROM tbl_devoluciones WHERE estado = 1 AND KidFacturaEncabezado = " + idFactura + " AND KidSerie = " + idSerie;
            OdbcDataAdapter data = new OdbcDataAdapter(sConsulta, conexion.Conectar());
            return data;
        }

        public OdbcDataAdapter obtenerDevoluciones()
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string sConsulta = "SELECT kidDevoluciones,motivo_devoluciones," +
                "DATE_FORMAT(fecha_devoluciones,'%d/%m/%y') AS fecha_devoluciones," +
                "CONCAT(KidSerie,'-',KidFacturaEncabezado) AS idFactura " +
                "FROM tbl_devoluciones WHERE estado = 1 ORDER BY fecha_devoluciones DESC";
            OdbcDataAdapter data = new OdbcDataAdapter(sConsulta, conexion.Conectar());
            return data;
        }

        public OdbcDataAdapter obtenerDatosFactura(string idFactura, string idSerie)
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string sConsulta = "SELECT KidCliente,FORMAT(impuesto_facturaencabezado,2) AS impuesto," +
                "FORMAT(monto_facturaencabezado,2) AS monto," +
                "DATE_FORMAT(fecha_facturaencabezado, '%d/%m/%y') AS fecha_facturaencabezado " +
                "FROM tbl_facturaencabezado WHERE KidFacturaEncabezado = " + idFactura + " AND KidSerie = " + idSerie;
            OdbcDataAdapter data = new OdbcDataAdapter(sConsulta, conexion.Conectar());
            return data;
        }

        public OdbcCommand validarSolicitud(string correlativo)
        {
            Conexion conexion = new Conexion();
            OdbcCommand command = new OdbcCommand();
            command.Connection = conexion.Conectar();
            command.CommandText = "UPDATE tbl_devoluciones SET estado = 0 WHERE kidDevoluciones = " + correlativo;
            return command;
        }

        public OdbcCommand anularFactura(string idFactura, string idSerie)
        {
            Conexion conexion = new Conexion();
            OdbcCommand command = new OdbcCommand();
            command.Connection = conexion.Conectar();
            command.CommandText = "UPDATE tbl_facturaencabezado SET estado = 0 WHERE KidFacturaEncabezado = " + idFactura + " AND KidSerie = " + idSerie;
            return command;
        }

        public OdbcDataAdapter cargarCotizaciones()
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string sConsulta = "SELECT KidCotizacionEncabezado,CONCAT(KidCotizacionEncabezado,' - ',vencimiento_cotizacionEncabezado) AS nombre FROM tbl_cotizacionencabezado";
            OdbcDataAdapter data = new OdbcDataAdapter(sConsulta, conexion.Conectar());
            return data;
        }

        public OdbcDataAdapter cargarPedidos()
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string sConsulta = "SELECT KidEncabezadoPedido,CONCAT(KidEncabezadoPedido,' - ',fecha_encabezadopedido) AS nombre FROM tbl_encabezadopedido";
            OdbcDataAdapter data = new OdbcDataAdapter(sConsulta, conexion.Conectar());
            return data;
        }
    }
}
