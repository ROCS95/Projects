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
    public partial class MiCuenta : Form
    {
        UsuarioBO ubo;
        ImagenBO ibo;
        private Usuario us;
        private Image imagen;

        public MiCuenta(Usuario us)
        {
            this.us = us;
        }

        private void MiCuenta_Load(object sender, EventArgs e)
        {
            ubo = new UsuarioBO();
            ibo = new ImagenBO();
            Cargar();
        }

        private void Cargar()
        {
            Usuario u = new Usuario();
            u = ubo.CargarUser(us);
            imagen = ibo.CagarImagen(u);
        }
    }
}
