using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoDeDesignPatterns.Interfaces
{
    public interface Desconto
    {
        public double Desconta(Orcamento orcamento);
        Desconto Proximo { get; set; }
    }
}