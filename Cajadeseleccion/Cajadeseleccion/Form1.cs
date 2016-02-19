using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajadeseleccion
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

        private void negrita_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily,
            this.label1.Font.Size, this.label1.Font.Style ^ FontStyle.Bold);
        }

        private void Consolas_CheckedChanged(object sender, EventArgs e)
        {
            FontFamily csl = new FontFamily("Consolas");
            this.label1.Font = new Font(csl, this.label1.Font.Size,
            this.label1.Font.Style);
        }

        private void Ocho_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily, 8,
            this.label1.Font.Style);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            FontFamily mss = new FontFamily("Microsoft Sans Serif");
            this.label1.Font = new Font(mss, 12, FontStyle.Regular);
        }
    }
}
