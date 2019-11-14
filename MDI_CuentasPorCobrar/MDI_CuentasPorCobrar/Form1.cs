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

namespace MDI_CuentasPorCobrar
{
    public partial class Form1 : Form
    {
        string sIdUsuario;
        public Form1()
        {
            InitializeComponent();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes form_clientes = new Clientes(sIdUsuario);
            form_clientes.MdiParent = this;
            form_clientes.Show();
        }

        private void TipoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_Clientes form_tipo_clientes = new Tipo_Clientes(sIdUsuario);
            form_tipo_clientes.MdiParent = this;
            form_tipo_clientes.Show();
        }

        private void VendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_Movimiento form_tipo_movimiento = new Tipo_Movimiento(sIdUsuario);
            form_tipo_movimiento.MdiParent = this;
            form_tipo_movimiento.Show();
        }

        private void TipoPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_Pagos form_tipo_pagos = new Tipo_Pagos(sIdUsuario);
            form_tipo_pagos.MdiParent = this;
            form_tipo_pagos.Show();
        }

        private void MovimientoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Movimientos fmMovimientos = new frm_Movimientos();
            fmMovimientos.MdiParent = this;
            fmMovimientos.Show();
        }

        private void CuentasPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PolizasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.ShowDialog();
            sIdUsuario = login.obtenerNombreUsuario();
            lbl_id_usuario.Text = sIdUsuario;

        }
    }
}
