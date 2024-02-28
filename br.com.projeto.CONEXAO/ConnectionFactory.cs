using Controle_de_Vendas.br.com.projeto.MODEL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Vendas.br.com.projeto.CONEXAO
{
    public class ConnectionFactory
    {
        // metodo para conectar ao banco de dados

        public SqlConnection getConnection()
        {
            string conexao = "Data Source=VINICIUS;Initial Catalog=BDVENDAS;Integrated Security=True;Encrypt=False";

            return new SqlConnection(conexao);
        }
    }
}