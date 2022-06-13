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
        public int IdServico { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Observacao { get; set; }
        public string DataDia { get; set; }
        public string CadastradoPor { get; set; }
        public double Valor { get; set; }

        Conexao con;

        public bool Cadastrar()
        {
            con = new Conexao();
            string sql = "INSERT INTO tbservico (`nome`,`descricao`,`observacao`,`valor`,`datadia`,`cadastradoPor`) values " +
                "('" + Nome + "', '" + Descricao + "', '" + Observacao + "', '" + Valor + "', '" + DataDia + "', '" + CadastradoPor + "');";

            return con.ComandoSQL(sql);
        }

        public bool Atualizar()
        {
            con = new Conexao();
            string sql = "UPDATE tbservico SET " +
                "nome='" + Nome + "', descricao='" + Descricao + "', observacao='" + Observacao + "', valor='" + Valor + "', datadia='" + DataDia + "', cadastradoPor='" + CadastradoPor +
                "' WHERE idServico=" + IdServico;
            return con.ComandoSQL(sql);
        }

        public bool Excluir()
        {
            con = new Conexao();
            string sql = "DELETE from tbservico WHERE idServico=" + IdServico;
            return con.ComandoSQL(sql);
        }

        public void Pesquisar()
        {
            con = new Conexao();
            string sql = "SELECT * FROM tbservico WHERE idServico=" + IdServico;
            DataSet ds;
            ds = con.Retorna(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;
                IdServico = Convert.ToInt32(dados.GetValue(0));
                Nome = Convert.ToString(dados.GetValue(1));
                Descricao = Convert.ToString(dados.GetValue(2));
                Observacao = Convert.ToString(dados.GetValue(3));
                Valor = Convert.ToDouble(dados.GetValue(4));
                DataDia = Convert.ToString(dados.GetValue(5));
                CadastradoPor = Convert.ToString(dados.GetValue(6));
            }
            else
            {
                IdServico = 0;
            }
        }

        public DataTable GridViewServico()
        {
            con = new Conexao();
            string sql = "select * from tbservico";
            return con.CarregarGridView(sql);
        }
    }
}
