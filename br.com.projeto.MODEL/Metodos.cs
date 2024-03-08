using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Vendas.br.com.projeto.MODEL
{
    public class Metodos : Form
    {

        // Metodo para colocar os TextBox do form vazios
        public bool textBoxVazio(List<TextBox> textBox)
        {
            foreach (TextBox campo in textBox)
            {
                if (string.IsNullOrEmpty(campo.Text))
                {
                    campo.BackColor = Color.LightPink;
                    return true;
                }
                else
                {
                    campo.BackColor = Color.White;
                }
            }
            return false;
        }

        // Metodo para deixar os comboBox vazios
        public bool comboBoxVazio(List<ComboBox> comboBox)
        {
            foreach (ComboBox campo in comboBox)
            {
                if (string.IsNullOrEmpty(campo.Text))
                {
                    campo.BackColor = Color.LightPink;
                    return true;
                }
                else
                {
                    campo.BackColor = Color.White;
                }
            }
            return false;
        }

        // Metodo para deixar as Mascaras vazias
        public bool maskarasVazias(List<MaskedTextBox> mascaras)
        {
            // Tratamento maskara
            foreach (MaskedTextBox campo in mascaras)
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
            return false;
        }


        //Metodo para zerar todas as informacoes preenchidas
        public void apagarCampos()
        {
            foreach (Control controle in Controls)
            {
                limparControle(controle);
            }
        }
        public void limparControle(Control controle)
        {
            // Limpando os campos Txt


            if (controle is TextBox text)
            {
                text.Text = string.Empty;
                text.BackColor = Color.White;
            }
            else if (controle is ComboBox combo)
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
    }
    // Extensao de metodo para declarar a variavel do tipo int para o valor null
    public static class IntNull
    {
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