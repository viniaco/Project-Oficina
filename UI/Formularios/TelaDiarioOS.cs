using System;
using Business;
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
    public partial class TelaDiarioOS : Form
    {
        public TelaDiarioOS()
        {
            InitializeComponent();
        }
        DiarioOS cadastro;
        OrdemServico os;


        private void TelaDiarioOS_Load(object sender, EventArgs e)
        {
            os = new OrdemServico();

            DiarioOS OS = new DiarioOS();
            var dt = OS.GridViewDiario();

            gdvDiarioOS.DataSource = dt;


            cbOrdemServico.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOrdemServico.DataSource = os.GridViewOS();
            cbOrdemServico.ValueMember = "idOrdemservico";
            cbOrdemServico.DisplayMember = "nomeOS";
            cbOrdemServico.Update();
            cbOrdemServico.SelectedIndex = -1;

            if (TelaLogin.NivelAcesso == "Operador")
            {
                //Nível de Operador não podera cadastrar usuário
                btnEditar.Visible = false;
                btnExcluir.Visible = false;
            }
        }

        private void GridLoad()
        {
            DiarioOS dt = new DiarioOS();

            BindingSource bs = new BindingSource();

            bs.DataSource = dt.GridViewDiario();

            gdvDiarioOS.DataSource = bs;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            cadastro = new DiarioOS();
            cadastro.Assunto = txtAssunto.Text;
            cadastro.Ocorrencia = txtOcorrencia.Text;
            cadastro.DataOcorrencia = dtOcorrencia.Value.ToString();
            cadastro.IdOrdemDiario = Convert.ToInt32(cbOrdemServico.SelectedValue);

            if (cadastro.Cadastrar())
            {
                MessageBox.Show("Ocorrência Registrada com sucesso!");
            }
            else
            {
                MessageBox.Show("Registro não realizado!");
            }

            LimparCampo();
            GridLoad();
        }

        private void LimparCampo()
        {
            txtAssunto.Clear();
            txtIdDiario.Clear();
            txtOcorrencia.Clear();
            txtIdOrdem.Clear();
        }

        private void gdvDiarioOS_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LimparCampo();

            txtIdDiario.Text = gdvDiarioOS.CurrentRow.Cells[0].Value.ToString();
            txtAssunto.Text = gdvDiarioOS.CurrentRow.Cells[1].Value.ToString();
            txtOcorrencia.Text = gdvDiarioOS.CurrentRow.Cells[2].Value.ToString();
            dtOcorrencia.Text = gdvDiarioOS.CurrentRow.Cells[3].Value.ToString();
            txtIdOrdem.Text = gdvDiarioOS.CurrentRow.Cells[4].Value.ToString();
            cbOrdemServico.SelectedValue = Convert.ToInt32(gdvDiarioOS.CurrentRow.Cells[4].Value);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            cadastro = new DiarioOS();
            cadastro.IdDiario = int.Parse(txtIdDiario.Text);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            cadastro = new DiarioOS();
            cadastro.IdDiario = Convert.ToInt32(txtIdDiario.Text);
            cadastro.Assunto = txtAssunto.Text;
            cadastro.Ocorrencia = txtOcorrencia.Text;
            cadastro.DataOcorrencia = dtOcorrencia.Value.ToString();
            cadastro.IdOrdemDiario = Convert.ToInt32(cbOrdemServico.SelectedValue);

            if (cadastro.Atualizar())
            {
                MessageBox.Show("Ocorrência Registrada com sucesso!");
            }
            else
            {
                MessageBox.Show("Registro não realizado!");
            }

            LimparCampo();
            GridLoad();
        }
    }
}
