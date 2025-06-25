using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_2_novo
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                Decimal Nota1 = Convert.ToDecimal(txtNota1.Text);
                Decimal Nota2 = Convert.ToDecimal(txtNota2.Text);
                Decimal Nota3 = Convert.ToDecimal(txtNota3.Text);
                Decimal Nota4 = Convert.ToDecimal(txtNota2.Text);

                Decimal Media = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
            lblResultado.Text = Media.ToString();
        }
    }
}
