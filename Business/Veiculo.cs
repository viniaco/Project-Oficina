using Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Veiculo
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Ano { get; set; }
        public string Cor { get; set; }
        public string Cambio { get; set; }
        public string Km { get; set; }
        public string Placa { get; set; }
        public string Combustivel { get; set; }
        public string Observacao { get; set; }

        Conexao con;


        public bool Cadastrar()
        {
            con = new Conexao();
            string sql = "INSERT INTO tbveiculo (`nome`,`ano`,`cor`,`cambio`,`km`,`placa`,`combustivel`,`observacao`,`idCliente`) values " +
                "('" + Nome + "', '" +
                Ano + "', '" +
                Cor + "', '" +
                Cambio + "', '" +
                Km + "', '" +
                Placa + "', '" +
                Combustivel + "', '" +
                Observacao + "', '" +
                IdCliente + "');";

            return con.ComandoSQL(sql);
        }

        public bool Atualizar()
        {
            con = new Conexao();
            string sql = "UPDATE tbveiculo SET " +
                "nome='" + Nome +
                "', ano='" + Ano +
                "', cor='" + Cor +
                "', cambio='" + Cambio +
                "', km='" + Km +
                "', placa='" + Placa +
                "', combustivel='" + Combustivel +
                "', observacao='" + Observacao +
                "' WHERE idVeiculo=" + Id; ;
            return con.ComandoSQL(sql);
        }

        public bool Excluir()
        {
            con = new Conexao();
            string sql = "DELETE from tbveiculo WHERE idVeiculo=" + Id;
            return con.ComandoSQL(sql);
        }

        public void Pesquisar()
        {
            con = new Conexao();
            string sql = "SELECT * FROM tbveiculo WHERE idVeiculo=" + Id;
            DataSet ds;
            ds = con.Retorna(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;
                Id = Convert.ToInt32(dados.GetValue(0));
                Nome = Convert.ToString(dados.GetValue(1));
                Ano = Convert.ToString(dados.GetValue(2));
                Cor = Convert.ToString(dados.GetValue(3));
                Cambio = Convert.ToString(dados.GetValue(4));
                Km = Convert.ToString(dados.GetValue(5));
                Placa = Convert.ToString(dados.GetValue(6));
                Combustivel = Convert.ToString(dados.GetValue(7));
                Observacao = Convert.ToString(dados.GetValue(8));
                IdCliente = Convert.ToInt32(dados.GetValue(9));
            }
            else
            {
                Id = 0;
            }
        }

        public DataTable GridViewVeiculo()
        {
            con = new Conexao();
            string sql = "select * from tbveiculo";
            return con.CarregarGridView(sql);
        }
    }
}
