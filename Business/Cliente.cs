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
        private int id;
        private string nome, cep, cnh, cpf, sexo, telefone, cidade, email, rua, dtnascimento;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Cnh { get => cnh; set => cnh = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Email { get => email; set => email = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Dtnascimento { get => dtnascimento; set => dtnascimento = value; }

        Conexao con;

        public bool Cadastrar()
        {
            con = new Conexao();
            string sql = "INSERT INTO clientes (nomeCliente, cpfCliente, emailCliente, cepCliente, ruaCliente, dtNascCliente, sexoCliente, telefoneCliente, cidadeCliente, cnhCliente, Oficina_idOficina) values " +
                "('" + Nome + "', '" + Cpf + "', '" + Email + "', '" + Cep + "', '" + Rua + "', '" + Dtnascimento + "', '" + Sexo + "', '" + Telefone + "', '" + Cidade + "', '" + Cnh + "', '1')";
            return con.ComandoSQL(sql);
        }

        public bool Atualizar()
        {
            con = new Conexao();
            string sql = "UPDATE clientes SET " +
                "nomeCliente='" + Nome + "', cpfCliente='" + Cpf + "', emailCliente='" + Email + "', cepCliente='" + Cep + "', dtNascCliente='" + Dtnascimento + "', sexoCliente='" + Sexo + "', telefoneCliente='" + Telefone + "', cidadeCliente='" + Cidade + "', cnhCliente='" + Cnh + "' WHERE idCliente=" + Id;
            return con.ComandoSQL(sql);
        }

        public bool Excluir()
        {
            con = new Conexao();
            string sql = "DELETE from clientes WHERE idCliente=" + Id;
            return con.ComandoSQL(sql);
        }

        public void Pesquisar()
        {
            con = new Conexao();
            string sql = "SELECT * FROM clientes WHERE idCliente=" + Id;
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
