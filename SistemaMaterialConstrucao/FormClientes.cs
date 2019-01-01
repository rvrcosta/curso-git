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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
            AccessBd bd = new AccessBd();
            bd.PreencheDataGridView(dataGridViewClientes, "comercialCliente");

            for (int u = 0; u < dataGridViewClientes.RowCount; u++)
            {
                dataGridViewClientes.Rows[u].Visible = true;
                u++;
            }

        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {

            for (int u = 0; u < dataGridViewClientes.RowCount; u++)
            {
                dataGridViewClientes.Rows[u].Visible = true;
                u++;
            }

            for (int u = 0; u < dataGridViewClientes.RowCount; u++)
            {                

                if ((dataGridViewClientes.Rows[u].Cells[1].Value.ToString().Contains(tbFilter.Text))||(dataGridViewClientes.Rows[u].Cells[2].Value.ToString().Contains(tbFilter.Text)))
                {
                    dataGridViewClientes.Rows[u].Visible = true;
                }
                else
                {
                    dataGridViewClientes.Rows[u].Visible = false;
                }

               
            }




        }
    }
}
