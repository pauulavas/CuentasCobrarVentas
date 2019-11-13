using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos_PolizayComision;

namespace CapaLogica_PolizaYComision
{
    public class Logica
    {
       

        public bool consultarNumPoliza(TextBox No_Poliza)
        {
            bool encontrado = true;
            Sentencia sentencias = new Sentencia();
            string nextId = sentencias.consultarNumPoliza();
            if (nextId=="")
            {
                No_Poliza.Text = "1";
            }
            else
            {
                No_Poliza.Text = (Convert.ToInt32(nextId) + 1).ToString();
            }
           
            return encontrado;
        }

       

        public void cargaRdatos( ComboBox Cmb_Cuenta)
        {
            Sentencia sentencias = new Sentencia();
            OdbcDataAdapter datos1 = sentencias.cargardatos(Cmb_Cuenta);
            DataTable dtDatos1 = new DataTable();
            datos1.Fill(dtDatos1);

            DataRow fila = dtDatos1.NewRow();
            fila["nombre"] = "SELECCIONE UNA CUENTA";
            dtDatos1.Rows.InsertAt(fila, 0);

            Cmb_Cuenta.ValueMember = "kid_Cuenta";
            Cmb_Cuenta.DisplayMember = "nombre";
            Cmb_Cuenta.DataSource = dtDatos1;

            //int noFilas = dtDatos1.Rows.Count;
            //for (int i = 0; i < noFilas; i++)
            //{
            //    Cmb_Cuenta.Items.Add("HOla");
            //}
        }

        public void buscar(DateTimePicker Dtg_Inicial, DateTimePicker Dtg_Final, DataGridView DgvPoliza, string id, string tipopoliza)
        {
      
            Sentencia sentencias = new Sentencia();
            OdbcDataAdapter datos = sentencias.busqueda(Dtg_Inicial,Dtg_Final,DgvPoliza);
            DataTable dtDatos = new DataTable();
            datos.Fill(dtDatos);

            if (dtDatos.Rows.Count > 0)
            {
                for (int i =0; i < dtDatos.Rows.Count; i++)
                {
                    DataRow fila = dtDatos.Rows[i];
                    DgvPoliza.Rows.Add(
                        id,
                        tipopoliza,
                         fila["Kidfacturaencabezado"].ToString(),
                        fila["fecha_facturaencabezado"].ToString(),
                        fila["impuesto_facturaencabezado"].ToString(),
                        fila["monto_facturaencabezado"].ToString()
                        );
                } 
            }
            else
            {
                MessageBox.Show("NO EXISTEN DATOS REGISTRADOS");
            }

            /*DataSet ds = new DataSet();
            DgvPoliza.DataSource = ds.Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
                DataRow row = dtDatos.Rows[0];
            }*/



        }

    public void insertardatos()
        {

        }


    }
  }

