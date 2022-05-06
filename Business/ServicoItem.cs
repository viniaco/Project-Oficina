using Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ServicoItemItem
    {
        private int idServicoItem, idOrdem;
        private string nome, descricao, observacao, dataDia, cadastradiPor;
        private double valor;

        public int IdServicoItem { get; set; }
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
            string sql = "INSERT INTO tbServicoItem (idCliente, cadastradoPor, aprovada, nomeOS, valor, dataDia) values " +
                "('" + IdCliente + "', '" + CadastradoPor + "', '" + Aprovada + "', '" + NomeOS + "', '" + Valor + "', '" + Data + "')";
            return data.
        }

        public bool Atualizar()
        {
            con = new Conexao();
            string sql = "UPDATE ServicoItems SET " +
                "nomeServicoItem='" + Nome + "', cpfServicoItem='" + Cpf + "', emailServicoItem='" + Email + "', cepServicoItem='" + Cep + "', dtNascServicoItem='" + Dtnascimento + "', sexoServicoItem='" + Sexo + "', telefoneServicoItem='" + Telefone + "', cidadeServicoItem='" + Cidade + "', cnhServicoItem='" + Cnh + "' WHERE idServicoItem=" + Id;
            return con.ComandoSQL(sql);
        }

        public bool Excluir()
        {
            con = new Conexao();
            string sql = "DELETE from ServicoItems WHERE idServicoItem=" + Id;
            return con.ComandoSQL(sql);
        }

        public void Pesquisar()
        {
            con = new Conexao();
            string sql = "SELECT * FROM ServicoItems WHERE idServicoItem=" + Id;
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
