using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElUltimo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Muestra la fecha seleccionada:
            MessageBox.Show("Has seleccionado la fecha: " + dateTimePicker1.Value.Date);
            // Muestra la fecha de hoy:
            MessageBox.Show("Hoy es: " + DateTime.Now);
        }
    }
}
