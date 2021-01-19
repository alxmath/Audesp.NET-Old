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

    }
}
