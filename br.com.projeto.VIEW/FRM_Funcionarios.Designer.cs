namespace Controle_de_Vendas.br.com.projeto.VIEW
{
    partial class FRM_Funcionario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_Clientes = new System.Windows.Forms.TabControl();
            this.tab_DadosPessoais = new System.Windows.Forms.TabPage();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.cbo_UF = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_Cidade = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Complemento = new System.Windows.Forms.TextBox();
            this.txt_CEP = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbo_Nivel = new System.Windows.Forms.ComboBox();
            this.cbo_Cargo = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.txt_RG = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.txt_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Celular = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_CPF = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.tab_Consulta = new System.Windows.Forms.TabPage();
            this.tabelaFuncionario = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_Pesquisa = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tab_Clientes.SuspendLayout();
            this.tab_DadosPessoais.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tab_Consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFuncionario)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1745, 216);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Funcionários";
            // 
            // tab_Clientes
            // 
            this.tab_Clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_Clientes.Controls.Add(this.tab_DadosPessoais);
            this.tab_Clientes.Controls.Add(this.tab_Consulta);
            this.tab_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Clientes.Location = new System.Drawing.Point(0, 228);
            this.tab_Clientes.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tab_Clientes.Name = "tab_Clientes";
            this.tab_Clientes.SelectedIndex = 0;
            this.tab_Clientes.Size = new System.Drawing.Size(1745, 1208);
            this.tab_Clientes.TabIndex = 2;
            // 
            // tab_DadosPessoais
            // 
            this.tab_DadosPessoais.Controls.Add(this.txt_Numero);
            this.tab_DadosPessoais.Controls.Add(this.groupBox2);
            this.tab_DadosPessoais.Controls.Add(this.btn_Editar);
            this.tab_DadosPessoais.Controls.Add(this.groupBox1);
            this.tab_DadosPessoais.Controls.Add(this.btn_Excluir);
            this.tab_DadosPessoais.Controls.Add(this.btn_Salvar);
            this.tab_DadosPessoais.Location = new System.Drawing.Point(4, 33);
            this.tab_DadosPessoais.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tab_DadosPessoais.Name = "tab_DadosPessoais";
            this.tab_DadosPessoais.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tab_DadosPessoais.Size = new System.Drawing.Size(1737, 1171);
            this.tab_DadosPessoais.TabIndex = 0;
            this.tab_DadosPessoais.Text = "Dados Pessoais";
            this.tab_DadosPessoais.UseVisualStyleBackColor = true;
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(1389, 583);
            this.txt_Numero.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(257, 29);
            this.txt_Numero.TabIndex = 35;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Buscar);
            this.groupBox2.Controls.Add(this.cbo_UF);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txt_Cidade);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_Bairro);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txt_Complemento);
            this.groupBox2.Controls.Add(this.txt_CEP);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_Endereco);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(41, 491);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Size = new System.Drawing.Size(1677, 373);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações de endereço";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.btn_Buscar.Location = new System.Drawing.Point(598, 33);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(218, 69);
            this.btn_Buscar.TabIndex = 26;
            this.btn_Buscar.Text = "Pesquisar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // cbo_UF
            // 
            this.cbo_UF.FormattingEnabled = true;
            this.cbo_UF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbo_UF.Location = new System.Drawing.Point(1347, 160);
            this.cbo_UF.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cbo_UF.Name = "cbo_UF";
            this.cbo_UF.Size = new System.Drawing.Size(257, 32);
            this.cbo_UF.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1245, 172);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 24);
            this.label16.TabIndex = 34;
            this.label16.Text = "* UF:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(90, 172);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 24);
            this.label15.TabIndex = 32;
            this.label15.Text = "* Cidade:";
            // 
            // txt_Cidade
            // 
            this.txt_Cidade.Location = new System.Drawing.Point(256, 168);
            this.txt_Cidade.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.Size = new System.Drawing.Size(917, 29);
            this.txt_Cidade.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(131, 278);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 24);
            this.label14.TabIndex = 30;
            this.label14.Text = "Bairro:";
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.Location = new System.Drawing.Point(256, 274);
            this.txt_Bairro.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(917, 29);
            this.txt_Bairro.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 219);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 24);
            this.label13.TabIndex = 28;
            this.label13.Text = "Complemento:";
            // 
            // txt_Complemento
            // 
            this.txt_Complemento.Location = new System.Drawing.Point(256, 219);
            this.txt_Complemento.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_Complemento.Name = "txt_Complemento";
            this.txt_Complemento.Size = new System.Drawing.Size(917, 29);
            this.txt_Complemento.TabIndex = 10;
            // 
            // txt_CEP
            // 
            this.txt_CEP.Location = new System.Drawing.Point(256, 57);
            this.txt_CEP.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_CEP.Mask = "00000-999";
            this.txt_CEP.Name = "txt_CEP";
            this.txt_CEP.Size = new System.Drawing.Size(327, 29);
            this.txt_CEP.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(129, 62);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 24);
            this.label12.TabIndex = 26;
            this.label12.Text = "* CEP:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1187, 118);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 24);
            this.label11.TabIndex = 14;
            this.label11.Text = "Número:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(70, 118);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 24);
            this.label10.TabIndex = 12;
            this.label10.Text = "Endereço:";
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.Location = new System.Drawing.Point(256, 113);
            this.txt_Endereco.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(917, 29);
            this.txt_Endereco.TabIndex = 8;
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.ForeColor = System.Drawing.Color.White;
            this.btn_Editar.Location = new System.Drawing.Point(1174, 916);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(282, 113);
            this.btn_Editar.TabIndex = 5;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.cbo_Nivel);
            this.groupBox1.Controls.Add(this.cbo_Cargo);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_Senha);
            this.groupBox1.Controls.Add(this.txt_RG);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Codigo);
            this.groupBox1.Controls.Add(this.txt_Telefone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_Nome);
            this.groupBox1.Controls.Add(this.txt_Celular);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Controls.Add(this.txt_CPF);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(1677, 435);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do funcionário";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(879, 374);
            this.label21.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(193, 24);
            this.label21.TabIndex = 31;
            this.label21.Text = "* Confirmação Senha:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(1216, 367);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(388, 29);
            this.textBox1.TabIndex = 30;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1319, 38);
            this.label20.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(195, 24);
            this.label20.TabIndex = 29;
            this.label20.Text = "Campos obrigatórios *";
            // 
            // cbo_Nivel
            // 
            this.cbo_Nivel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_Nivel.FormattingEnabled = true;
            this.cbo_Nivel.Items.AddRange(new object[] {
            "Administrador",
            "Usuário"});
            this.cbo_Nivel.Location = new System.Drawing.Point(982, 239);
            this.cbo_Nivel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cbo_Nivel.Name = "cbo_Nivel";
            this.cbo_Nivel.Size = new System.Drawing.Size(618, 32);
            this.cbo_Nivel.TabIndex = 28;
            // 
            // cbo_Cargo
            // 
            this.cbo_Cargo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_Cargo.FormattingEnabled = true;
            this.cbo_Cargo.Items.AddRange(new object[] {
            "Gerente",
            "Vendedor",
            "Estágiario",
            "Aprendiz",
            "Recursos Humanos",
            "Analista de T.I",
            "Auxiliar de Produção"});
            this.cbo_Cargo.Location = new System.Drawing.Point(982, 296);
            this.cbo_Cargo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cbo_Cargo.Name = "cbo_Cargo";
            this.cbo_Cargo.Size = new System.Drawing.Size(618, 32);
            this.cbo_Cargo.TabIndex = 27;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(854, 301);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 24);
            this.label19.TabIndex = 26;
            this.label19.Text = "Cargo:";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(705, 243);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(149, 24);
            this.label18.TabIndex = 24;
            this.label18.Text = "Nivel de acesso:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 379);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "* Senha:";
            // 
            // txt_Senha
            // 
            this.txt_Senha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Senha.Location = new System.Drawing.Point(477, 374);
            this.txt_Senha.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(388, 29);
            this.txt_Senha.TabIndex = 21;
            // 
            // txt_RG
            // 
            this.txt_RG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_RG.Location = new System.Drawing.Point(1305, 186);
            this.txt_RG.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_RG.Mask = "##,###,###-##";
            this.txt_RG.Name = "txt_RG";
            this.txt_RG.Size = new System.Drawing.Size(293, 29);
            this.txt_RG.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Código:";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Codigo.Enabled = false;
            this.txt_Codigo.Location = new System.Drawing.Point(199, 87);
            this.txt_Codigo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(157, 29);
            this.txt_Codigo.TabIndex = 1;
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Telefone.Location = new System.Drawing.Point(195, 292);
            this.txt_Telefone.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_Telefone.Mask = "(99) 0000-0000";
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(346, 29);
            this.txt_Telefone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "* Nome:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 296);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "Telefone:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Nome.Location = new System.Drawing.Point(199, 139);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(974, 29);
            this.txt_Nome.TabIndex = 2;
            // 
            // txt_Celular
            // 
            this.txt_Celular.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Celular.Location = new System.Drawing.Point(195, 239);
            this.txt_Celular.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_Celular.Mask = "(99) 00000-0000";
            this.txt_Celular.Name = "txt_Celular";
            this.txt_Celular.Size = new System.Drawing.Size(346, 29);
            this.txt_Celular.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "E-mail:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 243);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "* Celular:";
            // 
            // txt_Email
            // 
            this.txt_Email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Email.Location = new System.Drawing.Point(199, 188);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(974, 29);
            this.txt_Email.TabIndex = 3;
            // 
            // txt_CPF
            // 
            this.txt_CPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_CPF.Location = new System.Drawing.Point(1306, 137);
            this.txt_CPF.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_CPF.Mask = "###,###,###-##";
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.Size = new System.Drawing.Size(293, 29);
            this.txt_CPF.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1209, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "* RG:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1191, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "* CPF:";
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.ForeColor = System.Drawing.Color.White;
            this.btn_Excluir.Location = new System.Drawing.Point(880, 916);
            this.btn_Excluir.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(282, 113);
            this.btn_Excluir.TabIndex = 4;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.ForeColor = System.Drawing.Color.White;
            this.btn_Salvar.Location = new System.Drawing.Point(586, 916);
            this.btn_Salvar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(282, 113);
            this.btn_Salvar.TabIndex = 3;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = false;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // tab_Consulta
            // 
            this.tab_Consulta.Controls.Add(this.tabelaFuncionario);
            this.tab_Consulta.Controls.Add(this.groupBox3);
            this.tab_Consulta.Location = new System.Drawing.Point(4, 33);
            this.tab_Consulta.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tab_Consulta.Name = "tab_Consulta";
            this.tab_Consulta.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tab_Consulta.Size = new System.Drawing.Size(1737, 1171);
            this.tab_Consulta.TabIndex = 1;
            this.tab_Consulta.Text = "Consulta";
            this.tab_Consulta.UseVisualStyleBackColor = true;
            // 
            // tabelaFuncionario
            // 
            this.tabelaFuncionario.AllowUserToAddRows = false;
            this.tabelaFuncionario.AllowUserToDeleteRows = false;
            this.tabelaFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaFuncionario.Location = new System.Drawing.Point(13, 179);
            this.tabelaFuncionario.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabelaFuncionario.Name = "tabelaFuncionario";
            this.tabelaFuncionario.ReadOnly = true;
            this.tabelaFuncionario.RowHeadersWidth = 51;
            this.tabelaFuncionario.RowTemplate.Height = 24;
            this.tabelaFuncionario.Size = new System.Drawing.Size(1713, 961);
            this.tabelaFuncionario.TabIndex = 1;
            this.tabelaFuncionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaFuncionario_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txt_Pesquisa);
            this.groupBox3.Location = new System.Drawing.Point(13, 32);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox3.Size = new System.Drawing.Size(1713, 137);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisar funcionários";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 61);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 24);
            this.label17.TabIndex = 12;
            this.label17.Text = "Nome:";
            // 
            // txt_Pesquisa
            // 
            this.txt_Pesquisa.Location = new System.Drawing.Point(137, 56);
            this.txt_Pesquisa.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_Pesquisa.Name = "txt_Pesquisa";
            this.txt_Pesquisa.Size = new System.Drawing.Size(1566, 29);
            this.txt_Pesquisa.TabIndex = 13;
            this.txt_Pesquisa.TextChanged += new System.EventHandler(this.txt_Pesquisa_TextChanged);
            // 
            // FRM_Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1745, 1421);
            this.Controls.Add(this.tab_Clientes);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FRM_Funcionarios";
            this.Text = "Cadastro de Funcionários";
            this.Load += new System.EventHandler(this.FRM_Funcionario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab_Clientes.ResumeLayout(false);
            this.tab_DadosPessoais.ResumeLayout(false);
            this.tab_DadosPessoais.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tab_Consulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFuncionario)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tab_Clientes;
        private System.Windows.Forms.TabPage tab_DadosPessoais;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.ComboBox cbo_UF;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_Cidade;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Complemento;
        private System.Windows.Forms.MaskedTextBox txt_CEP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Endereco;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txt_RG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.MaskedTextBox txt_Telefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.MaskedTextBox txt_Celular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.MaskedTextBox txt_CPF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.TabPage tab_Consulta;
        private System.Windows.Forms.DataGridView tabelaFuncionario;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_Pesquisa;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.ComboBox cbo_Cargo;
        private System.Windows.Forms.ComboBox cbo_Nivel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox1;
    }
}