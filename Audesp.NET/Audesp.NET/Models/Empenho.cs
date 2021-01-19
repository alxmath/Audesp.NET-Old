using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Audesp.NET.Models
{
    public class Empenho
    {
        [DisplayName("Empenho")]
        public string NumeroEmpenho { get; set; }

        [DisplayName("Tipo Licit.")]
        public string TipoLicitacao { get; set; }

        [DisplayName("Licit.")]
        public string NumeroLicitacao { get; set; }

        [DisplayName("Emissão")]
        public DateTime Emissao { get; set; }

        [DisplayName("Credor")]
        public string CredorDocumento { get; set; }

        [DisplayName("Fonte Rec.")]
        public string FonteRecursos { get; set; }

        [DisplayName("Nat. Desp.")]
        public string NaturezaDespesa { get; set; }

        [DisplayName("Processo")]
        public string Processo { get; set; }

        [DisplayName("Valor")]
        public decimal Valor { get; set; }

        [DisplayName("Modalidade")]
        public string Modalidade { get; set; }

        [DisplayName("Qtd. Contrato")]
        public double QuantidadeContrato { get; set; }

        [DisplayName("Und. Contrato")]
        public string UnidadeContrato { get; set; }

        [DisplayName("Entrega")]
        public DateTime DataEstimadaEntrega { get; set; }

        [DisplayName("Cod. Ajuste")]
        public string CodigoAjuste { get; set; }

        [DisplayName("Pacote")]
        public string Pacote { get; set; }

        public string Documento { get; set; }

        [DisplayName("Situação")]
        public string Situacao { get; set; }

        [DisplayName("Vlr. Exec.")]
        public decimal ValorExecucoes { get; set; }

        [DisplayName("Vlr. NFs")]
        public decimal ValorNfs { get; set; }

        [DisplayName("Vlr. Pgtos")]
        public decimal ValorPagamentos { get; set; }

        [DisplayName("Vlr. Rec.")]
        public decimal ValorRecolhimentos { get; set; }

        [DisplayName("Vlr. Canc.")]
        public decimal ValorCancelamentos { get; set; }

        [DisplayName("Encerrado")]
        public bool IsEncerrado { get; set; }

        public List<EmpenhoItem> Itens { get; set; } = new List<EmpenhoItem>();
    }
}
