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

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            // Botao Salvar 
            Funcionario obj = new Funcionario();

            obj.nome = txt_Nome.Text;
            obj.rg = txt_RG.Text;
            obj.cpf = txt_CPF.Text;
            obj.email = txt_Email.Text;
            obj.senha = txt_Senha.Text;
            obj.nivel_acesso = cbo_Nivel.SelectedItem.ToString();
            obj.telefone = txt_Telefone.Text;
            obj.celular = txt_Celular.Text;
            obj.cep = txt_CEP.Text;
            obj.endereco = txt_Endereco.Text;
            obj.numero = int. Parse(txt_Numero.Text);
            obj.complemento = txt_Complemento.Text;
            obj.bairro = txt_Bairro.Text;
            obj.cidade = txt_Cidade.Text;
            obj.estado = cbo_UF.SelectedItem.ToString();
            obj.cargo = cbo_Cargo.SelectedItem.ToString();
        }
    }
}
