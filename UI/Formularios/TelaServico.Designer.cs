
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
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idServicoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.observacaoTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.dataDiaTextBox = new System.Windows.Forms.TextBox();
            this.cadastradoPorTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbmFiltrar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbServicoDataGridView = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtt = new System.Windows.Forms.Button();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            idServicoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            observacaoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            dataDiaLabel = new System.Windows.Forms.Label();
            cadastradoPorLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbServicoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idServicoLabel
            // 
            idServicoLabel.AutoSize = true;
            idServicoLabel.Location = new System.Drawing.Point(6, 27);
            idServicoLabel.Name = "idServicoLabel";
            idServicoLabel.Size = new System.Drawing.Size(51, 13);
            idServicoLabel.TabIndex = 0;
            idServicoLabel.Text = "Código: ";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(112, 27);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(45, 13);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome: ";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(6, 66);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(62, 13);
            descricaoLabel.TabIndex = 4;
            descricaoLabel.Text = "Descrição: ";
            // 
            // observacaoLabel
            // 
            observacaoLabel.AutoSize = true;
            observacaoLabel.Location = new System.Drawing.Point(3, 127);
            observacaoLabel.Name = "observacaoLabel";
            observacaoLabel.Size = new System.Drawing.Size(73, 13);
            observacaoLabel.TabIndex = 6;
            observacaoLabel.Text = "Observação: ";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(6, 188);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(39, 13);
            valorLabel.TabIndex = 8;
            valorLabel.Text = "Valor: ";
            // 
            // dataDiaLabel
            // 
            dataDiaLabel.AutoSize = true;
            dataDiaLabel.Location = new System.Drawing.Point(112, 188);
            dataDiaLabel.Name = "dataDiaLabel";
            dataDiaLabel.Size = new System.Drawing.Size(103, 13);
            dataDiaLabel.TabIndex = 10;
            dataDiaLabel.Text = "Data do Cadastro: ";
            // 
            // cadastradoPorLabel
            // 
            cadastradoPorLabel.AutoSize = true;
            cadastradoPorLabel.Location = new System.Drawing.Point(250, 188);
            cadastradoPorLabel.Name = "cadastradoPorLabel";
            cadastradoPorLabel.Size = new System.Drawing.Size(93, 13);
            cadastradoPorLabel.TabIndex = 12;
            cadastradoPorLabel.Text = "Cadastrado Por: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 40);
            this.label6.TabIndex = 13;
            this.label6.Text = "Serviços";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(idServicoLabel);
            this.groupBox1.Controls.Add(this.idServicoTextBox);
            this.groupBox1.Controls.Add(nomeLabel);
            this.groupBox1.Controls.Add(this.nomeTextBox);
            this.groupBox1.Controls.Add(descricaoLabel);
            this.groupBox1.Controls.Add(this.descricaoTextBox);
            this.groupBox1.Controls.Add(observacaoLabel);
            this.groupBox1.Controls.Add(this.observacaoTextBox);
            this.groupBox1.Controls.Add(valorLabel);
            this.groupBox1.Controls.Add(this.valorTextBox);
            this.groupBox1.Controls.Add(dataDiaLabel);
            this.groupBox1.Controls.Add(this.dataDiaTextBox);
            this.groupBox1.Controls.Add(cadastradoPorLabel);
            this.groupBox1.Controls.Add(this.cadastradoPorTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 230);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // idServicoTextBox
            // 
            this.idServicoTextBox.Enabled = false;
            this.idServicoTextBox.Location = new System.Drawing.Point(9, 43);
            this.idServicoTextBox.Name = "idServicoTextBox";
            this.idServicoTextBox.Size = new System.Drawing.Size(100, 22);
            this.idServicoTextBox.TabIndex = 1;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(115, 43);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(424, 22);
            this.nomeTextBox.TabIndex = 3;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(6, 82);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descricaoTextBox.Size = new System.Drawing.Size(529, 42);
            this.descricaoTextBox.TabIndex = 5;
            // 
            // observacaoTextBox
            // 
            this.observacaoTextBox.Location = new System.Drawing.Point(6, 143);
            this.observacaoTextBox.Multiline = true;
            this.observacaoTextBox.Name = "observacaoTextBox";
            this.observacaoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.observacaoTextBox.Size = new System.Drawing.Size(529, 42);
            this.observacaoTextBox.TabIndex = 7;
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(9, 204);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(100, 22);
            this.valorTextBox.TabIndex = 9;
            // 
            // dataDiaTextBox
            // 
            this.dataDiaTextBox.Enabled = false;
            this.dataDiaTextBox.Location = new System.Drawing.Point(115, 204);
            this.dataDiaTextBox.Name = "dataDiaTextBox";
            this.dataDiaTextBox.Size = new System.Drawing.Size(129, 22);
            this.dataDiaTextBox.TabIndex = 11;
            // 
            // cadastradoPorTextBox
            // 
            this.cadastradoPorTextBox.Enabled = false;
            this.cadastradoPorTextBox.Location = new System.Drawing.Point(250, 204);
            this.cadastradoPorTextBox.Name = "cadastradoPorTextBox";
            this.cadastradoPorTextBox.Size = new System.Drawing.Size(185, 22);
            this.cadastradoPorTextBox.TabIndex = 13;
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
            this.groupBox2.Location = new System.Drawing.Point(28, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(852, 66);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisar";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(401, 26);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.AcceptsReturn = true;
            this.txtPesquisar.Location = new System.Drawing.Point(211, 28);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(183, 22);
            this.txtPesquisar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "=";
            // 
            // cbmFiltrar
            // 
            this.cbmFiltrar.FormattingEnabled = true;
            this.cbmFiltrar.Items.AddRange(new object[] {
            "",
            "Código",
            "Nome"});
            this.cbmFiltrar.Location = new System.Drawing.Point(65, 28);
            this.cbmFiltrar.Name = "cbmFiltrar";
            this.cbmFiltrar.Size = new System.Drawing.Size(121, 21);
            this.cbmFiltrar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar por: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tbServicoDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(28, 370);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(659, 79);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Serviço(s)";
            // 
            // tbServicoDataGridView
            // 
            this.tbServicoDataGridView.AllowUserToAddRows = false;
            this.tbServicoDataGridView.AllowUserToDeleteRows = false;
            this.tbServicoDataGridView.ColumnHeadersHeight = 29;
            this.tbServicoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbServicoDataGridView.Location = new System.Drawing.Point(3, 16);
            this.tbServicoDataGridView.Name = "tbServicoDataGridView";
            this.tbServicoDataGridView.ReadOnly = true;
            this.tbServicoDataGridView.RowHeadersWidth = 51;
            this.tbServicoDataGridView.Size = new System.Drawing.Size(653, 60);
            this.tbServicoDataGridView.TabIndex = 0;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExcluir.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.Location = new System.Drawing.Point(693, 448);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(102, 23);
            this.btnExcluir.TabIndex = 47;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAtt
            // 
            this.btnAtt.BackColor = System.Drawing.Color.Transparent;
            this.btnAtt.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAtt.Location = new System.Drawing.Point(693, 419);
            this.btnAtt.Name = "btnAtt";
            this.btnAtt.Size = new System.Drawing.Size(102, 23);
            this.btnAtt.TabIndex = 46;
            this.btnAtt.Text = "Atualizar";
            this.btnAtt.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastrarCliente.Location = new System.Drawing.Point(693, 386);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(102, 27);
            this.btnCadastrarCliente.TabIndex = 45;
            this.btnCadastrarCliente.Text = "Cadastrar";
            this.btnCadastrarCliente.UseVisualStyleBackColor = false;
            // 
            // TelaServicoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 489);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnAtt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.label6);
            this.Name = "TelaServicoItem";
            this.Text = "TelaAgendamento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbServicoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox idServicoTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox observacaoTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.TextBox dataDiaTextBox;
        private System.Windows.Forms.TextBox cadastradoPorTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbmFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView tbServicoDataGridView;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtt;
        private System.Windows.Forms.Button btnCadastrarCliente;
    }
}