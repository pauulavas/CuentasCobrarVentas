using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogiga_CxC_MovClientes;

namespace CapaDiseno_CxC_MovClientes
{
    public partial class MovimientoClientes : UserControl
    {
        Logica_MovClientes CapaLogica = new Logica_MovClientes();
        TextBox txt_CodMov = new TextBox();
        TextBox txt_Naturaleza = new TextBox();
        TextBox txt_idPeri = new TextBox();
        int ContadorMovimientos = 0;
        public MovimientoClientes()
        {
            InitializeComponent();
            Dgv_detalleComprobante.ForeColor = Color.Black;
            CapaLogica.ConsultarFactura(cbo_factura);
            CapaLogica.ConsultarVendedor(cbo_codigoVendedor);
            CapaLogica.ConsultarDescuento(cbo_Descuento);
            CapaLogica.ConsultarCliente(cbo_codigoCliente);
            CapaLogica.ConsultarMoneda(cbo_TipoMoneda);
            CapaLogica.ConsultarMov(cbo_TipoComprobante);
            CapaLogica.IdMovimiento(txt_codigoMov);
            CapaLogica.Periodo(cbo_per);
            gb_DetalleMov.Enabled = false;
            lbl_war.Visible = false;
            lbl_war2.Visible = false;
            lbl_war3.Visible = false;
            lbl_war4.Visible = false;
            lbl_war5.Visible = false;
            lbl_war6.Visible = false;
            lbl_war7.Visible = false;
            lbl_war8.Visible = false;
            lbl_war9.Visible = false;
            lbl_war10.Visible = false;



        }



        private void cbo_TipoComprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            CapaLogica.IdTipoMov(txt_CodMov, cbo_TipoComprobante.Text);
            CapaLogica.IdNaturaleza(txt_Naturaleza, cbo_TipoComprobante.Text);
        }

