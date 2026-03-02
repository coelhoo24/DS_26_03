using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Calculos
{
    public partial class CALCULOS : Form
    {
        private object lbl;

        public CALCULOS()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            sinal.Text = "+";
            resultado.Text = (a + b).ToString();
        }

        private void btnnLimpar_Click(object sender, EventArgs e)
        {
            sinal.Text = "?";
            resultado.Text = "?";
            txt_min_n1.Clear();
            txt_min_n2.Clear();
            txt_min_n1.Focus();
        }

        private void btnSubitrair_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            sinal.Text = "-";
            resultado.Text = (a - b).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            sinal.Text = "x";
            resultado.Text = (a * b).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            sinal.Text = "/";
            resultado.Text = (a / b).ToString();
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            sinal.Text = "<>";
            if (a > b)
            {
                resultado.Text = (a > b).ToString();
            }
        }
    }
}
