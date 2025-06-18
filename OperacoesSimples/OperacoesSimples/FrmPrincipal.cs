using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperacoesSimples
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal soma, subtracao, multiplicacao, divisao;
            decimal num1 = Convert.ToDecimal(txt1.Text);
            decimal num2 = Convert.ToDecimal(txt2.Text);

            soma = num1 + num2;
            subtracao = num1 - num2;
            multiplicacao = num1 * num2;
            divisao = num1 / num2;
           
            lblSoma.Text = soma.ToString();
            lblSubtracao.Text = subtracao.ToString();
            lblMultiplicacao.Text = multiplicacao.ToString();
            lblDivisao.Text = divisao.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblMultiplicacao_Click(object sender, EventArgs e)
        {

        }

        private void lblSubtracao_Click(object sender, EventArgs e)
        {

        }

        private void lblDivisao_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
