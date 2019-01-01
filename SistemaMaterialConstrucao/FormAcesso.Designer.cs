namespace SistemaMaterialConstrucao
{
    partial class FormAcesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAcesso));
            this.btAcesso = new System.Windows.Forms.Button();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbTentativaAcesso = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAcesso
            // 
            this.btAcesso.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAcesso.Location = new System.Drawing.Point(472, 231);
            this.btAcesso.Name = "btAcesso";
            this.btAcesso.Size = new System.Drawing.Size(95, 37);
            this.btAcesso.TabIndex = 0;
            this.btAcesso.Text = "Acessar";
            this.btAcesso.UseVisualStyleBackColor = true;
            this.btAcesso.Click += new System.EventHandler(this.btAcesso_Click);
            // 
            // tbUsuario
            // 
            this.tbUsuario.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.Location = new System.Drawing.Point(461, 126);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(228, 26);
            this.tbUsuario.TabIndex = 1;
            // 
            // tbSenha
            // 
            this.tbSenha.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSenha.Location = new System.Drawing.Point(461, 166);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(228, 26);
            this.tbSenha.TabIndex = 2;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(381, 127);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(74, 22);
            this.lbUsuario.TabIndex = 3;
            this.lbUsuario.Text = "Usuário.:";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(381, 165);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(64, 22);
            this.lbSenha.TabIndex = 4;
            this.lbSenha.Text = "Senha.:";
            // 
            // lbTentativaAcesso
            // 
            this.lbTentativaAcesso.AutoSize = true;
            this.lbTentativaAcesso.Location = new System.Drawing.Point(458, 271);
            this.lbTentativaAcesso.Name = "lbTentativaAcesso";
            this.lbTentativaAcesso.Size = new System.Drawing.Size(125, 13);
            this.lbTentativaAcesso.TabIndex = 5;
            this.lbTentativaAcesso.Text = "Tentativas de Acesso.: 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 305);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelPrincipal.Controls.Add(this.pictureBox1);
            this.panelPrincipal.Controls.Add(this.lbSenha);
            this.panelPrincipal.Controls.Add(this.lbTentativaAcesso);
            this.panelPrincipal.Controls.Add(this.lbUsuario);
            this.panelPrincipal.Controls.Add(this.btAcesso);
            this.panelPrincipal.Controls.Add(this.tbSenha);
            this.panelPrincipal.Controls.Add(this.tbUsuario);
            this.panelPrincipal.Location = new System.Drawing.Point(12, 12);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(760, 405);
            this.panelPrincipal.TabIndex = 7;
            // 
            // FormAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 436);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "FormAcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAcesso";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAcesso;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbTentativaAcesso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelPrincipal;
    }
}