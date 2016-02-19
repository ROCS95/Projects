using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formscall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 acercaDe = new Form2();
            acercaDe.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 data = new Form3();
            data.Nombre = textBox1.Text;
            data.ShowDialog();
            label2.Text = "Calle: " + data.Calle;
            label3.Text = "Colonia: " + data.Colonia;
            label4.Text = "Delegación: " + data.Delegación;
            label5.Text = "Código Postal " + data.CódigoPostal;
            label6.Text = "Teléfono " + data.Teléfono;
        }
    }
}
