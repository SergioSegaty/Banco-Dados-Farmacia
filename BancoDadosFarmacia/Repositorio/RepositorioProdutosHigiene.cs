using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repositorio
{
    class RepositorioProdutosHigiene
    {
        string CadeiaDeConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\62110\Documents\ExemploDB02.mdf;Integrated Security=True;Connect Timeout=30";

        public void InserirRegistro()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO protudos_higiene 
            (nome, categoria, preco)
            VALUES
            (@NOME, @CATEGORIA, @PRECO)";

            ProdutoHigiene produtoHigiene = new ProdutoHigiene();

            comando.Parameters.AddWithValue("@NOME", produtoHigiene.Nome);
            comando.Parameters.AddWithValue("@CATEGORIA", produtoHigiene.Categoria);
            comando.Parameters.AddWithValue("@PRECO", produtoHigiene.Preco);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public List<ProdutoHigiene> ObterTodos()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM produtos_higiene";
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());


        }


    }
}
