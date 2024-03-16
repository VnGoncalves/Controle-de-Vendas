using Controle_de_Vendas.br.com.projeto.DAO;
using Controle_de_Vendas.br.com.projeto.MODEL;
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

        // Instancia as classes necessarias

        Metodos m = new Metodos();
        Produto obj = new Produto();
        ProdutoDAO dao = new ProdutoDAO();

        #region Carregar Form

        private void FRM_Produtos_Load(object sender, EventArgs e)
        {
            FornecedorDAO f_dao = new FornecedorDAO();
            cbo_FornecedorID.DataSource = f_dao.listarFornecedores();
            cbo_FornecedorID.DisplayMember = "FORNECEDOR";
            cbo_FornecedorID.ValueMember = "CODIGO";

            tabelaProdutos.DataSource = dao.listarProdutos();

            tabelaProdutos.Columns["DESCRICAO"].Width = 450;
            tabelaProdutos.Columns["PRECO"].Width = 350;
            tabelaProdutos.Columns["QUANTIDADE ESTOQUE"].Width = 380;
            tabelaProdutos.Columns["FORNECEDOR"].Width = 380;

        }

        #endregion

        #region 

        #region Botao Salvar

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {

                obj.descricao = txt_Descricao.Text;
                obj.preco = decimal.Parse(txt_Preco.Text);
                obj.qtd_estoque = int.Parse(txt_QtdEstoque.Text);
                obj.fornecedorID = int.Parse(cbo_FornecedorID.SelectedValue.ToString());

                List<TextBox> textBox = new List<TextBox> { txt_Descricao, txt_Preco, txt_QtdEstoque, };
                List<ComboBox> comboBox = new List<ComboBox> { cbo_FornecedorID };

                if (m.comboBoxVazio(comboBox) == true)
                {
                    MessageBox.Show("Preencha os campos em vermelho completamente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (m.textBoxVazio(textBox) == true)
                {
                    MessageBox.Show("Preencha os campos em vermelho completamente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Deseja salvar o registro ?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        dao.cadastrarProduto(obj);
                        //tabelaProdutos.DataSource = dao.ListarProdutos();

                        m.limparControle(this);
                        m.apagarCampos();
                    }
                }
            }
            catch (Exception)
            {
                if (cbo_FornecedorID.Text == string.Empty)
                    MessageBox.Show("Selecione um Fornecedor", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (txt_QtdEstoque.Text == string.Empty)
                    MessageBox.Show("Preencha o campo Quantidade Estoque", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (txt_Preco.Text == string.Empty)
                    MessageBox.Show("Preencha o campo Preço", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Metodo para os campos Preco e qauntidade receberem somente numeros

        private void txt_Preco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_QtdEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion
     
    }
}
