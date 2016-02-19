using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txttemperatura.Text = "";
            txtresultado.Text = "";
        }

        private void btncaf_Click(object sender, EventArgs e)
        {
            double gcentigrados, ct1;
            ct1 = Convert.ToDouble(txttemperatura.Text);
            gcentigrados = (ct1 - 32.0) / 1.8;
            txtresultado.Text = String.Format("{0:F3}", gcentigrados);
        }

        private void btnfac_Click(object sender, EventArgs e)
        {
            double gfarenheit, ct1;
            ct1 = Convert.ToDouble(txttemperatura.Text);
            gfarenheit = ct1 * 1.8 + 32.0;
            txtresultado.Text = String.Format("{0:F3}", gfarenheit);
        }
    }
}
