using Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Servico
    {
        private int idServico, idOrdem;
        private string nome, descricao, observacao, dataDia, cadastradiPor;
        private double valor;

        public int IdServico { get; set; }
        public int IdOrdem { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Observacao { get; set; }
        public string DataDia { get; set; }
        public string CadastradiPor { get; set; }
        public double Valor { get; set; }

        Conexao con;

        public bool Cadastrar()
        {
            con = new Conexao();
            string sql = "INSERT INTO tbServico (idOrdem, nome, descricao, obeservacao, valor, datadia,cadastradoPor) values " +
                "('" + IdOrdem + "', '" + Nome + "', '" + Descricao + "', '" + Observacao + "', '" + Valor + "', '" + DataDia + "', '" + CadastradiPor + "')";

            return con.ComandoSQL(sql);
        }

        public bool Atualizar()
        {
            con = new Conexao();
            string sql = "UPDATE tbservico SET " +
                "idOrdem='" + IdOrdem + "', nome='" + Nome + "', descricao='" + Descricao + "', obeservacao='" + Valor + "', valor='" + DataDia + "', datadia='" + CadastradiPor;
            return con.ComandoSQL(sql);
        }

        public bool Excluir()
        {
            con = new Conexao();
            string sql = "DELETE from tbservico WHERE idServico=" + idServico;
            return con.ComandoSQL(sql);
        }

        public void Pesquisar()
        {
            con = new Conexao();
            string sql = "SELECT * FROM tbservico WHERE idServico=" + idServico;
            DataSet ds;
            ds = con.Retorna(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;
                IdServico = Convert.ToInt32(dados.GetValue(0));
                idOrdem = Convert.ToInt32(dados.GetValue(1));
                Nome = Convert.ToString(dados.GetValue(2));
                Descricao = Convert.ToString(dados.GetValue(3));
                Valor = Convert.ToDouble(dados.GetValue(4));
                DataDia = Convert.ToString(dados.GetValue(5));
                CadastradiPor = Convert.ToString(dados.GetValue(6));
            }
            else
            {
                idServico = 0;
            }
        }
    }
}
