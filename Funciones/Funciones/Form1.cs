using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funciones
{
    public partial class Form1 : Form
    {
        private int n;
        private int a;
        private String valueText;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEND_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            textEntrada.Clear();
            textSalida.Clear();
            valueText = "";
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            n = int.Parse(textEntrada.Text);
            for (int i = 0; i <= 9; i++)
            {
                a = n * i;
                valueText = valueText + a.ToString() + "  ";
                textSalida.Text = valueText;
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            n = int.Parse(textEntrada.Text);
            for (int i = 1; i <= n; i++)
            {
                double b = Math.IEEERemainder(n, i);
                if (b == 0)
                {
                    valueText = valueText + i.ToString() + "  ";
                    textSalida.Text = valueText;
                }
            }
        }

        private void buttonSerie_Click(object sender, EventArgs e)
        {
            n = int.Parse(textEntrada.Text);
            for (int i = 1; i <= n; i++)
            {
                double b = Math.Pow(i, 2);
                valueText = valueText + b.ToString() + "  ";
                textSalida.Text = valueText;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = 1;
            n = int.Parse(textEntrada.Text);
            for (int i = 1; i <= n; i++)
            {
                a = a * i;
            }
            valueText = valueText + a.ToString();
            textSalida.Text = valueText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = 0;
            int b = 1;
            int z = 0;
            n = int.Parse(textEntrada.Text);
            valueText = valueText + b.ToString() + "  ";
            textSalida.Text = valueText;
            for (int i = 1; i < n; i++)
            {
                z = a;
                a = b;
                b = z + a;
                valueText = valueText + b.ToString() + "  ";
                textSalida.Text = valueText;
            }
        }
        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
