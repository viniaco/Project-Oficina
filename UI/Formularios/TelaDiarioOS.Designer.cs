
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
            System.Windows.Forms.Label idServicoLabel;
            System.Windows.Forms.Label idOrdemLabel;
            System.Windows.Forms.Label assuntoLabel;
            System.Windows.Forms.Label dataLabel;
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLookupServico = new System.Windows.Forms.Button();
            this.btnLookupOrdem = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ocorrenciaRichTextBox = new System.Windows.Forms.RichTextBox();
            this.idServicoTextBox = new System.Windows.Forms.TextBox();
            this.idOrdemTextBox = new System.Windows.Forms.TextBox();
            this.assuntoTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            diarioLabel = new System.Windows.Forms.Label();
            idServicoLabel = new System.Windows.Forms.Label();
            idOrdemLabel = new System.Windows.Forms.Label();
            assuntoLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 40);
            this.label6.TabIndex = 14;
            this.label6.Text = "Diário das O.S";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLookupServico);
            this.groupBox1.Controls.Add(this.btnLookupOrdem);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.ocorrenciaRichTextBox);
            this.groupBox1.Controls.Add(diarioLabel);
            this.groupBox1.Controls.Add(idServicoLabel);
            this.groupBox1.Controls.Add(this.idServicoTextBox);
            this.groupBox1.Controls.Add(idOrdemLabel);
            this.groupBox1.Controls.Add(this.idOrdemTextBox);
            this.groupBox1.Controls.Add(assuntoLabel);
            this.groupBox1.Controls.Add(this.assuntoTextBox);
            this.groupBox1.Controls.Add(dataLabel);
            this.groupBox1.Controls.Add(this.dataDateTimePicker);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 359);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ocorrência do diário";
            // 
            // btnLookupServico
            // 
            this.btnLookupServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookupServico.Location = new System.Drawing.Point(529, 158);
            this.btnLookupServico.Name = "btnLookupServico";
            this.btnLookupServico.Size = new System.Drawing.Size(28, 20);
            this.btnLookupServico.TabIndex = 14;
            this.btnLookupServico.Text = "...";
            this.btnLookupServico.UseVisualStyleBackColor = true;
            // 
            // btnLookupOrdem
            // 
            this.btnLookupOrdem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookupOrdem.Location = new System.Drawing.Point(529, 119);
            this.btnLookupOrdem.Name = "btnLookupOrdem";
            this.btnLookupOrdem.Size = new System.Drawing.Size(28, 20);
            this.btnLookupOrdem.TabIndex = 13;
            this.btnLookupOrdem.Text = "...";
            this.btnLookupOrdem.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(433, 22);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(433, 22);
            this.textBox1.TabIndex = 11;
            // 
            // ocorrenciaRichTextBox
            // 
            this.ocorrenciaRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ocorrenciaRichTextBox.Location = new System.Drawing.Point(26, 197);
            this.ocorrenciaRichTextBox.Name = "ocorrenciaRichTextBox";
            this.ocorrenciaRichTextBox.Size = new System.Drawing.Size(531, 156);
            this.ocorrenciaRichTextBox.TabIndex = 10;
            this.ocorrenciaRichTextBox.Text = "";
            // 
            // diarioLabel
            // 
            diarioLabel.AutoSize = true;
            diarioLabel.Location = new System.Drawing.Point(23, 181);
            diarioLabel.Name = "diarioLabel";
            diarioLabel.Size = new System.Drawing.Size(65, 13);
            diarioLabel.TabIndex = 8;
            diarioLabel.Text = "Ocorrência:";
            // 
            // idServicoLabel
            // 
            idServicoLabel.AutoSize = true;
            idServicoLabel.Location = new System.Drawing.Point(23, 142);
            idServicoLabel.Name = "idServicoLabel";
            idServicoLabel.Size = new System.Drawing.Size(60, 13);
            idServicoLabel.TabIndex = 6;
            idServicoLabel.Text = "id Servico:";
            // 
            // idServicoTextBox
            // 
            this.idServicoTextBox.Location = new System.Drawing.Point(23, 158);
            this.idServicoTextBox.Name = "idServicoTextBox";
            this.idServicoTextBox.Size = new System.Drawing.Size(63, 22);
            this.idServicoTextBox.TabIndex = 7;
            // 
            // idOrdemLabel
            // 
            idOrdemLabel.AutoSize = true;
            idOrdemLabel.Location = new System.Drawing.Point(23, 103);
            idOrdemLabel.Name = "idOrdemLabel";
            idOrdemLabel.Size = new System.Drawing.Size(58, 13);
            idOrdemLabel.TabIndex = 4;
            idOrdemLabel.Text = "id Ordem:";
            // 
            // idOrdemTextBox
            // 
            this.idOrdemTextBox.Location = new System.Drawing.Point(23, 119);
            this.idOrdemTextBox.Name = "idOrdemTextBox";
            this.idOrdemTextBox.Size = new System.Drawing.Size(63, 22);
            this.idOrdemTextBox.TabIndex = 5;
            // 
            // assuntoLabel
            // 
            assuntoLabel.AutoSize = true;
            assuntoLabel.Location = new System.Drawing.Point(23, 64);
            assuntoLabel.Name = "assuntoLabel";
            assuntoLabel.Size = new System.Drawing.Size(51, 13);
            assuntoLabel.TabIndex = 2;
            assuntoLabel.Text = "assunto:";
            // 
            // assuntoTextBox
            // 
            this.assuntoTextBox.Location = new System.Drawing.Point(23, 80);
            this.assuntoTextBox.Name = "assuntoTextBox";
            this.assuntoTextBox.Size = new System.Drawing.Size(534, 22);
            this.assuntoTextBox.TabIndex = 3;
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(23, 25);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(34, 13);
            dataLabel.TabIndex = 0;
            dataLabel.Text = "Data:";
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.Location = new System.Drawing.Point(23, 41);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(228, 22);
            this.dataDateTimePicker.TabIndex = 1;
            // 
            // TelaDiarioOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 469);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Name = "TelaDiarioOS";
            this.Text = "TelaAgendamento";
            this.Load += new System.EventHandler(this.TelaAgendamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLookupServico;
        private System.Windows.Forms.Button btnLookupOrdem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox ocorrenciaRichTextBox;
        private System.Windows.Forms.TextBox idServicoTextBox;
        private System.Windows.Forms.TextBox idOrdemTextBox;
        private System.Windows.Forms.TextBox assuntoTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
    }
}