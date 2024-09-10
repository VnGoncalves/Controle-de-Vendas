using Controle_de_Vendas.br.com.projeto.CONEXAO;
using Controle_de_Vendas.br.com.projeto.MODEL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Vendas.br.com.projeto.DAO
{
    public class Login
    {
        private SqlConnection conexao;
        public Login()
        {
            this.conexao = new ConnectionFactory().getConnection();
        }

        public bool Logar(Funcionario obj)
        {
            try
            {
                string sql = "select * from tb_Funcionarios where senha = @senha and email = @email";

                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@email", obj.email);
                cmd.Parameters.AddWithValue("@senha", obj.senha);

                conexao.Open();
                SqlDataReader linhas = cmd.ExecuteReader();

                if (linhas.HasRows)
                {
                    conexao.Close();
                    return true;
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
    }
}
