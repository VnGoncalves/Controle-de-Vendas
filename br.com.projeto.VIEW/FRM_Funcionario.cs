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

        }
        // Instancia a classe Metodos

        Metodos m = new Metodos();
        Funcionario obj = new Funcionario();

        #region Metodo Salvar
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            // Botao Salvar 

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

            List<MaskedTextBox> mascaras = new List<MaskedTextBox> { txt_Celular, txt_RG, txt_CPF, txt_CEP };
            List<TextBox> textBox = new List<TextBox> { txt_Nome, txt_Cidade, txt_Senha };
            List<ComboBox> comboBox = new List<ComboBox> { cbo_UF, cbo_Nivel, cbo_Cargo };

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
                    FuncionarioDAO dao = new FuncionarioDAO();
                    dao.cadastrarFuncionario(obj);
                    tabelaFuncionario.DataSource = dao.listarFuncionarios();
                }
            }
        }
        #endregion

        #region Metodo Pesquisar Funcionario
        private void txt_Pesquisa_TextChanged(object sender, EventArgs e)
        {
            ListarNomes();
        }
        #endregion

        #region Carregar Formulario
        private void FRM_Funcionario_Load(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
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

            tabelaFuncionario.Columns["FUNCIONARIO"].Width = 340;
            tabelaFuncionario.Columns["CARGO"].Width = 250;
            tabelaFuncionario.Columns["NIVEL ACESSO"].Width = 300;
        }
        #endregion

        #region Metodo botao Editar
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();
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


                List<MaskedTextBox> mascaras = new List<MaskedTextBox> { txt_Celular, txt_RG, txt_CPF, txt_CEP };
                List<TextBox> textBox = new List<TextBox> { txt_Nome, txt_Cidade };
                List<ComboBox> comboBox = new List<ComboBox> { cbo_UF };

                if (m.comboBoxVazio(comboBox) == true)
                {
                    MessageBox.Show("Preencha o campo Estado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                        FuncionarioDAO dao = new FuncionarioDAO();
                        dao.alterarFuncionario(obj);
                        tabelaFuncionario.DataSource = dao.listarFuncionarios();

                        // Limpa os campos após remover o registro

                        m.limparControle(this);
                        m.apagarCampos();
                    }
                }
            }
        }
        #endregion

        #region Metodo botao Novo
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            m.limparControle(this);
            m.apagarCampos();
        }
        #endregion

        #region Metodo Clicar no form
        private void tabelaFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
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

            tab_Clientes.SelectedTab = tab_DadosPessoais;
        }
        #endregion

        #region Metodo para Listar nomes
        private void ListarNomes()
        {
            // Declarando a variavel para receber o parametro LIKE do sql

            string nome = "%" + txt_Pesquisa.Text + "%";

            FuncionarioDAO dao = new FuncionarioDAO();
            tabelaFuncionario.DataSource = dao.buscarFuncionarioPorNome(nome);
        }
        #endregion
    }
}