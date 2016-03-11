﻿using PuzzleCapas.DAO;
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
        int admin;
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

            if (Participante.TipoUsuario == 1)
            {
                listBox1.Visible = true;
                listBox2.Visible = true;
                btndeletecat.Visible = true;
                btndeletedim.Visible = true;
                btninsertcat.Visible = true;
                btninsertdim.Visible = true;
                CargarCategorias();
                CargarDimenciones();
            }
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

        /// <summary>
        /// si el usuario es un administrador carga las categorias en el listBox1
        /// </summary>
        public void CargarCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();
            CategoriaDAO catdao = new CategoriaDAO();
            categorias = catdao.CargarCategorias();
            //listBox1.Items.Add(categorias);
            listBox1.DisplayMember = "Categoria";

            listBox1.DataSource = categorias;
        }

        /// <summary>
        /// si el usuario es un administrador carga las dimenciones en el listBox2
        /// </summary>
        public void CargarDimenciones()
        {
            List<Dimension> dimenciones = new List<Dimension>();
            DimensionDAO dimdao = new DimensionDAO();
            dimenciones = dimdao.CargarDimensiones();
            //listBox2.Items.Add(categorias);
            listBox2.DisplayMember = "Dimension, ID";

            listBox2.DataSource = dimenciones;
        }

        private void btninsertcat_Click(object sender, EventArgs e)
        {
            admin = 1;
            Mantenimiento man = new Mantenimiento()
            {
                Admin = admin
            };
            man.Show(this);
            if (man.DialogResult == DialogResult.OK)
            {
                CargarCategorias();
            }
        }

        private void btninsertdim_Click(object sender, EventArgs e)
        {
            admin = 2;
            Mantenimiento man = new Mantenimiento()
            {
                Admin = admin
            };
            man.Show(this);
            if (man.DialogResult == DialogResult.OK)
            {
                CargarDimenciones();
            }
        }
    }
}
