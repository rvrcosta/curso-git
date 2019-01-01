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
    public partial class FormCadastroUnidadesMedidaEditar : Form
    {
        public FormCadastroUnidadesMedidaEditar()
        {
            InitializeComponent();
        }

        public FormCadastroUnidadesMedidaEditar(int id){
            InitializeComponent();

            try
            {
                tbCodigo.Text = id.ToString();
                AccessBd bd = new AccessBd();
                String tabela = "comercialUnidadeMedida";
                bd.setSql("SELECT *  FROM comercialUnidadeMedida where idUnidadeMedida=" + id);
                bd.insereAtualizaInicio(tabela);
                string nomeUnidade = bd.retornaCampo(tabela, "nomeUnidadeMedida", "idUnidadeMedida", id);
                string siglaUnidade = bd.retornaCampo(tabela, "siglaUnidadeMedida", "idUnidadeMedida", id);                                
                bd.insereAtualizaFim(tabela, false, false);
                tbNomeUnidade.Text = nomeUnidade;
                tbSiglaUnidade.Text = siglaUnidade;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível carregar os dados do cliente. Reporte o erro.:" + erro);
            }  
        }


        private void FormCadastroUnidadesMedidaEditar_Load(object sender, EventArgs e)
        {


        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            try
            {
                AccessBd bd = new AccessBd();
                String tabela = "comercialUnidadeMedida";
                bd.setSql("SELECT *  FROM comercialUnidadeMedida where idUnidadeMedida=" + Convert.ToInt32(tbCodigo.Text));
                bd.insereAtualizaInicio(tabela);
                bd.AlterarDataSet(tabela, "nomeUnidadeMedida", tbNomeUnidade.Text.ToUpper().Trim());
                bd.AlterarDataSet(tabela, "siglaUnidadeMedida", tbSiglaUnidade.Text.ToUpper().Trim());
                bd.insereAtualizaFim(tabela, false, false);
                MessageBox.Show("Registro Alterado com Sucesso");
                this.Close();

                FormCadastroUnidadesMedida formUnidadeMedida = new FormCadastroUnidadesMedida();
                formUnidadeMedida.Show();
            }
            catch (Exception error)
            {
                MessageBox.Show("Evento executado gerou erro.: " + error);

                FormCadastroUnidadesMedida formUnidadeMedida = new FormCadastroUnidadesMedida();
                formUnidadeMedida.Show();
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                AccessBd bd = new AccessBd();
                String tabela = "comercialUnidadeMedida";
                bd.setSql("SELECT *  FROM comercialUnidadeMedida where idUnidadeMedida=" + Convert.ToInt32(tbCodigo.Text));
                bd.deleta(tabela);
                this.Close();

                FormCadastroUnidadesMedida formUnidadeMedida = new FormCadastroUnidadesMedida();
                formUnidadeMedida.Show();
            }
            catch (Exception error)
            {
                MessageBox.Show("Evento executado gerou erro.: " + error);

                FormCadastroUnidadesMedida formUnidadeMedida = new FormCadastroUnidadesMedida();
                formUnidadeMedida.Show();
            }
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormCadastroUnidadesMedida formUnidadeMedida = new FormCadastroUnidadesMedida();
            formUnidadeMedida.Show();   

        }

        
       
      
      
    }
}
