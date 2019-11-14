
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using Capa_Datos_VentasyCtasporCobrar_lp;
namespace Capa_Logica_VentasyCtasporCobrar_lp
{
    public class logica_lista_precio
    {

        //Cargar datos al combobox de nombre de listas
        public void CargarTabla(ComboBox comboBox, List<int> listaprecios)
        {
            sentencia_lista_precio sc = new sentencia_lista_precio();
            OdbcDataAdapter odbcDataAdapter = sc.ObtenerTabla();

            DataTable dataTable = new DataTable();
            odbcDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow row = dataTable.Rows[i];
                    listaprecios.Add(Convert.ToInt32(row["KidDetalleListaPrecios"]));
                    comboBox.Items.Add(row["nombre_listaprecios"].ToString());
                }
               
            }
        }

        //Carga datos al combobox de Tabla tipo de listas
        public void CargarTabla2(ComboBox comboBox, List<int> tipolistaprecios)
        {
            sentencia_lista_precio sc = new sentencia_lista_precio();
            OdbcDataAdapter odbcDataAdapter = sc.ObtenerTabla2();

            DataTable dataTable = new DataTable();
            odbcDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow row = dataTable.Rows[i];
                    tipolistaprecios.Add(Convert.ToInt32(row["Kidtipo_lista_precios"]));
                    comboBox.Items.Add(row["nombre_lista_precios_detalle"].ToString());
                }

            }
        }

        //Carga datos al combobox de Tabla codigo producto
        public void CargarTabla3(ComboBox comboBox)
        {
            sentencia_lista_precio sc = new sentencia_lista_precio();
            OdbcDataAdapter odbcDataAdapter = sc.ObtenerTabla3();

            DataTable dataTable = new DataTable();
            odbcDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow row = dataTable.Rows[i];
                    comboBox.Items.Add(Convert.ToInt32(row["KidProducto"]));
                }

            }
        }

        //mostrar el nombre del producto según codigo
        public void CargarTexto(TextBox box, string tabla)
        {
            sentencia_lista_precio sc = new sentencia_lista_precio();
            OdbcDataAdapter odbcDataAdapter = sc.ObtenerTabla4(tabla);

            DataTable dataTable = new DataTable();
            odbcDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow rows = dataTable.Rows[i];
                    string cam = rows["nombre_producto"].ToString();
                    box.Text = cam;
                }

            }
        }

        //mostrar el descuento de la lista de precios según tipo de lista
        public void CargarTexto2(TextBox box, string tabla)
        {
            sentencia_lista_precio sc = new sentencia_lista_precio();
            OdbcDataAdapter odbcDataAdapter = sc.ObtenerTabla5(tabla);

            DataTable dataTable = new DataTable();
            odbcDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow rows = dataTable.Rows[i];
                    string cam = rows["descuento_lista_precios"].ToString();
                    box.Text = cam;
                }

            }
        }
        //carga el id del tipo de lista según el nombre de la lista
        public void CargarTipoLista(TextBox box, string cam)
        {
            sentencia_lista_precio sc = new sentencia_lista_precio();
            OdbcDataAdapter odbcDataAdapter = sc.ObtenerTabla6(cam);

            DataTable dataTable = new DataTable();
            odbcDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow rows = dataTable.Rows[i];
                     cam = rows["Kidtipo_lista_precios"].ToString();
                    box.Text = cam;
                    
                }

            }
        }
        //carga el nombre del tipo de lista según el id del tipo de lista
        public void CargarTipoLista2(TextBox box, string cam)
        {
            sentencia_lista_precio sc = new sentencia_lista_precio();
            OdbcDataAdapter odbcDataAdapter = sc.ObtenerTabla7(cam);

            DataTable dataTable = new DataTable();
            odbcDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow rows = dataTable.Rows[i];
                    cam = rows["nombre_lista_precios_detalle"].ToString();
                    box.Text = cam;

                }

            }
        }
        //cargar id de fecha inicio
        public void CargarFechaInicio(TextBox box, string cam)
        {
            sentencia_lista_precio sc = new sentencia_lista_precio();
            OdbcDataAdapter odbcDataAdapter = sc.ObtenerTabla8(cam);

            DataTable dataTable = new DataTable();
            odbcDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow rows = dataTable.Rows[i];
                    cam = rows["KidEncabezadoListaPrecios"].ToString();
                    box.Text = cam;

                }

            }
        }
        //cargar  de fecha inicio según id
        public void CargarFechaInicio2(TextBox box, string cam)
        {
            sentencia_lista_precio sc = new sentencia_lista_precio();
            OdbcDataAdapter odbcDataAdapter = sc.ObtenerTabla9(cam);

            DataTable dataTable = new DataTable();
            odbcDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow rows = dataTable.Rows[i];
                    cam = rows["Fecha_inicio_listaprecios"].ToString();
                    box.Text = cam;

                }

            }
        }
        //cargo el descuento según el tipo de lista
        public void CargarDescuento(TextBox box, string cam)
        {
            sentencia_lista_precio sc = new sentencia_lista_precio();
            OdbcDataAdapter odbcDataAdapter = sc.ObtenerTabla10(cam);

            DataTable dataTable = new DataTable();
            odbcDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow rows = dataTable.Rows[i];
                    cam = rows["descuento_lista_precios"].ToString();
                    box.Text = cam;

                }

            }
        }
        //Insertar campos en tabla encabezado lista
        public void insertarencabezado1(string fecha_creacion)
        {
            sentencia_lista_precio sc = new sentencia_lista_precio();
            OdbcCommand command = sc.Insertarencabezadosentencia1(fecha_creacion);
            command.ExecuteNonQuery();
            
        }
        //buscar id de encabezado
        public void BuscarId(TextBox box, string tabla)
        {
            sentencia_lista_precio sc = new sentencia_lista_precio();
            OdbcDataAdapter odbcDataAdapter = sc.ObtenerTabla11(tabla);

            DataTable dataTable = new DataTable();
            odbcDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow rows = dataTable.Rows[i];
                    tabla = rows["KidEncabezadoListaPrecios"].ToString();
                    box.Text = tabla;

                }

            }
        }
        //id de tipo lista
        public void BuscarIdTipoLista(TextBox box, string tabla)
        {
            sentencia_lista_precio sc = new sentencia_lista_precio();
            OdbcDataAdapter odbcDataAdapter = sc.ObtenerTabla12(tabla);

            DataTable dataTable = new DataTable();
            odbcDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow rows = dataTable.Rows[i];
                    tabla = rows["Kidtipo_lista_precios"].ToString();
                    box.Text = tabla;

                }

            }
        }
        //Insertar campos en tabla detalle lista de precios
        public void InsertarDetalle1(string nombrelista , string box1, string box2, string box3, string precio)
        {
            sentencia_lista_precio sc = new sentencia_lista_precio();
            OdbcCommand command = sc.InsertarDetalle1(nombrelista,box1,box2,box3,precio);
            command.ExecuteNonQuery();

        }
        //llenar data
        public DataTable consultaId()
        {
            sentencia_lista_precio sn = new sentencia_lista_precio();
            OdbcDataAdapter datos = sn.consultarQuery();
            DataTable dtDatos = new DataTable();
            datos.Fill(dtDatos);
            return dtDatos;
        }
        



    }
}
