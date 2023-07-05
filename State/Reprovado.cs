using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoDeDesignPatterns.Interfaces;

namespace CursoDeDesignPatterns.State
{
    public class Reprovado : EstadosDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados/finalizados não recebem desconto.");
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("O orçamento já se encontra em estado de REPROVAÇÃO");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}