
using BO;
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
    public partial class Mantenimiento : Form
    {
        CategoriaBO catbo;
        DimensionBO dimbo;

        public Mantenimiento()
        {
            InitializeComponent();
            catbo = new CategoriaBO();
            dimbo = new DimensionBO();
        }

        public int Admin { get; internal set; }

        private void Mantenimiento_Load(object sender, EventArgs e)
        {
            if (Admin == 1)
            {
                label1.Text = "Categoria";
                label2.Visible = false;
                textBox2.Visible = false;
            }
            else
            {
                label1.Text = "Dimencion";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Admin == 1)
            {
                if (textBox1.Text != "")
                {
                    catbo.InsertCategoria(textBox1.Text);
                    this.Close();
                }
                else
                {
                    lblMensaje.Text = "No se puede guardar una categoria sin nombre";
                }

            }
            else
            {
                if (textBox1.Text != "" || textBox2.Text != "")
                {
                    if (textBox1.Text != textBox2.Text)
                    {
                        lblMensaje.Text = "Deve ser una dimencion cuadrada";
                    }
                    else
                    {
                    dimbo.InsertDimencion(textBox1.Text, textBox2.Text);
                        this.Close();

                    }
                }
                else
                {
                    lblMensaje.Text = "Por favor no deje espacios en blaco";
                }

            }
        }


        private void Mantenimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
