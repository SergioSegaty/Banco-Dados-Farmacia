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
    public class RepositorioComestiveis
    {
        string CadeiaDeConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\62110\Documents\ExemploDB02.mdf;Integrated Security=True;Connect Timeout=30";

        public List<Comestivel> ObterTodos()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM comestiveis";
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            List<Comestivel> comestiveis = new List<Comestivel>();
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                Comestivel comestivel = new Comestivel();

                comestivel.Id = Convert.ToInt32(linha["id"]);
                comestivel.Nome = linha["nome"].ToString();
                comestivel.Preco = Convert.ToDecimal(linha["preco"]);
                comestivel.Marca = linha["marca"].ToString();
                comestivel.Quantidade = Convert.ToInt32(linha["quantidade"]);
                comestivel.dataVencimento = Convert.ToDateTime(linha["data_vencimento"]);

                comestiveis.Add(comestivel);

            }
            return comestiveis;            
        }

        public void Inserir(Comestivel comestivel)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();


            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO comestiveis
            (nome, preco, data_vencimento, quantidade, marca)

            VALUES
            (@NOME, @PRECO, @DATA_VENCIMENTO, @QUANTIDADE, @MARCA)";

            comando.Parameters.AddWithValue("@NOME", comestivel.Nome);
            comando.Parameters.AddWithValue("@PRECO", comestivel.Preco);
            comando.Parameters.AddWithValue("@DATA_VENCIMENTO", comestivel.dataVencimento);
            comando.Parameters.AddWithValue("@QUANTIDADE", comestivel.Quantidade);
            comando.Parameters.AddWithValue("@MARCA", comestivel.Marca);

            comando.ExecuteNonQuery();
            conexao.Close();

        }

        public void Deletar(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"DELETE FROM comestiveis WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public Comestivel ObterPeloId(int id)
        {

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM comestiveis 
            where id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            comando.ExecuteNonQuery();
            conexao.Close();
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[0];
                Comestivel comestivel = new Comestivel();

                comestivel.Id = Convert.ToInt32(linha["id"]);
                comestivel.Nome = Convert.ToString(linha["nome"]);
                comestivel.Marca = (linha["marca"].ToString());
                comestivel.Quantidade = Convert.ToInt32(linha["quantidade"]);
                comestivel.dataVencimento = Convert.ToDateTime(linha["data_vencimento"]);
                comestivel.Preco = Convert.ToInt32(linha["preco"]);

                return comestivel;
            }
            return null;
        }

    }
}
