using System;
using System.Collections.Generic;
using System.Text;

namespace Audesp.NET.Models
{
    public class Licitacao
    {
        public string NumeroLicitacao { get; set; }
        public string CodigoAudespLicitacao { get; set; }
        public List<Lote> Lotes { get; } = new List<Lote>();
        public string Tipo { get; set; }

        public void Add(Lote item)
        {
            Lotes.Add(item);
        }
    }
}
