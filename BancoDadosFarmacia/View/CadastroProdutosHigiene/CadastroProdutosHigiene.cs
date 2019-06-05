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

namespace View.CadastroProdutosHigiene
{
    public partial class CadastroProdutosHigiene : Form
    {
        public CadastroProdutosHigiene()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProdutoHigiene produto = new ProdutoHigiene();

            if (txtNome.Text.Length < 3)
            {
                MessageBox.Show("Por favor, registre o nome do produto Corretamente.");
                txtNome.Focus();
                return;
            }

            produto.Nome = txtNome.Text;

            if (cbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a categoria do produto");
                cbCategoria.DroppedDown = true;
                return;
            }

            if (txtPreco.Text.Length < 1)
            {
                MessageBox.Show("Prencha o valor do produto");
                txtPreco.Focus();
                return;
            }
            try
            {
                produto.Preco = Convert.ToDecimal(txtPreco.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Somente números");
                txtPreco.Focus();
                return;
            }
        }
    }
}
