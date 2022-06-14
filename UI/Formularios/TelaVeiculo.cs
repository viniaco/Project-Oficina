using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace WF_OficinaTcc
{
    public partial class TelaVeiculo : Form
    {
        public TelaVeiculo()
        {
            InitializeComponent();
        }

        Veiculo cadastro;
        Cliente cli;

        private void GridLoad()
        {
            Veiculo dt = new Veiculo();

            BindingSource bs = new BindingSource();

            bs.DataSource = dt.GridViewVeiculo();

            gdvVeiculo.DataSource = bs;
        }

        private void btnCadastrarVeic_Click(object sender, EventArgs e)
        {
            cli = new Cliente();
            cadastro = new Veiculo();
            cadastro.Nome = txtNomeVeiculo.Text;
            cadastro.Ano = txtAno.Text;
            cadastro.Cor = txtCor.Text;
            cadastro.Cambio = cbCambio.Text;
            cadastro.Km = txtKM.Text;
            cadastro.Placa = txtPlaca.Text;
            cadastro.Combustivel = cbCombustivel.Text;
            cadastro.Observacao = txtObs.Text;
            cadastro.IdCliente = Convert.ToInt32(cbCliente.SelectedValue);

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

        private void btnEditarVeic_Click(object sender, EventArgs e)
        {
            cli = new Cliente();
            cadastro = new Veiculo();
            cadastro.Id = int.Parse(txtId.Text);
            cadastro.Nome = txtNomeVeiculo.Text;
            cadastro.Ano = txtAno.Text;
            cadastro.Cor = txtCor.Text;
            cadastro.Cambio = cbCambio.Text;
            cadastro.Km = txtKM.Text;
            cadastro.Placa = txtPlaca.Text;
            cadastro.Combustivel = cbCombustivel.Text;
            cadastro.Observacao = txtObs.Text;

            if (cadastro.Atualizar())
            {
                MessageBox.Show("Veiculo foi atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Atualização não realizada!");
            }
            LimparCampo();
            GridLoad();
        }

        private void btnBuscaVeic_Click(object sender, EventArgs e)
        {
            cadastro = new Veiculo();
            cadastro.Id = int.Parse(txtId.Text);
            cadastro.Pesquisar();
            if (cadastro.Id == 0)
            {
                MessageBox.Show("Desculpe, Veiculo não encontrado!");
            }
            else
            {
                txtNomeVeiculo.Text = cadastro.Nome;
                txtAno.Text = cadastro.Ano;
                txtCor.Text = cadastro.Cor;
                cbCambio.Text = cadastro.Cambio;
                txtKM.Text = cadastro.Placa;
                cbCombustivel.Text = cadastro.Combustivel;
                txtObs.Text = cadastro.Observacao;
                txtPlaca.Text = cadastro.Placa;
            }
        }

        private void btnExcluirVeic_Click(object sender, EventArgs e)
        {
            cadastro = new Veiculo();
            cadastro.Id = int.Parse(txtId.Text);
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

        private void TelaVeiculo_Load(object sender, EventArgs e)
        {
            cli = new Cliente();



            Veiculo veic = new Veiculo();
            var dt = veic.GridViewVeiculo();

            gdvVeiculo.DataSource = dt;

            cbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCliente.DataSource = cli.GridViewCliente();
            cbCliente.ValueMember = "idCliente";
            cbCliente.DisplayMember = "nome";
            cbCliente.Update();

            cbCliente.SelectedIndex = -1;

        }
        private void LimparCampo()
        {
            txtNomeVeiculo.Clear();
            txtAno.Clear();
            txtCor.Clear();
            txtId.Clear();
            txtKM.Clear();
            txtObs.Clear();
            txtPlaca.Clear();
            cbCliente.SelectedIndex = -1;
            cbCambio.SelectedIndex = -1;
        }

        private void dataGridViewVeiculo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LimparCampo();

            txtId.Text = gdvVeiculo.CurrentRow.Cells[0].Value.ToString();
            txtNomeVeiculo.Text = gdvVeiculo.CurrentRow.Cells[1].Value.ToString();
            txtAno.Text = gdvVeiculo.CurrentRow.Cells[2].Value.ToString();
            txtCor.Text = gdvVeiculo.CurrentRow.Cells[3].Value.ToString();
            cbCambio.Text = gdvVeiculo.CurrentRow.Cells[4].Value.ToString();
            txtKM.Text = gdvVeiculo.CurrentRow.Cells[5].Value.ToString();
            txtPlaca.Text = gdvVeiculo.CurrentRow.Cells[6].Value.ToString();
            cbCombustivel.Text = gdvVeiculo.CurrentRow.Cells[7].Value.ToString();
            txtObs.Text = gdvVeiculo.CurrentRow.Cells[8].Value.ToString();
            cbCliente.Text = gdvVeiculo.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnAtt_Click(object sender, EventArgs e)
        {
            cadastro = new Veiculo();
            cadastro.Id = Convert.ToInt32(txtId.Text);
            cadastro.Nome = txtNomeVeiculo.Text;
            cadastro.Ano = txtAno.Text;
            cadastro.Cor = txtCor.Text;
            cadastro.Cambio = cbCambio.Text;
            cadastro.Km = txtKM.Text;
            cadastro.Placa = txtPlaca.Text;
            cadastro.Combustivel = cbCombustivel.Text;
            cadastro.Observacao = txtObs.Text;
            cadastro.IdCliente = Convert.ToInt32(cbCliente.SelectedValue);

            if (cadastro.Atualizar())
            {
                MessageBox.Show("Veiculo: " + txtNomeVeiculo.Text + " foi atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Atualização não realizada!");
            }

            LimparCampo();
            GridLoad();
        }

        private void dataGridViewVeiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            cadastro = new Veiculo();
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
    }
}
