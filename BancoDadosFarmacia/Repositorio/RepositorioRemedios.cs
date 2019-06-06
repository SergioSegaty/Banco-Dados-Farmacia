using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repositorio
{
    public class RepositorioRemedios
    {
        string CadeiaDeConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\62110\Documents\ExemploDB02.mdf;Integrated Security=True;Connect Timeout=30";
        public void InserirRegistro(Remedios remedios)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO produtos_remedios
            (nome, categoria, faixa, contra_indicacao, preco, generico, solido, receita
            
            VALUES
            (@NOME, @CATEGORIA, @FAIXA, @CONTRA_INDICACAO, @PRECO, @GENERICO, @SOLIDO, @RECEITA)";

            comando.Parameters.AddWithValue("@NOME",remedios.Nome);
            comando.Parameters.AddWithValue("@CATEGORIA", remedios.Categoria);
            comando.Parameters.AddWithValue("@FAIXA", remedios.Faixa);
            comando.Parameters.AddWithValue("@CONTRA_INDICACAO", remedios.ContraIndicacoes);
            comando.Parameters.AddWithValue("@PRECO", remedios.Preco);
            comando.Parameters.AddWithValue("@GENERICO", remedios.Generico);
            comando.Parameters.AddWithValue("@SOLIDO", remedios.Solido);
            comando.Parameters.AddWithValue("@RECEITA", remedios.Receita);

            comando.ExecuteNonQuery();
            conexao.Close();            

        }
    }
}
