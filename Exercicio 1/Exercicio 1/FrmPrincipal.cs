using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Valor1 = (Convert.ToInt32(txtValor1.Text));
            int Valor2 = (Convert.ToInt32(txtValor2.Text));

            int Soma = (Valor1 +  Valor2);
            lblSoma.Text = Soma.ToString();



                
        }
    }
}
