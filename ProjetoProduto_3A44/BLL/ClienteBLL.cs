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
    class ClienteBLL
    {
        Conexao objConexao = new Conexao();
        private string tabela = "tbl_cliente";

        public void InserirCliente(ClienteDTO objDTO)
        {
            string sql = String.Format($@"INSERT INTO {tabela} VALUES(null,     '{objDTO.Nome}', 
                                                                                '{objDTO.Endereco}', 
                                                                                '{objDTO.UF}', 
                                                                                '{objDTO.Telefone}', 
                                                                                '{objDTO.Email}', 
                                                                                '{objDTO.Senha}', 
                                                                                '{objDTO.TipoUsuario}');");
            objConexao.ExecutarComando(sql);
        }
        public DataTable ListarClientes()
        {
            return objConexao.ExecutarConsulta($"SELECT * FROM {tabela} ORDER BY nome;");
        }

        public DataTable ListarClientes(string sql)
        {
            return objConexao.ExecutarConsulta(sql);
        }

        public DataTable ListarClientes(string campo, string valor)
        {
            return objConexao.ExecutarConsulta($"SELECT * FROM {tabela} WHERE {campo} LIKE '%{valor}%' ORDER BY {campo};");
        }

        public void AlterarCliente(ClienteDTO objDTO)
        {
            string sql = String.Format($@"UPDATE {tabela} SET nome = '{objDTO.Nome}', 
                                                                       endereco = '{objDTO.Endereco}',
                                                                       uf = '{objDTO.UF}',
                                                                       telefone = '{objDTO.Telefone}',
                                                                       email = '{objDTO.Email}',
                                                                       senha = '{objDTO.Senha}',
                                                                       tipoUsuario = '{objDTO.TipoUsuario}'
                                                                       WHERE id = '{objDTO.ID}';");
            objConexao.ExecutarComando(sql);
        }

        public void ExcluirCliente(ClienteDTO objDTO)
        {
            string sql = $"DELETE FROM {tabela} WHERE id = '{objDTO.ID}';";
            objConexao.ExecutarComando(sql);
        }

        public bool ValidarLogin(string user, string password)
        {
            string query = $"SELECT * FROM {tabela} WHERE email = '{user}' AND senha = '{password}';";

            DataTable resultado = new DataTable();

            resultado = objConexao.ExecutarConsulta(query);

            bool existe = resultado.Rows.Count == 1 ? true : false;

            return existe;
        }

        public bool ValidarLogin(string email)
        {
            string query = $"SELECT * FROM {tabela} WHERE email = '{email}';";

            DataTable resultado = new DataTable();

            resultado = objConexao.ExecutarConsulta(query);

            bool existe = resultado.Rows.Count == 1 ? true : false;

            return existe;
        }

        public int ValidarAcesso(string user, string password)
        {
            string query = $"SELECT * FROM {tabela} WHERE email = '{user}' AND senha = '{password}';";

            DataTable resultado = new DataTable();

            resultado = objConexao.ExecutarConsulta(query);

            int tipoUsuario = (resultado.Rows.Count == 1) ? Convert.ToInt32(resultado.Rows[0]["TipoUsuario"]) : -1;

            return tipoUsuario;
        }
    }
}
