namespace Controle_de_Vendas.br.com.projeto.VIEW
{
    partial class FRM_Produtos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Produtos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_Produtos = new System.Windows.Forms.TabControl();
            this.tab_DadosPessoais = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Novo = new System.Windows.Forms.ToolStripButton();
            this.btn_Salvar = new System.Windows.Forms.ToolStripButton();
            this.btn_Excluir = new System.Windows.Forms.ToolStripButton();
            this.btn_Alterar = new System.Windows.Forms.ToolStripButton();
            this.tabelaProdutos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_FornecedorID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_QtdEstoque = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Preco = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Descricao = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_Pesquisa = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tab_Produtos.SuspendLayout();
            this.tab_DadosPessoais.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProdutos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1506, 202);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // tab_Produtos
            // 
            this.tab_Produtos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_Produtos.Controls.Add(this.tab_DadosPessoais);
            this.tab_Produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Produtos.Location = new System.Drawing.Point(0, 205);
            this.tab_Produtos.Margin = new System.Windows.Forms.Padding(6);
            this.tab_Produtos.Name = "tab_Produtos";
            this.tab_Produtos.SelectedIndex = 0;
            this.tab_Produtos.Size = new System.Drawing.Size(1491, 849);
            this.tab_Produtos.TabIndex = 4;
            // 
            // tab_DadosPessoais
            // 
            this.tab_DadosPessoais.Controls.Add(this.toolStrip1);
            this.tab_DadosPessoais.Controls.Add(this.tabelaProdutos);
            this.tab_DadosPessoais.Controls.Add(this.groupBox1);
            this.tab_DadosPessoais.Controls.Add(this.groupBox3);
            this.tab_DadosPessoais.Location = new System.Drawing.Point(4, 34);
            this.tab_DadosPessoais.Margin = new System.Windows.Forms.Padding(6);
            this.tab_DadosPessoais.Name = "tab_DadosPessoais";
            this.tab_DadosPessoais.Padding = new System.Windows.Forms.Padding(6);
            this.tab_DadosPessoais.Size = new System.Drawing.Size(1483, 811);
            this.tab_DadosPessoais.TabIndex = 0;
            this.tab_DadosPessoais.Text = "Dados Pessoais";
            this.tab_DadosPessoais.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Novo,
            this.btn_Salvar,
            this.btn_Excluir,
            this.btn_Alterar});
            this.toolStrip1.Location = new System.Drawing.Point(6, 6);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1471, 35);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Novo
            // 
            this.btn_Novo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Novo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Novo.Image")));
            this.btn_Novo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(32, 32);
            this.btn_Novo.Text = "Novo";
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Salvar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salvar.Image")));
            this.btn_Salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(32, 32);
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Excluir.Image")));
            this.btn_Excluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(32, 32);
            this.btn_Excluir.Text = "Excluir";
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Alterar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Alterar.Image")));
            this.btn_Alterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(32, 32);
            this.btn_Alterar.Text = "Alterar";
            // 
            // tabelaProdutos
            // 
            this.tabelaProdutos.AllowUserToAddRows = false;
            this.tabelaProdutos.AllowUserToDeleteRows = false;
            this.tabelaProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabelaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaProdutos.Location = new System.Drawing.Point(1006, 202);
            this.tabelaProdutos.Margin = new System.Windows.Forms.Padding(5);
            this.tabelaProdutos.Name = "tabelaProdutos";
            this.tabelaProdutos.ReadOnly = true;
            this.tabelaProdutos.RowHeadersWidth = 51;
            this.tabelaProdutos.RowTemplate.Height = 24;
            this.tabelaProdutos.Size = new System.Drawing.Size(467, 590);
            this.tabelaProdutos.TabIndex = 27;
            this.tabelaProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaProdutos_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbo_FornecedorID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_QtdEstoque);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Preco);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Codigo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Descricao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(976, 362);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do produto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 279);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 24);
            this.label6.TabIndex = 35;
            this.label6.Text = "Fornecedor:";
            // 
            // cbo_FornecedorID
            // 
            this.cbo_FornecedorID.FormattingEnabled = true;
            this.cbo_FornecedorID.Location = new System.Drawing.Point(263, 276);
            this.cbo_FornecedorID.Name = "cbo_FornecedorID";
            this.cbo_FornecedorID.Size = new System.Drawing.Size(460, 32);
            this.cbo_FornecedorID.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "Quantidade Estoque:";
            // 
            // txt_QtdEstoque
            // 
            this.txt_QtdEstoque.Location = new System.Drawing.Point(263, 239);
            this.txt_QtdEstoque.Margin = new System.Windows.Forms.Padding(5);
            this.txt_QtdEstoque.Name = "txt_QtdEstoque";
            this.txt_QtdEstoque.Size = new System.Drawing.Size(460, 29);
            this.txt_QtdEstoque.TabIndex = 32;
            this.txt_QtdEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_QtdEstoque_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "* Preço (R$) :";
            // 
            // txt_Preco
            // 
            this.txt_Preco.Location = new System.Drawing.Point(197, 200);
            this.txt_Preco.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Preco.Name = "txt_Preco";
            this.txt_Preco.Size = new System.Drawing.Size(526, 29);
            this.txt_Preco.TabIndex = 30;
            this.txt_Preco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Preco_KeyPress);
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(696, 28);
            this.label20.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(195, 24);
            this.label20.TabIndex = 29;
            this.label20.Text = "Campos obrigatórios *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Código:";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Enabled = false;
            this.txt_Codigo.Location = new System.Drawing.Point(197, 121);
            this.txt_Codigo.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(57, 29);
            this.txt_Codigo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "* Descrição:";
            // 
            // txt_Descricao
            // 
            this.txt_Descricao.Location = new System.Drawing.Point(197, 161);
            this.txt_Descricao.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.Size = new System.Drawing.Size(526, 29);
            this.txt_Descricao.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txt_Pesquisa);
            this.groupBox3.Location = new System.Drawing.Point(1006, 46);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(467, 145);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisar produtos";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 63);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 25);
            this.label17.TabIndex = 12;
            this.label17.Text = "Nome:";
            // 
            // txt_Pesquisa
            // 
            this.txt_Pesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Pesquisa.Location = new System.Drawing.Point(90, 63);
            this.txt_Pesquisa.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Pesquisa.Name = "txt_Pesquisa";
            this.txt_Pesquisa.Size = new System.Drawing.Size(360, 31);
            this.txt_Pesquisa.TabIndex = 13;
            // 
            // FRM_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 1069);
            this.Controls.Add(this.tab_Produtos);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "FRM_Produtos";
            this.Text = "Cadatro de Produtos";
            this.Load += new System.EventHandler(this.FRM_Produtos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab_Produtos.ResumeLayout(false);
            this.tab_DadosPessoais.ResumeLayout(false);
            this.tab_DadosPessoais.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProdutos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tab_Produtos;
        private System.Windows.Forms.TabPage tab_DadosPessoais;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Novo;
        private System.Windows.Forms.ToolStripButton btn_Salvar;
        private System.Windows.Forms.ToolStripButton btn_Excluir;
        private System.Windows.Forms.ToolStripButton btn_Alterar;
        private System.Windows.Forms.DataGridView tabelaProdutos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Descricao;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_Pesquisa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_QtdEstoque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Preco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_FornecedorID;
    }
}