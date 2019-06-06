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
   public class RepositorioProdutosHigiene
    {
        string CadeiaDeConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\62110\Documents\ExemploDB02.mdf;Integrated Security=True;Connect Timeout=30";

        public void InserirRegistro(ProdutoHigiene produto)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO produtos_higiene 
            (nome, categoria, preco)
            VALUES
            (@NOME, @CATEGORIA, @PRECO)";            

            comando.Parameters.AddWithValue("@NOME", produto.Nome);
            comando.Parameters.AddWithValue("@CATEGORIA", produto.Categoria);
            comando.Parameters.AddWithValue("@PRECO", produto.Preco);

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
            List<ProdutoHigiene> listaProdutos = new List<ProdutoHigiene>();

            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow row = tabela.Rows[i];
                ProdutoHigiene produto = new ProdutoHigiene();

                produto.ID = Convert.ToInt32(row["id"]);
                produto.Nome = row["nome"].ToString();
                produto.Categoria = row["categoria"].ToString();
                produto.Preco = Convert.ToDecimal(row["preco"]);
                listaProdutos.Add(produto);

            }
            return listaProdutos;

        }
        public ProdutoHigiene ObterPeloId(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM produtos_higiene WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            if (tabela.Rows.Count == 1)
            {
                DataRow row = tabela.Rows[0];
                ProdutoHigiene produto = new ProdutoHigiene();

                produto.ID = Convert.ToInt32(row["id"]);
                produto.Nome = row["nome"].ToString();
                produto.Preco = Convert.ToDecimal(row["preco"]);
                produto.Categoria = row["categoria"].ToString();

                return produto;
                
            }

            return null;
        }
        public void Deletar(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"DELETE from produtos_higiene
            WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public void Atualizar(ProdutoHigiene produto)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE produtos_higiene SET
            nome = @NOME,
            preco = @PRECO,
            categoria = @CATEGORIA
            WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", produto.Nome);
            comando.Parameters.AddWithValue("@PRECO", produto.Preco);
            comando.Parameters.AddWithValue("@CATEGORIA", produto.Categoria);
            comando.Parameters.AddWithValue("@ID", produto.ID);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}
