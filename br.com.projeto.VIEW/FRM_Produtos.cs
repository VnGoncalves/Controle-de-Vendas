using Controle_de_Vendas.br.com.projeto.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Vendas.br.com.projeto.VIEW
{
    public partial class FRM_Produtos : Form
    {
        public FRM_Produtos()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void FRM_Produtos_Load(object sender, EventArgs e)
        {
            FornecedorDAO f_dao = new FornecedorDAO();
            cbo_Fornecedor.DataSource = f_dao.listarFornecedores();
            cbo_Fornecedor.DisplayMember = "FORNECEDOR";
            cbo_Fornecedor.ValueMember = "CODIGO";
        }
    }
}
