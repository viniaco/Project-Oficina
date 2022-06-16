
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
            this.btnCadCliente = new System.Windows.Forms.ToolStripDropDownButton();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadVeiculo = new System.Windows.Forms.ToolStripDropDownButton();
            this.veiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordemDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgendamento = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btnCaixa = new System.Windows.Forms.ToolStripDropDownButton();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orçamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.panelForms = new System.Windows.Forms.Panel();
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
            this.btnCaixa,
            this.btnSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(825, 55);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCadCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.usuárioToolStripMenuItem});
            this.btnCadCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCadCliente.Image")));
            this.btnCadCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCadCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Size = new System.Drawing.Size(62, 52);
            this.btnCadCliente.Text = "Cadastrar Cliente";
            this.btnCadCliente.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.clienteToolStripMenuItem.Text = "Cadastrar Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.usuárioToolStripMenuItem.Text = "Cadastrar Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // btnCadVeiculo
            // 
            this.btnCadVeiculo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCadVeiculo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veiculosToolStripMenuItem,
            this.ordemDeServiçoToolStripMenuItem});
            this.btnCadVeiculo.Image = global::WF_OficinaTcc.Properties.Resources.icons8_serviço_de_carro_48;
            this.btnCadVeiculo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadVeiculo.Name = "btnCadVeiculo";
            this.btnCadVeiculo.Size = new System.Drawing.Size(62, 52);
            this.btnCadVeiculo.Text = "Cadastrar Veiculo";
            this.btnCadVeiculo.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // veiculosToolStripMenuItem
            // 
            this.veiculosToolStripMenuItem.Name = "veiculosToolStripMenuItem";
            this.veiculosToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.veiculosToolStripMenuItem.Text = "Veiculos";
            this.veiculosToolStripMenuItem.Click += new System.EventHandler(this.veiculosToolStripMenuItem_Click);
            // 
            // ordemDeServiçoToolStripMenuItem
            // 
            this.ordemDeServiçoToolStripMenuItem.Name = "ordemDeServiçoToolStripMenuItem";
            this.ordemDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.ordemDeServiçoToolStripMenuItem.Text = "Ordem de Serviço";
            this.ordemDeServiçoToolStripMenuItem.Click += new System.EventHandler(this.ordemDeServiçoToolStripMenuItem_Click);
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
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::WF_OficinaTcc.Properties.Resources.diary;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(52, 52);
            this.toolStripButton2.Text = "btnDiarioOS";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // btnCaixa
            // 
            this.btnCaixa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCaixa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caixaToolStripMenuItem,
            this.orçamentosToolStripMenuItem});
            this.btnCaixa.Image = global::WF_OficinaTcc.Properties.Resources.cash_register;
            this.btnCaixa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(62, 52);
            this.btnCaixa.Text = "Caixa";
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.caixaToolStripMenuItem.Text = "Caixa";
            // 
            // orçamentosToolStripMenuItem
            // 
            this.orçamentosToolStripMenuItem.Name = "orçamentosToolStripMenuItem";
            this.orçamentosToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.orçamentosToolStripMenuItem.Text = "Orçamentos";
            this.orçamentosToolStripMenuItem.Click += new System.EventHandler(this.orçamentosToolStripMenuItem_Click);
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
            this.panelForms.AutoSize = true;
            this.panelForms.BackColor = System.Drawing.Color.Transparent;
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms.Location = new System.Drawing.Point(0, 55);
            this.panelForms.Margin = new System.Windows.Forms.Padding(4);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(825, 459);
            this.panelForms.TabIndex = 3;
            this.panelForms.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForms_Paint);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::WF_OficinaTcc.Properties.Resources.manutenção_1024x683;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 514);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.toolStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ToolStripButton btnAgendamento;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.ToolStripDropDownButton btnCadCliente;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton btnCadVeiculo;
        private System.Windows.Forms.ToolStripMenuItem veiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordemDeServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripDropDownButton btnCaixa;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orçamentosToolStripMenuItem;
    }
}