using Puzzle.BO;
using Puzzle.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle.GUI
{
    public partial class Form2 : Form
    {
        UsuarioBO ubo;
        ImagenBO ibo;
        int idImagen;
        byte[] binData;
        public Form2()
        {
            InitializeComponent();
            lvlfoto.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ubo = new UsuarioBO();
            ibo = new ImagenBO();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario()
            {
                User = txtUser.Text.Trim(),
                Contrasenia = txtPw.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
            };
            ibo.InsertImagen(binData);
            ubo.InsertUsuario(u);
            Form1 log = new Form1();
            log.Show();
            this.Hide();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Carga la imagen dentro del cuadro picture box.
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                    // Muestra el nombre del archivo en el titulo de forma this.Text = string.Concat("Visor de Imagenes(" + openFileDialog1.FileName + ")");
                    this.lvlfoto.Text = string.Concat(openFileDialog1.FileName);

                    FileStream stream = new FileStream(lvlfoto.Text, FileMode.Open, FileAccess.Read);
                    //Se inicailiza un flujo de archivo con la imagen seleccionada desde el disco.
                    BinaryReader br = new BinaryReader(stream);
                    FileInfo fi = new FileInfo(lvlfoto.Text);

                    //Se inicializa un arreglo de Bytes del tamaño de la imagen
                    binData = new byte[stream.Length];
                    //Se almacena en el arreglo de bytes la informacion que se obtiene del flujo de archivos(foto)
                    //Lee el bloque de bytes del flujo y escribe los datos en un búfer dado.
                    stream.Read(binData, 0, Convert.ToInt32(stream.Length));

                    ////Se muetra la imagen obtenida desde el flujo de datos
                    pictureBox1.Image = Image.FromStream(stream);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
