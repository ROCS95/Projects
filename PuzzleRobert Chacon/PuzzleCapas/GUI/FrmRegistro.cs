using PuzzleCapas.BO;
using PuzzleCapas.Entidades;
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

namespace PuzzleCapas.GUI
{
    public partial class FrmRegistro : Form
    {
        private ParticipanteBO pbo;
        private DimensionBO dbo;
        private CategoriaBO cbo;

        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void FrmRegistro_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
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
                Participante p = new Participante()
                {
                    Usuario = txtUsuario.Text.Trim(),
                    Contrasena = txtContrasena.Text.Trim(),
                    Nombre = txtNombreCompleto.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    Dimension = (Dimension)cbxDimension.SelectedItem,
                    Imagen = i,
                    Categorias = categorias
                };

                if (pbo.Registrar(p, txtContrasenaDos.Text.Trim()))
                {
                    MessageBox.Show("Usuario registrado con éxito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Problemas al registra el usuario");
                }
            }
            catch (Exception ex)
            {
                string pattern = "[0-9]*:";
                Regex rgx = new Regex(pattern);
                lblMensaje.Text = rgx.Replace(ex.Message, "");
            }
        }


        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            try
            {
                lblMensaje.Text = "";
                pbo = new ParticipanteBO();
                dbo = new DimensionBO();
                cbo = new CategoriaBO();
                cbxDimension.DataSource = dbo.CargarDimensiones();
                chbCategorias.Items.AddRange(cbo.CargarCategorias().ToArray<Categoria>());
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message.Replace("[0-9]*", "");
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
    }
}
