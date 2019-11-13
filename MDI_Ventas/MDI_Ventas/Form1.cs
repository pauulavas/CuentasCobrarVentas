using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;
using CapaDatos;
using CapaLogica;

namespace MDI_Ventas
{
    public partial class Form1 : Form
    {
        string sIdUsuario;
        public Form1()
        {
            InitializeComponent();
        }

        private void TipoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_Clientes form_tipo_clientes = new Tipo_Clientes(sIdUsuario);
            form_tipo_clientes.MdiParent = this;
            form_tipo_clientes.Show();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes form_clientes = new Clientes(sIdUsuario);
            form_clientes.MdiParent = this;
            form_clientes.Show();
        }

        private void ImpuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_Impuesto form_tipo_impuesto = new Tipo_Impuesto(sIdUsuario);
            form_tipo_impuesto.MdiParent = this;
            form_tipo_impuesto.Show();
        }

        private void TipoPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_Pagos form_tipo_pagos = new Tipo_Pagos(sIdUsuario);
            form_tipo_pagos.MdiParent = this;
            form_tipo_pagos.Show();
        }

        private void ComisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void TipoFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void SerieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serie form_serie = new Serie(sIdUsuario);
            form_serie.MdiParent = this;
            form_serie.Show();
        }

        private void FolioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void TipoDeListaDePreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_lista_de_precios form_lista_precios = new Tipo_lista_de_precios(sIdUsuario);
            form_lista_precios.MdiParent = this;
            form_lista_precios.Show();
        }

        private void DescuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_Descuentos form_descuentos = new Tipo_Descuentos(sIdUsuario);
            form_descuentos.MdiParent = this;
            form_descuentos.Show();
        }

        private void ListaDePreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista_Precios form_lista_precios = new Lista_Precios();
            form_lista_precios.MdiParent = this;
            form_lista_precios.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.ShowDialog();
            sIdUsuario = login.obtenerNombreUsuario();
            lbl_id_usuario.Text = sIdUsuario;

        }

        private void CotizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void IngresoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MovimientoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ComisionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void PolizasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void NominasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AyudasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, " AyudasVentas/Ayudas_Ventas.chm", "indexaaaa.html");//Abre el menu de ayuda HTML
        }
    }
}
