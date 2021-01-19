using Audesp.NET.Controllers;
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


        public FormAjusteController AjusteController { get; } = new FormAjusteController();
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
            var licitacao = AjusteController.ParseLicitacaoFromHtml();

            if (licitacao == null) return;

            txtLicitacao.Text = licitacao.NumeroLicitacao;
            txtCodigoAudespLicitacao.Text = licitacao.NumeroLicitacao;

            Fill(licitacao.Lotes);

            
        }

        private void Fill(List<Lote> lotes)
        {
            dgvLotesLicitacao.DataSource = null;
            dgvLotesLicitacao.AutoGenerateColumns = false;
            dgvLotesLicitacao.ColumnCount = 4;

            dgvLotesLicitacao.Columns[0].Name = "#";
            dgvLotesLicitacao.Columns[0].DataPropertyName = "Sequencia";
            dgvLotesLicitacao.Columns[0].Width = 30;

            dgvLotesLicitacao.Columns[1].Name = "Siafisico";
            dgvLotesLicitacao.Columns[1].DataPropertyName = "LoteSiafisico";
            dgvLotesLicitacao.Columns[1].Width = 65;

            dgvLotesLicitacao.Columns[2].Name = "Quantidade";
            dgvLotesLicitacao.Columns[2].DataPropertyName = "Quantidade";
            dgvLotesLicitacao.Columns[2].DefaultCellStyle.Format = "N2";
            dgvLotesLicitacao.Columns[2].Width = 75;

            dgvLotesLicitacao.Columns[3].Name = "Valor";
            dgvLotesLicitacao.Columns[3].DataPropertyName = "ValorNegociado";
            dgvLotesLicitacao.Columns[3].DefaultCellStyle.Format = "C2";
            dgvLotesLicitacao.Columns[3].Width = 65;

            DataGridViewButtonColumn colAction = new DataGridViewButtonColumn();
            colAction.UseColumnTextForButtonValue = true;
            colAction.Text = ">>";
            colAction.Width = 75;
            dgvLotesLicitacao.Columns.Add(colAction);

            dgvLotesLicitacao.DataSource = lotes;


        }
    }
}
