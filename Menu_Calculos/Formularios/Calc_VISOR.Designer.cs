using System;
using System.Windows.Forms;

namespace Menu_Calculos
{
    partial class Calc_VISOR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.visor = new System.Windows.Forms.Label();
            this.panel_num = new System.Windows.Forms.Panel();
            this.desfazer = new System.Windows.Forms.Button();
            this.limpa2 = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.virgula = new System.Windows.Forms.Button();
            this.positivo = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.dois = new System.Windows.Forms.Button();
            this.um = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.quatro = new System.Windows.Forms.Button();
            this.nove = new System.Windows.Forms.Button();
            this.oito = new System.Windows.Forms.Button();
            this.sete = new System.Windows.Forms.Button();
            this.panel_bot = new System.Windows.Forms.Panel();
            this.igual = new System.Windows.Forms.Button();
            this.potencia = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.multiplicacao = new System.Windows.Forms.Button();
            this.adicao = new System.Windows.Forms.Button();
            this.subtracao = new System.Windows.Forms.Button();
            this.panel_num.SuspendLayout();
            this.panel_bot.SuspendLayout();
            this.SuspendLayout();
            // 
            // visor
            // 
            this.visor.BackColor = System.Drawing.Color.Pink;
            this.visor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.visor.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.visor.Location = new System.Drawing.Point(12, 29);
            this.visor.Name = "visor";
            this.visor.Size = new System.Drawing.Size(471, 99);
            this.visor.TabIndex = 20;
            this.visor.Text = "0";
            this.visor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.visor.Click += new System.EventHandler(this.LblVisor_Click);
            // 
            // panel_num
            // 
            this.panel_num.BackColor = System.Drawing.Color.LightPink;
            this.panel_num.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_num.Controls.Add(this.desfazer);
            this.panel_num.Controls.Add(this.limpa2);
            this.panel_num.Controls.Add(this.limpar);
            this.panel_num.Controls.Add(this.zero);
            this.panel_num.Controls.Add(this.virgula);
            this.panel_num.Controls.Add(this.positivo);
            this.panel_num.Controls.Add(this.tres);
            this.panel_num.Controls.Add(this.dois);
            this.panel_num.Controls.Add(this.um);
            this.panel_num.Controls.Add(this.seis);
            this.panel_num.Controls.Add(this.cinco);
            this.panel_num.Controls.Add(this.quatro);
            this.panel_num.Controls.Add(this.nove);
            this.panel_num.Controls.Add(this.oito);
            this.panel_num.Controls.Add(this.sete);
            this.panel_num.Location = new System.Drawing.Point(12, 143);
            this.panel_num.Name = "panel_num";
            this.panel_num.Size = new System.Drawing.Size(311, 417);
            this.panel_num.TabIndex = 21;
            this.panel_num.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // desfazer
            // 
            this.desfazer.BackColor = System.Drawing.Color.Snow;
            this.desfazer.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desfazer.Location = new System.Drawing.Point(202, 16);
            this.desfazer.Name = "desfazer";
            this.desfazer.Size = new System.Drawing.Size(88, 69);
            this.desfazer.TabIndex = 34;
            this.desfazer.Text = "<=";
            this.desfazer.UseVisualStyleBackColor = false;
            this.desfazer.Click += new System.EventHandler(this.button19_Click);
            // 
            // limpa2
            // 
            this.limpa2.BackColor = System.Drawing.Color.Snow;
            this.limpa2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpa2.Location = new System.Drawing.Point(108, 16);
            this.limpa2.Name = "limpa2";
            this.limpa2.Size = new System.Drawing.Size(88, 69);
            this.limpa2.TabIndex = 33;
            this.limpa2.Text = "CE";
            this.limpa2.UseVisualStyleBackColor = false;
            this.limpa2.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // limpar
            // 
            this.limpar.BackColor = System.Drawing.Color.Snow;
            this.limpar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpar.Location = new System.Drawing.Point(14, 16);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(88, 69);
            this.limpar.TabIndex = 32;
            this.limpar.Text = "C";
            this.limpar.UseVisualStyleBackColor = false;
            this.limpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.Snow;
            this.zero.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(108, 319);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(88, 69);
            this.zero.TabIndex = 31;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.F_Digitos);
            // 
            // virgula
            // 
            this.virgula.BackColor = System.Drawing.Color.Snow;
            this.virgula.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.virgula.Location = new System.Drawing.Point(202, 319);
            this.virgula.Name = "virgula";
            this.virgula.Size = new System.Drawing.Size(88, 69);
            this.virgula.TabIndex = 30;
            this.virgula.Text = ",";
            this.virgula.UseVisualStyleBackColor = false;
            this.virgula.Click += new System.EventHandler(this.btnVirgula);
            // 
            // positivo
            // 
            this.positivo.BackColor = System.Drawing.Color.Snow;
            this.positivo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positivo.Location = new System.Drawing.Point(13, 319);
            this.positivo.Name = "positivo";
            this.positivo.Size = new System.Drawing.Size(89, 69);
            this.positivo.TabIndex = 29;
            this.positivo.Text = "+/-";
            this.positivo.UseVisualStyleBackColor = false;
            this.positivo.Click += new System.EventHandler(this.button17_Click);
            // 
            // tres
            // 
            this.tres.BackColor = System.Drawing.Color.Snow;
            this.tres.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tres.Location = new System.Drawing.Point(202, 244);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(88, 69);
            this.tres.TabIndex = 28;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = false;
            this.tres.Click += new System.EventHandler(this.F_Digitos);
            // 
            // dois
            // 
            this.dois.BackColor = System.Drawing.Color.Snow;
            this.dois.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dois.Location = new System.Drawing.Point(108, 244);
            this.dois.Name = "dois";
            this.dois.Size = new System.Drawing.Size(88, 69);
            this.dois.TabIndex = 27;
            this.dois.Text = "2";
            this.dois.UseVisualStyleBackColor = false;
            this.dois.Click += new System.EventHandler(this.F_Digitos);
            // 
            // um
            // 
            this.um.BackColor = System.Drawing.Color.Snow;
            this.um.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.um.Location = new System.Drawing.Point(13, 244);
            this.um.Name = "um";
            this.um.Size = new System.Drawing.Size(89, 69);
            this.um.TabIndex = 26;
            this.um.Text = "1";
            this.um.UseVisualStyleBackColor = false;
            this.um.Click += new System.EventHandler(this.F_Digitos);
            // 
            // seis
            // 
            this.seis.BackColor = System.Drawing.Color.Snow;
            this.seis.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seis.Location = new System.Drawing.Point(202, 169);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(88, 69);
            this.seis.TabIndex = 25;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = false;
            this.seis.Click += new System.EventHandler(this.F_Digitos);
            // 
            // cinco
            // 
            this.cinco.BackColor = System.Drawing.Color.Snow;
            this.cinco.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinco.Location = new System.Drawing.Point(108, 169);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(88, 69);
            this.cinco.TabIndex = 24;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = false;
            this.cinco.Click += new System.EventHandler(this.F_Digitos);
            // 
            // quatro
            // 
            this.quatro.BackColor = System.Drawing.Color.Snow;
            this.quatro.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quatro.Location = new System.Drawing.Point(13, 169);
            this.quatro.Name = "quatro";
            this.quatro.Size = new System.Drawing.Size(89, 69);
            this.quatro.TabIndex = 23;
            this.quatro.Text = "4";
            this.quatro.UseVisualStyleBackColor = false;
            this.quatro.Click += new System.EventHandler(this.F_Digitos);
            // 
            // nove
            // 
            this.nove.BackColor = System.Drawing.Color.Snow;
            this.nove.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nove.Location = new System.Drawing.Point(202, 94);
            this.nove.Name = "nove";
            this.nove.Size = new System.Drawing.Size(88, 69);
            this.nove.TabIndex = 22;
            this.nove.Text = "9";
            this.nove.UseVisualStyleBackColor = false;
            this.nove.Click += new System.EventHandler(this.F_Digitos);
            // 
            // oito
            // 
            this.oito.BackColor = System.Drawing.Color.Snow;
            this.oito.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oito.Location = new System.Drawing.Point(108, 94);
            this.oito.Name = "oito";
            this.oito.Size = new System.Drawing.Size(88, 69);
            this.oito.TabIndex = 21;
            this.oito.Text = "8";
            this.oito.UseVisualStyleBackColor = false;
            this.oito.Click += new System.EventHandler(this.F_Digitos);
            // 
            // sete
            // 
            this.sete.BackColor = System.Drawing.Color.Snow;
            this.sete.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sete.Location = new System.Drawing.Point(13, 94);
            this.sete.Name = "sete";
            this.sete.Size = new System.Drawing.Size(89, 69);
            this.sete.TabIndex = 20;
            this.sete.Text = "7";
            this.sete.UseVisualStyleBackColor = false;
            this.sete.Click += new System.EventHandler(this.F_Digitos);
            // 
            // panel_bot
            // 
            this.panel_bot.BackColor = System.Drawing.Color.LightPink;
            this.panel_bot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_bot.Controls.Add(this.igual);
            this.panel_bot.Controls.Add(this.potencia);
            this.panel_bot.Controls.Add(this.divisao);
            this.panel_bot.Controls.Add(this.multiplicacao);
            this.panel_bot.Controls.Add(this.adicao);
            this.panel_bot.Controls.Add(this.subtracao);
            this.panel_bot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_bot.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_bot.Location = new System.Drawing.Point(345, 143);
            this.panel_bot.Name = "panel_bot";
            this.panel_bot.Size = new System.Drawing.Size(138, 417);
            this.panel_bot.TabIndex = 22;
            this.panel_bot.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_bot_Paint);
            // 
            // igual
            // 
            this.igual.BackColor = System.Drawing.Color.Snow;
            this.igual.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igual.Location = new System.Drawing.Point(16, 329);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(91, 59);
            this.igual.TabIndex = 19;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = false;
            this.igual.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // potencia
            // 
            this.potencia.BackColor = System.Drawing.Color.Snow;
            this.potencia.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potencia.Location = new System.Drawing.Point(16, 267);
            this.potencia.Name = "potencia";
            this.potencia.Size = new System.Drawing.Size(91, 54);
            this.potencia.TabIndex = 18;
            this.potencia.Text = "^";
            this.potencia.UseVisualStyleBackColor = false;
            this.potencia.Click += new System.EventHandler(this.F_operaçoes);
            // 
            // divisao
            // 
            this.divisao.BackColor = System.Drawing.Color.Snow;
            this.divisao.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisao.Location = new System.Drawing.Point(16, 205);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(91, 54);
            this.divisao.TabIndex = 17;
            this.divisao.Text = "/";
            this.divisao.UseVisualStyleBackColor = false;
            this.divisao.Click += new System.EventHandler(this.F_operaçoes);
            // 
            // multiplicacao
            // 
            this.multiplicacao.BackColor = System.Drawing.Color.Snow;
            this.multiplicacao.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicacao.Location = new System.Drawing.Point(16, 143);
            this.multiplicacao.Name = "multiplicacao";
            this.multiplicacao.Size = new System.Drawing.Size(91, 54);
            this.multiplicacao.TabIndex = 16;
            this.multiplicacao.Text = "x";
            this.multiplicacao.UseVisualStyleBackColor = false;
            this.multiplicacao.Click += new System.EventHandler(this.F_operaçoes);
            // 
            // adicao
            // 
            this.adicao.BackColor = System.Drawing.Color.Snow;
            this.adicao.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicao.Location = new System.Drawing.Point(16, 81);
            this.adicao.Name = "adicao";
            this.adicao.Size = new System.Drawing.Size(91, 54);
            this.adicao.TabIndex = 15;
            this.adicao.Text = "+";
            this.adicao.UseVisualStyleBackColor = false;
            this.adicao.Click += new System.EventHandler(this.adicao_Click);
            // 
            // subtracao
            // 
            this.subtracao.BackColor = System.Drawing.Color.Snow;
            this.subtracao.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtracao.Location = new System.Drawing.Point(16, 16);
            this.subtracao.Name = "subtracao";
            this.subtracao.Size = new System.Drawing.Size(91, 54);
            this.subtracao.TabIndex = 14;
            this.subtracao.Text = "-";
            this.subtracao.UseVisualStyleBackColor = false;
            this.subtracao.Click += new System.EventHandler(this.F_operaçoes);
            // 
            // Calc_VISOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(502, 572);
            this.Controls.Add(this.panel_bot);
            this.Controls.Add(this.panel_num);
            this.Controls.Add(this.visor);
            this.Name = "Calc_VISOR";
            this.Text = "Calc_VISOR";
            this.panel_num.ResumeLayout(false);
            this.panel_bot.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void panel_bot_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion
        private System.Windows.Forms.Label visor;
        private System.Windows.Forms.Panel panel_num;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button virgula;
        private System.Windows.Forms.Button positivo;
        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button dois;
        private System.Windows.Forms.Button um;
        private System.Windows.Forms.Button seis;
        private System.Windows.Forms.Button cinco;
        private System.Windows.Forms.Button quatro;
        private System.Windows.Forms.Button nove;
        private System.Windows.Forms.Button oito;
        private System.Windows.Forms.Button sete;
        private System.Windows.Forms.Panel panel_bot;
        private System.Windows.Forms.Button subtracao;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button potencia;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.Button multiplicacao;
        private System.Windows.Forms.Button adicao;
        private System.Windows.Forms.Button desfazer;
        private System.Windows.Forms.Button limpa2;
        private System.Windows.Forms.Button limpar;
    }
}