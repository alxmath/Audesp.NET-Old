using System;
using System.Collections.Generic;
using System.Text;

namespace Audesp.NET.Models
{
    public struct Publicacao
    {
        public enum Veiculo
        {
            DOU = 1,
            JornalGrandeCirculacaoNacional,
            OutrosSites,
            JornalGrandeCirculacaoRegional,
            DOE,
            SiteAdministracaoDireta,
            DOM,
            QuadroMural,
            DJE
        }

        bool hasPublicacao;
        Veiculo veiculo;
        DateTime dataPublicacao;
        string descricaoPublicacao;

        public Publicacao(bool hasPublicacao, Veiculo veiculo,
            DateTime dataPublicacao, string descricaoPublicacao)
        {
            this.hasPublicacao = hasPublicacao;
            this.veiculo = veiculo;
            this.dataPublicacao = dataPublicacao;
            this.descricaoPublicacao = descricaoPublicacao;
        }
    }
}