        private void cbo_TipoMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            CapaLogica.Cotizacion(txt_Cotización, cbo_TipoMoneda.Text);
        }

        private void cbo_codigoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbo_codigoVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbo_Descuento_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_detalle_Click(object sender, EventArgs e)
        {

           
            


            if (txt_codigoMov.Text==""|cbo_factura.Text==""|cbo_codigoCliente.Text==""|cbo_TipoComprobante.Text==""|cbo_TipoMoneda.Text==""|cbo_codigoVendedor.Text==""|cbo_per.Text==""|txt_CentroCosto.Text=="")
            {
                MessageBox.Show(this, "Existen campos vacíos", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Question);
                lbl_war.Visible = true;
                lbl_war2.Visible = true;
                lbl_war3.Visible = true;
                lbl_war4.Visible = true;
                lbl_war5.Visible = true;
                lbl_war6.Visible = true;
                lbl_war7.Visible = true;
               
            }
            else
            {
                lbl_war.Visible = false;
                lbl_war2.Visible = false;
                lbl_war3.Visible = false;
                lbl_war4.Visible = false;
                lbl_war5.Visible = false;
                lbl_war6.Visible = false;
                lbl_war7.Visible = false;
                gb_DetalleMov.Enabled = true;
            }
        }

        private void txt_vigencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Btn_generar_Click(object sender, EventArgs e)
        {
            string sDescripcion;
            double dValor,dDescuento,dSaldoComprobante;
            ContadorMovimientos++;
            if (ContadorMovimientos == 1)
            {
                if (txt_descripcion.Text == "" | txt_Precio.Text == "" | cbo_Descuento.Text == "")
                {
                    lbl_war8.Visible = true;
                    lbl_war9.Visible = true;
                    lbl_war10.Visible = true;
                    MessageBox.Show(this, "Existen campos vacíos","Ayuda", MessageBoxButtons.OK,MessageBoxIcon.Question);

                }
                else
                {
                    sDescripcion = txt_descripcion.Text;
                    dValor = Convert.ToDouble(txt_Precio.Text);
                    dDescuento = dValor * Convert.ToDouble(cbo_Descuento.Text);
                    dSaldoComprobante = dValor - dDescuento;
                    Dgv_detalleComprobante.Rows.Add(cbo_TipoComprobante.Text, sDescripcion, dSaldoComprobante, dSaldoComprobante);
                    MessageBox.Show(this, "Presione Nuevamente para Registrar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                
            }
            else if(ContadorMovimientos==2)
            {
                int idEncabezado, idFactura, idCliente, idMovimiento, idEmpleado, Periodo;
                string sdate, sfechaVencimiento, smoneda, sCentro, sNat;
                double dCotizacion;
                sdate = date_FechaEmision.Value.ToString("yyyy/mm/dd");
                sfechaVencimiento = date_FechaEmision.Value.AddDays(Convert.ToDouble(txt_vigencia.Text)).ToString("yyyy/mm/dd");
                idEncabezado = Convert.ToInt32(txt_codigoMov.Text);
                idFactura = Convert.ToInt32(cbo_factura.Text);
                idCliente = Convert.ToInt32(cbo_codigoCliente.Text);
                idMovimiento = Convert.ToInt32(txt_CodMov.Text);
                idEmpleado = Convert.ToInt32(cbo_codigoVendedor.Text);
                sCentro = txt_CentroCosto.Text;
                smoneda = cbo_TipoMoneda.Text;
                Periodo = Convert.ToInt32(txt_idPeri.Text);
                dCotizacion = Convert.ToDouble(txt_Cotización.Text);
                sDescripcion = txt_descripcion.Text;
                dValor = Convert.ToDouble(txt_Precio.Text);
                dDescuento = dValor * Convert.ToDouble(cbo_Descuento.Text);
                dSaldoComprobante = dValor - dDescuento;
                sNat = txt_Naturaleza.Text;


                CapaLogica.InsertarM(idEncabezado, idFactura, idCliente, idMovimiento, idEmpleado, sdate, smoneda, dCotizacion, sCentro, sfechaVencimiento, Periodo,sNat);
                CapaLogica.InsertarDetalle(dDescuento, sDescripcion, dSaldoComprobante, idEncabezado, txt_Naturaleza.Text);

                MessageBox.Show(this, "Registrado Exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_codigoMov.Text = "";
                cbo_TipoComprobante.Text = "";
                cbo_factura.Text = "";
                cbo_TipoMoneda.Text = "";
                cbo_codigoCliente.Text = "";
                cbo_codigoVendedor.Text = "";
                cbo_per.Text = "";
                txt_Cotización.Text = "";
                CapaLogica.IdMovimiento(txt_codigoMov);
                txt_descripcion.Text = "";
                txt_Precio.Text = "";
                cbo_Descuento.Text = "";
                gb_DetalleMov.Enabled = false;
                Dgv_detalleComprobante.Rows.Clear();
                ContadorMovimientos = 0;

            }else if (ContadorMovimientos >= 3)
            {
                MessageBox.Show(this, "Accion Invalida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void cbo_per_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapaLogica.idPeriodo(txt_idPeri, Convert.ToInt32(cbo_per.Text));

        }

        private void cbo_TipoComprobante_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbo_factura_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbo_per_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Gpb_EncabezadoComprobante_Enter(object sender, EventArgs e)
        {

        }

        private void txt_codigoMov_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_CentroCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbo_TipoMoneda_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbo_codigoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbo_codigoVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbo_Descuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_codigoMov.Text = "";
            cbo_TipoComprobante.Text = "";
            cbo_factura.Text = "";
            cbo_TipoMoneda.Text = "";
            cbo_codigoCliente.Text = "";
            cbo_codigoVendedor.Text = "";
            cbo_per.Text = "";
            txt_Cotización.Text = "";
            CapaLogica.IdMovimiento(txt_codigoMov);
            txt_descripcion.Text = "";
            txt_Precio.Text = "";
            cbo_Descuento.Text = "";
            gb_DetalleMov.Enabled = false;
            Dgv_detalleComprobante.Rows.Clear();
            ContadorMovimientos = 0;
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
           
            Help.ShowHelp(this, "AyudaMov/ayuda Mov.chm", "index.html");
        }
    }
}
