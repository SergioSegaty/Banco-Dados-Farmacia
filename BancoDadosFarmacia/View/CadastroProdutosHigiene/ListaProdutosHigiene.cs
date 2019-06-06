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
    public partial class ListaProdutosHigiene : Form
    {
        public ListaProdutosHigiene()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastroProdutoHigiene cadastro = new CadastroProdutoHigiene();
            cadastro.ShowDialog();
        }

        private void ListaProdutosHigiene_Activated(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void AtualizarTabela()
        {
            RepositorioProdutosHigiene repositorio = new RepositorioProdutosHigiene();
            List<ProdutoHigiene> listaProdutosHigiene = repositorio.ObterTodos();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < listaProdutosHigiene.Count; i++)
            {
                ProdutoHigiene produto = listaProdutosHigiene[i];

                dataGridView1.Rows.Add(new object[]
                {
                    produto.ID, produto.Nome, produto.Categoria, produto.Preco
                });
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            RepositorioProdutosHigiene repositorio = new RepositorioProdutosHigiene();
            ProdutoHigiene produto = repositorio.ObterPeloId(id);

            AlterarProdutoHigiene alterarProduto = new AlterarProdutoHigiene(produto);
            alterarProduto.ShowDialog();

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            RepositorioProdutosHigiene repositorio = new RepositorioProdutosHigiene();

            DialogResult resultado = MessageBox.Show("Você tem certeza?", "AVISO",
                MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                repositorio.Deletar(id);
                AtualizarTabela();

            }

        }
    }
}
