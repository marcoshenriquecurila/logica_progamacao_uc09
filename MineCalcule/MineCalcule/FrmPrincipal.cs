using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineCalcule
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            Decimal valor1 = Convert.ToDecimal(txtValor1.Text);
            Decimal valor2 = Convert.ToDecimal(txtValor2.Text);


            Decimal resultado = valor1 + valor2;
            lblResultado.Text = resultado.ToString();
        }

        private void txtValor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            Decimal valor1 = Convert.ToDecimal(txtValor1.Text);
            Decimal valor2 = Convert.ToDecimal(txtValor2.Text);


            Decimal resultado = valor1 - valor2;
            lblResultado.Text = resultado.ToString();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            Decimal valor1 = Convert.ToDecimal(txtValor1.Text);
            Decimal valor2 = Convert.ToDecimal(txtValor2.Text);


            Decimal resultado = valor1 * valor2;
            lblResultado.Text = resultado.ToString();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            Decimal valor1 = Convert.ToDecimal(txtValor1.Text);
            Decimal valor2 = Convert.ToDecimal(txtValor2.Text);

            if (valor2 == 0)
            {
                MessageBox.Show("Divisão por 0 proibida");
                lblResultado.Text = "0";
            }
            else
            {

                Decimal resultado = valor1 / valor2;
                lblResultado.Text = Math.Round(resultado, 2).ToString();
            }
        }
    }
}