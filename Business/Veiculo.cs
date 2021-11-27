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
        private int id;
        private string nome, ano, cor, cambio, km, placa, combustivel, observacao;


        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Ano { get => ano; set => ano = value; }
        public string Cor { get => cor; set => cor = value; }
        public string Cambio { get => cambio; set => cambio = value; }
        public string Km { get => km; set => km = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Combustivel { get => combustivel; set => combustivel = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        //public string Fkcliente { get => fkcliente; set => fkcliente = value; }

        Conexao con;


        public bool Cadastrar()
        {
            con = new Conexao();
            string sql = "INSERT INTO veiculos (nomeVeiculo, anoVeiculo, corVeiculo, cambioVeiculo, kmVeiculo, placaVeiculo, combustivelVeiculo, obsVeiculo, Cliente_idCliente) values " +
                "('" + Nome + "', '" + Ano + "', '" + Cor + "', '" + Cambio + "', '" + Km + "', '" + Placa + "', '" + Combustivel + "', '" + Observacao + "', '1')";
            return con.ComandoSQL(sql);
        }

        public bool Atualizar()
        {
            con = new Conexao();
            string sql = "UPDATE veiculos SET " +
                "nomeVeiculo='" + Nome + "', anoVeiculo='" + Ano + "', corVeiculo='" + Cor + "', cambioVeiculo='" + Cambio + "', kmVeiculo='" + Km + "', placaVeiculo='" + Placa + "', combustivelVeiculo='" + Combustivel + "', obsVeiculo='" + Observacao + "' WHERE idVeiculo=" + Id;
            return con.ComandoSQL(sql);
        }

        public bool Excluir()
        {
            con = new Conexao();
            string sql = "DELETE from Veiculos WHERE idVeiculo=" + Id;
            return con.ComandoSQL(sql);
        }

        public void Pesquisar()
        {
            con = new Conexao();
            string sql = "SELECT * FROM veiculos WHERE idVeiculo=" + Id;
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
                //Fkcliente = Convert.ToString(dados.GetValue(9));
            }
            else
            {
                Id = 0;
            }
        }
    }
}
