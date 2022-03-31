﻿using System;
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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private Form Tela;

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Tela?.Close();
            Tela = new TelaCliente
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
            };
            panelForms.Controls.Add(Tela);
            Tela.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Tela?.Close();
            Tela = new TelaVeiculo
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
            };
            panelForms.Controls.Add(Tela);
            Tela.Show();
        }

        private void panelForms_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
           // this.TopMost = true;

            //this.FormBorderStyle = FormBorderStyle.None; // Full-Screen 

           // this.WindowState = FormWindowState.Maximized;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAgendamento_Click(object sender, EventArgs e)
        {
            Tela?.Close();
            Tela = new TelaOS
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
            };
            panelForms.Controls.Add(Tela);
            Tela.Show();

        }
    }
}