using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BO;

namespace GUI
{
    public partial class FrmPuzzle : Form
    {
        private Usuario us;
        private ImagenBO imgBO;
        private UsuarioBO usBO;
        private JuegoBO jgBO;
        private DimensionBO dimBO;
        private PictureBox[,] matPb;

        public FrmPuzzle()
        {
            InitializeComponent();
        }

        public FrmPuzzle(Usuario us)
        {
            this.us = us;
            usBO = new UsuarioBO();
            dimBO = new DimensionBO();
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FrmAdmin frmAd = new FrmAdmin();
            frmAd.Us = us;
            this.Hide();
            frmAd.ShowDialog(this);
        }

        private void FrmPuzzle_Load(object sender, EventArgs e)
        {
            imgBO = new ImagenBO();
            jgBO = new JuegoBO();

            if (us.Tipo == 1)
            {
                btnAdmin.Visible = true;
            }
            else
            {
                btnAdmin.Visible = false;
            }

            us = usBO.ObtenerUsuario(us);
            txtPerfil.Text = (String.Format("Nombre: {0} \n Correo: {1} \n Telefono: {2} \n Usuario: {3}", us.Nombre, us.Correo, us.Telefono, us.User));
            pbImagen.Image = imgBO.ObtImg(us.Foto.Id).Img;

            try
            {
                List<Juego> j = jgBO.ObtJuegosUsuario(us);
                listJuegos.DataSource = j;
            }
            catch (Exception)
            {

                lblMsg.Text = "No tiene juegos disponibles.";
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FrmReg fReg = new FrmReg(us);
            this.Hide();
            fReg.Show(this);
        }

        private void Cerrar(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void listJuegos_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlPuzzle.Controls.Clear();
            try
            {
                Juego jueg = (Juego)listJuegos.SelectedItem;
                pbImgFinal.Image = imgBO.ObtImg(jueg.Imagen.Id).Img;
                string[] dimension = dimBO.ObtDim(jueg.Dimension.Id).Split('x');
                int dim = Int32.Parse(dimension[0]);
                matPb = new PictureBox[dim, dim];
                jgBO.MatrizImg = new Image[dim, dim];
                jgBO.MatrizImgTemp = new Image[dim, dim];

                var imgArray = new Image[dim, dim];
                var img = imgBO.ObtImg(jueg.Imagen.Id).Img;
                int width = img.Width / dim;
                int height = img.Height / dim;

                for (int i = 0; i < dim; i++)
                {
                    for (int j = 0; j < dim; j++)
                    {
                        var index = i * dim + j;
                        imgArray[i, j] = new Bitmap(width, height);
                        var graphics = Graphics.FromImage(imgArray[i, j]);
                        graphics.DrawImage(img, new Rectangle(0, 0, width, height),
                        new Rectangle(i * width, j * height, width, height), GraphicsUnit.Pixel);
                        graphics.Dispose();
                    }
                }
                for (int i = 0; i < dim; i++)
                {
                    for (int j = 0; j < dim; j++)
                    {
                        if (j != dim - 1 || i != dim - 1)
                        {
                            jgBO.MatrizImg[i, j] = imgArray[j, i];
                            jgBO.MatrizImgTemp[i, j] = imgArray[j, i];
                        }
                        else
                        {
                            jgBO.MatrizImg[i, j] = null;
                            jgBO.MatrizImgTemp[i, j] = null;
                        }
                    }
                }
                jgBO.Desordenar();
                int alto = pnlPuzzle.Width / dim;
                int ancho = pnlPuzzle.Height / dim;
                for (int i = 0; i < dim; i++)
                {
                    for (int j = 0; j < dim; j++)
                    {
                        PictureBox test = new PictureBox();
                        test.Width = alto;
                        test.Height = ancho;
                        test.Left = j * ancho;
                        test.Top = i * ancho;
                        test.BorderStyle = BorderStyle.Fixed3D;
                        test.SizeMode = PictureBoxSizeMode.StretchImage;
                        test.Image = jgBO.MatrizImgTemp[i, j];

                        test.Click += Test_Click;
                        test.BringToFront();
                        test.Tag = (i + "," + j);
                        matPb[i, j] = test;
                        pnlPuzzle.Controls.Add(test);
                    }
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
                lblMsg.Text = "Problemas al cargar el puzzle.";
            }

        }

        /// <summary>
        /// Evento que se crea en cada PictureBox agregado
        /// </summary>
        /// <param name="sender">Envia el evento</param>
        /// <param name="e">Recibe Evento</param>
        private void Test_Click(object sender, EventArgs e)
        {
            PictureBox img = (PictureBox)sender;
            string[] tg = img.Tag.ToString().Split(',');
            int x = Convert.ToInt32(tg[0]);
            int y = Convert.ToInt32(tg[1]);
            if (img.Image != null)
            {
                for (int i = 0; i < matPb.GetLength(0); i++)
                {
                    for (int j = 0; j < matPb.GetLength(1); j++)
                    {
                        if (matPb[i, j].Image == null)
                        {
                            if (i == x && ((y + 1 == j) || (y - 1 == j)))
                            {
                                matPb[i, j].Image = img.Image;
                                jgBO.MatrizImgTemp[i, j]= img.Image;
                                matPb[x, y].Image = null;
                                jgBO.MatrizImgTemp[x, y] = null;
                            }
                            if (j == y && ((x + 1 == i) || (x - 1 == i)))
                            {
                                matPb[i, j].Image = img.Image;
                                jgBO.MatrizImgTemp[i, j] = img.Image;
                                matPb[x, y].Image = null;
                                jgBO.MatrizImgTemp[x, y] = null;
                            }
                        }
                    }
                }
            }
            if (jgBO.Estado())
            {
                MessageBox.Show("Ganó");
            }
            pnlPuzzle.Refresh();
        }

    }
}
