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
    public partial class FormCadastroClientes : Form
    {
        public FormCadastroClientes()
        {
            InitializeComponent();
        }
        public FormCadastroClientes(int id)
        {
            InitializeComponent();

            try
            {
                lbCodigoCliente.Text = id.ToString();
                AccessBd bd = new AccessBd();
                String tabela = "comercialCliente";
                bd.setSql("SELECT *  FROM comercialCliente where idCliente=" + id);
                bd.insereAtualizaInicio(tabela);

                string nomeCliente = bd.retornaCampo(tabela, "nomeCliente", "idCliente", id);
                string tipoCpfCnpjCliente = bd.retornaCampo(tabela, "tipoCpfCnpjCliente", "idCliente", id);
                string cpfCnpjCliente = bd.retornaCampo(tabela, "cpfCnpjCliente", "idCliente", id);
                string telCliente01 = bd.retornaCampo(tabela, "telCliente01", "idCliente", id);
                string telCliente02 = bd.retornaCampo(tabela, "telCliente02", "idCliente", id);
                string telCliente03 = bd.retornaCampo(tabela, "telCliente03", "idCliente", id);
                string endCliente = bd.retornaCampo(tabela, "endCliente", "idCliente", id);                
                string bairroCliente = bd.retornaCampo(tabela, "bairroCliente", "idCliente", id);
                string cidadeCliente = bd.retornaCampo(tabela, "cidadeCliente", "idCliente", id);
                string compCliente = bd.retornaCampo(tabela, "compCliente", "idCliente", id);
                string ufCliente = bd.retornaCampo(tabela, "ufCliente", "idCliente", id);
                string cepCliente = bd.retornaCampo(tabela, "cepCliente", "idCliente", id);
                string emailCliente = bd.retornaCampo(tabela, "emailCliente", "idCliente", id);
                bd.insereAtualizaFim(tabela, false, false);
                tbNome.Text = nomeCliente;
                if (tipoCpfCnpjCliente.Equals("CPF"))
                {
                    rbCPF.Checked = true;
                    mtbCPFCNPJ.Mask = ("000,000,000-00");
                }
                else
                {
                    rbCNPJ.Checked = true;
                    mtbCPFCNPJ.Mask = ("00,000,000/0000-00");
                }

                mtbCPFCNPJ.Text = cpfCnpjCliente;
                mtbTelResidencial.Text = telCliente01;
                mtbTelComercial.Text = telCliente02;
                mtbTelCelular.Text = telCliente03;
                tbLogradouro.Text = endCliente;                
                tbComplemento.Text = compCliente;
                tbBairro.Text = bairroCliente;
                tbCidade.Text = cidadeCliente;
                cbUF.SelectedItem = ufCliente;
                mtbCEP.Text = cepCliente;
                tbEmail.Text = emailCliente;  
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
                lbCPFCNPJ.Text = "CPF.:";
                mtbCPFCNPJ.Text = "";
                mtbCPFCNPJ.Mask = ("000,000,000-00");
            }
            else
            {
                lbCPFCNPJ.Text = "CNPJ.:";
                mtbCPFCNPJ.Text = "";
                mtbCPFCNPJ.Mask = ("00,000,000/0000-00");
            }
        }

        private void rbCNPJ_CheckedChanged(object sender, EventArgs e)
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

        private void mtbTelResidencial_Enter(object sender, EventArgs e)
        {
            mtbTelResidencial.SelectionStart = 1;
        }

        private void btPesquisaCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPesquisaCadastroCliente formulario = new FormPesquisaCadastroCliente();
            formulario.Show();
        }        

        private void FormCadastroClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaMaterialConstrucaoDataSet.comercialCliente' table. You can move, or remove it, as needed.
            
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            lbCodigoCliente.Text = "-";
            tbNome.Text = "";            
            rbCPF.Checked = true;
            mtbCPFCNPJ.Text = "";
            mtbTelResidencial.Text = "";
            mtbTelComercial.Text = "";
            mtbTelCelular.Text = "";
            tbLogradouro.Text = "";
            tbBairro.Text = "";
            mtbCEP.Text = "";
            tbEmail.Text = "";
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            string checado = "";
            string nomeCliente = tbNome.Text;
            string tipoCPFCNPJ = "";            
            string cpfCnpjCliente = mtbCPFCNPJ.Text;
            string telCliente01 = mtbTelResidencial.Text;
            string telCliente02 = mtbTelComercial.Text;
            string telCliente03 = mtbTelCelular.Text;
            string endCliente = tbLogradouro.Text;            
            string bairroCliente = tbBairro.Text;
            string compCliente = tbComplemento.Text;
            string cidadeCliente = tbCidade.Text;
            string ufCliente = cbUF.SelectedValue.ToString();
            string cepCliente = mtbCEP.Text;
            string emailCliente = tbEmail.Text;
            if (rbCPF.Checked == true)
            {
                tipoCPFCNPJ = "CPF";
            }
            else
            {
                tipoCPFCNPJ = "CNPJ";
            }

            AccessBd bd = new AccessBd();
            String tabela = "comercialCliente";
            checado = validacaoCampos() ;
                       
            if (lbCodigoCliente.Text == "-")
            {
                // Inseri um novo registro
                if (checado == "OK")
                {
                    bd.setSql("SELECT * FROM comercialCliente");
                    bd.insereAtualizaInicio(tabela);

                    if (tipoCPFCNPJ.Equals("CPF"))
                    {
                        if (validaCPF.IsCpf(mtbCPFCNPJ.Text))
                        {
                            DataRow dr = bd.IncluirDataSet(tabela);
                            dr["nomeCliente"] = nomeCliente.ToUpper().Trim();
                            dr["tipoCpfCnpjCliente"] = tipoCPFCNPJ;
                            dr["cpfCnpjCliente"] = cpfCnpjCliente;
                            if (telCliente01 != ("(   )     -"))
                            {
                                dr["telCliente01"] = telCliente01;
                            }
                            if (telCliente02 != ("(   )     -"))
                            {
                                dr["telCliente02"] = telCliente02;
                            }
                            if (telCliente03 != ("(   )      -"))
                            {
                                dr["telCliente03"] = telCliente03;
                            }
                            dr["compCliente"] = compCliente.ToUpper().Trim();
                            dr["endCliente"] = endCliente.ToUpper().Trim();
                            dr["bairroCliente"] = bairroCliente.ToUpper().Trim();
                            dr["cidadeCliente"] = cidadeCliente.ToUpper().Trim();
                            dr["ufCliente"] = ufCliente.ToUpper().Trim();
                            if (mtbCEP.Text != "  .   -")
                            {
                                dr["cepCliente"] = cepCliente.ToUpper().Trim();
                            }
                            dr["emailCliente"] = emailCliente.ToUpper().Trim();
                            dr["dataCadastramentoCliente"] = DateTime.Now.ToString();
                            bd.insereAtualizaFim(tabela, true, dr, false);
                            //bd.IncluirDataSetNewRowFim(tabela);

                            lbCodigoCliente.Text = "-";
                            tbNome.Text = "";
                            rbCPF.Checked = true;
                            mtbCPFCNPJ.Text = "";
                            mtbTelResidencial.Text = "";
                            mtbTelComercial.Text = "";
                            mtbTelCelular.Text = "";
                            tbLogradouro.Text = "";
                            tbComplemento.Text = "";
                            tbBairro.Text = "";
                            tbCidade.Text = "";
                            cbUF.SelectedItem = "";
                            mtbCEP.Text = "";
                            tbEmail.Text = "";
                            MessageBox.Show("Novo cliente registrado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("CPF Inválido");
                        }
                    }
                    else
                    {
                        if (validaCNPJ.IsCnpj(mtbCPFCNPJ.Text))
                        {
                            DataRow dr = bd.IncluirDataSet(tabela);
                            dr["nomeCliente"] = nomeCliente.ToUpper().Trim();
                            dr["tipoCpfCnpjCliente"] = tipoCPFCNPJ;
                            dr["cpfCnpjCliente"] = cpfCnpjCliente;
                            if (telCliente01 != ("(   )     -"))
                            {
                                dr["telCliente01"] = telCliente01;
                            }
                            if (telCliente02 != ("(   )     -"))
                            {
                                dr["telCliente02"] = telCliente02;
                            }
                            if (telCliente03 != ("(   )      -"))
                            {
                                dr["telCliente03"] = telCliente03;
                            }
                            dr["endCliente"] = endCliente.ToUpper().Trim();
                            dr["compCliente"] = compCliente.ToUpper().Trim();
                            dr["bairroCliente"] = bairroCliente.ToUpper().Trim();
                            dr["cidadeCliente"] = cidadeCliente.ToUpper().Trim();
                            dr["ufCliente"] = ufCliente.ToUpper().Trim();
                            if (mtbCEP.Text != "  .   -")
                            {
                                dr["cepCliente"] = cepCliente.ToUpper().Trim();
                            }
                            dr["emailCliente"] = emailCliente.ToUpper().Trim();
                            dr["dataCadastramentoCliente"] = DateTime.Now.ToString();
                            bd.insereAtualizaFim(tabela, true, dr, false);
                            //bd.IncluirDataSetNewRowFim(tabela);

                            lbCodigoCliente.Text = "-";
                            tbNome.Text = "";
                            rbCPF.Checked = true;
                            mtbCPFCNPJ.Text = "";
                            mtbTelResidencial.Text = "";
                            mtbTelComercial.Text = "";
                            mtbTelCelular.Text = "";
                            tbLogradouro.Text = "";
                            tbComplemento.Text = "";
                            tbBairro.Text = "";
                            tbCidade.Text = "";
                            cbUF.SelectedItem = "";
                            mtbCEP.Text = "";
                            tbEmail.Text = "";
                            MessageBox.Show("Novo cliente registrado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("CNPJ Inválido");
                        }
                    }
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
                    bd.setSql("SELECT * FROM comercialCliente where idCliente=" + Convert.ToInt32(lbCodigoCliente.Text));

                    bd.insereAtualizaInicio(tabela);

                    if(tipoCPFCNPJ.ToUpper().Trim().Equals("CPF")){

                        if (validaCPF.IsCpf(mtbCPFCNPJ.Text)){

                            bd.AlterarDataSet(tabela, "nomeCliente", nomeCliente.ToUpper().Trim());
                            bd.AlterarDataSet(tabela, "tipoCpfCnpjCliente", tipoCPFCNPJ.ToUpper().Trim());
                            bd.AlterarDataSet(tabela, "cpfCnpjCliente", cpfCnpjCliente);
                            if (telCliente01 != ("(   )     -"))
                            {
                                bd.AlterarDataSet(tabela, "telCliente01", telCliente01);
                            }
                            if (telCliente02 != ("(   )     -"))
                            {
                                bd.AlterarDataSet(tabela, "telCliente02", telCliente02);
                            }
                            if (telCliente03 != ("(   )     -"))
                            {
                                bd.AlterarDataSet(tabela, "telCliente03", telCliente03);
                            }
                            bd.AlterarDataSet(tabela, "endCliente", endCliente.ToUpper().Trim());
                            bd.AlterarDataSet(tabela, "compCliente", compCliente.ToUpper().Trim());
                            bd.AlterarDataSet(tabela, "bairroCliente", bairroCliente.ToUpper().Trim());
                            bd.AlterarDataSet(tabela, "cidadeCliente", cidadeCliente.ToUpper().Trim());
                            bd.AlterarDataSet(tabela, "ufCliente", ufCliente.ToUpper().Trim());
                            if (mtbCEP.Text != "  .   -") { 
                                bd.AlterarDataSet(tabela, "cepCliente", cepCliente);
                            }
                            bd.AlterarDataSet(tabela, "emailCliente", emailCliente.ToUpper().Trim());
                            bd.insereAtualizaFim(tabela, false, false);
                            lbCodigoCliente.Text = "-";
                            tbNome.Text = "";
                            rbCPF.Checked = true;
                            mtbCPFCNPJ.Text = "";
                            mtbTelResidencial.Text = "";
                            mtbTelComercial.Text = "";
                            mtbTelCelular.Text = "";
                            tbLogradouro.Text = "";
                            tbComplemento.Text = "";
                            tbBairro.Text = "";
                            tbCidade.Text = "";
                            cbUF.SelectedItem = "";
                            mtbCEP.Text = "";
                            tbEmail.Text = ""; 
                            MessageBox.Show("Alteração registrada com sucesso!");

                        } else {
                            MessageBox.Show("CPF Inválido");
                        }
                    }     
                    else {

                        if (validaCNPJ.IsCnpj(mtbCPFCNPJ.Text)){

                            bd.AlterarDataSet(tabela, "nomeCliente", nomeCliente.ToUpper().Trim());
                            bd.AlterarDataSet(tabela, "tipoCpfCnpjCliente", tipoCPFCNPJ.ToUpper().Trim());
                            bd.AlterarDataSet(tabela, "cpfCnpjCliente", cpfCnpjCliente);
                            if (telCliente01 != ("(   )     -"))
                            {
                                bd.AlterarDataSet(tabela, "telCliente01", telCliente01);
                            }
                            if (telCliente02 != ("(   )     -"))
                            {
                                bd.AlterarDataSet(tabela, "telCliente02", telCliente02);
                            }
                            if (telCliente03 != ("(   )     -"))
                            {
                                bd.AlterarDataSet(tabela, "telCliente03", telCliente03);
                            }
                            bd.AlterarDataSet(tabela, "endCliente", endCliente.ToUpper().Trim());
                            bd.AlterarDataSet(tabela, "compCliente", compCliente.ToUpper().Trim());
                            bd.AlterarDataSet(tabela, "bairroCliente", bairroCliente.ToUpper().Trim());
                            bd.AlterarDataSet(tabela, "cidadeCliente", cidadeCliente.ToUpper().Trim());
                            bd.AlterarDataSet(tabela, "ufCliente", ufCliente.ToUpper().Trim());
                            if (mtbCEP.Text != "  .   -") { 
                                bd.AlterarDataSet(tabela, "cepCliente", cepCliente);
                            }
                            bd.AlterarDataSet(tabela, "emailCliente", emailCliente.ToUpper().Trim());
                            bd.insereAtualizaFim(tabela, false, false);
                            lbCodigoCliente.Text = "-";
                            tbNome.Text = "";
                            rbCPF.Checked = true;
                            mtbCPFCNPJ.Text = "";
                            mtbTelResidencial.Text = "";
                            mtbTelComercial.Text = "";
                            mtbTelCelular.Text = "";
                            tbLogradouro.Text = "";
                            tbComplemento.Text = "";
                            tbBairro.Text = "";
                            tbCidade.Text = "";
                            cbUF.SelectedItem = "";
                            mtbCEP.Text = "";
                            tbEmail.Text = ""; 
                            MessageBox.Show("Alteração registrada com sucesso!");

                        } else {
                            MessageBox.Show("CNPJ Inválido");
                        }
                    }
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

                if (cbUF.SelectedText == "")
                {
                    validacao = validacao.Replace("!", ", ") + "UF!"; 
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
            if (lbCodigoCliente.Equals("-"))
            {
                lbCodigoCliente.Text = "-";
                tbNome.Text = "";
                rbCPF.Checked = true;
                mtbCPFCNPJ.Text = "";
                mtbTelResidencial.Text = "";
                mtbTelComercial.Text = "";
                mtbTelCelular.Text = "";
                tbLogradouro.Text = "";
                tbComplemento.Text = "";
                tbBairro.Text = "";
                tbCidade.Text = "";
                cbUF.SelectedItem = "";
                mtbCEP.Text = "";
                tbEmail.Text = "";
            }
            else
            {
                if (lbCodigoCliente.Text != "-")
                {
                    AccessBd bd = new AccessBd();
                    String tabela = "comercialCliente";
                    
                    bd.setSql("SELECT *  FROM comercialCliente where idCliente=" + Convert.ToInt32(lbCodigoCliente.Text));
                    bd.deleta(tabela);
                    lbCodigoCliente.Text = "-";
                    tbNome.Text = "";
                    rbCPF.Checked = true;
                    mtbCPFCNPJ.Text = "";
                    mtbTelResidencial.Text = "";
                    mtbTelComercial.Text = "";
                    mtbTelCelular.Text = "";
                    tbLogradouro.Text = "";
                    tbComplemento.Text = "";
                    tbBairro.Text = "";
                    tbCidade.Text = "";                    
                    cbUF.SelectedItem = "";
                    mtbCEP.Text = "";
                    tbEmail.Text = "";  
                    

                }
                else
                {
                    lbCodigoCliente.Text = "-";
                    tbNome.Text = "";
                    rbCPF.Checked = true;
                    mtbCPFCNPJ.Text = "";
                    mtbTelResidencial.Text = "";
                    mtbTelComercial.Text = "";
                    mtbTelCelular.Text = "";
                    tbLogradouro.Text = "";
                    tbComplemento.Text = "";
                    tbBairro.Text = "";
                    tbCidade.Text = "";
                    cbUF.SelectedValue = "";
                    mtbCEP.Text = "";
                    tbEmail.Text = "";
                    MessageBox.Show("Campos limpos com sucesso!");
                }
            }            
        }

        private void btNovo_MouseHover(object sender, EventArgs e)
        {
            toolTipNovoRegistro.Show("Novo Registro", btNovo);
        }

        private void btGravar_MouseHover(object sender, EventArgs e)
        {
            toolTipNovoRegistro.Show("Gravar Registro", btGravar);
        }

        private void btExcluir_MouseHover(object sender, EventArgs e)
        {
            toolTipNovoRegistro.Show("Excluir Registro", btGravar);
        }

        private void btFechar_MouseHover(object sender, EventArgs e)
        {
            toolTipNovoRegistro.Show("Fechar Formulário", btGravar);
        }

        private void btNovo_MouseLeave(object sender, EventArgs e)
        {
            toolTipNovoRegistro.RemoveAll();
        }

        private void btPesquisaCEP_Click(object sender, EventArgs e)
        {
            try
            {
                var ws = new WSCorreios.AtendeClienteClient();
                var consultaCep = ws.consultaCEP(mtbCEP.Text.Replace(".", "").Replace("-", "").Replace(",", "").Trim().ToString());

                if (consultaCep != null)
                {
                    tbLogradouro.Text = consultaCep.end;
                    tbBairro.Text = consultaCep.bairro;
                    tbCidade.Text = consultaCep.cidade;
                    cbUF.SelectedText = consultaCep.uf;                    
                }
                else
                {
                    mtbCEP.Clear();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar consulta. Descrição.: " + erro);
            }

        }

         
        
    }
}
