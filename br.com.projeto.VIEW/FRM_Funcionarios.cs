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
    public partial class FRM_Funcionario : Form
    {
        public FRM_Funcionario()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        // Instancia as classes necessarias

        Metodos m = new Metodos();
        Funcionario obj = new Funcionario();
        FuncionarioDAO dao = new FuncionarioDAO();

        #region Carregar Formulario
        private void FRM_Funcionario_Load(object sender, EventArgs e)
        {
            tabelaFuncionario.DataSource = dao.listarFuncionarios();

            // Ocultando campos desnecessarios do DataGrid tabelaClientes

            this.tabelaFuncionario.Columns["CODIGO"].Visible = false;
            this.tabelaFuncionario.Columns["RG"].Visible = false;
            this.tabelaFuncionario.Columns["CPF"].Visible = false;
            this.tabelaFuncionario.Columns["E-MAIL"].Visible = false;
            this.tabelaFuncionario.Columns["SENHA"].Visible = false;
            this.tabelaFuncionario.Columns["TELEFONE"].Visible = false;
            this.tabelaFuncionario.Columns["CELULAR"].Visible = false;
            this.tabelaFuncionario.Columns["CEP"].Visible = false;
            this.tabelaFuncionario.Columns["ENDERECO"].Visible = false;
            this.tabelaFuncionario.Columns["NUMERO"].Visible = false;
            this.tabelaFuncionario.Columns["COMPLEMENTO"].Visible = false;
            this.tabelaFuncionario.Columns["BAIRRO"].Visible = false;
            this.tabelaFuncionario.Columns["CIDADE"].Visible = false;
            this.tabelaFuncionario.Columns["ESTADO"].Visible = false;

            // Ajustando o tamanho de cada coluna

            tabelaFuncionario.Columns["FUNCIONARIO"].Width = 450;
            tabelaFuncionario.Columns["CARGO"].Width = 350;
            tabelaFuncionario.Columns["NIVEL ACESSO"].Width = 380;
        }
        #endregion

        #region Pesquisar Funcionarios
        private void txt_Pesquisa_TextChanged_1(object sender, EventArgs e)
        {
            string nome = "%" + txt_Pesquisa.Text + "%";
            tabelaFuncionario.DataSource = dao.buscarFuncionarioPorNome(nome);
        }
        #endregion

        #region Clicar no formulario
        private void tabelaFuncionario_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btn_Salvar.Enabled = false;

            // Este codigo e feito para quando eu cadastrar mais de um registro, os campos de mascara seja cadastrados certinhos no banco de dados.

            txt_Celular.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txt_Telefone.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txt_RG.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txt_CPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txt_CEP.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            // Seta os campos no cadastro de clientes quando eu clicar em algum cliente ja cadastrado

            txt_Codigo.Text = tabelaFuncionario.CurrentRow.Cells[0].Value.ToString();
            txt_Nome.Text = tabelaFuncionario.CurrentRow.Cells[1].Value.ToString();
            txt_RG.Text = tabelaFuncionario.CurrentRow.Cells[2].Value.ToString();
            txt_CPF.Text = tabelaFuncionario.CurrentRow.Cells[3].Value.ToString();
            txt_Email.Text = tabelaFuncionario.CurrentRow.Cells[4].Value.ToString();
            txt_Senha.Text = tabelaFuncionario.CurrentRow.Cells[5].Value.ToString();
            cbo_Cargo.Text = tabelaFuncionario.CurrentRow.Cells[6].Value.ToString();
            cbo_Nivel.Text = tabelaFuncionario.CurrentRow.Cells[7].Value.ToString();
            txt_Telefone.Text = tabelaFuncionario.CurrentRow.Cells[8].Value.ToString();
            txt_Celular.Text = tabelaFuncionario.CurrentRow.Cells[9].Value.ToString();
            txt_CEP.Text = tabelaFuncionario.CurrentRow.Cells[10].Value.ToString();
            txt_Endereco.Text = tabelaFuncionario.CurrentRow.Cells[11].Value.ToString();
            txt_Numero.Text = tabelaFuncionario.CurrentRow.Cells[12].Value.ToString();
            txt_Complemento.Text = tabelaFuncionario.CurrentRow.Cells[13].Value.ToString();
            txt_Bairro.Text = tabelaFuncionario.CurrentRow.Cells[14].Value.ToString();
            txt_Cidade.Text = tabelaFuncionario.CurrentRow.Cells[15].Value.ToString();
            cbo_UF.Text = tabelaFuncionario.CurrentRow.Cells[16].Value.ToString();
            var valorCelula = tabelaFuncionario.CurrentRow.Cells[17].Value;

            // Verifica se o valor não é nulo ou do tipo DBNull
            if (valorCelula != null && valorCelula != DBNull.Value)
            {
                try
                {
                    // Verifica se o valor é um booleano (por exemplo, se já é true ou false)
                    if (valorCelula is bool)
                    {
                        check_Ativo.Checked = (bool)valorCelula; // Atribui diretamente
                    }
                    // Se for um inteiro (1 ou 0), converte para booleano
                    else if (valorCelula is int)
                    {
                        check_Ativo.Checked = (int)valorCelula == 1; // Converte 1 para true e 0 para false
                    }
                    // Se for string (por exemplo, "1" ou "0"), converte para booleano
                    else if (valorCelula is string)
                    {
                        check_Ativo.Checked = valorCelula.ToString() == "1"; // Converte "1" para true
                    }
                    else
                    {
                        MessageBox.Show("O valor da célula não pode ser convertido.");
                    }
                }
                catch (InvalidCastException ex)
                {
                    // Captura erros de conversão
                    MessageBox.Show($"Erro de conversão: {ex.Message}");
                }
            }
        }
        #endregion

        #region Metodo buscar CEP
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

        // Botao Novo
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            btn_Salvar.Enabled = true;

            m.limparControle(this);
            m.apagarCampos();
        }
        #endregion

        #region Botao Salvar

        // Botao Salvar 
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                obj.nome = txt_Nome.Text;
                obj.rg = txt_RG.Text;
                obj.cpf = txt_CPF.Text;
                obj.email = txt_Email.Text;
                obj.senha = txt_Senha.Text;
                obj.nivel_acesso = cbo_Nivel.Text;
                obj.telefone = txt_Telefone.Text;
                obj.celular = txt_Celular.Text;
                obj.cep = txt_CEP.Text;
                obj.endereco = txt_Endereco.Text;
                obj.numero = IntNull.ForceInteger(txt_Numero.Text);
                obj.complemento = txt_Complemento.Text;
                obj.bairro = txt_Bairro.Text;
                obj.cidade = txt_Cidade.Text;
                obj.estado = cbo_UF.Text;
                obj.cargo = cbo_Cargo.Text;
                obj.ativo = check_Ativo.Checked;

                List<MaskedTextBox> mascaras = new List<MaskedTextBox> { txt_Celular, txt_RG, txt_CPF, txt_CEP };
                List<TextBox> textBox = new List<TextBox> { txt_Nome, txt_Cidade, txt_Senha };
                List<ComboBox> comboBox = new List<ComboBox> { cbo_UF, cbo_Nivel, cbo_Cargo };

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
                            dao.cadastrarFuncionario(obj);
                            tabelaFuncionario.DataSource = dao.listarFuncionarios();
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

        #region Metodo Excluir
        // Metodo Excluir
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

                        dao.excluirCliente(obj);

                        // Chamando o metodo para atualizar a lista no DataGrid após apagar

                        tabelaFuncionario.DataSource = dao.listarFuncionarios();

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

        #region Botao Alterar

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Codigo.Text == string.Empty)
                {
                    MessageBox.Show("Nenhum cliente identificado", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    obj.nome = txt_Nome.Text;
                    obj.rg = txt_RG.Text;
                    obj.cpf = txt_CPF.Text;
                    obj.email = txt_Email.Text;
                    obj.senha = txt_Senha.Text;
                    obj.cargo = cbo_Cargo.Text;
                    obj.nivel_acesso = cbo_Nivel.Text;
                    obj.telefone = txt_Telefone.Text;
                    obj.celular = txt_Celular.Text;
                    obj.cep = txt_CEP.Text;
                    obj.endereco = txt_Endereco.Text;
                    obj.numero = IntNull.ForceInteger(txt_Numero.Text);
                    obj.complemento = txt_Complemento.Text;
                    obj.bairro = txt_Bairro.Text;
                    obj.cidade = txt_Cidade.Text;
                    obj.estado = cbo_UF.Text;
                    obj.codigo = txt_Codigo.Text;
                    obj.ativo = check_Ativo.Checked;

                    List<MaskedTextBox> mascaras = new List<MaskedTextBox> { txt_Celular, txt_RG, txt_CPF, txt_CEP };
                    List<TextBox> textBox = new List<TextBox> { txt_Nome, txt_Cidade, txt_Senha };
                    List<ComboBox> comboBox = new List<ComboBox> { cbo_UF, cbo_Nivel, cbo_Cargo };

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
                            // Verificando se o usuario tem certeza que vai modificar o registro

                            if (MessageBox.Show("Deseja alterar o registro ?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                // Instanciando o metodo alterarCliente da classe ClienteDAO para alteramos os registro

                                dao.alterarFuncionario(obj);
                                tabelaFuncionario.DataSource = dao.listarFuncionarios();

                                // Limpa os campos após remover o registro

                                m.limparControle(this);
                                m.apagarCampos();
                            }
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

    }
}