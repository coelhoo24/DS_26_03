namespace Menu_Calculos.Formularios
{
    partial class CalcRadio
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
            this.soma = new System.Windows.Forms.RadioButton();
            this.sub = new System.Windows.Forms.RadioButton();
            this.mult = new System.Windows.Forms.RadioButton();
            this.div = new System.Windows.Forms.RadioButton();
            this.comp = new System.Windows.Forms.RadioButton();
            this.parimpar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // soma
            // 
            this.soma.AutoSize = true;
            this.soma.Location = new System.Drawing.Point(38, 81);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(52, 17);
            this.soma.TabIndex = 0;
            this.soma.TabStop = true;
            this.soma.Text = "Soma";
            this.soma.UseVisualStyleBackColor = true;
            this.soma.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // sub
            // 
            this.sub.AutoSize = true;
            this.sub.Location = new System.Drawing.Point(38, 104);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(74, 17);
            this.sub.TabIndex = 1;
            this.sub.TabStop = true;
            this.sub.Text = "Subtração";
            this.sub.UseVisualStyleBackColor = true;
            // 
            // mult
            // 
            this.mult.AutoSize = true;
            this.mult.Location = new System.Drawing.Point(38, 127);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(87, 17);
            this.mult.TabIndex = 2;
            this.mult.TabStop = true;
            this.mult.Text = "Multiplicação";
            this.mult.UseVisualStyleBackColor = true;
            // 
            // div
            // 
            this.div.AutoSize = true;
            this.div.Location = new System.Drawing.Point(38, 151);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(60, 17);
            this.div.TabIndex = 3;
            this.div.TabStop = true;
            this.div.Text = "Divisão";
            this.div.UseVisualStyleBackColor = true;
            // 
            // comp
            // 
            this.comp.AutoSize = true;
            this.comp.Location = new System.Drawing.Point(544, 81);
            this.comp.Name = "comp";
            this.comp.Size = new System.Drawing.Size(85, 17);
            this.comp.TabIndex = 4;
            this.comp.TabStop = true;
            this.comp.Text = "Comparação";
            this.comp.UseVisualStyleBackColor = true;
            this.comp.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // parimpar
            // 
            this.parimpar.AutoSize = true;
            this.parimpar.Location = new System.Drawing.Point(544, 104);
            this.parimpar.Name = "parimpar";
            this.parimpar.Size = new System.Drawing.Size(85, 17);
            this.parimpar.TabIndex = 5;
            this.parimpar.TabStop = true;
            this.parimpar.Text = "Par ou Impar";
            this.parimpar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "?";
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(311, 218);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(13, 13);
            this.resultado.TabIndex = 7;
            this.resultado.Text = "?";
            this.resultado.Click += new System.EventHandler(this.resultado_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(273, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(273, 184);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CalcRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parimpar);
            this.Controls.Add(this.comp);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.soma);
            this.Name = "CalcRadio";
            this.Text = "CalcRadio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton soma;
        private System.Windows.Forms.RadioButton sub;
        private System.Windows.Forms.RadioButton mult;
        private System.Windows.Forms.RadioButton div;
        private System.Windows.Forms.RadioButton comp;
        private System.Windows.Forms.RadioButton parimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}