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
    public partial class FRM_TelaLogin : Form
    {
        public FRM_TelaLogin()
        {
            InitializeComponent();
        }
        
        Metodos m = new Metodos();
        private void btn_Entrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Funcionario funcionario = new Funcionario();
                funcionario.email = txt_Email.Text;
                funcionario.senha = txt_Senha.Text;

                List<TextBox> textBox = new List<TextBox> { txt_Email, txt_Senha };

                if (m.textBoxVazio(textBox) == true)
                {
                    MessageBox.Show("Preencha os campos em vermelho completamente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Login login = new Login();
                    FRM_Principal principal = new FRM_Principal();
                    login.Logar(funcionario);
                    principal.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
