﻿
namespace WF_OficinaTcc
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.aaaaaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCadCliente = new System.Windows.Forms.ToolStripButton();
            this.btnCadVeiculo = new System.Windows.Forms.ToolStripButton();
            this.btnAgendamento = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.panelForms = new System.Windows.Forms.Panel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(83, 22);
            this.toolStripComboBox1.Text = "Cadastro";
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // aaaaaaToolStripMenuItem
            // 
            this.aaaaaaToolStripMenuItem.Name = "aaaaaaToolStripMenuItem";
            this.aaaaaaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aaaaaaToolStripMenuItem.Text = "aaaaaa";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "Cadastro";
            this.toolStripDropDownButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testeToolStripMenuItem.Text = "teste";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadCliente,
            this.btnCadVeiculo,
            this.btnAgendamento,
            this.toolStripButton2,
            this.btnSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1177, 55);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCadCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCadCliente.Image")));
            this.btnCadCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCadCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Size = new System.Drawing.Size(52, 52);
            this.btnCadCliente.Text = "Cadastrar Cliente";
            this.btnCadCliente.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btnCadVeiculo
            // 
            this.btnCadVeiculo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCadVeiculo.Image = global::WF_OficinaTcc.Properties.Resources.icons8_serviço_de_carro_48;
            this.btnCadVeiculo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadVeiculo.Name = "btnCadVeiculo";
            this.btnCadVeiculo.Size = new System.Drawing.Size(52, 52);
            this.btnCadVeiculo.Text = "Cadastrar Veiculo";
            this.btnCadVeiculo.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // btnAgendamento
            // 
            this.btnAgendamento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgendamento.Image = global::WF_OficinaTcc.Properties.Resources.icons8_tarefa_48;
            this.btnAgendamento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgendamento.Name = "btnAgendamento";
            this.btnAgendamento.Size = new System.Drawing.Size(52, 52);
            this.btnAgendamento.Text = "Agendamento";
            this.btnAgendamento.Click += new System.EventHandler(this.btnAgendamento_Click);
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = global::WF_OficinaTcc.Properties.Resources.icons8_cancelar_48;
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(52, 52);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // panelForms
            // 
            this.panelForms.BackColor = System.Drawing.Color.Transparent;
            this.panelForms.Location = new System.Drawing.Point(12, 58);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(908, 534);
            this.panelForms.TabIndex = 3;
            this.panelForms.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForms_Paint);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(52, 52);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WF_OficinaTcc.Properties.Resources.Capa_blog;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1177, 604);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.toolStrip1);
            this.Name = "TelaPrincipal";
            this.Text = "TelaPrincipal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripDropDownButton toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem aaaaaaToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCadCliente;
        private System.Windows.Forms.ToolStripButton btnCadVeiculo;
        private System.Windows.Forms.ToolStripButton btnAgendamento;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}