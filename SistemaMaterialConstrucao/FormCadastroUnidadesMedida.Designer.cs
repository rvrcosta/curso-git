namespace SistemaMaterialConstrucao
{
    partial class FormCadastroUnidadesMedida
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
            this.dataGridViewUnidadeMedida = new System.Windows.Forms.DataGridView();
            this.idUnidadeMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeUnidadeMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siglaUnidadeMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbNomeUnidadeMedida = new System.Windows.Forms.TextBox();
            this.tbSigla = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSigla = new System.Windows.Forms.Label();
            this.lbUnidMedida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnidadeMedida)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btFechar.BackgroundImage = global::SistemaMaterialConstrucao.Properties.Resources.sair;
            this.btFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFechar.Location = new System.Drawing.Point(595, 13);
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
            this.btExcluir.Location = new System.Drawing.Point(539, 12);
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
            this.btGravar.Location = new System.Drawing.Point(305, 79);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(34, 34);
            this.btGravar.TabIndex = 21;
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
            this.btNovo.Location = new System.Drawing.Point(265, 79);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(34, 34);
            this.btNovo.TabIndex = 20;
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // dataGridViewUnidadeMedida
            // 
            this.dataGridViewUnidadeMedida.AllowUserToAddRows = false;
            this.dataGridViewUnidadeMedida.AllowUserToDeleteRows = false;
            this.dataGridViewUnidadeMedida.AllowUserToOrderColumns = true;
            this.dataGridViewUnidadeMedida.AllowUserToResizeRows = false;
            this.dataGridViewUnidadeMedida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnidadeMedida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUnidadeMedida,
            this.nomeUnidadeMedida,
            this.siglaUnidadeMedida});
            this.dataGridViewUnidadeMedida.Location = new System.Drawing.Point(45, 69);
            this.dataGridViewUnidadeMedida.MultiSelect = false;
            this.dataGridViewUnidadeMedida.Name = "dataGridViewUnidadeMedida";
            this.dataGridViewUnidadeMedida.ReadOnly = true;
            this.dataGridViewUnidadeMedida.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewUnidadeMedida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUnidadeMedida.Size = new System.Drawing.Size(600, 200);
            this.dataGridViewUnidadeMedida.TabIndex = 1;
            this.dataGridViewUnidadeMedida.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUnidadeMedida_CellDoubleClick);
            // 
            // idUnidadeMedida
            // 
            this.idUnidadeMedida.HeaderText = "Identificador";
            this.idUnidadeMedida.Name = "idUnidadeMedida";
            this.idUnidadeMedida.ReadOnly = true;
            this.idUnidadeMedida.Visible = false;
            // 
            // nomeUnidadeMedida
            // 
            this.nomeUnidadeMedida.HeaderText = "Nome Unidade de Medida";
            this.nomeUnidadeMedida.Name = "nomeUnidadeMedida";
            this.nomeUnidadeMedida.ReadOnly = true;
            this.nomeUnidadeMedida.Width = 450;
            // 
            // siglaUnidadeMedida
            // 
            this.siglaUnidadeMedida.HeaderText = "Sigla";
            this.siglaUnidadeMedida.Name = "siglaUnidadeMedida";
            this.siglaUnidadeMedida.ReadOnly = true;
            // 
            // tbNomeUnidadeMedida
            // 
            this.tbNomeUnidadeMedida.Location = new System.Drawing.Point(120, 19);
            this.tbNomeUnidadeMedida.Name = "tbNomeUnidadeMedida";
            this.tbNomeUnidadeMedida.Size = new System.Drawing.Size(468, 20);
            this.tbNomeUnidadeMedida.TabIndex = 25;
            // 
            // tbSigla
            // 
            this.tbSigla.Location = new System.Drawing.Point(120, 45);
            this.tbSigla.Name = "tbSigla";
            this.tbSigla.Size = new System.Drawing.Size(95, 20);
            this.tbSigla.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbSigla);
            this.groupBox1.Controls.Add(this.lbUnidMedida);
            this.groupBox1.Controls.Add(this.tbSigla);
            this.groupBox1.Controls.Add(this.tbNomeUnidadeMedida);
            this.groupBox1.Controls.Add(this.btGravar);
            this.groupBox1.Controls.Add(this.btNovo);
            this.groupBox1.Location = new System.Drawing.Point(45, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 122);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo Registro";
            // 
            // lbSigla
            // 
            this.lbSigla.AutoSize = true;
            this.lbSigla.Location = new System.Drawing.Point(6, 48);
            this.lbSigla.Name = "lbSigla";
            this.lbSigla.Size = new System.Drawing.Size(103, 13);
            this.lbSigla.TabIndex = 28;
            this.lbSigla.Text = "Sigla Unidade Med.:";
            // 
            // lbUnidMedida
            // 
            this.lbUnidMedida.AutoSize = true;
            this.lbUnidMedida.Location = new System.Drawing.Point(6, 22);
            this.lbUnidMedida.Name = "lbUnidMedida";
            this.lbUnidMedida.Size = new System.Drawing.Size(108, 13);
            this.lbUnidMedida.TabIndex = 27;
            this.lbUnidMedida.Text = "Nome Unidade Med.:";
            // 
            // FormCadastroUnidadesMedida
            // 
            this.ClientSize = new System.Drawing.Size(690, 414);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.dataGridViewUnidadeMedida);
            this.Name = "FormCadastroUnidadesMedida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnidadeMedida)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

      
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btNovo;        
        private System.Windows.Forms.DataGridView dataGridViewUnidadeMedida;
        private System.Windows.Forms.TextBox tbNomeUnidadeMedida;
        private System.Windows.Forms.TextBox tbSigla;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUnidadeMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeUnidadeMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn siglaUnidadeMedida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbSigla;
        private System.Windows.Forms.Label lbUnidMedida;
      

    }
}