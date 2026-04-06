using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Calculos
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class CalcRadio : Form
    {
        public CalcRadio()
        {
            InitializeComponent();
        }

        private void CalcRadio_Load(object sender, EventArgs e)
        {
            // Aqui você pode inicializar componentes se necessário
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Evento de mudança do textBox1
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Evento de mudança do textBox2
        }

        private void soma_CheckedChanged(object sender, EventArgs e)
        {
            // Evento do radio button soma
        }

        private void sub_CheckedChanged(object sender, EventArgs e)
        {
            // Evento do radio button subtração
        }

        private void mult_CheckedChanged(object sender, EventArgs e)
        {
            // Evento do radio button multiplicação
        }

        private void div_CheckedChanged(object sender, EventArgs e)
        {
            // Evento do radio button divisão
        }

        private void comp_CheckedChanged(object sender, EventArgs e)
        {
            // Evento do radio button comparação
        }

        private void parimpar_CheckedChanged(object sender, EventArgs e)
        {
            // Evento do radio button par ou ímpar
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Evento do label 1
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Evento do label 2
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Limpar campos
            textBox1.Clear();
            textBox2.Clear();
            resultado.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Fechar formulário
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
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
                resultadoFinal = (a + b).ToString();
            }

            else if (sub.Checked)
            {
                resultadoFinal = (a - b).ToString();
            }

            else if (mult.Checked)
            {
                resultadoFinal = (a * b).ToString();
            }

            else if (div.Checked)
            {
                // Validação para divisão por zero
                if (b == 0)
                {
                    MessageBox.Show("Não é possível dividir por zero!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                resultadoFinal = (a / b).ToString();
            }

            // comparar
            else if (comp.Checked)
            {
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
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            button3_Click(null, null);
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
