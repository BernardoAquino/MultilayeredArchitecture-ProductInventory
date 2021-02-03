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
    class FornecedorBLL
    {
        Conexao objConexao = new Conexao();
        private string tabela = "tbl_fornecedor";

        public void InserirFornecedor(FornecedorDTO objDTO) //Recebe objeto já existente
        {
            string sql = String.Format($@"INSERT INTO {tabela} VALUES(null,     '{objDTO.Nome}', 
                                                                                '{objDTO.Email}', 
                                                                                '{objDTO.Telefone}');");
            objConexao.ExecutarComando(sql);
        }

        public DataTable ListarFornecedores()
        {
            DataTable query = new DataTable();
            string sql = $"SELECT * FROM {tabela} ORDER BY nome;";
            query = objConexao.ExecutarConsulta(sql);

            return query;

            //Ou apenas isso
            //return objConnexao.ExecutarConsulta($"SELECT * FROM {tabela} ORDER BY nome;");
        }

        public void AlterarFornecedor(FornecedorDTO objDTO)
        {
            string sql = String.Format($@"UPDATE {tabela} SET nome = '{objDTO.Nome}', 
                                                              email = '{objDTO.Email}',
                                                              telefone = '{objDTO.Telefone}'
                                                              WHERE id = '{objDTO.ID}';");
            objConexao.ExecutarComando(sql);
        }

        public void ExcluirFornecedor(FornecedorDTO objDTO)
        {
            string sql = $"DELETE FROM {tabela} WHERE id = {objDTO.ID}";
            objConexao.ExecutarComando(sql);
        }
    }
}
