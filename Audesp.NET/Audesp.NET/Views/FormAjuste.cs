using Audesp.NET.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Audesp.NET.Views
{
    public partial class FormAjuste : Form
    {

        public Empenho Empenho { get; set; }
        public FormAjuste(Empenho empenho)
        {
            InitializeComponent();
            Empenho = empenho;
        }

        private void FormAjuste_Load(object sender, EventArgs e)
        {
            txtEmpenho.Text = Empenho.NumeroEmpenho;
        }

        private void btnTransmitir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmpenho.Text.Trim()))
            {
                lblNotificacoes.Text = "Favor preencher o número do empenho.";
                txtEmpenho.Focus();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPreencherLotes_Click(object sender, EventArgs e)
        {

        }
    }
}
