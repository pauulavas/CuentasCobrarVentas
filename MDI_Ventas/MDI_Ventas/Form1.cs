using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Ventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TipoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_Clientes form_tipo_clientes = new Tipo_Clientes();
            form_tipo_clientes.MdiParent = this;
            form_tipo_clientes.Show();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes form_clientes = new Clientes();
            form_clientes.MdiParent = this;
            form_clientes.Show();
        }

        private void ImpuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_Impuesto form_tipo_impuesto = new Tipo_Impuesto();
            form_tipo_impuesto.MdiParent = this;
            form_tipo_impuesto.Show();
        }

        private void TipoPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_Pagos form_tipo_pagos = new Tipo_Pagos();
            form_tipo_pagos.MdiParent = this;
            form_tipo_pagos.Show();
        }

        private void ComisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comisiones form_comisiones = new Comisiones();
            form_comisiones.MdiParent = this;
            form_comisiones.Show();
        }

        private void TipoFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_Factura form_tipo_factura = new Tipo_Factura();
            form_tipo_factura.MdiParent = this;
            form_tipo_factura.Show();
        }

        private void SerieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serie form_serie = new Serie();
            form_serie.MdiParent = this;
            form_serie.Show();
        }

        private void FolioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Folio form_folio = new Folio();
            form_folio.MdiParent = this;
            form_folio.Show();
        }

        private void TipoDeListaDePreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_lista_de_precios form_lista_precios = new Tipo_lista_de_precios();
            form_lista_precios.MdiParent = this;
            form_lista_precios.Show();
        }

        private void DescuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_Descuentos form_descuentos = new Tipo_Descuentos();
            form_descuentos.MdiParent = this;
            form_descuentos.Show();
        }
    }
}
