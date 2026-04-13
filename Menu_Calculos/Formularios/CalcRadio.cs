using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Calculos.Formularios
{
    public partial class CalcRadio : Form
    {
        public CalcRadio()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validação dos campos
            if (!double.TryParse(textBox1.Text, out double a) ||
                !double.TryParse(textBox2.Text, out double b))
            {
                MessageBox.Show("Digite números válidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string resultadoFinal = "";
            double c;

            // operações matemáticas
            if (soma.Checked)
            {
                label1.Text = "+";
                resultadoFinal = (a + b).ToString();
            }

            else if (sub.Checked)
            {
                label1.Text = "-";
                resultadoFinal = (a - b).ToString();
            }

            else if (mult.Checked)
            {
                label1.Text = "*";
                resultadoFinal = (a * b).ToString();
            }

            else if (div.Checked)
            {
                label1.Text = "/";
                // Validação para divisão por zero
                try
                {
                    resultadoFinal = (a / b).ToString();
                }
                catch (DivideByZeroException) {
                      MessageBox.Show("Não é possível dividir por zero!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }
            }

            // comparar
            else if (comp.Checked)
            {
                label1.Text = "Comparar";
                if (a > b)
                    resultadoFinal = a + " > " + b;
                else if (a < b)
                    resultadoFinal = a + " < " + b;
                else
                    resultadoFinal = a + " = " + b;
            }

            // par ou ímpar (usa a soma dos dois números)
            else if (parimpar.Checked)
            {
                label1.Text = "Par ou Ímpar";
                c = a + b;
                resultadoFinal = c % 2 == 0 ? "A soma dos dois é Par" : "A soma dos dois é Ímpar";
            }

            else
            {
                MessageBox.Show("Selecione uma operação!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Exibir resultado
            resultado.Text = resultadoFinal;
            resultado.Text = resultadoFinal;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void resultado_Click(object sender, EventArgs e)
        {

        }
    }
}
