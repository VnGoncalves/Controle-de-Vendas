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
                // 2 - Criar um objeto da classe ClienteDAO e chamar o metodo cadastrarCliente

                if (verificaCamposVazios() == true)
                {
                    MessageBox.Show("Preencha todos os campos.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    if (MessageBox.Show("Deseja salvar o registro ?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ClienteDAO dao = new ClienteDAO();
                        dao.cadastrarCliente(obj);
                        tabelaCliente.DataSource = dao.listarClientes();

                        apagarCampos();
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
            // TODO: esta linha de código carrega dados na tabela 'bDVENDASDataSet.tb_clientes'. Você pode movê-la ou removê-la conforme necessário.

            this.tb_clientesTableAdapter.Fill(this.bDVENDASDataSet.tb_clientes);

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

            tabelaCliente.Columns["NOME CLIENTE"].Width = 250;
            tabelaCliente.Columns["CPF"].Width = 130;
            tabelaCliente.Columns["E-MAIL"].Width = 220;
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

            apagarCampos();
        }
        #endregion

        #region Evento Botão Excluir

        private void btn_Excluir_Click(object sender, EventArgs e)
        {

            // Botão excluir

            #region

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

                    apagarCampos();
                }
            }

            #endregion
        }
        #endregion

        #region Metodo para limpar os Controles do formulario
        private void apagarCampos()
        {
            foreach (Control controle in this.Controls)
            {
                limparControle(controle);
            }
        }
        private void limparControle(Control controle)
        {
            // Limpando os campos Txt


            if (controle is TextBox text)
            {
                text.Text = string.Empty;
                text.BackColor = Color.White;
            } else if (controle is ComboBox combo)
            {
                combo.SelectedIndex = -1;
                combo.BackColor = Color.White;
            }
            else if (controle is MaskedTextBox mask)
            {
                mask.Text = string.Empty;
                mask.ForeColor = Color.Black;
            }

            foreach (Control subControle in controle.Controls)
            {
                limparControle(subControle);
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

                // Verificando se todos os campos estão registrados

                if (verificaCamposVazios() == true)
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    // Verificando se o usuario tem certeza que vai modificar o registro

                    if (MessageBox.Show("Deseja alterar o registro ?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Instanciando o metodo alterarCliente da classe ClienteDAO para alteramos os registro

                        ClienteDAO dao = new ClienteDAO();
                        dao.alterarCliente(obj);
                        tabelaCliente.DataSource = dao.listarClientes();

                        // Limpa os campos após remover o registro

                        apagarCampos();
                    }
                }
            }

        }
        #endregion

        #region Evento Pesquisar Cliente
        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            // Chamando o metodo para listar os clientes no Data Grid

            ListarNomes();
        }
        #endregion

        #region Metodo para os clientes aparecer no DataGrid enquanto digita
        private void txt_Pesquisa_TextChanged(object sender, EventArgs e)
        {
            // Chamando o metodo para listar os clientes no Data Grid

            ListarNomes();
        }
        #endregion

        #region Metodo para Listar nomes

        private void ListarNomes()
        {
            // Instancia para chamar o metodo listar clientes no ClienteDAO


            // Declarando a variavel para receber o parametro LIKE do sql

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

        #region Metodo para Validar campos vazios
        private bool verificaCamposVazios()
        {
            // Valida se os componentes do form estao vazios

            TextBox[] textBoxObrigatorios = { txt_Nome, txt_Cidade };
            ComboBox[] comboBoxObrigatorios = { cbo_UF };
            MaskedTextBox[] MaskaraObrigatorias = { txt_Celular, txt_CEP, txt_RG, txt_CPF };

            // Tratamento campos de texto
            foreach (TextBox campo in textBoxObrigatorios)
            {
                if (string.IsNullOrEmpty(campo.Text))
                {
                    campo.BackColor = Color.LightPink;
                    return true;
                }
            }
            // Tratamento combo box
            foreach (ComboBox campo in comboBoxObrigatorios)
            {
                if (string.IsNullOrEmpty(campo.Text))
                {
                    campo.BackColor = Color.LightPink;
                    return true;
                }
            }

            // Tratamento maskara
            foreach (MaskedTextBox campo in MaskaraObrigatorias)
            {
                if (!campo.MaskFull)
                {
                    campo.ForeColor = Color.Red;
                    return true;
                }
                else
                {
                    campo.ForeColor = Color.Black;
                }
            }


            // Tratamento para validar o campo maskara telefone não obrigatorio
            txt_Telefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (txt_Telefone.Text == string.Empty)
            {
                txt_Telefone.ForeColor = Color.Black;
            }
            else
            {
                if (!txt_Telefone.MaskFull && txt_Telefone.TextLength != 0)
                {
                    txt_Telefone.ForeColor = Color.Red;
                    return true;
                }
            }
            return false;
        }
    }
    #endregion

    #region Metodo para tipo int receber vazio
    public static class IntNull
    {
        // Extensao de metodo para declarar a variavel do tipo int para o valor null
        public static int ForceInteger(this string valor)
        {
            int resultado;
            if (int.TryParse(valor, out resultado))
                return resultado;
            else
                return 0;
        }
    }
    #endregion
}