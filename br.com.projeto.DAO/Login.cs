using Controle_de_Vendas.br.com.projeto.CONEXAO;
using Controle_de_Vendas.br.com.projeto.MODEL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Vendas.br.com.projeto.DAO
{
    public class Login
    {
        public string nomeFuncionario { get; set; }

        private SqlConnection conexao;
        public Login()
        {
            this.conexao = new ConnectionFactory().getConnection();
        }
        public bool Logar(Funcionario obj)
        {
            try
            {
                string sql = "select nome, ativo from tb_Funcionarios where senha = @senha and email = @email";

                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@email", obj.email);
                cmd.Parameters.AddWithValue("@senha", obj.senha);

                conexao.Open();
                SqlDataReader linhas = cmd.ExecuteReader();

                if (linhas.Read() || linhas.HasRows)
                {
                    int verificaAtivo = Convert.ToInt32(linhas["ativo"]);

                    if (verificaAtivo == 0)
                    {
                        MessageBox.Show("Usuário bloqueado! Contate o administrador do sistema.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    } else
                    {
                        nomeFuncionario = linhas["nome"].ToString();
                        conexao.Close();
                        return true;
                    }
                }
                else
                {
                    conexao.Close();
                    MessageBox.Show("Usuário inválido", "ERRO");
                    return false;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void BloquearUsuario(string nomeFuncionario)
        {
            string sql = @"update
                              tb_Funcionarios
                           set ativo = 0
                           where email = @nome";

            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", nomeFuncionario);
            conexao.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Usuário bloqueado, contato o administrador do sistema.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            conexao.Close();
        }
    }
}