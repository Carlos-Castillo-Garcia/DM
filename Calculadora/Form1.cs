using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resultado_Click(object sender, EventArgs e)
        {

        }
        private void restar_Click(object sender, EventArgs e)
        {

        }

        private void sumar_Click(object sender, EventArgs e)
        {

        }

        private void dividir_Click(object sender, EventArgs e)
        {

        }

        private void multiplicar_Click(object sender, EventArgs e)
        {

        }

        private void resetear_Click(object sender, EventArgs e)
        {

        }

        private void uno_Click(object sender, EventArgs e)
        {
            if (label1.Text.Equals(""))
            {
                label1.Text = "1";
            }
            else
            {
                if (label2.Text.Equals(""))
                {
                    label1.Text = "1";
                }
                else
                {
                    if (label3.Text.Equals(""))
                    {
                        label1.Text = "1";
                    }
                }
            }
        }

        private void dos_Click(object sender, EventArgs e)
        {

        }

        private void tres_Click(object sender, EventArgs e)
        {

        }

        private void cuatro_Click(object sender, EventArgs e)
        {

        }

        private void cinco_Click(object sender, EventArgs e)
        {

        }

        private void seis_Click(object sender, EventArgs e)
        {

        }

        private void siete_Click(object sender, EventArgs e)
        {

        }

        private void ocho_Click(object sender, EventArgs e)
        {

        }

        private void nueve_Click(object sender, EventArgs e)
        {

        }

        private void cero_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
