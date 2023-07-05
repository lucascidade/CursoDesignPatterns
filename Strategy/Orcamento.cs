using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoDeDesignPatterns.ChainsOfResposability;
using CursoDeDesignPatterns.Interfaces;
using CursoDeDesignPatterns.State;

namespace CursoDeDesignPatterns
{
    public class Orcamento
    {
        public EstadosDeUmOrcamento EstadoAtual { get; set; }
        public double Valor { get; set; }
        public IList<Item> Itens { get; set; }
        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
            EstadoAtual = new EmAprovacao();
        }
        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }

        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}