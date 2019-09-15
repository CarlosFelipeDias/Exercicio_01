using Exercicio.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio.Domain.Valueobjects
{
    public class NumeroConta
    {
        public string Numero { get; private set; }
        public TipoConta TipoConta { get; private set; }
    }
}
