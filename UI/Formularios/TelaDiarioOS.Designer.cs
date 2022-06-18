
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
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOcorrencia = new System.Windows.Forms.RichTextBox();
            this.txtIdOrdem = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.dtOcorrencia = new System.Windows.Forms.DateTimePicker();
            this.gdvDiarioOS = new System.Windows.Forms.DataGridView();
            this.cbOrdemServico = new System.Windows.Forms.ComboBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIdDiario = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
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
            diarioLabel.Location = new System.Drawing.Point(27, 187);
            diarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            diarioLabel.Name = "diarioLabel";
            diarioLabel.Size = new System.Drawing.Size(87, 19);
            diarioLabel.TabIndex = 8;
            diarioLabel.Text = "Ocorrência:";
            // 
            // idOrdemLabel
            // 
            idOrdemLabel.AutoSize = true;
            idOrdemLabel.Location = new System.Drawing.Point(31, 127);
            idOrdemLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idOrdemLabel.Name = "idOrdemLabel";
            idOrdemLabel.Size = new System.Drawing.Size(77, 19);
            idOrdemLabel.TabIndex = 4;
            idOrdemLabel.Text = "id Ordem:";
            // 
            // assuntoLabel
            // 
            assuntoLabel.AutoSize = true;
            assuntoLabel.Location = new System.Drawing.Point(31, 79);
            assuntoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            assuntoLabel.Name = "assuntoLabel";
            assuntoLabel.Size = new System.Drawing.Size(65, 19);
            assuntoLabel.TabIndex = 2;
            assuntoLabel.Text = "Assunto:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(122, 32);
            dataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(44, 19);
            dataLabel.TabIndex = 0;
            dataLabel.Text = "Data:";
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
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(768, 459);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ocorrência do diário";
            // 
            // txtOcorrencia
            // 
            this.txtOcorrencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOcorrencia.Location = new System.Drawing.Point(31, 206);
            this.txtOcorrencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOcorrencia.Name = "txtOcorrencia";
            this.txtOcorrencia.Size = new System.Drawing.Size(708, 192);
            this.txtOcorrencia.TabIndex = 10;
            this.txtOcorrencia.Text = "";
            // 
            // txtIdOrdem
            // 
            this.txtIdOrdem.Enabled = false;
            this.txtIdOrdem.Location = new System.Drawing.Point(31, 146);
            this.txtIdOrdem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdOrdem.Name = "txtIdOrdem";
            this.txtIdOrdem.Size = new System.Drawing.Size(83, 26);
            this.txtIdOrdem.TabIndex = 5;
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(31, 98);
            this.txtAssunto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(711, 26);
            this.txtAssunto.TabIndex = 3;
            // 
            // dtOcorrencia
            // 
            this.dtOcorrencia.Location = new System.Drawing.Point(122, 51);
            this.dtOcorrencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtOcorrencia.Name = "dtOcorrencia";
            this.dtOcorrencia.Size = new System.Drawing.Size(303, 26);
            this.dtOcorrencia.TabIndex = 1;
            // 
            // gdvDiarioOS
            // 
            this.gdvDiarioOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvDiarioOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvDiarioOS.Location = new System.Drawing.Point(3, 20);
            this.gdvDiarioOS.Name = "gdvDiarioOS";
            this.gdvDiarioOS.RowHeadersWidth = 51;
            this.gdvDiarioOS.RowTemplate.Height = 24;
            this.gdvDiarioOS.Size = new System.Drawing.Size(860, 436);
            this.gdvDiarioOS.TabIndex = 16;
            this.gdvDiarioOS.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gdvDiarioOS_MouseDoubleClick);
            // 
            // cbOrdemServico
            // 
            this.cbOrdemServico.FormattingEnabled = true;
            this.cbOrdemServico.Location = new System.Drawing.Point(122, 146);
            this.cbOrdemServico.Name = "cbOrdemServico";
            this.cbOrdemServico.Size = new System.Drawing.Size(617, 27);
            this.cbOrdemServico.TabIndex = 11;
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnInserir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(31, 405);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(151, 32);
            this.btnInserir.TabIndex = 12;
            this.btnInserir.Text = "Inserir ocorrência";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gdvDiarioOS);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(800, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(866, 459);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ocorrências";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(31, 30);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 19);
            label1.TabIndex = 13;
            label1.Text = "Id Diário:";
            // 
            // txtIdDiario
            // 
            this.txtIdDiario.Enabled = false;
            this.txtIdDiario.Location = new System.Drawing.Point(31, 49);
            this.txtIdDiario.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdDiario.Name = "txtIdDiario";
            this.txtIdDiario.Size = new System.Drawing.Size(83, 26);
            this.txtIdDiario.TabIndex = 14;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(188, 405);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(151, 32);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(345, 405);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(151, 32);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // TelaDiarioOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 566);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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