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
    public class FuncionarioDAO
    {
        private SqlConnection conexao;

        public FuncionarioDAO()
        {
            this.conexao = new ConnectionFactory().getConnection();
        }

        #region Cadastrar Funcionario

        public void cadastrarFuncionario(Funcionario obj)
        {
            try
            {
                // Criar comando para inserir funcionario

                string sql = @"insert into tb_funcionarios (nome, rg, cpf, email, senha, cargo, nivel_acesso,telefone, celular, cep, endereco, 
                                numero, complemento, bairro, cidade, estado)
                                    values(@nome, @rg, @cpf, @email, @senha, @cargo, @nivel_acesso,@telefone, @celular, @cep, @endereco, 
                                @numero, @complemento, @bairro, @cidade, @estado)";
                // Organizar e executar o comando sql

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);
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

                MessageBox.Show("Funcionario cadastrado com sucesso", "SUCESSO.");

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro" + erro);
            }
        }

        #endregion

        #region Evento listar funcionarios
        public DataTable listarFuncionarios()
        {
            try
            {
                // 1 Criar o DataTable e o comando SQL

                DataTable tabelaFuncionario = new DataTable();
                string sql = @"select 
                                	id				[CODIGO],
                                	nome			[NOME],
                                	rg				[RG],
                                	cpf				[CPF], 
                                	email			[E-MAIL],
                                    senha           [SENHA],
                                    cargo           [CARGO],
                                    nivel_acesso    [NIVEL ACESSO],
                                	telefone		[TELEFONE],
                                	celular			[CELULAR],
                                	cep				[CEP],
                                	endereco		[ENDERECO],
                                	numero			[NUMERO],
                                	complemento		[COMPLEMENTO],
                                	bairro			[BAIRRO],
                                	cidade			[CIDADE],
                                	estado			[ESTADO]
                                from tb_Funcionarios";

                // 2 Organizar o comando sql e executar

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // 3 Criar o SqlDataAdapter para preencher os dados no DataTable

                SqlDataAdapter da = new SqlDataAdapter(executacmd);
                da.Fill(tabelaFuncionario);

                conexao.Close();
                return tabelaFuncionario;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
                return null;
            }
        }
        #endregion

        #region Metodo Alterar Funcionario

        public void alterarFuncionario(Funcionario obj)
        {
            try
            {
                // 1 - comando sql para alterar os campos desejados
                string sql = @"update tb_Funcionarios set nome = @nome, rg = @rg, cpf = @cpf, email = @email, 
                                                  senha = @senha, cargo = @cargo, nivel_acesso = @nivel_acesso
                                                  telefone = @telefone,
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
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);
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

                MessageBox.Show("Funcionario alterado com sucesso", "SUCESSO.");
            }
            catch (Exception e)
            {

                MessageBox.Show("Aconteceu um erro" + e);
            }
        }
        #endregion
    }
}
