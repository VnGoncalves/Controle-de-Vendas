﻿using Controle_de_Vendas.br.com.projeto.CONEXAO;
using Controle_de_Vendas.br.com.projeto.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Vendas.br.com.projeto.DAO
{
    public class ProdutoDAO
    {
        private SqlConnection conexao;
        public ProdutoDAO() 
        {
            this.conexao = new ConnectionFactory().getConnection();
        }

        #region Cadastrar Produto

        public void cadastrarProduto(Produto obj)
        {
            try
            {
                string sql = @"insert into tb_Produtos (descricao, preco, qtd_estoque, for_id)
                                                        values (@descricao, @preco, @qtd_estoque, @for_id)";

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@qtd_estoque", obj.qtd_estoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.fornecedorID);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Produto cadastrado com sucesso", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
            }
        }

        #endregion

        #region Listar Produtos

        public DataTable listarProdutos()
        {
            DataTable tabelaProduto = new DataTable();

            string sql = @"SELECT 
	                        TP.DESCRICAO,
	                        TP.PRECO,
	                        TP.QTD_ESTOQUE [QUANTIDADE ESTOQUE],
	                        TF.NOME [FORNECEDOR]
                            FROM TB_PRODUTOS TP
	                        INNER JOIN TB_FORNECEDORES TF ON TF.ID = TP.FOR_ID";
            
            SqlCommand executacmd = new SqlCommand(sql, conexao);
            conexao.Open();
            executacmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(executacmd);
            da.Fill(tabelaProduto);
            conexao.Close();

            return tabelaProduto;
        }

        #endregion
    }
}