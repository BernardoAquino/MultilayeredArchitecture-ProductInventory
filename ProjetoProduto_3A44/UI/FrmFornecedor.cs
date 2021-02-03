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
    public partial class FrmFornecedor : Form
    {
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            CarregarGridFornecedor();
        }

        FornecedorBLL objFornecedorBLL = new FornecedorBLL();
        FornecedorDTO objFornecedorDTO = new FornecedorDTO();

        //Queremos preencher o DataGridView com os dados obtidos do select (BLL)

        private void CarregarGridFornecedor()
        {
            gridFornecedor.DataSource = objFornecedorBLL.ListarFornecedores();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_id.Text == "")
                {
                    objFornecedorDTO.Nome = txt_nome.Text;
                    objFornecedorDTO.Email = txt_email.Text;
                    objFornecedorDTO.Telefone = txt_telefone.Text;

                    objFornecedorBLL.InserirFornecedor(objFornecedorDTO);
                    MessageBox.Show("Fornecedor cadastrado.");
                    CarregarGridFornecedor();
                    LimparComponentes();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERRO." + ex.Message);
            }
        }

        private void LimparComponentes()
        {
            txt_id.Clear();
            txt_nome.Clear();
            txt_email.Clear();
            txt_telefone.Clear();
        }

        private void gridFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = gridFornecedor.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nome.Text = gridFornecedor.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_email.Text = gridFornecedor.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_telefone.Text = gridFornecedor.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if(txt_id.Text != "")
            {
                objFornecedorDTO.ID = int.Parse(txt_id.Text);
                objFornecedorBLL.ExcluirFornecedor(objFornecedorDTO);
                MessageBox.Show("O fornecedor foi excluido");
                CarregarGridFornecedor();
                LimparComponentes();
            }else
            {
                MessageBox.Show("Selecione um fornecedor para excluir.");
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_id.Text != "") //Existe um ID selecionado ?
                {
                    objFornecedorDTO.ID = int.Parse(txt_id.Text);
                    objFornecedorDTO.Nome = txt_nome.Text;
                    objFornecedorDTO.Email = txt_email.Text;
                    objFornecedorDTO.Telefone = txt_telefone.Text;

                    objFornecedorBLL.AlterarFornecedor(objFornecedorDTO);
                    MessageBox.Show("Os dados do FORNECEDOR selecionado foram alterados com sucesso.");
                    CarregarGridFornecedor();
                    LimparComponentes();
                }
                else
                {
                    MessageBox.Show("Selecione um fornecedor para atualizar os dados.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERRO!\n" + ex.Message);
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            LimparComponentes();
        }
    }
}
