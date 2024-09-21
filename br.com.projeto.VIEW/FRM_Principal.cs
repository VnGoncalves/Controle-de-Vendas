using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Vendas.br.com.projeto.VIEW
{
    public partial class FRM_Principal : Form
    {
        public FRM_Principal()
        {
            InitializeComponent();

            this.BackgroundImage = Properties.Resources.laptop_near_smartphone_digital_devices_shopping_trolley; // Substitua pelo caminho da sua imagem
            this.BackgroundImageLayout = ImageLayout.Stretch; // Você pode escolher entre None, Tile, Center, Stretch, Zoom

            lbl_Data.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FRM_Funcionario funcionario = new FRM_Funcionario();
            funcionario.MdiParent = this;
            funcionario.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Vendas vendas = new FRM_Vendas();
            vendas.MdiParent = this;
            vendas.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Clientes cliente = new FRM_Clientes();
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Produtos produto = new FRM_Produtos();
            produto.MdiParent = this;
            produto.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Fornecedores fornecedor = new FRM_Fornecedores();
            fornecedor.MdiParent = this;
            fornecedor.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
