using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    class ProdutoBLL
    {
        Conexao objConexao = new Conexao();
        private string tabela = "tbl_produto";

        public void InserirProduto(ProdutoDTO objDTO) //Recebe objeto já existente
        {
            string sql = String.Format($@"INSERT INTO {tabela} VALUES(null,     '{objDTO.Descricao}', 
                                                                                '{objDTO.Preco}', 
                                                                                '{objDTO.Quantidade}', 
                                                                                '{objDTO.Peso}', 
                                                                                '{objDTO.Categoria_ID}', 
                                                                                '{objDTO.Fornecedor_ID}');");
            objConexao.ExecutarComando(sql);
        }
        public DataTable ListarProdutos()
        {
            return objConexao.ExecutarConsulta($"SELECT * FROM {tabela} ORDER BY descricao;");
        }

        public DataTable ListarProdutos(string condicao)
        {
            return objConexao.ExecutarConsulta($"SELECT * FROM {tabela} WHERE {condicao};");
        }

        public DataTable ListarProdutos(string campo, string valor)
        {
            return objConexao.ExecutarConsulta($"SELECT * FROM {tabela} WHERE {campo} = '{valor}';");
        }

        /*public DataTable ListarProdutos(string desc)
        {
            return objConexao.ExecutarConsulta($"SELECT * FROM {tabela} WHERE descricao like '%{desc}%' ORDER BY descricao;");
        }*/

        public void AlterarProduto(ProdutoDTO objDTO)
        {
            string sql = String.Format($@"UPDATE {tabela} SET   descricao = '{objDTO.Descricao}', 
                                                                preco = '{objDTO.Preco}',
                                                                quantidade = '{objDTO.Quantidade}',
                                                                peso = '{objDTO.Peso}',
                                                                idCategoria = '{objDTO.Categoria_ID}',
                                                                idFornecedor = '{objDTO.Fornecedor_ID}'
                                                                WHERE id = '{objDTO.ID}';");
            objConexao.ExecutarComando(sql);
        }

        public void ExcluirProduto(ProdutoDTO objDTO)
        {
            string sql = $"DELETE FROM {tabela} WHERE id = '{objDTO.ID}';";
            objConexao.ExecutarComando(sql);
        }
    }
}
