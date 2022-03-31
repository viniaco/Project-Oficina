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
    public partial class TelaCliente : Form
    {
        public TelaCliente()
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
            cadastro.Cpf = mtbCPF.Text;
            cadastro.Email = txtEmail.Text;
            cadastro.Sexo = cbSexo.Text;
            cadastro.Dtnascimento = DateTime.Parse(mtbDataNasc.Text).ToString("yyyy-MM-dd");
            cadastro.Cnh = txtCNH.Text;
            cadastro.Cep = mtbCEP.Text;
            cadastro.Rua = txtRua.Text;
            cadastro.Cidade = txtCidade.Text;
            cadastro.Telefone = mtbTelefone.Text;

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
            cadastro.Id = int.Parse(txtId.Text);
            cadastro.Nome = txtNome.Text;
            cadastro.Cpf = mtbCPF.Text;
            cadastro.Email = txtEmail.Text;
            cadastro.Sexo = cbSexo.Text;
            cadastro.Dtnascimento = DateTime.Parse(mtbDataNasc.Text).ToString("yyyy-MM-dd");
            cadastro.Cnh = txtCNH.Text;
            cadastro.Cep = mtbCEP.Text;
            cadastro.Rua = txtRua.Text;
            cadastro.Cidade = txtCidade.Text;
            cadastro.Telefone = mtbTelefone.Text;

            if (cadastro.Atualizar())
            {
                MessageBox.Show("Cliente: " + txtNome.Text + " foi atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Atualização não realizada!");
            }

        }

        private void TelaCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            cadastro = new Cliente();
            cadastro.Id = int.Parse(txtId.Text);
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
            cadastro = new Cliente();
            cadastro.Id = int.Parse(txtId.Text);
            cadastro.Pesquisar();
            if (cadastro.Id == 0)
            {
                MessageBox.Show("Desculpe, cliente não encontrado!");
            }
            else
            {
                txtNome.Text = cadastro.Nome;
                mtbCPF.Text = cadastro.Cpf;
                txtEmail.Text = cadastro.Email;
                cbSexo.Text = cadastro.Sexo;
                mtbDataNasc.Text = cadastro.Dtnascimento;
                txtCNH.Text = cadastro.Cnh;
                mtbCEP.Text = cadastro.Cep;
                txtRua.Text = cadastro.Rua;
                txtCidade.Text = cadastro.Cidade;
                mtbTelefone.Text = cadastro.Telefone;
            }

        }
    }
}
