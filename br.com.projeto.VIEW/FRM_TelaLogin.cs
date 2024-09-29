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

        int tentativas = 0;

        private void btn_Entrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                List<TextBox> textBox = new List<TextBox> { txt_Email, txt_Senha };

                Funcionario funcionario = new Funcionario();
                funcionario.email = txt_Email.Text;
                funcionario.senha = txt_Senha.Text;

                Login login = new Login();

                FRM_Principal principal = new FRM_Principal();

                if (m.textBoxVazio(textBox) == true)
                {
                    MessageBox.Show("Preencha os campos em vermelho por completo.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (login.Logar(funcionario) == true)
                    {
                        principal.SetUsuario(login.nomeFuncionario);
                        principal.Show();
                        this.Hide();
                    }
                    else
                    {
                        while (tentativas < 3)
                        {
                            tentativas += 1;
                            //if (tentativas == 3)
                            //{
                            //    login.BloquearUsuario(login.nomeFuncionario);
                            //    break;
                            //}
                            break;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}