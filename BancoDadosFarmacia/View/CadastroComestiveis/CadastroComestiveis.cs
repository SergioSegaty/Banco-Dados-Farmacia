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

namespace View.CadastroComestiveis
{
    public partial class CadastroComestiveis : Form
    {
        public CadastroComestiveis()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarRegistro();
        }

        private void SalvarRegistro()
        {
            Comestivel comestivel = new Comestivel();

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
            repositorio.Inserir(comestivel);
            Close();

        }

        private void DtpDataVencimento_DropDown(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
