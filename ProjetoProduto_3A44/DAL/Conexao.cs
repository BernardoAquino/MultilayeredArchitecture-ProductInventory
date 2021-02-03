using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data; //Para utilizar objetos DataTable

namespace DAL
{
    class Conexao
    {
        MySqlConnection conexao;

        public void Conectar()
        {
            try
            {
                string conn = "Persist Security Info = false; server = localhost; database = bd_produto; uid = root; pwd = root";
                conexao = new MySqlConnection(conn);
                conexao.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Não foi possível conectar ao banco de dados.\n" + ex.Message);
            }
        }

        public DataTable ExecutarConsulta(string sql) //sql é uma string que deve conter uma instrução Select - Método capaz de executar qualquer instrução SELECT
        {
            try
            {
                Conectar();
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexao); //Executa comando que retorna
                DataTable dt = new DataTable();
                dados.Fill(dt); //Preenchimento do objeto DataTable(dt) com os dados obtidos da execução do select

                return dt;
            }catch(MySqlException ex)
            {
                throw new Exception("Não foi possível execitar a CONSULTA solicitada.\n" + ex.Message);
            }finally //Executa independente se cair  no try ou catch
            {
                conexao.Close();
            }
        }

        public void ExecutarComando(string sql) //sql deverá conter o comando a ser executado: INSERT, UPDATE, DELETE
        {
            Conectar();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao); //Executa comando que não retorna
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Não foi possível executar a instrução.\n" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
