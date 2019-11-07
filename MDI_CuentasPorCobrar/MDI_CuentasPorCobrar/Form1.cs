using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_CuentasPorCobrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes form_clientes = new Clientes();
            form_clientes.MdiParent = this;
            form_clientes.Show();
        }

        private void TipoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_Clientes form_tipo_clientes = new Tipo_Clientes();
            form_tipo_clientes.MdiParent = this;
            form_tipo_clientes.Show();
        }

        private void VendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_Movimiento form_tipo_movimiento = new Tipo_Movimiento();
            form_tipo_movimiento.MdiParent = this;
            form_tipo_movimiento.Show();
        }

        private void TipoPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_Pagos form_tipo_pagos = new Tipo_Pagos();
            form_tipo_pagos.MdiParent = this;
            form_tipo_pagos.Show();
        }
    }
}
