using Controle_de_Vendas.br.com.projeto.CONEXAO;
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
                        	TP.ID [CODIGO],
                        	TP.DESCRICAO,
                        	TP.PRECO,
                        	TP.QTD_ESTOQUE [QTD ESTOQUE],
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

        #region Procurar Produto por nome

        public DataTable buscarProdutoPorNome(string nome)
        {
            try
            {
                // 1 Criar o DataTable e o comando SQL

                DataTable tabelaProduto = new DataTable();
                string sql = @"SELECT 
                        	TP.ID [CODIGO],
                        	TP.DESCRICAO,
                        	TP.PRECO,
                        	TP.QTD_ESTOQUE [QTD ESTOQUE],
                        	TF.NOME [FORNECEDOR]
                          FROM TB_PRODUTOS TP
                        	INNER JOIN TB_FORNECEDORES TF ON TF.ID = TP.FOR_ID
                          WHERE DESCRICAO like @NOME";
                // 2 Organizar o comando sql e executar

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // 3 Criar o SqlDataAdapter para preencher os dados no DataTable

                SqlDataAdapter da = new SqlDataAdapter(executacmd);
                da.Fill(tabelaProduto);

                conexao.Close();
                return tabelaProduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
                return null;
            }
        }

        #endregion

        #region Excluir Produto

        public void excluirProduto(Produto obj)
        {
            try
            {
                string sql = "delete from tb_Produtos where id = @id";

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Produto excluído.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu algum erro: " + erro);
            }
        }

        #endregion

        #region Alterar Produto

        public void alterarProduto(Produto obj)
        {
            try
            {
                try
                {
                    string sql = @"update tb_Produtos set descricao = @descricao, preco = @preco, qtd_estoque = @qtd_estoque, for_id = @for_id where id = @id";

                    SqlCommand executacmd = new SqlCommand(sql, conexao);
                    executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                    executacmd.Parameters.AddWithValue("@preco", obj.preco);
                    executacmd.Parameters.AddWithValue("@qtd_estoque", obj.qtd_estoque);
                    executacmd.Parameters.AddWithValue("@for_id", obj.fornecedorID);
                    executacmd.Parameters.AddWithValue("@id", obj.codigo);


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
            catch (Exception e)
            {

                MessageBox.Show("Aconteceu um erro" + e);
            }
        }

        #endregion
    }
}
