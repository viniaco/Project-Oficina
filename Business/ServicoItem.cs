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
    public class ServicoItemItem
    {
        private int idServicoItem, idServico, checkin, checkout, finalizado;
        private string usuarioAlocado;
        private double valor;
        private DateTime prazo, dataCheckin, dataCheckout, dataFinalizacao;


        Conexao con;

        public int IdServicoItem { get; set; }
        public int IdServico { get; set; }
        public int Checkin { get; set; }
        public int Checkout { get; set; }
        public int Finalizado { get; set; }
        public string UsuarioAlocado { get; set; }
        public double Valor { get; set; }
        public DateTime Prazo { get; set; }
        public DateTime DataCheckin { get; set; }
        public DateTime DataCheckout { get; set; }
        public DateTime DataFinalizacao { get; set; }

        public bool Cadastrar()
        {
            con = new Conexao();
            string sql = "INSERT INTO tbServicoItem (idServico, valor, prazo, checkin, dataCheckin, UsuarioAlocado,Checkout,dataCheckout,DataFinalizacao,finalizado) values " +
                "('"
                + IdServico + "', '"
                + Valor + "', '"
                + Prazo + "', '"
                + Checkin + "', '"
                + DataCheckin + "', '"
                + UsuarioAlocado + "', '"
                + Checkout + "', '"
                + DataCheckout + "', '"
                + DataFinalizacao + "', '"
                + Finalizado + "')";

            return con.ComandoSQL(sql);
        }

        public bool Atualizar()
        {
            con = new Conexao();
            string sql = "UPDATE tbServicoItem SET " +
                "idServico='" + IdServico +
                "', valor='" + Valor +
                "', prazo='" + Prazo +
                "', checkin='" + Checkin +
                "', dataCheckin='" + DataCheckin +
                "', UsuarioAlocado='" + UsuarioAlocado +
                "', Checkout='" + Checkout +
                "', dataCheckout='" + DataCheckout +
                "', DataFinalizacao='" + DataFinalizacao +
                 "', finalizado='" + Finalizado +
                "' WHERE idServicoItem=" + IdServicoItem;
            return con.ComandoSQL(sql);
        }

        public bool Excluir()
        {
            con = new Conexao();
            string sql = "DELETE from tbServicoItem WHERE idServicoItem=" + IdServicoItem;
            return con.ComandoSQL(sql);
        }

        public void Pesquisar()
        {
            con = new Conexao();
            string sql = "SELECT * FROM tbServicoItem WHERE idServicoItem=" + IdServicoItem;
            DataSet ds;
            ds = con.Retorna(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;
                IdServicoItem = Convert.ToInt32(dados.GetValue(0));
                IdServico = Convert.ToInt32(dados.GetValue(1));
                Valor = Convert.ToDouble(dados.GetValue(2));
                Prazo = Convert.ToDateTime(dados.GetValue(3));
                Checkin = Convert.ToInt32(dados.GetValue(4));
                DataCheckin = Convert.ToDateTime(dados.GetValue(5));
                UsuarioAlocado = Convert.ToString(dados.GetValue(6));
                Checkout = Convert.ToInt32(dados.GetValue(8));
                DataCheckout = Convert.ToDateTime(dados.GetValue(9));
                DataFinalizacao = Convert.ToDateTime(dados.GetValue(10));
                Finalizado = Convert.ToInt32(dados.GetValue(11));
            }
            else
            {
                IdServicoItem = 0;
            }
        }
    }
}
