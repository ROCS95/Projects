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
        private UsuarioBO uBo;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            uBo = new UsuarioBO();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario()
            {
                User = txtUsuario.Text.Trim(),
                Pass = txtPassword.Text.Trim(),
            };
            us = uBo.AutentificarUsuario(us);
            if (us.Id > 0)
            {
                FrmPuzzle frmP = new FrmPuzzle(us);
                frmP.Show(this);
                this.Hide();
            }
            else
            {
                lblMsg.Text = "Wrong username or password!";
            }
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            FrmReg fReg = new FrmReg(new Usuario());
            this.Hide();
            fReg.ShowDialog(this);
        }

        private void TextReset(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
        }

        private void PassReset(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }
    }
}
