using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NomeCompleto
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            lblNomeCompleto.Text = txtNome.Text + " " + txtSobrenome.Text;
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
