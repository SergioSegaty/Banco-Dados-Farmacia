using Model;
using Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace View.CadastroRemedios
{
    public partial class AlterarProdutoRemedios : Form
    {
        public AlterarProdutoRemedios()
        {
            InitializeComponent();
        }

        public AlterarProdutoRemedios(Remedio remedio)
        {
            lblID.Text = remedio.ID.ToString();
            txtNome.Text = remedio.Nome;
            txtPreco.Text = remedio.Preco.ToString();
            cbCategoria.Text = remedio.Categoria;
            cbFaixa.Text = remedio.Faixa;
            if (remedio.Generico == true)
            {
                ckbGenerico.Checked = true;
            }
            if (remedio.Solido == true)
            {
                ckbSolido.Checked = true;
            }
            if (remedio.Receita == true)
            {
                ckbReceita.Checked = true;
            }


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarRegistro();
        }

        private void SalvarRegistro()
        {
            // Alocando Variaveis

            Remedio remedio = new Remedio();
            // ID
            remedio.ID = Convert.ToInt32(lblID.Text);

            // Nome
            if (txtNome.Text.Length < 3)
            {
                MessageBox.Show("Por favor, insira o Nome do remédio");
                txtNome.Focus();
                return;
            }
            remedio.Nome = txtNome.Text;

            // Preço
            try
            {
                remedio.Preco = Convert.ToDecimal(txtPreco.Text);
                if (remedio.Preco < 0)
                {
                    MessageBox.Show("Somente números maiores que 0");
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

            //Categoria
            if (cbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione uma Categoria");
                cbCategoria.DroppedDown = true;
                return;
            }
            remedio.Categoria = cbCategoria.Text;

            //Faixa
            if (cbFaixa.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione a Faixa do remédio");
                cbFaixa.DroppedDown = true;
                return;
            }
            remedio.Faixa = cbFaixa.Text;

            //Generico
            remedio.Generico = ckbGenerico.Checked;

            //Solido
            remedio.Solido = ckbSolido.Checked;

            //Receita
            remedio.Receita = ckbReceita.Checked;




            remedio.ContraIndicacoes = rtbBula.Text;

            RepositorioRemedios repositorio = new RepositorioRemedios();
            repositorio.AlterarRegistro(remedio);
            Close();
        }
    }
}
