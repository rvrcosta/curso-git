namespace SistemaMaterialConstrucao
{
    partial class FormPadrao
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
            this.SuspendLayout();
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btFechar.BackgroundImage = global::SistemaMaterialConstrucao.Properties.Resources.sair;
            this.btFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFechar.Location = new System.Drawing.Point(363, 346);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(50, 50);
            this.btFechar.TabIndex = 23;
            this.btFechar.UseVisualStyleBackColor = false;
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btExcluir.BackgroundImage = global::SistemaMaterialConstrucao.Properties.Resources.excluirRegistro;
            this.btExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExcluir.Location = new System.Drawing.Point(302, 346);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(50, 50);
            this.btExcluir.TabIndex = 22;
            this.btExcluir.UseVisualStyleBackColor = false;
            // 
            // btGravar
            // 
            this.btGravar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btGravar.BackgroundImage = global::SistemaMaterialConstrucao.Properties.Resources.salvar;
            this.btGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btGravar.Location = new System.Drawing.Point(241, 346);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(50, 50);
            this.btGravar.TabIndex = 21;
            this.btGravar.UseVisualStyleBackColor = false;
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btNovo.BackgroundImage = global::SistemaMaterialConstrucao.Properties.Resources.novoRegistro;
            this.btNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btNovo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNovo.Location = new System.Drawing.Point(180, 346);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(50, 50);
            this.btNovo.TabIndex = 20;
            this.btNovo.UseVisualStyleBackColor = false;
            // 
            // FormPadrao
            // 
            this.ClientSize = new System.Drawing.Size(575, 415);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.btNovo);
            this.Name = "FormPadrao";
            this.Load += new System.EventHandler(this.FormPadrao_Load);
            this.ResumeLayout(false);

        }

        #endregion

      
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btNovo;
      

    }
}