using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using WebServiceAllanMurillo.BO;
using WebServiceAllanMurillo.Entidades;
using WebServiceAllanMurillo.WSBanco;

namespace WebServiceAllanMurillo.GUI
{
    public partial class FrmPrincipal : Form
    {
        private Logica log;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            System.Net.ServicePointManager.Expect100Continue = false;
            log = new Logica();
            log.ConsultarTipoCambio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toCRC.Text = log.ToColones(Decimal.Parse(fromUSD.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toUSD.Text = log.ToDolares(Decimal.Parse(fromCRC.Text)).ToString();
        }
    }
}
