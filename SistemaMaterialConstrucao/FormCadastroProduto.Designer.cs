namespace SistemaMaterialConstrucao
{
    partial class FormCadastroProduto
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
            this.btFechar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.tbNomeProduto = new System.Windows.Forms.TextBox();
            this.tbQtd = new System.Windows.Forms.TextBox();
            this.cbUnidadesMedida = new System.Windows.Forms.ComboBox();
            this.cbGrupoProdutos = new System.Windows.Forms.ComboBox();
            this.tbPrecoVenda = new System.Windows.Forms.TextBox();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.tbPrecoCusto = new System.Windows.Forms.TextBox();
            this.lbNomeProduto = new System.Windows.Forms.Label();
            this.lbQtd = new System.Windows.Forms.Label();
            this.lbPrecoVenda = new System.Windows.Forms.Label();
            this.lbPrecoCusto = new System.Windows.Forms.Label();
            this.lbNomeFornecedor = new System.Windows.Forms.Label();
            this.lbUnidadeMedida = new System.Windows.Forms.Label();
            this.lbGrupo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btFechar.BackgroundImage = global::SistemaMaterialConstrucao.Properties.Resources.sair;
            this.btFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFechar.Location = new System.Drawing.Point(373, 249);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(50, 50);
            this.btFechar.TabIndex = 12;
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btExcluir.BackgroundImage = global::SistemaMaterialConstrucao.Properties.Resources.excluirRegistro;
            this.btExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExcluir.Location = new System.Drawing.Point(312, 249);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(50, 50);
            this.btExcluir.TabIndex = 11;
            this.btExcluir.UseVisualStyleBackColor = false;
            // 
            // btGravar
            // 
            this.btGravar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btGravar.BackgroundImage = global::SistemaMaterialConstrucao.Properties.Resources.salvar;
            this.btGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btGravar.Location = new System.Drawing.Point(251, 249);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(50, 50);
            this.btGravar.TabIndex = 10;
            this.btGravar.UseVisualStyleBackColor = false;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btNovo.BackgroundImage = global::SistemaMaterialConstrucao.Properties.Resources.novoRegistro;
            this.btNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btNovo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNovo.Location = new System.Drawing.Point(190, 249);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(50, 50);
            this.btNovo.TabIndex = 9;
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // tbNomeProduto
            // 
            this.tbNomeProduto.Location = new System.Drawing.Point(152, 50);
            this.tbNomeProduto.Name = "tbNomeProduto";
            this.tbNomeProduto.Size = new System.Drawing.Size(383, 20);
            this.tbNomeProduto.TabIndex = 1;
            // 
            // tbQtd
            // 
            this.tbQtd.Location = new System.Drawing.Point(424, 87);
            this.tbQtd.Name = "tbQtd";
            this.tbQtd.Size = new System.Drawing.Size(111, 20);
            this.tbQtd.TabIndex = 3;
            this.tbQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQtd_KeyPress);
            // 
            // cbUnidadesMedida
            // 
            this.cbUnidadesMedida.FormattingEnabled = true;
            this.cbUnidadesMedida.Location = new System.Drawing.Point(152, 87);
            this.cbUnidadesMedida.Name = "cbUnidadesMedida";
            this.cbUnidadesMedida.Size = new System.Drawing.Size(136, 21);
            this.cbUnidadesMedida.TabIndex = 2;
            // 
            // cbGrupoProdutos
            // 
            this.cbGrupoProdutos.FormattingEnabled = true;
            this.cbGrupoProdutos.Items.AddRange(new object[] {
            " "});
            this.cbGrupoProdutos.Location = new System.Drawing.Point(152, 194);
            this.cbGrupoProdutos.Name = "cbGrupoProdutos";
            this.cbGrupoProdutos.Size = new System.Drawing.Size(383, 21);
            this.cbGrupoProdutos.TabIndex = 8;
            // 
            // tbPrecoVenda
            // 
            this.tbPrecoVenda.Location = new System.Drawing.Point(424, 124);
            this.tbPrecoVenda.Name = "tbPrecoVenda";
            this.tbPrecoVenda.Size = new System.Drawing.Size(111, 20);
            this.tbPrecoVenda.TabIndex = 6;
            this.tbPrecoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecoVenda_KeyPress);
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Items.AddRange(new object[] {
            " "});
            this.cbFornecedor.Location = new System.Drawing.Point(152, 159);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(383, 21);
            this.cbFornecedor.TabIndex = 7;
            // 
            // tbPrecoCusto
            // 
            this.tbPrecoCusto.Location = new System.Drawing.Point(152, 124);
            this.tbPrecoCusto.Name = "tbPrecoCusto";
            this.tbPrecoCusto.Size = new System.Drawing.Size(136, 20);
            this.tbPrecoCusto.TabIndex = 5;
            this.tbPrecoCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecoCusto_KeyPress);
            // 
            // lbNomeProduto
            // 
            this.lbNomeProduto.AutoSize = true;
            this.lbNomeProduto.Location = new System.Drawing.Point(50, 53);
            this.lbNomeProduto.Name = "lbNomeProduto";
            this.lbNomeProduto.Size = new System.Drawing.Size(96, 13);
            this.lbNomeProduto.TabIndex = 27;
            this.lbNomeProduto.Text = "Nome do Produto.:";
            // 
            // lbQtd
            // 
            this.lbQtd.AutoSize = true;
            this.lbQtd.Location = new System.Drawing.Point(322, 90);
            this.lbQtd.Name = "lbQtd";
            this.lbQtd.Size = new System.Drawing.Size(68, 13);
            this.lbQtd.TabIndex = 28;
            this.lbQtd.Text = "Quantidade.:";
            // 
            // lbPrecoVenda
            // 
            this.lbPrecoVenda.AutoSize = true;
            this.lbPrecoVenda.Location = new System.Drawing.Point(322, 127);
            this.lbPrecoVenda.Name = "lbPrecoVenda";
            this.lbPrecoVenda.Size = new System.Drawing.Size(90, 13);
            this.lbPrecoVenda.TabIndex = 29;
            this.lbPrecoVenda.Text = "Preço de Venda.:";
            // 
            // lbPrecoCusto
            // 
            this.lbPrecoCusto.AutoSize = true;
            this.lbPrecoCusto.Location = new System.Drawing.Point(50, 127);
            this.lbPrecoCusto.Name = "lbPrecoCusto";
            this.lbPrecoCusto.Size = new System.Drawing.Size(86, 13);
            this.lbPrecoCusto.TabIndex = 30;
            this.lbPrecoCusto.Text = "Preço de Custo.:";
            // 
            // lbNomeFornecedor
            // 
            this.lbNomeFornecedor.AutoSize = true;
            this.lbNomeFornecedor.Location = new System.Drawing.Point(50, 162);
            this.lbNomeFornecedor.Name = "lbNomeFornecedor";
            this.lbNomeFornecedor.Size = new System.Drawing.Size(67, 13);
            this.lbNomeFornecedor.TabIndex = 31;
            this.lbNomeFornecedor.Text = "Fornecedor.:";
            // 
            // lbUnidadeMedida
            // 
            this.lbUnidadeMedida.AutoSize = true;
            this.lbUnidadeMedida.Location = new System.Drawing.Point(50, 90);
            this.lbUnidadeMedida.Name = "lbUnidadeMedida";
            this.lbUnidadeMedida.Size = new System.Drawing.Size(91, 13);
            this.lbUnidadeMedida.TabIndex = 32;
            this.lbUnidadeMedida.Text = "Unid. de Medida.:";
            // 
            // lbGrupo
            // 
            this.lbGrupo.AutoSize = true;
            this.lbGrupo.Location = new System.Drawing.Point(50, 194);
            this.lbGrupo.Name = "lbGrupo";
            this.lbGrupo.Size = new System.Drawing.Size(42, 13);
            this.lbGrupo.TabIndex = 33;
            this.lbGrupo.Text = "Grupo.:";
            // 
            // FormCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 311);
            this.Controls.Add(this.lbGrupo);
            this.Controls.Add(this.lbUnidadeMedida);
            this.Controls.Add(this.lbNomeFornecedor);
            this.Controls.Add(this.lbPrecoCusto);
            this.Controls.Add(this.lbPrecoVenda);
            this.Controls.Add(this.lbQtd);
            this.Controls.Add(this.lbNomeProduto);
            this.Controls.Add(this.tbPrecoCusto);
            this.Controls.Add(this.cbFornecedor);
            this.Controls.Add(this.tbPrecoVenda);
            this.Controls.Add(this.cbGrupoProdutos);
            this.Controls.Add(this.cbUnidadesMedida);
            this.Controls.Add(this.tbQtd);
            this.Controls.Add(this.tbNomeProduto);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.btNovo);
            this.Name = "FormCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Cadastro do Produto";
            this.Load += new System.EventHandler(this.FormCadastroProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.TextBox tbNomeProduto;
        private System.Windows.Forms.TextBox tbQtd;
        private System.Windows.Forms.ComboBox cbUnidadesMedida;
        private System.Windows.Forms.ComboBox cbGrupoProdutos;
        private System.Windows.Forms.TextBox tbPrecoVenda;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.TextBox tbPrecoCusto;
        private System.Windows.Forms.Label lbNomeProduto;
        private System.Windows.Forms.Label lbQtd;
        private System.Windows.Forms.Label lbPrecoVenda;
        private System.Windows.Forms.Label lbPrecoCusto;
        private System.Windows.Forms.Label lbNomeFornecedor;
        private System.Windows.Forms.Label lbUnidadeMedida;
        private System.Windows.Forms.Label lbGrupo;

    }
}