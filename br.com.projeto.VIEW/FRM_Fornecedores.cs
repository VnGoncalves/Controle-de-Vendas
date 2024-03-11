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
    public partial class FRM_Fornecedores : Form
    {
        public FRM_Fornecedores()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        // Instancia as classes necessarias

        Metodos m = new Metodos();
        Fornecedor obj = new Fornecedor();
        FornecedorDAO dao = new FornecedorDAO();

        #region Buscar CEP

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Declarando as variaveis CEP e XML para obtermos os XML com o CEP

                string cep = txt_CEP.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();

                dados.ReadXml(xml);

                //Passando os valores dos campos textBox para os parametros do XML

                txt_Endereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txt_Bairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txt_Cidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txt_Complemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                cbo_UF.Text = dados.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Endereco não encontrado, digite manualmente.");
            }
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

        #region Botao Salvar

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                obj.nome = txt_Nome.Text;
                obj.CNPJ = txt_CNPJ.Text;
                obj.email = txt_Email.Text;
                obj.telefone = txt_Telefone.Text;
                obj.celular = txt_Celular.Text;
                obj.cep = txt_CEP.Text;
                obj.endereco = txt_Endereco.Text;
                obj.numero = IntNull.ForceInteger(txt_Numero.Text);
                obj.complemento = txt_Complemento.Text;
                obj.bairro = txt_Bairro.Text;
                obj.cidade = txt_Cidade.Text;
                obj.estado = cbo_UF.Text;

                List<MaskedTextBox> mascaras = new List<MaskedTextBox> { txt_Celular, txt_CEP, txt_CNPJ };
                List<TextBox> textBox = new List<TextBox> { txt_Nome, txt_Cidade };
                List<ComboBox> comboBox = new List<ComboBox> { cbo_UF };

                txt_Telefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                if (txt_Telefone.Text.Length != 0 && !txt_Telefone.MaskFull)
                {
                    txt_Telefone.ForeColor = Color.Red;
                    MessageBox.Show("Preencha os campos em vermelho completamente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txt_Telefone.ForeColor = Color.Black;

                    if (m.comboBoxVazio(comboBox) == true)
                    {
                        MessageBox.Show("Preencha os campos em vermelho completamente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (m.maskarasVazias(mascaras) == true)
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
                            FornecedorDAO dao = new FornecedorDAO();
                            dao.cadastrarFornecedor(obj);
                            tabelaFornecedores.DataSource = dao.listarFornecedores();
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
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

                        obj.codigo = txt_Codigo.Text;

                        // Instanciando a classe ClienteDAO e chamando o método ExcluirCliente

                        dao.excluirFornecedor(obj);

                        // Chamando o metodo para atualizar a lista no DataGrid após apagar

                        tabelaFornecedores.DataSource = dao.listarFornecedores();

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



        #region Clicar no Formulario

        private void tabelaFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Salvar.Enabled = false;

            // Este codigo e feito para quando eu cadastrar mais de um registro, os campos de mascara seja cadastrados certinhos no banco de dados.

            txt_Celular.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txt_Telefone.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txt_CEP.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            // Seta os campos no cadastro de clientes quando eu clicar em algum cliente ja cadastrado

            txt_Codigo.Text = tabelaFornecedores.CurrentRow.Cells[0].Value.ToString();
            txt_Nome.Text = tabelaFornecedores.CurrentRow.Cells[1].Value.ToString();
            txt_Email.Text = tabelaFornecedores.CurrentRow.Cells[2].Value.ToString();
            txt_CNPJ.Text = tabelaFornecedores.CurrentRow.Cells[3].Value.ToString();
            txt_Telefone.Text = tabelaFornecedores.CurrentRow.Cells[4].Value.ToString();
            txt_Celular.Text = tabelaFornecedores.CurrentRow.Cells[5].Value.ToString();
            txt_CEP.Text = tabelaFornecedores.CurrentRow.Cells[6].Value.ToString();
            txt_Endereco.Text = tabelaFornecedores.CurrentRow.Cells[7].Value.ToString();
            txt_Numero.Text = tabelaFornecedores.CurrentRow.Cells[8].Value.ToString();
            txt_Complemento.Text = tabelaFornecedores.CurrentRow.Cells[9].Value.ToString();
            txt_Bairro.Text = tabelaFornecedores.CurrentRow.Cells[10].Value.ToString();
            txt_Cidade.Text = tabelaFornecedores.CurrentRow.Cells[11].Value.ToString();
            cbo_UF.Text = tabelaFornecedores.CurrentRow.Cells[12].Value.ToString();
        }

        #endregion

        #region Carregar Form

        private void FRM_Fornecedores_Load(object sender, EventArgs e)
        {
            FornecedorDAO dao = new FornecedorDAO();
            tabelaFornecedores.DataSource = dao.listarFornecedores();

            // Ocultando campos desnecessarios do DataGrid tabelaClientes

            this.tabelaFornecedores.Columns["CODIGO"].Visible = false;
            this.tabelaFornecedores.Columns["E-MAIL"].Visible = false;
            this.tabelaFornecedores.Columns["TELEFONE"].Visible = false;
            this.tabelaFornecedores.Columns["CELULAR"].Visible = false;
            this.tabelaFornecedores.Columns["CEP"].Visible = false;
            this.tabelaFornecedores.Columns["ENDERECO"].Visible = false;
            this.tabelaFornecedores.Columns["NUMERO"].Visible = false;
            this.tabelaFornecedores.Columns["COMPLEMENTO"].Visible = false;
            this.tabelaFornecedores.Columns["BAIRRO"].Visible = false;
            this.tabelaFornecedores.Columns["CIDADE"].Visible = false;
            this.tabelaFornecedores.Columns["ESTADO"].Visible = false;

            // Ajustando o tamanho de cada coluna

            tabelaFornecedores.Columns["FORNECEDOR"].Width = 450;
            tabelaFornecedores.Columns["CNPJ"].Width = 350;
        }

        #endregion

        #region Pesquisar Fornecedor

        private void txt_Pesquisa_TextChanged(object sender, EventArgs e)
        {
            ListarNomes();
        }

        #endregion

        #region Metodo para Listar nomes

        private void ListarNomes()
        {
            // Declarando a variavel para receber o parametro LIKE do sql

            string nome = "%" + txt_Pesquisa.Text + "%";

            FornecedorDAO dao = new FornecedorDAO();
            tabelaFornecedores.DataSource = dao.buscarFornecedorPorNome(nome);
        }

        #endregion

    }
}