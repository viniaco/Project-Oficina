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

        private void GridLoad()
        {
            Cliente dt = new Cliente();

            BindingSource bs = new BindingSource();

            bs.DataSource = dt.GridViewCliente();

            gdvCliente.DataSource = bs;
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            cadastro = new Cliente();
            cadastro.Nome = txtNome.Text;
            cadastro.Cpf = mtbCPF.Text;
            cadastro.Telefone = mtbTelefone.Text;
            cadastro.Email = txtEmail.Text;
            cadastro.Endereco = txtEndereco.Text;
            cadastro.Cnh = txtCNH.Text;
            cadastro.Cep = mtbCEP.Text;
            cadastro.Bairro = txtBairro.Text;
            cadastro.Cidade = txtCidade.Text;
            cadastro.Estado = cbEstado.Text;
            cadastro.Tipocliente = cbTipoCliente.Text;

            if (cadastro.Cadastrar())
            {
                MessageBox.Show("CADASTRADO!");
            }
            else
            {
                MessageBox.Show("Cadastro não realizado!");
            }

            LimparCampo();
            GridLoad();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAtt_Click(object sender, EventArgs e)
        {
            cadastro = new Cliente();
            cadastro.IdCliente = int.Parse(txtIdCliente.Text);
            cadastro.Nome = txtNome.Text;
            cadastro.Cpf = mtbCPF.Text;
            cadastro.Telefone = mtbTelefone.Text;
            cadastro.Email = txtEmail.Text;
            cadastro.Endereco = txtEndereco.Text;
            cadastro.Cnh = txtCNH.Text;
            cadastro.Cep = mtbCEP.Text;
            cadastro.Bairro = txtBairro.Text;
            cadastro.Cidade = txtCidade.Text;
            cadastro.Estado = cbEstado.Text;
            cadastro.Tipocliente = cbTipoCliente.Text;

            if (cadastro.Atualizar())
            {
                MessageBox.Show("Cliente: " + txtNome.Text + " foi atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Atualização não realizada!");
            }

            LimparCampo();
            GridLoad();

        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            cadastro = new Cliente();
            cadastro.IdCliente = int.Parse(txtIdCliente.Text);
            if (cadastro.Excluir())
            {
                MessageBox.Show("Exluido!");
            }
            else
            {
                MessageBox.Show("Exclusão não efetuada!");
            }

            LimparCampo();
            GridLoad();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            cadastro = new Cliente();
            cadastro.IdCliente = int.Parse(txtIdCliente.Text);
            cadastro.Pesquisar();
            if (cadastro.IdCliente == 0)
            {
                MessageBox.Show("Desculpe, cliente não encontrado!");
            }
            else
            {
                txtNome.Text = cadastro.Nome;
                mtbCPF.Text = cadastro.Cpf;
                txtEmail.Text = cadastro.Email;
                txtCNH.Text = cadastro.Cnh;
                mtbCEP.Text = cadastro.Cep;
                txtEndereco.Text = cadastro.Endereco;
                txtCidade.Text = cadastro.Cidade;
                mtbTelefone.Text = cadastro.Telefone;
                txtBairro.Text = cadastro.Bairro;
                cbEstado.Text = cadastro.Estado;
                cbTipoCliente.Text = cadastro.Tipocliente;

            }

        }

        private void TelaCliente_Load(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            var dt = cli.GridViewCliente();
            gdvCliente.DataSource = dt;
        }

        private void LimparCampo()
        {
            txtIdCliente.Clear();
            txtNome.Clear();
            mtbCPF.Clear();
            txtEmail.Clear();
            txtCNH.Clear();
            mtbCEP.Clear();
            txtEndereco.Clear();
            txtCidade.Clear();
            mtbTelefone.Clear();
            txtBairro.Clear();
            cbEstado.SelectedIndex = -1;
            cbTipoCliente.SelectedIndex = -1;
        }

        private void DataGridViewCliente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LimparCampo();

            txtIdCliente.Text = gdvCliente.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = gdvCliente.CurrentRow.Cells[1].Value.ToString();
            mtbCPF.Text = gdvCliente.CurrentRow.Cells[2].Value.ToString();
            mtbTelefone.Text = gdvCliente.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = gdvCliente.CurrentRow.Cells[4].Value.ToString();
            txtEndereco.Text = gdvCliente.CurrentRow.Cells[5].Value.ToString();
            mtbCEP.Text = gdvCliente.CurrentRow.Cells[6].Value.ToString();
            txtBairro.Text = gdvCliente.CurrentRow.Cells[7].Value.ToString();
            txtCidade.Text = gdvCliente.CurrentRow.Cells[8].Value.ToString();
            cbEstado.Text = gdvCliente.CurrentRow.Cells[9].Value.ToString();
            txtCNH.Text = gdvCliente.CurrentRow.Cells[10].Value.ToString();
            cbTipoCliente.Text = gdvCliente.CurrentRow.Cells[11].Value.ToString();

        }

        private void gdvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
