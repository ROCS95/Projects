using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear(); dataGridView2.Columns.Clear(); dataGridView3.Columns.Clear();
            int tam = int.Parse(textBox1.Text);
            int i = 1;
            while (i <= tam)
            {
                DataGridViewColumn columna = new DataGridViewColumn(new DataGridViewTextBoxCell());
                columna.Width = 25; //ancho
                this.dataGridView1.Columns.Add(columna);
                DataGridViewColumn columna2 = new DataGridViewColumn(new DataGridViewTextBoxCell());
                columna2.Width = 25;
                this.dataGridView2.Columns.Add(columna2);
                DataGridViewColumn columna3 = new DataGridViewColumn(new DataGridViewTextBoxCell());
                columna3.Width = 25;
                this.dataGridView3.Columns.Add(columna3);
                i++;
            }
            int[,] _matriz1 = new int[tam, tam]; // se declaran variables de tipo matriz
            int[,] _matriz2 = new int[tam, tam]; int[,] _matriz3 = new int[tam, tam];
            dataGridView1.Rows.Add(tam); dataGridView2.Rows.Add(tam); dataGridView3.Rows.Add(tam);
            Random r = new Random();
            // genera un dato de manera aleatoria, se utiliza para revolver los datos llena los datos de las casillas vacias.
            for (int f = 0; f < tam; f++)
            {
                for (int c = 0; c < tam; c++)
                {
                    _matriz1[f, c] = r.Next(10); // valor inicial que agarra valores del 0 al 10
                    _matriz2[f, c] = r.Next(10);
                    _matriz3[f, c] = 0;
                    dataGridView1[f, c].Value = _matriz1[f, c]; // se agrega filas y colmnas
                    dataGridView2[f, c].Value = _matriz2[f, c]; dataGridView3[f, c].Value = _matriz3[f, c];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tam = int.Parse(textBox1.Text);
            int[,] _matriz1 = new int[tam, tam]; int[,] _matriz2 = new int[tam, tam]; int[,] _matriz3 = new int[tam, tam];
            for (int f = 0; f < tam; f++) // filas
            {
                for (int c = 0; c < tam; c++) //columnas
                {
                    _matriz1[f, c] = int.Parse(dataGridView1[f, c].Value.ToString()); // almacena
                    _matriz2[f, c] = int.Parse(dataGridView2[f, c].Value.ToString());
                    _matriz3[f, c] = _matriz1[f, c] + _matriz2[f, c];
                    dataGridView3.CurrentCell = dataGridView3[f, c];
                    dataGridView3.CurrentCell.Value = _matriz3[f, c];
                }
            }
        }
    }
}
