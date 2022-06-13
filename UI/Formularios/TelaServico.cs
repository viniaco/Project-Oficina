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
        OrdemServico OS;


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastro = new Servico();

            cadastro.Nome = txtNome.Text;
            cadastro.Descricao = txtDesc.Text;
            cadastro.Observacao = txtDesc.Text;
            cadastro.Valor = Convert.ToDouble(txtValor.Text);
            cadastro.DataDia = txtDatadia.Text;
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
                MessageBox.Show("Veiculo foi atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Atualização não realizada!");
            }
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
    }
}
