using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Audesp.NET.Models
{
    public class EmpenhoOld : ModuloAudesp
    {
        public enum TipoAjuste
        {
            Contrato, // 0
            Empenho  //  1
        }

        public enum TipoDocumento
        {
            Cnpj,
            Cpf,
            OutroDoc
        }

        public enum Vigencia
        {
            Meses,
            Data
        }

        public string NumeroEmpenho { get; set; }
        public string TipoLicitacao { get; set; }
        public string NumeroLicitacao { get; set; }
        public DateTime Emissao { get; set; }
        public string CredorDocumento { get; set; }
        public string FonteRecursos { get; set; }
        public string NaturezaDespesa { get; set; }
        public string Processo { get; set; }
        public decimal Valor { get; set; }
        public TipoAjuste Modalidade { get; set; }
        public DateTime DataEstimadaEntrega { get; set; }
        public string CodigoAjuste { get; set; }
        public string CodigoAudespLicitacao { get; set; }
        public decimal ValorExecucoes { get; set; }
        public decimal ValorNfs { get; set; }
        public decimal ValorPagamentos { get; set; }
        public decimal ValorRecolhimentos { get; set; }
        public decimal ValorCancelamentos { get; set; }
        public string NumeroContratoAdministrativo { get; set; }
        public string AnoContratoAdministrativo { get; set; }
        public string ObjetoContrato { get; set; }
        public double QuantidadeContrato { get; set; }
        public string UnidadeContrato { get; set; }
        public Vigencia TipoVigencia { get; set; }
        public Garantia Garantia { get; set; }
        public Gestor Gestor { get; set; }
        public bool HasClausulaPenal { get; set; } = true;
        public Publicacao Publicacao { get; set; }
        public string ClausulaFinanceira { get; set; }
        public string CodigoClassificacaoEconomica { get; set; }
        public List<EmpenhoItemOld> Itens { get; set; } = new List<EmpenhoItemOld>();
        public TipoDocumento TipoDocumentoCredor
        {
            get  
            {
                if(CredorDocumento.Length == 11)
                {
                    return TipoDocumento.Cpf; 

                }
                else if (CredorDocumento.Length == 14)
                {
                    return TipoDocumento.Cnpj;
                }
                else
                {
                    return TipoDocumento.OutroDoc;
                }
            }
        }

        public override string ToString()
        {
            return $"Número: {NumeroEmpenho}\nTipo da licitação: {TipoLicitacao}\n" +
                   $"Número da licitação: {NumeroLicitacao}\nEmissão:: {Emissao}\n" +
                   $"Documento do credor: {CredorDocumento}\nTipo do documento: {TipoDocumentoCredor}\n" +
                   $"Fonte de recursos: {FonteRecursos}\nNatureza de despesa: {NaturezaDespesa}\n" +
                   $"Processo: {Processo}\nValor: {Valor}\nModalidade: {Modalidade}\n" +
                   $"Entrega: {DataEstimadaEntrega}\nCódigo do ajuste: {CodigoAjuste}\n" +
                   $"Código Audesp Licitação: {CodigoAudespLicitacao}\n" +
                   $"Pacote: {Pacote}\nDocumento: {Documento}\nData Transmissao: {null}\n" +
                   $"Situação: {Situacao}\nEncerrado: {IsEncerrado}\n" +
                   $"Valor da execuções: {ValorExecucoes}\nValor dos documentos fiscais: {ValorNfs}\n" +
                   $"Valor dos pagamentos: {ValorPagamentos}\nValor dos recolhimentos: {ValorRecolhimentos}\n" +
                   $"Valor dos cancelamentos: {ValorCancelamentos}";
        }

    }
}
