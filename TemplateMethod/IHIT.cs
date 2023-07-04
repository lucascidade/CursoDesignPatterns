using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using CursoDeDesignPatterns.ChainsOfResposability;
using CursoDeDesignPatterns.Strategy.Interfaces;

namespace CursoDeDesignPatterns.TemplateMethod
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        public IHIT(Imposto outroImposto) : base(outroImposto) { }
        public IHIT() : base() { }

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {

            IList<String> noOrcamento = new List<String>();

            foreach (Item item in orcamento.Itens)
            {
                if (noOrcamento.Contains(item.Nome))
                    return true;
                else
                    noOrcamento.Add(item.Nome);
            }
            return false;
        }
        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100 + calculoDoOutroImposto(orcamento);

        }
        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.01 * orcamento.Itens.Count + calculoDoOutroImposto(orcamento);

        }

    }
}