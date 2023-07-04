using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoDeDesignPatterns.ChainsOfResposability;
using CursoDeDesignPatterns.Strategy.Interfaces;

namespace CursoDeDesignPatterns.TemplateMethod
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        public IKCV(Imposto outroImposto) : base(outroImposto) { }
        public IKCV() : base() { }
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && temItemMaiorQue100ReaisNo(orcamento);
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + calculoDoOutroImposto(orcamento);
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + calculoDoOutroImposto(orcamento);
        }

        public bool temItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Valor > 100) return true;
            }
            return false;
        }
    }
}