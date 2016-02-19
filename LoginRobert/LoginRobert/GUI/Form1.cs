using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginRobert.BO;
using LoginRobert.Entidad;

namespace LoginRobert.GUI
{
    public partial class Form1 : Form
    {

        UsuarioBO ubo = new UsuarioBO();
        User us = new User();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {

        }
    }
}
