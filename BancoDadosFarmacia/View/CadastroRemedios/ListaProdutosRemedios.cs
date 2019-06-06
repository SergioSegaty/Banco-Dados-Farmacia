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
using View.CadastroRemedios;

namespace View.CadastroRemedios
{
    public partial class ListaProdutosRemedios : Form
    {
        private void ListaProdutosRemedios_Activated(object sender, EventArgs e)
        {
            AtualizarTabela();

        }
        public ListaProdutosRemedios()
        {
            InitializeComponent();
        }


        private void AtualizarTabela()
        {
            RepositorioRemedios repositorio = new RepositorioRemedios();
            List<Remedio> remedios = repositorio.ObterTodos();

            dgvRemedios.Rows.Clear();
            for (int i = 0; i < remedios.Count; i++)
            {
                Remedio remedio = remedios[i];

                string precoRemedio = $"R$ {remedio.Preco}";
                string receitaTexto = "Não";
                if (remedio.Receita == true)
                {
                    receitaTexto = "Sim";
                }


                dgvRemedios.Rows.Add(new object[]
                {
                    remedio.ID, remedio.Nome, precoRemedio, remedio.Faixa, receitaTexto
                });
            }

        }

        private void bntCadastrar_Click(object sender, EventArgs e)
        {
            CadastroProdutoRemedios produtoRemedios = new CadastroProdutoRemedios();
            produtoRemedios.ShowDialog();
        }

        private void dgvRemedios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRemedios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um registro");
                return;
            }

            int id = Convert.ToInt32(dgvRemedios.CurrentRow.Cells[0].Value);
            RepositorioRemedios repositorio = new RepositorioRemedios();
            Remedio remedio = repositorio.ObterPeloID(id);

            AlterarProdutoRemedios alterarProdutoRemedio = new  AlterarProdutoRemedios(remedio);



        }
    }
}
