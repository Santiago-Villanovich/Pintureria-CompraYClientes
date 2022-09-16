using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Villanovich_Santiago_TP2_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ingresoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Listado_de_Stock formu = new Listado_de_Stock();
            formu.MdiParent = this;
            formu.Show();
        }

        private void generarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerarCompra formu = new GenerarCompra();
            formu.MdiParent = this;
            formu.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarCliente formu = new IngresarCliente();
            formu.MdiParent = this;
            formu.Show();
        }
    }
}
