using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;  // Não esquecer de adicionar a referência no projeto.


namespace Database
{
    public class Conexao //Conexão padrão
    {
        protected MySqlConnection conexao = new MySqlConnection("Server=localhost;Port=3306;Database=db_oficinatcc;Uid=root;Pwd=gabriel10;");
        protected MySqlCommand cmd;
        private bool resultado;

        public bool ComandoSQL(string sql)
        {
            resultado = false;
            try
            {
                conexao.Open();
                cmd = new MySqlCommand(sql, conexao);
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
            return resultado;
        }

        public DataSet Retorna(string sql) //Representa um cache de dados na mémoria
        {
            try
            {
                conexao.Open();
                cmd = new MySqlCommand(sql, conexao);
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
