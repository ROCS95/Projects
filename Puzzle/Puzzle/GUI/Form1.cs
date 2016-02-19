using Puzzle.BO;
using Puzzle.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle.GUI
{
    public partial class Form1 : Form
    {
        UsuarioBO ubo;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario()
            {
                User = txtUs.Text.Trim(),
                Contrasenia = txtPas.Text.Trim(),
        };
            u = ubo.AutentificarseUsuario(u);
            if (u.Id > 0)
            {
                MiCuenta mi = new MiCuenta(u);
            }
            else {
                label1.Text = "DATOS INCORRECTOS";
            }
    }

        private void Form1_Load(object sender, EventArgs e)
        {
            ubo = new UsuarioBO();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnRegi_Click(object sender, EventArgs e)
        {
            Form2 reg = new Form2();
            reg.Show();
            this.Hide();
        }
    }
}

