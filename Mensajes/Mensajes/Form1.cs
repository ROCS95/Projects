using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mensajes
{
    public partial class Form1 : Form
    {
        private MessageBoxButtons tipoDeBoton = MessageBoxButtons.OK;
        private MessageBoxIcon tipoDeIcono = MessageBoxIcon.Error;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnvisual_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Mensaje a desplegar", "Título de la Ventana", tipoDeBoton, tipoDeIcono);
            switch (result)
            {
                case DialogResult.OK: lblseleccion.Text = "Seleccionó OK."; break;
                case DialogResult.Cancel: lblseleccion.Text = "Seleccionó Cancel."; break;
                case DialogResult.Yes: lblseleccion.Text = "Seleccionó Yes."; break;
                case DialogResult.No: lblseleccion.Text = "Seleccionó No."; break;
                case DialogResult.Ignore: lblseleccion.Text = "Seleccionó Ignore."; break;
                case DialogResult.Abort: lblseleccion.Text = "Seleccionó Abort."; break;
                case DialogResult.Retry: lblseleccion.Text = "Seleccionó Retry."; break;
            }
        }

        private void tipoboton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == rbtnok)
                tipoDeBoton = MessageBoxButtons.OK;
            else if (sender == rbtnokcan)
                tipoDeBoton = MessageBoxButtons.OKCancel;
            else if (sender == rbtnyesno)
                tipoDeBoton = MessageBoxButtons.YesNo;
            else if (sender == rbtnyesnocan)
                tipoDeBoton = MessageBoxButtons.YesNoCancel;
            else if (sender == rbtnretrycan)
                tipoDeBoton = MessageBoxButtons.RetryCancel;
            else
                tipoDeBoton = MessageBoxButtons.AbortRetryIgnore;
        }

        private void tipoinfo_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == rbtninfo) // display error icon
                tipoDeIcono = MessageBoxIcon.Information;
            else if (sender == rbtnexcl)
                tipoDeIcono = MessageBoxIcon.Exclamation;
            else if (sender == rbtnquest)
                tipoDeIcono = MessageBoxIcon.Question;
            else // only one option left--display question mark
                tipoDeIcono = MessageBoxIcon.Error;
        }
    }
}
