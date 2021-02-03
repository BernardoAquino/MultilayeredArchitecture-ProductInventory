using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace ProjetoProduto_3A44
{
    public partial class FrmTipoUsuario : Form
    {
        public FrmTipoUsuario()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            txt_id.Clear();
            txt_descricao.Clear();
        }

        private void FrmTipoUsuario_Load(object sender, EventArgs e)
        {
            CarregarGridTipoUsuario();
        }

        TipoUsuarioBLL objTipoUsuarioBLL = new TipoUsuarioBLL();
        TipoUsuarioDTO objTipoUsuarioDTO = new TipoUsuarioDTO();

        private void CarregarGridTipoUsuario()
        {
            gridFornecedor.DataSource = objTipoUsuarioBLL.ListarTipoUsuario();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            try
            {
                objTipoUsuarioDTO.Descricao = txt_descricao.Text;

                if (txt_id.Text == "")
                {
                    objTipoUsuarioBLL.InserirTipoUsuario(objTipoUsuarioDTO);
                    MessageBox.Show("Tipo de usuário Cadastrada");
                }
                else //Se o ID estiver preenchido
                {
                    objTipoUsuarioDTO.ID = int.Parse(txt_id.Text);
                    objTipoUsuarioBLL.AlterarTipoUsuario(objTipoUsuarioDTO);
                    MessageBox.Show("Dados do tipo de usuário atualizados com sucesso.");
                }

                CarregarGridTipoUsuario();
                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO.\n" + ex.Message);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_id.Text != "")
                {
                    objTipoUsuarioDTO.ID = int.Parse(txt_id.Text);
                    objTipoUsuarioBLL.ExcluirTipoUsuario(objTipoUsuarioDTO);
                    MessageBox.Show("O tipo de usuário foi excluido com sucesso.");
                }
                else
                {
                    MessageBox.Show("Selecione primeiro o tipo de usuario a ser excluido.");
                }
                Limpar();
                CarregarGridTipoUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO. \n" + ex.Message);
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void gridFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = gridFornecedor.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_descricao.Text = gridFornecedor.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
