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
    public partial class FormModuloVendaStatus : Form
    {
        public FormModuloVendaStatus()
        {
            InitializeComponent();
            gbOrcamento.Visible = false;
            gbVenda.Visible = false;
            
            mbDataValidadeOrcamento.Text = DateTime.Now.AddDays(7).ToShortDateString();

        }
        public FormModuloVendaStatus(String cpf, String produtos)
        {
            InitializeComponent();
            gbOrcamento.Visible = false;
            gbVenda.Visible = false;

            mbDataValidadeOrcamento.Text = DateTime.Now.AddDays(7).ToShortDateString();
        }
        
        private void btCalendar_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible)
            {
                monthCalendar1.Visible = false;
            }
            else
            {
                monthCalendar1.Visible = true;
            }
        }       

        private void cbDinheiro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbCheque_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbCartao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbOutros_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.SelectedItem == "ORÇAMENTO")
            {
                gbVenda.Visible = false;
                gbOrcamento.Visible = true;
            }
            if (cbStatus.SelectedItem == "VENDA")
            {
                gbOrcamento.Visible = false;
                gbVenda.Visible = true;
            }
            if (cbStatus.SelectedItem == "")
            {
                gbOrcamento.Visible = false;
                gbVenda.Visible = false;
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            mbDataValidadeOrcamento.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
            monthCalendar1.Visible = false;
        }

        private void monthCalendar1_Leave(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
        }
    }
}
