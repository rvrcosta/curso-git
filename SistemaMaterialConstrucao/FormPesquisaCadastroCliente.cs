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
    public partial class FormPesquisaCadastroCliente : Form
    {
        public FormPesquisaCadastroCliente()
        {
            InitializeComponent();
        }

        private void FormPesquisaCadastroCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaMaterialConstrucaoDataSet.comercialCliente' table. You can move, or remove it, as needed.
            AccessBd bd = new AccessBd();
            String tabela = "comercialCliente";
            bd.PreencheComboBox(cbCliente, tabela, "nomeCliente", "idCliente", "nomeCliente ASC", true);
            bd.insereAtualizaFim(tabela, false, false);
            //bd.setSql("SELECT * comercialCliente");

            //bd.insereAtualizaInicio(tabela);
            
            //bd.PreencheComboBox(cbCliente, tabela, "idCliente", "nomeCliente", false);
        }        

        private void btPesquisaNome_Click(object sender, EventArgs e)
        {
            if (cbCliente.SelectedValue==null)
            {
                var formCadastro = new FormCadastroClientes();
                formCadastro.Show();
                this.Close();  
            }
            else
            {
                int id = Convert.ToInt32(cbCliente.SelectedValue.ToString());

                var formCadastro = new FormCadastroClientes(id);
                formCadastro.Show();
                this.Close();
            }
                    
            
        }
   
       
    }
}
