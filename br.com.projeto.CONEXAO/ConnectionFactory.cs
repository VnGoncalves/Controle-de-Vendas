using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Vendas.br.com.projeto.CONEXAO
{
    public class ConnectionFactory
    {
        // metodo para conectar ao banco de dados

        public SqlConnection getConnection()
        {
            string conexao = "Data Source=VINICIUS;Initial Catalog=BDVENDAS;Integrated Security=True";

            return new SqlConnection(conexao);
        }
    }
}
