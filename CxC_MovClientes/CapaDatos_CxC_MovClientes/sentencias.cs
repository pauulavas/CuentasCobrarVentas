using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using CapaDatos_CxC_MovClientes;
using System.Data;

namespace CapaDatos_CxC_MovClientes
{

    public class sentencias
    {
        


        public OdbcDataAdapter Movimientos()
        {
            conexion cn = new conexion();
            cn.Conectar();
            string sMovimiento = "SELECT NombreMovimiento FROM tbl_tipomovimiento WHERE estado = 1";
            OdbcDataAdapter odbcConsultar = new OdbcDataAdapter(sMovimiento, cn.Conectar());
            return odbcConsultar;
        }
        public OdbcDataAdapter ConsultarFacturas()
        {
            conexion conn = new conexion();
            conn.Conectar();
            string sConsultarFactura = "SELECT KidFacturaEncabezado FROM tbl_facturaEncabezado WHERE estado = 1 ";
            OdbcDataAdapter odbcConsultarFactura = new OdbcDataAdapter(sConsultarFactura, conn.Conectar());
            return odbcConsultarFactura;
        }

        public OdbcDataAdapter ConsultarMoneda()
        {
            conexion conn = new conexion();
            conn.Conectar();
            string sConsultarMoneda = "SELECT nombre_moneda From tbl_moneda WHERE estado = 1 ";
            OdbcDataAdapter odbcConsultarMoneda = new OdbcDataAdapter(sConsultarMoneda, conn.Conectar());
            return odbcConsultarMoneda;
        }

        public OdbcDataAdapter ConsultarClientes()
        {
            conexion conn = new conexion();
            OdbcConnection conectar= conn.Conectar();
            string sConsultarCliente = "SELECT KidCliente From tbl_clientes WHERE estado = 1 ";
            OdbcDataAdapter odbcConsultarCliente= new OdbcDataAdapter(sConsultarCliente, conectar);
            return odbcConsultarCliente;
        }

        public OdbcDataAdapter ConsultarVendedores()
        {
            conexion conn = new conexion();
            conn.Conectar();
            string sConsultarVendedor= "SELECT KidEmpleado From tbl_empleado WHERE estado = 1 ";
            OdbcDataAdapter odbcConsultarVendedor = new OdbcDataAdapter(sConsultarVendedor, conn.Conectar());
            return odbcConsultarVendedor;
        }

        public OdbcDataAdapter ConsultarDescuentos()
        {
            conexion conn = new conexion();
            conn.Conectar();
            string sConsultarVendedor = "SELECT porcentaje_descuentos From tbl_descuentos WHERE estado = 1 ";
            OdbcDataAdapter odbcConsultarVendedor = new OdbcDataAdapter(sConsultarVendedor, conn.Conectar());
            return odbcConsultarVendedor;
        }
        public OdbcDataAdapter ObtenerPer()
        {
            conexion con = new conexion();
            con.Conectar();
            string sPeriodo = "SELECT Periodo FROM tbl_periodo WHERE estado = 1 ";
            OdbcDataAdapter odbcConsultarPer = new OdbcDataAdapter(sPeriodo, con.Conectar());
            return odbcConsultarPer;
        }

        public OdbcDataAdapter idPeriodo(int periodo)
        {
            conexion con = new conexion();
            con.Conectar();
            string sPeriodo = "SELECT KidPeriodo FROM tbl_periodo WHERE Periodo = " + periodo;
            OdbcDataAdapter idPeriodo = new OdbcDataAdapter(sPeriodo, con.Conectar());
            return idPeriodo;
        }
        public OdbcDataAdapter ConsultarCotizaciones(string sMoneda)
        {
            int comi = 34;
            string comi2 = ((char)(comi)).ToString();
            conexion conn = new conexion();
            conn.Conectar();
            string sConsultarVendedor = "SELECT tasa_moneda From tbl_moneda  WHERE nombre_moneda = " + comi2+ sMoneda +comi2 ;
            OdbcDataAdapter odbcConsultarVendedor = new OdbcDataAdapter(sConsultarVendedor, conn.Conectar());
            return odbcConsultarVendedor;
        }
      
        
        public OdbcDataAdapter ObtenerIdMov(string sNombreMov)
        {
            int comi = 34;
            string comi2 = ((char)(comi)).ToString();
            conexion con = new conexion();
            con.Conectar();
            string sIdComprobante = "SELECT KidtipoMovimiento FROM tbl_tipomovimiento WHERE NombreMovimiento = " + comi2 + sNombreMov + comi2;
            OdbcDataAdapter idComprobante = new OdbcDataAdapter(sIdComprobante, con.Conectar());
            return idComprobante;
        }

        public OdbcDataAdapter ObtenerNaturaleza(string sNombreMov)
        {
            int comi = 34;
            string comi2 = ((char)(comi)).ToString();
            conexion con = new conexion();
            con.Conectar();
            string sNatura = "SELECT naturaleza FROM tbl_tipomovimiento WHERE NombreMovimiento = " + comi2 + sNombreMov + comi2;
            OdbcDataAdapter Nat = new OdbcDataAdapter(sNatura, con.Conectar());
            return Nat;
        }

        
        public OdbcDataAdapter ObtenerId()
        {
            conexion con = new conexion();
            con.Conectar();
            string sIdComprobante = "SELECT COUNT(*)+1 AS id FROM tbl_encabezadocomprobante";
            OdbcDataAdapter idComprobante = new OdbcDataAdapter(sIdComprobante, con.Conectar());
            return idComprobante;
        }

        public OdbcCommand InsertarMovimiento(int idEncabezado,int idFactura,int idCliente, int idMovimiento ,int idEmpleado, string sdate, string smoneda, double dCotizacion, string sCentro, string sfechaVencimiento, int Periodo, string sNat)
        {
            conexion con = new conexion();
            con.Conectar();
            string sInsertaMov = "INSERT INTO tbl_encabezadocomprobante  " +
                "VALUES ("+idEncabezado+", "+idFactura+","+idCliente+" , "+idEmpleado+" , "+idMovimiento+", '"+sdate+"', '"+smoneda+"', "+dCotizacion+", '"+sCentro+"', '"+sfechaVencimiento+"', "+Periodo+", '"+sNat+"' ,'1')";

            OdbcCommand InsertarMov = new OdbcCommand(sInsertaMov, con.Conectar());
            return InsertarMov;
        }

        public OdbcCommand InsertarDetalle(double dDescuento, string sDescripcion, double dValorComprobante, int iCodigoEncabezado, string sNaturaleza)
        {
            conexion con = new conexion();
            con.Conectar();
            OdbcCommand command = new OdbcCommand();
            //command.CommandText = "SELECT COUNT(*)+1 AS id FROM consulta";
            command.CommandText = "SELECT COUNT(*)+1 AS id FROM tbl_detallecomprobante";
            command.Connection = con.Conectar();

            OdbcDataAdapter mySqlDataAdapter = new OdbcDataAdapter(command);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);


            int iConteo = 0;

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                iConteo = Convert.ToInt32(row["id"]);
            }

            int comi = 34;
            string comi2 = ((char)(comi)).ToString();

            command.CommandText = "INSERT INTO tbl_detallecomprobante VALUES (" +iConteo+ " , "+dValorComprobante+ " , '" + sDescripcion + "' , " + dDescuento+
                " , '"+sNaturaleza+"' , " +iCodigoEncabezado+ ")";


            return command;
        }

    }
}
