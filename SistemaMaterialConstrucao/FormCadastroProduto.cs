using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMaterialConstrucao
{
    public partial class FormCadastroProduto : Form
    {
        public FormCadastroProduto()
        {
            InitializeComponent();            
        }

        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {
                        

            AccessBd bd = new AccessBd();
            String tabela = "comercialUnidadeMedida";
            bd.PreencheComboBox(cbUnidadesMedida, tabela, "siglaUnidadeMedida", "idUnidadeMedida", "siglaUnidadeMedida ASC", true);
            bd.insereAtualizaFim(tabela, false, false);

            bd = new AccessBd();
            tabela = "comercialGrupoProdutos";
            bd.PreencheComboBox(cbGrupoProdutos, tabela, "nomeGrupoProdutos", "idGrupoProdutos", "nomeGrupoProdutos ASC", true);
            bd.insereAtualizaFim(tabela, false, false);

            bd = new AccessBd();
            tabela = "comercialFornecedor";
            bd.PreencheComboBox(cbFornecedor, tabela, "nomeFornecedor", "idFornecedor", "nomeFornecedor ASC", true);            
            bd.insereAtualizaFim(tabela, false, false);

            cbFornecedor.SelectedIndex = -1;
            cbGrupoProdutos.SelectedIndex = -1;
            cbUnidadesMedida.SelectedIndex = -1;    
                        
           }

        private void btNovo_Click(object sender, EventArgs e)
        {

        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            try
            {

                String tabela = "comercialProdutos";
                AccessBd bd = new AccessBd();
                bd.setSql("SELECT * FROM comercialProdutos");
                bd.insereAtualizaInicio(tabela);
                DataRow dr = bd.IncluirDataSet(tabela);
                dr["nomeProduto"] = tbNomeProduto.Text.ToUpper().Trim();
                dr["qtdProduto"] = tbQtd.Text.ToUpper().Trim();
                dr["precoVendaProduto"] = tbPrecoVenda.Text.ToUpper().Trim();
                dr["fkUnidadeMedida"] = cbUnidadesMedida.SelectedValue;
                dr["fkGrupoProdutos"] = cbGrupoProdutos.SelectedValue;
                bd.insereAtualizaFim(tabela, true, dr, false);


                // Retorna o id do produto
                tabela = "comercialProdutos";
                bd.setSql("SELECT *  FROM comercialProdutos where nomeProduto='" + tbNomeProduto.Text.ToUpper().Trim() + "'");
                bd.insereAtualizaInicio(tabela);
                string idProduto = bd.retornaCampo(tabela, "idProduto", "nomeProduto", tbNomeProduto.Text.ToUpper().Trim().ToString());
                bd.insereAtualizaFim(tabela, false, false);

                // Inseri Log de Compra
                tabela = "comercialProdutoLogCompra";
                bd = new AccessBd();
                bd.setSql("SELECT * FROM comercialProdutoLogCompra");
                bd.insereAtualizaInicio(tabela);
                dr.Delete();
                dr = bd.IncluirDataSet(tabela);
                dr["fkProduto"] = idProduto.ToUpper().Trim();
                dr["fkFornecedor"] = cbFornecedor.SelectedValue;
                dr["custoProduto"] = tbPrecoCusto.Text.ToUpper().Trim();
                dr["dataInclusao"] = DateTime.Now.ToString();
                bd.insereAtualizaFim(tabela, true, dr, false);
                limparCampos();
                MessageBox.Show("Produto Cadastrado com sucesso");

            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao executar a ação.: " + error);
            }
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbPrecoCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            // Check if the pressed character was a backspace or numeric.
            if (e.KeyChar != (char)8 && !char.IsNumber(e.KeyChar) && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }

            /*
            if (tbPrecoCusto.Text.Length >= 3) // commas should appear only if there are more than 3 digits
            {
                // First, taje the numbers only, no commas
                string formattedText = "";
                string textToFormat = (tbPrecoCusto.Text + e.KeyChar);

                // Put a comma after every 3 digits
                for (int index = textToFormat.Length - 1, counter = 1; index >= 0; index--, counter++)
                {
                    formattedText = formattedText + textToFormat[index].ToString();
                    if (counter % 3 == 0 && index > 0)
                        formattedText += ".";
                }

                e.Handled = true;

                tbPrecoCusto.Text = "";

                // Reverse the number to display properly
                for (int index = formattedText.Length - 1; index >= 0; index--)
                {
                    tbPrecoCusto.Text += formattedText[index];
                }
                formattedText = "";

                // Put cursor at the end of the text
                tbPrecoCusto.Select(tbPrecoCusto.Text.Length, 0);
            }   
            */

        }
        
        private void tbPrecoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            // Check if the pressed character was a backspace or numeric.
            if (e.KeyChar != (char)8 && !char.IsNumber(e.KeyChar) && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void tbQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            // Check if the pressed character was a backspace or numeric.
            if (e.KeyChar != (char)8 && !char.IsNumber(e.KeyChar) && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        public void limparCampos()
        {
            tbNomeProduto.Text = "";
            tbPrecoCusto.Text = "";
            tbPrecoVenda.Text = "";
            tbQtd.Text = "";
            cbFornecedor.SelectedValue="";
            cbGrupoProdutos.SelectedValue = "";
            cbUnidadesMedida.SelectedValue = "";

        }
    }
}
