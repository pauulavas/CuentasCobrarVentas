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

        public OdbcDataAdapter cargarSeries()
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string sConsulta = "SELECT KidSerie,serie_serie FROM tbl_serie WHERE estado = 1";
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
             "," + idCliente +  ",'" + fechaI.ToString("yyyy-MM-dd") + "','" + fechaF.ToString("yyyy-MM-dd") + "')";
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
    }
}
