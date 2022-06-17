using Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class OrdemServico
    {
        public int IdOrdem { get; set; }
        public int Aprovada { get; set; }
        public string CadastradoPor { get; set; }
        public string NomeOS { get; set; }
        public string Data { get; set; }
        public double Valor { get; set; }
        public string Finalizada { get; set; }
        public int IdCliente { get; set; }
        public int idVeiculo { get; set; }
        public int idServico { get; set; }

        Conexao con;

        public bool Cadastrar()
        {
            con = new Conexao();
            string sql = "INSERT INTO tbordemservico(`cadastradoPor`,`aprovada`,`nomeOS`,`valor`,`dataDia`,`finalizada`,`idCliente`,`idVeiculo`,`idServico`) values " +
                "('" + CadastradoPor + "', '" + Aprovada + "', '" + NomeOS + "', '" + Valor + "', '" + Data + "','" + Finalizada + "','" + IdCliente + "','" + idVeiculo + "','" + idServico + "');";
            return con.ComandoSQL(sql);
        }

        public bool Atualizar()
        {
            con = new Conexao();
            string sql = "UPDATE tbordemservico SET " +
                "cadastradoPor='" + CadastradoPor +
                "', aprovada='" + Aprovada +
                "', nomeOS='" + NomeOS +
                "', valor='" + Valor +
                "', dataDia='" + Data +
                "', finalizada='" + Finalizada +
                "' WHERE idOrdemservico=" + IdOrdem;
            return con.ComandoSQL(sql);
        }

        public bool Excluir()
        {
            con = new Conexao();
            string sql = "DELETE from tbordemservico WHERE idOrdemservico=" + IdOrdem;
            return con.ComandoSQL(sql);
        }

        public void Pesquisar()
        {
            con = new Conexao();
            string sql = "SELECT * FROM tbordemservico WHERE idOrdemServico=" + IdOrdem;
            DataSet ds;
            ds = con.Retorna(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;
                IdOrdem = Convert.ToInt32(dados.GetValue(0));
                CadastradoPor = Convert.ToString(dados.GetValue(1));
                Aprovada = Convert.ToInt32(dados.GetValue(2));
                NomeOS = Convert.ToString(dados.GetValue(3));
                Valor = Convert.ToDouble(dados.GetValue(4));
                Data = Convert.ToString(dados.GetValue(5));
                IdCliente = Convert.ToInt32(dados.GetValue(6));
                idVeiculo = Convert.ToInt32(dados.GetValue(7));
                idServico = Convert.ToInt32(dados.GetValue(8));
            }
            else
            {
                IdOrdem = 0;
            }
        }

        public DataTable GridViewOS()
        {
            con = new Conexao();
            string sql = "select * from tbordemservico";
            return con.CarregarGridView(sql);
        }

    }
}
