using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Datos_VentasyCtasporCobrar_lp
{
    public class sentencia_lista_precio
    {
        //Cargar datos al combobox de nombre de listas
        public OdbcDataAdapter ObtenerTabla()
        {
            conexion conexion = new conexion();
            OdbcCommand command = new OdbcCommand();
            command.CommandText = "SELECT KidDetalleListaPrecios,nombre_listaprecios FROM tbl_detalle_lista_precios";
            command.Connection = conexion.Conectar();
            OdbcDataAdapter odbcDataAdapter = new OdbcDataAdapter(command);
            return odbcDataAdapter;
        }
        //Carga datos al combobox de Tabla tipo de listas
        public OdbcDataAdapter ObtenerTabla2()
        {
            conexion conexion = new conexion();
            OdbcCommand command = new OdbcCommand();
            command.CommandText = "SELECT Kidtipo_lista_precios,nombre_lista_precios_detalle FROM tbl_tipo_lista_precios WHERE estado = 1";
            command.Connection = conexion.Conectar();
            OdbcDataAdapter odbcDataAdapter = new OdbcDataAdapter(command);
            return odbcDataAdapter;
        }
        //Carga datos al combobox de Tabla codigo producto
        public OdbcDataAdapter ObtenerTabla3()
        {
            conexion conexion = new conexion();
            OdbcCommand command = new OdbcCommand();
            command.CommandText = "SELECT KidProducto FROM tbl_producto WHERE estado = 1";
            command.Connection = conexion.Conectar();
            OdbcDataAdapter odbcDataAdapter = new OdbcDataAdapter(command);
            return odbcDataAdapter;
        }
        //mostrar el nombre del producto según codigo
        public OdbcDataAdapter ObtenerTabla4(string iIdProducto)
        {
            conexion cnccc = new conexion();
            cnccc.Conectar();
            string srelleno1 = "SELECT nombre_producto  FROM tbl_producto WHERE KidProducto = '" + iIdProducto + "' AND estado = 1";
            OdbcDataAdapter data = new OdbcDataAdapter(srelleno1, cnccc.Conectar());
            return data;
        }
        //mostrar el descuento de la lista de precios según tipo de lista
        public OdbcDataAdapter ObtenerTabla5(string tipodelista)
        {
            conexion cnccc = new conexion();
            cnccc.Conectar();
            string srelleno1 = "SELECT descuento_lista_precios  FROM tbl_tipo_lista_precios WHERE nombre_lista_precios_detalle = '" + tipodelista + "' AND estado = 1";
            OdbcDataAdapter data = new OdbcDataAdapter(srelleno1, cnccc.Conectar());
            return data;
        }
        //carga el id del tipo de lista según el nombre de la lista
        public OdbcDataAdapter ObtenerTabla6(string sLista)
        {
            conexion cnccc = new conexion();
            cnccc.Conectar();
            string srelleno1 = "SELECT Kidtipo_lista_precios  FROM tbl_detalle_lista_precios WHERE nombre_listaprecios = '" + sLista + "'";
            OdbcDataAdapter data = new OdbcDataAdapter(srelleno1, cnccc.Conectar());
            return data;
        }
        //carga el nombre del tipo de lista según el id del tipo de lista
        public OdbcDataAdapter ObtenerTabla7(string sTipoLista)
        {
            conexion cnccc = new conexion();
            cnccc.Conectar();
            string srelleno1 = "SELECT nombre_lista_precios_detalle  FROM tbl_tipo_lista_precios WHERE Kidtipo_lista_precios = '" + sTipoLista + "'";
            OdbcDataAdapter data = new OdbcDataAdapter(srelleno1, cnccc.Conectar());
            return data;
        }
        //cargar id de fecha inicio
        public OdbcDataAdapter ObtenerTabla8(string sEncabezadoLista)
        {
            conexion cnccc = new conexion();
            cnccc.Conectar();
            string srelleno1 = "SELECT KidEncabezadoListaPrecios  FROM tbl_detalle_lista_precios WHERE nombre_listaprecios = '" + sEncabezadoLista + "'";
            OdbcDataAdapter data = new OdbcDataAdapter(srelleno1, cnccc.Conectar());
            return data;
        }
        //cargar fecha inicio segun id 
        public OdbcDataAdapter ObtenerTabla9(string sEncabezadoLista)
        {
            conexion cnccc = new conexion();
            cnccc.Conectar();
            string srelleno1 = "SELECT Fecha_inicio_listaprecios  FROM tbl_encabezado_lista_precios WHERE KidEncabezadoListaPrecios = '" + sEncabezadoLista + "'";
            OdbcDataAdapter data = new OdbcDataAdapter(srelleno1, cnccc.Conectar());
            return data;
        }
        //cargo el descuento según el tipo de lista
        public OdbcDataAdapter ObtenerTabla10(string sTipoLista)
        {
            conexion cnccc = new conexion();
            cnccc.Conectar();
            string srelleno1 = "SELECT descuento_lista_precios  FROM tbl_tipo_lista_precios WHERE Kidtipo_lista_precios = '" + sTipoLista + "'";
            OdbcDataAdapter data = new OdbcDataAdapter(srelleno1, cnccc.Conectar());
            return data;
        }
        //Insertar fecha en encabezado de lista de precios
        public OdbcCommand Insertarencabezadosentencia1(string fecha_creacion1)
        {
            conexion conexion = new conexion();
            OdbcCommand command = new OdbcCommand();
            command.CommandText = "SELECT COUNT(*)+1 AS KidEncabezadoListaPrecios FROM tbl_encabezado_lista_precios";
            command.Connection = conexion.Conectar();
            OdbcDataAdapter mySqlDataAdapter = new OdbcDataAdapter(command);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            //crea id
            int iConteo = 0;
            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                iConteo = Convert.ToInt32(row["KidEncabezadoListaPrecios"]);
            }
            int comi = 34;
            string comi2 = ((char)(comi)).ToString();
            //sentencia
            command.CommandText = "INSERT INTO tbl_encabezado_lista_precios " +
             "VALUES (" + iConteo +
             ",'" + fecha_creacion1 + "' ,'" + fecha_creacion1 + "')";
            return command;
        }
        //obtener id según fecha
        public OdbcDataAdapter ObtenerTabla11(string sfechainicio)
        {
            conexion cnccc = new conexion();
            cnccc.Conectar();
            string srelleno1 = "SELECT KidEncabezadoListaPrecios  FROM tbl_encabezado_lista_precios WHERE Fecha_inicio_listaprecios = '" + sfechainicio + "'";
            OdbcDataAdapter data = new OdbcDataAdapter(srelleno1, cnccc.Conectar());
            return data;
        }
        //obtener id tipo de lista
        public OdbcDataAdapter ObtenerTabla12(string snombreLista)
        {
            conexion cnccc = new conexion();
            cnccc.Conectar();
            string srelleno1 = "SELECT Kidtipo_lista_precios  FROM tbl_tipo_lista_precios WHERE nombre_lista_precios_detalle = '" + snombreLista + "'";
            OdbcDataAdapter data = new OdbcDataAdapter(srelleno1, cnccc.Conectar());
            return data;
        }
        //Insertar fecha en encabezado de lista de precios
        public OdbcCommand InsertarDetalle1( string nombrelista,string idencabezado, string idtipolista, string producto, string precio)
        {
            conexion conexion = new conexion();
            OdbcCommand command = new OdbcCommand();
            command.CommandText = "SELECT COUNT(*)+1 AS KidDetalleListaPrecios FROM tbl_detalle_lista_precios";
            command.Connection = conexion.Conectar();
            OdbcDataAdapter mySqlDataAdapter = new OdbcDataAdapter(command);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            //crea id
            int iConteo = 0;
            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                iConteo = Convert.ToInt32(row["KidDetalleListaPrecios"]);
            }
            int comi = 34;
            string comi2 = ((char)(comi)).ToString();
            //sentencia
            command.CommandText = "INSERT INTO tbl_detalle_lista_precios  " +
             "VALUES (" + idencabezado +
             ",'" + iConteo + "' ,'" + producto + "','" + idtipolista + "','" + nombrelista+ "','" + precio + "')";
            return command;
        }
        //llenar tabla
        public OdbcDataAdapter consultarQuery()
        {

            conexion cn = new conexion();
            cn.Conectar();
            string sConsulta = "SELECT * FROM tbl_detalle_lista_precios ";
            OdbcDataAdapter data = new OdbcDataAdapter(sConsulta, cn.Conectar());
            return data;
        }

    }

}
