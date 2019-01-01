namespace SistemaMaterialConstrucao
{
    partial class FormCadastroUnidadesMedidaEditar
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
            this.tbNomeUnidade = new System.Windows.Forms.TextBox();
            this.tbSiglaUnidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btFechar.BackgroundImage = global::SistemaMaterialConstrucao.Properties.Resources.sair;
            this.btFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFechar.Location = new System.Drawing.Point(291, 141);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(50, 50);
            this.btFechar.TabIndex = 23;
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btExcluir.BackgroundImage = global::SistemaMaterialConstrucao.Properties.Resources.excluirRegistro;
            this.btExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExcluir.Location = new System.Drawing.Point(230, 141);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(50, 50);
            this.btExcluir.TabIndex = 22;
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btGravar
            // 
            this.btGravar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btGravar.BackgroundImage = global::SistemaMaterialConstrucao.Properties.Resources.salvar;
            this.btGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btGravar.Location = new System.Drawing.Point(169, 141);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(50, 50);
            this.btGravar.TabIndex = 21;
            this.btGravar.UseVisualStyleBackColor = false;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // tbNomeUnidade
            // 
            this.tbNomeUnidade.Location = new System.Drawing.Point(144, 63);
            this.tbNomeUnidade.Name = "tbNomeUnidade";
            this.tbNomeUnidade.Size = new System.Drawing.Size(362, 20);
            this.tbNomeUnidade.TabIndex = 24;
            // 
            // tbSiglaUnidade
            // 
            this.tbSiglaUnidade.Location = new System.Drawing.Point(144, 89);
            this.tbSiglaUnidade.Name = "tbSiglaUnidade";
            this.tbSiglaUnidade.Size = new System.Drawing.Size(178, 20);
            this.tbSiglaUnidade.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nome Unidade.: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Sigla.: ";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Enabled = false;
            this.tbCodigo.Location = new System.Drawing.Point(144, 37);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(178, 20);
            this.tbCodigo.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Código.: ";
            // 
            // FormCadastroUnidadesMedidaEditar
            // 
            this.ClientSize = new System.Drawing.Size(553, 203);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSiglaUnidade);
            this.Controls.Add(this.tbNomeUnidade);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btGravar);
            this.Name = "FormCadastroUnidadesMedidaEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormCadastroUnidadesMedidaEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.TextBox tbNomeUnidade;
        private System.Windows.Forms.TextBox tbSiglaUnidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label3;
      

    }
}