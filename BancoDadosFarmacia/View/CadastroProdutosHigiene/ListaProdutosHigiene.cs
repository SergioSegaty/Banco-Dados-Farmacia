﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            SalvarRegistro();
        }

        private void SalvarRegistro()
        {
            throw new NotImplementedException();
        }
    }
}