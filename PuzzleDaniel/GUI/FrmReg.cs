using BO;
using Entidades;
using GUI.Properties;
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
    public partial class FrmReg : Form
    {
        private Usuario us;
        private int idImgUs;
        private UsuarioBO usBO;
        private Imagen img;
        private ImagenBO imgB;
        private DimensionBO dimBO;
        private CategoriaBO catBO;

        public FrmReg()
        {
            InitializeComponent();
        }

        public FrmReg(Usuario us)
        {
            InitializeComponent();
            this.us = us;
        }

        private void FrmReg_Load(object sender, EventArgs e)
        {
            dimBO = new DimensionBO();
            usBO = new UsuarioBO();
            catBO = new CategoriaBO();
            img = new Imagen();
            imgB = new ImagenBO();
            idImgUs = us.Foto.Id;
            ObtDatos();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            bool tipo = false;
            try
            {
                lblMsg.Text = "";
                List<Categoria> categorias = new List<Categoria>();

                foreach (Categoria cat in checkListCat.CheckedItems)
                {
                    categorias.Add(cat);
                }
                Dimension dim = (Dimension)cbDimension.SelectedItem;
                dim.Id = dim.Id;
                us = usBO.ValidarUs(txtNombre.Text, txtCorreo.Text, txtTel.Text, txtUsuario.Text, txtPass.Text, dim, us.Foto, categorias, us.Id, us.Tipo);
                if (txtPass.Text != txtPass2.Text)
                {
                    lblMsg.Text = "Contraseñas no son iguales";
                }
                else if (String.IsNullOrEmpty(us.Nombre))
                {
                    lblMsg.Text = "No puede dejar campos vacíos";
                }
                else if (categorias.Count <= 0)
                {
                    lblMsg.Text = "Debe seleccionar una categoría";
                }
                else
                {
                    if (us.Foto.Img == null)
                    {
                        us.Foto = imgB.ObtImg(us.Foto.Id);
                    }
                    if (us.Id > 0)
                    {
                        tipo = true;
                    }
                    Usuario usTemp = usBO.RegistrarUsuario(us, idImgUs);
                    if (usTemp.Id > 0)
                    {
                        if (tipo)
                        {
                            MessageBox.Show("Actualizado con éxito");
                            this.Owner = new FrmPuzzle(usTemp);
                            idImgUs = us.Foto.Id;
                            this.Owner.Show();
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Registrado con éxito");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Error a la hora de registrar usuario");
                    }
                }
            }
            catch (Exception)
            {
                lblMsg.Text = "Usuario o correo ya registrados.";
            }
        }

        private void pbFoto_Click(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pbFoto.Image = Image.FromFile(openFileDialog1.FileName);
                    img.Img = pbFoto.Image;
                    us.Foto.Img = img.Img;
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }

        /// <summary>
        /// Método que obtiene los datos si el usuario ya esta registrado
        /// </summary>
        public void ObtDatos()
        {
            cbDimension.DataSource = dimBO.ObtDim();
            checkListCat.Items.AddRange(catBO.ObtCat().ToArray<Categoria>());
            if (us.Id > 0)
            {
                txtNombre.Text = us.Nombre;
                txtCorreo.Text = us.Correo;
                txtPass.Text = us.Pass;
                txtPass2.Text = us.Pass;
                txtTel.Text = us.Telefono;
                txtUsuario.Text = us.User;
                pbFoto.Image = imgB.ObtImg(us.Foto.Id).Img;
                for (int i = 0; i < cbDimension.Items.Count; i++)
                {
                    Dimension dimension = (Dimension)cbDimension.Items[i];
                    if (dimension.Id == us.Dimension.Id)
                    {
                        cbDimension.SelectedIndex = i;
                    }
                }

                List<Categoria> catUsuario = catBO.ObtCatSeleccionada(us);
                for (int i = 0; i < checkListCat.Items.Count; i++)
                {
                    Categoria cat = (Categoria)checkListCat.Items[i];
                    for (int j = 0; j < catUsuario.Count; j++)
                    {
                        if (cat.Id == catUsuario.ElementAt(j).Id)
                        {
                            checkListCat.SetItemChecked(i, true);
                        }
                    }
                }
                btnReg.Text = "Actualizar";
            }
            if (us.Id == 0)
            {
                us.Foto.Img = Resources.users1;
            }
        }

        private void Back(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }
    }
}
