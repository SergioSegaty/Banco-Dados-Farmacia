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

namespace View
{
    public partial class ListaComestiveis : Form
    {
        public ListaComestiveis()
        {
            InitializeComponent();
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroComestiveis novoCadastro = new CadastroComestiveis();
            novoCadastro.ShowDialog();
        }

        public void AtualizarTabela()
        {
            RepositorioComestiveis repositorio = new RepositorioComestiveis();
            List<Comestivel> comestiveis = repositorio.ObterTodos();
            dgvListaComestiveis.Rows.Clear();

            for (int i = 0; i < comestiveis.Count; i++)
            {
                Comestivel comestivel = comestiveis[i];
                decimal precoTotal = comestivel.Preco * comestivel.Quantidade;
                string precoTotalTexto = $"R$: {precoTotal}";
                string precoTexto = $"R$: {comestivel.Preco}";

                dgvListaComestiveis.Rows.Add(new object[]
                {
                    comestivel.Id, comestivel.Nome, comestivel.Marca, precoTexto, comestivel.Quantidade, precoTotalTexto
                });
            }
        }

        private void ListaComestiveis_Activated(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void dgvListaComestiveis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvListaComestiveis.CurrentRow.Cells[0].Value);

            RepositorioComestiveis repositorio = new RepositorioComestiveis();
            Comestivel comestivel = repositorio.ObterPeloId(id);

            CadastroAlterar cadastroAlterar = new CadastroAlterar(comestivel);
            cadastroAlterar.ShowDialog();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            ApagarDaLista();
        }

        private void ApagarDaLista()
        {
            int id = Convert.ToInt32(dgvListaComestiveis.CurrentRow.Cells[0].Value);
            RepositorioComestiveis repositorio = new RepositorioComestiveis();
            repositorio.Deletar(id);
            AtualizarTabela();

        }
    }
}
