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
    class CategoriaBLL
    {
        Conexao objConexao = new Conexao();
        private string tabela = "tbl_categoria";

        public void InserirCategoria(CategoriaDTO objDTO) //Recebe objeto já existente
        {
            string sql = $"INSERT INTO {tabela} VALUES(null, '{objDTO.Descricao}');";
            objConexao.ExecutarComando(sql);
        }

        public DataTable ListarCategorias()
        {
            DataTable query = new DataTable();
            string sql = $"SELECT * FROM {tabela} ORDER BY descricao;";
            query = objConexao.ExecutarConsulta(sql);

            return query;
        }

        public void AlterarCategoria(CategoriaDTO objDTO)
        {
            string sql = String.Format($@"UPDATE {tabela} SET descricao = '{objDTO.Descricao}' WHERE id = '{objDTO.ID}';");
            objConexao.ExecutarComando(sql);
        }

        public void ExcluirCategoria(CategoriaDTO objDTO)
        {
            string sql = $"DELETE FROM {tabela} WHERE id = '{objDTO.ID}';";
            objConexao.ExecutarComando(sql);
        }
    }
}
