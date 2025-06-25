using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenacao
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            Decimal numero1 = Convert.ToDecimal(txtNumero1.Text);
            Decimal numero2 = Convert.ToDecimal(txtNumero2.Text);
            Decimal numero3 = Convert.ToDecimal(txtNumero3.Text);
          

            if (numero1 <= numero2 && numero1 <= numero3)
            {
                if (numero2 <= numero3)
                {
                    lblCrescente1.Text = numero1.ToString();
                    lblCrescente2.Text = numero2.ToString();
                    lblCrescente3.Text = numero3.ToString();
                }
                else
                {
                    lblCrescente1.Text = numero1.ToString();
                    lblCrescente2.Text = numero3.ToString();
                    lblCrescente3.Text = numero2.ToString();
                }
                else if (numero2 <= numero1 && numero2 <= numero3)
                {
                    if(numero1 <= numero3 )
                    lblCrescente1.Text = numero2.ToString();
                    lblCrescente2.Text = numero1.ToString();
                    lblCrescente3.Text = numero3.ToString();
                }
                else
                {
                    if ()
                }
            }
        }
    }
}
