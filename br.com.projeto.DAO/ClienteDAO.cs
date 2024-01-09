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
                MessageBox.Show("Cliente cadastrado com sucesso");

            } catch (Exception erro) 
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
            }
        }
        #endregion
    }
}
