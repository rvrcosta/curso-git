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
    public partial class FormCadastroUnidadesMedida : Form
    {
        public FormCadastroUnidadesMedida()
        {
            InitializeComponent();
            AccessBd bd = new AccessBd();
            bd.PreencheDataGridView(dataGridViewUnidadeMedida, "comercialUnidadeMedida");
        }      

        private void dataGridViewUnidadeMedida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewUnidadeMedida.CurrentRow.Cells[0].Value.ToString());
            var editarUnidadeMedida = new FormCadastroUnidadesMedidaEditar(id);
            editarUnidadeMedida.Show();
            this.Close();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            tbNomeUnidadeMedida.Text = "";
            tbSigla.Text = "";
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNomeUnidadeMedida.Text.Trim().Equals("") || tbSigla.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
                else
                {
                    AccessBd bd = new AccessBd();
                    String tabela = "comercialUnidadeMedida";
                    bd.setSql("SELECT *  FROM comercialUnidadeMedida");
                    bd.insereAtualizaInicio(tabela);
                    DataRow dr = bd.IncluirDataSet(tabela);
                    dr["nomeUnidadeMedida"] = tbNomeUnidadeMedida.Text.ToUpper().Trim();
                    dr["siglaUnidadeMedida"] = tbSigla.Text.ToUpper().Trim();
                    bd.insereAtualizaFim(tabela, true, dr, false);

                    bd = new AccessBd();
                    dataGridViewUnidadeMedida.Rows.Clear();
                    bd.PreencheDataGridView(dataGridViewUnidadeMedida, "comercialUnidadeMedida");

                    tbNomeUnidadeMedida.Text = "";
                    tbSigla.Text = "";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao executar ação. Descrição.: " + error);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridViewUnidadeMedida.CurrentRow.Cells[0].Value.ToString());
                AccessBd bd = new AccessBd();
                String tabela = "comercialUnidadeMedida";
                bd.setSql("SELECT *  FROM comercialUnidadeMedida where idUnidadeMedida=" + Convert.ToInt32(id));
                bd.deleta(tabela);

                bd = new AccessBd();
                dataGridViewUnidadeMedida.Rows.Clear();
                bd.PreencheDataGridView(dataGridViewUnidadeMedida, "comercialUnidadeMedida");
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao executar ação. Descrição.: " + error);
            }

        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
