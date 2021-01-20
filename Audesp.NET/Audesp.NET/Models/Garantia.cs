using System;
using System.Collections.Generic;
using System.Text;

namespace Audesp.NET.Models
{
    public struct Garantia
    {
        bool isExigida;
        decimal valor;
        double percentagem;
        string clausula;

        public Garantia(bool isExigida, decimal valor, double percentagem, string clausula)
        {
            this.isExigida = isExigida;
            this.valor = valor;
            this.percentagem = percentagem;
            this.clausula = clausula;
        }
    }
}
