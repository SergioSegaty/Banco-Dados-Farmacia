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
    public partial class CadastroAlterar : Form
    {
        public CadastroAlterar()
        {
            InitializeComponent();
        }

        public CadastroAlterar(Comestivel comesestivel)
        {
            InitializeComponent();

            txtNome.Text = comesestivel.Nome;
            txtMarca.Text = comesestivel.Marca;
            txtPreco.Text = Convert.ToString(comesestivel.Preco);
            txtQuantidade.Text = comesestivel.Quantidade.ToString();
            lblID.Text = comesestivel.Id.ToString();
            dtpDataVencimento.Value = comesestivel.DataVencimento;
        }

        private void SalvarRegistro()
        {
            Comestivel comestivel = new Comestivel();

            comestivel.Id = Convert.ToInt32(lblID.Text);

            comestivel.Nome = txtNome.Text;
            if (comestivel.Nome.Length < 3)
            {
                MessageBox.Show("Por favor, registre o nome do produto.");
                txtNome.Focus();
                return;
            }

            comestivel.Marca = txtMarca.Text;
            if (comestivel.Marca.Length < 3)
            {
                MessageBox.Show("Por favor, registre a marca do produto.");
                txtMarca.Focus();
                return;
            }


            try
            {
                comestivel.Preco = Convert.ToDecimal(txtPreco.Text);
                if (comestivel.Preco < 0)
                {
                    MessageBox.Show("O valor não pode ser menor que 0");
                    txtPreco.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Somente números");
                txtPreco.Focus();
                return;
            }

            try
            {
                comestivel.Quantidade = Convert.ToInt32(txtQuantidade.Text);
                if (comestivel.Quantidade < 0)
                {
                    MessageBox.Show("Somente números maiores que 0");
                    txtQuantidade.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Somente números!");
                txtQuantidade.Focus();
                return;
            }

            comestivel.DataVencimento = dtpDataVencimento.Value;
            DateTime hoje = DateTime.Now;
            if (comestivel.DataVencimento <= hoje)
            {
                MessageBox.Show("Por favor selecione a data de validade");
                dtpDataVencimento.Select();
                SendKeys.Send("%{DOWN}");
                return;
            }

            RepositorioComestiveis repositorio = new RepositorioComestiveis();
            repositorio.AtualizarRegistro(comestivel);
            Close();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarRegistro();
        }
    }
}
