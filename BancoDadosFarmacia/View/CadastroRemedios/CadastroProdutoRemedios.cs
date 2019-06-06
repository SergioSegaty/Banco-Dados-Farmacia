using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Repositorio;

namespace View.CadastroRemedios
{
    public partial class CadastroProdutoRemedios : Form
    {
        public CadastroProdutoRemedios()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastroProdutoRemedios produtoRemedios = new CadastroProdutoRemedios();
            produtoRemedios.ShowDialog();
        }
    }
}
