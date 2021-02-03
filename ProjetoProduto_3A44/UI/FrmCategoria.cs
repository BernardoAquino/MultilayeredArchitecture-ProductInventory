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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            CarregarGridCategoria();
        }

        CategoriaBLL objCategoriaBLL = new CategoriaBLL();
        CategoriaDTO objCategoriaDTO = new CategoriaDTO();

        private void CarregarGridCategoria()
        {
            gridCategoria.DataSource = objCategoriaBLL.ListarCategorias();
        }

        private void Limpar()
        {
            txt_id.Clear();
            txt_descricao.Clear();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            try
            {
                objCategoriaDTO.Descricao = txt_descricao.Text;

                if (txt_id.Text == "")
                {
                    objCategoriaBLL.InserirCategoria(objCategoriaDTO);
                    MessageBox.Show("Categoria Cadastrada");
                }
                else //Se o ID estiver preenchido
                {
                    objCategoriaDTO.ID = int.Parse(txt_id.Text);
                    objCategoriaBLL.AlterarCategoria(objCategoriaDTO);
                    MessageBox.Show("Dados da categoria atualizados com sucesso.");
                }

                CarregarGridCategoria();
                Limpar();
            }
            catch(Exception ex)
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
                    objCategoriaDTO.ID = int.Parse(txt_id.Text);
                    objCategoriaBLL.ExcluirCategoria(objCategoriaDTO);
                    MessageBox.Show("A categoria foi excluida com sucesso.");
                }
                else
                {
                    MessageBox.Show("Selecione primeiro a categoria à ser excluido.");
                }
                Limpar();
                CarregarGridCategoria();
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

        private void gridCategoria_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = gridCategoria.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_descricao.Text = gridCategoria.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
