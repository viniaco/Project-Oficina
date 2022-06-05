using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;

namespace WF_OficinaTcc
{
    public partial class TelaLogin : Form
    {
        //Responsavel pelo Nivel de Acesso
        public static string NivelAcesso;

        //Responsavel por mostrar quem esta conectado no sistema
        public static string usuarioConectado;
        //String de Conexão
        MySqlConnection conn = new MySqlConnection();

        public TelaLogin()
        {
            InitializeComponent();
        }

        private void TelaAgendamento_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                //Verificar ser os campos estão preenchidos
                if ((usuarioTextBox.Text != "") && (nivelAcessoComboBox.Text != "") && (senhaTextBox.Text != ""))
                {
                    //Responsavel pelo Comando Sql
                    MySqlCommand comm = new MySqlCommand("Select * From `db.oficina`.tbusuario Where usuario = @usuario and " +
                        "senha = @senha and nivelAcesso=@nivel", conn);

                    //Parametizar os codigos
                    comm.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = usuarioTextBox.Text;
                    comm.Parameters.Add("@senha", MySqlDbType.VarChar).Value = senhaTextBox.Text;
                    comm.Parameters.Add("@nivel", MySqlDbType.VarChar).Value = nivelAcessoComboBox.Text;

                    //Abre a conexão
                    conn.Open();

                    MySqlDataReader reader = null;
                    //lê as linhas de uma base de dados SQL Server
                    reader = comm.ExecuteReader();

                    //Se tiver coisa pra lê faça:
                    if (reader.Read())
                    {
                        //Variaveil usuarioConectado recebe campo usuarioComboBox.Text
                        usuarioConectado = usuarioTextBox.Text;

                        //Variavei nivelAcesso recebe o campo nivelAcessoComboBox.Text
                        NivelAcesso = nivelAcessoComboBox.Text;

                        //Declara a variavel que recebe o formulario frmTelaPrinciapal
                        TelaPrincipal p = new TelaPrincipal();
                        //Esconde o formulario Tela de Login
                        this.Hide();
                        //Mostrar o formulario frmTelaPrinciapl
                        p.Show();

                    }
                    else
                    {
                        MessageBox.Show("Usuário e/ou senha incorretas",
                        "Aviso de Segurança",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("Todos os Campos são obrigatórios",
                   "Aviso de Segurança",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                //Gerar a exceção
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Finalizar tarefa
                conn.Close();
            }
        }
    }
}
