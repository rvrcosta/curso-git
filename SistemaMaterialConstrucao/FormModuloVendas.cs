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
    public partial class FormModuloVendas : Form
    {
        public FormModuloVendas()
        {
            InitializeComponent();
        }

        private void FormModuloVendas_Load(object sender, EventArgs e)
        {
            lbDataPedido.Text = DateTime.Now.ToString();
            AccessBd bd = new AccessBd();
            String tabela = "comercialProdutos";
            bd.PreencheComboBox(cbProduto, tabela, "nomeProduto", "idProduto", "nomeProduto ASC", true);
            bd.insereAtualizaFim(tabela, false, false);        
            cbProduto.SelectedIndex = -1;
            tbCodigoProduto.Text = "";            
            dataGridViewDadosPedido.ColumnCount = 5;
            dataGridViewDadosPedido.Columns[0].Name = "Código do Produto";
            dataGridViewDadosPedido.Columns[1].Name = "Nome do Produto";
            dataGridViewDadosPedido.Columns[2].Name = "Preço do Unit";
            dataGridViewDadosPedido.Columns[3].Name = "Quantidade do Produto";
            dataGridViewDadosPedido.Columns[4].Name = "Preço Total";
            //dataGridViewDadosPedido.Columns[4].ValueType = typeof(Double);
            dataGridViewDadosPedido.Columns[0].Width = 80;
            dataGridViewDadosPedido.Columns[1].Width = 500;
            dataGridViewDadosPedido.Columns[2].Width = 100;
            dataGridViewDadosPedido.Columns[3].Width = 100;
            dataGridViewDadosPedido.Columns[4].Width = 100;            
        }

        //**************************************************
        //
        // Eventos para adicionar ou excluir produtos no datagridview
        //
        //**************************************************

        private void btAdicionarProduto_Click(object sender, EventArgs e)
        {
            String verificacaoExisteProdutoGridView = "";
            String quantidadeComprada = tbQtdProduto.Text;
            Int32 id = 0;
            if (tbCodigoProduto.Text != "")
            {
                id = Convert.ToInt32(tbCodigoProduto.Text);
            }

            if (id != 0 && quantidadeComprada!="" && cbProduto.SelectedIndex!= -1)
            {
                AccessBd bd = new AccessBd();
                String tabela = "comercialProdutos";
                bd.setSql("SELECT * FROM comercialProdutos where idProduto=" + id);
                bd.insereAtualizaInicio(tabela);
                String nomeProduto = bd.retornaCampo(tabela, "nomeProduto", "idProduto", id);
                String codigoProduto = tbCodigoProduto.Text;
                String precoProduto = bd.retornaCampo(tabela, "precoVendaProduto", "idProduto", id);
                String quantidadeEstoque = bd.retornaCampo(tabela, "qtdProduto", "idProduto", id);
                String precoTotal = "0";                
                bd.insereAtualizaFim(tabela, false, false);

                for (int i = 0; i < dataGridViewDadosPedido.Rows.Count; i++)
                {
                    Int32 codProdutoGridView = Convert.ToInt32(dataGridViewDadosPedido.Rows[i].Cells[0].Value);

                    if (codProdutoGridView == id)
                    {
                        // Rotina para caso já haja o Codigo do Produto no pedido para inclusão apenas da quantidade solicitada.
                        verificacaoExisteProdutoGridView = "Existe";
                        
                        if (Convert.ToDouble(quantidadeEstoque) >= (Convert.ToDouble(quantidadeComprada) + Convert.ToDouble(dataGridViewDadosPedido.Rows[i].Cells[3].Value)))
                        {
                            quantidadeComprada = Convert.ToString(Convert.ToDouble(quantidadeComprada) + Convert.ToDouble(dataGridViewDadosPedido.Rows[i].Cells[3].Value));
                            quantidadeComprada = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(quantidadeComprada));
                            precoTotal = Convert.ToString(Convert.ToDouble(quantidadeComprada) * Convert.ToDouble(dataGridViewDadosPedido.Rows[i].Cells[2].Value));
                            precoTotal = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(precoTotal));                              
                            dataGridViewDadosPedido.Rows[i].Cells[3].Value = quantidadeComprada;
                            dataGridViewDadosPedido.Rows[i].Cells[4].Value = precoTotal;
                        }
                        else
                        {
                            MessageBox.Show("Quantidade no estoque menor que o solicitado. Estoque atual em " + quantidadeEstoque);
                        }
                    }
                }

                if (verificacaoExisteProdutoGridView!="Existe" && (Convert.ToDouble(quantidadeEstoque) >= Convert.ToDouble(quantidadeComprada)))
                {
                    precoTotal = Convert.ToString(Convert.ToDouble(precoProduto) * Convert.ToDouble(quantidadeComprada));
                    precoTotal = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(precoTotal));
                    precoProduto = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(precoProduto));
                    quantidadeComprada = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(quantidadeComprada));
                    precoTotal = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(precoTotal));

                    DataGridViewRow row = (DataGridViewRow)dataGridViewDadosPedido.RowTemplate.Clone();
                    row.CreateCells(dataGridViewDadosPedido, codigoProduto, nomeProduto, precoProduto, quantidadeComprada, precoTotal);
                    dataGridViewDadosPedido.Rows.Add(row);                    
                    // Código do Produto, Nome do Produto, Preço do Unit, Quantidade do Produto, Preço Total
                }
                else
                {
                    if (verificacaoExisteProdutoGridView != "Existe")
                    {
                        MessageBox.Show("Quantidade no estoque menor que o solicitado. Estoque atual em " + quantidadeEstoque);
                    }
                }
            }
            else
            {
                // Rotina para caso não haja codigo do produto ou quantidade da compra informada.
                if (id == 0)
                {
                    MessageBox.Show("Informe um produto!");
                } else if(cbProduto.SelectedIndex == -1){
                    MessageBox.Show("Informe um código de produto válido!");
                } else if(quantidadeComprada ==""){
                    MessageBox.Show("Informe a quantidade do produto na compra!");
                }
            }            
        }

        private void btExcluirProduto_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewDadosPedido.SelectedRows)
            {
                dataGridViewDadosPedido.Rows.RemoveAt(item.Index);
            }
        }

        //**************************************************
        //
        // Eventos para completar o Text Box Codigo do Produto ou o Combobox Produto
        //
        //**************************************************

        private void cbProduto_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbProduto.SelectedIndex != -1)
                {
                    tbCodigoProduto.Text = cbProduto.SelectedValue.ToString();
                }                
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro apresentado.: " + error);
            }
        }

        private void tbCodigoProduto_Leave(object sender, EventArgs e)
        {
            try
            {
                cbProduto.SelectedValue = tbCodigoProduto.Text;
                if (cbProduto.SelectedIndex == -1)
                {
                    tbCodigoProduto.Text = "";
                    MessageBox.Show("Código do Produto não localizado.");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro apresentado.: " + error);
            }
        }

        //**************************************************
        //
        // Eventos para acatar apenas numeros, backspace e virgula
        //
        //**************************************************

        private void tbQtdProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            // Check if the pressed character was a backspace or numeric.
            if (e.KeyChar != (char)8 && !char.IsNumber(e.KeyChar) && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }        

        private void tbCodigoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            // Check if the pressed character was a backspace or numeric.
            if (e.KeyChar != (char)8 && !char.IsNumber(e.KeyChar) && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }        

        //**************************************************
        //
        // Eventos para calculo do valor total do pedido.
        //
        //**************************************************

        private void dataGridViewDadosPedido_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            string valor = "0";
            for (int i = 0; i < dataGridViewDadosPedido.Rows.Count; i++)
            {          
                valor = Convert.ToString(Convert.ToDouble(dataGridViewDadosPedido.Rows[i].Cells[4].Value) + Convert.ToDouble(valor));               
            }
            valor = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(valor));
            lbValorTotalPedido.Text = "Valor Total do Pedido.: " + valor;
        }

        private void dataGridViewDadosPedido_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            string valor = "0";
            for (int i = 0; i < dataGridViewDadosPedido.Rows.Count; i++)
            {
                valor = Convert.ToString(Convert.ToDouble(dataGridViewDadosPedido.Rows[i].Cells[4].Value) + Convert.ToDouble(valor));
            }
            valor = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(valor));
            lbValorTotalPedido.Text = "Valor Total do Pedido.: " + valor;
        }       

        private void dataGridViewDadosPedido_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string valor = "0";
            for (int i = 0; i < dataGridViewDadosPedido.Rows.Count; i++)
            {
                valor = Convert.ToString(Convert.ToDouble(dataGridViewDadosPedido.Rows[i].Cells[4].Value) + Convert.ToDouble(valor));
            }
            valor = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(valor));
            lbValorTotalPedido.Text = "Valor Total do Pedido.: " + valor;
        }

        //**************************************************
        //
        // Eventos para seleção de CPF ou CNPJ.
        //
        //**************************************************

        private void rbPf_CheckedChanged(object sender, EventArgs e)
        {
            mbCPF.Mask = "000,000,000-00";
            lbCpfTitulo.Text = "CPF do cliente.: ";
        }

        private void rbPj_CheckedChanged(object sender, EventArgs e)
        {
            mbCPF.Mask = "00,000,000/0000-00";
            lbCpfTitulo.Text = "CNPJ do cliente.: ";
        }

        //**************************************************
        //
        // Evento consulta CPF ou CNPJ para retornar dados do cliente.
        //
        //**************************************************

        private void btConsultarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                String cpfCnpj = mbCPF.Text;
                String tipoSelecionado = "";
                String nomeCliente="";
                String codCliente ="";
                String telCliente = "";
                
                if (rbPf.Checked)
                {
                    tipoSelecionado = "CPF";
                }
                else
                {
                    tipoSelecionado = "CNPJ";
                }

                if (tipoSelecionado=="CPF" && !cpfCnpj.Contains(" "))
                {                    
                    AccessBd bd = new AccessBd();
                    String tabela = "comercialCliente";
                    bd.setSql("SELECT * FROM comercialCliente where cpfCnpjCliente='" + cpfCnpj+"'");
                    bd.insereAtualizaInicio(tabela);
                    nomeCliente = bd.retornaCampo(tabela, "nomeCliente", "cpfCnpjCliente", cpfCnpj);
                    codCliente = bd.retornaCampo(tabela, "idCliente", "cpfCnpjCliente", cpfCnpj);
                    telCliente = bd.retornaCampo(tabela, "telCliente01", "cpfCnpjCliente", cpfCnpj);  
                    bd.insereAtualizaFim(tabela, false, false);

                    tbNomeCliente.Text = nomeCliente;
                    tbCpfCnpj.Text = cpfCnpj;
                    tbIDCliente.Text = codCliente;
                    tbTelCliente.Text = telCliente;


                    btConsultarCliente.Enabled = false;
                    mbCPF.Enabled = false;
                    rbPf.Enabled = false;
                    rbPj.Enabled = false;
                    lbCpfTitulo.Enabled = false;

                    lbDataPedido.Text = DateTime.Now.ToString();

                    groupBox1.Visible = true;
                    groupBox2.Visible = true;
                    
                }
                else if (tipoSelecionado == "CNPJ" && !cpfCnpj.Contains(" "))
                {
                    AccessBd bd = new AccessBd();
                    String tabela = "comercialCliente";
                    bd.setSql("SELECT * FROM comercialCliente where cpfCnpjCliente='" + cpfCnpj + "'");
                    bd.insereAtualizaInicio(tabela);
                    nomeCliente = bd.retornaCampo(tabela, "nomeCliente", "cpfCnpjCliente", cpfCnpj);
                    codCliente = bd.retornaCampo(tabela, "idCliente", "cpfCnpjCliente", cpfCnpj);
                    telCliente = bd.retornaCampo(tabela, "telCliente01", "cpfCnpjCliente", cpfCnpj);
                    bd.insereAtualizaFim(tabela, false, false);

                    tbNomeCliente.Text = nomeCliente;
                    tbCpfCnpj.Text = cpfCnpj;
                    tbIDCliente.Text = codCliente;
                    tbTelCliente.Text = telCliente;
                    lbDataPedido.Text = DateTime.Now.ToString();

                    btConsultarCliente.Enabled = false;
                    mbCPF.Enabled = false;
                    rbPf.Enabled = false;
                    rbPj.Enabled = false;
                    lbCpfTitulo.Enabled = false;
                    groupBox1.Enabled = true;
                    groupBox2.Enabled = true;                    
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Não há cliente com este CPF cadastrado na nossa base de dados.", "Erro!");
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro" + error);
            }
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            FormModuloVendaStatus formModuloVendaStatus = new FormModuloVendaStatus();
            formModuloVendaStatus.Show();

            int quantidadeProdutosPedido = dataGridViewDadosPedido.Rows.Count;
            String[,] produtosPedido = new String[quantidadeProdutosPedido,5];            
            String cpfCnpj = "";
                       
            

           
            

            if (dataGridViewDadosPedido.Rows.Count != 0)
            {

                cpfCnpj = tbCpfCnpj.Text;

                for (int i = 0; i < dataGridViewDadosPedido.Rows.Count; i++)
                {
                    produtosPedido[i, 0] = Convert.ToString(dataGridViewDadosPedido.Rows[i].Cells[0].Value);
                    produtosPedido[i, 1] = Convert.ToString(dataGridViewDadosPedido.Rows[i].Cells[1].Value);
                    produtosPedido[i, 2] = Convert.ToString(dataGridViewDadosPedido.Rows[i].Cells[2].Value);
                    produtosPedido[i, 3] = Convert.ToString(dataGridViewDadosPedido.Rows[i].Cells[3].Value);
                    produtosPedido[i, 4] = Convert.ToString(dataGridViewDadosPedido.Rows[i].Cells[4].Value);                    
                }




            }
            else
            {
                MessageBox.Show("Não há produtos para este pedido.");
            }

        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            DialogResult verificador = MessageBox.Show("Seus dados do pedido atual seram perdidos. Você deseja iniciar um novo pedido?", "Deseja iniciar novo pedido?",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (verificador == DialogResult.Yes)
            {
                mbCPF.Text = "";
                rbPf.Checked=true;
                tbNomeCliente.Text = "";
                tbCpfCnpj.Text = "";
                tbIDCliente.Text = "";
                tbTelCliente.Text = "";
                cbProduto.SelectedIndex = -1;
                tbCodigoProduto.Text = "";
                tbQtdProduto.Text = "";
                dataGridViewDadosPedido.Rows.Clear();

                btConsultarCliente.Enabled = true;
                mbCPF.Enabled = true;
                rbPf.Enabled = true;
                rbPj.Enabled = true;
                lbCpfTitulo.Enabled = true;               

                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;

            }            


            
        }

       
    }
}
