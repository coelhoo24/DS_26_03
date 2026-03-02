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
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txt_min_n2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_min_n1 = new System.Windows.Forms.TextBox();
            this.btnSubitrair = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnComparar = new System.Windows.Forms.Button();
            this.btnParImpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sinal
            // 
            this.sinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinal.Location = new System.Drawing.Point(37, 174);
            this.sinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sinal.Name = "sinal";
            this.sinal.Size = new System.Drawing.Size(64, 56);
            this.sinal.TabIndex = 0;
            this.sinal.Text = "?";
            this.sinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sinal.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 292);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "___________________________";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // resultado
            // 
            this.resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(120, 326);
            this.resultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(149, 65);
            this.resultado.TabIndex = 3;
            this.resultado.Text = "?";
            this.resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSomar
            // 
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.Location = new System.Drawing.Point(562, 49);
            this.btnSomar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(166, 49);
            this.btnSomar.TabIndex = 5;
            this.btnSomar.Text = "&Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnnLimpar
            // 
            this.btnnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnLimpar.Location = new System.Drawing.Point(206, 522);
            this.btnnLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnnLimpar.Name = "btnnLimpar";
            this.btnnLimpar.Size = new System.Drawing.Size(112, 49);
            this.btnnLimpar.TabIndex = 6;
            this.btnnLimpar.Text = "&Limpar";
            this.btnnLimpar.UseVisualStyleBackColor = true;
            this.btnnLimpar.Click += new System.EventHandler(this.btnnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(70, 522);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(112, 49);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txt_min_n2
            // 
            this.txt_min_n2.Location = new System.Drawing.Point(120, 222);
            this.txt_min_n2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_min_n2.Name = "txt_min_n2";
            this.txt_min_n2.Size = new System.Drawing.Size(148, 26);
            this.txt_min_n2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(120, 98);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 40);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(120, 208);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 40);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_min_n1
            // 
            this.txt_min_n1.Location = new System.Drawing.Point(120, 112);
            this.txt_min_n1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_min_n1.Name = "txt_min_n1";
            this.txt_min_n1.Size = new System.Drawing.Size(148, 26);
            this.txt_min_n1.TabIndex = 8;
            this.txt_min_n1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSubitrair
            // 
            this.btnSubitrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubitrair.Location = new System.Drawing.Point(562, 112);
            this.btnSubitrair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubitrair.Name = "btnSubitrair";
            this.btnSubitrair.Size = new System.Drawing.Size(166, 49);
            this.btnSubitrair.TabIndex = 10;
            this.btnSubitrair.Text = "&Subtrair";
            this.btnSubitrair.UseVisualStyleBackColor = true;
            this.btnSubitrair.Click += new System.EventHandler(this.btnSubitrair_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(562, 171);
            this.btnMultiplicar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(166, 49);
            this.btnMultiplicar.TabIndex = 11;
            this.btnMultiplicar.Text = "&Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(562, 230);
            this.btnDividir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(166, 49);
            this.btnDividir.TabIndex = 12;
            this.btnDividir.Text = "&Dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnComparar
            // 
            this.btnComparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComparar.Location = new System.Drawing.Point(562, 373);
            this.btnComparar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(166, 49);
            this.btnComparar.TabIndex = 13;
            this.btnComparar.Text = "&Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // btnParImpar
            // 
            this.btnParImpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParImpar.Location = new System.Drawing.Point(562, 446);
            this.btnParImpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnParImpar.Name = "btnParImpar";
            this.btnParImpar.Size = new System.Drawing.Size(166, 49);
            this.btnParImpar.TabIndex = 14;
            this.btnParImpar.Text = "&Par e impar";
            this.btnParImpar.UseVisualStyleBackColor = true;
            // 
            // CALCULOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(802, 585);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CALCULOS";
            this.Text = "DogMello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txt_min_n2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt_min_n1;
        private System.Windows.Forms.Button btnSubitrair;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Button btnParImpar;
    }
}

