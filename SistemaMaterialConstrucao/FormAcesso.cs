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
    public partial class FormAcesso : Form
    {
        public FormAcesso()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            this.panelPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text = "Acesso ao sistema SISCON.";
            this.lbTentativaAcesso.Visible = false;
        }
    

        private void btAcesso_Click(object sender, EventArgs e)
        {
            String usuario = "C138421";
            String tentativasAcesso = lbTentativaAcesso.Text.Replace("Tentativas de Acesso.: ","").ToString();
            // Tratamento para verificar se possui acesso ou não
            if (tentativasAcesso == "")
            {
                tentativasAcesso = "0";
            }
          

            //Não possui acesso

            if (tbUsuario.Text != usuario)
            {
                if (Convert.ToDouble(tentativasAcesso) >= 3)
                {
                    MessageBox.Show("Você realizou mais de 3 tentativas de acesso ao sistema sem sucesso. O Aplicativo está sendo encerrado");
                    Application.Exit();
                }

                if ( tentativasAcesso == "0")
                {
                    lbTentativaAcesso.Visible = true;
                    tentativasAcesso = "1";
                    lbTentativaAcesso.Text = "Tentativas de Acesso.: "+tentativasAcesso;                    
                }
                else
                {
                    lbTentativaAcesso.Visible = true;
                    tentativasAcesso = Convert.ToString(Convert.ToDouble(tentativasAcesso) + 1);
                    lbTentativaAcesso.Text = "Tentativas de Acesso.: " + tentativasAcesso; 
                }
            }
            else
            {
                this.Opacity = 0.0f;
                this.ShowInTaskbar = false;


                FormTelaInicial formTelaInicial = new FormTelaInicial(usuario);
                formTelaInicial.Show();
            }
        }       
    }
}
