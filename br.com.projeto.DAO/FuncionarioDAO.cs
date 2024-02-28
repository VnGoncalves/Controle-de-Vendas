using Controle_de_Vendas.br.com.projeto.CONEXAO;
using Controle_de_Vendas.br.com.projeto.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Vendas.br.com.projeto.DAO
{
    public  class FuncionarioDAO
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

                string sql = "insert into tb_funcionarios (nome, rg, cpf, email, senha, cargo, nivel_acesso, celular," +
                    " cep, endereco, numero, complemento, bairro, cidade, estado) " +
                    "values (@nome, @rg, @cpf, @email, @senha, @cargo, @nivel_acesso, @celular, @cep, @endereco, @numero, @complemento" +
                    "@bairro, @cidade, @estado)";
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

    }
}
