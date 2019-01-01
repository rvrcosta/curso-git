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
    public partial class FormTelaInicial : Form
    {
        public FormTelaInicial()
        {
            InitializeComponent();
            this.Hide();
 

           // FormAcesso formAcesso = new FormAcesso();
           // formAcesso.Show();            
            
        }

        public FormTelaInicial(String usuario)
        {
            InitializeComponent();            

        }

        private void toolStripButtonCadastroCliente_Click(object sender, EventArgs e)
        {
            FormCadastroClientes formCadastroCliente = new FormCadastroClientes();
            formCadastroCliente.Show();
        }

        private void perfilDeAcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroClientes formCadastroCliente = new FormCadastroClientes();
            formCadastroCliente.Show();
        }

        private void cadastroFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroFornecedores formCadastroFornecedores = new FormCadastroFornecedores();
            formCadastroFornecedores.Show();
        }

        private void toolStripButtonCadastroFornecedor_Click(object sender, EventArgs e)
        {
            FormCadastroFornecedores formCadastroFornecedores = new FormCadastroFornecedores();
            formCadastroFornecedores.Show();
        }

        private void cadastroDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroProduto formCadastroProduto = new FormCadastroProduto();
            formCadastroProduto.Show();
        }

        private void cadastroUnidadesDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroUnidadesMedida formCadastroUnidadesMedida = new FormCadastroUnidadesMedida();
            formCadastroUnidadesMedida.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModuloVendas formModuloVendas = new FormModuloVendas();
            formModuloVendas.Show();
        }

        private void FormTelaInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cadastroDeClientes2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();
            formClientes.Show();
        }
    }
}
