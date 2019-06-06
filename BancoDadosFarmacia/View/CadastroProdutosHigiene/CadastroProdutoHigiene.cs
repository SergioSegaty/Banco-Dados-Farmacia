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
    public partial class CadastroProdutoHigiene : Form
    {
        public CadastroProdutoHigiene()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProdutoHigiene produto = new ProdutoHigiene();

            if (txtNome.Text.Length < 2)
            {
                MessageBox.Show("Registre o nome do produto");
                txtNome.Focus();
                return;
            }
            produto.Nome = txtNome.Text;

            if (cbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a categoria");
                cbCategoria.DroppedDown = true;
                return;
            }
            produto.Categoria = cbCategoria.Text;

            try
            {
                produto.Preco = Convert.ToDecimal(txtPreco.Text);
                if (produto.Preco < 0)
                {
                    MessageBox.Show("O preço precisa ser maior que 0");
                    txtPreco.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Somente números!");
                txtPreco.Focus();
                return;
            }

            RepositorioProdutosHigiene repositorio = new RepositorioProdutosHigiene();
            repositorio.InserirRegistro(produto);

        }
    }
}
