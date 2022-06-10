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
    public class Cliente
    {
        private int idCliente, tipocliente;
        private string nome, cep, cnh, cpf, sexo, telefone, cidade, email, endereco, bairro, estado, dtnascimento;

        public int IdCliente { get; set; }
        public int Tipocliente { get; set; }
        public string Nome { get; set; }
        public string Cep { get; set; }
        public string Cnh { get; set; }
        public string Cpf { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public string Cidade { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }
        public string Dtnascimento { get; set; }



        Conexao con;

        public bool Cadastrar()
        {
            con = new Conexao();
            string sql = "INSERT INTO tbCliente (nome, cpf, telefone, email, endereco, cep, bairro, cidade, estado, cnh, tipocliente) values " +
                "('" + Nome + "', '" +
                Cpf + "', '" +
                Telefone + "', '" +
                Email + "', '" +
                Endereco + "', '" +
                Cep + "', '" +
                Bairro + "', '" +
                Cidade + "', '" +
                Estado + "', '" +
                Cnh + "', '" +
                Tipocliente + ")";

            return con.ComandoSQL(sql);
        }

        public bool Atualizar()
        {
            con = new Conexao();
            string sql = "UPDATE clientes SET " +
                "nomeCliente='" + Nome +
                "', cpfCliente='" + Cpf +
                "', emailCliente='" + Email +
                "', cepCliente='" + Cep +
                "', dtNascCliente='" + Dtnascimento +
                "', sexoCliente='" + Sexo +
                "', telefoneCliente='" + Telefone +
                "', cidadeCliente='" + Cidade +
                "', cnhCliente='" + Cnh +
                "' WHERE idCliente=" + IdCliente;
            return con.ComandoSQL(sql);
        }

        public bool Excluir()
        {
            con = new Conexao();
            string sql = "DELETE from tbCliente WHERE idCliente=" + IdCliente;
            return con.ComandoSQL(sql);
        }

        public void Pesquisar()
        {
            con = new Conexao();
            string sql = "SELECT * FROM tbCliente WHERE idCliente=" + IdCliente;
            DataSet ds;
            ds = con.Retorna(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;
                IdCliente = Convert.ToInt32(dados.GetValue(0));
                Nome = Convert.ToString(dados.GetValue(1));
                Cpf = Convert.ToString(dados.GetValue(2));
                Telefone = Convert.ToString(dados.GetValue(3));
                Email = Convert.ToString(dados.GetValue(4));
                Endereco = Convert.ToString(dados.GetValue(5));
                Cep = Convert.ToString(dados.GetValue(6));
                Bairro = Convert.ToString(dados.GetValue(7));
                Cidade = Convert.ToString(dados.GetValue(8));
                Estado = Convert.ToString(dados.GetValue(9));
                Cnh = Convert.ToString(dados.GetValue(10));
                Tipocliente = Convert.ToInt32(dados.GetValue(11));
            }
            else
            {
                IdCliente = 0;
            }
        }

        public DataTable GridViewCliente()
        {
            con = new Conexao();
            string sql = "select * from tbcliente";
            return con.CarregarUsuario(sql);
        }
    }
}
