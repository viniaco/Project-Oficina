using Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Usuario
    {
        Conexao con;
        public int IdUsuario { get; set; }
        public string User { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string RepitaSenha { get; set; }
        public string NivelAcesso { get; set; }
        public string CadastradoPor { get; set; }

        public bool Cadastrar()
        {
            con = new Conexao();
            string sql = "INSERT INTO tbusuario (`usuario`, `nome`, `senha`, `repitaSenha`, `nivelAcesso`, `cadastradoPor`) values " +
                "('" + User + "','" + Nome + "','" + Senha + "','" + RepitaSenha + "','" + NivelAcesso + "','" + CadastradoPor + "');";
            return con.ComandoSQL(sql);

        }

        public bool Atualizar()
        {
            con = new Conexao();
            string sql = "UPDATE tbusuario SET " +
                "usuario='" + User + "', nome='" + Nome + "', senha='" + Senha + "', repitaSenha='" + RepitaSenha + "', nivelAcesso='" + NivelAcesso + "', cadastradoPor='" + CadastradoPor + "' WHERE idUsuario=" + IdUsuario;
            return con.ComandoSQL(sql);
        }

        public bool Excluir()
        {
            con = new Conexao();
            string sql = "DELETE from tbusuario WHERE idUsuario=" + IdUsuario;
            return con.ComandoSQL(sql);
        }

        public void Pesquisar()
        {
            con = new Conexao();
            string sql = "SELECT * FROM tbusuario WHERE idUsuario=" + IdUsuario;
            DataSet ds;
            ds = con.Retorna(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;
                IdUsuario = Convert.ToInt32(dados.GetValue(0));
                User = Convert.ToString(dados.GetValue(1));
                Nome = Convert.ToString(dados.GetValue(2));
                Senha = Convert.ToString(dados.GetValue(3));
                RepitaSenha = Convert.ToString(dados.GetValue(4));
                NivelAcesso = Convert.ToString(dados.GetValue(5));
                CadastradoPor = Convert.ToString(dados.GetValue(6));
            }
            else
            {
                IdUsuario = 0;
            }
        }

        public DataTable GridViewUsuario()
        {
            con = new Conexao();
            string sql = "select * from tbusuario";
            return con.CarregarUsuario(sql);
        }
    }
}
