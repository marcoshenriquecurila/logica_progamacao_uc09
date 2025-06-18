namespace OperacoesSimples
{
    partial class FrmPrincipal
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.lblSoma = new System.Windows.Forms.Label();
            this.lblSubtracao = new System.Windows.Forms.Label();
            this.lblMultiplicacao = new System.Windows.Forms.Label();
            this.lblDivisao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(119, 74);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 29);
            this.txt1.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(313, 74);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 29);
            this.txt2.TabIndex = 1;
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(220, 180);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 2;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSoma
            // 
            this.lblSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoma.Location = new System.Drawing.Point(426, 252);
            this.lblSoma.Name = "lblSoma";
            this.lblSoma.Size = new System.Drawing.Size(225, 23);
            this.lblSoma.TabIndex = 3;
            this.lblSoma.Text = "0";
            this.lblSoma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSoma.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSubtracao
            // 
            this.lblSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtracao.Location = new System.Drawing.Point(426, 303);
            this.lblSubtracao.Name = "lblSubtracao";
            this.lblSubtracao.Size = new System.Drawing.Size(225, 23);
            this.lblSubtracao.TabIndex = 4;
            this.lblSubtracao.Text = "0";
            this.lblSubtracao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSubtracao.Click += new System.EventHandler(this.lblSubtracao_Click);
            // 
            // lblMultiplicacao
            // 
            this.lblMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplicacao.Location = new System.Drawing.Point(426, 353);
            this.lblMultiplicacao.Name = "lblMultiplicacao";
            this.lblMultiplicacao.Size = new System.Drawing.Size(225, 23);
            this.lblMultiplicacao.TabIndex = 5;
            this.lblMultiplicacao.Text = "0";
            this.lblMultiplicacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMultiplicacao.Click += new System.EventHandler(this.lblMultiplicacao_Click);
            // 
            // lblDivisao
            // 
            this.lblDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivisao.Location = new System.Drawing.Point(426, 404);
            this.lblDivisao.Name = "lblDivisao";
            this.lblDivisao.Size = new System.Drawing.Size(225, 23);
            this.lblDivisao.TabIndex = 6;
            this.lblDivisao.Text = "0";
            this.lblDivisao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDivisao.Click += new System.EventHandler(this.lblDivisao_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "A Soma é :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "A Subtração é :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "A Multiplicação é :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(268, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "A Divisão é : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDivisao);
            this.Controls.Add(this.lblMultiplicacao);
            this.Controls.Add(this.lblSubtracao);
            this.Controls.Add(this.lblSoma);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label lblSoma;
        private System.Windows.Forms.Label lblSubtracao;
        private System.Windows.Forms.Label lblMultiplicacao;
        private System.Windows.Forms.Label lblDivisao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

