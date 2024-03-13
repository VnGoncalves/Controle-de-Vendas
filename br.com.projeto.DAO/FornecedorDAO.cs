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
    public class FornecedorDAO
    {
        private SqlConnection conexao;

        public FornecedorDAO()
        {
            this.conexao = new ConnectionFactory().getConnection();
        }
        #region Cadastrar Fornecedor
        public void cadastrarFornecedor(Fornecedor obj)
        {
            try
            {
                // Criar comando para inserir funcionario

                string sql = @"insert into tb_fornecedores (nome,cnpj ,email ,telefone ,celular ,cep ,endereco , 
                                numero ,complemento ,bairro ,cidade ,estado )
                                    values(@nome,@cnpj ,@email ,@telefone, @celular, @cep, @endereco, 
                                @numero, @complemento, @bairro, @cidade, @estado)";
                // Organizar e executar o comando sql

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.CNPJ);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                // Abrir conexao

                conexao.Open();
                // Executa comando
                executacmd.ExecuteNonQuery();

                // Fechar conexao
                conexao.Close();

                MessageBox.Show("Fornecedor cadastrado com sucesso", "SUCESSO.");

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro" + erro);
            }
        }
        #endregion

        #region Excluir Fornecedor

        public void excluirFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = "delete from tb_fornecedores where id = @id";

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                conexao.Open() ;
                executacmd.ExecuteNonQuery();
                conexao.Close();
                
                MessageBox.Show("Fornecedor excluido com sucesso", "SUCESSO.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu algum erro: " + erro);
            }
        }

        #endregion

        #region Alterar Fornecedor

        public void alterarFornecedor(Fornecedor obj)
        {
            try
            {
                // 1 - comando sql para alterar os campos desejados
                string sql = @"update 
                                    tb_fornecedores
                                    set nome = @nome,
                                    cnpj = @cnpj,
                                    email = @email,
                                    telefone = @telefone,
                                    celular = @celular,
                                    cep = @cep,
                                    endereco = @endereco,
                                    numero = @numero,
                                    complemento = @complemento,
                                    bairro = @bairro,
                                    cidade = @cidade,
                                    estado = @estado
                                where id = @id";


                //2 - Associando os parametros dos campos do sistema ao codigo sql
                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.CNPJ);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.cidade);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                //3 - Executando o codigo sql
                conexao.Open();
                executacmd.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Fornecedor alterado com sucesso", "SUCESSO.");
            }
            catch (Exception e)
            {

                MessageBox.Show("Aconteceu um erro" + e);
            }
        }
        #endregion

        #region Listar Fornecedores

        public DataTable listarFornecedores()
        {
            try
            {
                // 1 Criar o DataTable e o comando SQL

                DataTable tabelaFornecedor = new DataTable();
                string sql = @"select 
                                	id				[CODIGO],
                                	nome			[FORNECEDOR],
                                	cnpj            [CNPJ],
                                	email			[E-MAIL],
                                	telefone		[TELEFONE],
                                	celular			[CELULAR],
                                	cep				[CEP],
                                	endereco		[ENDERECO],
                                	numero			[NUMERO],
                                	complemento		[COMPLEMENTO],
                                	bairro			[BAIRRO],
                                	cidade			[CIDADE],
                                	estado			[ESTADO]
                                from tb_fornecedores";

                // 2 Organizar o comando sql e executar

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // 3 Criar o SqlDataAdapter para preencher os dados no DataTable

                SqlDataAdapter da = new SqlDataAdapter(executacmd);
                da.Fill(tabelaFornecedor);

                conexao.Close();
                return tabelaFornecedor;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
                return null;
            }
        }

        #endregion

        #region Buscar Fornecedor por Nome
        public DataTable buscarFornecedorPorNome(string nome)
        {
            try
            {
                // 1 Criar o DataTable e o comando SQL

                DataTable tabelaFornecedor = new DataTable();
                string sql = @"select 
                                	id				[CODIGO],
                                	nome			[FORNECEDOR],
                                	cnpj            [CNPJ],
                                	email			[E-MAIL],
                                	telefone		[TELEFONE],
                                	celular			[CELULAR],
                                	cep				[CEP],
                                	endereco		[ENDERECO],
                                	numero			[NUMERO],
                                	complemento		[COMPLEMENTO],
                                	bairro			[BAIRRO],
                                	cidade			[CIDADE],
                                	estado			[ESTADO]
                                from tb_fornecedores where nome like @nome";
                // 2 Organizar o comando sql e executar

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // 3 Criar o SqlDataAdapter para preencher os dados no DataTable

                SqlDataAdapter da = new SqlDataAdapter(executacmd);
                da.Fill(tabelaFornecedor);

                conexao.Close();
                return tabelaFornecedor;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
                return null;
            }
        }
        #endregion
    }
}