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
    public partial class FrmAdmin : Form
    {
        private DimensionBO dimBO;
        private CategoriaBO catBO;
        private JuegoBO jgBO;
        private Imagen img;
        private int tipo;
        public Usuario Us { get; set; }

        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            catBO = new CategoriaBO();
            dimBO = new DimensionBO();
            img = new Imagen();
            jgBO = new JuegoBO();
            cbCatJ.DataSource = catBO.ObtCat();
            cbDimJ.DataSource = dimBO.ObtDim(); 
            pnlJuego.Visible = false;
            pnlEditar.Visible = false;
            pnlVerJuegos.Visible =false;
            dtInicio.Value = DateTime.Today;
            dtFin.Value = DateTime.Today;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tipo == 1)
                {
                    string texto = txtAgregar.Text;
                    if (!String.IsNullOrEmpty(texto))
                    {
                        Categoria c = new Categoria() { Categ = texto };
                        catBO.Insertar(c);
                        listEditar.DataSource = catBO.ObtCat();
                    }
                    else
                    {
                        lblMsg.Text = "Debe ingresar una categoría";
                    }
                }
                else if (tipo == 2)
                {
                    string texto = txtAgregar.Text;
                    if (!String.IsNullOrEmpty(texto))
                    {
                        int x;
                        if (Int32.TryParse(texto, out x))
                        {
                            texto = x + "x" + x;
                            Dimension d = new Dimension() { Dim = texto };
                            dimBO.Insertar(d);
                            listEditar.DataSource = dimBO.ObtDim();
                        }
                        else
                        {
                            lblMsg.Text = "Solo puede ingresar valores númericos";
                        }
                    }
                    else
                    {
                        lblMsg.Text = "Debe ingresar una Dimensión";
                    }
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tipo == 1)
                {
                    Categoria cat = (Categoria)listEditar.SelectedItem;
                    if (catBO.BorrarCat(cat.Id))
                    {
                        listEditar.DataSource = catBO.ObtCat();
                    }
                    else
                    {
                        lblMsg.Text = "Error a la hora de borrar categoría";
                    }
                }
                else if (tipo == 2)
                {
                    Dimension dim = (Dimension)listEditar.SelectedItem;
                    if (dimBO.BorrarDim(dim.Id))
                    {
                        listEditar.DataSource = dimBO.ObtDim();
                    }
                    else
                    {
                        lblMsg.Text = "Error a la hora de borrar dimension";
                    }
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }

        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlEditar.Visible = true;
            pnlVerJuegos.Visible = false;
            pnlJuego.Visible = false;
            tipo = 1;
            catBO = new CategoriaBO();
            listEditar.DataSource = catBO.ObtCat();
        }

        private void dimensionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlEditar.Visible = true;
            pnlVerJuegos.Visible = false;
            pnlJuego.Visible = false;
            tipo = 2;
            dimBO = new DimensionBO();
            listEditar.DataSource = dimBO.ObtDim();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Juego juego = new Juego()
            {
                Categoria = (Categoria)cbCatJ.SelectedItem,
                Dimension = (Dimension)cbDimJ.SelectedItem,
                Descripcion = txtEvento.Text,
                Fecha_inicio = dtInicio.Value,
                Fecha_fin = dtFin.Value,
                Imagen = img,
                Estado = false
            };
            try
            {
                jgBO.InsertarJuego(juego);
                juego = new Juego();
                txtEvento.Text = "";
                pbFoto.Image = null;
                lblMsgJuego.Text = "Juego registrado con exito.";
            }
            catch (Exception ex)
            {
                lblMsgJuego.Text = ex.Message;
            }
        }
    
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pbFoto.Image = Image.FromFile(openFileDialog1.FileName);  
                    Bitmap obB = new Bitmap(pbFoto.Image, new Size(400, 400));
                    img.Img = obB;
                }
            }
            catch (Exception ex)
            {
                lblMsgJuego.Text = ex.Message;
            }
        }

        private void juegoNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlJuego.Visible = true;
            pnlEditar.Visible = false;
            pnlVerJuegos.Visible = false;
        }

        private void verJuegosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlJuego.Visible = false;
            pnlEditar.Visible = false;
            pnlVerJuegos.Visible = true;
            lblMsgVerJ.Text = "";
            jgBO = new JuegoBO();
            listJuegos.DataSource = jgBO.ObtJuegos();
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            try
            {
                Juego jg = (Juego)listJuegos.SelectedItem;
                jgBO.PublicarJuego(jg);
                listJuegos.DataSource = jgBO.ObtJuegos();
                lblMsgVerJ.Text = "Se publicó con exito.";
                this.Owner = new FrmPuzzle(Us);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }
    }
}
