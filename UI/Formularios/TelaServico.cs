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
    public partial class TelaServico : Form
    {
        public TelaServico()
        {
            InitializeComponent();
        }

        Servico cadastro;


        private void GridLoad()
        {
            Servico dt = new Servico();

            BindingSource bs = new BindingSource();

            bs.DataSource = dt.GridViewServico();

            ServicoDataGridView.DataSource = bs;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastro = new Servico();
            cadastro.Nome = txtNome.Text;
            cadastro.Descricao = txtDesc.Text;
            cadastro.Observacao = txtDesc.Text;
            cadastro.Valor = Convert.ToDouble(txtValor.Text);
            cadastro.DataDia = Convert.ToString(DateTime.Today);
            cadastro.CadastradoPor = TelaLogin.usuarioConectado;

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

        private void btnAtt_Click(object sender, EventArgs e)
        {

            cadastro = new Servico();
            cadastro.IdServico = int.Parse(txtIdServico.Text);
            cadastro.Nome = txtNome.Text;
            cadastro.Descricao = txtDesc.Text;
            cadastro.Observacao = txtDesc.Text;
            cadastro.Valor = Convert.ToDouble(txtValor.Text);
            cadastro.DataDia = txtDatadia.Text;
            cadastro.CadastradoPor = txtCadastradoPor.Text;


            if (cadastro.Atualizar())
            {
                MessageBox.Show("O Serviço foi atualizado com sucesso!");
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
            cadastro = new Servico();
            cadastro.IdServico = int.Parse(txtIdServico.Text);
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

        private void TelaServico_Load(object sender, EventArgs e)
        {
            Servico serv = new Servico();
            var dt = serv.GridViewServico();

            ServicoDataGridView.DataSource = dt;
        }

        private void LimparCampo()
        {
            txtNome.Clear();
            txtIdServico.Clear();
            txtDesc.Clear();
            txtObs.Clear();
            txtValor.Clear();
            txtDatadia.Clear();
            txtCadastradoPor.Clear();
        }

        private void ServicoDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LimparCampo();

            txtIdServico.Text = ServicoDataGridView.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = ServicoDataGridView.CurrentRow.Cells[1].Value.ToString();
            txtDesc.Text = ServicoDataGridView.CurrentRow.Cells[2].Value.ToString();
            txtObs.Text = ServicoDataGridView.CurrentRow.Cells[3].Value.ToString();
            txtValor.Text = ServicoDataGridView.CurrentRow.Cells[4].Value.ToString();
            txtDatadia.Text = ServicoDataGridView.CurrentRow.Cells[5].Value.ToString();
            txtCadastradoPor.Text = ServicoDataGridView.CurrentRow.Cells[6].Value.ToString();

        }
    }
}
