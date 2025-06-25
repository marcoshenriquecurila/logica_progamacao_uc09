using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medias
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btmCalcular_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt16(txtValor1.Text);
            int numero2 = Convert.ToInt16(txtValor2.Text);
            int numero3 = Convert.ToInt16(txtValor3.Text);
            decimal media = (numero1 + numero2 + numero3) / 3;

            MessageBox.Show("A média é: " + media.ToString());

            if (numero1 < media)
            {
                txtValor1.ForeColor = Color.Blue;
            }
            if (numero2 < media)
            {
                txtValor2.ForeColor = Color.Blue;

            }

                if (numero3 < media)
                {
                    txtValor3.ForeColor = Color.Blue;
                }
        }
    }
}
