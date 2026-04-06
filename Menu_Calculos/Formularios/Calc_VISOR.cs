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
    public partial class Calc_VISOR : Form
    {

        decimal vNumant;
        string vOperaçao;  
        bool vLimparVisor;
        // as tres são variaveis

        public Calc_VISOR()
        {
            InitializeComponent();
        }

        private void F_Digitos(object sender, EventArgs e)
        {
            string digito = ((Button)sender).Text;
            if (visor.Text == "0" || vLimparVisor)
            {
                visor.Text = "";
                vLimparVisor = false;
            }
            visor.Text += digito;
        }

        private void F_operaçoes(object sender, EventArgs e)
        {
            vNumant = decimal.Parse(visor.Text);
            vOperaçao = ((Button)sender).Text;
            vLimparVisor = true;
        }

        private void RealizarOperacao()
        {
            decimal vNumAtual = decimal.Parse(visor.Text);
            decimal resultado = 0;

            switch (vOperaçao)
            {
                case "+":
                    resultado = vNumant + vNumAtual;
                    break;
                case "-":
                    resultado = vNumant - vNumAtual;
                    break;
                case "x":
                    resultado = vNumant * vNumAtual;
                    break;
                case "/":
                    if (vNumAtual != 0)
                        resultado = vNumant / vNumAtual;
                    else
                        MessageBox.Show("Divisão por zero não permitida!");
                    break;
                case "^":
                    resultado = (decimal)Math.Pow((double)vNumant, (double)vNumAtual);
                    break;
            }

            visor.Text = resultado.ToString();
            vNumant = resultado;
            vLimparVisor = true;
        }

        private void adicao_Click(object sender, EventArgs e)
        {
            F_operaçoes(sender, e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            F_Digitos(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            F_Digitos(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            F_Digitos(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F_Digitos(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            F_Digitos(sender, e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            F_Digitos(sender, e);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            F_operaçoes(sender, e);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            F_operaçoes(sender, e);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            F_operaçoes(sender, e);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            F_operaçoes(sender, e);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (vOperaçao != "")
            {
                RealizarOperacao();
                vOperaçao = "";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (visor.Text.Length > 0)
            {
                visor.Text = visor.Text.Substring(0, visor.Text.Length - 1);
            }
            if (visor.Text == "") visor.Text = "0";
        }

        private void LblVisor_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            decimal valor = decimal.Parse(visor.Text);
            valor = valor * -1;
            visor.Text = valor.ToString();
        }

        private void btnVirgula(object sender, EventArgs e)
        {
            if (!visor.Text.Contains(","))
                visor.Text += ",";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            vNumant = 0;
            visor.Text = "0";
            vOperaçao = "";
            vLimparVisor = false;
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
