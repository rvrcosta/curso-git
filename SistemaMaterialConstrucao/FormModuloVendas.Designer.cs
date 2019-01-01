namespace SistemaMaterialConstrucao
{
    partial class FormModuloVendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDadosPedido = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbValorTotalPedido = new System.Windows.Forms.Label();
            this.btExcluirProduto = new System.Windows.Forms.Button();
            this.tbQtdProduto = new System.Windows.Forms.TextBox();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCodigoProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btAdicionaProduto = new System.Windows.Forms.Button();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbIDCliente = new System.Windows.Forms.TextBox();
            this.tbTelCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCpfCnpj = new System.Windows.Forms.TextBox();
            this.lbDataPedidoText = new System.Windows.Forms.Label();
            this.lbDataPedido = new System.Windows.Forms.Label();
            this.lbCpfDescTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNomeCliente = new System.Windows.Forms.TextBox();
            this.rbPj = new System.Windows.Forms.RadioButton();
            this.rbPf = new System.Windows.Forms.RadioButton();
            this.lbCpfTitulo = new System.Windows.Forms.Label();
            this.mbCPF = new System.Windows.Forms.MaskedTextBox();
            this.btConsultarCliente = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDadosPedido)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDadosPedido
            // 
            this.dataGridViewDadosPedido.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew;
            this.dataGridViewDadosPedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDadosPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDadosPedido.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewDadosPedido.Location = new System.Drawing.Point(16, 104);
            this.dataGridViewDadosPedido.MultiSelect = false;
            this.dataGridViewDadosPedido.Name = "dataGridViewDadosPedido";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDadosPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewDadosPedido.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDadosPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDadosPedido.Size = new System.Drawing.Size(962, 375);
            this.dataGridViewDadosPedido.TabIndex = 24;
            this.dataGridViewDadosPedido.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDadosPedido_CellValueChanged);
            this.dataGridViewDadosPedido.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewDadosPedido_RowsAdded);
            this.dataGridViewDadosPedido.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewDadosPedido_RowsRemoved);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btExcluirProduto);
            this.groupBox1.Controls.Add(this.tbQtdProduto);
            this.groupBox1.Controls.Add(this.lbQuantidade);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbCodigoProduto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btAdicionaProduto);
            this.groupBox1.Controls.Add(this.cbProduto);
            this.groupBox1.Controls.Add(this.dataGridViewDadosPedido);
            this.groupBox1.Location = new System.Drawing.Point(12, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1056, 485);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Pedido";
            this.groupBox1.Visible = false;
            // 
            // lbValorTotalPedido
            // 
            this.lbValorTotalPedido.AutoSize = true;
            this.lbValorTotalPedido.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTotalPedido.Location = new System.Drawing.Point(752, 48);
            this.lbValorTotalPedido.Name = "lbValorTotalPedido";
            this.lbValorTotalPedido.Size = new System.Drawing.Size(240, 18);
            this.lbValorTotalPedido.TabIndex = 56;
            this.lbValorTotalPedido.Text = "Valor Total do Pedido .: 0,00";
            // 
            // btExcluirProduto
            // 
            this.btExcluirProduto.Location = new System.Drawing.Point(996, 237);
            this.btExcluirProduto.Name = "btExcluirProduto";
            this.btExcluirProduto.Size = new System.Drawing.Size(29, 23);
            this.btExcluirProduto.TabIndex = 39;
            this.btExcluirProduto.Text = " - ";
            this.btExcluirProduto.UseVisualStyleBackColor = true;
            this.btExcluirProduto.Click += new System.EventHandler(this.btExcluirProduto_Click);
            // 
            // tbQtdProduto
            // 
            this.tbQtdProduto.Location = new System.Drawing.Point(106, 53);
            this.tbQtdProduto.Name = "tbQtdProduto";
            this.tbQtdProduto.Size = new System.Drawing.Size(100, 20);
            this.tbQtdProduto.TabIndex = 38;
            this.tbQtdProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQtdProduto_KeyPress);
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(17, 56);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(68, 13);
            this.lbQuantidade.TabIndex = 37;
            this.lbQuantidade.Text = "Quantidade.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Produto.:";
            // 
            // tbCodigoProduto
            // 
            this.tbCodigoProduto.Location = new System.Drawing.Point(106, 23);
            this.tbCodigoProduto.Name = "tbCodigoProduto";
            this.tbCodigoProduto.Size = new System.Drawing.Size(100, 20);
            this.tbCodigoProduto.TabIndex = 35;
            this.tbCodigoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigoProduto_KeyPress);
            this.tbCodigoProduto.Leave += new System.EventHandler(this.tbCodigoProduto_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Cód. Produto.:";
            // 
            // btAdicionaProduto
            // 
            this.btAdicionaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionaProduto.Location = new System.Drawing.Point(212, 52);
            this.btAdicionaProduto.Name = "btAdicionaProduto";
            this.btAdicionaProduto.Size = new System.Drawing.Size(25, 23);
            this.btAdicionaProduto.TabIndex = 28;
            this.btAdicionaProduto.Text = "+";
            this.btAdicionaProduto.UseVisualStyleBackColor = true;
            this.btAdicionaProduto.Click += new System.EventHandler(this.btAdicionarProduto_Click);
            // 
            // cbProduto
            // 
            this.cbProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(294, 22);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(532, 21);
            this.cbProduto.TabIndex = 27;
            this.cbProduto.SelectedValueChanged += new System.EventHandler(this.cbProduto_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbValorTotalPedido);
            this.groupBox2.Controls.Add(this.tbIDCliente);
            this.groupBox2.Controls.Add(this.tbTelCliente);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbCpfCnpj);
            this.groupBox2.Controls.Add(this.lbDataPedidoText);
            this.groupBox2.Controls.Add(this.lbDataPedido);
            this.groupBox2.Controls.Add(this.lbCpfDescTitulo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbNomeCliente);
            this.groupBox2.Location = new System.Drawing.Point(12, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1057, 85);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Cliente";
            this.groupBox2.Visible = false;
            // 
            // tbIDCliente
            // 
            this.tbIDCliente.Enabled = false;
            this.tbIDCliente.Location = new System.Drawing.Point(560, 21);
            this.tbIDCliente.Name = "tbIDCliente";
            this.tbIDCliente.Size = new System.Drawing.Size(75, 20);
            this.tbIDCliente.TabIndex = 55;
            // 
            // tbTelCliente
            // 
            this.tbTelCliente.Enabled = false;
            this.tbTelCliente.Location = new System.Drawing.Point(378, 51);
            this.tbTelCliente.Name = "tbTelCliente";
            this.tbTelCliente.Size = new System.Drawing.Size(167, 20);
            this.tbTelCliente.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Telefone.:";
            // 
            // tbCpfCnpj
            // 
            this.tbCpfCnpj.Enabled = false;
            this.tbCpfCnpj.Location = new System.Drawing.Point(105, 49);
            this.tbCpfCnpj.Name = "tbCpfCnpj";
            this.tbCpfCnpj.Size = new System.Drawing.Size(167, 20);
            this.tbCpfCnpj.TabIndex = 52;
            // 
            // lbDataPedidoText
            // 
            this.lbDataPedidoText.AutoSize = true;
            this.lbDataPedidoText.Location = new System.Drawing.Point(833, 21);
            this.lbDataPedidoText.Name = "lbDataPedidoText";
            this.lbDataPedidoText.Size = new System.Drawing.Size(87, 13);
            this.lbDataPedidoText.TabIndex = 51;
            this.lbDataPedidoText.Text = "Data do Pedido.:";
            // 
            // lbDataPedido
            // 
            this.lbDataPedido.AutoSize = true;
            this.lbDataPedido.Location = new System.Drawing.Point(926, 21);
            this.lbDataPedido.Name = "lbDataPedido";
            this.lbDataPedido.Size = new System.Drawing.Size(66, 13);
            this.lbDataPedido.TabIndex = 50;
            this.lbDataPedido.Text = "data_pedido";
            // 
            // lbCpfDescTitulo
            // 
            this.lbCpfDescTitulo.AutoSize = true;
            this.lbCpfDescTitulo.Location = new System.Drawing.Point(6, 51);
            this.lbCpfDescTitulo.Name = "lbCpfDescTitulo";
            this.lbCpfDescTitulo.Size = new System.Drawing.Size(76, 13);
            this.lbCpfDescTitulo.TabIndex = 47;
            this.lbCpfDescTitulo.Text = "Informe o Cpf.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Nome do Cliente.:";
            // 
            // tbNomeCliente
            // 
            this.tbNomeCliente.Enabled = false;
            this.tbNomeCliente.Location = new System.Drawing.Point(106, 21);
            this.tbNomeCliente.Name = "tbNomeCliente";
            this.tbNomeCliente.Size = new System.Drawing.Size(439, 20);
            this.tbNomeCliente.TabIndex = 44;
            // 
            // rbPj
            // 
            this.rbPj.AutoSize = true;
            this.rbPj.Location = new System.Drawing.Point(117, 14);
            this.rbPj.Name = "rbPj";
            this.rbPj.Size = new System.Drawing.Size(101, 17);
            this.rbPj.TabIndex = 53;
            this.rbPj.TabStop = true;
            this.rbPj.Text = "Pessoa Jurídica";
            this.rbPj.UseVisualStyleBackColor = true;
            this.rbPj.CheckedChanged += new System.EventHandler(this.rbPj_CheckedChanged);
            // 
            // rbPf
            // 
            this.rbPf.AutoSize = true;
            this.rbPf.Checked = true;
            this.rbPf.Location = new System.Drawing.Point(19, 14);
            this.rbPf.Name = "rbPf";
            this.rbPf.Size = new System.Drawing.Size(92, 17);
            this.rbPf.TabIndex = 52;
            this.rbPf.TabStop = true;
            this.rbPf.Text = "Pessoa Física";
            this.rbPf.UseVisualStyleBackColor = true;
            this.rbPf.CheckedChanged += new System.EventHandler(this.rbPf_CheckedChanged);
            // 
            // lbCpfTitulo
            // 
            this.lbCpfTitulo.AutoSize = true;
            this.lbCpfTitulo.Location = new System.Drawing.Point(18, 41);
            this.lbCpfTitulo.Name = "lbCpfTitulo";
            this.lbCpfTitulo.Size = new System.Drawing.Size(79, 13);
            this.lbCpfTitulo.TabIndex = 51;
            this.lbCpfTitulo.Text = "Informe o Cpf.: ";
            // 
            // mbCPF
            // 
            this.mbCPF.Location = new System.Drawing.Point(118, 37);
            this.mbCPF.Mask = "000,000,000-00";
            this.mbCPF.Name = "mbCPF";
            this.mbCPF.Size = new System.Drawing.Size(131, 20);
            this.mbCPF.TabIndex = 50;
            // 
            // btConsultarCliente
            // 
            this.btConsultarCliente.Location = new System.Drawing.Point(255, 36);
            this.btConsultarCliente.Name = "btConsultarCliente";
            this.btConsultarCliente.Size = new System.Drawing.Size(75, 22);
            this.btConsultarCliente.TabIndex = 54;
            this.btConsultarCliente.Text = "Consultar";
            this.btConsultarCliente.UseVisualStyleBackColor = true;
            this.btConsultarCliente.Click += new System.EventHandler(this.btConsultarCliente_Click);
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btNovo.BackgroundImage = global::SistemaMaterialConstrucao.Properties.Resources.novoRegistro;
            this.btNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btNovo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNovo.Location = new System.Drawing.Point(962, 12);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(50, 50);
            this.btNovo.TabIndex = 20;
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btGravar
            // 
            this.btGravar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btGravar.BackgroundImage = global::SistemaMaterialConstrucao.Properties.Resources.salvar;
            this.btGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btGravar.Location = new System.Drawing.Point(906, 12);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(50, 50);
            this.btGravar.TabIndex = 21;
            this.btGravar.UseVisualStyleBackColor = false;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btFechar.BackgroundImage = global::SistemaMaterialConstrucao.Properties.Resources.sair;
            this.btFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFechar.Location = new System.Drawing.Point(1018, 12);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(50, 50);
            this.btFechar.TabIndex = 23;
            this.btFechar.UseVisualStyleBackColor = false;
            // 
            // FormModuloVendas
            // 
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.btConsultarCliente);
            this.Controls.Add(this.rbPj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbCpfTitulo);
            this.Controls.Add(this.rbPf);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.mbCPF);
            this.Controls.Add(this.btNovo);
            this.Name = "FormModuloVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.FormModuloVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDadosPedido)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDadosPedido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAdicionaProduto;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCodigoProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbQtdProduto;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.Button btExcluirProduto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbCpfDescTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNomeCliente;
        private System.Windows.Forms.Label lbDataPedido;
        private System.Windows.Forms.Label lbDataPedidoText;
        private System.Windows.Forms.RadioButton rbPj;
        private System.Windows.Forms.RadioButton rbPf;
        private System.Windows.Forms.Label lbCpfTitulo;
        private System.Windows.Forms.MaskedTextBox mbCPF;
        private System.Windows.Forms.Button btConsultarCliente;
        private System.Windows.Forms.TextBox tbIDCliente;
        private System.Windows.Forms.TextBox tbTelCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCpfCnpj;
        private System.Windows.Forms.Label lbValorTotalPedido;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btFechar;
      

    }
}