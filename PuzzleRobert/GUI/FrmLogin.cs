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
    public partial class FrmLogin : Form
    {
        private ParticipanteBO ubo;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            ubo = new ParticipanteBO();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Participante p = new Participante()
            {
                Usuario = txtUsuario.Text,
                Contrasena = txtContrasena.Text
            };

            p = ubo.Autentificiar(p);
            if (p.Id > 0)
            {
                int j = p.Imagen.Id;
                p.Contrasena = txtContrasena.Text;
                FrmPrincipal prin = new FrmPrincipal()
                {
                    Participante = p,
                    IdImagen = j
                };
                prin.Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("No entro");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistro registro = new FrmRegistro();
            registro.Show(this);
            this.Hide();
        }
    }
}
