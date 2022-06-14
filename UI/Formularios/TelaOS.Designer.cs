
namespace WF_OficinaTcc
{
    partial class TelaOS
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
            System.Windows.Forms.Label cadastradorPorLabel;
            System.Windows.Forms.Label dataDiaLabel;
            System.Windows.Forms.Label idServicoLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label idOrdemLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPesquisar = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbmFiltrar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNomeOS = new System.Windows.Forms.TextBox();
            this.cbVeiculo = new System.Windows.Forms.ComboBox();
            this.txtCadastradoPor = new System.Windows.Forms.TextBox();
            this.txtDatadia = new System.Windows.Forms.TextBox();
            this.cbServico = new System.Windows.Forms.ComboBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.txtidOrdem = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gdvOS = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtt = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            cadastradorPorLabel = new System.Windows.Forms.Label();
            dataDiaLabel = new System.Windows.Forms.Label();
            idServicoLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            idOrdemLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvOS)).BeginInit();
            this.SuspendLayout();
            // 
            // cadastradorPorLabel
            // 
            cadastradorPorLabel.AutoSize = true;
            cadastradorPorLabel.Location = new System.Drawing.Point(241, 129);
            cadastradorPorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cadastradorPorLabel.Name = "cadastradorPorLabel";
            cadastradorPorLabel.Size = new System.Drawing.Size(123, 19);
            cadastradorPorLabel.TabIndex = 8;
            cadastradorPorLabel.Text = "Cadastrado Por: ";
            // 
            // dataDiaLabel
            // 
            dataDiaLabel.AutoSize = true;
            dataDiaLabel.Location = new System.Drawing.Point(9, 129);
            dataDiaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataDiaLabel.Name = "dataDiaLabel";
            dataDiaLabel.Size = new System.Drawing.Size(130, 19);
            dataDiaLabel.TabIndex = 6;
            dataDiaLabel.Text = "Data do Cadastro:";
            // 
            // idServicoLabel
            // 
            idServicoLabel.AutoSize = true;
            idServicoLabel.Location = new System.Drawing.Point(9, 74);
            idServicoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idServicoLabel.Name = "idServicoLabel";
            idServicoLabel.Size = new System.Drawing.Size(131, 19);
            idServicoLabel.TabIndex = 4;
            idServicoLabel.Text = "Nome do Serviço:";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(584, 27);
            idClienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(126, 19);
            idClienteLabel.TabIndex = 2;
            idClienteLabel.Text = "Nome do Cliente:";
            // 
            // idOrdemLabel
            // 
            idOrdemLabel.AutoSize = true;
            idOrdemLabel.Location = new System.Drawing.Point(9, 27);
            idOrdemLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idOrdemLabel.Name = "idOrdemLabel";
            idOrdemLabel.Size = new System.Drawing.Size(85, 19);
            idOrdemLabel.TabIndex = 0;
            idOrdemLabel.Text = "Código OS:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(584, 74);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(124, 19);
            label1.TabIndex = 10;
            label1.Text = "Nome do Veiculo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(98, 27);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(98, 19);
            label2.TabIndex = 12;
            label2.Text = "Nome da OS:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 50);
            this.label6.TabIndex = 13;
            this.label6.Text = "Agendamento";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtPesquisar);
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbmFiltrar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(39, 274);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1049, 80);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OS(s)";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(281, 36);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(175, 26);
            this.txtPesquisar.TabIndex = 10;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(465, 33);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 28);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "=";
            // 
            // cbmFiltrar
            // 
            this.cbmFiltrar.FormattingEnabled = true;
            this.cbmFiltrar.Items.AddRange(new object[] {
            "",
            "Código OS",
            "Código Cliente",
            "Código Serviço"});
            this.cbmFiltrar.Location = new System.Drawing.Point(87, 36);
            this.cbmFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.cbmFiltrar.Name = "cbmFiltrar";
            this.cbmFiltrar.Size = new System.Drawing.Size(160, 27);
            this.cbmFiltrar.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Filtrar por:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.txtNomeOS);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.cbVeiculo);
            this.groupBox1.Controls.Add(cadastradorPorLabel);
            this.groupBox1.Controls.Add(this.txtCadastradoPor);
            this.groupBox1.Controls.Add(dataDiaLabel);
            this.groupBox1.Controls.Add(this.txtDatadia);
            this.groupBox1.Controls.Add(idServicoLabel);
            this.groupBox1.Controls.Add(this.cbServico);
            this.groupBox1.Controls.Add(idClienteLabel);
            this.groupBox1.Controls.Add(this.cbCliente);
            this.groupBox1.Controls.Add(idOrdemLabel);
            this.groupBox1.Controls.Add(this.txtidOrdem);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1049, 188);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados OS";
            // 
            // txtNomeOS
            // 
            this.txtNomeOS.Location = new System.Drawing.Point(102, 47);
            this.txtNomeOS.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeOS.Name = "txtNomeOS";
            this.txtNomeOS.Size = new System.Drawing.Size(474, 26);
            this.txtNomeOS.TabIndex = 13;
            // 
            // cbVeiculo
            // 
            this.cbVeiculo.DisplayMember = "idCliente";
            this.cbVeiculo.FormattingEnabled = true;
            this.cbVeiculo.Location = new System.Drawing.Point(584, 94);
            this.cbVeiculo.Margin = new System.Windows.Forms.Padding(4);
            this.cbVeiculo.Name = "cbVeiculo";
            this.cbVeiculo.Size = new System.Drawing.Size(343, 27);
            this.cbVeiculo.TabIndex = 11;
            this.cbVeiculo.ValueMember = "idCliente";
            // 
            // txtCadastradoPor
            // 
            this.txtCadastradoPor.Enabled = false;
            this.txtCadastradoPor.Location = new System.Drawing.Point(241, 149);
            this.txtCadastradoPor.Margin = new System.Windows.Forms.Padding(4);
            this.txtCadastradoPor.Name = "txtCadastradoPor";
            this.txtCadastradoPor.Size = new System.Drawing.Size(335, 26);
            this.txtCadastradoPor.TabIndex = 9;
            // 
            // txtDatadia
            // 
            this.txtDatadia.Enabled = false;
            this.txtDatadia.Location = new System.Drawing.Point(13, 149);
            this.txtDatadia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatadia.Name = "txtDatadia";
            this.txtDatadia.Size = new System.Drawing.Size(211, 26);
            this.txtDatadia.TabIndex = 7;
            // 
            // cbServico
            // 
            this.cbServico.DisplayMember = "idServico";
            this.cbServico.FormattingEnabled = true;
            this.cbServico.Location = new System.Drawing.Point(13, 94);
            this.cbServico.Margin = new System.Windows.Forms.Padding(4);
            this.cbServico.Name = "cbServico";
            this.cbServico.Size = new System.Drawing.Size(563, 27);
            this.cbServico.TabIndex = 5;
            this.cbServico.ValueMember = "idServico";
            // 
            // cbCliente
            // 
            this.cbCliente.DisplayMember = "idCliente";
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(584, 47);
            this.cbCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(343, 27);
            this.cbCliente.TabIndex = 3;
            this.cbCliente.ValueMember = "idCliente";
            // 
            // txtidOrdem
            // 
            this.txtidOrdem.Enabled = false;
            this.txtidOrdem.Location = new System.Drawing.Point(13, 47);
            this.txtidOrdem.Margin = new System.Windows.Forms.Padding(4);
            this.txtidOrdem.Name = "txtidOrdem";
            this.txtidOrdem.Size = new System.Drawing.Size(81, 26);
            this.txtidOrdem.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.gdvOS);
            this.groupBox3.Location = new System.Drawing.Point(36, 362);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1052, 377);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OS(s)";
            // 
            // gdvOS
            // 
            this.gdvOS.AllowUserToAddRows = false;
            this.gdvOS.AllowUserToDeleteRows = false;
            this.gdvOS.ColumnHeadersHeight = 29;
            this.gdvOS.Location = new System.Drawing.Point(27, 23);
            this.gdvOS.Margin = new System.Windows.Forms.Padding(4);
            this.gdvOS.Name = "gdvOS";
            this.gdvOS.ReadOnly = true;
            this.gdvOS.RowHeadersWidth = 51;
            this.gdvOS.Size = new System.Drawing.Size(683, 357);
            this.gdvOS.TabIndex = 0;
            this.gdvOS.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DataGridViewOS_MouseDoubleClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExcluir.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.Location = new System.Drawing.Point(763, 462);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(136, 31);
            this.btnExcluir.TabIndex = 41;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtt
            // 
            this.btnAtt.BackColor = System.Drawing.Color.Transparent;
            this.btnAtt.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAtt.Location = new System.Drawing.Point(763, 426);
            this.btnAtt.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtt.Name = "btnAtt";
            this.btnAtt.Size = new System.Drawing.Size(136, 28);
            this.btnAtt.TabIndex = 40;
            this.btnAtt.Text = "Atualizar";
            this.btnAtt.UseVisualStyleBackColor = false;
            this.btnAtt.Click += new System.EventHandler(this.btnAtt_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCadastrar.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastrar.Location = new System.Drawing.Point(763, 385);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(136, 33);
            this.btnCadastrar.TabIndex = 39;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // TelaOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 793);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtt);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaOS";
            this.Text = "TelaAgendamento";
            this.Load += new System.EventHandler(this.TelaAgendamento_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbmFiltrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCadastradoPor;
        private System.Windows.Forms.TextBox txtDatadia;
        private System.Windows.Forms.ComboBox cbServico;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.TextBox txtidOrdem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gdvOS;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtt;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cbVeiculo;
        private System.Windows.Forms.TextBox txtNomeOS;
    }
}