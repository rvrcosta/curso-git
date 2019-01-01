namespace SistemaMaterialConstrucao
{
    partial class FormCadastroFornecedores
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
            this.mtbTelFax = new System.Windows.Forms.MaskedTextBox();
            this.lbTelComercial = new System.Windows.Forms.Label();
            this.mtbTelCelular = new System.Windows.Forms.MaskedTextBox();
            this.lbTelCelular = new System.Windows.Forms.Label();
            this.mtbTelComercial = new System.Windows.Forms.MaskedTextBox();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.tbLogradouro = new System.Windows.Forms.TextBox();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.btPesquisaCliente = new System.Windows.Forms.Button();
            this.lbCodigoFornecedor = new System.Windows.Forms.Label();
            this.btNovo = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.lbNomeCliente.Size = new System.Drawing.Size(119, 20);
            this.lbNomeCliente.TabIndex = 0;
            this.lbNomeCliente.Text = "*Nome Fornec.:";
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
            this.lbTelefoneResidencial.Size = new System.Drawing.Size(112, 20);
            this.lbTelefoneResidencial.TabIndex = 2;
            this.lbTelefoneResidencial.Text = "Tel Comercial.:";
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
            this.gbTelefone.Controls.Add(this.mtbTelFax);
            this.gbTelefone.Controls.Add(this.lbTelComercial);
            this.gbTelefone.Controls.Add(this.mtbTelCelular);
            this.gbTelefone.Controls.Add(this.lbTelCelular);
            this.gbTelefone.Controls.Add(this.mtbTelComercial);
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
            // mtbTelFax
            // 
            this.mtbTelFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelFax.Location = new System.Drawing.Point(142, 66);
            this.mtbTelFax.Mask = "(999) 0000-0000";
            this.mtbTelFax.Name = "mtbTelFax";
            this.mtbTelFax.Size = new System.Drawing.Size(167, 26);
            this.mtbTelFax.TabIndex = 7;
            // 
            // lbTelComercial
            // 
            this.lbTelComercial.AutoSize = true;
            this.lbTelComercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelComercial.Location = new System.Drawing.Point(2, 72);
            this.lbTelComercial.Name = "lbTelComercial";
            this.lbTelComercial.Size = new System.Drawing.Size(43, 20);
            this.lbTelComercial.TabIndex = 6;
            this.lbTelComercial.Text = "Fax.:";
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
            // mtbTelComercial
            // 
            this.mtbTelComercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelComercial.Location = new System.Drawing.Point(142, 25);
            this.mtbTelComercial.Mask = "(999) 0000-0000";
            this.mtbTelComercial.Name = "mtbTelComercial";
            this.mtbTelComercial.Size = new System.Drawing.Size(167, 26);
            this.mtbTelComercial.TabIndex = 3;
            this.mtbTelComercial.Enter += new System.EventHandler(this.mtbTelResidencial_Enter);
            // 
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.mtbCEP);
            this.gbEndereco.Controls.Add(this.label3);
            this.gbEndereco.Controls.Add(this.tbBairro);
            this.gbEndereco.Controls.Add(this.lbBairro);
            this.gbEndereco.Controls.Add(this.tbLogradouro);
            this.gbEndereco.Controls.Add(this.lbEndereco);
            this.gbEndereco.Location = new System.Drawing.Point(50, 296);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(647, 101);
            this.gbEndereco.TabIndex = 9;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
            // 
            // mtbCEP
            // 
            this.mtbCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCEP.Location = new System.Drawing.Point(466, 53);
            this.mtbCEP.Mask = "00,000-999";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(167, 26);
            this.mtbCEP.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "CEP.:";
            // 
            // tbBairro
            // 
            this.tbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBairro.Location = new System.Drawing.Point(142, 53);
            this.tbBairro.MaxLength = 255;
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(213, 26);
            this.tbBairro.TabIndex = 11;
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBairro.Location = new System.Drawing.Point(2, 59);
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
            this.lbEndereco.Size = new System.Drawing.Size(124, 20);
            this.lbEndereco.TabIndex = 10;
            this.lbEndereco.Text = "Logradouro, Nº.:";
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
            // lbCodigoFornecedor
            // 
            this.lbCodigoFornecedor.AutoSize = true;
            this.lbCodigoFornecedor.Location = new System.Drawing.Point(56, 22);
            this.lbCodigoFornecedor.Name = "lbCodigoFornecedor";
            this.lbCodigoFornecedor.Size = new System.Drawing.Size(10, 13);
            this.lbCodigoFornecedor.TabIndex = 11;
            this.lbCodigoFornecedor.Text = "-";
            this.lbCodigoFornecedor.Visible = false;
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btNovo.BackgroundImage = global::SistemaMaterialConstrucao.Properties.Resources.novoRegistro;
            this.btNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btNovo.Location = new System.Drawing.Point(289, 416);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(50, 50);
            this.btNovo.TabIndex = 12;
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btGravar
            // 
            this.btGravar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btGravar.BackgroundImage = global::SistemaMaterialConstrucao.Properties.Resources.salvar;
            this.btGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btGravar.Location = new System.Drawing.Point(350, 416);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(50, 50);
            this.btGravar.TabIndex = 13;
            this.btGravar.UseVisualStyleBackColor = false;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btExcluir.BackgroundImage = global::SistemaMaterialConstrucao.Properties.Resources.excluirRegistro;
            this.btExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExcluir.Location = new System.Drawing.Point(411, 416);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(50, 50);
            this.btExcluir.TabIndex = 14;
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btFechar
            // 
            this.btFechar.AccessibleDescription = "";
            this.btFechar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btFechar.BackgroundImage = global::SistemaMaterialConstrucao.Properties.Resources.sair;
            this.btFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFechar.Location = new System.Drawing.Point(472, 416);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(50, 50);
            this.btFechar.TabIndex = 15;
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "* Campo obrigatório";
            // 
            // FormCadastroFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 499);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.lbCodigoFornecedor);
            this.Controls.Add(this.btPesquisaCliente);
            this.Controls.Add(this.gbEndereco);
            this.Controls.Add(this.gbTelefone);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.mtbCPFCNPJ);
            this.Controls.Add(this.lbCPFCNPJ);
            this.Controls.Add(this.lbNomeCliente);
            this.Name = "FormCadastroFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedores";
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
        private System.Windows.Forms.MaskedTextBox mtbTelComercial;
        private System.Windows.Forms.MaskedTextBox mtbTelCelular;
        private System.Windows.Forms.Label lbTelCelular;
        private System.Windows.Forms.MaskedTextBox mtbTelFax;
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
        private System.Windows.Forms.Label lbCodigoFornecedor;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Label label2;
    }
}