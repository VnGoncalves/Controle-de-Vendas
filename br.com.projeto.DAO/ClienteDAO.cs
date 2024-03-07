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
    public class ClienteDAO
    {
        private SqlConnection conexao;
        public ClienteDAO() 
        {
            this.conexao = new ConnectionFactory().getConnection();
        }

        #region Cadastrar Cliente
        public void cadastrarCliente(Cliente obj)
        {
            try 
            {
                // 1 -  Comando insert para cadastrar o cliente

                string sql = @"insert into tb_clientes (nome, rg, cpf, email, telefone, celular, cep, endereco, 
                                numero, complemento, bairro, cidade, estado)
                                    values(@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, 
                                @numero, @complemento, @bairro, @cidade, @estado)";

                //  2 - Organizar o comando CMD
                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
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

                // 3 - Abrir conexao e executar o comando SQL

                conexao.Open();
                executacmd.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Cliente cadastrado com sucesso", "SUCESSO.");

            } catch (Exception erro) 
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
            }
        }
        #endregion

        #region Listar Clientes

        public DataTable listarClientes()
        {
            try
            {
                // 1 Criar o DataTable e o comando SQL

                DataTable tabelaCliente = new DataTable();
                string sql = @"select 
                                	id				[CODIGO],
                                	nome			[NOME CLIENTE],
                                	rg				[RG],
                                	cpf				[CPF], 
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
                                from tb_clientes";
                // 2 Organizar o comando sql e executar

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // 3 Criar o SqlDataAdapter para preencher os dados no DataTable

                SqlDataAdapter da = new SqlDataAdapter(executacmd);
                da.Fill(tabelaCliente);

                conexao.Close();
                return tabelaCliente;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
                return null;
            }
        }
        #endregion

        #region Alterar Cliente
        
        public void alterarCliente(Cliente obj)
        {
            // Metodo para Alterar o cliente no sistema

            try
            {
                // 1 - comando sql para alterar os campos desejados
                string sql = @"update tb_clientes set nome = @nome, rg = @rg, cpf = @cpf, email = @email, telefone = @telefone,
                                                  celular = @celular, cep = @cep, endereco = @cep, 
                                                  numero = @numero, complemento = @complemento, bairro = @bairro, 
                                                  cidade = @cidade, estado = @estado
                              where id = @id";
                //2 - Associando os parametros dos campos do sistema ao codigo sql
                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
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
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                //3 - Executando o codigo sql
                conexao.Open();
                executacmd.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Cliente alterado com sucesso", "SUCESSO.");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu algum erro: " + erro);
            }
        }

        #endregion

        #region Exluir Cliente
        public void excluirCliente(Cliente obj)
        {
            try
            {
                // 1 - Comando sql para excluir o registro
                string sql = "delete from tb_clientes where id = @id";

                // 2 - Associar o registro para o parametro do codigo
                SqlCommand executecmd = new SqlCommand(sql, conexao);
                executecmd.Parameters.AddWithValue("@id", obj.codigo);

                // 3 - Executar codigo sql
                conexao.Open();
                executecmd.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Cliente excluido com sucesso.", "SUCESSO.");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu algum erro: "+ erro);
            }
        }

        #endregion

        #region Buscar Cliente por nome

        public DataTable buscarClientePorNome(string nome)
        {
            try
            {
                // 1 Criar o DataTable e o comando SQL

                DataTable tabelaCliente = new DataTable();
                string sql = @"select 
                                	id				[CODIGO],
                                	nome			[NOME CLIENTE],
                                	rg				[RG],
                                	cpf				[CPF], 
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
                                from tb_clientes where nome like @nome";
                // 2 Organizar o comando sql e executar

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // 3 Criar o SqlDataAdapter para preencher os dados no DataTable

                SqlDataAdapter da = new SqlDataAdapter(executacmd);
                da.Fill(tabelaCliente);

                conexao.Close();
                return tabelaCliente;
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