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
    public partial class FrmNuevoJuego : Form
    {

        private DimensionBO dbo;
        private CategoriaBO cbo;
        private JuegoBO jbo;

        public FrmNuevoJuego()
        {
            InitializeComponent();
        }

        private void FrmNuevoJuego_Load(object sender, EventArgs e)
        {
            try
            {
                lblMensaje.Text = "";
                jbo = new JuegoBO();
                dbo = new DimensionBO();
                cbo = new CategoriaBO();
                cbxDimenciones.DataSource = dbo.CargarDimensiones();
                cbxCategorias.DataSource = cbo.CargarCategorias().ToArray<Categoria>();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message.Replace("[0-9]*", "");
            }
        }

        private void pbxImgenJuego_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensaje.Text = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pbxImgenJuego.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmNuevoJuego_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            
            try
            {
                lblMensaje.Text = "";
                Imagen i = new Imagen()
                {
                    Foto = pbxImgenJuego.Image
                };
                Juego j = new Juego()
                {
                    Dimension = (Dimension)cbxDimenciones.SelectedItem,
                    Categoria = (Categoria)cbxCategorias.SelectedItem,
                    Descripcion = tbxDescripcion.Text,
                    Imagen = i,
                    FechaInicio = dtpInicio.Value,
                    FechaFinal = dtpFinal.Value
                };

                if (jbo.RegistrarJuego(j))
                {
                    MessageBox.Show("Nuevo juego creado con éxito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Problemas al crear el nuevo juego");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                string pattern = "[0-9]*:";
                Regex rgx = new Regex(pattern);
                lblMensaje.Text = rgx.Replace(ex.Message, "");
            }
        }
    }
}
