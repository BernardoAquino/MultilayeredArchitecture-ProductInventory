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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            CarregarGridProduto();
            CarregarCategoria();
            CarregarFornecedor();
        }

        ProdutoDTO objProdutoDTO = new ProdutoDTO();
        ProdutoBLL objProdutoBLL = new ProdutoBLL();
        FornecedorBLL objFornecedorBLL = new FornecedorBLL();
        CategoriaBLL objCategoriaBLL = new CategoriaBLL();

        private void LimparComponentes()
        {
            txtIdProduto.Clear();
            txtDescricao.Clear();
            txtPreco.Clear();
            txtPeso.Clear();
            txtQuantidade.Clear();
            cbxCategoria.Text = null;
            cbxFornecedor.Text = null;
        }

        private void CarregarGridProduto()
        {
            gridProdutos.DataSource = objProdutoBLL.ListarProdutos();
        }

        private void CarregarCategoria()
        {
            cbxCategoria.DataSource = objCategoriaBLL.ListarCategorias();
            cbxCategoria.DisplayMember = "descricao";
            cbxCategoria.ValueMember = "id";
        }

        private void CarregarFornecedor()
        {
            cbxFornecedor.DataSource = objFornecedorBLL.ListarFornecedores();
            cbxFornecedor.DisplayMember = "nome";
            cbxFornecedor.ValueMember = "id";
        }

        private void gridProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdProduto.Text = gridProdutos.Rows[e.RowIndex].Cells["id"].Value.ToString();
            txtDescricao.Text = gridProdutos.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
            txtPreco.Text = gridProdutos.Rows[e.RowIndex].Cells["preco"].Value.ToString();
            txtQuantidade.Text = gridProdutos.Rows[e.RowIndex].Cells["quantidade"].Value.ToString();
            txtPeso.Text = gridProdutos.Rows[e.RowIndex].Cells["peso"].Value.ToString();
            cbxCategoria.SelectedValue = gridProdutos.Rows[e.RowIndex].Cells["idCategoria"].Value.ToString();
            cbxFornecedor.SelectedValue = gridProdutos.Rows[e.RowIndex].Cells["idFornecedor"].Value.ToString();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                objProdutoDTO.Descricao = txtDescricao.Text;
                objProdutoDTO.Preco = Double.Parse(txtPreco.Text);
                objProdutoDTO.Quantidade = int.Parse(txtQuantidade.Text);
                objProdutoDTO.Peso = Double.Parse(txtPeso.Text);
                objProdutoDTO.Categoria_ID = Convert.ToInt32(cbxCategoria.SelectedValue);
                objProdutoDTO.Fornecedor_ID = Convert.ToInt32(cbxFornecedor.SelectedValue);

                if (txtIdProduto.Text == "")
                {
                    objProdutoBLL.InserirProduto(objProdutoDTO);
                    MessageBox.Show("Produto inserido com sucesso.");
                }
                else //Se o ID estiver preenchido
                {
                    objProdutoDTO.ID = int.Parse(txtIdProduto.Text);
                    objProdutoBLL.AlterarProduto(objProdutoDTO);
                    MessageBox.Show("Dados do produto atualizados com sucesso.");
                }
                CarregarGridProduto();
                LimparComponentes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO. \n" + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtIdProduto.Text != "")
            {
                objProdutoDTO.ID = int.Parse(txtIdProduto.Text);
                objProdutoBLL.ExcluirProduto(objProdutoDTO);
                MessageBox.Show("O Produto  foi excluido.");
                CarregarGridProduto();
                LimparComponentes();
            }
            else
            {

                MessageBox.Show("Selecione um Produto para ser excluido.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparComponentes();
        }
    }
}
