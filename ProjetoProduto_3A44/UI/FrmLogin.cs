using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace ProjetoProduto_3A44
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string emailUsuario = txtEmail.Text;
            string senhalUsuario = txtSenha.Text;

            ClienteBLL objClienteBLL = new ClienteBLL();

            if (objClienteBLL.ValidarLogin(emailUsuario) == false)
            {
                MessageBox.Show("ATENÇÃO. Usuário não existente.");
            }
            else if (objClienteBLL.ValidarLogin(emailUsuario, senhalUsuario))
            {
                MessageBox.Show("Acesso Permitido.");
                FrmPrincipal objTela = new FrmPrincipal();
                objTela.ShowDialog();
            }
            else
            {
                MessageBox.Show("A senha está INCORRETA.");
            }
        }
    }
}
