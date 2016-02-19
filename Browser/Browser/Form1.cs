using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            webBrowser1.GoHome();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(comboBox1.SelectedItem.ToString());
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Opción del Menú Home o Página Principal
            webBrowser1.GoHome();
        }

        private void adelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Opción del Menú Adelante
            webBrowser1.GoForward();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Opción del Menú Atras
            webBrowser1.GoBack();
        }
    }
}
