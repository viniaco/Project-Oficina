
namespace WF_OficinaTcc
{
    partial class TelaServico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label idServicoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label observacaoLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label dataDiaLabel;
            System.Windows.Forms.Label cadastradoPorLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdServico = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDatadia = new System.Windows.Forms.TextBox();
            this.txtCadastradoPor = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gdvServico = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtt = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbmFiltrar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            idServicoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            observacaoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            dataDiaLabel = new System.Windows.Forms.Label();
            cadastradoPorLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvServico)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // idServicoLabel
            // 
            idServicoLabel.AutoSize = true;
            idServicoLabel.Location = new System.Drawing.Point(8, 33);
            idServicoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idServicoLabel.Name = "idServicoLabel";
            idServicoLabel.Size = new System.Drawing.Size(66, 19);
            idServicoLabel.TabIndex = 0;
            idServicoLabel.Text = "Código: ";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(149, 33);
            nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(58, 19);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome: ";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(8, 81);
            descricaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(82, 19);
            descricaoLabel.TabIndex = 4;
            descricaoLabel.Text = "Descrição: ";
            // 
            // observacaoLabel
            // 
            observacaoLabel.AutoSize = true;
            observacaoLabel.Location = new System.Drawing.Point(4, 156);
            observacaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            observacaoLabel.Name = "observacaoLabel";
            observacaoLabel.Size = new System.Drawing.Size(98, 19);
            observacaoLabel.TabIndex = 6;
            observacaoLabel.Text = "Observação: ";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(8, 231);
            valorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(53, 19);
            valorLabel.TabIndex = 8;
            valorLabel.Text = "Valor: ";
            // 
            // dataDiaLabel
            // 
            dataDiaLabel.AutoSize = true;
            dataDiaLabel.Location = new System.Drawing.Point(149, 231);
            dataDiaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataDiaLabel.Name = "dataDiaLabel";
            dataDiaLabel.Size = new System.Drawing.Size(134, 19);
            dataDiaLabel.TabIndex = 10;
            dataDiaLabel.Text = "Data do Cadastro: ";
            // 
            // cadastradoPorLabel
            // 
            cadastradoPorLabel.AutoSize = true;
            cadastradoPorLabel.Location = new System.Drawing.Point(333, 231);
            cadastradoPorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cadastradoPorLabel.Name = "cadastradoPorLabel";
            cadastradoPorLabel.Size = new System.Drawing.Size(123, 19);
            cadastradoPorLabel.TabIndex = 12;
            cadastradoPorLabel.Text = "Cadastrado Por: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 50);
            this.label6.TabIndex = 13;
            this.label6.Text = "Serviços";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(idServicoLabel);
            this.groupBox1.Controls.Add(this.txtIdServico);
            this.groupBox1.Controls.Add(nomeLabel);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(descricaoLabel);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(observacaoLabel);
            this.groupBox1.Controls.Add(this.txtObs);
            this.groupBox1.Controls.Add(valorLabel);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(dataDiaLabel);
            this.groupBox1.Controls.Add(this.txtDatadia);
            this.groupBox1.Controls.Add(cadastradoPorLabel);
            this.groupBox1.Controls.Add(this.txtCadastradoPor);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1136, 283);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // txtIdServico
            // 
            this.txtIdServico.Enabled = false;
            this.txtIdServico.Location = new System.Drawing.Point(12, 53);
            this.txtIdServico.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdServico.Name = "txtIdServico";
            this.txtIdServico.Size = new System.Drawing.Size(132, 26);
            this.txtIdServico.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(153, 53);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(564, 26);
            this.txtNome.TabIndex = 3;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(8, 101);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(704, 51);
            this.txtDesc.TabIndex = 5;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(8, 176);
            this.txtObs.Margin = new System.Windows.Forms.Padding(4);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObs.Size = new System.Drawing.Size(704, 51);
            this.txtObs.TabIndex = 7;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(12, 251);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(132, 26);
            this.txtValor.TabIndex = 9;
            // 
            // txtDatadia
            // 
            this.txtDatadia.Enabled = false;
            this.txtDatadia.Location = new System.Drawing.Point(153, 251);
            this.txtDatadia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatadia.Name = "txtDatadia";
            this.txtDatadia.Size = new System.Drawing.Size(171, 26);
            this.txtDatadia.TabIndex = 11;
            // 
            // txtCadastradoPor
            // 
            this.txtCadastradoPor.Enabled = false;
            this.txtCadastradoPor.Location = new System.Drawing.Point(333, 251);
            this.txtCadastradoPor.Margin = new System.Windows.Forms.Padding(4);
            this.txtCadastradoPor.Name = "txtCadastradoPor";
            this.txtCadastradoPor.Size = new System.Drawing.Size(245, 26);
            this.txtCadastradoPor.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.gdvServico);
            this.groupBox3.Location = new System.Drawing.Point(37, 455);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(879, 97);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Serviço(s)";
            // 
            // gdvServico
            // 
            this.gdvServico.AllowUserToAddRows = false;
            this.gdvServico.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvServico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gdvServico.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvServico.DefaultCellStyle = dataGridViewCellStyle2;
            this.gdvServico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvServico.Location = new System.Drawing.Point(4, 19);
            this.gdvServico.Margin = new System.Windows.Forms.Padding(4);
            this.gdvServico.Name = "gdvServico";
            this.gdvServico.ReadOnly = true;
            this.gdvServico.RowHeadersWidth = 51;
            this.gdvServico.Size = new System.Drawing.Size(871, 74);
            this.gdvServico.TabIndex = 0;
            this.gdvServico.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ServicoDataGridView_MouseDoubleClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExcluir.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.Location = new System.Drawing.Point(1037, 543);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(136, 28);
            this.btnExcluir.TabIndex = 47;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtt
            // 
            this.btnAtt.BackColor = System.Drawing.Color.Transparent;
            this.btnAtt.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAtt.Location = new System.Drawing.Point(1037, 507);
            this.btnAtt.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtt.Name = "btnAtt";
            this.btnAtt.Size = new System.Drawing.Size(136, 28);
            this.btnAtt.TabIndex = 46;
            this.btnAtt.Text = "Atualizar";
            this.btnAtt.UseVisualStyleBackColor = false;
            this.btnAtt.Click += new System.EventHandler(this.btnAtt_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCadastrar.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastrar.Location = new System.Drawing.Point(1037, 466);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(136, 33);
            this.btnCadastrar.TabIndex = 45;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar por: ";
            // 
            // cbmFiltrar
            // 
            this.cbmFiltrar.FormattingEnabled = true;
            this.cbmFiltrar.Items.AddRange(new object[] {
            "",
            "Código",
            "Nome"});
            this.cbmFiltrar.Location = new System.Drawing.Point(87, 34);
            this.cbmFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.cbmFiltrar.Name = "cbmFiltrar";
            this.cbmFiltrar.Size = new System.Drawing.Size(160, 27);
            this.cbmFiltrar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "=";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.AcceptsReturn = true;
            this.txtPesquisar.Location = new System.Drawing.Point(281, 34);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(243, 26);
            this.txtPesquisar.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(535, 32);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 28);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Controls.Add(this.txtPesquisar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbmFiltrar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(37, 367);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1136, 81);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisar";
            // 
            // TelaServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 602);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnAtt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaServico";
            this.Text = "TelaAgendamento";
            this.Load += new System.EventHandler(this.TelaServico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvServico)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIdServico;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDatadia;
        private System.Windows.Forms.TextBox txtCadastradoPor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gdvServico;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtt;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbmFiltrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}