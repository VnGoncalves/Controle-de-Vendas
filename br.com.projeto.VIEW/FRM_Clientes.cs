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
using System.Web;
using System.Windows.Forms;

namespace Controle_de_Vendas.br.com.projeto.VIEW
{
    public partial class FRM_Clientes : Form
    {
        public FRM_Clientes()
        {
            InitializeComponent();
        }

        // Intancia classe Metodo

        Metodos m = new Metodos();

        #region Evento Botao salvar
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            // Programa o botão Salvar

            // 1 - Receber os dados dentro do objeto modelo de cliente

            Cliente obj = new Cliente();
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

            try
            {
                // Instancia a classe Metodo para usar o metodo de validar os controles vazio


                // Cria listas e insere somente os controles necessarios (Obrigatorios)

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
                    if (MessageBox.Show("Deseja salvar o registro ?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ClienteDAO dao = new ClienteDAO();
                        dao.cadastrarCliente(obj);
                        tabelaCliente.DataSource = dao.listarClientes();

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

        #region Evento Carregar Form
        private void FRM_Clientes_Load(object sender, EventArgs e)
        {
            // Carrega as informações da tabela tb_clientes ao carregar o formulario

            ClienteDAO dao = new ClienteDAO();
            tabelaCliente.DataSource = dao.listarClientes();

            // Ocultando campos desnecessarios do DataGrid tabelaClientes

            this.tabelaCliente.Columns[0].Visible = false;
            this.tabelaCliente.Columns[2].Visible = false;
            this.tabelaCliente.Columns[5].Visible = false;
            this.tabelaCliente.Columns[6].Visible = false;
            this.tabelaCliente.Columns[7].Visible = false;
            this.tabelaCliente.Columns[8].Visible = false;
            this.tabelaCliente.Columns[9].Visible = false;
            this.tabelaCliente.Columns[10].Visible = false;
            this.tabelaCliente.Columns[11].Visible = false;
            this.tabelaCliente.Columns[12].Visible = false;
            this.tabelaCliente.Columns[13].Visible = false;

            // Ajustando o tamanho de cada coluna

            tabelaCliente.Columns["NOME CLIENTE"].Width = 340;
            tabelaCliente.Columns["CPF"].Width = 250;
            tabelaCliente.Columns["E-MAIL"].Width = 300;
        }
        #endregion

        #region Evento de clicar no data Grid
        private void tabelaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegar os dados da linha selecionada

            // Se houver uma linha selecionada, desative o botão "Salvar"

            btn_Salvar.Enabled = false;

            // Este codigo e feito para quando eu cadastrar mais de um registro, os campos de mascara seja cadastrados certinhos no banco de dados.

            txt_Celular.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txt_Telefone.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txt_RG.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txt_CPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txt_CEP.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            // Seta os campos no cadastro de clientes quando eu clicar em algum cliente ja cadastrado

            txt_Codigo.Text = tabelaCliente.CurrentRow.Cells[0].Value.ToString();
            txt_Nome.Text = tabelaCliente.CurrentRow.Cells[1].Value.ToString();
            txt_RG.Text = tabelaCliente.CurrentRow.Cells[2].Value.ToString();
            txt_CPF.Text = tabelaCliente.CurrentRow.Cells[3].Value.ToString();
            txt_Email.Text = tabelaCliente.CurrentRow.Cells[4].Value.ToString();
            txt_Telefone.Text = tabelaCliente.CurrentRow.Cells[5].Value.ToString();
            txt_Celular.Text = tabelaCliente.CurrentRow.Cells[6].Value.ToString();
            txt_CEP.Text = tabelaCliente.CurrentRow.Cells[7].Value.ToString();
            txt_Endereco.Text = tabelaCliente.CurrentRow.Cells[8].Value.ToString();
            txt_Numero.Text = tabelaCliente.CurrentRow.Cells[9].Value.ToString();
            txt_Complemento.Text = tabelaCliente.CurrentRow.Cells[10].Value.ToString();
            txt_Bairro.Text = tabelaCliente.CurrentRow.Cells[11].Value.ToString();
            txt_Cidade.Text = tabelaCliente.CurrentRow.Cells[12].Value.ToString();
            cbo_UF.Text = tabelaCliente.CurrentRow.Cells[13].Value.ToString();

            tab_Clientes.SelectedTab = tab_DadosPessoais;
        }
        #endregion

        #region Evento Botao Novo
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            // Habilitar o botao editar

            btn_Salvar.Enabled = true;

            // Botão para limpar os campos

            m.limparControle(this);
            m.apagarCampos();
        }
        #endregion

        #region Evento Botão Excluir

        private void btn_Excluir_Click(object sender, EventArgs e)
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

                    Cliente obj = new Cliente();

                    // pegar o codigo do cliente

                    obj.codigo = txt_Codigo.Text;

                    // Instanciando a classe ClienteDAO e chamando o método ExcluirCliente

                    ClienteDAO dao = new ClienteDAO();
                    dao.excluirCliente(obj);

                    // Chamando o metodo para atualizar a lista no DataGrid após apagar

                    tabelaCliente.DataSource = dao.listarClientes();

                    // Limpa os campos após remover o registro

                    m.limparControle(this);
                    m.apagarCampos();
                }
            }
        }
        #endregion

        #region Evento Botão Editar
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            // 1 - Receber os dados dentro do objeto modelo de cliente

            Cliente obj = new Cliente();

            // Verifica se o cliente esta setado no campo txt_Codigo para editar

            if (txt_Codigo.Text == string.Empty)
            {
                MessageBox.Show("Nenhum cliente identificado", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Instancia dos objetos para os componentes do Form

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

                // Instancia a classe Metodo para usar o metodo de validar os controles vazio

                Metodos m = new Metodos();

                // Cria listas e insere somente os controles necessarios (Obrigatorios)

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
                        // Instanciando o metodo alterarFuncionario da classe FuncionarioDAO para alteramos os registro

                        ClienteDAO dao = new ClienteDAO();
                        dao.alterarCliente(obj);
                        tabelaCliente.DataSource = dao.listarClientes();

                        // Limpa os campos após EDITAR o registro

                        m.limparControle(this);
                        m.apagarCampos();
                    }
                }
            }
        }
        #endregion
      
        #region Metodo para os clientes aparecer no DataGrid enquanto digita
        private void txt_Pesquisa_TextChanged(object sender, EventArgs e)
        {
            // Chamando o metodo para listar os clientes no Data Grid
            string nome = "%" + txt_Pesquisa.Text + "%";

            ClienteDAO dao = new ClienteDAO();
            tabelaCliente.DataSource = dao.buscarClientePorNome(nome);
        }
        #endregion

        #region Evento Buscar CEP
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            // Botão para consultar cep com WebService

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
    }
}