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

namespace AlturaMédia
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
       
        private void Calcular_Click(object sender, EventArgs e)

    
        {
            decimal a1 = Convert.ToDecimal(txtA1.Text);
            decimal a2 = Convert.ToDecimal(txtA2.Text);
            decimal a3 = Convert.ToDecimal(txtA3.Text);

            decimal media = (a1 + a2 + a3) / 3;


            lblMedia.Text =  Math.Round(media,1).ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
