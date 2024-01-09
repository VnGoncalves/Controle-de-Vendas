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
    public partial class FRM_Clientes : Form
    {
        public FRM_Clientes()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
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
            obj.numero = int.Parse(txt_Numero.Text);
            obj.complemento = txt_Complemento.Text;
            obj.bairro = txt_Bairro.Text;
            obj.cidade = txt_Cidade.Text;
            obj.estado = cbo_UF.Text;

            // 2 - Criar um objeto da classe ClienteDAO e chamar o metodo cadastrarCliente
            ClienteDAO dao = new ClienteDAO();
            dao.cadastrarCliente(obj);            
        }
    }
} 
