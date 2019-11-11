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
        //FUNCION PARA OBTENER POLIZA
        int id;
        void obtenerNoPoliza()
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string numero = "SELECT count(*) from tbl_encabezado_poliza";
            OdbcDataAdapter sda4 = new OdbcDataAdapter(numero, conexion.Conectar());
            DataTable tabla = new DataTable();
            sda4.Fill(tabla);
            id = Convert.ToInt32(tabla.Rows[0][0]);

        }

        //FUNCION BUSCAR LAS FECHAS 
        void buscar(DateTimePicker Dtg_Inicial, DateTimePicker Dtg_Final, DataGridView dataPrueba)
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string cadenaSQL = "Select *from tbl_facturaencabezado where fecha_facturaencabezado between ' " + Dtg_Inicial.Value.ToString("yyyy-MM-dd") + "' AND '" + Dtg_Final.Value.ToString("yyyy-MM-dd") + "'";
            OdbcDataAdapter sda = new OdbcDataAdapter(cadenaSQL, conexion.Conectar());


            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataPrueba.DataSource = ds.Tables[0];


        }

        void suma(DataGridView dataPrueba, DataGridView Dgv_Poliza, Label lbl1, Label lbl2, Label lbl3, TextBox Txt_NoPoliza, DateTimePicker Dtp_Creacion)
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();

            //Suma de facturas

            float sumaFinal = 0; float suma = 0; float suma3 = 0;

            for (int i = 0; i < dataPrueba.Rows.Count; i++)
            {
                suma += Convert.ToInt32(dataPrueba.Rows[i].Cells[9].Value);
            }
            lbl1.Text = suma.ToString();//SumaAlmacenadaMonto

            int suma2 = 0;
            for (int i = 0; i < dataPrueba.Rows.Count; i++)
            {
                suma2 += Convert.ToInt32(dataPrueba.Rows[i].Cells[11].Value);
            }
            suma3 = suma + suma2;
            lbl2.Text = suma3.ToString();                               //Suma Monto e Iva
            lbl3.Text = suma2.ToString();



            OdbcDataAdapter sda3 = new OdbcDataAdapter("select id_cuenta,Nombre_cuenta from tbl_catalogo_cuentas_contables where id_cuenta= 16", conexion.Conectar());
            DataTable datos3 = new DataTable();
            sda3.Fill(datos3);

            OdbcDataAdapter sda4 = new OdbcDataAdapter("select id_cuenta,Nombre_cuenta from tbl_catalogo_cuentas_contables where id_cuenta= 5", conexion.Conectar());
            DataTable datos4 = new DataTable();
            sda4.Fill(datos4);

            OdbcDataAdapter sda2 = new OdbcDataAdapter("select id_cuenta,Nombre_cuenta from tbl_catalogo_cuentas_contables where id_cuenta=4", conexion.Conectar());
            DataTable datos2 = new DataTable();
            sda2.Fill(datos2);

            Dgv_Poliza.Rows.Add(Txt_NoPoliza.Text, datos2.Rows[0][0].ToString(), datos2.Rows[0][1].ToString(), "Cargo", lbl1.Text);
            Dgv_Poliza.Rows.Add(Txt_NoPoliza.Text, datos3.Rows[0][0].ToString(), datos3.Rows[0][1].ToString(), "Abono", lbl3.Text);
            Dgv_Poliza.Rows.Add(Txt_NoPoliza.Text, datos4.Rows[0][0].ToString(), datos4.Rows[0][1].ToString(), "Abono", " ", lbl2.Text);



            OdbcCommand comando = new OdbcCommand("insert into tbl_encabezado_poliza(id_poliza,FechaActual_poliza,Total_poliza,estatus) values ('" + Txt_NoPoliza.Text + "','" + Dtp_Creacion.Value.ToString("yyyy-MM-dd") + "','" + lbl1.Text + "','" + "0" + "')", conexion.Conectar());
            comando.ExecuteNonQuery();



            OdbcCommand comando2 = new OdbcCommand("insert into tbl_detalle_poliza(FK_id_poliza,FK_id_cuenta,NombreCuenta_detapoliza,Tipo_cuenta,Cargo_detallepoliza,Abono_detallepoliza) values ('" + Txt_NoPoliza.Text + "','" + datos2.Rows[0][0].ToString() + "','" + datos2.Rows[0][1].ToString() + "','" + "Cargo" + "','" + lbl3.Text + "','" + " 0" + "')", conexion.Conectar());
            comando2.ExecuteNonQuery();


            OdbcCommand comando3 = new OdbcCommand("insert into tbl_detalle_poliza(FK_id_poliza,FK_id_cuenta,NombreCuenta_detapoliza,Tipo_cuenta,Cargo_detallepoliza,Abono_detallepoliza) values ('" + Txt_NoPoliza.Text + "','" + datos3.Rows[0][0].ToString() + "','" + datos3.Rows[0][1].ToString() + "','" + "Abono" + "','" + lbl2.Text + "','" + " 0" + "')", conexion.Conectar());
            comando3.ExecuteNonQuery();

            OdbcCommand comando4 = new OdbcCommand("insert into tbl_detalle_poliza(FK_id_poliza,FK_id_cuenta,NombreCuenta_detapoliza,Tipo_cuenta,Cargo_detallepoliza,Abono_detallepoliza) values ('" + Txt_NoPoliza.Text + "','" + datos4.Rows[0][0].ToString() + "','" + datos4.Rows[0][1].ToString() + "','" + "Abono" + "','" + "0" + "','" + lbl1.Text + "')", conexion.Conectar());
            comando4.ExecuteNonQuery();

        }

        //FUNCION PARA OBTENER COMISION
        int id1;
        void obtenerNoComision()
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string numero = "SELECT count(*) from tbl_encabezado_poliza";
            OdbcDataAdapter sda4 = new OdbcDataAdapter(numero, conexion.Conectar());
            DataTable tabla = new DataTable();
            sda4.Fill(tabla);
            id1 = Convert.ToInt32(tabla.Rows[0][0]);

        }


}
}
