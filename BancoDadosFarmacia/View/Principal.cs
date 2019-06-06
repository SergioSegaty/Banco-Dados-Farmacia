using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.CadastroComestiveis;
using View.CadastroProdutosHigiene;

namespace View
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnComestiveis_Click(object sender, EventArgs e)
        {
            ListaComestiveis cadastroComestiveis = new ListaComestiveis();
            cadastroComestiveis.ShowDialog();
        }

        private void bntHigiene_Click(object sender, EventArgs e)
        {
            ListaProdutosHigiene cadastroHigiene = new ListaProdutosHigiene();
            cadastroHigiene.ShowDialog();
        }
    }
}
