﻿using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Commons.Actions;
using excel = Microsoft.Office.Interop.Excel;

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

            if (TelaLogin.NivelAcesso == "Operador")
            {
                //Nível de Operador não podera cadastrar usuário
                btnGerarRelatorio.Visible = false;
                btnExcluir.Visible = false;
            }

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
            cadastro = new OrdemServico();
            cadastro.CadastradoPor = TelaLogin.usuarioConectado;
            cadastro.Aprovada = 1;
            cadastro.NomeOS = txtNomeOS.Text;
            cadastro.Valor = Convert.ToDouble(txtValorServico.Text);
            cadastro.Data = Convert.ToString(DateTime.Now);
            cadastro.Finalizada = cbFinalizada.SelectedItem.ToString();
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
            cadastro.Valor = Convert.ToDouble(txtValorServico.Text);
            cadastro.Finalizada = cbFinalizada.SelectedItem.ToString();
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
            cbFinalizada.SelectedIndex = -1;
            txtDatadia.Clear();
            txtCadastradoPor.Clear();
            txtValorServico.Clear();
        }

        private void DataGridViewOS_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LimparCampo();

            txtidOrdem.Text = gdvOS.CurrentRow.Cells[0].Value.ToString();
            txtCadastradoPor.Text = gdvOS.CurrentRow.Cells[1].Value.ToString();
            //.Text = dataGridViewVeiculo.CurrentRow.Cells[2].Value.ToString(); - APROVADA
            txtNomeOS.Text = gdvOS.CurrentRow.Cells[3].Value.ToString();
            txtValorServico.Text = gdvOS.CurrentRow.Cells[4].Value.ToString();
            txtDatadia.Text = gdvOS.CurrentRow.Cells[5].Value.ToString();
            cbFinalizada.Text = gdvOS.CurrentRow.Cells[6].Value.ToString();
            cbCliente.SelectedValue = Convert.ToInt32(gdvOS.CurrentRow.Cells[7].Value);
            cbVeiculo.SelectedValue = Convert.ToInt32(gdvOS.CurrentRow.Cells[8].Value);
            cbServico.SelectedValue = Convert.ToInt32(gdvOS.CurrentRow.Cells[9].Value);
        }

        private void tsSalvar_Click(object sender, EventArgs e)
        {
            servi = new Servico();
            cadastro = new OrdemServico();
            cadastro.CadastradoPor = TelaLogin.usuarioConectado;
            cadastro.Aprovada = 1;
            cadastro.NomeOS = txtNomeOS.Text;
            cadastro.Valor = Convert.ToDouble(txtValorServico.Text);
            cadastro.Data = Convert.ToString(DateTime.Now);
            cadastro.Finalizada = cbFinalizada.SelectedText.ToString();
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

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvaraquivo = new SaveFileDialog();
            excel.Application app;
            excel.Workbook workbook;
            excel.Worksheet worksheet;
            object misvalue = System.Reflection.Missing.Value;

            app = new excel.Application();
            workbook = app.Workbooks.Add(misvalue);
            worksheet = (excel.Worksheet)workbook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;

            for (i = 0; i <= gdvOS.RowCount - 1; i++)
            {
                for (j = 0; j <= gdvOS.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = gdvOS[j, i];
                    worksheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }

            salvaraquivo.Title = "Relatorio_OS";
            salvaraquivo.Filter = "Arquivo do excel *.xls | *.xls";
            salvaraquivo.ShowDialog();

            workbook.SaveAs(salvaraquivo.FileName, excel.XlFileFormat.xlWorkbookNormal, misvalue, misvalue,
                misvalue, misvalue,

            excel.XlSaveAsAccessMode.xlExclusive, misvalue, misvalue, misvalue, misvalue);
            workbook.Close(true, misvalue, misvalue);
            app.Quit();

            MessageBox.Show("Exportado com Sucesso");
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCliente.SelectedIndex != -1 && cbCliente.SelectedIndex != 0)
            {
                veic = new Veiculo();
                veic.IdCliente = Convert.ToInt32(cbCliente.SelectedValue);
                cbVeiculo.DropDownStyle = ComboBoxStyle.DropDownList;
                cbVeiculo.DataSource = veic.listaVeiculo();
                cbVeiculo.ValueMember = "idVeiculo";
                cbVeiculo.DisplayMember = "nome";
                cbVeiculo.Update();
            }

        }

        private void cbServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbServico.SelectedIndex != -1 && cbServico.SelectedIndex != 0)
            {
                servi = new Servico();
                servi.IdServico = Convert.ToInt32(cbServico.SelectedValue);
                servi.Pesquisar();
                txtValorServico.Text = servi.Valor.ToString();
            }
        }

        private void txtCadastradoPor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
