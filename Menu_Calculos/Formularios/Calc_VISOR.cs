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
    public partial class Calc_VISOR : Form
    {
       
        decimal vNumant;
        string vOperaçao;  // variavel global, para armazenar a operação selecionada!!
        bool vLimparVisor;
        // as tres são variaveis

        public Calc_VISOR()
        {
            InitializeComponent();
        }

        private void F_Digitos(object sender, EventArgs e)
        {
            string digito = ((Button)sender). Text ;
            if (LblVisor.Text == "0")
            {
                LblVisor.Text = "";
                vLimparVisor = false;
            }
            LblVisor.Text += digito;

        }
        private void F_operaçoes(object sender, EventArgs e)
        {
            vNumant = decimal.Parse(LblVisor.Text);
            vOperaçao = ((Button)sender).Text;
            vLimparVisor = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            //pegar o numero atual do visor
            decimal v = decimal.Parse(s: LblVisor.Text);
            decimal vNumant = v;
            //decidir que operação fazer   
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            LblVisor.Text=LblVisor.Text.Substring(0, LblVisor.Text.Length -);
            if(LblVisor.Text=="") LblVisor.Text = "0";
        }

        private void LblVisor_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void btnVirgula(object sender, EventArgs e)
        {
            if(!LblVisor.Text.Contains(","))
            LblVisor.Text += ",";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            vNumant = 0;
            LblVisor.Text = "0";
        }
    }
}
