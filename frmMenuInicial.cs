using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSorveteriaSimples
{
    public partial class frmMenuInicial : Form
    {
        public frmMenuInicial()
        {
            InitializeComponent();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frmProdutos frm_produtos = new frmProdutos();

            frm_produtos.ShowDialog();
        }
    }
}
