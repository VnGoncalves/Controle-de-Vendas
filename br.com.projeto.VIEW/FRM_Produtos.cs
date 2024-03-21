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

            // Este codigo define um troca de valores para chave estrangeira

            cbo_FornecedorID.DisplayMember = "FORNECEDOR";
            cbo_FornecedorID.ValueMember = "CODIGO";

            tabelaProdutos.DataSource = dao.listarProdutos();

            // Ocultando colunas desnecessarios do DataGrid tabelaProdutos

            this.tabelaProdutos.Columns["CODIGO"].Visible = false;

            // Define o tamanho das colunas

            tabelaProdutos.Columns["DESCRICAO"].Width = 380;
            tabelaProdutos.Columns["PRECO"].Width = 250;
            tabelaProdutos.Columns["QTD ESTOQUE"].Width = 150;
            tabelaProdutos.Columns["FORNECEDOR"].Width = 380;
        }

        #endregion

        #region Clicar no formulario

        private void tabelaProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Desabilita o botao salvar quando clicado no form

            btn_Salvar.Enabled = false;

            // Seta os campos no cadastro de clientes quando eu clicar em algum cliente ja cadastrado

            txt_Codigo.Text = tabelaProdutos.CurrentRow.Cells[0].Value.ToString();
            txt_Descricao.Text = tabelaProdutos.CurrentRow.Cells[1].Value.ToString();
            txt_Preco.Text = tabelaProdutos.CurrentRow.Cells[2].Value.ToString();
            txt_QtdEstoque.Text = tabelaProdutos.CurrentRow.Cells[3].Value.ToString();
            cbo_FornecedorID.Text = tabelaProdutos.CurrentRow.Cells[4].Value.ToString();
        }

        #endregion

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

        #region Metodo Pesquisar produto

        private void txt_Pesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txt_Pesquisa.Text + "%";
            tabelaProdutos.DataSource = dao.buscarProdutoPorNome(nome);
        }

        #endregion

        #region Botao Novo

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            btn_Salvar.Enabled = true;

            m.limparControle(this);
            m.apagarCampos();
        }

        #endregion

        #region Botao Excluir

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se o usuario tem certeza que vai deletar o registro
                if (txt_Codigo.Text == string.Empty)
                {
                    MessageBox.Show("Nenhum registro foi selecionado.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    if (MessageBox.Show("Deseja excluir o registro ?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        btn_Salvar.Enabled = true;

                        // pegar o codigo do cliente

                        obj.codigo = int.Parse(txt_Codigo.Text);

                        // Instanciando a classe ProdutoDAO e chamando o método ExcluirProduto

                        dao.excluirProduto(obj);

                        // Chamando o metodo para atualizar a lista no DataGrid após apagar

                        tabelaProdutos.DataSource = dao.listarProdutos();

                        // Limpa os campos após remover o registro

                        m.limparControle(this);
                        m.apagarCampos();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion
    }
}