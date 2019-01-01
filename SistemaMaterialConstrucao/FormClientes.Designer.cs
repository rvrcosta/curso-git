namespace SistemaMaterialConstrucao
{
    partial class FormClientes
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
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfCnpjCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.AllowUserToDeleteRows = false;
            this.dataGridViewClientes.AllowUserToOrderColumns = true;
            this.dataGridViewClientes.AllowUserToResizeColumns = false;
            this.dataGridViewClientes.AllowUserToResizeRows = false;
            this.dataGridViewClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.nomeCliente,
            this.cpfCnpjCliente});
            this.dataGridViewClientes.Location = new System.Drawing.Point(74, 136);
            this.dataGridViewClientes.MultiSelect = false;
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewClientes.Size = new System.Drawing.Size(1070, 386);
            this.dataGridViewClientes.TabIndex = 0;
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(74, 75);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(291, 20);
            this.tbFilter.TabIndex = 1;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // idCliente
            // 
            this.idCliente.HeaderText = "Identificador";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Visible = false;
            // 
            // nomeCliente
            // 
            this.nomeCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nomeCliente.HeaderText = "Nome";
            this.nomeCliente.MinimumWidth = 200;
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.ReadOnly = true;
            this.nomeCliente.Width = 500;
            // 
            // cpfCnpjCliente
            // 
            this.cpfCnpjCliente.HeaderText = "CPF/CNPJ";
            this.cpfCnpjCliente.Name = "cpfCnpjCliente";
            this.cpfCnpjCliente.ReadOnly = true;
            this.cpfCnpjCliente.Width = 200;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 554);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.dataGridViewClientes);
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfCnpjCliente;
    }
}