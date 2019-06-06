using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositorio;
using Model;

namespace View.CadastroProdutosHigiene
{
    public partial class AlterarProdutoHigiene : Form
    {
        public AlterarProdutoHigiene()
        {
            InitializeComponent();
        }

        public AlterarProdutoHigiene(ProdutoHigiene produto)
        {
            InitializeComponent();
            txtNome.Text = produto.Nome;
            cbCategoria.Text = produto.Categoria;
            txtPreco.Text = produto.Preco.ToString();
            lblID.Text = produto.ID.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarRegistro();
        }

        private void AlterarRegistro()
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

            produto.ID = Convert.ToInt32(lblID.Text);

            RepositorioProdutosHigiene repositorio = new RepositorioProdutosHigiene();
            repositorio.Atualizar(produto);
            Close();
        }
    }
}
