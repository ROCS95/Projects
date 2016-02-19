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
    public partial class Form3 : Form
    {
        public string Nombre
        {
            set
            {
                label12.Text = value;
            }
        }
        public string Calle
        {
            get
            {
                return textBox6.Text;
            }
        }
        public string Colonia
        {
            get
            {
                return textBox3.Text;
            }
        }
        public string Delegación
        {
            get
            {
                return textBox2.Text;
            }
        }
        public string CódigoPostal
        {
            get
            {
                return textBox4.Text;
            }
        }
        public string Teléfono
        {
            get
            {
                return textBox5.Text;
            }
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
