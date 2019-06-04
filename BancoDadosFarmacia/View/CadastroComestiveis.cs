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

            comestivel.Marca = txtMarca.Text;

            comestivel.Preco = Convert.ToDecimal(txtPreco.Text);

            comestivel.Quantidade = Convert.ToInt32(txtQuantidade.Text);

            comestivel.dataVencimento = dtpDataVencimento.Value;

            RepositorioComestiveis repositorio = new RepositorioComestiveis();
            repositorio.Inserir(comestivel);

            
        }
    }
}
