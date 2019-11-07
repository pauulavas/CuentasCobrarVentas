using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_VentasyCtasPorCobrar
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void FacturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Facturacion form_Facturacion = new Form_Facturacion();
            form_Facturacion.MdiParent = this;
            form_Facturacion.Show();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            
        }

        private void ImpuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Impuesto form_impuesto = new Impuesto();
            form_impuesto.MdiParent = this;
            form_impuesto.Show();
        }

        private void PagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipos_Pagos form_tipos_pagos = new Tipos_Pagos();
            form_tipos_pagos.MdiParent = this;
            form_tipos_pagos.Show();
        }

        private void ReembolsoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Reembolsos form_reembolsos = new Reembolsos();
           // form_reembolsos.MdiParent = this;
           // form_reembolsos.Show();
        }

        private void ComisionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Comisiones form_comisiones = new Comisiones();
            form_comisiones.MdiParent = this;
            form_comisiones.Show();
        }

        private void TipoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_Clientes form_tipo_cliente = new Tipo_Clientes();
            form_tipo_cliente.MdiParent = this;
            form_tipo_cliente.Show();
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente form_cliente = new Cliente();
            form_cliente.MdiParent = this;
            form_cliente.Show();
        }

        private void TipoFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_Factura form_tipo_factura = new Tipo_Factura();
            form_tipo_factura.MdiParent = this;
            form_tipo_factura.Show();
        }

        private void ImpuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Descuentos form_descuentos = new Descuentos();
            form_descuentos.MdiParent = this;
            form_descuentos.Show();
        }

        private void SerieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serie form_serie = new Serie();
            form_serie.MdiParent = this;
            form_serie.Show();
        }

        private void ListaPreciosDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_lista_precio form_lista_precio_detalle = new Tipo_lista_precio();
            form_lista_precio_detalle.MdiParent = this;
            form_lista_precio_detalle.Show();

        }

        private void DescuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Descuentos form_descuentos = new Descuentos();
            form_descuentos.MdiParent = this;
            form_descuentos.Show();
        }

        private void CuentasPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
