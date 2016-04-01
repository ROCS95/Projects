using BO;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class EditarUsuario : Form
    {

        private ParticipanteBO pbo;
        private DimensionBO dbo;
        private CategoriaBO cbo;

        public Participante Participante { get; internal set; }
        public int IdImage { get; internal set; }

        public EditarUsuario()
        {
            InitializeComponent();
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                lblMensaje.Text = "";
                pbo = new ParticipanteBO();
                dbo = new DimensionBO();
                cbo = new CategoriaBO();
                txtUsuario.Text = Participante.Usuario;
                txtNombreCompleto.Text = Participante.Nombre;
                txtContrasena.Text = Participante.Contrasena;
                txtContrasenaDos.Text = Participante.Contrasena;
                txtTelefono.Text = Participante.Telefono;
                txtCorreo.Text = Participante.Correo;
                cbxDimension.DataSource = dbo.CargarDimensiones();
                chbCategorias.Items.AddRange(cbo.CargarCategorias().ToArray<Categoria>());
                pbxFoto.Image = Participante.Imagen.Foto;
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message.Replace("[0-9]*", "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensaje.Text = "";
                List<Categoria> categorias = new List<Categoria>();

                foreach (Categoria cat in chbCategorias.CheckedItems)
                {
                    categorias.Add(cat);
                }
                Imagen i = new Imagen()
                {
                    Foto = pbxFoto.Image
                };
                Participante.Usuario = txtUsuario.Text.Trim();
                Participante.Contrasena = txtContrasena.Text.Trim();
                Participante.Nombre = txtNombreCompleto.Text.Trim();
                Participante.Telefono = txtTelefono.Text.Trim();
                Participante.Correo = txtCorreo.Text.Trim();
                Participante.Dimension = (Dimension)cbxDimension.SelectedItem;
                Participante.Imagen = i;
                Participante.Imagen.Id = IdImage;
                Participante.Categorias = categorias;
                

                if (pbo.Editar(Participante, txtContrasenaDos.Text.Trim(), Participante.Id))
                {
                    MessageBox.Show("Usuario Editado con éxito");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Problemas al Editar el usuario");
                }
            }
            catch (Exception ex)
            {
                string pattern = "[0-9]*:";
                Regex rgx = new Regex(pattern);
                lblMensaje.Text = rgx.Replace(ex.Message, "");
            }
        }

        private void pbxFoto_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensaje.Text = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pbxFoto.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        private void EditarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
