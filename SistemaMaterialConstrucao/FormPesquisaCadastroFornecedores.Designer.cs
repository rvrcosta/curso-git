namespace SistemaMaterialConstrucao
{
    partial class FormPesquisaCadastroFornecedores
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
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.lbPesquisaCliente = new System.Windows.Forms.Label();
            this.btPesquisaNome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(121, 15);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(369, 21);
            this.cbFornecedor.TabIndex = 0;
            // 
            // lbPesquisaCliente
            // 
            this.lbPesquisaCliente.AutoSize = true;
            this.lbPesquisaCliente.Location = new System.Drawing.Point(2, 18);
            this.lbPesquisaCliente.Name = "lbPesquisaCliente";
            this.lbPesquisaCliente.Size = new System.Drawing.Size(113, 13);
            this.lbPesquisaCliente.TabIndex = 1;
            this.lbPesquisaCliente.Text = "Pesquisa Fornecedor.:";
            // 
            // btPesquisaNome
            // 
            this.btPesquisaNome.Location = new System.Drawing.Point(496, 13);
            this.btPesquisaNome.Name = "btPesquisaNome";
            this.btPesquisaNome.Size = new System.Drawing.Size(36, 23);
            this.btPesquisaNome.TabIndex = 2;
            this.btPesquisaNome.Text = "OK";
            this.btPesquisaNome.UseVisualStyleBackColor = true;
            this.btPesquisaNome.Click += new System.EventHandler(this.btPesquisaNome_Click);
            // 
            // FormPesquisaCadastroFornecedores
            // 
            this.ClientSize = new System.Drawing.Size(552, 55);
            this.Controls.Add(this.btPesquisaNome);
            this.Controls.Add(this.lbPesquisaCliente);
            this.Controls.Add(this.cbFornecedor);
            this.Name = "FormPesquisaCadastroFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Fornecedores";
            this.Load += new System.EventHandler(this.FormPesquisaCadastroFornecedores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.Label lbPesquisaCliente;
        private System.Windows.Forms.Button btPesquisaNome;

        
    }
}