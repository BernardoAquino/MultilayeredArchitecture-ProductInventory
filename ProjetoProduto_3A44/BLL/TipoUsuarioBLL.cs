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
    class TipoUsuarioBLL
    {
        Conexao objConexao = new Conexao();
        private string tabela = "tbl_tipousuario";

        public void InserirTipoUsuario(TipoUsuarioDTO objDTO) //Recebe objeto já existente
        {
            string sql = $"INSERT INTO {tabela} VALUES(null,  '{objDTO.Descricao}');";
            objConexao.ExecutarComando(sql);
        }
        public DataTable ListarTipoUsuario()
        {
            return objConexao.ExecutarConsulta($"SELECT * FROM {tabela} ORDER BY descricao;");
        }

        public void AlterarTipoUsuario(TipoUsuarioDTO objDTO)
        {
            string sql = String.Format($@"UPDATE {tabela} SET descricao = '{objDTO.Descricao}' WHERE id = '{objDTO.ID}';");
            objConexao.ExecutarComando(sql);
        }

        public void ExcluirTipoUsuario(TipoUsuarioDTO objDTO)
        {
            string sql = $"DELETE FROM {tabela} WHERE id = '{objDTO.ID}';";
            objConexao.ExecutarComando(sql);
        }
    }
}
