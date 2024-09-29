using Controle_de_Vendas.br.com.projeto.DAO;
using Controle_de_Vendas.br.com.projeto.MODEL;
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
        private Timer timer;
        public FRM_Principal()
        {
            InitializeComponent();

            this.BackgroundImage = Properties.Resources.laptop_near_smartphone_digital_devices_shopping_trolley;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Atualiza a data em tempo real
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();  

        }

        public void SetUsuario(string nomeFuncionario)
        {
            lbl_Usuario.Text = nomeFuncionario;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Atualiza o Label com a data atual
            lbl_Data.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
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
