using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos_CxC_MovClientes;
using System.Data.Odbc;
using System.Data;
namespace CapaLogiga_CxC_MovClientes
{
    public class Logica_MovClientes
    {
        sentencias Sentencias_MovClientes = new sentencias();
      

        public void ConsultarMov(ComboBox TiposMoviemiento)
        {
            OdbcDataAdapter tMov = Sentencias_MovClientes.Movimientos();
            DataTable dtMovimientos = new DataTable();
            tMov.Fill(dtMovimientos);
            if (dtMovimientos.Rows.Count > 0)
            {
                for (int i = 0; i < dtMovimientos.Rows.Count; i++)
                {
                    DataRow rows = dtMovimientos.Rows[i];
                    string sMovs = rows["NombreMovimiento"].ToString();
                    TiposMoviemiento.Items.Add(sMovs);
                }
            }

        }

        public void ConsultarFactura(ComboBox CodigoFactura)
        {
            OdbcDataAdapter CodFactura = Sentencias_MovClientes.ConsultarFacturas();
            DataTable dtCodFact = new DataTable();
            CodFactura.Fill(dtCodFact);
            if (dtCodFact.Rows.Count > 0)
            {
                for(int i = 0; i < dtCodFact.Rows.Count; i++)
                {
                    DataRow rows = dtCodFact.Rows[i];
                    string sCodFac = rows["KidFacturaEncabezado"].ToString();
                    CodigoFactura.Items.Add(sCodFac);
                }
            }
        }
        public void ConsultarMoneda(ComboBox cboMoneda)
        {
            OdbcDataAdapter Moneda = Sentencias_MovClientes.ConsultarMoneda();
            DataTable dtMoneda = new DataTable();
            Moneda.Fill(dtMoneda);
            if (dtMoneda.Rows.Count > 0)
            {
                for (int i = 0; i < dtMoneda.Rows.Count; i++)
                {
                    DataRow rows = dtMoneda.Rows[i];
                    string sCodMoneda = rows["nombre_moneda"].ToString();
                    cboMoneda.Items.Add(sCodMoneda);
                }
            }
        }
        public void Periodo(ComboBox cboperiodo)
        {
            OdbcDataAdapter odbcPeriodo = Sentencias_MovClientes.ObtenerPer();
            DataTable dtPeriodo = new DataTable();
            odbcPeriodo.Fill(dtPeriodo);

            if(dtPeriodo.Rows.Count > 0)
            {
                for(int i = 0; i < dtPeriodo.Rows.Count; i++)
                {
                    DataRow rs = dtPeriodo.Rows[i];
                    string sPer = rs["Periodo"].ToString();
                    cboperiodo.Items.Add(sPer);
                }
            }
        }

        public void ConsultarCliente(ComboBox cboClientes)
        {
            OdbcDataAdapter CodCliente = Sentencias_MovClientes.ConsultarClientes();
            DataTable dtCodCliente = new DataTable();
            CodCliente.Fill(dtCodCliente);
            if (dtCodCliente.Rows.Count > 0)
            {
                for (int i = 0; i < dtCodCliente.Rows.Count; i++)
                {
                    DataRow rows = dtCodCliente.Rows[i];
                    string sCodCliente = rows["KidCliente"].ToString();
                    cboClientes.Items.Add(sCodCliente);
                }
            }
        }

        public void ConsultarVendedor(ComboBox cboVendedor)
        {
            OdbcDataAdapter CodVendedor = Sentencias_MovClientes.ConsultarVendedores();
            DataTable dtCodVendedor = new DataTable();
            CodVendedor.Fill(dtCodVendedor);
            if (dtCodVendedor.Rows.Count > 0)
            {
                for (int i = 0; i < dtCodVendedor.Rows.Count; i++)
                {
                    DataRow rows = dtCodVendedor.Rows[i];
                    string sCodVendedor = rows["KidEmpleado"].ToString();
                    cboVendedor.Items.Add(sCodVendedor);
                }
            }
        }

