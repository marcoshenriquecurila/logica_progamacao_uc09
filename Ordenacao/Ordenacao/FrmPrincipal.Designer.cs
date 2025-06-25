namespace Ordenacao
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
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtNumero3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCrescente1 = new System.Windows.Forms.Label();
            this.lblCrescente2 = new System.Windows.Forms.Label();
            this.lblCrescente3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDecrescente1 = new System.Windows.Forms.Label();
            this.lblDecrescente2 = new System.Windows.Forms.Label();
            this.lblDecrescente3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnResultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero1.Location = new System.Drawing.Point(124, 44);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 38);
            this.txtNumero1.TabIndex = 0;
            this.txtNumero1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNumero2
            // 
            this.txtNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero2.Location = new System.Drawing.Point(273, 44);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 38);
            this.txtNumero2.TabIndex = 2;
            // 
            // txtNumero3
            // 
            this.txtNumero3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero3.Location = new System.Drawing.Point(398, 44);
            this.txtNumero3.Name = "txtNumero3";
            this.txtNumero3.Size = new System.Drawing.Size(100, 38);
            this.txtNumero3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número 3";
            // 
            // lblCrescente1
            // 
            this.lblCrescente1.AutoSize = true;
            this.lblCrescente1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrescente1.Location = new System.Drawing.Point(154, 176);
            this.lblCrescente1.Name = "lblCrescente1";
            this.lblCrescente1.Size = new System.Drawing.Size(29, 31);
            this.lblCrescente1.TabIndex = 6;
            this.lblCrescente1.Text = "0";
            // 
            // lblCrescente2
            // 
            this.lblCrescente2.AutoSize = true;
            this.lblCrescente2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrescente2.Location = new System.Drawing.Point(297, 176);
            this.lblCrescente2.Name = "lblCrescente2";
            this.lblCrescente2.Size = new System.Drawing.Size(29, 31);
            this.lblCrescente2.TabIndex = 7;
            this.lblCrescente2.Text = "0";
            // 
            // lblCrescente3
            // 
            this.lblCrescente3.AutoSize = true;
            this.lblCrescente3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrescente3.Location = new System.Drawing.Point(431, 176);
            this.lblCrescente3.Name = "lblCrescente3";
            this.lblCrescente3.Size = new System.Drawing.Size(29, 31);
            this.lblCrescente3.TabIndex = 8;
            this.lblCrescente3.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(212, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ordem Crescente";
            // 
            // lblDecrescente1
            // 
            this.lblDecrescente1.AutoSize = true;
            this.lblDecrescente1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecrescente1.Location = new System.Drawing.Point(149, 368);
            this.lblDecrescente1.Name = "lblDecrescente1";
            this.lblDecrescente1.Size = new System.Drawing.Size(29, 31);
            this.lblDecrescente1.TabIndex = 10;
            this.lblDecrescente1.Text = "0";
            // 
            // lblDecrescente2
            // 
            this.lblDecrescente2.AutoSize = true;
            this.lblDecrescente2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecrescente2.Location = new System.Drawing.Point(297, 368);
            this.lblDecrescente2.Name = "lblDecrescente2";
            this.lblDecrescente2.Size = new System.Drawing.Size(29, 31);
            this.lblDecrescente2.TabIndex = 11;
            this.lblDecrescente2.Text = "0";
            // 
            // lblDecrescente3
            // 
            this.lblDecrescente3.AutoSize = true;
            this.lblDecrescente3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecrescente3.Location = new System.Drawing.Point(431, 368);
            this.lblDecrescente3.Name = "lblDecrescente3";
            this.lblDecrescente3.Size = new System.Drawing.Size(29, 31);
            this.lblDecrescente3.TabIndex = 12;
            this.lblDecrescente3.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(212, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(257, 31);
            this.label9.TabIndex = 13;
            this.label9.Text = "Ordem Decrescente";
            // 
            // btnResultado
            // 
            this.btnResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.Location = new System.Drawing.Point(589, 44);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(130, 38);
            this.btnResultado.TabIndex = 14;
            this.btnResultado.Text = "Ordenar";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDecrescente3);
            this.Controls.Add(this.lblDecrescente2);
            this.Controls.Add(this.lblDecrescente1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCrescente3);
            this.Controls.Add(this.lblCrescente2);
            this.Controls.Add(this.lblCrescente1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumero3);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero1);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtNumero3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCrescente1;
        private System.Windows.Forms.Label lblCrescente2;
        private System.Windows.Forms.Label lblCrescente3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDecrescente1;
        private System.Windows.Forms.Label lblDecrescente2;
        private System.Windows.Forms.Label lblDecrescente3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnResultado;
    }
}

