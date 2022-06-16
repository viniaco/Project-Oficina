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
    public partial class TelaOS : Form
    {
        public TelaOS()
        {
            InitializeComponent();
        }

        OrdemServico cadastro;
        Veiculo veic;
        Cliente cli;
        Servico servi;

        private void TelaAgendamento_Load(object sender, EventArgs e)
        {
            cli = new Cliente();
            veic = new Veiculo();
            servi = new Servico();

            OrdemServico OS = new OrdemServico();
            var dt = OS.GridViewOS();

            gdvOS.DataSource = dt;


            cbVeiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVeiculo.DataSource = veic.GridViewVeiculo();
            cbVeiculo.ValueMember = "idveiculo";
            cbVeiculo.DisplayMember = "nome";
            cbVeiculo.Update();


            cbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCliente.DataSource = cli.GridViewCliente();
            cbCliente.ValueMember = "idCliente";
            cbCliente.DisplayMember = "nome";
            cbCliente.Update();


            cbServico.DropDownStyle = ComboBoxStyle.DropDownList;
            cbServico.DataSource = servi.GridViewServico();
            cbServico.ValueMember = "idServico";
            cbServico.DisplayMember = "nome";
            cbServico.Update();

            cbVeiculo.SelectedIndex = -1;
            cbCliente.SelectedIndex = -1;
            cbServico.SelectedIndex = -1;

        }

        private void GridLoad()
        {
            OrdemServico dt = new OrdemServico();

            BindingSource bs = new BindingSource();

            bs.DataSource = dt.GridViewOS();

            gdvOS.DataSource = bs;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            servi = new Servico();
            var 
            cadastro = new OrdemServico();
            cadastro.CadastradoPor = TelaLogin.usuarioConectado;
            cadastro.Aprovada = 1;
            cadastro.NomeOS = txtNomeOS.Text;
            cadastro.Valor = servi.Valor;
            cadastro.Data = Convert.ToString(DateTime.Now);
            cadastro.IdCliente = Convert.ToInt32(cbCliente.SelectedValue);
            cadastro.idVeiculo = Convert.ToInt32(cbVeiculo.SelectedValue);
            cadastro.idServico = Convert.ToInt32(cbServico.SelectedValue);

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
            servi = new Servico();
            cadastro = new OrdemServico();
            cadastro.IdOrdem = Convert.ToInt32(txtidOrdem.Text);
            cadastro.CadastradoPor = TelaLogin.usuarioConectado;
            cadastro.Aprovada = 1;
            cadastro.NomeOS = txtNomeOS.Text;
            cadastro.Valor = servi.Valor;
            cadastro.Data = Convert.ToString(DateTime.Now);
            cadastro.IdCliente = Convert.ToInt32(cbCliente.SelectedValue);
            cadastro.idVeiculo = Convert.ToInt32(cbVeiculo.SelectedValue);
            cadastro.idServico = Convert.ToInt32(cbServico.SelectedValue);


            if (cadastro.Atualizar())
            {
                MessageBox.Show("A Ordem de Serviço foi atualizado com sucesso!");
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
            cadastro = new OrdemServico();
            cadastro.IdOrdem = int.Parse(txtidOrdem.Text);
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

        private void LimparCampo()
        {
            txtidOrdem.Clear();
            txtNomeOS.Clear();
            cbCliente.SelectedIndex = -1;
            cbServico.SelectedIndex = -1;
            cbVeiculo.SelectedIndex = -1;
            txtDatadia.Clear();
            txtCadastradoPor.Clear();
        }

        private void DataGridViewOS_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LimparCampo();

            txtidOrdem.Text = gdvOS.CurrentRow.Cells[0].Value.ToString();
            txtCadastradoPor.Text = gdvOS.CurrentRow.Cells[1].Value.ToString();
            //.Text = dataGridViewVeiculo.CurrentRow.Cells[2].Value.ToString(); - APROVADA
            txtNomeOS.Text = gdvOS.CurrentRow.Cells[3].Value.ToString();
            //.Text = dataGridViewVeiculo.CurrentRow.Cells[4].Value.ToString(); - VALOR 
            txtDatadia.Text = gdvOS.CurrentRow.Cells[5].Value.ToString();
            cbCliente.Text = gdvOS.CurrentRow.Cells[6].Value.ToString();
            cbVeiculo.Text = gdvOS.CurrentRow.Cells[7].Value.ToString();
            cbVeiculo.Text = gdvOS.CurrentRow.Cells[8].Value.ToString();
        }

        private void tsSalvar_Click(object sender, EventArgs e)
        {
            servi = new Servico();
            var
            cadastro = new OrdemServico();
            cadastro.CadastradoPor = TelaLogin.usuarioConectado;
            cadastro.Aprovada = 1;
            cadastro.NomeOS = txtNomeOS.Text;
            cadastro.Valor = servi.Valor;
            cadastro.Data = Convert.ToString(DateTime.Now);
            cadastro.IdCliente = Convert.ToInt32(cbCliente.SelectedValue);
            cadastro.idVeiculo = Convert.ToInt32(cbVeiculo.SelectedValue);
            cadastro.idServico = Convert.ToInt32(cbServico.SelectedValue);

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

        private void gdvOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
