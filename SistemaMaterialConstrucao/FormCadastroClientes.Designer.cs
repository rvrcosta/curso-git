namespace SistemaMaterialConstrucao
{
    partial class FormCadastroClientes
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
            this.components = new System.ComponentModel.Container();
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.lbCPFCNPJ = new System.Windows.Forms.Label();
            this.lbTelefoneResidencial = new System.Windows.Forms.Label();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.rbCNPJ = new System.Windows.Forms.RadioButton();
            this.mtbCPFCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbTelefone = new System.Windows.Forms.GroupBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbTelComercial = new System.Windows.Forms.MaskedTextBox();
            this.lbTelComercial = new System.Windows.Forms.Label();
            this.mtbTelCelular = new System.Windows.Forms.MaskedTextBox();
            this.lbTelCelular = new System.Windows.Forms.Label();
            this.mtbTelResidencial = new System.Windows.Forms.MaskedTextBox();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbComplemento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btPesquisaCEP = new System.Windows.Forms.Button();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.tbLogradouro = new System.Windows.Forms.TextBox();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.btPesquisaCliente = new System.Windows.Forms.Button();
            this.lbCodigoCliente = new System.Windows.Forms.Label();
            this.btNovo = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTipNovoRegistro = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.gbTelefone.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeCliente.Location = new System.Drawing.Point(52, 65);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(140, 20);
            this.lbNomeCliente.TabIndex = 0;
            this.lbNomeCliente.Text = "*Nome do Cliente.:";
            // 
            // lbCPFCNPJ
            // 
            this.lbCPFCNPJ.AutoSize = true;
            this.lbCPFCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPFCNPJ.Location = new System.Drawing.Point(52, 104);
            this.lbCPFCNPJ.Name = "lbCPFCNPJ";
            this.lbCPFCNPJ.Size = new System.Drawing.Size(54, 20);
            this.lbCPFCNPJ.TabIndex = 1;
            this.lbCPFCNPJ.Text = "*CPF.:";
            // 
            // lbTelefoneResidencial
            // 
            this.lbTelefoneResidencial.AutoSize = true;
            this.lbTelefoneResidencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefoneResidencial.Location = new System.Drawing.Point(2, 31);
            this.lbTelefoneResidencial.Name = "lbTelefoneResidencial";
            this.lbTelefoneResidencial.Size = new System.Drawing.Size(124, 20);
            this.lbTelefoneResidencial.TabIndex = 2;
            this.lbTelefoneResidencial.Text = "Tel Residencial.:";
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.Checked = true;
            this.rbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCPF.Location = new System.Drawing.Point(15, 3);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(58, 24);
            this.rbCPF.TabIndex = 3;
            this.rbCPF.TabStop = true;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = true;
            this.rbCPF.CheckedChanged += new System.EventHandler(this.rbCPF_CheckedChanged);
            // 
            // rbCNPJ
            // 
            this.rbCNPJ.AutoSize = true;
            this.rbCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCNPJ.Location = new System.Drawing.Point(90, 4);
            this.rbCNPJ.Name = "rbCNPJ";
            this.rbCNPJ.Size = new System.Drawing.Size(67, 24);
            this.rbCNPJ.TabIndex = 4;
            this.rbCNPJ.TabStop = true;
            this.rbCNPJ.Text = "CNPJ";
            this.rbCNPJ.UseVisualStyleBackColor = true;
            this.rbCNPJ.CheckedChanged += new System.EventHandler(this.rbCNPJ_CheckedChanged);
            // 
            // mtbCPFCNPJ
            // 
            this.mtbCPFCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCPFCNPJ.Location = new System.Drawing.Point(192, 99);
            this.mtbCPFCNPJ.Mask = "999,999,999-99";
            this.mtbCPFCNPJ.Name = "mtbCPFCNPJ";
            this.mtbCPFCNPJ.Size = new System.Drawing.Size(213, 26);
            this.mtbCPFCNPJ.TabIndex = 2;
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(192, 59);
            this.tbNome.MaxLength = 255;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(470, 26);
            this.tbNome.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbCPF);
            this.panel1.Controls.Add(this.rbCNPJ);
            this.panel1.Location = new System.Drawing.Point(438, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 32);
            this.panel1.TabIndex = 7;
            // 
            // gbTelefone
            // 
            this.gbTelefone.Controls.Add(this.tbEmail);
            this.gbTelefone.Controls.Add(this.label1);
            this.gbTelefone.Controls.Add(this.mtbTelComercial);
            this.gbTelefone.Controls.Add(this.lbTelComercial);
            this.gbTelefone.Controls.Add(this.mtbTelCelular);
            this.gbTelefone.Controls.Add(this.lbTelCelular);
            this.gbTelefone.Controls.Add(this.mtbTelResidencial);
            this.gbTelefone.Controls.Add(this.lbTelefoneResidencial);
            this.gbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTelefone.Location = new System.Drawing.Point(50, 141);
            this.gbTelefone.Name = "gbTelefone";
            this.gbTelefone.Size = new System.Drawing.Size(647, 146);
            this.gbTelefone.TabIndex = 8;
            this.gbTelefone.TabStop = false;
            this.gbTelefone.Text = "Contatos";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(142, 102);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(491, 26);
            this.tbEmail.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Email.:";
            // 
            // mtbTelComercial
            // 
            this.mtbTelComercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelComercial.Location = new System.Drawing.Point(142, 66);
            this.mtbTelComercial.Mask = "(999) 0000-0000";
            this.mtbTelComercial.Name = "mtbTelComercial";
            this.mtbTelComercial.Size = new System.Drawing.Size(167, 26);
            this.mtbTelComercial.TabIndex = 7;
            // 
            // lbTelComercial
            // 
            this.lbTelComercial.AutoSize = true;
            this.lbTelComercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelComercial.Location = new System.Drawing.Point(2, 72);
            this.lbTelComercial.Name = "lbTelComercial";
            this.lbTelComercial.Size = new System.Drawing.Size(112, 20);
            this.lbTelComercial.TabIndex = 6;
            this.lbTelComercial.Text = "Tel Comercial.:";
            // 
            // mtbTelCelular
            // 
            this.mtbTelCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelCelular.Location = new System.Drawing.Point(466, 25);
            this.mtbTelCelular.Mask = "(999) 00000-0000";
            this.mtbTelCelular.Name = "mtbTelCelular";
            this.mtbTelCelular.Size = new System.Drawing.Size(167, 26);
            this.mtbTelCelular.TabIndex = 5;
            // 
            // lbTelCelular
            // 
            this.lbTelCelular.AutoSize = true;
            this.lbTelCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelCelular.Location = new System.Drawing.Point(358, 31);
            this.lbTelCelular.Name = "lbTelCelular";
            this.lbTelCelular.Size = new System.Drawing.Size(91, 20);
            this.lbTelCelular.TabIndex = 4;
            this.lbTelCelular.Text = "Tel Celular.:";
            // 
            // mtbTelResidencial
            // 
            this.mtbTelResidencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelResidencial.Location = new System.Drawing.Point(142, 25);
            this.mtbTelResidencial.Mask = "(999) 0000-0000";
            this.mtbTelResidencial.Name = "mtbTelResidencial";
            this.mtbTelResidencial.Size = new System.Drawing.Size(167, 26);
            this.mtbTelResidencial.TabIndex = 3;
            this.mtbTelResidencial.Enter += new System.EventHandler(this.mtbTelResidencial_Enter);
            // 
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.cbUF);
            this.gbEndereco.Controls.Add(this.label6);
            this.gbEndereco.Controls.Add(this.tbCidade);
            this.gbEndereco.Controls.Add(this.label5);
            this.gbEndereco.Controls.Add(this.tbComplemento);
            this.gbEndereco.Controls.Add(this.label4);
            this.gbEndereco.Controls.Add(this.btPesquisaCEP);
            this.gbEndereco.Controls.Add(this.mtbCEP);
            this.gbEndereco.Controls.Add(this.label3);
            this.gbEndereco.Controls.Add(this.tbBairro);
            this.gbEndereco.Controls.Add(this.lbBairro);
            this.gbEndereco.Controls.Add(this.tbLogradouro);
            this.gbEndereco.Controls.Add(this.lbEndereco);
            this.gbEndereco.Location = new System.Drawing.Point(50, 296);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(647, 163);
            this.gbEndereco.TabIndex = 9;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
            // 
            // cbUF
            // 
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Items.AddRange(new object[] {
            "",
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
            this.cbUF.Location = new System.Drawing.Point(420, 99);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(121, 21);
            this.cbUF.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(361, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "UF.:";
            // 
            // tbCidade
            // 
            this.tbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCidade.Location = new System.Drawing.Point(142, 94);
            this.tbCidade.MaxLength = 255;
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(213, 26);
            this.tbCidade.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Cidade.:";
            // 
            // tbComplemento
            // 
            this.tbComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbComplemento.Location = new System.Drawing.Point(420, 57);
            this.tbComplemento.MaxLength = 255;
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(213, 26);
            this.tbComplemento.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(361, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Comp.:";
            // 
            // btPesquisaCEP
            // 
            this.btPesquisaCEP.BackgroundImage = global::SistemaMaterialConstrucao.Properties.Resources.pesquisar;
            this.btPesquisaCEP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPesquisaCEP.Location = new System.Drawing.Point(282, 129);
            this.btPesquisaCEP.Name = "btPesquisaCEP";
            this.btPesquisaCEP.Size = new System.Drawing.Size(30, 30);
            this.btPesquisaCEP.TabIndex = 16;
            this.btPesquisaCEP.UseVisualStyleBackColor = true;
            this.btPesquisaCEP.Click += new System.EventHandler(this.btPesquisaCEP_Click);
            // 
            // mtbCEP
            // 
            this.mtbCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCEP.Location = new System.Drawing.Point(142, 131);
            this.mtbCEP.Mask = "00,000-999";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(134, 26);
            this.mtbCEP.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Codigo Postal.:";
            // 
            // tbBairro
            // 
            this.tbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBairro.Location = new System.Drawing.Point(142, 59);
            this.tbBairro.MaxLength = 255;
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(213, 26);
            this.tbBairro.TabIndex = 11;
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBairro.Location = new System.Drawing.Point(2, 65);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(59, 20);
            this.lbBairro.TabIndex = 12;
            this.lbBairro.Text = "Bairro.:";
            // 
            // tbLogradouro
            // 
            this.tbLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLogradouro.Location = new System.Drawing.Point(142, 21);
            this.tbLogradouro.MaxLength = 255;
            this.tbLogradouro.Name = "tbLogradouro";
            this.tbLogradouro.Size = new System.Drawing.Size(491, 26);
            this.tbLogradouro.TabIndex = 10;
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndereco.Location = new System.Drawing.Point(2, 27);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(99, 20);
            this.lbEndereco.TabIndex = 10;
            this.lbEndereco.Text = "Logradouro.:";
            // 
            // btPesquisaCliente
            // 
            this.btPesquisaCliente.Location = new System.Drawing.Point(667, 59);
            this.btPesquisaCliente.Name = "btPesquisaCliente";
            this.btPesquisaCliente.Size = new System.Drawing.Size(30, 26);
            this.btPesquisaCliente.TabIndex = 10;
            this.btPesquisaCliente.Text = "?";
            this.btPesquisaCliente.UseVisualStyleBackColor = true;
            this.btPesquisaCliente.Click += new System.EventHandler(this.btPesquisaCliente_Click);
            // 
            // lbCodigoCliente
            // 
            this.lbCodigoCliente.AutoSize = true;
            this.lbCodigoCliente.Location = new System.Drawing.Point(56, 22);
            this.lbCodigoCliente.Name = "lbCodigoCliente";
            this.lbCodigoCliente.Size = new System.Drawing.Size(10, 13);
            this.lbCodigoCliente.TabIndex = 11;
            this.lbCodigoCliente.Text = "-";
            this.lbCodigoCliente.Visible = false;
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btNovo.BackgroundImage = global::SistemaMaterialConstrucao.Properties.Resources.novoRegistro;
            this.btNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btNovo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNovo.Location = new System.Drawing.Point(289, 480);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(50, 50);
            this.btNovo.TabIndex = 12;
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            this.btNovo.MouseLeave += new System.EventHandler(this.btNovo_MouseLeave);
            this.btNovo.MouseHover += new System.EventHandler(this.btNovo_MouseHover);
            // 
            // btGravar
            // 
            this.btGravar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btGravar.BackgroundImage = global::SistemaMaterialConstrucao.Properties.Resources.salvar;
            this.btGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btGravar.Location = new System.Drawing.Point(350, 480);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(50, 50);
            this.btGravar.TabIndex = 13;
            this.btGravar.UseVisualStyleBackColor = false;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            this.btGravar.MouseHover += new System.EventHandler(this.btGravar_MouseHover);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btExcluir.BackgroundImage = global::SistemaMaterialConstrucao.Properties.Resources.excluirRegistro;
            this.btExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExcluir.Location = new System.Drawing.Point(411, 480);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(50, 50);
            this.btExcluir.TabIndex = 14;
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            this.btExcluir.MouseHover += new System.EventHandler(this.btExcluir_MouseHover);
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btFechar.BackgroundImage = global::SistemaMaterialConstrucao.Properties.Resources.sair;
            this.btFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFechar.Location = new System.Drawing.Point(472, 480);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(50, 50);
            this.btFechar.TabIndex = 15;
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            this.btFechar.MouseHover += new System.EventHandler(this.btFechar_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "* Campo obrigatório";
            // 
            // FormCadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 552);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.lbCodigoCliente);
            this.Controls.Add(this.btPesquisaCliente);
            this.Controls.Add(this.gbEndereco);
            this.Controls.Add(this.gbTelefone);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.mtbCPFCNPJ);
            this.Controls.Add(this.lbCPFCNPJ);
            this.Controls.Add(this.lbNomeCliente);
            this.Name = "FormCadastroClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.FormCadastroClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbTelefone.ResumeLayout(false);
            this.gbTelefone.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNomeCliente;
        private System.Windows.Forms.Label lbCPFCNPJ;
        private System.Windows.Forms.Label lbTelefoneResidencial;
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.RadioButton rbCNPJ;
        private System.Windows.Forms.MaskedTextBox mtbCPFCNPJ;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbTelefone;
        private System.Windows.Forms.MaskedTextBox mtbTelResidencial;
        private System.Windows.Forms.MaskedTextBox mtbTelCelular;
        private System.Windows.Forms.Label lbTelCelular;
        private System.Windows.Forms.MaskedTextBox mtbTelComercial;
        private System.Windows.Forms.Label lbTelComercial;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.TextBox tbLogradouro;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.MaskedTextBox mtbCEP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Button btPesquisaCliente;
        private System.Windows.Forms.Label lbCodigoCliente;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTipNovoRegistro;
        private System.Windows.Forms.Button btPesquisaCEP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbComplemento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbUF;
    }
}