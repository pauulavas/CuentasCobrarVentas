using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using CapaLogica_PolizaYComision;

namespace CapaDisenoPoliza
{
    public partial class Poliza : UserControl
    {
        Logica logica;
        public Poliza()
        {
            InitializeComponent();
            logica = new Logica();
        }

        ///// <summary>
        /////  cambioooooooooos
        ///// </summary>
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>



        private void Button1_Click(object sender, EventArgs e)
        {
            double totaliva = 0;
            double totalventas = 0;
            double totalclientes = 0;

            DgvPoliza.Rows.Clear();
            logica.buscar(Dtg_Final, Dtg_Inicial, DgvPoliza, Txt_NoPoliza.Text,Lbl_ventas.Text );
            if (DgvPoliza.Rows.Count - 1 > 0)
            {
                for (int i = 0; i < DgvPoliza.Rows.Count - 1; i++)
                {
                    totaliva += double.Parse(DgvPoliza.Rows[i].Cells[4].Value.ToString());
                    totalventas += double.Parse(DgvPoliza.Rows[i].Cells[5].Value.ToString());
                }
            }

            Txt_Total.Text = Convert.ToString(totalventas);
            Txt_Totaliva.Text = Convert.ToString(totaliva);
            Txt_Clientes.Text = Convert.ToString(totalventas-totaliva);




        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Poliza_Load(object sender, EventArgs e)
        {
            logica.cargaRdatos(Cmb_Cuenta);
            logica.consultarNumPoliza(Txt_NoPoliza);
        }

        private void Txt_TipoPoliza_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}