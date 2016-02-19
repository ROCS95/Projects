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
    public partial class Form2 : Form
    {
        UsuarioBO ubo;
        public Form2()
        {
            InitializeComponent();
            lvlfoto.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           ubo = new UsuarioBO();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario()
            {
                User = txtUser.Text.Trim(),
                Contrasenia = txtPw.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
            };
          u = ubo.InsertUsuario(u);
            Form1 log = new Form1();
            log.Show();
            this.Hide();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Carga la imagen dentro del cuadro picture box.
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                // Muestra el nombre del archivo en el titulo de forma this.Text = string.Concat("Visor de Imagenes(" + openFileDialog1.FileName + ")");
                this.lvlfoto.Text = string.Concat(openFileDialog1.FileName);
            }
        }
    }
}
