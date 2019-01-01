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
    public partial class FormCadastroFornecedores : Form
    {
        public FormCadastroFornecedores()
        {            
            InitializeComponent();
        }

        //Caso tenha parametro id
        public FormCadastroFornecedores(int id)
        {
            InitializeComponent();

            try
            {
                lbCodigoFornecedor.Text = id.ToString();
                AccessBd bd = new AccessBd();
                String tabela = "comercialFornecedor";
                bd.setSql("SELECT *  FROM comercialFornecedor where idFornecedor=" + id);
                bd.insereAtualizaInicio(tabela);

                string nomeFornecedor = bd.retornaCampo(tabela, "nomeFornecedor", "idFornecedor", id);
                string tipoCpfCnpjFornecedor = bd.retornaCampo(tabela, "tipoCpfCnpjFornecedor", "idFornecedor", id);
                string cpfCnpjFornecedor = bd.retornaCampo(tabela, "cpfCnpjFornecedor", "idFornecedor", id);
                string telFornecedor01 = bd.retornaCampo(tabela, "telFornecedor01", "idFornecedor", id);
                string telFornecedor02 = bd.retornaCampo(tabela, "telFornecedor02", "idFornecedor", id);
                string telFornecedor03 = bd.retornaCampo(tabela, "telFornecedor03", "idFornecedor", id);
                string endForncedor = bd.retornaCampo(tabela, "endFornecedor", "idFornecedor", id);
                string bairroForncedor = bd.retornaCampo(tabela, "bairroFornecedor", "idFornecedor", id);
                string cepFornecedor = bd.retornaCampo(tabela, "cepFornecedor", "idFornecedor", id);
                string emailFornecedor = bd.retornaCampo(tabela, "emailFornecedor", "idFornecedor", id);
                bd.insereAtualizaFim(tabela, false, false);
                tbNome.Text = nomeFornecedor;
                if (tipoCpfCnpjFornecedor.Equals("CPF"))
                {
                    rbCPF.Checked = true;
                    mtbCPFCNPJ.Mask = ("000,000,000-00");
                }
                else
                {
                    rbCNPJ.Checked = true;
                    mtbCPFCNPJ.Mask = ("00,000,000/0000-00");
                }

                mtbCPFCNPJ.Text = cpfCnpjFornecedor;
                mtbTelComercial.Text = telFornecedor01;
                mtbTelFax.Text = telFornecedor02;
                mtbTelCelular.Text = telFornecedor03;
                tbLogradouro.Text = endForncedor;
                tbBairro.Text = bairroForncedor;
                mtbCEP.Text = cepFornecedor;
                tbEmail.Text = emailFornecedor;  
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível carregar os dados do cliente. Reporte o erro.:" + erro);
            }                     
        }

        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCPF.Checked)
            {
                mtbCPFCNPJ.Text = "";
                mtbCPFCNPJ.Mask = ("000,000,000-00");
            }
            else
            {
                mtbCPFCNPJ.Text = "";
                mtbCPFCNPJ.Mask = ("00,000,000/0000-00");
            }
        }

        private void rbCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCPF.Checked)
            {
                lbCPFCNPJ.Text = "*CPF.:";
                mtbCPFCNPJ.Text = "";
                mtbCPFCNPJ.Mask = ("000,000,000-00");
            }
            else
            {
                lbCPFCNPJ.Text = "*CNPJ.:";
                mtbCPFCNPJ.Text = "";
                mtbCPFCNPJ.Mask = ("00,000,000/0000-00");
            }
        }

        private void mtbTelResidencial_Enter(object sender, EventArgs e)
        {
            mtbTelComercial.SelectionStart = 1;
        }

        private void btPesquisaCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPesquisaCadastroFornecedores formulario = new FormPesquisaCadastroFornecedores();
            formulario.Show();
        }        

        private void FormCadastroClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaMaterialConstrucaoDataSet.comercialCliente' table. You can move, or remove it, as needed.
            
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            lbCodigoFornecedor.Text = "-";
            tbNome.Text = "";            
            rbCPF.Checked = true;
            mtbCPFCNPJ.Text = "";
            mtbTelComercial.Text = "";
            mtbTelFax.Text = "";
            mtbTelCelular.Text = "";
            tbLogradouro.Text = "";
            tbBairro.Text = "";
            mtbCEP.Text = "";
            tbEmail.Text = "";
        }

        private void btGravar_Click(object sender, EventArgs e)
        {

            string checado = "";
            string nomeFornecedor = tbNome.Text;
            string tipoCPFCNPJ = "";            
            string cpfCnpjFornecedor = mtbCPFCNPJ.Text;
            string telFornecedor01 = mtbTelComercial.Text;
            string telFornecedor02 = mtbTelFax.Text;
            string telFornecedor03 = mtbTelCelular.Text;
            string endFornecedor = tbLogradouro.Text;
            string bairroFornecedor = tbBairro.Text;
            string cepFornecedor = mtbCEP.Text;
            string emailFornecedor = tbEmail.Text;
            if (rbCPF.Checked == true)
            {
                tipoCPFCNPJ = "CPF";
            }
            else
            {
                tipoCPFCNPJ = "CNPJ";
            }

            AccessBd bd = new AccessBd();
            String tabela = "comercialFornecedor";

            checado = validacaoCampos() ;
                       
            if (lbCodigoFornecedor.Text == "-")
            {
                // Inseri um novo registro
                if (checado == "OK")
                {
                    bd.setSql("SELECT * FROM comercialFornecedor");
                    bd.insereAtualizaInicio(tabela);

                    DataRow dr = bd.IncluirDataSet(tabela);
                    dr["nomeFornecedor"] = nomeFornecedor.ToUpper().Trim() ;
                    dr["tipoCpfCnpjFornecedor"] = tipoCPFCNPJ;
                    dr["cpfCnpjFornecedor"] = cpfCnpjFornecedor;
                    if (telFornecedor01 != ("(   )     -")) {
                        dr["telFornecedor01"] = telFornecedor01;
                    }
                    if (telFornecedor02 != ("(   )     -"))
                    {
                        dr["telFornecedor02"] = telFornecedor02;
                    }
                    if (telFornecedor03 != ("(   )      -"))
                    {
                        dr["telFornecedor03"] = telFornecedor03;
                    }
                    dr["endFornecedor"] = endFornecedor.ToUpper().Trim();
                    dr["bairroFornecedor"] = bairroFornecedor.ToUpper().Trim();
                    if (mtbCEP.Text != "  .   -")
                    { 
                        dr["cepFornecedor"] = cepFornecedor.ToUpper().Trim();
                    }
                    dr["emailFornecedor"] = emailFornecedor.ToUpper().Trim();
                    dr["dataCadastramentoFornecedor"] = DateTime.Now.ToString();                
                    bd.insereAtualizaFim(tabela, true, dr, false);                
                    //bd.IncluirDataSetNewRowFim(tabela);              

                    MessageBox.Show("Novo fornecedor registrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Há problemas com o preenchimento no(s) campo(s).: " + checado);
                }
            }
            else
            {
                // Altera um registro já existente registro
                if (checado == "OK")
                {
                    bd.setSql("SELECT * FROM comercialFornecedor where idFornecedor=" + Convert.ToInt32(lbCodigoFornecedor.Text));

                    bd.insereAtualizaInicio(tabela);

                    bd.AlterarDataSet(tabela, "nomeFornecedor", nomeFornecedor.ToUpper().Trim());
                    bd.AlterarDataSet(tabela, "tipoCpfCnpjFornecedor", tipoCPFCNPJ.ToUpper().Trim());
                    bd.AlterarDataSet(tabela, "cpfCnpjFornecedor", cpfCnpjFornecedor);
                    if (telFornecedor01 != ("(   )     -"))
                    {
                        bd.AlterarDataSet(tabela, "telFornecedor01", telFornecedor01);
                    }
                    if (telFornecedor02 != ("(   )     -"))
                    {
                        bd.AlterarDataSet(tabela, "telFornecedor02", telFornecedor02);
                    }
                    if (telFornecedor03 != ("(   )     -"))
                    {
                        bd.AlterarDataSet(tabela, "telFornecedor03", telFornecedor03);
                    }
                    bd.AlterarDataSet(tabela, "endFornecedor", endFornecedor.ToUpper().Trim());
                    bd.AlterarDataSet(tabela, "bairroFornecedor", bairroFornecedor.ToUpper().Trim());
                    if (mtbCEP.Text != "  .   -") {
                        bd.AlterarDataSet(tabela, "cepFornecedor", cepFornecedor);
                    }
                    bd.AlterarDataSet(tabela, "emailFornecedor", emailFornecedor.ToUpper().Trim());

                    bd.insereAtualizaFim(tabela, false, false);                   
                    MessageBox.Show("Alteração registrada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Há problemas com o preenchimento no(s) campo(s).: " + checado);
                }

                
            }
        }

        public string validacaoCampos()
        {
            string validacao = "OK";
            
            if (tbNome.Text.Equals("") || mtbCPFCNPJ.Text.Contains(" "))
            {
                validacao = "";

                if (tbNome.Text.Equals(""))
                {
                    validacao = "Nome!";
                }

                if (mtbCPFCNPJ.Text.Contains(" "))
                {
                    if (rbCPF.Checked == true)
                    {
                        validacao = validacao.Replace("!", ", ") + "CPF!";                        
                    }
                    else
                    {
                        validacao = validacao.Replace("!", ", ") + "CNPJ!";                        
                    }
                }

            }

            return validacao;
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (lbCodigoFornecedor.Equals("-"))
            {
                lbCodigoFornecedor.Text = "-";
                tbNome.Text = "";
                rbCPF.Checked = true;
                mtbCPFCNPJ.Text = "";
                mtbTelComercial.Text = "";
                mtbTelFax.Text = "";
                mtbTelCelular.Text = "";
                tbLogradouro.Text = "";
                tbBairro.Text = "";
                mtbCEP.Text = "";
                tbEmail.Text = "";
            }
            else
            {
                if (lbCodigoFornecedor.Text != "-")
                {

                
                AccessBd bd = new AccessBd();
                String tabela = "comercialFornecedor";

                bd.setSql("SELECT *  FROM comercialFornecedor where idFornecedor=" + Convert.ToInt32(lbCodigoFornecedor.Text));
                bd.deleta(tabela);

                lbCodigoFornecedor.Text = "-";
                tbNome.Text = "";
                rbCPF.Checked = true;
                mtbCPFCNPJ.Text = "";
                mtbTelComercial.Text = "";
                mtbTelFax.Text = "";
                mtbTelCelular.Text = "";
                tbLogradouro.Text = "";
                tbBairro.Text = "";
                mtbCEP.Text = "";
                tbEmail.Text = "";
                
                }
                else
                {
                    lbCodigoFornecedor.Text = "-";
                    tbNome.Text = "";
                    rbCPF.Checked = true;
                    mtbCPFCNPJ.Text = "";
                    mtbTelComercial.Text = "";
                    mtbTelFax.Text = "";
                    mtbTelCelular.Text = "";
                    tbLogradouro.Text = "";
                    tbBairro.Text = "";
                    mtbCEP.Text = "";
                    tbEmail.Text = "";
                    MessageBox.Show("Campos limpos com sucesso!");
                }

            }            
        }
        
    }
}
