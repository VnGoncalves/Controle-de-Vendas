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

        #region Metodo Salvar
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            // Botao Salvar 
            Funcionario obj = new Funcionario();

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

            Metodos m = new Metodos();

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

        #region
        private void txt_Pesquisa_TextChanged(object sender, EventArgs e)
        {

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

            tabelaFuncionario.Columns["NOME"].Width = 280;
            tabelaFuncionario.Columns["CARGO"].Width = 200;
            tabelaFuncionario.Columns["NIVEL ACESSO"].Width = 250;
        }
        #endregion

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
            }
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            m.limparControle(this);
            m.apagarCampos();
        }
    }
}