namespace Menu_Calculos
{
    public partial class CalcRadio : Form
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
            this.div = new System.Windows.Forms.RadioButton();
            this.mult = new System.Windows.Forms.RadioButton();
            this.comp = new System.Windows.Forms.RadioButton();
            this.parimpar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.calcular = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // soma
            // 
            this.soma.AutoSize = true;
            this.soma.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soma.Location = new System.Drawing.Point(90, 126);
            this.soma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(51, 30);
            this.soma.TabIndex = 0;
            this.soma.TabStop = true;
            this.soma.Text = "+";
            this.soma.UseVisualStyleBackColor = true;
            this.soma.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // sub
            // 
            this.sub.AutoSize = true;
            this.sub.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(90, 162);
            this.sub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(45, 30);
            this.sub.TabIndex = 1;
            this.sub.TabStop = true;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // div
            // 
            this.div.AutoSize = true;
            this.div.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.Location = new System.Drawing.Point(90, 197);
            this.div.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(44, 30);
            this.div.TabIndex = 2;
            this.div.TabStop = true;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // mult
            // 
            this.mult.AutoSize = true;
            this.mult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult.Location = new System.Drawing.Point(90, 232);
            this.mult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(49, 30);
            this.mult.TabIndex = 3;
            this.mult.TabStop = true;
            this.mult.Text = "x";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // comp
            // 
            this.comp.AutoSize = true;
            this.comp.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comp.Location = new System.Drawing.Point(90, 351);
            this.comp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comp.Name = "comp";
            this.comp.Size = new System.Drawing.Size(118, 26);
            this.comp.TabIndex = 4;
            this.comp.TabStop = true;
            this.comp.Text = "Comparar";
            this.comp.UseVisualStyleBackColor = true;
            this.comp.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // parimpar
            // 
            this.parimpar.AutoSize = true;
            this.parimpar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parimpar.Location = new System.Drawing.Point(90, 385);
            this.parimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.parimpar.Name = "parimpar";
            this.parimpar.Size = new System.Drawing.Size(119, 26);
            this.parimpar.TabIndex = 5;
            this.parimpar.TabStop = true;
            this.parimpar.Text = "Par Impar";
            this.parimpar.UseVisualStyleBackColor = true;
            this.parimpar.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 351);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "-------------------------------";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // resultado
            // 
            this.resultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultado.AutoSize = true;
            this.resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultado.Cursor = System.Windows.Forms.Cursors.Default;
            this.resultado.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(352, 385);
            this.resultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultado.MaximumSize = new System.Drawing.Size(74, 76);
            this.resultado.MinimumSize = new System.Drawing.Size(74, 76);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(74, 76);
            this.resultado.TabIndex = 9;
            this.resultado.Text = "?";
            this.resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resultado.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(450, 523);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 69);
            this.button2.TabIndex = 11;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);

            this.calcular.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.calcular.Location = new System.Drawing.Point(270, 523);
            this.calcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(156, 69);
            this.calcular.TabIndex = 12;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(75, 523);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 69);
            this.button1.TabIndex = 15;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(318, 192);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 35);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(318, 272);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 35);
            this.textBox2.TabIndex = 17;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // CalcRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(700, 692);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parimpar);
            this.Controls.Add(this.comp);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.div);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.soma);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CalcRadio";
            this.Text = "CalcRadio";
            this.Load += new System.EventHandler(this.CalcRadio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.RadioButton soma;
        private System.Windows.Forms.RadioButton sub;
        private System.Windows.Forms.RadioButton div;
        private System.Windows.Forms.RadioButton mult;
        private System.Windows.Forms.RadioButton comp;
        private System.Windows.Forms.RadioButton parimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}