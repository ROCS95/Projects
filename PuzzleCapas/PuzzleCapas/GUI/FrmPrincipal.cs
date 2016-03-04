using PuzzleCapas.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleCapas.GUI
{
    public partial class FrmPrincipal : Form
    {
        public Participante Participante { get; set; }

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblNombre.Text = Participante.Nombre;
            lblUsuario.Text = Participante.Usuario;
            pictureBox1.Image = Participante.Imagen.Foto;
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EditarUsuario ed = new EditarUsuario()
            {
                Participante = this.Participante
            };
            ed.Show(this);

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {
            pictureBox1_Click(sender, e);
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
            pictureBox1_Click(sender, e);
        }
    }
}
