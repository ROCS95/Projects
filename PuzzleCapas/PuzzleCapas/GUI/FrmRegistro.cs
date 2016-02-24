using PuzzleCapas.BO;
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
            try
            {
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
                MessageBox.Show(ex.Message);
            }
        }


        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            pbo = new ParticipanteBO();
            dbo = new DimensionBO();
            cbo = new CategoriaBO();
            cbxDimension.DataSource = dbo.CargarDimensiones();
            chbCategorias.Items.AddRange(cbo.CargarCategorias().ToArray<Categoria>());
            Participante p = new Participante();
            foreach (Categoria item in p.Categorias)
            {
                int index = chbCategorias.Items.IndexOf(item);
                if (index >= 0)
                {
                    chbCategorias.SetItemChecked(index, true);
                }
            }

        }

        private void pbxFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbxFoto.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
