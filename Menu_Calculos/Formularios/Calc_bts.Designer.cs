namespace Menu_Calculos
{
    partial class CALCULOS
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.sinal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.btnnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txt_min_n2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_min_n1 = new System.Windows.Forms.TextBox();
            this.btnParImpar = new System.Windows.Forms.Button();
            this.btnComparar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnSubitrair = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sinal
            // 
            this.sinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinal.Location = new System.Drawing.Point(25, 113);
            this.sinal.Name = "sinal";
            this.sinal.Size = new System.Drawing.Size(43, 37);
            this.sinal.TabIndex = 0;
            this.sinal.Text = "?";
            this.sinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sinal.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "___________________________";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // resultado
            // 
            this.resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(80, 212);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(100, 43);
            this.resultado.TabIndex = 3;
            this.resultado.Text = "?";
            this.resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnnLimpar
            // 
            this.btnnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnLimpar.Location = new System.Drawing.Point(137, 339);
            this.btnnLimpar.Name = "btnnLimpar";
            this.btnnLimpar.Size = new System.Drawing.Size(75, 32);
            this.btnnLimpar.TabIndex = 6;
            this.btnnLimpar.Text = "&Limpar";
            this.btnnLimpar.UseVisualStyleBackColor = true;
            this.btnnLimpar.Click += new System.EventHandler(this.btnnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(47, 339);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 32);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txt_min_n2
            // 
            this.txt_min_n2.Location = new System.Drawing.Point(80, 144);
            this.txt_min_n2.Name = "txt_min_n2";
            this.txt_min_n2.Size = new System.Drawing.Size(100, 20);
            this.txt_min_n2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(80, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(80, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 29);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_min_n1
            // 
            this.txt_min_n1.Location = new System.Drawing.Point(80, 73);
            this.txt_min_n1.Name = "txt_min_n1";
            this.txt_min_n1.Size = new System.Drawing.Size(100, 20);
            this.txt_min_n1.TabIndex = 8;
            this.txt_min_n1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnParImpar
            // 
            this.btnParImpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParImpar.Location = new System.Drawing.Point(375, 290);
            this.btnParImpar.Name = "btnParImpar";
            this.btnParImpar.Size = new System.Drawing.Size(111, 32);
            this.btnParImpar.TabIndex = 14;
            this.btnParImpar.Text = "&Par e impar";
            this.btnParImpar.UseVisualStyleBackColor = true;
            this.btnParImpar.Click += new System.EventHandler(this.btnParImpar_Click);
            // 
            // btnComparar
            // 
            this.btnComparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComparar.Location = new System.Drawing.Point(375, 242);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(111, 32);
            this.btnComparar.TabIndex = 13;
            this.btnComparar.Text = "&Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(375, 150);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(111, 32);
            this.btnDividir.TabIndex = 12;
            this.btnDividir.Text = "&Dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(375, 113);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(111, 32);
            this.btnMultiplicar.TabIndex = 11;
            this.btnMultiplicar.Text = "&Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnSubitrair
            // 
            this.btnSubitrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubitrair.Location = new System.Drawing.Point(375, 73);
            this.btnSubitrair.Name = "btnSubitrair";
            this.btnSubitrair.Size = new System.Drawing.Size(111, 32);
            this.btnSubitrair.TabIndex = 10;
            this.btnSubitrair.Text = "&Subtrair";
            this.btnSubitrair.UseVisualStyleBackColor = true;
            this.btnSubitrair.Click += new System.EventHandler(this.btnSubitrair_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.Location = new System.Drawing.Point(375, 32);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(111, 32);
            this.btnSomar.TabIndex = 5;
            this.btnSomar.Text = "&Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // CALCULOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(535, 380);
            this.Controls.Add(this.btnParImpar);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSubitrair);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_min_n2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_min_n1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnnLimpar);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sinal);
            this.Name = "CALCULOS";
            this.Text = "DogMello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button btnnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txt_min_n2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt_min_n1;
        private System.Windows.Forms.Button btnParImpar;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSubitrair;
        private System.Windows.Forms.Button btnSomar;
    }
}