        public void ConsultarDescuento(ComboBox cboDescuento)
        {

            OdbcDataAdapter CodDescuento = Sentencias_MovClientes.ConsultarDescuentos();
            DataTable dtCodDescuento = new DataTable();
            CodDescuento.Fill(dtCodDescuento);
            if (dtCodDescuento.Rows.Count > 0)
            {
                for (int i = 0; i < dtCodDescuento.Rows.Count; i++)
                {
                    DataRow rows = dtCodDescuento.Rows[i];
                    string sCodDescuento = rows["porcentaje_descuentos"].ToString();
                    cboDescuento.Items.Add(sCodDescuento);
                }
            }
        }


        

        public void Cotizacion(TextBox txt_Moneda, String sMoneda)
        {
            OdbcDataAdapter Cotizacion = Sentencias_MovClientes.ConsultarCotizaciones(sMoneda);
            DataTable dtCotizacion = new DataTable();
            Cotizacion.Fill(dtCotizacion);

            for (int i = 0; i < dtCotizacion.Rows.Count; i++)
            {
                DataRow rows = dtCotizacion.Rows[i];
                string sCotizacion = rows["tasa_moneda"].ToString();
                txt_Moneda.Text = sCotizacion;
            }
            
        }
        public void IdTipoMov(TextBox txt_CodigoMov, String sNombreMov)
        {
            OdbcDataAdapter id = Sentencias_MovClientes.ObtenerIdMov(sNombreMov);
            DataTable dtMov = new DataTable();
            id.Fill(dtMov);

            for (int i = 0; i < dtMov.Rows.Count; i++)
            {
                DataRow rows = dtMov.Rows[i];
                string sCod = rows["KidtipoMovimiento"].ToString();
                txt_CodigoMov.Text = sCod;
            }

        }
        public void idPeriodo(TextBox txt_per, int Periodo)
        {
            OdbcDataAdapter idPer = Sentencias_MovClientes.idPeriodo(Periodo);
            DataTable dtId = new DataTable();

            idPer.Fill(dtId);

            for(int i=0; i < dtId.Rows.Count; i++)
            {
                DataRow rs = dtId.Rows[i];
                string sCodPer = rs["KidPeriodo"].ToString();
                txt_per.Text = sCodPer;
            }

        }

        public void IdMovimiento(TextBox txt_codigo)
        {
            OdbcDataAdapter id = Sentencias_MovClientes.ObtenerId();
            DataTable dataTable = new DataTable();
            id.Fill(dataTable);

            int iConteo = 0;

            if (dataTable.Rows.Count > 0)
            {
                for(int i=0;i< dataTable.Rows.Count; i++)
                {
                    DataRow row = dataTable.Rows[0];
                    iConteo = Convert.ToInt32(row["id"]);
                    txt_codigo.Text = Convert.ToString(iConteo);
                }

            }
        }

       

        public OdbcCommand InsertarM(int idEncabezado, int idFactura, int idCliente, int idMovimiento, int idEmpleado, string sdate, string smoneda, double dCotizacion, string sCentro, string sfechaVencimiento, int Periodo, string sNat)
        {
            OdbcCommand Inserta = Sentencias_MovClientes.InsertarMovimiento(idEncabezado, idFactura, idCliente, idMovimiento, idEmpleado, sdate, smoneda, dCotizacion, sCentro, sfechaVencimiento, Periodo, sNat);
            Inserta.ExecuteNonQuery();
            return Inserta;
        }

        public void InsertarDetalle(double dDescuento, string sDescripcion, double dValorComprobante, int iCodigoEncabezado, string sNaturaleza)
        {
            OdbcCommand InsertarDetalle = Sentencias_MovClientes.InsertarDetalle(dDescuento, sDescripcion, dValorComprobante, iCodigoEncabezado, sNaturaleza);
            InsertarDetalle.ExecuteNonQuery();
        }

        public void IdNaturaleza(TextBox txt_Naturaleza, String sNombreMov)
        {
            OdbcDataAdapter id = Sentencias_MovClientes.ObtenerNaturaleza(sNombreMov);
            DataTable dtMov = new DataTable();
            id.Fill(dtMov);

            for (int i = 0; i < dtMov.Rows.Count; i++)
            {
                DataRow rows = dtMov.Rows[i];
                string sCod = rows["Naturaleza"].ToString();
                txt_Naturaleza.Text = sCod;
            }

        }
    }
}
