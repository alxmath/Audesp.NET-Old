using System;
using System.Collections.Generic;
using System.Text;

namespace Audesp.NET.Models
{
    public class Lote
    {
        public int Sequencia { get; set; } // sequencia
        public string LoteSiafisico { get; set; }
        public double Quantidade { get; set; }
        public decimal ValorNegociado { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Lote lote &&
                   Sequencia == lote.Sequencia;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Sequencia);
        }

        public override string ToString()
        {
            return $"#{Sequencia} - Siafisico:{LoteSiafisico}, Quantidade: {Quantidade:N2}, Valor: {ValorNegociado:C2}";
        }
    }
}
