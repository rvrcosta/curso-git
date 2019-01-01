using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMaterialConstrucao
{
    public partial class FormPesquisaCadastroFornecedores : Form
    {
        public FormPesquisaCadastroFornecedores()
        {
            InitializeComponent();
        }

        private void FormPesquisaCadastroFornecedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaMaterialConstrucaoDataSet.comercialCliente' table. You can move, or remove it, as needed.
            AccessBd bd = new AccessBd();
            String tabela = "comercialFornecedor";
            bd.PreencheComboBox(cbFornecedor, tabela, "nomeFornecedor", "idFornecedor", "nomeFornecedor ASC", true);
            bd.insereAtualizaFim(tabela, false, false);
            //bd.setSql("SELECT * comercialCliente");

            //bd.insereAtualizaInicio(tabela);
            
            //bd.PreencheComboBox(cbCliente, tabela, "idCliente", "nomeCliente", false);
        }        

        private void btPesquisaNome_Click(object sender, EventArgs e)
        {
            if (cbFornecedor.SelectedValue == null)
            {
                var formCadastro2 = new FormCadastroFornecedores();
                formCadastro2.Show();
                this.Close(); 
            }
            else
            {
                int id = Convert.ToInt32(cbFornecedor.SelectedValue.ToString());
                var formCadastro = new FormCadastroFornecedores(id);
                formCadastro.Show();
                this.Close();     
            }
        }         
       
    }
}
