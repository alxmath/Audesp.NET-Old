using Audesp.NET.Controllers;
using Audesp.NET.Models;
//using Audesp.NET.Models;
using AudespNETModels.Models;
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
        public List<Lote> Lotes { get; set; } = new List<Lote>();
        public BindingList<Lote> LotesAjuste { get; set; }

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
            lblNotificacoes.Text = string.Empty;

            if (string.IsNullOrEmpty(txtEmpenho.Text.Trim()))
            {
                lblNotificacoes.Text = "Favor preencher o número do empenho.";
                txtEmpenho.Focus();
            }

            if (dgvLotesAjuste.Rows.Count == 0)
            {
                lblNotificacoes.Text = "Favor selecionar os itens do ajuste.";
                return;
            }

            // MessageBox.Show(Empenho.ToString());

            /***
             * TODO: se tipo for contrato, buscar dados;
             */

            Empenho.CodigoAudespLicitacao = txtCodigoAudespLicitacao.Text.Trim();
            Empenho.NumeroLicitacao = txtLicitacao.Text.Trim();

            AjusteXML ajusteXML = new AjusteXML(Empenho);
            ajusteXML.GerarXML();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPreencherLotes_Click(object sender, EventArgs e)
        {
            lblNotificacoes.Text = string.Empty;
            dgvLotesAjuste.DataSource = null;

            var licitacao = AjusteController.ParseLicitacaoFromHtml();

            if (licitacao == null) return;

            txtLicitacao.Text = licitacao.NumeroLicitacao;
            txtCodigoAudespLicitacao.Text = licitacao.CodigoAudespLicitacao;

            if (licitacao.Tipo == "L") lblNotificacoes.Text = "<< Licitação por Lotes >>";
            Lotes = licitacao.Lotes;

            Fill();
        }

        private void Fill()
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
            dgvLotesLicitacao.Columns[3].Width = 75;

            DataGridViewButtonColumn colAction = new DataGridViewButtonColumn();
            colAction.UseColumnTextForButtonValue = true;
            colAction.Text = ">>";
            colAction.Width = 75;
            dgvLotesLicitacao.Columns.Add(colAction);

            dgvLotesLicitacao.DataSource = Lotes;


        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            lblNotificacoes.Text = string.Empty;

            if (dgvLotesLicitacao.Rows.Count == 0) return;

            LotesAjuste = new BindingList<Lote>(Lotes);
            FillLoteAjuste(LotesAjuste);
        }

        private void FillLoteAjuste(BindingList<Lote> lotes)
        {
            dgvLotesAjuste.DataSource = null;
            dgvLotesAjuste.AutoGenerateColumns = false;
            dgvLotesAjuste.ColumnCount = 2;

            dgvLotesAjuste.Columns[0].Name = "#";
            dgvLotesAjuste.Columns[0].DataPropertyName = "Sequencia";
            dgvLotesAjuste.Columns[0].Width = 33;

            dgvLotesAjuste.Columns[1].Name = "Siafisico";
            dgvLotesAjuste.Columns[1].DataPropertyName = "LoteSiafisico";
            dgvLotesAjuste.Columns[1].Width = 60;

            DataGridViewButtonColumn colAction = new DataGridViewButtonColumn();
            colAction.UseColumnTextForButtonValue = true;
            colAction.Text = "Excluir";
            colAction.Width = 95;
            dgvLotesAjuste.Columns.Add(colAction);

            var source = new BindingSource(lotes, null);
            dgvLotesAjuste.DataSource = source;
        }

        private void dgvLotesAjuste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLotesAjuste.Rows.Count == 0)
            {
                return;
            }

            if (e.ColumnIndex == 2)
            {
                //Lote loteToRemove = (Lote)dgvLotesAjuste.CurrentRow.DataBoundItem;
                dgvLotesAjuste.Rows.RemoveAt(e.RowIndex);
                //LotesAjuste.Remove(loteToRemove);
                
            }
        }

        private void dgvLotesLicitacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLotesLicitacao.Rows.Count == 0)
            {
                return;
            }

            lblNotificacoes.Text = string.Empty;

            if (e.ColumnIndex == 4)
            {
                if (LotesAjuste == null)
                {
                    LotesAjuste = new BindingList<Lote>();
                }

                var loteToInsert = (Lote)dgvLotesLicitacao.CurrentRow.DataBoundItem;

                foreach (Lote lote in LotesAjuste)
                {
                    if (lote.Equals(loteToInsert))
                    {
                        lblNotificacoes.Text = "Item | Lote já inserido.";
                        return;
                    }
                }

                LotesAjuste.Add(loteToInsert);

                dgvLotesAjuste.DataSource = null;
                FillLoteAjuste(LotesAjuste);

            }
        }
    }
}
