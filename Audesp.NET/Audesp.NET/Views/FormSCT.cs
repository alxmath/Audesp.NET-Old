using Audesp.NET.Controllers;
using Audesp.NET.Models;
using Audesp.NET.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Audesp.NET
{
    public partial class FormSCT : Form
    {
        public FormSCT()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProcesso.Text.Trim()))
            {
                lblNotificacoes.Text = "Favor inserir o número do processo";
                return;
            }

            string processo = txtProcesso.Text.Trim();
            dgvEmpenhos.DataSource = null;

            try
            {
                var empenhos = new FormSCTController().GetByProcesso(processo);
                Fill(empenhos);
            }
            catch (Exception ex)
            {
                lblNotificacoes.Text =  ex.Message;
            }
        }

        private void Fill(List<Empenho> empenhos)
        {
            dgvEmpenhos.AutoGenerateColumns = false;

            dgvEmpenhos.ColumnCount = 12;

            dgvEmpenhos.Columns[0].Name = "Empenhos";
            dgvEmpenhos.Columns[0].DataPropertyName = "NumeroEmpenho";
            dgvEmpenhos.Columns[0].Width = 80;

            dgvEmpenhos.Columns[1].Name = "Ajuste";
            dgvEmpenhos.Columns[1].DataPropertyName = "CodigoAjuste";
            dgvEmpenhos.Columns[1].Width = 90;

            dgvEmpenhos.Columns[2].Name = "Desp.";
            dgvEmpenhos.Columns[2].DataPropertyName = "NaturezaDespesa";
            dgvEmpenhos.Columns[2].Width = 60;

            dgvEmpenhos.Columns[3].Name = "Modal.";
            dgvEmpenhos.Columns[3].DataPropertyName = "Modalidade";
            dgvEmpenhos.Columns[3].Width = 50;

            dgvEmpenhos.Columns[4].Name = "Valor";
            dgvEmpenhos.Columns[4].DataPropertyName = "Valor";
            dgvEmpenhos.Columns[4].DefaultCellStyle.Format = "C2";
            dgvEmpenhos.Columns[4].Width = 75;

            dgvEmpenhos.Columns[5].Name = "Pacote";
            dgvEmpenhos.Columns[5].DataPropertyName = "Pacote";
            dgvEmpenhos.Columns[5].Width = 60;

            dgvEmpenhos.Columns[6].Name = "Doc.";
            dgvEmpenhos.Columns[6].DataPropertyName = "Documento";
            dgvEmpenhos.Columns[6].Width = 60;

            //dgvEmpenhos.Columns[7].Name = "Sit.";
            //dgvEmpenhos.Columns[7].DataPropertyName = "Situacao";
            

            dgvEmpenhos.Columns[7].Name = "Vlr. Exec.";
            dgvEmpenhos.Columns[7].DataPropertyName = "ValorExecucoes";
            dgvEmpenhos.Columns[7].DefaultCellStyle.Format = "C2";
            dgvEmpenhos.Columns[7].Width = 75;

            dgvEmpenhos.Columns[8].Name = "Vlr. NFs";
            dgvEmpenhos.Columns[8].DataPropertyName = "ValorNfs";
            dgvEmpenhos.Columns[8].DefaultCellStyle.Format = "C2";
            dgvEmpenhos.Columns[8].Width = 75;

            dgvEmpenhos.Columns[9].Name = "Vlr. Pgtos";
            dgvEmpenhos.Columns[9].DataPropertyName = "ValorPagamentos";
            dgvEmpenhos.Columns[9].DefaultCellStyle.Format = "C2";
            dgvEmpenhos.Columns[9].Width = 75;

            dgvEmpenhos.Columns[10].Name = "Vlr. Rec.";
            dgvEmpenhos.Columns[10].DataPropertyName = "ValorRecolhimentos";
            dgvEmpenhos.Columns[10].DefaultCellStyle.Format = "C2";
            dgvEmpenhos.Columns[10].Width = 75;

            dgvEmpenhos.Columns[11].Name = "Vlr. Canc.";
            dgvEmpenhos.Columns[11].DataPropertyName = "ValorCancelamentos";
            dgvEmpenhos.Columns[11].DefaultCellStyle.Format = "C2";
            dgvEmpenhos.Columns[11].Width = 75;

            //dgvEmpenhos.Columns[12].Name = "Enc.";
            //dgvEmpenhos.Columns[12].DataPropertyName = "IsEncerrado";
            //dgvEmpenhos.Columns[12].CellTemplate = new DataGridViewCheckBoxCell();
            //dgvEmpenhos.Columns[12].Width = 55;

            DataGridViewButtonColumn colAjuste = new DataGridViewButtonColumn();
            colAjuste.UseColumnTextForButtonValue = true;
            colAjuste.Text = "Ajuste";
            //colAjuste.Name = "Ajuste";
            colAjuste.Width = 75;
            dgvEmpenhos.Columns.Add(colAjuste);

            DataGridViewButtonColumn colEmpenho = new DataGridViewButtonColumn();
            colEmpenho.UseColumnTextForButtonValue = true;
            colEmpenho.Text = "Empenho";
            //colEmpenho.Name = "Empenho";
            colEmpenho.Width = 75;
            dgvEmpenhos.Columns.Add(colEmpenho);

            DataGridViewButtonColumn colExecucao = new DataGridViewButtonColumn();
            colExecucao.UseColumnTextForButtonValue = true;
            colExecucao.Text = "Execução";
            //colExecucao.Name = "Execução";
            colExecucao.Width = 75;
            dgvEmpenhos.Columns.Add(colExecucao);

            DataGridViewButtonColumn colDocFiscal = new DataGridViewButtonColumn();
            colDocFiscal.UseColumnTextForButtonValue = true;
            colDocFiscal.Text = "Doc. Fiscal";
            //colDocFiscal.Name = "Doc. Fiscal";
            colDocFiscal.Width = 75;
            dgvEmpenhos.Columns.Add(colDocFiscal);

            DataGridViewButtonColumn colPagamento = new DataGridViewButtonColumn();
            colPagamento.UseColumnTextForButtonValue = true;
            colPagamento.Text = "Pagamento";
            //colPagamento.Name = "Pagamento";
            colPagamento.Width = 75;
            dgvEmpenhos.Columns.Add(colPagamento);

            dgvEmpenhos.DataSource = empenhos;
        }

        private void dgvEmpenhos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmpenhos.Rows.Count == 0)
            {
                return;
            }

            if (e.ColumnIndex == 12)
            {
                Empenho currentEmpenho = (Empenho)dgvEmpenhos.CurrentRow.DataBoundItem;
                var formAjuste = new FormAjuste(currentEmpenho);
                formAjuste.ShowDialog();

            }

            if (e.ColumnIndex == 13)
            {
                lblNotificacoes.Text = "Empenho";
            }

            if (e.ColumnIndex == 14)
            {
                lblNotificacoes.Text = "Execução";
            }

            if (e.ColumnIndex == 15)
            {
                lblNotificacoes.Text = "Documento Fiscal";
            }

            if (e.ColumnIndex == 16)
            {
                lblNotificacoes.Text = "Pagamento";
            }
        }

        private void txtProcesso_TextChanged(object sender, EventArgs e)
        {
            lblNotificacoes.Text = string.Empty;
        }

        private void txtProcesso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void FormSCT_Load(object sender, EventArgs e)
        {
            TabControlPrincipal.SelectedTab.Name = "TabAjuste";
        }
    }
}
