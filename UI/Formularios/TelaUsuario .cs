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

        Usuario cadastro;



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            cadastro = new Usuario();

            cadastro.Nome = txtNome.Text;
            cadastro.User = txtUsuario.Text;
            cadastro.Nome = txtNome.Text;
            cadastro.Senha = txtSenha.Text;
            cadastro.RepitaSenha = txtRepitaSenha.Text;
            cadastro.NivelAcesso = cbNivelAcesso.Text;
            cadastro.CadastradoPor = txtCadastradoPor.Text;

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
            cadastro = new Usuario();
            cadastro.IdUsuario = Convert.ToInt32(txtIdUser.Text);
            cadastro.Nome = txtNome.Text;
            cadastro.User = txtUsuario.Text;
            cadastro.Nome = txtNome.Text;
            cadastro.Senha = txtSenha.Text;
            cadastro.RepitaSenha = txtRepitaSenha.Text;
            cadastro.NivelAcesso = cbNivelAcesso.Text;
            cadastro.CadastradoPor = txtCadastradoPor.Text;


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
        private void LimparCampo()
        {
            txtIdUser.Clear();
            txtUsuario.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            txtRepitaSenha.Clear();
            cbNivelAcesso.SelectedIndex = -1;
            txtCadastradoPor.Clear();
        }
        private void dataGridViewUsuario_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LimparCampo();
            txtIdUser.Text = dataGridViewUsuario.CurrentRow.Cells[0].Value.ToString();
            txtUsuario.Text = dataGridViewUsuario.CurrentRow.Cells[1].Value.ToString();
            txtNome.Text = dataGridViewUsuario.CurrentRow.Cells[2].Value.ToString();
            txtSenha.Text = dataGridViewUsuario.CurrentRow.Cells[3].Value.ToString();
            txtRepitaSenha.Text = dataGridViewUsuario.CurrentRow.Cells[4].Value.ToString();
            cbNivelAcesso.Text = dataGridViewUsuario.CurrentRow.Cells[5].Value.ToString();
            txtCadastradoPor.Text = dataGridViewUsuario.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnAtt_Click_1(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            cadastro = new Usuario();
            cadastro.IdUsuario = int.Parse(txtIdUser.Text);
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
