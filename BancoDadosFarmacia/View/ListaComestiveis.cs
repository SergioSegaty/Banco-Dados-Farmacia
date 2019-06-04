﻿using System;
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
            List<Comestivel> comestiveis = new List<Comestivel>();
            dgvListaComestiveis.Rows.Clear();

            for (int i = 0; i < comestiveis.Count; i++)
            {
                Comestivel comestivel = comestiveis[i];
                decimal precoTotal = comestivel.Preco * comestivel.Quantidade;
                string precoTotalTexto = $"R$: {precoTotal}";

                dgvListaComestiveis.Rows.Add(new object[]
                {
                    comestivel.Id, comestivel.Nome, comestivel.Marca, comestivel.Preco, comestivel.Quantidade, precoTotalTexto
                });
            }
        }
    }
}
