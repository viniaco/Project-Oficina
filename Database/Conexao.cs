using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Database
{
    public class Conexao : IDisposable
    {
        public SqlConnection conn;
        private readonly string host = "127.0.0.1";
        private readonly string port = "3306";
        private readonly string db = "tcc";
        private readonly string user = "root";
        private readonly string pass = "123123123";

        public Conexao()
        {
            Conectar();
        }

        private void Conectar()
        {
            string StrConn = "Server=" + host + "; Port=" + port + "; Database=" + db + "; Uid=" + user + "; Pwd=" + pass + ";";
            conn = new SqlConnection(StrConn);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Dispose()
        {
            conn.Close();
            conn.Dispose();
        }
    }
    //public class Conexao //Conexão padrão
    //{
    //    protected MySqlConnection conexao = new MySqlConnection("Server=localhost;Port=3306;Database=db_oficinatcc;Uid=root;Pwd=gabriel10;");
    //    protected MySqlCommand cmd;
    //    private bool resultado;

    //    public bool ComandoSQL(string sql)
    //    {
    //        resultado = false;
    //        try
    //        {
    //            conexao.Open();
    //            cmd = new MySqlCommand(sql, conexao);
    //            cmd.ExecuteNonQuery();
    //            resultado = true;
    //        }
    //        catch (Exception ex)
    //        {
    //            throw ex;
    //        }
    //        finally
    //        {
    //            conexao.Close();
    //        }
    //        return resultado;
    //    }

    //    public DataSet Retorna(string sql) //Representa um cache de dados na mémoria
    //    {
    //        try
    //        {
    //            conexao.Open();
    //            cmd = new MySqlCommand(sql, conexao);
    //            MySqlDataAdapter da = new MySqlDataAdapter();
    //            DataSet ds = new DataSet();
    //            da.SelectCommand = cmd;
    //            da.Fill(ds);
    //            return ds;
    //        }
    //        catch (Exception ex)
    //        {
    //            throw ex;
    //        }
    //        finally
    //        {
    //            conexao.Close();
    //        }
    //    }
    //}
}
