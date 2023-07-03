using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoDeDesignPatterns.ChainsOfResposability;

namespace CursoDeDesignPatterns
{
    public class Orcamento
    {

        public double Valor { get; private set; }
        public IList<Item> Itens { get; set; }
        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
        }
        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}