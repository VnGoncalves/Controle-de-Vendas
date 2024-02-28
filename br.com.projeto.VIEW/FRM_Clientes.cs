﻿using Controle_de_Vendas.br.com.projeto.DAO;
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
    public partial class FRM_Clientes : Form
    {
        public FRM_Clientes()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            // Programa o botão Salvar

            #region

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

                if (verificaTamanhoCampo() == true)
                {
                    MessageBox.Show("Preencha os campos em vermelho completo.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
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
            }
            catch (Exception)
            {

                throw;
            }

            #endregion 
        }

        private void FRM_Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDVENDASDataSet.tb_clientes'. Você pode movê-la ou removê-la conforme necessário.

            this.tb_clientesTableAdapter.Fill(this.bDVENDASDataSet.tb_clientes);

            // Carrega as informações da tabela tb_clientes ao carregar o formulario

            #region

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


            #endregion
        }

        private void tabelaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegar os dados da linha selecionada

            #region

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
            txt_Numero1.Text = tabelaCliente.CurrentRow.Cells[9].Value.ToString();
            txt_Complemento.Text = tabelaCliente.CurrentRow.Cells[10].Value.ToString();
            txt_Bairro.Text = tabelaCliente.CurrentRow.Cells[11].Value.ToString();
            txt_Cidade.Text = tabelaCliente.CurrentRow.Cells[12].Value.ToString();
            cbo_UF.Text = tabelaCliente.CurrentRow.Cells[13].Value.ToString();

            tab_Clientes.SelectedTab = tab_DadosPessoais;


            #endregion
        }
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            // Habilitar o botao editar

            btn_Salvar.Enabled = true;

            // Botão para limpar os campos

            apagarCampos();
        }

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

        private void apagarCampos()
        {
            // Limpando os campos Txt

            #region

            txt_Codigo.Text = string.Empty;
            txt_Nome.Text = string.Empty;
            txt_RG.Text = string.Empty;
            txt_CPF.Text = string.Empty;
            txt_Email.Text = string.Empty;
            txt_Telefone.Text = string.Empty;
            txt_Celular.Text = string.Empty;
            txt_CEP.Text = string.Empty;
            txt_Endereco.Text = string.Empty;
            txt_Numero1.Text = string.Empty;
            txt_Complemento.Text = string.Empty;
            txt_Bairro.Text = string.Empty;
            txt_Cidade.Text = string.Empty;
            cbo_UF.Text = string.Empty;

            #endregion
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            // 1 - Receber os dados dentro do objeto modelo de cliente

            #region

            Cliente obj = new Cliente();

            // Verifica se o cliente esta setado no campo txt_Codigo para editar

            if (txt_Codigo.Text == string.Empty)
            {
                MessageBox.Show("Nenhum cliente identificado", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (verificaTamanhoCampo() == true)
                {
                    MessageBox.Show("Preencha os campos em vermelho completo.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show("Preencha todos os campos.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            // Chamando o metodo para listar os clientes no Data Grid

            ListarNomes();
        }

        private void txt_Pesquisa_TextChanged(object sender, EventArgs e)
        {
            // Chamando o metodo para listar os clientes no Data Grid

            ListarNomes();
        }

        private void ListarNomes()
        {
            // Instancia para chamar o metodo listar clientes no ClienteDAO

            #region

            // Declarando a variavel para receber o parametro LIKE do sql

            string nome = "%" + txt_Pesquisa.Text + "%";

            ClienteDAO dao = new ClienteDAO();
            tabelaCliente.DataSource = dao.buscarClientePorNome(nome);

            #endregion
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            // Botão para consultar cep com WebService

            #region

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

            #endregion
        }

        private bool verificaCamposVazios()
        {
            // Verifca os campos vazios para nao deixar de cadastrar informacoes obrigatorias

            #region

            txt_Celular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txt_Telefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txt_RG.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txt_CPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txt_CEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txt_Numero1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (txt_Nome.Text.Equals(string.Empty) ||
                txt_CPF.Text.Equals(string.Empty) ||
                txt_Celular.Text.Equals(string.Empty) ||
                txt_RG.Text.Equals(string.Empty) ||
                txt_Cidade.Text.Equals(string.Empty) ||
                cbo_UF.Text.Equals(string.Empty) ||
                txt_CEP.Text.Equals(string.Empty))
            {
                return true;
            }

            return false;

            #endregion
        }

        private bool verificaTamanhoCampo()
        {
            // Verifica se todos os campos do tipo Macara estao preenchidos completamente

            #region

            txt_Telefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (!txt_Celular.MaskCompleted || !txt_RG.MaskCompleted || !txt_CPF.MaskCompleted || !txt_CEP.MaskCompleted || !txt_Telefone.MaskCompleted && txt_Telefone.Text.Length != 0)
            {
                if (!txt_Celular.MaskCompleted)
                {
                    txt_Celular.ForeColor = Color.Red;
                }
                else
                {
                    txt_Celular.ForeColor = Color.Black;
                }

                if (!txt_RG.MaskCompleted)
                {
                    txt_RG.ForeColor = Color.Red;
                }
                else
                {
                    txt_RG.ForeColor = Color.Black;
                }

                if (!txt_CPF.MaskCompleted)
                {
                    txt_CPF.ForeColor = Color.Red;
                }
                else
                {
                    txt_CPF.ForeColor = Color.Black;
                }

                if (!txt_CEP.MaskCompleted)
                {
                    txt_CEP.ForeColor = Color.Red;
                }
                else
                {
                    txt_CEP.ForeColor = Color.Black;
                }

                if (!txt_Telefone.MaskCompleted && txt_Telefone.Text.Length != 0)
                {
                    txt_Telefone.ForeColor = Color.Red;
                }
                else
                {
                    txt_Telefone.ForeColor = Color.Black;
                }
                if (txt_Telefone.Text == string.Empty)
                {
                    txt_Telefone.ForeColor = Color.Black;
                }

                return true;
            }
            else
            {
                txt_Celular.ForeColor = Color.Black;
                txt_RG.ForeColor = Color.Black;
                txt_CPF.ForeColor = Color.Black;
                txt_CEP.ForeColor = Color.Black;
                txt_Telefone.ForeColor = Color.Black;

                return false;
            }

            #endregion
        }
    }

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
}