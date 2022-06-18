using Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Business
{
    public class DiarioOS
    {
        Conexao con;

        public int IdDiario { get; set; }
        public int IdOrdemDiario { get; set; }
        public string Assunto { get; set; }
        public string Ocorrencia { get; set; }
        public string DataOcorrencia { get; set; }



        public bool Cadastrar()
        {
            con = new Conexao();
            string sql = "INSERT INTO tbdiario(`assunto`,`ocorrencia`,`dataocorrencia`,`idOrdemDiario`)values " +
                "('"
                + Assunto + "', '"
                + Ocorrencia + "', '"
                + DataOcorrencia + "', '"
                + IdOrdemDiario + "')";

            return con.ComandoSQL(sql);
        }

        public bool Atualizar()
        {
            con = new Conexao();
            string sql = "UPDATE tbdiario SET " +
                "idDiario='" + IdDiario +
                "', assunto='" + Assunto +
                 "', dataOcorrencia='" + DataOcorrencia +
                "', ocorrencia='" + Ocorrencia +
                "' WHERE idDiario=" + IdDiario;
            return con.ComandoSQL(sql);
        }

        public bool Excluir()
        {
            con = new Conexao();
            string sql = "DELETE from tbDiario WHERE idDiario=" + IdDiario;
            return con.ComandoSQL(sql);
        }

        public void Pesquisar()
        {
            con = new Conexao();
            string sql = "SELECT * FROM tbDiario WHERE idDiario=" + IdDiario;
            DataSet ds;
            ds = con.Retorna(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;
                IdDiario = Convert.ToInt32(dados.GetValue(0));
                Assunto = Convert.ToString(dados.GetValue(1));
                Ocorrencia = Convert.ToString(dados.GetValue(2));
                DataOcorrencia = Convert.ToString(dados.GetValue(3));
                IdOrdemDiario = Convert.ToInt32(dados.GetValue(4));
            }
            else
            {
                IdDiario = 0;
            }
        }
        public DataTable GridViewDiario()
        {
            con = new Conexao();
            string sql = "select * from tbdiario";
            return con.CarregarGridView(sql);
        }
    }
}
