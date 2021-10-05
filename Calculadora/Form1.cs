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
    public partial class Pantalla : Form
    {
        double op1;
        double op2;
        String operador;
        double resul;
        public Pantalla()
        {
            InitializeComponent();
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            op2 = double.Parse(mostraresultado.Text);

            switch (operador)
            {
                case "+":
                    resul = op1 + op2;
                    mostraresultado.Text = resul.ToString();
                    historial.Text = resul.ToString();
                    mostraresultado.Clear();
                    break;
                case "-":
                    resul = op1 - op2;
                    mostraresultado.Text = resul.ToString();
                    historial.Text = resul.ToString();
                    mostraresultado.Clear();
                    break;
                case "*":
                    resul = op1 * op2;
                    mostraresultado.Text = resul.ToString();
                    historial.Text = resul.ToString();
                    mostraresultado.Clear();
                    break;
                case "/":
                    resul = op1 / op2;
                    mostraresultado.Text = resul.ToString();
                    historial.Text = resul.ToString();
                    mostraresultado.Clear();
                    break;
            }
        }
        private void restar_Click(object sender, EventArgs e)
        {
            operador = "-";
            op1 = double.Parse(mostraresultado.Text);
            mostraresultado.Clear();

        }

        private void sumar_Click(object sender, EventArgs e)
        {
            operador = "+";
            op1 = double.Parse(mostraresultado.Text);
            mostraresultado.Clear();
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            op1 = double.Parse(mostraresultado.Text);
            mostraresultado.Clear();
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            operador = "*";
            op1 = double.Parse(mostraresultado.Text);
            mostraresultado.Clear();
        }

        private void resetear_Click(object sender, EventArgs e)
        {
            mostraresultado.Clear();
        }

        private void uno_Click(object sender, EventArgs e)
        {
            mostraresultado.Text = mostraresultado.Text + "1";
        }

        private void dos_Click(object sender, EventArgs e)
        {
            mostraresultado.Text = mostraresultado.Text + "2";
        }

        private void tres_Click(object sender, EventArgs e)
        {
            mostraresultado.Text = mostraresultado.Text + "3";
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            mostraresultado.Text = mostraresultado.Text + "4";
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            mostraresultado.Text = mostraresultado.Text + "5";
        }

        private void seis_Click(object sender, EventArgs e)
        {
            mostraresultado.Text = mostraresultado.Text + "6";
        }

        private void siete_Click(object sender, EventArgs e)
        {
            mostraresultado.Text = mostraresultado.Text + "7";
        }

        private void ocho_Click(object sender, EventArgs e)
        {
            mostraresultado.Text = mostraresultado.Text + "8";
        }

        private void nueve_Click(object sender, EventArgs e)
        {
            mostraresultado.Text = mostraresultado.Text + "9";
        }

        private void cero_Click(object sender, EventArgs e)
        {
            mostraresultado.Text = mostraresultado.Text + "0";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
