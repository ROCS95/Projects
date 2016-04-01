using BO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace GUI
{
    public partial class FrmJuego : Form
    {
        Point EmptyPoint;
        Image ToBeResize;
        JuegoBO jbo;

        public Participante Participante { get; internal set; }
        public Juego Juegos { get; internal set; }

        public FrmJuego()
        {
            InitializeComponent();
            EmptyPoint.X = 210;
            EmptyPoint.Y = 210;
            jbo = new JuegoBO();
        }

        private void FrmJuego_Load(object sender, EventArgs e)
        {
            ToBeResize = jbo.GetImagen(Juegos);
            AddImagesToButtons(jbo.ReturnCroppedList(jbo.Resize(ToBeResize), 70, 70));
            original_pic.Image = ToBeResize;
        }

        private void stretch_frm_Click(object sender, EventArgs e)
        {
            if (btn_stretch_frm.Text == "<<<")
            {

                btn_stretch_frm.Text = ">>>";
                this.Size = new Size(578, 550);
            }
            else if (btn_stretch_frm.Text == ">>>")
            {

                btn_stretch_frm.Text = "<<<";
                this.Size = new Size(947, 550);

            }
        }

        /// <summary>
        /// metodo para que los botones se muevan
        /// </summary>
        /// <param name="button">sender del metodo click del boton</param>
        private void MoveButton(Button button)
        {
            int x = EmptyPoint.X - button.Location.X;
            int px = x < 0 ? -x : x;

            int y = EmptyPoint.Y - button.Location.Y;
            int py = y < 0 ? -y : y;
            //moving right &left
            if (button.Location.Y.Equals(EmptyPoint.Y) && px.Equals(button.Size.Width))
            {

                button.Location = new Point(button.Location.X + x, button.Location.Y);
                EmptyPoint.X -= x;


            }
            //moving top &botton
            if (button.Location.X.Equals(EmptyPoint.X) && py.Equals(button.Size.Width))
            {
                button.Location = new Point(button.Location.X, button.Location.Y + y);
                EmptyPoint.Y -= y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoveButton((Button)sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MoveButton((Button)sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MoveButton((Button)sender);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MoveButton((Button)sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MoveButton((Button)sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MoveButton((Button)sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MoveButton((Button)sender);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MoveButton((Button)sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MoveButton((Button)sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MoveButton((Button)sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MoveButton((Button)sender);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MoveButton((Button)sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MoveButton((Button)sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MoveButton((Button)sender);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MoveButton((Button)sender);
        }

        /// <summary>
        /// Anade las imagenes al los botones
        /// </summary>
        /// <param name="pieces">array con lass piesas de la imagen</param>
        public void AddImagesToButtons(ArrayList pieces)
        {
            int x = 0;
            int[] c = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            jbo.Shuffle(c);

            foreach (Button b in butns_container.Controls)
            {
                if (x < c.Length)
                {
                    b.Image = (Image)pieces[c[x]];
                    x++;
                }
            }


        }

        private void FrmJuego_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
