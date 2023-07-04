using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoDeDesignPatterns.Strategy.Interfaces;
namespace CursoDeDesignPatterns.Strategy
{
    public class ISS : Imposto
    {
        public ISS(Imposto outroImposto) : base(outroImposto) { }
        public ISS() : base()
        {

        }
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + calculoDoOutroImposto(orcamento);
        }


    }
}