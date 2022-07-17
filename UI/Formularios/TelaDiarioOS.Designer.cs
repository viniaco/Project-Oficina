
namespace WF_OficinaTcc
{
    partial class TelaDiarioOS
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
            System.Windows.Forms.Label diarioLabel;
            System.Windows.Forms.Label idOrdemLabel;
            System.Windows.Forms.Label assuntoLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDiarioOS));
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtIdDiario = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.cbOrdemServico = new System.Windows.Forms.ComboBox();
            this.txtOcorrencia = new System.Windows.Forms.RichTextBox();
            this.txtIdOrdem = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.dtOcorrencia = new System.Windows.Forms.DateTimePicker();
            this.gdvDiarioOS = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            diarioLabel = new System.Windows.Forms.Label();
            idOrdemLabel = new System.Windows.Forms.Label();
            assuntoLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDiarioOS)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // diarioLabel
            // 
            diarioLabel.AutoSize = true;
            diarioLabel.Location = new System.Drawing.Point(27, 248);
            diarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            diarioLabel.Name = "diarioLabel";
            diarioLabel.Size = new System.Drawing.Size(101, 23);
            diarioLabel.TabIndex = 8;
            diarioLabel.Text = "Ocorrência:";
            // 
            // idOrdemLabel
            // 
            idOrdemLabel.AutoSize = true;
            idOrdemLabel.Location = new System.Drawing.Point(31, 172);
            idOrdemLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idOrdemLabel.Name = "idOrdemLabel";
            idOrdemLabel.Size = new System.Drawing.Size(92, 23);
            idOrdemLabel.TabIndex = 4;
            idOrdemLabel.Text = "id Ordem:";
            // 
            // assuntoLabel
            // 
            assuntoLabel.AutoSize = true;
            assuntoLabel.Location = new System.Drawing.Point(31, 100);
            assuntoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            assuntoLabel.Name = "assuntoLabel";
            assuntoLabel.Size = new System.Drawing.Size(78, 23);
            assuntoLabel.TabIndex = 2;
            assuntoLabel.Text = "Assunto:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(122, 32);
            dataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(53, 23);
            dataLabel.TabIndex = 0;
            dataLabel.Text = "Data:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(29, 30);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 23);
            label1.TabIndex = 13;
            label1.Text = "Id Diário:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 50);
            this.label6.TabIndex = 14;
            this.label6.Text = "Diário das O.S";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.txtIdDiario);
            this.groupBox1.Controls.Add(this.btnInserir);
            this.groupBox1.Controls.Add(this.cbOrdemServico);
            this.groupBox1.Controls.Add(this.txtOcorrencia);
            this.groupBox1.Controls.Add(diarioLabel);
            this.groupBox1.Controls.Add(idOrdemLabel);
            this.groupBox1.Controls.Add(this.txtIdOrdem);
            this.groupBox1.Controls.Add(assuntoLabel);
            this.groupBox1.Controls.Add(this.txtAssunto);
            this.groupBox1.Controls.Add(dataLabel);
            this.groupBox1.Controls.Add(this.dtOcorrencia);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(768, 552);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ocorrência do diário";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(429, 466);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(193, 37);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(230, 466);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(193, 37);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtIdDiario
            // 
            this.txtIdDiario.Enabled = false;
            this.txtIdDiario.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDiario.Location = new System.Drawing.Point(31, 57);
            this.txtIdDiario.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdDiario.Name = "txtIdDiario";
            this.txtIdDiario.Size = new System.Drawing.Size(83, 30);
            this.txtIdDiario.TabIndex = 14;
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnInserir.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(31, 466);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(193, 37);
            this.btnInserir.TabIndex = 12;
            this.btnInserir.Text = "Inserir ocorrência";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // cbOrdemServico
            // 
            this.cbOrdemServico.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrdemServico.FormattingEnabled = true;
            this.cbOrdemServico.Location = new System.Drawing.Point(122, 198);
            this.cbOrdemServico.Name = "cbOrdemServico";
            this.cbOrdemServico.Size = new System.Drawing.Size(617, 31);
            this.cbOrdemServico.TabIndex = 11;
            // 
            // txtOcorrencia
            // 
            this.txtOcorrencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOcorrencia.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOcorrencia.Location = new System.Drawing.Point(31, 267);
            this.txtOcorrencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtOcorrencia.Name = "txtOcorrencia";
            this.txtOcorrencia.Size = new System.Drawing.Size(708, 192);
            this.txtOcorrencia.TabIndex = 10;
            this.txtOcorrencia.Text = "";
            // 
            // txtIdOrdem
            // 
            this.txtIdOrdem.Enabled = false;
            this.txtIdOrdem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdOrdem.Location = new System.Drawing.Point(31, 198);
            this.txtIdOrdem.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdOrdem.Name = "txtIdOrdem";
            this.txtIdOrdem.Size = new System.Drawing.Size(83, 30);
            this.txtIdOrdem.TabIndex = 5;
            // 
            // txtAssunto
            // 
            this.txtAssunto.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssunto.Location = new System.Drawing.Point(31, 127);
            this.txtAssunto.Margin = new System.Windows.Forms.Padding(4);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(711, 30);
            this.txtAssunto.TabIndex = 3;
            // 
            // dtOcorrencia
            // 
            this.dtOcorrencia.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtOcorrencia.Location = new System.Drawing.Point(122, 59);
            this.dtOcorrencia.Margin = new System.Windows.Forms.Padding(4);
            this.dtOcorrencia.Name = "dtOcorrencia";
            this.dtOcorrencia.Size = new System.Drawing.Size(303, 30);
            this.dtOcorrencia.TabIndex = 1;
            // 
            // gdvDiarioOS
            // 
            this.gdvDiarioOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gdvDiarioOS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gdvDiarioOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvDiarioOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvDiarioOS.Location = new System.Drawing.Point(3, 23);
            this.gdvDiarioOS.Name = "gdvDiarioOS";
            this.gdvDiarioOS.RowHeadersWidth = 51;
            this.gdvDiarioOS.RowTemplate.Height = 24;
            this.gdvDiarioOS.Size = new System.Drawing.Size(860, 526);
            this.gdvDiarioOS.TabIndex = 16;
            this.gdvDiarioOS.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gdvDiarioOS_MouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gdvDiarioOS);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(800, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(866, 552);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ocorrências";
            // 
            // TelaDiarioOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 689);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaDiarioOS";
            this.Text = "Oficina VM";
            this.Load += new System.EventHandler(this.TelaDiarioOS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDiarioOS)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtOcorrencia;
        private System.Windows.Forms.TextBox txtIdOrdem;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.DateTimePicker dtOcorrencia;
        private System.Windows.Forms.DataGridView gdvDiarioOS;
        private System.Windows.Forms.ComboBox cbOrdemServico;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIdDiario;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
    }
}