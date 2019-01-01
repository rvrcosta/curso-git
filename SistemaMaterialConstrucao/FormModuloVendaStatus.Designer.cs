namespace SistemaMaterialConstrucao
{
    partial class FormModuloVendaStatus
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
            this.lbStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.gbOrcamento = new System.Windows.Forms.GroupBox();
            this.mbDataValidadeOrcamento = new System.Windows.Forms.MaskedTextBox();
            this.btCalendar = new System.Windows.Forms.Button();
            this.lbDataValidadeOrcamento = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.gbVenda = new System.Windows.Forms.GroupBox();
            this.cbOutros = new System.Windows.Forms.CheckBox();
            this.cbCartao = new System.Windows.Forms.CheckBox();
            this.cbCheque = new System.Windows.Forms.CheckBox();
            this.cbDinheiro = new System.Windows.Forms.CheckBox();
            this.gbOrcamento.SuspendLayout();
            this.gbVenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(49, 31);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(94, 13);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "Status do Pedido.:";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "",
            "ORÇAMENTO",
            "VENDA"});
            this.cbStatus.Location = new System.Drawing.Point(150, 27);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(175, 21);
            this.cbStatus.TabIndex = 1;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // gbOrcamento
            // 
            this.gbOrcamento.Controls.Add(this.mbDataValidadeOrcamento);
            this.gbOrcamento.Controls.Add(this.btCalendar);
            this.gbOrcamento.Controls.Add(this.lbDataValidadeOrcamento);
            this.gbOrcamento.Controls.Add(this.monthCalendar1);
            this.gbOrcamento.Location = new System.Drawing.Point(52, 81);
            this.gbOrcamento.Name = "gbOrcamento";
            this.gbOrcamento.Size = new System.Drawing.Size(682, 210);
            this.gbOrcamento.TabIndex = 2;
            this.gbOrcamento.TabStop = false;
            this.gbOrcamento.Text = "Orçamento";
            // 
            // mbDataValidadeOrcamento
            // 
            this.mbDataValidadeOrcamento.Location = new System.Drawing.Point(197, 31);
            this.mbDataValidadeOrcamento.Mask = "00/00/0000";
            this.mbDataValidadeOrcamento.Name = "mbDataValidadeOrcamento";
            this.mbDataValidadeOrcamento.Size = new System.Drawing.Size(100, 20);
            this.mbDataValidadeOrcamento.TabIndex = 4;
            this.mbDataValidadeOrcamento.ValidatingType = typeof(System.DateTime);
            // 
            // btCalendar
            // 
            this.btCalendar.Location = new System.Drawing.Point(303, 29);
            this.btCalendar.Name = "btCalendar";
            this.btCalendar.Size = new System.Drawing.Size(29, 23);
            this.btCalendar.TabIndex = 3;
            this.btCalendar.Text = "...";
            this.btCalendar.UseVisualStyleBackColor = true;
            this.btCalendar.Click += new System.EventHandler(this.btCalendar_Click);
            // 
            // lbDataValidadeOrcamento
            // 
            this.lbDataValidadeOrcamento.AutoSize = true;
            this.lbDataValidadeOrcamento.Location = new System.Drawing.Point(22, 36);
            this.lbDataValidadeOrcamento.Name = "lbDataValidadeOrcamento";
            this.lbDataValidadeOrcamento.Size = new System.Drawing.Size(168, 13);
            this.lbDataValidadeOrcamento.TabIndex = 1;
            this.lbDataValidadeOrcamento.Text = "Data de Validade do Orçamento.: ";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(344, 25);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            this.monthCalendar1.Leave += new System.EventHandler(this.monthCalendar1_Leave);
            // 
            // gbVenda
            // 
            this.gbVenda.Controls.Add(this.cbOutros);
            this.gbVenda.Controls.Add(this.cbCartao);
            this.gbVenda.Controls.Add(this.cbCheque);
            this.gbVenda.Controls.Add(this.cbDinheiro);
            this.gbVenda.Location = new System.Drawing.Point(52, 330);
            this.gbVenda.Name = "gbVenda";
            this.gbVenda.Size = new System.Drawing.Size(682, 210);
            this.gbVenda.TabIndex = 3;
            this.gbVenda.TabStop = false;
            this.gbVenda.Text = "Venda";
            // 
            // cbOutros
            // 
            this.cbOutros.AutoSize = true;
            this.cbOutros.Location = new System.Drawing.Point(25, 170);
            this.cbOutros.Name = "cbOutros";
            this.cbOutros.Size = new System.Drawing.Size(166, 17);
            this.cbOutros.TabIndex = 3;
            this.cbOutros.Text = "Outras Formas de Pagamento";
            this.cbOutros.UseVisualStyleBackColor = true;
            this.cbOutros.CheckedChanged += new System.EventHandler(this.cbOutros_CheckedChanged);
            // 
            // cbCartao
            // 
            this.cbCartao.AutoSize = true;
            this.cbCartao.Location = new System.Drawing.Point(25, 146);
            this.cbCartao.Name = "cbCartao";
            this.cbCartao.Size = new System.Drawing.Size(57, 17);
            this.cbCartao.TabIndex = 2;
            this.cbCartao.Text = "Cartão";
            this.cbCartao.UseVisualStyleBackColor = true;
            this.cbCartao.CheckedChanged += new System.EventHandler(this.cbCartao_CheckedChanged);
            // 
            // cbCheque
            // 
            this.cbCheque.AutoSize = true;
            this.cbCheque.Location = new System.Drawing.Point(25, 122);
            this.cbCheque.Name = "cbCheque";
            this.cbCheque.Size = new System.Drawing.Size(63, 17);
            this.cbCheque.TabIndex = 1;
            this.cbCheque.Text = "Cheque";
            this.cbCheque.UseVisualStyleBackColor = true;
            this.cbCheque.CheckedChanged += new System.EventHandler(this.cbCheque_CheckedChanged);
            // 
            // cbDinheiro
            // 
            this.cbDinheiro.AutoSize = true;
            this.cbDinheiro.Location = new System.Drawing.Point(25, 99);
            this.cbDinheiro.Name = "cbDinheiro";
            this.cbDinheiro.Size = new System.Drawing.Size(65, 17);
            this.cbDinheiro.TabIndex = 0;
            this.cbDinheiro.Text = "Dinheiro";
            this.cbDinheiro.UseVisualStyleBackColor = true;
            this.cbDinheiro.CheckedChanged += new System.EventHandler(this.cbDinheiro_CheckedChanged);
            // 
            // FormModuloVendaStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 581);
            this.Controls.Add(this.gbVenda);
            this.Controls.Add(this.gbOrcamento);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lbStatus);
            this.Name = "FormModuloVendaStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormModuloVendaStatus";
            this.gbOrcamento.ResumeLayout(false);
            this.gbOrcamento.PerformLayout();
            this.gbVenda.ResumeLayout(false);
            this.gbVenda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.GroupBox gbOrcamento;
        private System.Windows.Forms.GroupBox gbVenda;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btCalendar;
        private System.Windows.Forms.Label lbDataValidadeOrcamento;
        private System.Windows.Forms.CheckBox cbOutros;
        private System.Windows.Forms.CheckBox cbCartao;
        private System.Windows.Forms.CheckBox cbCheque;
        private System.Windows.Forms.CheckBox cbDinheiro;
        private System.Windows.Forms.MaskedTextBox mbDataValidadeOrcamento;
    }
}