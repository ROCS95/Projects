using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplicar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            double op1, op2;

            op1 = Convert.ToDouble(txtop1.Text);
            op2 = Convert.ToDouble(txtop2.Text);

            txtresult.Text = String.Format("{0:F2}", op1 * op2);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtop1.Text = "";
            txtop2.Text = "";
            txtresult.Text = "";
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
