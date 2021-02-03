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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            CarregarClientes();
            CarregarTiposUsuario();
        }

        private void LimparDados()
        {
            txt_id.Clear();
            txt_nome.Clear();
            txt_endereco.Clear();
            txt_email.Clear();
            txt_senha.Clear();
            txt_telefone.Clear();
            cbx_uf.Text = null;
            cbx_tipo.Text = null;
            rdb_email.Checked = false;
            rdb_endereco.Checked = false;
            rdb_nome.Checked = false;
            rdb_telefone.Checked = false;
            //cbx_tipo.SelectedIndex = -1;
            //Falta o tipode usuário
        }

        ClienteBLL objClienteBLL = new ClienteBLL();
        ClienteDTO objClienteDTO = new ClienteDTO();
        TipoUsuarioBLL objTipoBLL = new TipoUsuarioBLL();

        private void CarregarClientes() //Responsável por preencher o DataGridView
        {
            gridCliente.DataSource = objClienteBLL.ListarClientes();
        }

        private void CarregarTiposUsuario() //Responsável por preencher o ComboBox de Tipos de Usuários
        {
            cbx_tipo.DataSource = objTipoBLL.ListarTipoUsuario(); //Serão retornados todos os tipos de usuários com ID e descrição
            cbx_tipo.DisplayMember = "descricao"; //Campo que será exibido no formulário
            cbx_tipo.ValueMember = "id"; //Campo que será armazenado (chave estrangeira)
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            try
            {
                objClienteDTO.Nome = txt_nome.Text;
                objClienteDTO.Endereco = txt_endereco.Text;
                objClienteDTO.Telefone = txt_telefone.Text;
                objClienteDTO.Email = txt_email.Text;
                objClienteDTO.Senha = txt_senha.Text;
                objClienteDTO.UF = cbx_uf.Text;
                //objClienteDTO.TipoUsuario = int.Parse(cbx_tipo.SelectedValue.ToString());
                objClienteDTO.TipoUsuario = Convert.ToInt32(cbx_tipo.SelectedValue);

                if (txt_id.Text == "")
                {
                    objClienteBLL.InserirCliente(objClienteDTO);
                    MessageBox.Show("Cliente inserido com sucesso.");
                }
                else //Se o ID estiver preenchido
                {
                    objClienteDTO.ID = int.Parse(txt_id.Text);
                    objClienteBLL.AlterarCliente(objClienteDTO);
                    MessageBox.Show("Dados do cliente atualizados com sucesso.");
                }
                CarregarClientes();
                LimparDados();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERRO. \n" + ex.Message);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_id.Text != "")
                {
                    objClienteDTO.ID = int.Parse(txt_id.Text);
                    objClienteBLL.ExcluirCliente(objClienteDTO);
                    MessageBox.Show("O cliente foi excluido com sucesso.");
                }else
                {
                    MessageBox.Show("Selecione primeiro o cliente a ser excluido.");
                }
                LimparDados();
                CarregarClientes();
            }catch(Exception ex)
            {
               MessageBox.Show("ERRO. \n" + ex.Message);
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void gridCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = gridCliente.Rows[e.RowIndex].Cells["id"].Value.ToString();
            txt_nome.Text = gridCliente.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txt_endereco.Text = gridCliente.Rows[e.RowIndex].Cells["endereco"].Value.ToString();
            txt_telefone.Text = gridCliente.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
            txt_email.Text = gridCliente.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txt_senha.Text = gridCliente.Rows[e.RowIndex].Cells["senha"].Value.ToString();
            cbx_uf.Text = gridCliente.Rows[e.RowIndex].Cells["uf"].Value.ToString();
            cbx_tipo.SelectedValue = gridCliente.Rows[e.RowIndex].Cells["tipoUsuario"].Value.ToString();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string variavel;

            if (rdb_nome.Checked)
                variavel = "nome";
            else if (rdb_endereco.Checked)
                variavel = "endereco";
            else if (rdb_telefone.Checked)
                variavel = "telefone";
            else if (rdb_email.Checked)
                variavel = "email";
            else
                variavel = "nome";

            gridCliente.DataSource = objClienteBLL.ListarClientes(variavel, txtPesquisa.Text);
        }
    }
}
