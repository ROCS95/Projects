using BO;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmPublicar : Form
    {
        JuegoBO jbo;
        public FrmPublicar()
        {
            InitializeComponent();
        }

        private void FrmPublicar_Load(object sender, EventArgs e)
        {
            List<Juego> juegos = new List<Juego>();
            jbo = new JuegoBO();
            juegos = jbo.CargarJuegos();
            //listBox1.Items.Add(categorias);
            lbxJuegos.DisplayMember = "descripcion";
            lbxJuegos.DataSource = juegos;
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            Juego j = new Juego();
            j = (Juego)lbxJuegos.SelectedItem;
            jbo.HacerJuegoBublico(j);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPublicar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
