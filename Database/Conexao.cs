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
        private readonly string host = "LAB04-50";
        private readonly string port = "3306";
        private readonly string db = "dbOficinaTCCSqlServer (1)";
        private readonly string user = "";
        private readonly string pass = "";

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
}
