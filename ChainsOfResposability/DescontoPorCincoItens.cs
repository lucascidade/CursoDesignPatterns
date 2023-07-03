using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoDeDesignPatterns.Interfaces;

namespace CursoDeDesignPatterns.ChainsOfResposability
{
    public class DescontoPorCincoItens : Desconto
    {
        public Desconto Proximo { get; set; }
        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5) return orcamento.Valor * 0.10;

            return Proximo.Desconta(orcamento);
        }

    }
}