using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_OficinaTcc
{
    public partial class TelaUsuario : Form
    {
        string User, nome, senha, repitaSenha, nivelAcesso, cadastradoPor;
        public TelaUsuario()
        {
            InitializeComponent();
        }

        Cliente cadastro;



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            cadastro = new Cliente();
            cadastro.Nome = txtNome.Text;

            cadastro.Email = txtSenha.Text;
            cadastro.Sexo = cbNivelAcesso.Text;



            if (cadastro.Cadastrar())
            {
                MessageBox.Show("CADASTRADO!");
            }
            else
            {
                MessageBox.Show("Cadastro não realizado!");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAtt_Click(object sender, EventArgs e)
        {
            cadastro = new Cliente();
            cadastro.IdCliente = int.Parse(txtUsuario.Text);
            cadastro.Nome = txtNome.Text;


            if (cadastro.Atualizar())
            {
                MessageBox.Show("Cliente: " + txtNome.Text + " foi atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Atualização não realizada!");
            }

        }

        private void TelaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewUsuario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Usuario user = (Usuario)dataGridViewUsuario.Rows[e.RowIndex].DataBoundItem;
            txtUsuario.Text = user.User;
            txtNome.Text = user.Nome;
            txtSenha.Text = user.Senha;
            txtRepitaSenha.Text = user.RepitaSenha;
            cbNivelAcesso.Text = user.NivelAcesso;
            txtCadastradoPor.Text = user.CadastradoPor;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            cadastro = new Cliente();
            cadastro.IdCliente = int.Parse(txtUsuario.Text);
            if (cadastro.Excluir())
            {
                MessageBox.Show("Exluido!");
            }
            else
            {
                MessageBox.Show("Exclusão não efetuada!");
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void TelaUsuario_Load_1(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            var dt = user.GridViewUsuario();
            dataGridViewUsuario.DataSource = dt;
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                //Se os campos estiver preenchido faça
                if ((txtUsuario.Text != "") && (cbNivelAcesso.Text != "") && (txtSenha.Text != "") && (txtRepitaSenha.Text != ""))
                {
                    //Se as senhas forem igual faça
                    if (txtSenha.Text == txtRepitaSenha.Text)
                    {
                        ////Mostrar a Data do Cadastro na Hora
                        //if (dataDiaTextBox.Text == "")
                        //{
                        //    dataDiaTextBox.Text = DateTime.Now.ToString();
                        //}

                        //Mostrar quem Cadastrou o usuario
                        if (txtCadastradoPor.Text == "")
                        {
                            txtCadastradoPor.Text = TelaLogin.usuarioConectado;
                        }

                        //Executar a aplicação
                        Usuario user = new Usuario();
                        user.User = txtUsuario.Text;
                        user.Nome = txtNome.Text;
                        user.Senha = txtSenha.Text;
                        user.RepitaSenha = txtRepitaSenha.Text;
                        user.NivelAcesso = cbNivelAcesso.Text;
                        user.CadastradoPor = txtCadastradoPor.Text;
                        user.Cadastrar();
                        MessageBox.Show("Usuário cadastrado!");
                        //this.Validate();
                        //this.tbUsuarioBindingSource.EndEdit();
                        //this.tbUsuarioTableAdapter.Update(this.servicoDataSet.tbUsuario);
                    }
                    else
                    {
                        //Caso as senhas são diferentes
                        MessageBox.Show("As senhas estão diferentes");
                    }
                }
                else
                {
                    //Ser os campos não estiverem preenchido
                    MessageBox.Show("Todos os campos não podem ficar vazio");
                }
            }
            catch (Exception ex)
            {
                //Caso haja uma exceção será tratada neste código
                MessageBox.Show("Não foi possível salvar pelo seguinte motivo: " + ex.Message);
            }
        }

        private void dataGridViewUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
