﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repositorio;

namespace Repositorio
{
    public class RepositorioComestiveis
    {
        Servidor servidor = new Servidor();

        string CadeiaDeConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Seek3r_Home.mdf;Integrated Security = True; Connect Timeout = 30";

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
                comestivel.DataVencimento = Convert.ToDateTime(linha["data_vencimento"]);

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
            comando.Parameters.AddWithValue("@DATA_VENCIMENTO", comestivel.DataVencimento);
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
            conexao.Close();
            if (tabela.Rows.Count == 1)
            {
                DataRow linha = tabela.Rows[0];
                Comestivel comestivel = new Comestivel();

                comestivel.Id = Convert.ToInt32(linha["id"]);
                comestivel.Nome = Convert.ToString(linha["nome"]);
                comestivel.Marca = (linha["marca"].ToString());
                comestivel.Quantidade = Convert.ToInt32(linha["quantidade"]);
                comestivel.DataVencimento = Convert.ToDateTime(linha["data_vencimento"]);
                comestivel.Preco = Convert.ToDecimal(linha["preco"]);

                return comestivel;
            }            
            return null;
        }

        public void AtualizarRegistro(Comestivel comestivel)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE comestiveis SET
            nome = @NOME,
            marca = @MARCA,
            preco = @PRECO,
            quantidade = @QUANTIDADE,
            data_vencimento = @DATA_VENCIMENTO
            WHERE id = @ID";

            comando.Parameters.AddWithValue("@NOME", comestivel.Nome);
            comando.Parameters.AddWithValue("@MARCA", comestivel.Marca);
            comando.Parameters.AddWithValue("@PRECO", comestivel.Preco);
            comando.Parameters.AddWithValue("@QUANTIDADE", comestivel.Quantidade);
            comando.Parameters.AddWithValue("@DATA_VENCIMENTO", comestivel.DataVencimento);
            comando.Parameters.AddWithValue("@ID", comestivel.Id);

            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}
