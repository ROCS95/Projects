using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dados
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            int num = NumeroApostado();
            if (num >= 1 && num <= 12)
            {
                tirarDado(num);
                txtNum.Text = "";
            }
            else
            {
                lblError.Text = "No se a bruto son numeros de 1 al 12.";
            }
        }

        private void tirarDado(int num)
        {
            lblError.Text = "";
            int diceone = rnd.Next(1, 7);   // creates a number between 1 and 6
            int dicetwo = rnd.Next(1, 7);   // creates a number between 1 and 6
            dados(diceone, dicetwo);
            int total = diceone + dicetwo;
            if (total == num)
            {
                cambiarPuntos(true);
            }
            else
            {
                cambiarPuntos(false);
            }
        }

        private void dados(int diceone, int dicetwo)
        {
            switch (diceone)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources._1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources._2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources._3;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources._4;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources._5;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources._6;
                    break;
            }
            switch (dicetwo)
            {
                case 1:
                    pictureBox2.Image = Properties.Resources._1;
                    break;
                case 2:
                    pictureBox2.Image = Properties.Resources._2;
                    break;
                case 3:
                    pictureBox2.Image = Properties.Resources._3;
                    break;
                case 4:
                    pictureBox2.Image = Properties.Resources._4;
                    break;
                case 5:
                    pictureBox2.Image = Properties.Resources._5;
                    break;
                case 6:
                    pictureBox2.Image = Properties.Resources._6;
                    break;
            }

        }

        private void cambiarPuntos(bool gana)
        {
            if (gana)
            {
                lblPuntos.Text = int.Parse(lblPuntos.Text) + 1 + "";
            }
            else
            {
                lblPuntos.Text = int.Parse(lblPuntos.Text) - 1 + "";
            }
        }

        private int NumeroApostado()
        {
            int num = -1;
            int.TryParse(txtNum.Text, out num);
            return num;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text != "")
            {
                DialogResult result = MessageBox.Show("Nombre: " + TxtNombre.Text + "\n Puntuacion: " + lblPuntos.Text, "Puntuacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblError.Text = "";
                compararPuntos();
            }
            else
            {
                lblError.Text = "Tiene que ingresar su nombre.";
            }
        }

        private void compararPuntos()
        {
            bool entra = true;
            if (int.Parse(lblPuntos.Text) > int.Parse(lbl11.Text) && entra)
            {
                lbl1.Text = TxtNombre.Text;
                lbl11.Text = lblPuntos.Text;
                entra = false;
            }
            if (int.Parse(lblPuntos.Text) > int.Parse(lbl22.Text) && entra)
            {
                lbl2.Text = TxtNombre.Text;
                lbl22.Text = lblPuntos.Text;
                entra = false;
            }
            if (int.Parse(lblPuntos.Text) > int.Parse(lbl33.Text) && entra)
            {
                lbl3.Text = TxtNombre.Text;
                lbl33.Text = lblPuntos.Text;
                entra = false;
            }
            if (int.Parse(lblPuntos.Text) > int.Parse(lbl44.Text) && entra)
            {
                lbl4.Text = TxtNombre.Text;
                lbl44.Text = lblPuntos.Text;
                entra = false;
            }
            if (int.Parse(lblPuntos.Text) > int.Parse(lbl55.Text) && entra)
            {
                lbl5.Text = TxtNombre.Text;
                lbl55.Text = lblPuntos.Text;
                entra = false;
            }
            lblPuntos.Text = "0";
            TxtNombre.Text = "";
        }
    }
}
