using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.SqlClient;

namespace CapaDatos_PolizayComision
{
    public class Sentencia
    {
        public string consultarNumPoliza()
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string sConsulta = "SELECT MAX(KidPoliza) from tbl_poliza_encabezado"; //encabezado poliza
            string nextId = "";
            OdbcCommand comando = new OdbcCommand(sConsulta, conexion.Conectar());
            OdbcDataReader data = comando.ExecuteReader();
            if (data.HasRows) 
            {
                if (data.Read())
                {
                    if (data.GetValue(0).ToString() == "" || data.GetValue(0).ToString() == null)
                    {
                        nextId = "0";
                    }
                    else
                    {
                        nextId = data.GetValue(0).ToString();
                    }
                }
            }
            return nextId;
        }


        public OdbcDataAdapter cargardatos(ComboBox cb)
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string carga = "select nombre from tbl_cuentas";
            OdbcDataAdapter data = new OdbcDataAdapter(carga, conexion.Conectar());
            return data;
        }

        public OdbcDataAdapter busqueda( DateTimePicker Dtg_Inicial,DateTimePicker Dtg_Final,  DataGridView DgvPoliza )
        {   //VENTAS

            Conexion conexion = new Conexion();
            conexion.Conectar();

            //string cadenaSQL = "Select KidFacturaEncabezado, fecha_facturaencabezado, KidSerie,  KidCliente,  KidImpuesto, impuesto_facturaencabezado, monto_facturaencabezado from tbl_facturaencabezado where fecha_facturaencabezado between '" + Dtg_Inicial.Value.Date.ToString("yyyy-MM-dd") + "' AND '" + Dtg_Final.Value.Date.ToString("yyyy-MM-dd") + "'";
            string cadenaSQL = "Select Kidfacturaencabezado, fecha_facturaencabezado, impuesto_facturaencabezado, monto_facturaencabezado from tbl_facturaencabezado";
            MessageBox.Show("" + Dtg_Final.Value.Date.ToString("yyyy-MM-dd") + "-" + Dtg_Final.Value.Date.ToString("yyyy-MM-dd"));
            OdbcDataAdapter sda = new OdbcDataAdapter(cadenaSQL, conexion.Conectar());
            return sda;
        }

        public OdbcCommand insertardatos(string nopoliza,DateTimePicker DtpCreacion,string notipo,string totalventas )
        {
            Conexion conexion = new Conexion();
            OdbcCommand insertar = new OdbcCommand();
            insertar.Connection = conexion.Conectar();
            
            insertar.CommandText = "INSERT INTO tbl_poliza_encabezado" + "VALUES ("+ nopoliza+ ","+ notipo +"," + DtpCreacion.Value.Date.ToString("yyyy-MM-dd") +"," + totalventas+"')";

            return insertar;
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

        public OdbcCommand validarSolicitud(string correlativo)
        {
            Conexion conexion = new Conexion();
            OdbcCommand command = new OdbcCommand();
            command.Connection = conexion.Conectar();
            command.CommandText = "UPDATE tbl_devoluciones SET estado = 0 WHERE kidDevoluciones = " + correlativo;
            return command;
        }



    }
}
