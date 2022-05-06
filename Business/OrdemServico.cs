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
            return data.    
        }

        public bool Atualizar()
        {
            con = new Conexao();
            string sql = "UPDATE OrdemServicos SET " +
                "nomeOrdemServico='" + Nome + "', cpfOrdemServico='" + Cpf + "', emailOrdemServico='" + Email + "', cepOrdemServico='" + Cep + "', dtNascOrdemServico='" + Dtnascimento + "', sexoOrdemServico='" + Sexo + "', telefoneOrdemServico='" + Telefone + "', cidadeOrdemServico='" + Cidade + "', cnhOrdemServico='" + Cnh + "' WHERE idOrdemServico=" + Id;
            return con.ComandoSQL(sql);
        }

        public bool Excluir()
        {
            con = new Conexao();
            string sql = "DELETE from OrdemServicos WHERE idOrdemServico=" + Id;
            return con.ComandoSQL(sql);
        }

        public void Pesquisar()
        {
            con = new Conexao();
            string sql = "SELECT * FROM OrdemServicos WHERE idOrdemServico=" + Id;
            DataSet ds;
            ds = con.Retorna(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;
                Id = Convert.ToInt32(dados.GetValue(0));
                Nome = Convert.ToString(dados.GetValue(1));
                Cpf = Convert.ToString(dados.GetValue(2));
                Email = Convert.ToString(dados.GetValue(3));
                Cep = Convert.ToString(dados.GetValue(4));
                Rua = Convert.ToString(dados.GetValue(5));
                Dtnascimento = Convert.ToString(dados.GetValue(6));
                Sexo = Convert.ToString(dados.GetValue(7));
                Telefone = Convert.ToString(dados.GetValue(8));
                Cidade = Convert.ToString(dados.GetValue(9));
                Cnh = Convert.ToString(dados.GetValue(10));
            }
            else
            {
                Id = 0;
            }
        }
    }
}
