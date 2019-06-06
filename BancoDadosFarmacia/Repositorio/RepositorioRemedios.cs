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
    public class RepositorioRemedios
    {
        string CadeiaDeConexao = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Seek3r_Home.mdf;Integrated Security = True; Connect Timeout = 30";
        public void InserirRegistro(Remedio remedio)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO produtos_remedios
            (nome, categoria, faixa, contra_indicacao, preco, generico, solido, receita)
            
            VALUES
            (@NOME, @CATEGORIA, @FAIXA, @CONTRA_INDICACAO, @PRECO, @GENERICO, @SOLIDO, @RECEITA)";

            comando.Parameters.AddWithValue("@NOME", remedio.Nome);
            comando.Parameters.AddWithValue("@CATEGORIA", remedio.Categoria);
            comando.Parameters.AddWithValue("@FAIXA", remedio.Faixa);
            comando.Parameters.AddWithValue("@CONTRA_INDICACAO", remedio.ContraIndicacoes);
            comando.Parameters.AddWithValue("@PRECO", remedio.Preco);
            comando.Parameters.AddWithValue("@GENERICO", remedio.Generico);
            comando.Parameters.AddWithValue("@SOLIDO", remedio.Solido);
            comando.Parameters.AddWithValue("@RECEITA", remedio.Receita);

            comando.ExecuteNonQuery();
            conexao.Close();

        }

        public List<Remedio> ObterTodos()
        {

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM produtos_remedios";

            List<Remedio> remedios = new List<Remedio>();
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow row = tabela.Rows[i];
                Remedio remedio = new Remedio();

                remedio.ID = Convert.ToInt32(row["id"]);
                remedio.Nome = row["nome"].ToString();
                remedio.Categoria = row["categoria"].ToString();
                remedio.Faixa = row["faixa"].ToString();
                remedio.Preco = Convert.ToDecimal(row["preco"]);
                remedio.Receita = Convert.ToBoolean(row["receita"]);
                remedio.Solido = Convert.ToBoolean(row["solido"]);
                remedio.Generico = Convert.ToBoolean(row["generico"]);
                remedio.ContraIndicacoes = row["contra_indicacao"].ToString();
                remedios.Add(remedio);
            }
            return remedios;
        }

        public void Deletar(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"DELETE FROM produtos_remedios
            WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);


            comando.ExecuteNonQuery();
            conexao.Close();

        }

        public Remedio ObterPeloID(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM produtos_remedios
            WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            conexao.Close();
            if (tabela.Rows.Count == 1)
            {
                Remedio remedio = new Remedio();
                DataRow row = tabela.Rows[0];

                remedio.ID = Convert.ToInt32(row["id"]);
                remedio.Nome = row["nome"].ToString();
                remedio.Preco = Convert.ToDecimal(row["preco"]);
                remedio.Categoria = row["categoria"].ToString();
                remedio.Faixa = row["faixa"].ToString();
                remedio.Receita = Convert.ToBoolean(row["receita"]);
                remedio.Solido = Convert.ToBoolean(row["solido"]);
                remedio.Generico = Convert.ToBoolean(row["generico"]);
                remedio.ContraIndicacoes = row["contra_indicacao"].ToString();

                return remedio;
            }
            return null;

        }

        public void AlterarRegistro(Remedio remedio)
        {

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE produtos_remedios SET
            nome = @NOME,
            preco = @PRECO,
            categoria = @CATEGORIA,
            faixa = @FAIXA,
            contra_indicacao = @CONTRA_INDICACAO,
            generico = @GENERICO,
            solido = @SOLIDO,
            receita = @RECEITA

            WHERE id = @ID";

            comando.Parameters.AddWithValue("@NOME", remedio.Nome);
            comando.Parameters.AddWithValue("@CATEGORIA", remedio.Categoria);
            comando.Parameters.AddWithValue("@FAIXA", remedio.Faixa);
            comando.Parameters.AddWithValue("@CONTRA_INDICACAO", remedio.ContraIndicacoes);
            comando.Parameters.AddWithValue("@PRECO", remedio.Preco);
            comando.Parameters.AddWithValue("@GENERICO", remedio.Generico);
            comando.Parameters.AddWithValue("@SOLIDO", remedio.Solido);
            comando.Parameters.AddWithValue("@RECEITA", remedio.Receita);
            comando.Parameters.AddWithValue("@ID", remedio.ID);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

    }
}
