using System;
using System.Collections.Generic;
using System.Text;

namespace Audesp.NET.Models
{
    public class ModuloAudesp
    {
        public string Pacote { get; set; }
        public string Documento { get; set; }
        public string Situacao { get; set; }
        public DateTime DataTransmissao { get; set; }
        public bool IsEncerrado { get; set; }
    }
}
