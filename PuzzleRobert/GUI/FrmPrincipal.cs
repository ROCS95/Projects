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
    public partial class FrmPrincipal : Form
    {
        int admin;
        public Participante Participante { get; set; }
        public Juego Juegos { get; set; }
        public int IdImagen { get; internal set; }
        JuegoBO jbo;

        public FrmPrincipal()
        {
            InitializeComponent();
            jbo = new JuegoBO();
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
                btninsertcat.Visible = true;
                btninsertdim.Visible = true;
                CargarCategorias();
                CargarDimenciones();
                btnPublicar.Visible = true;
            }
            else
            {
                btnNuevoJuego.Text = "Jugar";
                dgvJuegos.Visible = true;
                Cargarjuegos(Participante);
                cbxjuegos.Visible = true;
                Cargarcombox(Participante);
            }
        }

        private void Cargarcombox(Participante participante)
        {
            cbxjuegos.Items.AddRange(jbo.Cargarcombox(participante).ToArray<Juego>());
        }

        private void Cargarjuegos(Participante Participante)
        {
            dgvJuegos.DataSource = jbo.Cargarjuegos(Participante);
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EditarUsuario ed = new EditarUsuario()
            {
                Participante = this.Participante,
                IdImage = this.IdImagen
            };
            if (ed.ShowDialog(this) == DialogResult.OK)
            {
                ParticipanteBO pbo = new ParticipanteBO();
                //Refrescar los datos del usuarios en el cuadro de texto
                pbo.RefrescarUsuario(Participante);
                lblNombre.Text = this.Participante.Nombre;
                pictureBox1.Image = this.Participante.Imagen != null ? this.Participante.Imagen.Foto : null;
                lblUsuario.Text = this.Participante.Usuario;
                if (Participante.TipoUsuario == 2)
                {
                    Cargarjuegos(Participante);
                    cbxjuegos.Items.Clear();
                    Cargarcombox(Participante);
                }

            }

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
            CategoriaBO catbo = new CategoriaBO();
            categorias = catbo.CargarCategorias();
            listBox1.DisplayMember = "Categoria";

            listBox1.DataSource = categorias;
        }

        /// <summary>
        /// si el usuario es un administrador carga las dimenciones en el listBox2
        /// </summary>
        public void CargarDimenciones()
        {
            List<Dimension> dimenciones = new List<Dimension>();
            DimensionBO dimbo = new DimensionBO();
            dimenciones = dimbo.CargarDimensiones();
            listBox2.DisplayMember = "Dimension, ID";

            listBox2.DataSource = dimenciones;
        }

        private void btninsertcat_Click(object sender, EventArgs e)
        {
            Participante.TipoUsuario = 1;
            Mantenimiento man = new Mantenimiento()
            {
                Admin = Participante.TipoUsuario
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

        private void btnNuevoJuego_Click(object sender, EventArgs e)
        {
            if (Participante.TipoUsuario == 1)
            {
                FrmNuevoJuego nj = new FrmNuevoJuego();
                nj.Show(this);
                this.Hide();
            }
            else
            {
                Juegos = (Juego)cbxjuegos.SelectedItem;
                if (Juegos != null)
                {
                    FrmJuego jue = new FrmJuego()
                    {
                        Participante = Participante,
                        Juegos = Juegos
                    };
                    this.Hide();
                    jue.Show(this);
                }
                else
                {
                    lblMensaje.Text = "Seleccione un juego";
                }
            }

        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            FrmPublicar pub = new FrmPublicar();
            pub.Show(this);
            this.Hide();
        }
    }
}
