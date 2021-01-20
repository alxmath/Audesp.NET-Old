using Audesp.NET.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Audesp.NET.Models
{
    public abstract class ModuloXML : IXmlable
    {
        public abstract void GerarXML();
    }
}
