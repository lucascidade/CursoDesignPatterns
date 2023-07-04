using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoDeDesignPatterns.Strategy.Interfaces
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }
        public Imposto()
        {
            OutroImposto = null;
        }
        public Imposto(Imposto outroImposto)
        {
            OutroImposto = outroImposto;
        }
        public abstract double Calcula(Orcamento orcamento);

        protected double calculoDoOutroImposto(Orcamento orcamento)
        {
            return OutroImposto == null ? 0 : OutroImposto.Calcula(orcamento);
        }
    }
}