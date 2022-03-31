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

        private void btnCadastrarVeic_Click(object sender, EventArgs e)
        {
            //Botao de cadastro
            cadastro = new Veiculo();
            cadastro.Nome = txtNomeVeiculo.Text;
            cadastro.Ano = txtAno.Text;
            cadastro.Cor = txtCor.Text;
            cadastro.Cambio = cbCambio.Text;
            cadastro.Km = txtKM.Text;
            cadastro.Placa = txtPlaca.Text;
            cadastro.Combustivel = cbCombustivel.Text;
            cadastro.Observacao = txtObs.Text;

            if (cadastro.Cadastrar())
            {
                MessageBox.Show("CADASTRADO!");
            }
            else
            {
                MessageBox.Show("Cadastro não realizado!");
            }
        }

        private void btnEditarVeic_Click(object sender, EventArgs e)
        {
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
        }
    }
}
