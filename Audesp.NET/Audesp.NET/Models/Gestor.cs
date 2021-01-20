using System;
using System.Collections.Generic;
using System.Text;

namespace Audesp.NET.Models
{
    public struct Gestor
    {
        bool isExigido;
        string cpf;
        string cargo;


        public Gestor(bool isExigido, string cpf, string cargo)
        {
            this.isExigido = isExigido;
            this.cpf = cpf;
            this.cargo = cargo;
        }
    }
}
