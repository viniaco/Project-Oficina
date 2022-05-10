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
        private int idOrdem, idCliente, aprovada;
        private string cadastradoPor, nomeOS, data;
        private double valor;

        public int IdOrdem { get; set; }
        public int IdCliente { get; set; }
        public int Aprovada { get; set; }
        public string CadastradoPor { get; set; }
        public string NomeOS { get; set; }
        public string Data { get; set; }
        public double Valor { get; set; }

        Conexao con;

        public bool Cadastrar()
        {
            con = new Conexao();
            string sql = "INSERT INTO tbOrdemServico (idCliente, cadastradoPor, aprovada, nomeOS, valor, dataDia) values " +
                "('" + IdCliente + "', '" + CadastradoPor + "', '" + Aprovada + "', '" + NomeOS + "', '" + Valor + "', '" + Data + "')";
            return con.ComandoSQL(sql);
        }

        public bool Atualizar()
        {
            con = new Conexao();
            string sql = "UPDATE tbordemservico SET " +
                "idCliente='" + IdCliente + "', cadastradoPor='" + CadastradoPor + "', aprovada='" + Aprovada + "', nomeOS='" + NomeOS + "', valor='" + Valor + "', dataDia='" + Data;
            return con.ComandoSQL(sql);
        }

        public bool Excluir()
        {
            con = new Conexao();
            string sql = "DELETE from OrdemServicos WHERE idOrdemServico=" + idOrdem;
            return con.ComandoSQL(sql);
        }

        public void Pesquisar()
        {
            con = new Conexao();
            string sql = "SELECT * FROM OrdemServicos WHERE idOrdemServico=" + idOrdem;
            DataSet ds;
            ds = con.Retorna(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;
                IdOrdem = Convert.ToInt32(dados.GetValue(0));
                IdCliente = Convert.ToInt32(dados.GetValue(1));
                CadastradoPor = Convert.ToString(dados.GetValue(2));
                Aprovada = Convert.ToInt32(dados.GetValue(3));
                NomeOS = Convert.ToString(dados.GetValue(4));
                Valor = Convert.ToDouble(dados.GetValue(5));
                Data = Convert.ToString(dados.GetValue(6));
            }
            else
            {
                idOrdem = 0;
            }
        }
    }
}
